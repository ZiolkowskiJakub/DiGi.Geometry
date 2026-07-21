using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents the result of a 2D union operation.
    /// </summary>
    public class UnionResult2D : BooleanOperationResult2D, IUnionResult2D
    {
        /// <summary>
        /// Gets the type of the boolean operation, which is <see cref="BooleanOpertaionType.Union"/>.
        /// </summary>
        public override BooleanOpertaionType BooleanOpertaionType
        {
            get
            {
                return BooleanOpertaionType.Union;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionResult2D"/> class.
        /// </summary>
        public UnionResult2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionResult2D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public UnionResult2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionResult2D"/> class using another <see cref="UnionResult2D"/> instance.
        /// </summary>
        /// <param name="unionResult2D">The <see cref="UnionResult2D"/> instance to copy from.</param>
        public UnionResult2D(UnionResult2D? unionResult2D)
            : base(unionResult2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionResult2D"/> class with the specified <see cref="IGeometry2D"/>.
        /// </summary>
        /// <param name="geometry2D">The <see cref="IGeometry2D"/> to initialize the result with. This value can be null.</param>
        public UnionResult2D(IGeometry2D? geometry2D)
            : base(geometry2D != null ? [geometry2D] : null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionResult2D"/> class.
        /// </summary>
        /// <param name="geometry2Ds">An optional collection of <see cref="IGeometry2D"/> objects to be cloned and stored in the result.</param>
        public UnionResult2D(IEnumerable<IGeometry2D>? geometry2Ds)
            : base(geometry2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnionResult2D"/> class from a prebuilt list of geometries.
        /// </summary>
        /// <param name="geometry2Ds">The list of geometries resulting from the union.</param>
        /// <param name="clone">When <see langword="true"/>, each geometry is cloned defensively; when <see langword="false"/>, the supplied list is adopted directly without cloning. Use <see langword="false"/> only when the caller owns freshly created geometries that are not shared.</param>
        internal UnionResult2D(List<IGeometry2D>? geometry2Ds, bool clone)
            : base(geometry2Ds, clone)
        {
        }

        /// <summary>
        /// Creates a copy of the current <see cref="UnionResult2D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new UnionResult2D(this);
        }
    }
}