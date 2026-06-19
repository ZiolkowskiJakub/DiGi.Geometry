using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Returns a list of <see cref="Classes.Plane"/> objects that define the boundaries of the specified <see cref="Classes.BoundingBox3D"/>.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="Classes.BoundingBox3D"/> instance from which to extract the planes.</param>
        /// <returns>A <c>List&lt;Plane&gt;</c> containing the boundary planes, or null if the <see cref="Classes.BoundingBox3D"/> is null or contains invalid bounds.</returns>
        public static List<Plane>? Planes(this BoundingBox3D? boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            Point3D point3D_Min = boundingBox3D.Min;
            if (point3D_Min == null)
            {
                return null;
            }

            Point3D point3D_Max = boundingBox3D.Max;
            if (point3D_Min == null)
            {
                return null;
            }

            Vector3D vector3D_X = Constants.Vector3D.WorldX;
            Vector3D vector3D_Y = Constants.Vector3D.WorldY;
            Vector3D vector3D_Z = Constants.Vector3D.WorldZ;

            return
            [
                new Plane(point3D_Min, vector3D_X),
                new Plane(point3D_Min, vector3D_Y),
                new Plane(point3D_Min, vector3D_Z),
                new Plane(point3D_Max, vector3D_X),
                new Plane(point3D_Max, vector3D_Y),
                new Plane(point3D_Max, vector3D_Z)
            ];
        }
    }
}