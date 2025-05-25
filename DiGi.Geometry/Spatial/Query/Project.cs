using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Project(this Plane plane, Point3D point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            return plane.ClosestPoint(point3D);
        }

        public static Vector3D Project(this Plane plane, Vector3D vector3D)
        {
            if (plane == null || vector3D == null)
                return null;

            Vector3D normal = plane.Normal;

            return vector3D - vector3D.DotProduct(normal) * normal;
        }

        public static T Project<T>(this Plane plane, IGeometry3D geometry3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : IGeometry3D
        {
            if(geometry3D == null || plane == null)
            {
                return default;
            }

            if(geometry3D is Point3D)
            {
                if(typeof(T).IsAssignableFrom(typeof(Point3D)))
                {
                    Point3D point3D = Project(plane, (Point3D)geometry3D);
                    if(point3D != null)
                    {
                        return (T)(object)point3D;
                    }
                }

                return default;
            }

            ProjectionResult projectionResult = Create.ProjectionResult(plane, geometry3D, tolerance);
            if(projectionResult == null)
            {
                return default;
            }

            List<T> ts = projectionResult.GetGeometry3Ds<T>();
            if(ts == null || ts.Count == 0)
            {
                return default;
            }

            return ts[0];
        }
    }

}
