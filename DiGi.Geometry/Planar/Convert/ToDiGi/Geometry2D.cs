using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static IGeometry2D? ToDiGi(this NetTopologySuite.Geometries.Geometry? geometry)
        {
            if(geometry == null)
            {
                return null;
            }

            if(geometry is Point point)
            {
                return point.ToDiGi();
            }

            if(geometry is LinearRing linearRing)
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

            if(geometry is GeometryCollection geometryCollection)
            {
                return geometryCollection.ToDiGi();
            }

            throw new System.NotImplementedException();
        }
    }
}
