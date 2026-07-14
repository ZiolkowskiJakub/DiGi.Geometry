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
        /// Projects a <see cref="Point3D"/> onto a <see cref="Classes.Plane"/> to create a <see cref="Classes.ProjectionResult"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> used for the projection.</param>
        /// <param name="point3D">The <see cref="Point3D"/> to be projected onto the plane.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the result of the projection, or <c>null</c> if the <see cref="Classes.Plane"/> or <see cref="Point3D"/> is <c>null</c>, or if the conversion to a <see cref="Point2D"/> fails.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Point3D? point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            Point2D? point2D = Query.Convert(plane, plane.ClosestPoint(point3D));
            if (point2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, point2D);
        }

        /// <summary>
        /// Projects a collection of <see cref="Point3D"/> points onto a <see cref="Classes.Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to which the points are projected.</param>
        /// <param name="point3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to project.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projection data, or <see langword="null"/> if either the <see cref="Classes.Plane"/> or the <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> is null.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, IEnumerable<Point3D>? point3Ds)
        {
            if (plane == null || point3Ds == null)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = [];
            foreach (Point3D point3D in point3Ds)
            {
                Point2D? point2D = Query.Convert(plane, plane.ClosestPoint(point3D));
                if (point2D == null)
                {
                    continue;
                }

                geometry2Ds.Add(point2D);
            }

            return new ProjectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the projection result of a <see cref="Vector3D"/> onto a <see cref="Classes.Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project onto.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the minimum length threshold for the projection result.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projection details, or <c>null</c> if the input parameters are null or the resulting vector length is less than the specified <see cref="double"/> tolerance.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || vector3D == null)
            {
                return null;
            }

            Vector3D? normal = plane.Normal;

            Vector3D? vector3D_Temp = vector3D - vector3D.DotProduct(normal) * normal;
            if (vector3D_Temp is null)
            {
                return null;
            }

            double length = vector3D_Temp.Length;

            if (double.IsNaN(length) || length < tolerance)
            {
                return null;
            }

            Vector2D? vector2D = Query.Convert(plane, vector3D_Temp);
            if (vector2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, vector2D);
        }

        /// <summary>
        /// Projects a <see cref="Line3D"/> onto a <see cref="Classes.Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project the line onto.</param>
        /// <param name="line3D">The <see cref="Line3D"/> to be projected.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for similarity and intersection calculations.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projection results, or <c>null</c> if either input is null or the projection cannot be determined.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Line3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || line3D == null)
            {
                return null;
            }

            if (Query.Similar(plane.Normal, line3D.Direction, tolerance))
            {
                PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, line3D, tolerance);
                return new ProjectionResult(plane, planarIntersectionResult?.GetGeometry2Ds<IGeometry2D>());
            }

            Point2D? point2D = ProjectionResult(plane, line3D.Origin)?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if (point2D == null)
            {
                return null;
            }

            Vector2D? vector2D = ProjectionResult(plane, line3D.Direction, tolerance)?.GetGeometry2Ds<Vector2D>()?.FirstOrDefault();
            if (vector2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, new Line2D(point2D, vector2D));
        }

        /// <summary>
        /// Calculates the projection of a 3D ray onto a plane.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project the ray onto.</param>
        /// <param name="ray3D">The <see cref="Ray3D"/> to be projected.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for similarity and distance calculations.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projection data, or <c>null</c> if either the <see cref="Classes.Plane"/> or <see cref="Ray3D"/> is null.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Ray3D? ray3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || ray3D == null)
            {
                return null;
            }

            if (Query.Similar(plane.Normal, ray3D.Direction, tolerance))
            {
                PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, ray3D, tolerance);
                return new ProjectionResult(plane, planarIntersectionResult?.GetGeometry2Ds<IGeometry2D>());
            }

            Point2D? point2D = ProjectionResult(plane, ray3D.Origin)?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if (point2D == null)
            {
                return null;
            }

            Vector2D? vector2D = ProjectionResult(plane, ray3D.Direction, tolerance)?.GetGeometry2Ds<Vector2D>()?.FirstOrDefault();
            if (vector2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, new Ray2D(point2D, vector2D));
        }

        /// <summary>
        /// Calculates the projection result of a <see cref="Segment3D"/> onto a <see cref="Classes.Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project onto.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance for similarity calculations.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projection details, or <c>null</c> if either the <see cref="Classes.Plane"/> or <see cref="Segment3D"/> is <c>null</c>.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || segment3D == null)
            {
                return null;
            }

            if (Query.Similar(plane.Normal, segment3D.Direction, tolerance))
            {
                return ProjectionResult(plane, segment3D.Mid());
            }

            Point2D? point2D_1 = ProjectionResult(plane, segment3D[0])?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = ProjectionResult(plane, segment3D[1])?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if (point2D_2 == null)
            {
                return null;
            }

            return new ProjectionResult(plane, new Segment2D(point2D_1, point2D_2));
        }

        /// <summary>
        /// Calculates the projection result of a 3D triangle onto a plane.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> object to project onto.</param>
        /// <param name="triangle3D">The <see cref="Triangle3D"/> object to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for collinearity checks.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projection data, or <see langword="null"/> if the input is null or the resulting points are not valid.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Triangle3D? triangle3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || triangle3D == null)
            {
                return null;
            }

            ProjectionResult? projectionResult = ProjectionResult(plane, triangle3D.GetPoints());
            List<Point2D>? point2Ds = projectionResult?.GetGeometry2Ds<Point2D>();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            if (Planar.Query.Collinear(point2Ds, tolerance))
            {
                Planar.Query.ExtremePoints(point2Ds, out Point2D? point2D_1, out Point2D? point2D_2);
                if (point2D_1 == null || point2D_2 == null)
                {
                    return null;
                }

                Segment2D segment2D = new(point2D_1, point2D_2);
                if (segment2D.Length < tolerance)
                {
                    return new ProjectionResult(plane, segment2D?.Mid());
                }

                return new ProjectionResult(plane, segment2D);
            }

            if (Planar.Query.MinDistance(point2Ds) < tolerance)
            {
                return null;
            }

            return new ProjectionResult(plane, new Triangle2D(point2Ds));
        }

        /// <summary>
        /// Projects a <see cref="Classes.Polygon3D"/> onto a <see cref="Classes.Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project onto.</param>
        /// <param name="polygon3D">The <see cref="Classes.Polygon3D"/> to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the projection.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the result of the projection, or <c>null</c> if the input parameters are null or the resulting geometry is invalid.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Polygon3D? polygon3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || polygon3D == null)
            {
                return null;
            }

            Vector3D? polygon3D_Normal = polygon3D.Plane?.Normal;
            if (polygon3D_Normal == null)
            {
                return null;
            }

            ProjectionResult? projectionResult = ProjectionResult(plane, polygon3D.GetPoints());
            List<Point2D>? point2Ds = projectionResult?.GetGeometry2Ds<Point2D>();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            if (Query.Perpendicular(plane.Normal, polygon3D_Normal, tolerance))
            {
                Planar.Query.ExtremePoints(point2Ds, out Point2D? point2D_1, out Point2D? point2D_2);
                if (point2D_1 == null || point2D_2 == null)
                {
                    return null;
                }

                Segment2D segment2D = new(point2D_1, point2D_2);
                if (segment2D.Length < tolerance)
                {
                    return new ProjectionResult(plane, segment2D?.Mid());
                }

                return new ProjectionResult(plane, segment2D);
            }

            return new ProjectionResult(plane, new Polygon2D(point2Ds));
        }

        /// <summary>
        /// Calculates the projection result of a specified 3D geometry onto a plane.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project onto.</param>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> object to be projected.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance for the projection.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the result of the projection, or null if either the plane or geometry is null.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, IGeometry3D? geometry3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || geometry3D == null)
            {
                return null;
            }

            if (geometry3D is Point3D point3D)
            {
                return ProjectionResult(plane, point3D);
            }

            return ProjectionResult(plane, geometry3D as dynamic, tolerance);
        }

        /// <summary>
        /// Projects a collection of 3D geometry objects onto a plane.
        /// </summary>
        /// <typeparam name="T">The type of 3D geometry, which must implement <see cref="IGeometry3D"/>.</typeparam>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project the geometries onto.</param>
        /// <param name="geometry3Ds">An <see cref="IEnumerable{T}"/> of 3D geometry objects to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the projection process.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the results of the projection, or <c>null</c> if the <paramref name="plane"/> or <paramref name="geometry3Ds"/> is <c>null</c>.</returns>
        public static ProjectionResult? ProjectionResult<T>(this Plane? plane, IEnumerable<T>? geometry3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IGeometry3D
        {
            if (plane == null || geometry3Ds == null)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = [];

            foreach (T geometry2D in geometry3Ds)
            {
                if (geometry2D == null)
                {
                    continue;
                }

                List<IGeometry2D>? geometry2Ds_Temp = ProjectionResult(plane, geometry2D, tolerance)?.GetGeometry2Ds<IGeometry2D>();
                if (geometry2Ds_Temp == null)
                {
                    continue;
                }

                geometry2Ds.AddRange(geometry2Ds_Temp);
            }

            return new ProjectionResult(plane, geometry2Ds);
        }

        /// <summary>
        /// Calculates the projection result of a 3D ellipse onto a plane.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> onto which the ellipse is projected.</param>
        /// <param name="ellipse3D">The <see cref="Ellipse3D"/> to be projected.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used to determine if the plane and the ellipse's plane are parallel.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> containing the projected 2D ellipse, or <see langword="null"/> if either the <see cref="Classes.Plane"/> or <see cref="Ellipse3D"/> is <see langword="null"/>.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, Ellipse3D? ellipse3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || ellipse3D == null)
            {
                return null;
            }

            Vector3D? vector3D_EllipseNormal = ellipse3D.Plane?.Normal;
            if (vector3D_EllipseNormal == null)
            {
                return null;
            }

            if (Query.Parallel(plane.Normal, vector3D_EllipseNormal, tolerance))
            {
                Point3D? point3D_Center = plane.Project(ellipse3D.Center);
                Vector3D? vector3D_Direction = plane.Project(ellipse3D.Direction);

                Point2D? point2D_ParallelCenter = plane.Convert(point3D_Center);
                Vector2D? vector2D_ParallelDirection = plane.Convert(vector3D_Direction);

                if (ellipse3D.B < tolerance)
                {
                    if (ellipse3D.A < tolerance)
                    {
                        return new ProjectionResult(plane, point2D_ParallelCenter);
                    }

                    Vector2D? vector2D_ParallelDirUnit = (vector2D_ParallelDirection?.Unit) ?? Planar.Constants.Vector2D.WorldX;

                    Segment2D segment2D = new(point2D_ParallelCenter - (ellipse3D.A * vector2D_ParallelDirUnit), point2D_ParallelCenter + (ellipse3D.A * vector2D_ParallelDirUnit));
                    if (segment2D.Length < tolerance)
                    {
                        return new ProjectionResult(plane, segment2D.Mid());
                    }

                    return new ProjectionResult(plane, segment2D);
                }

                return new ProjectionResult(plane, new Ellipse2D(point2D_ParallelCenter, ellipse3D.A, ellipse3D.B, vector2D_ParallelDirection));
            }

            Point3D? point3D_Center3D = ellipse3D.Center;
            Vector3D? vector3D_U3D = ellipse3D.Direction;
            if (point3D_Center3D == null || vector3D_U3D == null)
            {
                return null;
            }

            Vector3D? vector3D_V3D = vector3D_EllipseNormal.CrossProduct(vector3D_U3D);
            if (vector3D_V3D == null)
            {
                return null;
            }

            Point2D? point2D_Center2D = plane.Convert(point3D_Center3D);
            Vector2D? vector2D_A = plane.Convert(ellipse3D.A * vector3D_U3D);
            Vector2D? vector2D_B = plane.Convert(ellipse3D.B * vector3D_V3D);
            if (point2D_Center2D == null || vector2D_A == null || vector2D_B == null)
            {
                return null;
            }

            double aSquared = vector2D_A.SquaredLength;
            double bSquared = vector2D_B.SquaredLength;
            double dotProduct = vector2D_A.DotProduct(vector2D_B);

            double m = (aSquared + bSquared) / 2.0;
            double d = (aSquared - bSquared) / 2.0;
            double r = System.Math.Sqrt((d * d) + (dotProduct * dotProduct));

            double b2dSquared = m - r;
            double b2d = b2dSquared > 0.0 ? System.Math.Sqrt(b2dSquared) : 0.0;
            double a2d = System.Math.Sqrt(m + r);

            double theta = 0.5 * System.Math.Atan2(dotProduct, d);
            Vector2D? vector2D_Major = (System.Math.Cos(theta) * vector2D_A) + (System.Math.Sin(theta) * vector2D_B);
            Vector2D? vector2D_MajorUnit = vector2D_Major?.Unit;
            if (vector2D_MajorUnit == null)
            {
                vector2D_MajorUnit = vector2D_A.SquaredLength > 0.0 ? vector2D_A.Unit : Planar.Constants.Vector2D.WorldX;
            }

            if (b2d < tolerance)
            {
                Segment2D segment2D = new(point2D_Center2D - (a2d * vector2D_MajorUnit), point2D_Center2D + (a2d * vector2D_MajorUnit));
                if (segment2D.Length < tolerance)
                {
                    return new ProjectionResult(plane, segment2D.Mid());
                }

                return new ProjectionResult(plane, segment2D);
            }

            return new ProjectionResult(plane, new Ellipse2D(point2D_Center2D, a2d, b2d, vector2D_MajorUnit));
        }

        /// <summary>
        /// Calculates the projection result of a 3D polygonal face onto a plane.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> to project onto.</param>
        /// <param name="polygonalFace3D">The <see cref="Classes.PolygonalFace3D"/> to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the projection.</param>
        /// <returns>A <see cref="Classes.ProjectionResult"/> if the projection is successful; otherwise, <c>null</c>.</returns>
        public static ProjectionResult? ProjectionResult(this Plane? plane, PolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || polygonalFace3D == null)
            {
                return null;
            }

            Vector3D? polygonalFace3D_Normal = polygonalFace3D.Plane?.Normal;
            if (polygonalFace3D_Normal == null)
            {
                return null;
            }

            ProjectionResult? projectionResult = plane.ProjectionResult(polygonalFace3D.ExternalEdge, tolerance);
            if (projectionResult == null)
            {
                return null;
            }

            if (projectionResult.Contains<Segment2D>())
            {
                return new ProjectionResult(plane, projectionResult.GetGeometry2Ds<IGeometry2D>());
            }

            IPolygonal2D? externalEdge2D = projectionResult.GetGeometry2Ds<IPolygonal2D>()?.FirstOrDefault();
            if (externalEdge2D == null)
            {
                return null;
            }

            projectionResult = ProjectionResult(plane, polygonalFace3D.InternalEdges, tolerance);

            PolygonalFace2D? polygonalFace2D = Planar.Create.PolygonalFace2D(externalEdge2D, projectionResult?.GetGeometry2Ds<IPolygonal2D>(), tolerance);
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, polygonalFace2D);
        }
    }
}