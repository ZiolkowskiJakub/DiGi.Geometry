namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Represents the spatial relation of a point to the boundary of a closed 3D volume.
    /// </summary>
    public enum PointRelation
    {
        /// <summary>
        /// The relation could not be determined.
        /// </summary>
        Undefined,

        /// <summary>
        /// The point lies outside the volume.
        /// </summary>
        Outside,

        /// <summary>
        /// The point lies on the boundary surface (within tolerance).
        /// </summary>
        On,

        /// <summary>
        /// The point lies strictly inside the volume.
        /// </summary>
        Inside
    }
}