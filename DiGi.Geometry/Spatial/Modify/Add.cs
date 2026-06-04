using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a new <see cref="Point3D"/> to the specified list of nullable <see cref="Point3D"/> objects using the provided coordinates.
        /// </summary>
        /// <param name="point3Ds">The <see cref="List{Point3D?}"/> to which the point will be added. If this list is null, no action is taken.</param>
        /// <param name="x">The double value representing the X coordinate of the point.</param>
        /// <param name="y">The double value representing the Y coordinate of the point.</param>
        /// <param name="z">The double value representing the Z coordinate of the point.</param>
        public static void Add(this List<Point3D?>? point3Ds, double x, double y, double z)
        {
            if (point3Ds == null)
            {
                return;
            }

            point3Ds.Add(new Point3D(x, y, z));
        }
    }
}