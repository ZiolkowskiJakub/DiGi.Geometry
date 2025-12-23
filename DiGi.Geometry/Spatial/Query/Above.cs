using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Above(this Plane? plane, Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            Vector3D? normal = plane?.Normal;
            if (normal == null)
            {
                return false;
            }

            Point3D? origin = plane!.Origin;
            if (origin == null)
            {
                return false;
            }

            return (normal.X * (point3D.X - origin.X)) + (normal.Y * (point3D.Y - origin.Y)) + (normal.Z * (point3D.Z - origin.Z)) > 0 + tolerance;
        }

        public static bool Above(this Plane? plane, IPolygonal3D? polygonal3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || polygonal3D?.GetPoints() is not List<Point3D> point3Ds)
            {
                return false;
            }

            return point3Ds.All(x => plane.Above(x, tolerance));
        }
    }
}
