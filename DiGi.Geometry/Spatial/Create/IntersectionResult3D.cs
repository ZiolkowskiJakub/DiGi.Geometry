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
        /// <param name="linear3D">The <see cref="ILinear3D"/> object to intersect with the polyhedron.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for calculations.</param>
        /// <returns>An <see cref="Classes.IntersectionResult3D"/> containing the intersection details, or <c>null</c> if either input is null or the bounding box cannot be determined.</returns>
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

            bool inRange = false;
            if (linear3D is Line3D line3D)
            {
                inRange = boundingBox3D.InRange(line3D, tolerance);
            }
            else if (linear3D is Ray3D ray3D)
            {
                inRange = boundingBox3D.InRange(ray3D, tolerance);
            }
            else if (linear3D is Segment3D segment3D)
            {
                inRange = boundingBox3D.InRange(segment3D, tolerance);
            }
            else
            {
                inRange = boundingBox3D.InRange(linear3D as dynamic, tolerance);
            }

            if (!inRange)
            {
                return new IntersectionResult3D();
            }

            List<Point3D> point3Ds = [];
            List<Segment3D> segment3Ds = [];
            for (int i = 0; i < polyhedron.Count; i++)
            {
                PlanarIntersectionResult? planarIntersectionResult = null;
                if (linear3D is Line3D line3D_Temp)
                {
                    planarIntersectionResult = PlanarIntersectionResult(polyhedron[i], line3D_Temp, tolerance);
                }
                else if (linear3D is Ray3D ray3D_Temp)
                {
                    planarIntersectionResult = PlanarIntersectionResult(polyhedron[i], ray3D_Temp, tolerance);
                }
                else if (linear3D is Segment3D segment3D_Temp)
                {
                    planarIntersectionResult = PlanarIntersectionResult(polyhedron[i], segment3D_Temp, tolerance);
                }
                else
                {
                    planarIntersectionResult = PlanarIntersectionResult(polyhedron[i], linear3D as dynamic, tolerance);
                }

                if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                List<IGeometry3D>? iGeometry3Ds_Temp = planarIntersectionResult.GetGeometry3Ds<IGeometry3D>();
                if (iGeometry3Ds_Temp != null)
                {
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
            }

            if (point3Ds.Count == 0 && segment3Ds.Count == 0)
            {
                return new IntersectionResult3D();
            }

            List<IGeometry3D> iGeometry3Ds = [];
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

            if (!intersectionResult3D.Intersect)
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