using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.PolygonalFace2D"/> using the specified external boundary and optional internal boundaries.
        /// </summary>
        /// <param name="externalEdge">The <see cref="IPolygonal2D"/> that defines the external boundary of the face.</param>
        /// <param name="internalEdges">An optional <see cref="IEnumerable{IPolygonal2D}"/> containing the internal boundaries (holes) of the face.</param>
        /// <param name="tolerace">The <see cref="double"/> tolerance used to determine if an internal boundary is inside the external boundary.</param>
        /// <returns>A <see cref="Classes.PolygonalFace2D"/> instance if the <paramref name="externalEdge"/> is not null; otherwise, <c>null</c>.</returns>
        public static PolygonalFace2D? PolygonalFace2D(this IPolygonal2D? externalEdge, IEnumerable<IPolygonal2D>? internalEdges = null, double tolerace = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D>? internalEdges_Inside = null;
            if (internalEdges != null)
            {
                internalEdges_Inside = [];
                foreach (IPolygonal2D internalEdge in internalEdges)
                {
                    if (externalEdge.Inside(internalEdge, tolerace))
                    {
                        internalEdges_Inside.Add(internalEdge);
                    }
                }

                if (internalEdges_Inside.Count > 1)
                {
                    DiGi.Core.Modify.Sort(internalEdges_Inside, x => x.GetArea());
                    internalEdges_Inside.Reverse();

                    List<IPolygonal2D> internalEdges_Temp = [];

                    while (internalEdges_Inside.Count > 0)
                    {
                        IPolygonal2D internalEdge = internalEdges_Inside[0];

                        internalEdges_Temp.Add(internalEdge);
                        internalEdges_Inside.RemoveAt(0);

                        for (int i = internalEdges_Inside.Count - 1; i >= 0; i--)
                        {
                            if (internalEdge.InRange(internalEdges_Inside[i], tolerace))
                            {
                                internalEdges_Inside.RemoveAt(i);
                            }
                        }
                    }

                    internalEdges_Inside = internalEdges_Temp;
                }

                if (internalEdges_Inside.Count == 0)
                {
                    internalEdges_Inside = null;
                }
            }

            return new PolygonalFace2D(externalEdge, internalEdges_Inside);
        }

        /// <summary>
        /// Creates a <see cref="Classes.PolygonalFace2D"/> from the specified array of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="points">An array of <see cref="Point2D"/> objects that define the vertices of the polygonal face.</param>
        /// <returns>A <see cref="Classes.PolygonalFace2D"/> instance if the provided <see cref="Point2D"/> array contains at least three points; otherwise, null.</returns>
        public static PolygonalFace2D? PolygonalFace2D(params Point2D[]? points)
        {
            if (points == null || points.Length < 3)
            {
                return null;
            }

            return new PolygonalFace2D(new Polygon2D(points));
        }
    }
}