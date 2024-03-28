using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static List<Plane> Planes(this BoundingBox3D boundingBox3D)
        {
            if(boundingBox3D == null)
            {
                return null;
            }

            Point3D point3D_Min = boundingBox3D.Min;
            if(point3D_Min == null)
            {
                return null;
            }

            Point3D point3D_Max = boundingBox3D.Max;
            if (point3D_Min == null)
            {
                return null;
            }

            Vector3D vector3D_X = Constans.Vector3D.WorldX;
            Vector3D vector3D_Y = Constans.Vector3D.WorldY;
            Vector3D vector3D_Z = Constans.Vector3D.WorldZ;

            return new List<Plane>()
            {
                new Plane(point3D_Min, vector3D_X),
                new Plane(point3D_Min, vector3D_Y),
                new Plane(point3D_Min, vector3D_Z),
                new Plane(point3D_Max, vector3D_X),
                new Plane(point3D_Max, vector3D_Y),
                new Plane(point3D_Max, vector3D_Z)
            };
        }
    }
}
