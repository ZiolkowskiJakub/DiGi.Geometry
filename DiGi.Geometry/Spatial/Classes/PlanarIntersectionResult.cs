using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the result of a planar intersection operation in 3D space.
    /// </summary>
    public class PlanarIntersectionResult : PlanarResult, IIntersectionResult3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarIntersectionResult"/> class.
        /// </summary>
        public PlanarIntersectionResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarIntersectionResult"/> class using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used to initialize the result.</param>
        public PlanarIntersectionResult(Plane? plane)
            : base(plane)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarIntersectionResult"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public PlanarIntersectionResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarIntersectionResult"/> class using another <see cref="PlanarIntersectionResult"/> instance.
        /// </summary>
        /// <param name="planarIntersectionResult">The <see cref="PlanarIntersectionResult"/> instance to copy from.</param>
        public PlanarIntersectionResult(PlanarIntersectionResult? planarIntersectionResult)
            : base(planarIntersectionResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarIntersectionResult"/> class with the specified plane and a collection of 2D geometries.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> that defines the planar intersection, or null if not applicable.</param>
        /// <param name="geometry2Ds">An <see cref="IEnumerable{IGeometry2D}"/> containing the 2D geometries resulting from the intersection, or null if no geometries were found.</param>
        public PlanarIntersectionResult(Plane? plane, IEnumerable<IGeometry2D>? geometry2Ds)
            : base(plane, geometry2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarIntersectionResult"/> class.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the intersection.</param>
        /// <param name="geometry2D">The <see cref="IGeometry2D"/> resulting from the intersection.</param>
        public PlanarIntersectionResult(Plane? plane, IGeometry2D? geometry2D)
            : base(plane, geometry2D)
        {
        }

        /// <summary>
        /// Gets a value indicating whether an intersection exists.
        /// </summary>
        /// <value>A <see cref="bool"/> value that is true if the count of intersecting elements is greater than zero; otherwise, false.</value>
        [JsonIgnore]
        public bool Intersect
        {
            get
            {
                return Count > 0;
            }
        }

        /// <summary>
        /// Creates a copy of the current <see cref="PlanarIntersectionResult"/> instance.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> that is a clone of the current instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new PlanarIntersectionResult(this);
        }
    }
}
