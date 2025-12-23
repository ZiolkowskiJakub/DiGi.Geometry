using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static GeometryCollection2D? ToDiGi(this GeometryCollection? geometryCollection)
        {
            if (geometryCollection == null)
            {
                return null;
            }

            GeometryCollection2D result = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometryCollection)
            {
                if (geometry.ToDiGi() is not ICollectable2D collectable2D)
                {
                    continue;
                }

                result.Add(collectable2D);
            }

            return result;
        }
    }
}
