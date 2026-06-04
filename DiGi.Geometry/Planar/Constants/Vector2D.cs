namespace DiGi.Geometry.Planar.Constants
{
    /// <summary>
    /// Provides static properties and utility methods for working with <see cref="Classes.Vector2D"/> instances.
    /// </summary>
    public static class Vector2D
    {
        /// <summary>
        /// Gets the unit vector along the X-axis (1, 0).
        /// </summary>
        public static Classes.Vector2D WorldX
        {
            get
            {
                return new Classes.Vector2D(1, 0);
            }
        }

        /// <summary>
        /// Gets the unit vector along the Y-axis (0, 1).
        /// </summary>
        public static Classes.Vector2D WorldY
        {
            get
            {
                return new Classes.Vector2D(0, 1);
            }
        }
    }
}