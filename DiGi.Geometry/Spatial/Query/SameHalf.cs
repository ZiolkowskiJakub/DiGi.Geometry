using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two vectors are within the same half-space based on a specified tolerance.
        /// </summary>
/// <param name="vector3D_1">The first <c>Vector3D?</c> vector to compare.</param>
/// <param name="vector3D_2">The second <c>Vector3D?</c> vector to compare.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance for the angle comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the vectors are in the same half; returns <c>false</c> if either vector is <c>null</c>.</returns>
        public static bool SameHalf(this Vector3D? vector3D_1, Vector3D? vector3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (vector3D_1 == null || vector3D_2 == null)
            {
                return false;
            }

            return vector3D_1.Angle(vector3D_2) - tolerance <= vector3D_1.Angle(vector3D_1.GetInversed());
        }
    }
}