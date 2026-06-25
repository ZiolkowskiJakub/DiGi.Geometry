using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>Attempts to convert a polygonal geometry to a specific type of polygonal geometry.</summary>
        /// <typeparam name="TPolygonal2D">The target polygonal geometry type that implements <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="polygonal2D">The source polygonal geometry to be converted.</param>
        /// <param name="polygonal2Ds">When this method returns true, contains the list of converted polygonal geometries; otherwise, null.</param>
        /// <param name="tolerance">The distance tolerance used during conversion.</param>
        /// <returns><c>true</c> if the conversion was successful; otherwise, <c>false</c>.</returns>
        public static bool TryConvert<TPolygonal2D>(this IPolygonal2D? polygonal2D, out List<TPolygonal2D>? polygonal2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonal2D : IPolygonal2D
        {
            polygonal2Ds = null;

            if (polygonal2D is null)
            {
                return false;
            }

            if (polygonal2D is TPolygonal2D polygonal2D_Match)
            {
                if (polygonal2D_Match.Clone() is TPolygonal2D polygonal2D_Clone)
                {
                    polygonal2Ds = [polygonal2D_Clone];
                    return true;
                }

                return false;
            }

            if (typeof(TPolygonal2D) == typeof(Polygon2D) || typeof(TPolygonal2D) == typeof(IPolygon2D))
            {
                Polygon2D polygon2D_Temp = new(polygonal2D.GetPoints());
                polygonal2Ds = [(TPolygonal2D)(object)polygon2D_Temp];
                return true;
            }

            if (typeof(TPolygonal2D) == typeof(Rectangle2D))
            {
                if (Query.Rectangular(polygonal2D, out Rectangle2D? rectangle2D_Temp, tolerance))
                {
                    if (rectangle2D_Temp is not null)
                    {
                        polygonal2Ds = [(TPolygonal2D)(object)rectangle2D_Temp];
                        return true;
                    }
                }

                return false;
            }

            if (typeof(TPolygonal2D) == typeof(Triangle2D))
            {
                List<Triangle2D>? triangle2Ds = polygonal2D.Triangulate(tolerance);
                if (triangle2Ds is not null)
                {
                    List<TPolygonal2D> polygonal2Ds_Temp = new(triangle2Ds.Count);
                    foreach (Triangle2D triangle2D_Temp in triangle2Ds)
                    {
                        polygonal2Ds_Temp.Add((TPolygonal2D)(object)triangle2D_Temp);
                    }

                    polygonal2Ds = polygonal2Ds_Temp;
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}