using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static IGeometry2D ToDiGi(this NetTopologySuite.Geometries.Geometry geometry)
        {
            if(geometry == null)
            {
                return null;
            }

            if(geometry is Point)
            {
                return ((Point)geometry).ToDiGi();
            }

            if(geometry is LinearRing)
            {
                return ((LinearRing)geometry).ToDiGi();
            }

            if (geometry is LineString)
            {
                return ((LineString)geometry).ToDiGi();
            }

            if (geometry is Polygon)
            {
                return ((Polygon)geometry).ToDiGi();
            }

            if(geometry is GeometryCollection)
            {
                return ((GeometryCollection)geometry).ToDiGi();
            }

            throw new System.NotImplementedException();
        }
    }
}
