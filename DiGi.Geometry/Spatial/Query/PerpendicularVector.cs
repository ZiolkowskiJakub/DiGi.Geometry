using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates a vector that is perpendicular to the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> for which to find a perpendicular vector.</param>
        /// <param name="tolerance">A <see cref="double"/> value used to determine the alignment of the input vector relative to world axes.</param>
        /// <returns>A <see cref="Vector3D"/> that is perpendicular to the input vector, or <see langword="null"/> if the input <see cref="Vector3D"/> is <see langword="null"/>.</returns>
        public static Vector3D? PerpendicularVector(this Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (vector3D == null)
            {
                return null;
            }

            Vector3D? vector3D_Temp = System.Math.Abs(vector3D.X) > 1 - tolerance && System.Math.Abs(vector3D.Y) < tolerance && System.Math.Abs(vector3D.Z) < tolerance ? Constants.Vector3D.WorldY : Constants.Vector3D.WorldX;

            return vector3D.CrossProduct(vector3D_Temp);
        }
    }
}