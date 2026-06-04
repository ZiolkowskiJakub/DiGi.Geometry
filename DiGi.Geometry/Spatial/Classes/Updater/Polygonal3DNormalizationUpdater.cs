using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Updates the normalization of a 3D polygonal geometry to ensure it matches a specified orientation.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Polygonal3DNormalizationUpdater"/> class.
    /// </summary>
    /// <param name="orientation">The target <see cref="Orientation"/> to which the geometry should be normalized.</param>
    /// <summary>
    /// Determines whether the current 3D polygonal geometry is already normalized according to the specified orientation.
    /// </summary>
    /// <returns>True if the geometry's orientation matches the target <see cref="Orientation"/>; otherwise, false.</returns>
    /// <summary>
    /// Updates the normalization of the 3D polygonal geometry.
    /// </summary>
    /// <returns>True if the geometry was updated; otherwise, false.</returns>
    public class Polygonal3DNormalizationUpdater : GeometryUpdater<IPolygonal3D>, Core.Interfaces.INormalizationUpdater<IPolygonal3D>
    {
        private readonly Orientation orientation;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygonal3DNormalizationUpdater"/> class.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> to which the polygonal 3D object should be normalized.</param>
        public Polygonal3DNormalizationUpdater(Orientation orientation)
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
        /// Updates the orientation of the current value.
        /// </summary>
        /// <returns>A <see cref="bool"/> indicating whether the update operation was successful.</returns>
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