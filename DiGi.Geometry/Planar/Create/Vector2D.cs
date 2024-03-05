using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static Vector2D Vector2D(this double angle)
        {
            if (double.IsNaN(angle))
            {
                return null;
            }

            return new Vector2D(System.Math.Cos(angle), System.Math.Sin(angle));
        }
    }

}
