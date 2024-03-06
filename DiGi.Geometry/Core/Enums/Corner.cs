using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    [Description("Corner")]
    public enum Corner
    {
        [Description("Undefined")] Undefined,
        [Description("Bottom Left")] BottomLeft,
        [Description("Bottom Right")] BottomRight,
        [Description("Top Right")] TopRight,
        [Description("Top Left")] TopLeft
    }
}
