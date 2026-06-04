using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Plane"/> to a <see cref="CoordinateSystem3D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> instance to convert.</param>
        /// <returns>A <see cref="CoordinateSystem3D"/> representing the plane's coordinate system, or null if the provided <see cref="Plane"/> is null.</returns>
        public static CoordinateSystem3D? ToDiGi(this Plane? plane)
        {
            if (plane == null)
            {
                return null;
            }

            return new CoordinateSystem3D(plane.Origin, plane.AxisX, plane.AxisY);
        }
    }
}