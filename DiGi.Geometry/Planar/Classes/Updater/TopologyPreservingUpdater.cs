using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Simplify;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Provides functionality to update an <see cref="IGeometry2D"/> while preserving its topological structure.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="TopologyPreservingUpdater"/> class using the default distance tolerance.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="TopologyPreservingUpdater"/> class with a specified distance tolerance.
    /// </summary>
    /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
    /// <summary>
    /// Gets or sets the <see cref="IGeometry2D"/> instance to be updated.
    /// </summary>
    /// <summary>
    /// Updates the geometry while preserving its topology.
    /// </summary>
    /// <returns>A <see cref="bool"/> value indicating whether the update operation was successful.</returns>
    public class TopologyPreservingUpdater : IGeometryUpdater<IGeometry2D>
    {
        private readonly double tolerance = DiGi.Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyPreservingUpdater"/> class.
        /// </summary>
        public TopologyPreservingUpdater()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyPreservingUpdater"/> class with the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> value used as the tolerance for preserving topology during updates.</param>
        public TopologyPreservingUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Gets or sets the <see cref="IGeometry2D"/> value.
        /// </summary>
        public IGeometry2D? Value { get; set; }

        /// <summary>
        /// Updates the current value by simplifying its geometry while preserving topology.
        /// </summary>
        /// <returns>A <see cref="bool"/> indicating whether the update was successful; returns <see langword="true"/> if the value was successfully simplified and updated, otherwise <see langword="false"/>.</returns>
        public bool Update()
        {
            if (Value is null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry? geometry = Value?.ToNTS();
            if (geometry == null)
            {
                return false;
            }

            IGeometry2D? value_Temp = TopologyPreservingSimplifier.Simplify(geometry, tolerance)?.ToDiGi();
            if (value_Temp is null)
            {
                return false;
            }

            Value = value_Temp;
            return true;
        }
    }
}