using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Modify
    {
        public static void Add(this List<Point3D> point3Ds, double x, double y, double z)
        {
            if (point3Ds == null)
            {
                return;
            }

            point3Ds.Add(new Point3D(x, y, z));
        }
    }
}
