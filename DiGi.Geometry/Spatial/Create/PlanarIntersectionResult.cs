using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the planar intersection result for a given <see cref="Classes.Plane"/> and <see cref="Point3D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> used for the intersection calculation.</param>
        /// <param name="point3D">The <see cref="Point3D"/> to be checked against the plane.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for determining if the point lies on the plane.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the intersection details, or <see langword="null"/> if either input is null or projection fails.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            Point3D? point3D_Project = plane.Project(point3D);
            if (point3D_Project == null)
            {
                return null;
            }

            if (point3D_Project.Distance(point3D) < tolerance)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Project));
        }

        /// <summary>
        /// Calculates the intersection result between a plane and a 3D segment.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to intersect.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> to intersect.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the intersection details, or <c>null</c> if either input is null or a result cannot be determined.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || segment3D == null)
            {
                return null;
            }

            Vector3D? direction = segment3D.Direction;
            if (direction is null)
            {
                return null;
            }

            Vector3D? normal = plane.Normal;
            if (normal is null)
            {
                return null;
            }

            double d = normal.DotProduct(direction);
            if (System.Math.Abs(d) < tolerance)
            {
                if (System.Math.Min(plane.Distance(segment3D[0]), plane.Distance(segment3D[1])) < tolerance)
                {
                    ProjectionResult? projectionResult = ProjectionResult(plane, segment3D, tolerance);
                    if (projectionResult != null && projectionResult.Contains<Segment2D>())
                    {
                        return new PlanarIntersectionResult(plane, projectionResult.GetGeometry2Ds<Segment2D>());
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            double u = (plane.K - normal.DotProduct((Vector3D?)segment3D[0])) / d;
            Point3D? point3D = segment3D[0];
            if (point3D is null)
            {
                return null;
            }

            double len = segment3D.Length;
            if (!(u >= -tolerance && u <= len + tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            Point3D point3D_Intersection = new(point3D.X + u * direction.X, point3D.Y + u * direction.Y, point3D.Z + u * direction.Z);
            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Intersection));
        }

        /// <summary>
        /// Calculates the intersection result between a plane and a 3D ray.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to be intersected.</param>
        /// <param name="ray3D">The <see cref="Ray3D"/> used for the intersection calculation.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the intersection.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> if an intersection is found and inputs are valid; otherwise, null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, Ray3D? ray3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || ray3D == null)
            {
                return null;
            }

            if (ray3D.Direction is not Vector3D direction)
            {
                return null;
            }

            if (plane.Normal is not Vector3D normal)
            {
                return null;
            }

            if (ray3D.Origin is not Point3D origin)
            {
                return null;
            }

            double d = normal.DotProduct(direction);
            if (System.Math.Abs(d) < tolerance)
            {
                if (System.Math.Min(plane.Distance(origin), plane.Distance(origin + direction)) < tolerance)
                {
                    ProjectionResult? projectionResult = ProjectionResult(plane, ray3D, tolerance);
                    if (projectionResult != null && projectionResult.Contains<Segment2D>())
                    {
                        return new PlanarIntersectionResult(plane, projectionResult.GetGeometry2Ds<Segment2D>());
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            double u = (plane.K - normal.DotProduct((Vector3D?)origin)) / d;
            Point3D? point3D = origin;
            if (point3D is null)
            {
                return null;
            }

            if (!(u >= -tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            Point3D point3D_Intersection = new(point3D.X + u * direction.X, point3D.Y + u * direction.Y, point3D.Z + u * direction.Z);
            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Intersection));
        }

        /// <summary>
        /// Calculates the intersection result between a <see cref="Classes.Plane"/> and a <see cref="Line3D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to intersect.</param>
        /// <param name="line3D">The <see cref="Line3D"/> to intersect.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or null if the plane or line is null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, Line3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane is null || line3D?.Origin is not Point3D origin)
            {
                return null;
            }

            return PlanarIntersectionResult(plane, origin, origin + line3D.Direction, false, false, tolerance);
        }

        /// <summary>
        /// Calculates the intersection result between a <see cref="Classes.Plane"/> and a line segment defined by two <see cref="Point3D"/> points.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to intersect with.</param>
        /// <param name="point3D_1">The first <see cref="Point3D"/> defining the line segment.</param>
        /// <param name="point3D_2">The second <see cref="Point3D"/> defining the line segment.</param>
        /// <param name="bounded_1">A <see cref="bool"/> value indicating whether the intersection is bounded for the first point.</param>
        /// <param name="bounded_2">A <see cref="bool"/> value indicating whether the intersection is bounded for the second point.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for distance calculations.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or <c>null</c> if any input parameters are null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, Point3D? point3D_1, Point3D? point3D_2, bool bounded_1 = false, bool bounded_2 = false, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane is null || point3D_1 is null || point3D_2 is null)
            {
                return null;
            }

            Vector3D? normal = plane.Normal;
            if (normal is null)
            {
                return null;
            }

            Vector3D vector3D = new(point3D_1, point3D_2);

            double d = normal.DotProduct(vector3D);
            if (System.Math.Abs(d) < tolerance)
            {
                if (plane.Distance(point3D_1) < tolerance)
                {
                    ProjectionResult? projectionResult;
                    if (bounded_1 && bounded_2)
                    {
                        projectionResult = ProjectionResult(plane, new Segment3D(point3D_1, vector3D), tolerance);
                    }
                    else if (!bounded_1 && !bounded_2)
                    {
                        projectionResult = ProjectionResult(plane, new Line3D(point3D_1, vector3D), tolerance);
                    }
                    else
                    {
                        if (bounded_1)
                        {
                            projectionResult = ProjectionResult(plane, new Ray3D(point3D_1, point3D_2), tolerance);
                        }
                        else
                        {
                            projectionResult = ProjectionResult(plane, new Ray3D(point3D_2, point3D_1), tolerance);
                        }
                    }

                    if (projectionResult != null && projectionResult.Contains<ILinear2D>())
                    {
                        return new PlanarIntersectionResult(plane, projectionResult.GetGeometry2Ds<ILinear2D>());
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            double u = (plane.K - normal.DotProduct((Vector3D?)point3D_1)) / d;

            if (bounded_1 || bounded_2)
            {
                double len = vector3D.Length;
                if (len < tolerance)
                {
                    if (plane.Distance(point3D_1) > tolerance)
                    {
                        return new PlanarIntersectionResult(plane);
                    }
                }
                else
                {
                    double tLimit = tolerance / len;
                    if (bounded_1 && bounded_2)
                    {
                        if (!(u >= -tLimit && u <= 1.0 + tLimit))
                        {
                            return new PlanarIntersectionResult(plane);
                        }
                    }
                    else if (bounded_1)
                    {
                        if (!(u >= -tLimit))
                        {
                            return new PlanarIntersectionResult(plane);
                        }
                    }
                    else // bounded_2
                    {
                        if (!(u <= 1.0 + tLimit))
                        {
                            return new PlanarIntersectionResult(plane);
                        }
                    }
                }
            }

            Point3D point3D_Intersection = new(point3D_1.X + u * vector3D.X, point3D_1.Y + u * vector3D.Y, point3D_1.Z + u * vector3D.Z);
            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Intersection));
        }

        /// <summary>
        /// Calculates the planar intersection result between a <see cref="Classes.Plane"/> and an <see cref="ISegmentable3D"/> object.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> used for the intersection calculation.</param>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to be intersected with the plane.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine if an intersection occurs.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the intersection data, or <c>null</c> if the <see cref="Classes.Plane"/> or <see cref="ISegmentable3D"/> is null, or if no segments are available.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || segmentable3D == null)
            {
                return null;
            }

            BoundingBox3D? boundingBox3D = segmentable3D.GetBoundingBox();
            if (boundingBox3D != null && !boundingBox3D.InRange(plane, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            List<Segment3D>? segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = [];
            List<Point2D> point2Ds = [];

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, segment3Ds[i], tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Any())
                {
                    continue;
                }

                List<IGeometry2D>? geometry2Ds_Temp = planarIntersectionResult.GetGeometry2Ds<IGeometry2D>();
                if (geometry2Ds_Temp is null)
                {
                    continue;
                }

                foreach (IGeometry2D geometry2D in geometry2Ds_Temp)
                {
                    if (geometry2D is Segment2D segment2D)
                    {
                        DiGi.Core.Modify.Add(segment2Ds, segment2D, x => Planar.Query.Similar(x, segment2D, tolerance));
                    }
                    else if (geometry2D is Point2D point2D)
                    {
                        DiGi.Core.Modify.Add(point2Ds, point2D, x => Planar.Query.Similar(x, point2D, tolerance));
                    }
                }
            }
            List<IGeometry2D> geometry2Ds = [];
            for (int i = 0; i < segment2Ds.Count; i++)
            {
                geometry2Ds.Add(segment2Ds[i]);
            }

            for (int i = 0; i < point2Ds.Count; i++)
            {
                geometry2Ds.Add(point2Ds[i]);
            }

            if (geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the intersection result of two planes.
        /// </summary>
        /// <param name="plane_1">The first <see cref="Classes.Plane"/> to intersect.</param>
        /// <param name="plane_2">The second <see cref="Classes.Plane"/> to intersect.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> if an intersection is found; otherwise, <c>null</c>.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane_1, Plane? plane_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Point3D? origin_1 = plane_1?.Origin;
            if (origin_1 is null)
            {
                return null;
            }

            Point3D? origin_2 = plane_2?.Origin;
            if (origin_2 is null)
            {
                return null;
            }

            if (plane_1!.Coplanar(plane_2, tolerance))
            {
                if (plane_1.Distance(plane_2!.Origin) < tolerance)
                {
                    return null;
                }

                return new PlanarIntersectionResult(plane_1);
            }

            Vector3D? normal_1 = plane_1.Normal;
            Vector3D? normal_2 = plane_2!.Normal;

            //Calculate tangent of line perpendicular to the normal of the two planes
            Vector3D? tangent = normal_1?.CrossProduct(normal_2)?.Unit;
            if (tangent is null)
            {
                return null;
            }

            //d-values from plane equation: ax+by+cz+d=0
            double d1 = -normal_1!.DotProduct(new Vector3D(origin_1.X, origin_1.Y, origin_1.Z));
            double d2 = -normal_2!.DotProduct(new Vector3D(origin_2.X, origin_2.Y, origin_2.Z));

            Point3D orgin;

            if (System.Math.Abs(tangent.Z) >= tolerance)
            {
                double x0 = (normal_1.Y * d2 - normal_2.Y * d1) / (normal_1.X * normal_2.Y - normal_2.X * normal_1.Y);
                double y0 = (normal_2.X * d1 - normal_1.X * d2) / (normal_1.X * normal_2.Y - normal_2.X * normal_1.Y);

                orgin = new Point3D(x0, y0, 0);
            }
            else if (System.Math.Abs(tangent.Y) >= tolerance)
            {
                double x0 = (normal_1.Z * d2 - normal_2.Z * d1) / (normal_1.X * normal_2.Z - normal_2.X * normal_1.Z);
                double z0 = (normal_2.X * d1 - normal_1.X * d2) / (normal_1.X * normal_2.Z - normal_2.X * normal_1.Z);
                orgin = new Point3D(x0, 0, z0);
            }
            else
            {
                double y0 = (normal_1.Z * d2 - normal_2.Z * d1) / (normal_1.Y * normal_2.Z - normal_2.Y * normal_1.Z);
                double z0 = (normal_2.Y * d1 - normal_1.Y * d2) / (normal_1.Y * normal_2.Z - normal_2.Y * normal_1.Z);
                orgin = new Point3D(0, y0, z0);
            }

            return new PlanarIntersectionResult(plane_1, plane_1.Convert(new Line3D(orgin, tangent)));
        }

        /// <summary>
        /// Calculates the planar intersection result between a plane and a 3D polygonal face.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to evaluate.</param>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for coplanar and distance checks.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> if the intersection is successfully calculated; otherwise, null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || polygonalFace3D == null)
            {
                return null;
            }

            Plane? plane_PolygonalFace3D = polygonalFace3D.Plane;
            if (plane_PolygonalFace3D == null)
            {
                return null;
            }

            if (plane.Coplanar(plane_PolygonalFace3D, tolerance))
            {
                if (plane.Distance(plane_PolygonalFace3D.Origin) < tolerance)
                {
                    IPolygonalFace2D? polygonalFace2D_Temp = plane.Convert(polygonalFace3D);
                    if (polygonalFace2D_Temp != null)
                    {
                        return new PlanarIntersectionResult(plane, polygonalFace2D_Temp);
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();
            if (boundingBox3D == null)
            {
                return null;
            }

            if (!boundingBox3D.InRange(plane, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, plane_PolygonalFace3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any())
            {
                return new PlanarIntersectionResult(plane);
            }

            Line3D? line3D = planarIntersectionResult.GetGeometry3Ds<Line3D>()?.FirstOrDefault();
            if (line3D is null)
            {
                return new PlanarIntersectionResult(plane);
            }

            if (!boundingBox3D.InRange(line3D, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D, line3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any())
            {
                return new PlanarIntersectionResult(plane);
            }

            List<IGeometry2D> geometry2Ds = [];

            List<IGeometry3D>? geometry3Ds = planarIntersectionResult.GetGeometry3Ds<IGeometry3D>();
            if (geometry3Ds != null)
            {
                foreach (IGeometry3D geometry3D in geometry3Ds)
                {
                    if (geometry3D is Point3D point3D)
                    {
                        Point2D? point2D = plane.Convert(point3D);
                        if (point2D is not null)
                        {
                            geometry2Ds.Add(point2D);
                        }
                        continue;
                    }

                    if (geometry3D is Segment3D segment3D)
                    {
                        Segment2D? segment2D = plane.Convert(segment3D);
                        if (segment2D is not null)
                        {
                            geometry2Ds.Add(segment2D);
                        }

                        continue;
                    }
                }
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the planar intersection between a plane and a polyhedron.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to intersect with the polyhedron.</param>
        /// <param name="polyhedron">The <see cref="IPolyhedron"/> to be intersected by the plane.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or <c>null</c> if either input is <c>null</c> or the polyhedron contains no faces.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, IPolyhedron? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || polyhedron == null)
            {
                return null;
            }

            BoundingBox3D? boundingBox3D = polyhedron.GetBoundingBox();
            if (boundingBox3D != null && !boundingBox3D.InRange(plane, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            int count = polyhedron.Count;
            if (count == 0)
            {
                return null;
            }

            List<IGeometry2D>? geometry2Ds = [];
            for (int i = 0; i < count; i++)
            {
                PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i), tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Any())
                {
                    continue;
                }

                geometry2Ds.AddRange(planarIntersectionResult.GetGeometry2Ds<IGeometry2D>());
            }

            geometry2Ds = Planar.Create.Geometry2Ds(geometry2Ds, tolerance);
            if (geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the planar intersection result between a plane and a 3D bounding box.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to intersect with the bounding box.</param>
        /// <param name="boundingBox3D">The <see cref="Classes.BoundingBox3D"/> to be intersected by the plane.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or null if either the plane or bounding box is null, or if a polyhedron cannot be created from the bounding box.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this Plane? plane, BoundingBox3D? boundingBox3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || boundingBox3D == null)
            {
                return null;
            }

            Polyhedron? polyhedron = Polyhedron(boundingBox3D);
            if (polyhedron == null)
            {
                return null;
            }

            return PlanarIntersectionResult(plane, polyhedron, tolerance);
        }

        /// <summary>
        /// Calculates the planar intersection between a 3D polygonal face and a line segment defined by two points.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> to intersect with.</param>
        /// <param name="point3D_1">The first <see cref="Point3D"/> defining the line segment.</param>
        /// <param name="point3D_2">The second <see cref="Point3D"/> defining the line segment.</param>
        /// <param name="bounded_1">A <see cref="bool"/> value indicating whether the intersection is bounded by the first point.</param>
        /// <param name="bounded_2">A <see cref="bool"/> value indicating whether the intersection is bounded by the second point.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for distance calculations.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or <c>null</c> if the input parameters are null or an intersection cannot be determined.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, Point3D? point3D_1, Point3D? point3D_2, bool bounded_1, bool bounded_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D_1 is null || point3D_2 is null)
            {
                return null;
            }

            if (polygonalFace3D?.Plane is not Plane plane || polygonalFace3D.Geometry2D is not IPolygonalFace2D polygonalFace2D)
            {
                return null;
            }

            PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, point3D_1, point3D_2, bounded_1, bounded_2, tolerance);
            if (planarIntersectionResult is null)
            {
                return null;
            }

            if (!planarIntersectionResult.Any())
            {
                return new PlanarIntersectionResult(plane);
            }

            List<IGeometry2D>? geometry2Ds_Plane = planarIntersectionResult.GetGeometry2Ds<IGeometry2D>();
            if (geometry2Ds_Plane == null || geometry2Ds_Plane.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            if (polygonalFace2D.GetBoundingBox() is not BoundingBox2D boundingBox2D)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = [];
            foreach (IGeometry2D geometry2D in geometry2Ds_Plane)
            {
                if (geometry2D is Point2D point2D)
                {
                    if (boundingBox2D.InRange(point2D, tolerance))
                    {
                        if (polygonalFace2D.InRange(point2D, tolerance))
                        {
                            geometry2Ds.Add(geometry2D);
                        }
                    }
                    continue;
                }

                if (geometry2D is ILinear2D linear2D)
                {
                    IntersectionResult2D? intersectionResult2D = Planar.Create.IntersectionResult2D(polygonalFace2D, linear2D, tolerance);
                    if (intersectionResult2D != null && intersectionResult2D.Any())
                    {
                        geometry2Ds.AddRange(intersectionResult2D.GetGeometry2Ds<IGeometry2D>());
                    }

                    continue;
                }
            }

            if (geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the planar intersection result of a <see cref="Point3D"/> relative to an <see cref="IPolygonalFace3D"/>.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to evaluate.</param>
        /// <param name="point3D">The <see cref="Point3D"/> instance to check for intersection.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for range checking.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the plane and potentially the projected point, or <c>null</c> if either input is null or the face has no associated plane.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null || point3D == null)
            {
                return null;
            }

            Plane? plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            if (!polygonalFace3D.InRange(point3D, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, plane.Convert(point3D));
        }

        /// <summary>
        /// Calculates the planar intersection result between a polygonal face and a line.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to intersect.</param>
        /// <param name="line3D">The <see cref="Line3D"/> instance to intersect.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or <c>null</c> if either input is null or an intersection cannot be determined.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, Line3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            if (line3D?.Origin is not Point3D origin)
            {
                return null;
            }

            if (line3D.Direction is not Vector3D direction)
            {
                return null;
            }

            return PlanarIntersectionResult(polygonalFace3D, origin, origin + direction, false, false, tolerance);
        }

        /// <summary>
        /// Calculates the planar intersection result between a polygonal face and a segment.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> representing the polygonal face.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> representing the line segment.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or null if the <see cref="IPolygonalFace3D"/> or <see cref="Segment3D"/> is null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            if (segment3D?.Start is not Point3D start)
            {
                return null;
            }

            if (segment3D?.End is not Point3D end)
            {
                return null;
            }

            return PlanarIntersectionResult(polygonalFace3D, start, end, true, true, tolerance);
        }

        /// <summary>
        /// Calculates the planar intersection result between a polygonal face and a ray.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to intersect.</param>
        /// <param name="ray3D">The <see cref="Ray3D"/> instance representing the ray.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for calculations.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the intersection details, or <c>null</c> if no intersection is found or if either input is null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, Ray3D? ray3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            if (ray3D?.Origin is not Point3D origin)
            {
                return null;
            }

            if (ray3D.Direction is not Vector3D direction)
            {
                return null;
            }

            return PlanarIntersectionResult(polygonalFace3D, origin, origin + direction, true, false, tolerance);
        }

        /// <summary>
        /// Calculates the planar intersection between a reference polygonal face and a collection of other polygonal faces.
        /// </summary>
        /// <param name="polygonalFace3D">The reference <see cref="IPolygonalFace3D"/> object.</param>
        /// <param name="polygonalFace3Ds">An <see cref="IEnumerable{IPolygonalFace3D}"/> containing the polygonal faces to intersect with the reference face.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> object if a valid intersection is found; otherwise, <see langword="null"/>.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, IEnumerable<IPolygonalFace3D>? polygonalFace3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null || polygonalFace3Ds == null)
            {
                return null;
            }

            Plane? plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            List<IGeometry2D>? geometry2Ds = [];
            foreach (IPolygonalFace3D volatilePolygonalFace3D_Temp in polygonalFace3Ds)
            {
                BoundingBox3D? boundingBox3D = volatilePolygonalFace3D_Temp?.GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                if (!boundingBox3D.InRange(plane, tolerance))
                {
                    continue;
                }

                PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D, volatilePolygonalFace3D_Temp, tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Any())
                {
                    continue;
                }

                geometry2Ds.AddRange(planarIntersectionResult.GetGeometry2Ds<IGeometry2D>());
            }

            geometry2Ds = Planar.Create.Geometry2Ds(geometry2Ds);
            if (geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the planar intersection result between two polygonal faces.
        /// </summary>
        /// <param name="polygonalFace3D_1">The first <see cref="IPolygonalFace3D"/> face.</param>
        /// <param name="polygonalFace3D_2">The second <see cref="IPolygonalFace3D"/> face.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the planar intersection, or <c>null</c> if either face is null or their planes are not defined.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D_1, IPolygonalFace3D? polygonalFace3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D_1 == null || polygonalFace3D_2 == null)
            {
                return null;
            }

            Plane? plane_PolygonalFace3D_1 = polygonalFace3D_1.Plane;
            if (plane_PolygonalFace3D_1 == null)
            {
                return null;
            }

            Plane? plane_PolygonalFace3D_2 = polygonalFace3D_2.Plane;
            if (plane_PolygonalFace3D_2 == null)
            {
                return null;
            }

            BoundingBox3D? bbox1 = polygonalFace3D_1.GetBoundingBox();
            BoundingBox3D? bbox2 = polygonalFace3D_2.GetBoundingBox();
            if (bbox1 != null && bbox2 != null && !bbox1.InRange(bbox2, tolerance))
            {
                return new PlanarIntersectionResult(plane_PolygonalFace3D_1);
            }

            if (plane_PolygonalFace3D_1.Coplanar(plane_PolygonalFace3D_2, tolerance))
            {
                if (plane_PolygonalFace3D_1.Distance(plane_PolygonalFace3D_2.Origin) < tolerance)
                {
                    IPolygonalFace2D? polygonalFace2D_1 = polygonalFace3D_1.Geometry2D;
                    IPolygonalFace2D? polygonalFace2D_2 = plane_PolygonalFace3D_1.Convert(polygonalFace3D_2);

                    IntersectionResult2D? intersectionResult2D = Planar.Create.IntersectionResult2D(polygonalFace2D_1, polygonalFace2D_2);
                    if (intersectionResult2D != null && intersectionResult2D.Any())
                    {
                        return new PlanarIntersectionResult(plane_PolygonalFace3D_1, intersectionResult2D.GetGeometry2Ds<IGeometry2D>());
                    }
                }

                return new PlanarIntersectionResult(plane_PolygonalFace3D_1);
            }

            PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane_PolygonalFace3D_1, plane_PolygonalFace3D_2, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any())
            {
                return new PlanarIntersectionResult(plane_PolygonalFace3D_1);
            }

            Line3D? line3D = planarIntersectionResult.GetGeometry3Ds<Line3D>()?.FirstOrDefault();
            if (line3D is null)
            {
                return new PlanarIntersectionResult(plane_PolygonalFace3D_1);
            }

            planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D_2, line3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any())
            {
                return new PlanarIntersectionResult(plane_PolygonalFace3D_1);
            }

            List<IGeometry2D> geometry2Ds = [];

            List<IGeometry3D>? geometry3Ds = planarIntersectionResult.GetGeometry3Ds<IGeometry3D>();
            if (geometry3Ds != null)
            {
                foreach (IGeometry3D geometry3D in geometry3Ds)
                {
                    planarIntersectionResult = null;

                    if (geometry3D is Point3D point3D)
                    {
                        planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D_1, point3D, tolerance);
                    }
                    else if (geometry3D is Segment3D segment3D)
                    {
                        planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D_1, segment3D, tolerance);
                    }

                    if (planarIntersectionResult != null && planarIntersectionResult.Any())
                    {
                        geometry2Ds.AddRange(planarIntersectionResult.GetGeometry2Ds<IGeometry2D>());
                    }
                }
            }

            return new PlanarIntersectionResult(plane_PolygonalFace3D_1, geometry2Ds);
        }

        /// <summary>
        /// Calculates the planar intersection result between a polygonal face and all faces of a polyhedron.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> to be intersected.</param>
        /// <param name="polyhedron">The <see cref="IPolyhedron"/> whose faces are used for the intersection calculation.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance.</param>
        /// <returns>A <see cref="Classes.PlanarIntersectionResult"/> containing the result of the intersection, or <c>null</c> if either the <see cref="IPolygonalFace3D"/> or the <see cref="IPolyhedron"/> is null.</returns>
        public static PlanarIntersectionResult? PlanarIntersectionResult(this IPolygonalFace3D? polygonalFace3D, IPolyhedron? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null || polyhedron == null)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];
            for (int i = 0; i < polyhedron.Count; i++)
            {
                if (polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is not IPolygonalFace3D polygonalFace3D_Temp)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D_Temp);
            }

            return PlanarIntersectionResult(polygonalFace3D, polygonalFace3Ds, tolerance);
        }
    }
}