namespace DiGi.Geometry.Spatial.Constants
{
    /// <summary>
    /// Provides static utility properties for common 3D vector directions.
    /// </summary>
    /// <summary>
    /// Gets a <see cref="Classes.Vector3D"/> representing the X-axis unit vector (1, 0, 0).
    /// </summary>
    /// <value>A <see cref="Classes.Vector3D"/> instance pointing along the positive X-axis.</value>
    /// <summary>
    /// Gets a <see cref="Classes.Vector3D"/> representing the Y-axis unit vector (0, 1, 0).
    /// </summary>
    /// <value>A <see cref="Classes.Vector3D"/> instance pointing along the positive Y-axis.</value>
    /// <summary>
    /// Gets a <see cref="Classes.Vector3D"/> representing the Z-axis unit vector (0, 0, 1).
    /// </summary>
    /// <value>A <see cref="Classes.Vector3D"/> instance pointing along the positive Z-axis.</value>
    public static class Vector3D
    {
        /// <summary>
        /// Gets the unit vector representing the X-axis in world space.
        /// </summary>
        /// <value>A <see cref="Classes.Vector3D"/> instance that represents the X-axis.</value>
        public static Classes.Vector3D WorldX
        {
            get
            {
                return new Classes.Vector3D(1, 0, 0);
            }
        }

        /// <summary>
        /// Gets the unit vector representing the Y-axis in world space as a <see cref="Classes.Vector3D"/>.
        /// </summary>
        public static Classes.Vector3D WorldY
        {
            get
            {
                return new Classes.Vector3D(0, 1, 0);
            }
        }

        /// <summary>
        /// Gets the unit vector pointing along the positive Z-axis of the world coordinate system as a <see cref="Classes.Vector3D"/>.
        /// </summary>
        public static Classes.Vector3D WorldZ
        {
            get
            {
                return new Classes.Vector3D(0, 0, 1);
            }
        }

        /// <summary>
        /// Gets a <see cref="Classes.Vector3D"/> where all coordinates are set to 0.
        /// </summary>
        public static Classes.Vector3D Zero
        {
            get
            {
                return new Classes.Vector3D(0, 0, 0);
            }
        }
    }
}