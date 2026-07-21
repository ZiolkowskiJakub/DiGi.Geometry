using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersection result between a <see cref="Polyhedron{TPolygonalFace3D}"/> and an <see cref="ILinear3D"/>.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to check for intersection.</param>
        /// <param name="linear3D">The <see cref="ILinear3D"/> object to intersect with the polyhedron. Supported implementations are <see cref="Line3D"/>, <see cref="Ray3D"/> and <see cref="Segment3D"/>.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for calculations.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the intersection details, or <c>null</c> if either input is null, the linear type is not supported or the bounding box cannot be determined.</returns>
        public static IntersectionResult3D? IntersectionResult3D<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron, ILinear3D? linear3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron == null || linear3D == null)
            {
                return null;
            }

            BoundingBox3D? boundingBox3D = polyhedron.GetBoundingBox();
            if (boundingBox3D == null)
            {
                return null;
            }

            // Static typed dispatch - avoids the runtime binder cost and allocations of dynamic dispatch
            Line3D? line3D = linear3D as Line3D;
            Ray3D? ray3D = linear3D as Ray3D;
            Segment3D? segment3D_Linear = linear3D as Segment3D;

            if (line3D == null && ray3D == null && segment3D_Linear == null)
            {
                return null;
            }

            bool inRange = line3D != null ? boundingBox3D.InRange(line3D, tolerance) : ray3D != null ? boundingBox3D.InRange(ray3D, tolerance) : boundingBox3D.InRange(segment3D_Linear, tolerance);
            if (!inRange)
            {
                return new IntersectionResult3D();
            }

            List<Point3D> point3Ds = [];
            List<Segment3D> segment3Ds = [];
            for (int i = 0; i < polyhedron.Count; i++)
            {
                // GetPolygonalFace3D returns the internal face without cloning - the indexer would clone every face
                if (polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is not IPolygonalFace3D polygonalFace3D)
                {
                    continue;
                }

                PlanarIntersectionResult? planarIntersectionResult = line3D != null ? PlanarIntersectionResult(polygonalFace3D, line3D, tolerance) : ray3D != null ? PlanarIntersectionResult(polygonalFace3D, ray3D, tolerance) : PlanarIntersectionResult(polygonalFace3D, segment3D_Linear, tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Any())
                {
                    continue;
                }

                List<IGeometry3D>? iGeometry3Ds_Temp = planarIntersectionResult.GetGeometry3Ds<IGeometry3D>();
                if (iGeometry3Ds_Temp == null)
                {
                    continue;
                }

                foreach (IGeometry3D iGeometry3D in iGeometry3Ds_Temp)
                {
                    if (iGeometry3D is Point3D point3D)
                    {
                        bool similarExists = false;
                        for (int j = 0; j < point3Ds.Count; j++)
                        {
                            if (point3D.Similar(point3Ds[j], tolerance))
                            {
                                similarExists = true;
                                break;
                            }
                        }

                        if (!similarExists)
                        {
                            point3Ds.Add(point3D);
                        }
                    }
                    else if (iGeometry3D is Segment3D segment3D)
                    {
                        bool similarExists = false;
                        for (int j = 0; j < segment3Ds.Count; j++)
                        {
                            if (segment3D.Similar(segment3Ds[j], tolerance))
                            {
                                similarExists = true;
                                break;
                            }
                        }

                        if (!similarExists)
                        {
                            segment3Ds.Add(segment3D);
                        }
                    }
                }
            }

            if (point3Ds.Count == 0 && segment3Ds.Count == 0)
            {
                return new IntersectionResult3D();
            }

            List<IGeometry3D> iGeometry3Ds = new(point3Ds.Count + segment3Ds.Count);
            for (int i = 0; i < point3Ds.Count; i++)
            {
                iGeometry3Ds.Add(point3Ds[i]);
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                iGeometry3Ds.Add(segment3Ds[i]);
            }

            return new IntersectionResult3D(iGeometry3Ds);
        }

        /// <summary>
        /// Calculates the 3D boolean intersection between two polyhedra defined by TPolygonalFace3D faces.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron to intersect.</param>
        /// <param name="polyhedron_2">The second polyhedron to intersect.</param>
        /// <param name="tolerance">The distance tolerance for intersection computations.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the intersection geometry, or null if either input is null.</returns>
        public static IntersectionResult3D? IntersectionResult3D<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron_1, Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null || polyhedron_2 == null)
            {
                return null;
            }

            // Early-out Axis-Aligned Bounding Box (AABB) intersection check
            BoundingBox3D? boundingBox3D_1 = polyhedron_1.GetBoundingBox();
            BoundingBox3D? boundingBox3D_2 = polyhedron_2.GetBoundingBox();
            if (boundingBox3D_1 == null || boundingBox3D_2 == null || !boundingBox3D_1.InRange(boundingBox3D_2, tolerance))
            {
                return new IntersectionResult3D();
            }

            List<IPolygonalFace3D> polygonalFace3Ds_1 = PolygonalFace3Ds(polyhedron_1);
            List<IPolygonalFace3D> polygonalFace3Ds_2 = PolygonalFace3Ds(polyhedron_2);

            if (polygonalFace3Ds_1.Count == 0 || polygonalFace3Ds_2.Count == 0)
            {
                return new IntersectionResult3D();
            }

            List<IPolygonalFace3D> polygonalFace3Ds_Unique = BooleanOperationPolygonalFace3Ds(BooleanOpertaionType.Intersection, polyhedron_1, polyhedron_2, polygonalFace3Ds_1, polygonalFace3Ds_2, out BVHNode bVHNode_2, tolerance);

            // Construct 3D intersection volume if valid (requires >= 4 faces for a solid closed polyhedron)
            if (polygonalFace3Ds_Unique.Count >= 4 && Polyhedron(polygonalFace3Ds_Unique) is Polyhedron polyhedron)
            {
                return new IntersectionResult3D((IGeometry3D)polyhedron);
            }

            // If empty or lower-dimensional boundary touch, collect intersection elements (polygons, segments, points),
            // reusing the BVH built for polyhedron 2 to cull non-overlapping face pairs
            List<IGeometry3D> geometry3Ds_Lower = [];
            List<IPolygonalFace3D> polygonalFace3Ds_Overlapping = [];
            for (int i = 0; i < polygonalFace3Ds_1.Count; i++)
            {
                IPolygonalFace3D polygonalFace3D_1 = polygonalFace3Ds_1[i];

                BoundingBox3D? boundingBox3D = polygonalFace3D_1.GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                polygonalFace3Ds_Overlapping.Clear();
                polygonalFace3Ds_Overlapping.AddOverlappingFaces(bVHNode_2, boundingBox3D, tolerance);

                for (int j = 0; j < polygonalFace3Ds_Overlapping.Count; j++)
                {
                    PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D_1, polygonalFace3Ds_Overlapping[j], tolerance);
                    if (planarIntersectionResult == null || !planarIntersectionResult.Any())
                    {
                        continue;
                    }

                    List<IGeometry3D>? geometry3Ds_Temp = planarIntersectionResult.GetGeometry3Ds<IGeometry3D>();
                    if (geometry3Ds_Temp == null)
                    {
                        continue;
                    }

                    foreach (IGeometry3D geometry3D in geometry3Ds_Temp)
                    {
                        if (geometry3D == null)
                        {
                            continue;
                        }

                        bool exists = false;
                        if (geometry3D is Point3D point3D)
                        {
                            foreach (IGeometry3D geometry3D_Existing in geometry3Ds_Lower)
                            {
                                if (geometry3D_Existing is Point3D point3D_Existing && point3D.Similar(point3D_Existing, tolerance))
                                {
                                    exists = true;
                                    break;
                                }
                            }
                        }
                        else if (geometry3D is Segment3D segment3D)
                        {
                            foreach (IGeometry3D geometry3D_Existing in geometry3Ds_Lower)
                            {
                                if (geometry3D_Existing is Segment3D segment3D_Existing && segment3D.Similar(segment3D_Existing, tolerance))
                                {
                                    exists = true;
                                    break;
                                }
                            }
                        }
                        else if (geometry3D is Polygon3D polygon3D)
                        {
                            Point3D? point3D_Centroid = polygon3D.GetCentroid();
                            if (point3D_Centroid != null)
                            {
                                foreach (IGeometry3D geometry3D_Existing in geometry3Ds_Lower)
                                {
                                    if (geometry3D_Existing is not Polygon3D polygon3D_Existing)
                                    {
                                        continue;
                                    }

                                    Point3D? point3D_CentroidExisting = polygon3D_Existing.GetCentroid();
                                    if (point3D_CentroidExisting != null && point3D_Centroid.Similar(point3D_CentroidExisting, tolerance) &&
                                        polygon3D.Plane != null && polygon3D_Existing.Plane != null && polygon3D.Plane.Coplanar(polygon3D_Existing.Plane, tolerance))
                                    {
                                        exists = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (!exists)
                        {
                            geometry3Ds_Lower.Add(geometry3D);
                        }
                    }
                }
            }

            return new IntersectionResult3D(geometry3Ds_Lower);
        }

        /// <summary>
        /// Calculates the intersection between a <see cref="Classes.BoundingBox3D"/> and an <see cref="ILinear3D"/>.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="Classes.BoundingBox3D"/> to intersect.</param>
        /// <param name="linear3D">The <see cref="ILinear3D"/> to intersect.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance for the intersection calculation.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the result of the intersection, or <c>null</c> if either input is null or the operation fails.</returns>
        public static IntersectionResult3D? IntersectionResult3D(this BoundingBox3D? boundingBox3D, ILinear3D? linear3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (boundingBox3D == null || linear3D == null)
            {
                return null;
            }

            Polyhedron? polyhedron = Polyhedron(boundingBox3D);
            if (polyhedron == null)
            {
                return null;
            }

            return IntersectionResult3D(polyhedron, linear3D, tolerance);
        }

        /// <summary>
        /// Calculates the intersection between a 3D bounding box and a ray defined by a point and a direction.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="Classes.BoundingBox3D"/> to check for intersection.</param>
        /// <param name="point3D">The <see cref="Point3D"/> representing the starting point of the ray.</param>
        /// <param name="vector3D_Direction">The <see cref="Vector3D"/> representing the direction of the ray.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the intersection calculation.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the result of the intersection, or null if any of the required parameters are null.</returns>
        public static IntersectionResult3D? IntersectionResult3D(this BoundingBox3D? boundingBox3D, Point3D? point3D, Vector3D? vector3D_Direction, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (boundingBox3D == null || vector3D_Direction == null || point3D == null)
            {
                return null;
            }

            IntersectionResult3D? intersectionResult3D = IntersectionResult3D(boundingBox3D, new Line3D(point3D, vector3D_Direction), tolerance);
            if (intersectionResult3D == null)
            {
                return null;
            }

            if (!intersectionResult3D.Any())
            {
                return intersectionResult3D;
            }

            Vector3D? vector3D_Unit = vector3D_Direction?.Unit;
            if (vector3D_Unit == null)
            {
                return null;
            }

            List<IGeometry3D> iGeometry3Ds = [];

            List<IGeometry3D>? iGeometry3Ds_Temp = intersectionResult3D.GetGeometry3Ds<IGeometry3D>();
            if (iGeometry3Ds_Temp != null)
            {
                foreach (IGeometry3D iGeometry3D in iGeometry3Ds_Temp)
                {
                    if (iGeometry3D is Point3D point3D_Temp)
                    {
                        Vector3D? vector3D_UnitTemp = new Vector3D(point3D, point3D_Temp).Unit;
                        if (vector3D_Unit.AlmostEquals(vector3D_UnitTemp))
                        {
                            iGeometry3Ds.Add(iGeometry3D);
                        }
                    }
                    else if (iGeometry3D is Segment3D segment3D)
                    {
                        Point3D? point3D_SegmentStart = segment3D[0];
                        Point3D? point3D_SegmentEnd = segment3D[1];
                        if (point3D_SegmentStart != null && point3D_SegmentEnd != null)
                        {
                            Vector3D? vector3D_UnitTemp = new Vector3D(point3D, point3D_SegmentStart).Unit;
                            if (vector3D_Unit.AlmostEquals(vector3D_UnitTemp))
                            {
                                iGeometry3Ds.Add(new Segment3D(point3D, point3D_SegmentStart));
                            }
                            else
                            {
                                iGeometry3Ds.Add(new Segment3D(point3D, point3D_SegmentEnd));
                            }
                        }
                    }
                }
            }

            if (iGeometry3Ds.Count == 0)
            {
                return new IntersectionResult3D();
            }

            return new IntersectionResult3D(iGeometry3Ds);
        }

        /// <summary>
        /// Calculates the intersection between a <see cref="Sphere"/> and a <see cref="Segment3D"/>.
        /// </summary>
        /// <param name="sphere">The <see cref="Sphere"/> to intersect.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> to intersect.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the intersection calculation.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the result of the intersection, or <see langword="null"/> if either the sphere or segment is null.</returns>
        public static IntersectionResult3D? IntersectionResult3D(this Sphere? sphere, Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Vector3D? vector3D_D = segment3D?.End - segment3D?.Start;
            Vector3D? vector3D_F = segment3D?.Start - sphere?.Center;
            if (vector3D_D is null || vector3D_F is null)
            {
                return null;
            }

            double a = vector3D_D.DotProduct(vector3D_D);
            double b = 2 * vector3D_F.DotProduct(vector3D_D);
            double c = vector3D_F.DotProduct(vector3D_F) - sphere!.Radius * sphere.Radius;

            double discriminant = b * b - 4 * a * c;

            if (discriminant < -tolerance)
            {
                return new IntersectionResult3D();
            }

            discriminant = System.Math.Sqrt(discriminant);
            double t1 = (-b - discriminant) / (2 * a);
            double t2 = (-b + discriminant) / (2 * a);

            List<IGeometry3D> iGeometry3Ds = [];
            if (t1 >= -tolerance && t1 <= 1 + tolerance)
            {
                IGeometry3D? iGeometry3D = segment3D?.Start + t1 * vector3D_D;
                if (iGeometry3D is not null)
                {
                    iGeometry3Ds.Add(iGeometry3D);
                }
            }

            if (t2 >= -tolerance && t2 <= 1 + tolerance)
            {
                IGeometry3D? iGeometry3D = segment3D?.Start + t2 * vector3D_D;
                if (iGeometry3D is not null)
                {
                    iGeometry3Ds.Add(iGeometry3D);
                }
            }

            return new IntersectionResult3D(iGeometry3Ds);
        }

        /// <summary>
        /// Calculates the intersection between a sphere and a 3D line.
        /// </summary>
        /// <param name="sphere">The <see cref="Sphere"/> to intersect.</param>
        /// <param name="line3D">The <see cref="Line3D"/> to intersect.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the intersection calculation.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the intersection details, or <see langword="null"/> if either the sphere or line is null.</returns>
        public static IntersectionResult3D? IntersectionResult3D(this Sphere? sphere, Line3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Vector3D? vector3D_D = line3D?.Direction;
            Vector3D? vector3D_F = line3D?.Origin - sphere?.Center;
            if (vector3D_D is null || vector3D_F is null)
            {
                return null;
            }

            double a = vector3D_D.DotProduct(vector3D_D);
            double b = 2 * vector3D_F.DotProduct(vector3D_D);
            double c = vector3D_F.DotProduct(vector3D_F) - sphere!.Radius * sphere.Radius;

            double discriminant = b * b - 4 * a * c;

            if (discriminant < -tolerance)
            {
                return new IntersectionResult3D();
            }

            discriminant = System.Math.Sqrt(discriminant);
            double t1 = (-b - discriminant) / (2 * a);
            double t2 = (-b + discriminant) / (2 * a);

            if (line3D!.Origin + t1 * vector3D_D is not IGeometry3D iGeometry3D_1 || line3D!.Origin + t2 * vector3D_D is not IGeometry3D iGeometry3D_2)
            {
                return new IntersectionResult3D();
            }

            List<IGeometry3D> iGeometry3Ds =
            [
                iGeometry3D_1,
                iGeometry3D_2
            ];

            return new IntersectionResult3D(iGeometry3Ds);
        }
    }
}