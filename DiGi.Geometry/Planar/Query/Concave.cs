using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the provided collection of <see cref="Point2D"/> points forms a concave polygon.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects representing the vertices of the polygon.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polygon is concave; returns <see langword="false"/> if the collection is null or contains fewer than three points.</returns>
        public static bool Concave(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return false;
            }

            List<Point2D> point2Ds_Temp = point2Ds as List<Point2D> ?? [.. point2Ds];
            if (point2Ds_Temp.Count < 3)
            {
                return false;
            }

            int index = point2Ds_Temp.Count - 1;

            point2Ds_Temp.Add(point2Ds_Temp[0]);
            point2Ds_Temp.Insert(0, point2Ds_Temp[index]);

            int sign = System.Math.Sign(Determinant(point2Ds_Temp[0], point2Ds_Temp[1], point2Ds_Temp[2]));
            for (int i = 2; i < point2Ds_Temp.Count - 1; i++)
            {
                int sign_Temp = System.Math.Sign(Determinant(point2Ds_Temp[i - 1], point2Ds_Temp[i], point2Ds_Temp[i + 1]));
                if (sign != sign_Temp)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="IPolygonal2D"/> instance is concave.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to evaluate.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polygonal object is concave; otherwise, false if the <see cref="IPolygonal2D"/> instance is null.</returns>
        public static bool Concave(this IPolygonal2D? polygonal2D)
        {
            return Concave(polygonal2D?.GetPoints());
        }

        /// <summary>
        /// Determines whether the specified <see cref="PolygonalFace2D"/> is concave.
        /// </summary>
        /// <param name="polygonalFace2D">The <see cref="PolygonalFace2D"/> instance to evaluate.</param>
        /// <param name="externalEdge">A <see cref="bool"/> value indicating whether the external edge should be checked for concavity.</param>
        /// <param name="internalEdges">A <see cref="bool"/> value indicating whether internal edges should be checked for concavity.</param>
        /// <returns>A <see cref="bool"/> value that is <c>true</c> if the polygonal face is concave; otherwise, <c>false</c>.</returns>
        public static bool Concave(this PolygonalFace2D? polygonalFace2D, bool externalEdge = true, bool internalEdges = true)
        {
            if (polygonalFace2D == null)
            {
                return false;
            }

            if (externalEdge)
            {
                IPolygonal2D? polygonal2D = polygonalFace2D.ExternalEdge;
                if (polygonal2D == null)
                {
                    return false;
                }

                if (!polygonal2D.Concave())
                {
                    return false;
                }
            }

            if (internalEdges)
            {
                List<IPolygonal2D>? polygonal2Ds = polygonalFace2D.InternalEdges;
                if (polygonal2Ds != null)
                {
                    for (int i = 0; i < polygonal2Ds.Count; i++)
                    {
                        if (!polygonal2Ds[i].Concave())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}