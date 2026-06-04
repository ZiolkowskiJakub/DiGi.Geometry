using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a copy of the specified <see cref="Vector3D"/>, with an option to normalize the resulting vector.
        /// </summary>
        /// <param name="vector3D">The source <see cref="Vector3D"/> instance to be copied.</param>
        /// <param name="normalize">A <see cref="bool"/> value indicating whether the returned vector should be normalized.</param>
        /// <returns>A new <see cref="Vector3D"/> instance if the provided <see cref="Vector3D"/> is not null; otherwise, returns null.</returns>
        public static Vector3D? Vector3D(Vector3D? vector3D, bool normalize = false)
        {
            if (vector3D == null)
            {
                return null;
            }

            Vector3D result = new(vector3D);
            if (normalize)
            {
                result.Normalize();
            }

            return result;
        }
    }
}