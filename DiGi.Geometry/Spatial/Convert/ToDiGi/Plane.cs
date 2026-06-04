using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="CoordinateSystem3D"/> instance to a <see cref="Plane"/>.
        /// </summary>
        /// <param name="coordinateSystem3D">The <see cref="CoordinateSystem3D"/> instance to convert.</param>
        /// <returns>A <see cref="Plane"/> object if the provided <see cref="CoordinateSystem3D"/> is not null; otherwise, null.</returns>
        public static Plane? ToDiGi(this CoordinateSystem3D? coordinateSystem3D)
        {
            if (coordinateSystem3D == null)
            {
                return null;
            }

            return new Plane(coordinateSystem3D.Origin, coordinateSystem3D.AxisX, coordinateSystem3D.AxisY);
        }
    }
}