using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the result of a 3D difference operation.
    /// </summary>
    public class DifferenceResult3D : BooleanOperationResult3D, IDifferenceResult3D
    {
        /// <summary>
        /// Gets the type of the boolean operation, which is <see cref="BooleanOpertaionType.Difference"/>.
        /// </summary>
        public override BooleanOpertaionType BooleanOpertaionType
        {
            get
            {
                return BooleanOpertaionType.Difference;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferenceResult3D"/> class.
        /// </summary>
        public DifferenceResult3D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferenceResult3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public DifferenceResult3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferenceResult3D"/> class using another <see cref="DifferenceResult3D"/> instance.
        /// </summary>
        /// <param name="differenceResult3D">The <see cref="DifferenceResult3D"/> instance to copy from.</param>
        public DifferenceResult3D(DifferenceResult3D? differenceResult3D)
            : base(differenceResult3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferenceResult3D"/> class with the specified <see cref="IGeometry3D"/>.
        /// </summary>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> to initialize the result with. This value can be null.</param>
        public DifferenceResult3D(IGeometry3D? geometry3D)
            : base(geometry3D != null ? [geometry3D] : null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DifferenceResult3D"/> class.
        /// </summary>
        /// <param name="geometry3Ds">An optional collection of <see cref="IGeometry3D"/> objects to be cloned and stored in the result.</param>
        public DifferenceResult3D(IEnumerable<IGeometry3D>? geometry3Ds)
            : base(geometry3Ds)
        {
        }

        /// <summary>
        /// Creates a copy of the current <see cref="DifferenceResult3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new DifferenceResult3D(this);
        }
    }
}