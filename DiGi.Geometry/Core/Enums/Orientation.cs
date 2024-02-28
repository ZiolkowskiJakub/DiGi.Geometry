using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    [Description("Orientation")]
    public enum Orientation
    {
        [Description("Undefined")] Undefined,
        [Description("Collinear")] Collinear,
        [Description("Clockwise")] Clockwise,
        [Description("CounterClockwise")] CounterClockwise
    }
}
