namespace DiGi.Geometry.Spatial.Constants
{
    /// <summary>
    /// Provides common world plane definitions.
    /// </summary>
    public static class Plane
    {
        /// <summary>
        /// Gets a <see cref="Classes.Plane"/> representing the world X plane, which is perpendicular to the world X axis and passes through the origin.
        /// </summary>
        public static Classes.Plane WorldX
        {
            get
            {
                return new Classes.Plane(Point3D.Zero, Vector3D.WorldX);
            }
        }

        /// <summary>
        /// Gets a <see cref="Classes.Plane"/> representing the world Y plane, defined by the origin point and the world Y normal vector.
        /// </summary>
        /// <value>A <see cref="Classes.Plane"/> that is perpendicular to the world Y axis.</value>
        public static Classes.Plane WorldY
        {
            get
            {
                return new Classes.Plane(Point3D.Zero, Vector3D.WorldY);
            }
        }

        /// <summary>
        /// Gets a <see cref="Classes.Plane"/> representing the world Z plane.
        /// </summary>
        public static Classes.Plane WorldZ
        {
            get
            {
                return new Classes.Plane(Point3D.Zero, Vector3D.WorldZ);
            }
        }
    }
}