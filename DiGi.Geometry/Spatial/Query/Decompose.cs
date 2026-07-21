using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Decomposes an affine 3D transformation matrix into its translation vector, pure rotation matrix, and scale factors.
        /// </summary>
        /// <param name="transform3D">The source <see cref="Transform3D"/> matrix to decompose.</param>
        /// <param name="translation">When this method returns, contains the extracted translation <see cref="Vector3D"/>, or null if decomposition fails.</param>
        /// <param name="rotation">When this method returns, contains the extracted pure rotation <see cref="Transform3D"/> matrix, or null if decomposition fails.</param>
        /// <param name="scale">When this method returns, contains the extracted scale factors as a <see cref="Vector3D"/>, or null if decomposition fails.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the matrix was successfully decomposed.</returns>
        public static bool Decompose(this Transform3D? transform3D, out Vector3D? translation, out Transform3D? rotation, out Vector3D? scale)
        {
            translation = null;
            rotation = null;
            scale = null;

            if (transform3D is null || transform3D.Matrix4D is null)
            {
                return false;
            }

            translation = new Vector3D(transform3D[0, 3], transform3D[1, 3], transform3D[2, 3]);

            double scaleX = System.Math.Sqrt(transform3D[0, 0] * transform3D[0, 0] + transform3D[1, 0] * transform3D[1, 0] + transform3D[2, 0] * transform3D[2, 0]);
            double scaleY = System.Math.Sqrt(transform3D[0, 1] * transform3D[0, 1] + transform3D[1, 1] * transform3D[1, 1] + transform3D[2, 1] * transform3D[2, 1]);
            double scaleZ = System.Math.Sqrt(transform3D[0, 2] * transform3D[0, 2] + transform3D[1, 2] * transform3D[1, 2] + transform3D[2, 2] * transform3D[2, 2]);

            scale = new Vector3D(scaleX, scaleY, scaleZ);

            if (scaleX < 1e-12 || scaleY < 1e-12 || scaleZ < 1e-12)
            {
                return false;
            }

            DiGi.Math.Classes.Matrix4D? matrix4D_Rot = Math.Create.Matrix4D.Identity();
            if (matrix4D_Rot is null)
            {
                return false;
            }

            matrix4D_Rot[0, 0] = transform3D[0, 0] / scaleX;
            matrix4D_Rot[1, 0] = transform3D[1, 0] / scaleX;
            matrix4D_Rot[2, 0] = transform3D[2, 0] / scaleX;

            matrix4D_Rot[0, 1] = transform3D[0, 1] / scaleY;
            matrix4D_Rot[1, 1] = transform3D[1, 1] / scaleY;
            matrix4D_Rot[2, 1] = transform3D[2, 1] / scaleY;

            matrix4D_Rot[0, 2] = transform3D[0, 2] / scaleZ;
            matrix4D_Rot[1, 2] = transform3D[1, 2] / scaleZ;
            matrix4D_Rot[2, 2] = transform3D[2, 2] / scaleZ;

            rotation = new Transform3D(matrix4D_Rot);
            return true;
        }
    }
}