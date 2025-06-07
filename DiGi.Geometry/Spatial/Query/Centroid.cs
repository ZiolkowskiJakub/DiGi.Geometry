using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Centroid(this IEnumerable<Point3D> point3Ds)
        {
            if (point3Ds == null)
            {
                return null;
            }

            int count = point3Ds.Count();
            if(count == 0)
            {
                return null;
            }

            Point3D point3D_1 = point3Ds.ElementAt(0);

            if (count == 1)
            {
                return new Point3D(point3D_1);
            }

            Point3D point3D_2 = point3Ds.ElementAt(1);

            if (count == 2)
            {
                return new Segment3D(point3D_1, point3D_2).Mid();
            }

            if (count == 3)
            {
                Point3D point3D_3 = point3Ds.ElementAt(1);

                double centroidX = (point3D_1.X + point3D_2.X + point3D_3.X) / 3.0;
                double centroidY = (point3D_1.Y + point3D_2.Y + point3D_3.Y) / 3.0;
                double centroidZ = (point3D_1.Z + point3D_2.Z + point3D_3.Z) / 3.0;

                return new Point3D(centroidX, centroidY, centroidZ);
            }

            Vector3D vector3D = Constans.Vector3D.Zero;
            double area = 0;

            for (var i = 2; i < count; i++)
            {
                Point3D point3D_3 = point3Ds.ElementAt(i);
                Vector3D vector3D_1 = new Vector3D(point3D_1, point3D_3);
                Vector3D vector3D_2 = new Vector3D(point3D_2, point3D_3);

                Vector3D vector3D_3 = vector3D_1.CrossProduct(vector3D_2);
                double area_Temp = vector3D_3.Length / 2;

                vector3D.X += area_Temp * (point3D_1.X + point3D_2.X + point3D_3.X) / 3;
                vector3D.Y += area_Temp * (point3D_1.Y + point3D_2.Y + point3D_3.Y) / 3;
                vector3D.Z += area_Temp * (point3D_1.Z + point3D_2.Z + point3D_3.Z) / 3;

                area += area_Temp;
                point3D_2 = point3D_3;
            }

            if (area == 0)
            {
                return null;
            }

            return new Point3D(vector3D.X / area, vector3D.Y / area, vector3D.Z / area);
        }
    }

}
