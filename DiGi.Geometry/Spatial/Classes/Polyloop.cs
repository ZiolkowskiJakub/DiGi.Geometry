using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a closed polyline in 3D space.
    /// </summary>
    public class Polyloop : Segmentable3D, IClosedCurve3D, ISegmentable3D, IInvertible3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polyloop"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public Polyloop(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyloop"/> class.
        /// </summary>
        public Polyloop()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyloop"/> class by copying the points from an existing <see cref="Polyloop"/> instance.
        /// </summary>
        /// <param name="polyloop">The source <see cref="Polyloop"/> instance to copy from. This parameter can be null.</param>
        public Polyloop(Polyloop? polyloop)
            : base(polyloop)
        {
            points = polyloop?.points.Clone()?.FilterNulls() ?? [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyloop"/> class using a collection of <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">An optional collection of <see cref="Point3D"/> objects that define the points of the loop.</param>
        public Polyloop(IEnumerable<Point3D>? point3Ds)
        {
            points = point3Ds?.Clone()?.FilterNulls() ?? [];
        }

        /// <summary>
        /// Gets the perimeter of the object.
        /// </summary>
        /// <returns>A <see cref="double"/> value representing the total length of the perimeter.</returns>
        public double GetPerimeter()
        {
            return Length;
        }

        /// <summary>
        /// Gets the collection of 3D segments.
        /// </summary>
        /// <returns>A <see cref="List{Segment3D}"/> containing the generated 3D segments, or null if no segments are available.</returns>
        public override List<Segment3D>? GetSegments()
        {
            return Create.Segment3Ds(points, true);
        }
    }
}
