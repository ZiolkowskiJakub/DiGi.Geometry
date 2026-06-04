using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified collection of <see cref="Point2D"/> objects forms a convex polygon.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to evaluate.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points form a convex polygon; returns <see langword="false"/> if the collection is null or contains fewer than three points.</returns>
        public static bool Convex(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return false;
            }

            return !Concave(point2Ds);
        }

        /// <summary>
        /// Determines whether the specified <see cref="IPolygonal2D"/> is convex.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to evaluate.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polygon is convex; returns <see langword="false"/> if the input is null.</returns>
        public static bool Convex(this IPolygonal2D? polygonal2D)
        {
            return Convex(polygonal2D?.GetPoints());
        }

        /// <summary>
        /// Determines whether the specified <see cref="PolygonalFace2D"/> is convex.
        /// </summary>
        /// <param name="polygonalFace2D">The <see cref="PolygonalFace2D"/> instance to evaluate.</param>
        /// <param name="externalEdge">A <see cref="bool"/> value indicating whether the external edge should be included in the convexity check.</param>
        /// <param name="internalEdges">A <see cref="bool"/> value indicating whether internal edges should be included in the convexity check.</param>
        /// <returns>A <see cref="bool"/> value that is <c>true</c> if the face is convex; otherwise, <c>false</c>.</returns>
        public static bool Convex(this PolygonalFace2D? polygonalFace2D, bool externalEdge = true, bool internalEdges = true)
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

                if (!polygonal2D.Convex())
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
                        if (!polygonal2Ds[i].Convex())
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