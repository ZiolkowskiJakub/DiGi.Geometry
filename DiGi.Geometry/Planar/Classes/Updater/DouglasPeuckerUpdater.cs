using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Simplify;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Provides functionality to update a 2D geometry using the Douglas-Peucker simplification algorithm.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="DouglasPeuckerUpdater"/> class using default tolerance settings.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="DouglasPeuckerUpdater"/> class with a specified distance tolerance.
    /// </summary>
    /// <param name="tolerance">The <double> value representing the distance tolerance for simplification.</param>
    /// <summary>
    /// Updates the geometry by applying the Douglas-Peucker algorithm to simplify the points based on the defined tolerance.
    /// </summary>
    /// <returns>A <bool> value indicating whether the update process was successful.</returns>
    public class DouglasPeuckerUpdater : GeometryUpdater<IGeometry2D>
    {
        private readonly double tolerance = DiGi.Core.Constants.Tolerance.Distance;

        /// <summary>
        /// Initializes a new instance of the <see cref="DouglasPeuckerUpdater"/> class.
        /// </summary>
        public DouglasPeuckerUpdater()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DouglasPeuckerUpdater"/> class with a specified tolerance.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance used for simplifying geometries.</param>
        public DouglasPeuckerUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Updates the current value by simplifying its underlying geometry using the Douglas-Peucker simplification algorithm.
        /// </summary>
        /// <returns>A <see cref="bool"/> indicating whether the update was successful. Returns <see cref="false"/> if the value is null or cannot be simplified; otherwise, returns <see cref="true"/>.</returns>
        public override bool Update()
        {
            if (Value == null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry? geometry = Value?.ToNTS();
            if (geometry == null)
            {
                return false;
            }

            IGeometry2D? value_Temp = DouglasPeuckerSimplifier.Simplify(geometry, tolerance)?.ToDiGi();
            if (value_Temp is null)
            {
                return false;
            }

            Value = value_Temp;
            return true;
        }
    }
}