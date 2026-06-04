using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Provides functionality to update geometry by snapping it based on a specified tolerance.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="SnapperUpdater"/> class using the default distance tolerance.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="SnapperUpdater"/> class with a specified distance tolerance.
    /// </summary>
    /// <param name="tolerance">The double value representing the snapping tolerance.</param>
    /// <summary>
    /// Gets or sets the <see cref="IGeometry2D"/> object to be updated.
    /// </summary>
    /// <summary>
    /// Updates the current geometry value by applying snapping logic.
    /// </summary>
    /// <returns>A boolean value indicating whether the update was successful or if changes were applied.</returns>
    public class SnapperUpdater : IGeometryUpdater<IGeometry2D>
    {
        private readonly double tolerance = DiGi.Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapperUpdater"/> class.
        /// </summary>
        public SnapperUpdater()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapperUpdater"/> class.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for snapping operations.</param>
        public SnapperUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Gets or sets the <see cref="IGeometry2D"/> value to be processed during the update operation.
        /// </summary>
        /// <value>The <see cref="IGeometry2D"/> instance.</value>
        public IGeometry2D? Value { get; set; }

        /// <summary>
        /// Updates the current value by snapping the geometry to itself using a specified tolerance.
        /// </summary>
        /// <returns>A <bool> indicating whether the update operation was successful.</returns>
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

            IGeometry2D? geometry2D = NetTopologySuite.Operation.Overlay.Snap.GeometrySnapper.SnapToSelf(geometry, tolerance, true)?.ToDiGi();
            if (geometry2D == null)
            {
                return false;
            }

            Value = geometry2D;

            return true;
        }
    }
}