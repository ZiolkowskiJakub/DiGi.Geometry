using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static GeometryCollection2D ToDiGi(this GeometryCollection geometryCollection)
        {
            if(geometryCollection == null)
            {
                return null;
            }

            GeometryCollection2D result = new GeometryCollection2D();
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometryCollection)
            {
                ICollectable2D collectable2D = geometry.ToDiGi() as ICollectable2D;
                if(collectable2D == null)
                {
                    continue;
                }

                result.Add(collectable2D);
            }

            return result;
        }
    }
}
