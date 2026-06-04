using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="NetTopologySuite.Geometries.Geometry"/> to an <see cref="IGeometry2D"/>.
        /// </summary>
        /// <param name="geometry">The <see cref="NetTopologySuite.Geometries.Geometry"/> instance to convert.</param>
        /// <returns>An <see cref="IGeometry2D"/> representation of the geometry, or <c>null</c> if the provided <see cref="NetTopologySuite.Geometries.Geometry"/> is <c>null</c>.</returns>
        public static IGeometry2D? ToDiGi(this NetTopologySuite.Geometries.Geometry? geometry)
        {
            if (geometry == null)
            {
                return null;
            }

            if (geometry is Point point)
            {
                return point.ToDiGi();
            }

            if (geometry is LinearRing linearRing)
            {
                return linearRing.ToDiGi();
            }

            if (geometry is LineString lineString)
            {
                return lineString.ToDiGi();
            }

            if (geometry is Polygon polygon)
            {
                return polygon.ToDiGi();
            }

            if (geometry is GeometryCollection geometryCollection)
            {
                return geometryCollection.ToDiGi();
            }

            throw new System.NotImplementedException();
        }
    }
}