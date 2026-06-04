using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Specifies the position of a corner.
    /// </summary>
    [Description("Corner")]
    public enum Corner
    {
        /// <summary>
        /// <para>Represents an undefined corner.</para>
        /// </summary>
        [Description("Undefined")] Undefined,
        /// <summary>
        /// Represents the bottom left corner.
        /// </summary>
        [Description("Bottom Left")] BottomLeft,
        /// <summary>
        /// <para>Represents the bottom right corner.</para>
        /// </summary>
        [Description("Bottom Right")] BottomRight,
        /// <summary>
        /// Represents the top right corner.
        /// </summary>
        [Description("Top Right")] TopRight,
        /// <summary>
        /// Represents the top left corner.
        /// </summary>
        [Description("Top Left")] TopLeft
    }
}