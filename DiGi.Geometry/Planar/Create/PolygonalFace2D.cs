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
                BoundingBox2D? boundingBox2D_ExternalEdge = externalEdge.GetBoundingBox();

                internalEdges_Inside = [];
                foreach (IPolygonal2D internalEdge in internalEdges)
                {
                    if (internalEdge == null)
                    {
                        continue;
                    }

                    if (boundingBox2D_ExternalEdge != null && !boundingBox2D_ExternalEdge.InRange(internalEdge.GetBoundingBox(), tolerace))
                    {
                        continue;
                    }

                    if (externalEdge.Inside(internalEdge, tolerace))
                    {
                        internalEdges_Inside.Add(internalEdge);
                    }
                }

                if (internalEdges_Inside.Count > 1)
                {
                    int count = internalEdges_Inside.Count;

                    double[] areas = new double[count];
                    IPolygonal2D[] polygonal2Ds = new IPolygonal2D[count];
                    for (int i = 0; i < count; i++)
                    {
                        IPolygonal2D internalEdge = internalEdges_Inside[i];
                        areas[i] = internalEdge.GetArea();
                        polygonal2Ds[i] = internalEdge;
                    }

                    System.Array.Sort(areas, polygonal2Ds);

                    BoundingBox2D?[] boundingBox2Ds = new BoundingBox2D?[count];
                    for (int i = 0; i < count; i++)
                    {
                        boundingBox2Ds[i] = polygonal2Ds[i].GetBoundingBox();
                    }

                    internalEdges_Inside.Clear();

                    bool[] removed = new bool[count];
                    for (int i = count - 1; i >= 0; i--)
                    {
                        if (removed[i])
                        {
                            continue;
                        }

                        IPolygonal2D internalEdge = polygonal2Ds[i];
                        internalEdges_Inside.Add(internalEdge);

                        BoundingBox2D? boundingBox2D = boundingBox2Ds[i];
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (removed[j])
                            {
                                continue;
                            }

                            if (boundingBox2D != null && !boundingBox2D.InRange(boundingBox2Ds[j], tolerace))
                            {
                                continue;
                            }

                            if (internalEdge.InRange(polygonal2Ds[j], tolerace))
                            {
                                removed[j] = true;
                            }
                        }
                    }
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