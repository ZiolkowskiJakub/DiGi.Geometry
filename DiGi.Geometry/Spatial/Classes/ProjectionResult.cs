using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the result of a projection operation, inheriting from <see cref="PlanarResult"/>.
    /// </summary>
    public class ProjectionResult : PlanarResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionResult"/> class.
        /// </summary>
        public ProjectionResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionResult"/> class using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the projection.</param>
        public ProjectionResult(Plane? plane)
            : base(plane)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionResult"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public ProjectionResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionResult"/> class using an existing <see cref="ProjectionResult"/> instance.
        /// </summary>
        /// <param name="projectionResult">The <see cref="ProjectionResult"/> instance to copy from.</param>
        public ProjectionResult(ProjectionResult? projectionResult)
            : base(projectionResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionResult"/> class with the specified <see cref="Plane"/> and a collection of <see cref="IGeometry2D"/> objects.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the projection.</param>
        /// <param name="geometry2Ds">A collection of <see cref="IGeometry2D"/> objects to be projected.</param>
        public ProjectionResult(Plane? plane, IEnumerable<IGeometry2D>? geometry2Ds)
            : base(plane, geometry2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectionResult"/> class.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the projection.</param>
        /// <param name="geometry2D">The <see cref="IGeometry2D"/> resulting from the projection.</param>
        public ProjectionResult(Plane? plane, IGeometry2D? geometry2D)
            : base(plane, geometry2D)
        {
        }

        /// <summary>
        /// Creates a clone of the current object.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> instance that is a copy of the current object, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new ProjectionResult(this);
        }
    }
}
