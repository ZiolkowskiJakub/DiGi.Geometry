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
        public static ProjectionResult ProjectionResult(this Plane plane, Point3D point3D)
        {
            if(plane == null || point3D == null)
            {
                return null;
            }

            Point2D point2D = Query.Convert(plane, plane.ClosestPoint(point3D));
            if(point2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, point2D);
        }

        public static ProjectionResult ProjectionResult(this Plane plane, IEnumerable<Point3D> point3Ds)
        {
            if (plane == null || point3Ds == null)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            foreach(Point3D point3D in point3Ds)
            {
                Point2D point2D = Query.Convert(plane, plane.ClosestPoint(point3D));
                if (point2D == null)
                {
                    continue;
                }

                geometry2Ds.Add(point2D);
            }

            return new ProjectionResult(plane, geometry2Ds);
        }

        public static ProjectionResult ProjectionResult(this Plane plane, Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || vector3D == null)
            {
                return null;
            }

            Vector3D normal = plane.Normal;

            Vector3D vector3D_Temp = vector3D - vector3D.DotProduct(normal) * normal;

            double length = vector3D_Temp.Length;

            if (double.IsNaN(length) || length < tolerance)
            {
                return null;
            }

            Vector2D vector2D = Query.Convert(plane, vector3D_Temp);
            if (vector2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, vector2D);
        }

        public static ProjectionResult ProjectionResult(this Plane plane, Line3D line3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || line3D == null)
            {
                return null;
            }

            if(Query.Similar(plane.Normal, line3D.Direction, tolerance))
            {
                PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(plane, line3D, tolerance);
                return new ProjectionResult(plane, planarIntersectionResult?.GetGeometry2Ds<IGeometry2D>());
            }

            Point2D point2D = ProjectionResult(plane, line3D.Origin)?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if(point2D == null)
            {
                return null;
            }

            Vector2D vector2D = ProjectionResult(plane, line3D.Direction, tolerance)?.GetGeometry2Ds<Vector2D>()?.FirstOrDefault();
            if(vector2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, new Line2D(point2D, vector2D));
        }

        public static ProjectionResult ProjectionResult(this Plane plane, Segment3D segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || segment3D == null)
            {
                return null;
            }

            if (Query.Similar(plane.Normal, segment3D.Direction, tolerance))
            {
                return ProjectionResult(plane, segment3D.Mid());
            }

            Point2D point2D_1 = ProjectionResult(plane, segment3D[0])?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if(point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = ProjectionResult(plane, segment3D[1])?.GetGeometry2Ds<Point2D>()?.FirstOrDefault();
            if (point2D_2 == null)
            {
                return null;
            }

            return new ProjectionResult(plane, new Segment2D(point2D_1, point2D_2));
        }

        public static ProjectionResult ProjectionResult(this Plane plane, Triangle3D triangle3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || triangle3D == null)
            {
                return null;
            }

            ProjectionResult projectionResult = ProjectionResult(plane, triangle3D.GetPoints());
            List<Point2D> point2Ds = projectionResult?.GetGeometry2Ds<Point2D>();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            if(Planar.Query.Collinear(point2Ds, tolerance))
            {
                Planar.Query.ExtremePoints(point2Ds, out Point2D point2D_1, out Point2D point2D_2);
                if(point2D_1 == null || point2D_2 == null)
                {
                    return null;
                }

                Segment2D segment2D = new Segment2D(point2D_1, point2D_2);
                if(segment2D.Length < tolerance)
                {
                    return new ProjectionResult(plane, segment2D.Mid());
                }

                return new ProjectionResult(plane, segment2D);
            }

            if(Planar.Query.MinDistance(point2Ds) < tolerance)
            {
                return null;
            }

            return new ProjectionResult(plane, new Triangle2D(point2Ds));

        }

        public static ProjectionResult ProjectionResult(this Plane plane, Polygon3D polygon3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || polygon3D == null)
            {
                return null;
            }

            Vector3D polygon3D_Normal = polygon3D.Plane?.Normal;
            if(polygon3D_Normal == null)
            {
                return null;
            }

            ProjectionResult projectionResult = ProjectionResult(plane, polygon3D.GetPoints());
            List<Point2D> point2Ds = projectionResult?.GetGeometry2Ds<Point2D>();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            if (Query.Perpendicular(plane.Normal, polygon3D_Normal, tolerance))
            {
                Planar.Query.ExtremePoints(point2Ds, out Point2D point2D_1, out Point2D point2D_2);
                if (point2D_1 == null || point2D_2 == null)
                {
                    return null;
                }

                Segment2D segment2D = new Segment2D(point2D_1, point2D_2);
                if (segment2D.Length < tolerance)
                {
                    return new ProjectionResult(plane, segment2D.Mid());
                }

                return new ProjectionResult(plane, segment2D);
            }

            return new ProjectionResult(plane, new Polygon2D(point2Ds));

        }
    
        public static ProjectionResult ProjectionResult(this Plane plane, IGeometry3D geometry3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || geometry3D == null)
            {
                return null;
            }

            if(geometry3D is Point3D)
            {
                return ProjectionResult(plane, (Point3D)geometry3D);
            }

            return ProjectionResult(plane, geometry3D as dynamic, tolerance);
        }
    
        public static ProjectionResult ProjectionResult<T>(this Plane plane, IEnumerable<T> geometry3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T: IGeometry3D
        {
            if(plane == null || geometry3Ds == null)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();

            foreach(T geometry2D in geometry3Ds)
            {
                if(geometry2D == null)
                {
                    continue;
                }

                List<IGeometry2D> geometry2Ds_Temp = ProjectionResult(plane, geometry2D, tolerance)?.GetGeometry2Ds<IGeometry2D>();
                if(geometry2Ds_Temp == null)
                {
                    continue;
                }

                geometry2Ds.AddRange(geometry2Ds_Temp);
            }

            return new ProjectionResult(plane, geometry2Ds);
        }

        public static ProjectionResult ProjectionResult(this Plane plane, Ellipse3D ellipse3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || ellipse3D == null)
            {
                return null;
            }

            Vector3D ellipse3D_Normal = ellipse3D.Plane?.Normal;

            if (Query.Parallel(plane.Normal, ellipse3D_Normal, tolerance))
            {
                Point3D center = plane.Project(ellipse3D.Center);
                Vector3D direction = plane.Project(ellipse3D.Direction);

                return new ProjectionResult(plane, new Ellipse2D(plane.Convert(center), ellipse3D.A, ellipse3D.B, plane.Convert(direction)));
            }

            throw new System.NotImplementedException();
        }

        public static ProjectionResult ProjectionResult(this Plane plane, PolygonalFace3D polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || polygonalFace3D == null)
            {
                return null;
            }

            Vector3D polygonalFace3D_Normal = polygonalFace3D.Plane?.Normal;
            if (polygonalFace3D_Normal == null)
            {
                return null;
            }

            ProjectionResult projectionResult = null;

            projectionResult = ProjectionResult(plane, polygonalFace3D.ExternalEdge, tolerance);
            if(projectionResult == null)
            {
                return null;
            }

            if(projectionResult.Contains<Segment2D>())
            {
                return new ProjectionResult(plane, projectionResult.GetGeometry2Ds<IGeometry2D>());
            }

            IPolygonal2D externalEdge2D = projectionResult.GetGeometry2Ds<IPolygonal2D>()?.FirstOrDefault();
            if(externalEdge2D == null)
            {
                return null;
            }

            projectionResult = ProjectionResult(plane, polygonalFace3D.InternalEdges, tolerance);

            PolygonalFace2D polygonalFace2D = Planar.Create.PolygonalFace2D(externalEdge2D, projectionResult == null ? null : projectionResult.GetGeometry2Ds<IPolygonal2D>(), tolerance);
            if(polygonalFace2D == null)
            {
                return null;
            }

            return new ProjectionResult(plane, polygonalFace2D);
        }
    }
}
