using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents the result of a 2D intersection operation.
    /// </summary>
    public class IntersectionResult2D : BooleanOperationResult2D, IIntersectionResult2D
    {
        /// <summary>
        /// Gets the type of the boolean operation, which is <see cref="BooleanOpertaionType.Intersection"/>.
        /// </summary>
        public override BooleanOpertaionType BooleanOpertaionType
        {
            get
            {
                return BooleanOpertaionType.Intersection;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class.
        /// </summary>
        public IntersectionResult2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public IntersectionResult2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class using another <see cref="IntersectionResult2D"/> instance.
        /// </summary>
        /// <param name="intersectionResult2D">The <see cref="IntersectionResult2D"/> instance to copy from.</param>
        public IntersectionResult2D(IntersectionResult2D? intersectionResult2D)
            : base(intersectionResult2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class with the specified <see cref="IGeometry2D"/>.
        /// </summary>
        /// <param name="geometry2D">The <see cref="IGeometry2D"/> to initialize the result with. This value can be null.</param>
        public IntersectionResult2D(IGeometry2D? geometry2D)
            : base(geometry2D != null ? [geometry2D] : null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class.
        /// </summary>
        /// <param name="geometry2Ds">An optional collection of <see cref="IGeometry2D"/> objects to be cloned and stored in the result.</param>
        public IntersectionResult2D(IEnumerable<IGeometry2D>? geometry2Ds)
            : base(geometry2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class from a prebuilt list of geometries.
        /// </summary>
        /// <param name="geometry2Ds">The list of geometries resulting from the intersection.</param>
        /// <param name="clone">When <see langword="true"/>, each geometry is cloned defensively; when <see langword="false"/>, the supplied list is adopted directly without cloning. Use <see langword="false"/> only when the caller owns freshly created geometries that are not shared.</param>
        internal IntersectionResult2D(List<IGeometry2D>? geometry2Ds, bool clone)
            : base(geometry2Ds, clone)
        {
        }

        /// <summary>
        /// Creates a copy of the current <see cref="IntersectionResult2D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new IntersectionResult2D(this);
        }
    }
}