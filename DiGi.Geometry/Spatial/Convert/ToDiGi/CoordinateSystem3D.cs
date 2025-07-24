using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Convert
    {
        public static CoordinateSystem3D ToDiGi(this Plane plane)
        {
            if(plane == null)
            {
                return null;
            }

            return new CoordinateSystem3D(plane.Origin, plane.AxisX, plane.AxisY);
        }

    }
}
