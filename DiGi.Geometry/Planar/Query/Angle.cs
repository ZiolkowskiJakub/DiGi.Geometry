using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the angle formed by three <see cref="Point2D"/> points, where the second point is the vertex of the angle.
        /// </summary>
        /// <param name="point2D_Previous">The first <see cref="Point2D"/> point.</param>
        /// <param name="point2D">The <see cref="Point2D"/> point that serves as the vertex of the angle.</param>
        /// <param name="point2D_Next">The third <see cref="Point2D"/> point.</param>
        /// <returns>A <see cref="double"/> representing the angle between the vectors, or <see cref="double.NaN"/> if any of the <see cref="Point2D"/> parameters are null.</returns>
        public static double Angle(this Point2D point2D_Previous, Point2D point2D, Point2D point2D_Next)
        {
            if (point2D_Previous == null || point2D == null || point2D_Next == null)
            {
                return double.NaN;
            }

            return (new Vector2D(point2D, point2D_Previous).Angle(new Vector2D(point2D, point2D_Next)));
        }
    }
}