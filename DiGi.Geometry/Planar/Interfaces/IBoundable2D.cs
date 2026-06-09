using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IBoundable2D : IGeometry2D, IBoundable, ICollectable2D
    {
        /// <summary>
        /// Gets the bounding box of the geometry.
        /// </summary>
        /// <returns>The bounding box if available; otherwise, null.</returns>
        BoundingBox2D? GetBoundingBox();
    }
}