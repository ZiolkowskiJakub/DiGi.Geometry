using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates an X-axis vector perpendicular to the specified <see cref="Vector3D"/> normal.
        /// </summary>
        /// <param name="normal">The <see cref="Vector3D"/> normal vector used as a reference.</param>
        /// <returns>A <see cref="Vector3D"/> representing the calculated X-axis, or null if the provided <see cref="Vector3D"/> normal is null.</returns>
        public static Vector3D? AxisX(this Vector3D? normal)
        {
            if (normal == null)
            {
                return null;
            }

            if (normal.X == 0 && normal.Y == 0)
            {
                return Constants.Vector3D.WorldX;
            }

            return new Vector3D(normal.Y, -normal.X, 0).Unit;
        }

        /// <summary>
        /// Calculates the X-axis vector based on a normal vector and a Y-axis vector.
        /// </summary>
/// <param name="normal">The <c>Vector3D?</c> normal vector.</param>
/// <param name="axisY">The <c>Vector3D?</c> Y-axis vector.</param>
/// <returns>A <c>Vector3D?</c> representing the unit X-axis vector, or null if either the normal or axisY is null.</returns>
        public static Vector3D? AxisX(this Vector3D? normal, Vector3D? axisY)
        {
            if (normal == null || axisY == null)
            {
                return null;
            }

            return axisY.CrossProduct(normal)?.Unit;
        }
    }
}