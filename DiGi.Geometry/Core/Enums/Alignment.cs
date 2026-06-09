using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Specifies the alignment orientation.
    /// </summary>
    [Description("Alignment")]
    public enum Alignment
    {
        /// <summary>
        /// <para>Specifies that the alignment is undefined.</para>
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Represents horizontal alignment.
        /// </summary>
        [Description("Horizontal")] Horizontal,

        /// <summary>
        /// Specifies vertical alignment.
        /// </summary>
        [Description("Vertical")] Vertical,
    }
}