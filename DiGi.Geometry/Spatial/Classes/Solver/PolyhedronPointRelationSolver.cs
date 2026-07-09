using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Classifies points against a closed polyhedron boundary as <see cref="PointRelation.Inside"/>,
    /// <see cref="PointRelation.On"/> or <see cref="PointRelation.Outside"/> using a prebuilt
    /// Bounding Volume Hierarchy (BVH) for accelerated parity ray-casting queries.
    /// <para>
    /// The solver is built once per polyhedron and reused for many point queries during constructive solid
    /// geometry (CSG) boolean operations. A single query answers Inside, On and Outside at once, avoiding the
    /// repeated face extraction, face cloning and bounding box recomputation that the general purpose
    /// <see cref="Polyhedron{TPolygonalFace3D}.Inside"/> and <see cref="Polyhedron{TPolygonalFace3D}.On"/>
    /// methods incur on every call.
    /// </para>
    /// <para>
    /// Not thread-safe: instances keep an internal scratch buffer and are intended for single-threaded use
    /// within one boolean operation.
    /// </para>
    /// </summary>
    internal class PolyhedronPointRelationSolver
    {
        // Non-axis-aligned unit ray directions used for parity ray casting. Components are irrational-like to
        // minimize the chance of hitting edges or vertices of axis-aligned geometry; subsequent directions are
        // only used when a cast is ambiguous (edge hit or in-plane segment).
        private static readonly double[][] rayDirections =
        [
            [0.2971170290, 0.5847102846, 0.7549241557],
            [-0.6154122094, 0.4898979485, 0.6172133998],
            [0.7071067811, -0.5773502691, 0.4082482904],
            [-0.3511234416, -0.6348325761, 0.6884421236],
            [0.7988316861, 0.4351237912, -0.4159012347],
            [-0.2810934512, 0.8432712345, -0.4564412378],
            [0.5270412346, -0.3162312345, -0.7888512346],
            [-0.5798812345, -0.6123712346, -0.5373012345]
        ];

        private readonly BVHNode<IPolygonalFace3D> bVHNode;
        private readonly BoundingBox3D? boundingBox3D;
        private readonly double tolerance;
        private readonly double rayLength;
        private readonly List<IPolygonalFace3D> polygonalFace3Ds_Scratch = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronPointRelationSolver"/> class.
        /// </summary>
        /// <param name="bVHNode">The prebuilt Bounding Volume Hierarchy (BVH) of the polyhedron faces. Its root box defines the query bounds.</param>
        /// <param name="tolerance">The distance tolerance used for On-boundary classification and crossing tests.</param>
        internal PolyhedronPointRelationSolver(BVHNode<IPolygonalFace3D> bVHNode, double tolerance)
        {
            this.bVHNode = bVHNode;
            this.tolerance = tolerance;

            boundingBox3D = bVHNode.Box;

            double diagonal = 0.0;
            if (boundingBox3D?.Min is Point3D point3D_Min && boundingBox3D?.Max is Point3D point3D_Max)
            {
                double dX = point3D_Max.X - point3D_Min.X;
                double dY = point3D_Max.Y - point3D_Min.Y;
                double dZ = point3D_Max.Z - point3D_Min.Z;
                diagonal = System.Math.Sqrt((dX * dX) + (dY * dY) + (dZ * dZ));
            }

            // Any chord of the bounding box is at most one diagonal long, so a ray of this length starting
            // anywhere inside the box is guaranteed to end outside it.
            rayLength = (diagonal * 1.5) + (System.Math.Abs(tolerance) * 10.0) + 1.0;
        }

        /// <summary>
        /// Gets the spatial relation of the specified point to the polyhedron boundary.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to classify.</param>
        /// <returns>A <see cref="PointRelation"/> value describing the relation of the point to the volume.</returns>
        internal PointRelation GetPointRelation(Point3D? point3D)
        {
            if (point3D == null || boundingBox3D == null)
            {
                return PointRelation.Undefined;
            }

            // A point further than 2 * tolerance (on any axis) from the bounding box can be neither on the
            // boundary nor inside the volume.
            if (!boundingBox3D.InRange(point3D, System.Math.Max(tolerance, 0.0) * 2.0))
            {
                return PointRelation.Outside;
            }

            if (On(point3D))
            {
                return PointRelation.On;
            }

            bool inside = false;
            for (int i = 0; i < rayDirections.Length; i++)
            {
                if (TryCountRayCrossings(point3D, rayDirections[i], out int count))
                {
                    return count % 2 == 1 ? PointRelation.Inside : PointRelation.Outside;
                }

                inside = count % 2 == 1;
            }

            // All ray directions were ambiguous (degenerate or non-manifold input) - fall back to the parity
            // of the last cast, counting only unambiguous crossings.
            return inside ? PointRelation.Inside : PointRelation.Outside;
        }

        private bool On(Point3D point3D)
        {
            polygonalFace3Ds_Scratch.Clear();
            polygonalFace3Ds_Scratch.AddOverlappingFaces(bVHNode, new BoundingBox3D(point3D, System.Math.Max(tolerance, 0.0) * 2.0), tolerance);

            for (int i = 0; i < polygonalFace3Ds_Scratch.Count; i++)
            {
                if (polygonalFace3Ds_Scratch[i].InRange(point3D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        private bool TryCountRayCrossings(Point3D point3D, double[] direction, out int count)
        {
            count = 0;

            Point3D point3D_End = new(point3D.X + (direction[0] * rayLength), point3D.Y + (direction[1] * rayLength), point3D.Z + (direction[2] * rayLength));

            polygonalFace3Ds_Scratch.Clear();
            polygonalFace3Ds_Scratch.AddOverlappingFaces(bVHNode, new BoundingBox3D(point3D, point3D_End), tolerance);

            for (int i = 0; i < polygonalFace3Ds_Scratch.Count; i++)
            {
                IPolygonalFace3D polygonalFace3D = polygonalFace3Ds_Scratch[i];

                Plane? plane = polygonalFace3D.Plane;
                if (plane?.Normal is not Vector3D vector3D_Normal || plane.Origin is not Point3D point3D_Origin)
                {
                    continue;
                }

                double distance_Start = (vector3D_Normal.X * (point3D.X - point3D_Origin.X)) + (vector3D_Normal.Y * (point3D.Y - point3D_Origin.Y)) + (vector3D_Normal.Z * (point3D.Z - point3D_Origin.Z));
                double distance_End = (vector3D_Normal.X * (point3D_End.X - point3D_Origin.X)) + (vector3D_Normal.Y * (point3D_End.Y - point3D_Origin.Y)) + (vector3D_Normal.Z * (point3D_End.Z - point3D_Origin.Z));

                if (System.Math.Abs(distance_Start) <= tolerance && System.Math.Abs(distance_End) <= tolerance)
                {
                    // The segment runs inside the face plane - parity counting is unreliable for this direction.
                    return false;
                }

                double denominator = distance_Start - distance_End;
                if (System.Math.Abs(denominator) < 1.0e-12)
                {
                    continue;
                }

                double t = distance_Start / denominator;
                if (t <= 0.0 || t > 1.0)
                {
                    continue;
                }

                Point3D point3D_Hit = new(point3D.X + (t * (point3D_End.X - point3D.X)), point3D.Y + (t * (point3D_End.Y - point3D.Y)), point3D.Z + (t * (point3D_End.Z - point3D.Z)));

                if (!polygonalFace3D.InRange(point3D_Hit, tolerance))
                {
                    continue;
                }

                if (polygonalFace3D.OnEdge(point3D_Hit, tolerance))
                {
                    // An edge or vertex hit would be double counted by adjacent faces - retry with another direction.
                    return false;
                }

                count++;
            }

            return true;
        }
    }
}
