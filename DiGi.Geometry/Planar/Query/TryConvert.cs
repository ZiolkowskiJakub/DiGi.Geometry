using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool TryConvert<TPolygonal2D>(this IPolygonal2D polygonal2D, out List<TPolygonal2D>? polygonal2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonal2D : IPolygonal2D
        {
            polygonal2Ds = null;

            if (polygonal2D is null)
            {
                return false;
            }

            if (typeof(TPolygonal2D) == polygonal2D.GetType())
            {
                if (polygonal2D.Clone() is TPolygonal2D polygonal2D_Temp)
                {
                    polygonal2Ds = [polygonal2D_Temp];
                    return true;
                }

                return false;
            }

            if (typeof(TPolygonal2D) == typeof(Polygon2D))
            {
                polygonal2Ds = [(TPolygonal2D)(object)new Polygon2D(polygonal2D.GetPoints())];

                return true;
            }

            throw new System.NotImplementedException();
        }
    }
}