using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static List<Polygon3D> Polygon3Ds(BoundingBox3D boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            Point3D min = boundingBox3D.Min;
            if (min == null)
            {
                return null;
            }

            Point3D max = boundingBox3D.Max;
            if (max == null)
            {
                return null;
            }

            double width = boundingBox3D.Width;
            double depth = boundingBox3D.Depth;
            double height = boundingBox3D.Height;

            Vector3D vector3D_Width = new Vector3D(width, 0, 0);
            Vector3D vector3D_Depth = new Vector3D(0, depth, 0);
            Vector3D vector3D_Height = new Vector3D(0, 0, height);

            Plane plane;

            Point3D point3D_1;
            Point3D point3D_2;
            Point3D point3D_3;
            Point3D point3D_4;

            List<Polygon3D> result = new List<Polygon3D>();

            point3D_1 = min;
            point3D_2 = min.GetMoved(vector3D_Width);
            point3D_3 = point3D_2.GetMoved(vector3D_Depth);
            point3D_4 = min.GetMoved(vector3D_Depth);

            plane = Constans.Plane.WorldZ;
            plane.Inverse();
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            result.Add(Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4)));

            point3D_1 = min;
            point3D_2 = min.GetMoved(vector3D_Depth);
            point3D_3 = point3D_2.GetMoved(vector3D_Height);
            point3D_4 = min.GetMoved(vector3D_Height);

            plane = Constans.Plane.WorldX;
            plane.Inverse();
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            result.Add(Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4)));

            point3D_1 = min;
            point3D_2 = min.GetMoved(vector3D_Height);
            point3D_3 = point3D_2.GetMoved(vector3D_Width);
            point3D_4 = min.GetMoved(vector3D_Width);

            plane = Constans.Plane.WorldY;
            plane.Inverse();
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            result.Add(Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4)));

            point3D_1 = max;
            point3D_2 = max.GetMoved(-vector3D_Height);
            point3D_3 = point3D_2.GetMoved(-vector3D_Depth);
            point3D_4 = max.GetMoved(-vector3D_Depth);

            plane = Constans.Plane.WorldX;
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            result.Add(Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4)));

            point3D_1 = max;
            point3D_2 = max.GetMoved(-vector3D_Width);
            point3D_3 = point3D_2.GetMoved(-vector3D_Height);
            point3D_4 = max.GetMoved(-vector3D_Height);

            plane = Constans.Plane.WorldY;
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            result.Add(Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4)));

            point3D_1 = max;
            point3D_2 = max.GetMoved(-vector3D_Depth);
            point3D_3 = point3D_2.GetMoved(-vector3D_Width);
            point3D_4 = max.GetMoved(-vector3D_Width);

            plane = Constans.Plane.WorldZ;
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            result.Add(Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4)));

            return result;
        }
    }
}
