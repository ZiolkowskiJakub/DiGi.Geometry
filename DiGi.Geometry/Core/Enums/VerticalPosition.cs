using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Specifies the vertical position of an object relative to a reference point.
    /// </summary>
    [Description("VerticalPosition")]
    public enum VerticalPosition
    {
        /// <summary>
        /// Indicates that the vertical position is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,
        /// <summary>
        /// Indicates that the vertical position is above.
        /// </summary>
        [Description("Above")] Above,
        /// <summary>
        /// Specifies that the position is below.
        /// </summary>
        [Description("Below")] Below,
        /// <summary>
        /// <para>Specifies that the vertical position is On.</para>
        /// </summary>
        [Description("On")] On,
        /// <summary>
        /// Specifies that the vertical position is inside.
        /// </summary>
        [Description("Inside")] Inside
    }
}