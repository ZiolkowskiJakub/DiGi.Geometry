using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Provides functionality to update and verify the normalization of a 2D polygonal geometry based on a specified orientation.
    /// </summary>
    public class Polygonal2DNormalizationUpdater : GeometryUpdater<IPolygonal2D>, Core.Interfaces.INormalizationUpdater<IPolygonal2D>
    {
        private readonly Orientation orientation;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygonal2DNormalizationUpdater"/> class.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> that the polygonal 2D object should be normalized to.</param>
        public Polygonal2DNormalizationUpdater(Orientation orientation)
        {
            this.orientation = orientation;
        }

        /// <summary>
        /// Determines whether the current value is normalized based on the specified orientation.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating true if the value is normalized; otherwise, false.</returns>
        public bool Normalized()
        {
            return Query.Orientation(Value) == orientation;
        }

        /// <summary>
        /// Updates the orientation of the value.
        /// </summary>
        /// <returns>A <see cref="bool"/> indicating whether the update was successful; returns <c>false</c> if the value is null.</returns>
        public override bool Update()
        {
            if (Value is null)
            {
                return false;
            }

            return Value.Orient(orientation);
        }
    }
}
