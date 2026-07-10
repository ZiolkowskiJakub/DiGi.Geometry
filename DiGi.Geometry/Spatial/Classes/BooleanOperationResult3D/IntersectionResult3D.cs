using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the result of a 3D intersection operation.
    /// </summary>
    public class IntersectionResult3D : BooleanOperationResult3D, IIntersectionResult3D
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
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class.
        /// </summary>
        public IntersectionResult3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public IntersectionResult3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class using another <see cref="IntersectionResult3D"/> instance.
        /// </summary>
        /// <param name="intersectionResult3D">The <see cref="IntersectionResult3D"/> instance to copy from.</param>
        public IntersectionResult3D(IntersectionResult3D? intersectionResult3D)
            : base(intersectionResult3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class with the specified <see cref="IGeometry3D"/>.
        /// </summary>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> to initialize the result with. This value can be null.</param>
        public IntersectionResult3D(IGeometry3D? geometry3D)
            : base(geometry3D != null ? [geometry3D] : null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class.
        /// </summary>
        /// <param name="geometry3Ds">An optional collection of <see cref="IGeometry3D"/> objects to be cloned and stored in the result.</param>
        public IntersectionResult3D(IEnumerable<IGeometry3D>? geometry3Ds)
            : base(geometry3Ds)
        {
        }

        /// <summary>
        /// Creates a copy of the current <see cref="IntersectionResult3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new IntersectionResult3D(this);
        }
    }
}