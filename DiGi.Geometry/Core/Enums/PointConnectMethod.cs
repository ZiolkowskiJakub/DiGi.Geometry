using System.ComponentModel;

namespace DiGi.Geometry.Core.Enums
{
    /// <summary>
    /// Specifies the method used to connect points.
    /// </summary>
    [Description("PointConnectMethod")]
    public enum PointConnectMethod
    {
        /// <summary>
        /// Indicates that the point connection method is undefined or not specified.
        /// </summary>
        [Description("Undefined")] Undefined,
        /// <summary>
        /// Specifies that the point connection method uses the ends.
        /// </summary>
        [Description("Ends")] Ends,
        /// <summary>
        /// Specifies that the connection between points is established using a projection method.
        /// </summary>
        [Description("Projection")] Projection
    }
}