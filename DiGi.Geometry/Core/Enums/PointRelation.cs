namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Represents the spatial relation of a point to the boundary of a closed region - a polygonal face in the plane or a volume in space.
    /// </summary>
    public enum PointRelation
    {
        /// <summary>
        /// The relation could not be determined.
        /// </summary>
        Undefined,

        /// <summary>
        /// The point lies outside the region.
        /// </summary>
        Outside,

        /// <summary>
        /// The point lies on the boundary (within tolerance).
        /// </summary>
        On,

        /// <summary>
        /// The point lies strictly inside the region.
        /// </summary>
        Inside
    }
}