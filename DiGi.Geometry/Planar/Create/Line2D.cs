using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a line with the specified origin and angle.
        /// </summary>
        /// <param name="origin">The origin point of the line.</param>
        /// <param name="angle">The angle of the line in radians.</param>
        /// <returns>A new Line2D; otherwise, null if origin is null or angle is invalid.</returns>
        public static Line2D? Line2D(this Point2D? origin, double angle)
        {
            if (origin == null || double.IsNaN(angle) || double.IsInfinity(angle))
            {
                return null;
            }

            return new Line2D(origin, Vector2D(angle));
        }
    }
}