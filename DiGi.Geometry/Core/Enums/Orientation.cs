using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Specifies the orientation of three points in a two-dimensional plane.
    /// </summary>
    [Description("Orientation")]
    public enum Orientation
    {
        /// <summary>
        /// Represents an undefined orientation.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Indicates that the points are collinear, meaning they lie on the same straight line.
        /// </summary>
        [Description("Collinear")] Collinear,

        /// <summary>
        /// Specifies a clockwise orientation.
        /// </summary>
        [Description("Clockwise")] Clockwise,

        /// <summary>
        /// Specifies an orientation that is counter-clockwise.
        /// </summary>
        [Description("CounterClockwise")] CounterClockwise
    }
}