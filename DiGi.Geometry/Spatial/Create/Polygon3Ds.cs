using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a list of <see cref="Classes.Polygon3D"/> objects from the specified <see cref="Classes.BoundingBox3D"/>.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="Classes.BoundingBox3D"/> used to create the polygons.</param>
        /// <returns>A <c>List&lt;Polygon3D&gt;</c> containing the generated polygons, or null if the provided <see cref="Classes.BoundingBox3D"/> or its boundaries are null.</returns>
        public static List<Polygon3D>? Polygon3Ds(BoundingBox3D? boundingBox3D)
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

            Vector3D vector3D_Width = new(width, 0, 0);
            Vector3D vector3D_Depth = new(0, depth, 0);
            Vector3D vector3D_Height = new(0, 0, height);

            Plane plane;

            Point3D? point3D_1;
            Point3D? point3D_2;
            Point3D? point3D_3;
            Point3D? point3D_4;

            List<Polygon3D> result = [];

            point3D_1 = min;
            point3D_2 = min.GetMoved(vector3D_Width);
            point3D_3 = point3D_2?.GetMoved(vector3D_Depth);
            point3D_4 = min.GetMoved(vector3D_Depth);

            plane = Constants.Plane.WorldZ;
            plane.Flip();
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            Polygon3D? polygon3D = Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4));
            if (polygon3D != null)
            {
                result.Add(polygon3D);
            }

            point3D_1 = min;
            point3D_2 = min.GetMoved(vector3D_Depth);
            point3D_3 = point3D_2?.GetMoved(vector3D_Height);
            point3D_4 = min.GetMoved(vector3D_Height);

            plane = Constants.Plane.WorldX;
            plane.Flip();
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            polygon3D = Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4));
            if (polygon3D != null)
            {
                result.Add(polygon3D);
            }

            point3D_1 = min;
            point3D_2 = min.GetMoved(vector3D_Height);
            point3D_3 = point3D_2?.GetMoved(vector3D_Width);
            point3D_4 = min.GetMoved(vector3D_Width);

            plane = Constants.Plane.WorldY;
            plane.Flip();
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            polygon3D = Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4));
            if (polygon3D != null)
            {
                result.Add(polygon3D);
            }

            point3D_1 = max;
            point3D_2 = max.GetMoved(-vector3D_Height);
            point3D_3 = point3D_2?.GetMoved(-vector3D_Depth);
            point3D_4 = max.GetMoved(-vector3D_Depth);

            plane = Constants.Plane.WorldX;
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            polygon3D = Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4));
            if (polygon3D != null)
            {
                result.Add(polygon3D);
            }

            point3D_1 = max;
            point3D_2 = max.GetMoved(-vector3D_Width);
            point3D_3 = point3D_2?.GetMoved(-vector3D_Height);
            point3D_4 = max.GetMoved(-vector3D_Height);

            plane = Constants.Plane.WorldY;
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            polygon3D = Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4));
            if (polygon3D != null)
            {
                result.Add(polygon3D);
            }

            point3D_1 = max;
            point3D_2 = max.GetMoved(-vector3D_Depth);
            point3D_3 = point3D_2?.GetMoved(-vector3D_Width);
            point3D_4 = max.GetMoved(-vector3D_Width);

            plane = Constants.Plane.WorldZ;
            plane = new Plane(plane, point3D_1.Mid(point3D_3));

            polygon3D = Polygon3D(plane, plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4));
            if (polygon3D != null)
            {
                result.Add(polygon3D);
            }

            return result;
        }
    }
}