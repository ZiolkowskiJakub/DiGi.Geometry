using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the centroid of a collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">The collection of <see cref="Point2D"/> objects to process.</param>
        /// <returns>A <see cref="Point2D"/> representing the centroid, or null if the input collection is null or empty.</returns>
        public static Point2D? Centroid(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return null;
            }

            Point2D[] point2Ds_Local = point2Ds as Point2D[] ?? point2Ds.ToArray();
            int count = point2Ds_Local.Length;

            if (count == 0)
            {
                return null;
            }

            if (count == 1)
            {
                return point2Ds_Local[0];
            }

            if (count == 2)
            {
                Point2D point2D_First = point2Ds_Local[0];
                return point2D_First != null ? point2D_First.Mid(point2Ds_Local[1]) : null;
            }

            double area = 0;
            double x = 0;
            double y = 0;

            for (int i = 0, j = count - 1; i < count; j = i++)
            {
                Point2D point2D_1 = point2Ds_Local[i];
                Point2D point2D_2 = point2Ds_Local[j];
                if (point2D_1 == null || point2D_2 == null)
                {
                    continue;
                }

                double area_Temp = point2D_1.X * point2D_2.Y - point2D_2.X * point2D_1.Y;
                area += area_Temp;
                x += (point2D_1.X + point2D_2.X) * area_Temp;
                y += (point2D_1.Y + point2D_2.Y) * area_Temp;
            }

            if (area == 0)
            {
                return null;
            }

            area *= 3;
            return new(x / area, y / area);
        }

        /// <summary>
        /// Calculates the centroid of the specified <see cref="IPolygonal2D"/>.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to calculate the centroid for.</param>
        /// <returns>A <see cref="Point2D"/> representing the centroid, or null if the <see cref="IPolygonal2D"/> is null.</returns>
        public static Point2D? Centroid(this IPolygonal2D? polygonal2D)
        {
            return Centroid(polygonal2D?.GetPoints());
        }

        /// <summary>
        /// Calculates the centroid of the specified <see cref="IPolygonalFace2D"/>.
        /// </summary>
        /// <param name="polygonalFace2D">The <see cref="IPolygonalFace2D"/> for which to calculate the centroid.</param>
        /// <returns>A <see cref="Point2D"/> representing the centroid, or <c>null</c> if the <see cref="IPolygonalFace2D"/> is null or has no external edge.</returns>
        public static Point2D? Centroid(this IPolygonalFace2D? polygonalFace2D)
        {
            IPolygonal2D? polygonal2D = polygonalFace2D?.ExternalEdge;
            if (polygonal2D == null)
            {
                return null;
            }

            return Centroid(polygonal2D);
        }
    }
}