namespace DiGi.Geometry.Spatial.Constants
{
    /// <summary>
    /// Provides utility members and constants for 3D point coordinates.
    /// </summary>
    public static class Point3D
    {
        /// <summary>
        /// Gets a <see cref="Classes.Point3D"/> instance representing the origin point with all coordinates set to zero.
        /// </summary>
        public static Classes.Point3D Zero
        {
            get
            {
                return new Classes.Point3D(0, 0, 0);
            }
        }
    }
}