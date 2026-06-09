using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the Y-axis vector based on the provided normal vector.
        /// </summary>
/// <param name="normal">The <c>Vector3D?</c> normal vector used as a basis for calculating the Y-axis.</param>
/// <returns>A <c>Vector3D?</c> representing the Y-axis, or null if the provided normal is null.</returns>
        public static Vector3D? AxisY(this Vector3D? normal)
        {
            if (normal == null)
            {
                return null;
            }

            return AxisY(normal, AxisX(normal));
        }

        /// <summary>
        /// Calculates the Y-axis vector by computing the cross product of the normal and the X-axis, then normalizing the result.
        /// </summary>
        /// <param name="normal">The <see cref="Vector3D"/> representing the normal vector.</param>
        /// <param name="axisX">The <see cref="Vector3D"/> representing the X-axis vector.</param>
        /// <returns>A <see cref="Vector3D"/> representing the normalized Y-axis if both inputs are non-null and a valid unit vector can be derived; otherwise, null.</returns>
        public static Vector3D? AxisY(this Vector3D? normal, Vector3D? axisX)
        {
            if (normal == null || axisX == null)
            {
                return null;
            }

            return normal.CrossProduct(axisX)?.Unit;
        }
    }
}