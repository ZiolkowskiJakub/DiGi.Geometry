using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two <c>Vector3D?</c> vectors are perpendicular within a specified tolerance.
        /// </summary>
        /// <param name="vector3D_1">The first <c>Vector3D?</c> vector.</param>
        /// <param name="vector3D_2">The second <c>Vector3D?</c> vector.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value used to determine if the vectors are perpendicular.</param>
        /// <returns>A <see cref="bool" /> value indicating whether the two <c>Vector3D?</c> vectors are perpendicular.</returns>
        public static bool Perpendicular(this Vector3D? vector3D_1, Vector3D? vector3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (vector3D_1 == vector3D_2)
            {
                return false;
            }

            if (vector3D_1?.Unit is not Vector3D unit_1 || vector3D_2?.Unit is not Vector3D unit_2)
            {
                return false;
            }

            return System.Math.Abs(unit_1.DotProduct(unit_2)) <= tolerance;
        }

        /// <summary>
        /// Determines whether two planes are perpendicular within a specified tolerance.
        /// </summary>
        /// <param name="plane_1">The first <see cref="Plane"/> to evaluate.</param>
        /// <param name="plane_2">The second <see cref="Plane"/> to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance for the perpendicularity check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two planes are perpendicular.</returns>
        public static bool Perpendicular(this Plane? plane_1, Plane? plane_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane_1 == plane_2 || plane_1 == null || plane_2 == null)
            {
                return false;
            }

            double double_A1 = plane_1.A;
            double double_B1 = plane_1.B;
            double double_C1 = plane_1.C;

            double double_A2 = plane_2.A;
            double double_B2 = plane_2.B;
            double double_C2 = plane_2.C;

            if (double.IsNaN(double_A1) || double.IsNaN(double_B1) || double.IsNaN(double_C1) ||
                double.IsNaN(double_A2) || double.IsNaN(double_B2) || double.IsNaN(double_C2))
            {
                return false;
            }

            double double_Dot = double_A1 * double_A2 + double_B1 * double_B2 + double_C1 * double_C2;
            return System.Math.Abs(double_Dot) <= tolerance;
        }
    }
}