using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates unit vector for given angle [rad]
        /// </summary>
        /// <param name="angle">angle to X axis counted counterclockwise [rad]</param>
        /// <returns>Unit Vector2D</returns>
        public static Vector2D Vector2D(double angle)
        {
            if (double.IsNaN(angle) || double.IsInfinity(angle))
            {
                return null;
            }

            if (angle == 0)
            {
                return Constans.Vector2D.WorldX;
            }

            double xAngle = angle;
            double yAngle = (System.Math.PI / 2) - angle;

            return new Vector2D(System.Math.Cos(xAngle), System.Math.Cos(yAngle));
        }

        public static Vector2D Vector2D(double angle, double length)
        {
            if (double.IsNaN(length) || double.IsInfinity(length))
            {
                return null;
            }

            Vector2D vector2D = Vector2D(angle);
            if (vector2D == null)
            {
                return null;
            }

            return vector2D * length;
        }

        public static Vector2D Vector2D(Alignment alignment)
        {
            if (alignment == Alignment.Undefined)
            {
                return null;
            }

            switch (alignment)
            {
                case Alignment.Vertical:
                    return new Vector2D(1, 0);

                case Alignment.Horizontal:
                    return new Vector2D(0, 1);
            }

            return null;
        }
    }

}
