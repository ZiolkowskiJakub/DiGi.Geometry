using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Plane ToDiGi(this CoordinateSystem3D coordinateSystem3D)
        {
            if(coordinateSystem3D == null)
            {
                return null;
            }

            return new Plane(coordinateSystem3D.Origin, coordinateSystem3D.AxisX, coordinateSystem3D.AxisY);
        }

    }
}
