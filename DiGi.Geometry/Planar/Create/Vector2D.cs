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
        public static Vector2D? Vector2D(double angle)
        {
            if (double.IsNaN(angle) || double.IsInfinity(angle))
            {
                return null;
            }

            if (angle == 0)
            {
                return Constants.Vector2D.WorldX;
            }

            double xAngle = angle;
            double yAngle = (System.Math.PI / 2) - angle;

            return new Vector2D(System.Math.Cos(xAngle), System.Math.Cos(yAngle));
        }

        /// <summary>
        /// Calculates a vector for a given angle and length.
        /// </summary>
        /// <param name="angle">The angle to the X axis counted counterclockwise [rad].</param>
        /// <param name="length">The length of the vector.</param>
        /// <returns>A Vector2D with specified angle and length; otherwise, null.</returns>
        public static Vector2D? Vector2D(double angle, double length)
        {
            if (double.IsNaN(length) || double.IsInfinity(length))
            {
                return null;
            }

            Vector2D? vector2D = Vector2D(angle);
            if (vector2D == null)
            {
                return null;
            }

            return vector2D * length;
        }

        /// <summary>
        /// Calculates a unit vector based on the specified alignment.
        /// </summary>
        /// <param name="alignment">The desired alignment.</param>
        /// <returns>A unit Vector2D corresponding to the alignment; otherwise, null.</returns>
        public static Vector2D? Vector2D(Alignment alignment)
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

                case Alignment.Undefined:
                    break;

                default:
                    break;
            }

            return null;
        }
    }
}