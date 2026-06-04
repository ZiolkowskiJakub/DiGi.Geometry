using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two <see cref="Vector3D"/> vectors are parallel within a specified tolerance.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/> vector to evaluate.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/> vector to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance for determining if the vectors are parallel.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two vectors are parallel; returns <c>false</c> if either vector is <c>null</c>.</returns>
        public static bool Parallel(this Vector3D? vector3D_1, Vector3D? vector3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (vector3D_1 is null || vector3D_2 is null)
            {
                return false;
            }

            // Calculate cross product
            double crossX = vector3D_1.Y * vector3D_2.Z - vector3D_1.Z * vector3D_2.Y;
            double crossY = vector3D_1.Z * vector3D_2.X - vector3D_1.X * vector3D_2.Z;
            double crossZ = vector3D_1.X * vector3D_2.Y - vector3D_1.Y * vector3D_2.X;

            // Check if the cross product is (almost) zero vector
            return System.Math.Abs(crossX) < tolerance && System.Math.Abs(crossY) < tolerance && System.Math.Abs(crossZ) < tolerance;
        }
    }
}