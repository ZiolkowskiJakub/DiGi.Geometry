using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static CoordinateSystem2D CoordinateSystem2D(this Point2D origin, Vector2D axisY)
        {
            if (origin == null || axisY == null)
            {
                return null;
            }

            Vector2D axisY_Temp = new Vector2D(axisY);
            axisY_Temp.Normalize();

            Vector2D axisX = axisY_Temp.GetPerpendicular(Core.Enums.Orientation.Clockwise);

            return new CoordinateSystem2D(origin, axisX, axisY_Temp);
        }
    }

}
