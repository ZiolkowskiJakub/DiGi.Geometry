using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Min(this IEnumerable<Point3D> point3Ds)
        {
            return Min(point3Ds, out Point3D max);
        }

        public static Point3D Min(this Point3D point3D_1, Point3D point3D_2)
        {
            if(point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            return Min(new Point3D[] { point3D_1, point3D_2 }, out Point3D max);
        }

        public static Point3D Min(this IEnumerable<Point3D> point3Ds, out Point3D max)
        {
            max = null;
            if(point3Ds == null || point3Ds.Count() == 0)
            {
                return null;
            }
            
            double x_Min = double.MaxValue;
            double x_Max = double.MinValue;
            double y_Min = double.MaxValue;
            double y_Max = double.MinValue;
            double z_Min = double.MaxValue;
            double z_Max = double.MinValue;
            foreach (Point3D point3D in point3Ds)
            {
                if(point3D == null)
                {
                    continue;
                }

                if (point3D.X > x_Max)
                {
                    x_Max = point3D.X;
                }

                if (point3D.X < x_Min)
                {
                    x_Min = point3D.X;
                }

                if (point3D.Y > y_Max)
                {
                    y_Max = point3D.Y;
                }

                if (point3D.Y < y_Min)
                {
                    y_Min = point3D.Y;
                }

                if (point3D.Z > z_Max)
                {
                    z_Max = point3D.Z;
                }

                if (point3D.Z < z_Min)
                {
                    z_Min = point3D.Z;
                }
            }

            if(x_Min == double.MaxValue || x_Max == double.MinValue || y_Min == double.MaxValue || y_Max == double.MinValue || z_Min == double.MaxValue || z_Max == double.MinValue)
            {
                return null;
            }

            max = new Point3D(x_Max, y_Max, z_Max);
            return new Point3D(x_Min, y_Min, z_Min);
        }
    }

}
