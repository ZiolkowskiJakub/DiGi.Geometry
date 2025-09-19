using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;


namespace DiGi.Geometry.Planar.Classes
{
    public class PolygonalFace2DInternalPointSolver : Core.Classes.InternalPointSolver<IPolygonalFace2D, Point2D>
    {
        private IPolygonalFace2D? polygonalFace2D = null;

        private Tuple<bool, List<IPolygonal2D>?> edges = new(false, null);
        private Tuple<bool, List<Point2D>?> points = new(false, null);
        private Tuple<bool, List<Triangle2D>?> triangles = new(false, null);

        private int i = 0;
        private int j = 0;

        public PolygonalFace2DInternalPointSolver(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {

        }
        
        public PolygonalFace2DInternalPointSolver(int maxCount, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
            : base(maxCount, tolerance)
        {

        }

        public override IPolygonalFace2D? Input
        {
            set
            {
                polygonalFace2D = DiGi.Core.Query.Clone(value);
            }
        }

        public override bool Solve()
        {
            if (polygonalFace2D is null || outputs.Count >= maxCount)
            {
                return false;
            }

            if (edges.Item1 is false)
            {
                edges = new Tuple<bool, List<IPolygonal2D>?>(true, []);

                if (polygonalFace2D.ExternalEdge is not IPolygonal2D externalEdge)
                {
                    return false;
                }

                if (externalEdge.GetArea() < 2 * tolerance)
                {
                    return false;
                }

                edges.Item2!.Add(externalEdge);

                Point2D? internalPoint = null;
                if (polygonalFace2D.InternalEdges is not List<IPolygonal2D> internalEdges || internalEdges.Count == 0)
                {
                    internalPoint = externalEdge.GetInternalPoint(tolerance);
                }
                else
                {
                    edges.Item2!.AddRange(internalEdges);

                    internalPoint = externalEdge.GetCentroid();
                    if (!polygonalFace2D.Inside(internalPoint))
                    {
                        internalPoint = null;
                    }
                }

                if (internalPoint is not null)
                {
                    outputs.Add(internalPoint);
                    return true;
                }
            }

            if (points.Item1 is false)
            {
                if (points.Item2 is null)
                {
                    points = new(false, []);

                    if (edges.Item2 is List<IPolygonal2D> edges_Temp)
                    {
                        foreach (IPolygonal2D edge in edges_Temp)
                        {
                            if (edge.GetPoints() is not List<Point2D> point2Ds)
                            {
                                continue;
                            }

                            points.Item2!.AddRange(point2Ds);
                        }
                    }
                }

                if (points.Item2 is List<Point2D> points_Temp && points_Temp.Count != 0)
                {
                    int count = points_Temp.Count;
                    for (int i = this.i; i < count - 2; i++)
                    {
                        for (int j = 1; j < count - 1; j++)
                        {
                            if (j <= this.j)
                            {
                                continue;
                            }

                            this.j = j;

                            Point2D? internalPoint = points_Temp[i].Mid(points_Temp[j]);
                            if (polygonalFace2D.Inside(internalPoint, tolerance))
                            {
                                outputs.Add(internalPoint!);
                                return true;
                            }
                        }

                        j = -1;
                    }
                }

                i = 0;
                j = 0;

                points = new Tuple<bool, List<Point2D>?>(true, points.Item2);
            }

            if (triangles.Item1 is false)
            {
                if (triangles.Item2 is null)
                {
                    triangles = new(false, []);

                    if (polygonalFace2D.Triangulate() is List<Triangle2D> triangle2Ds)
                    {
                        triangles.Item2!.AddRange(triangle2Ds);
                    }
                }

                if (triangles.Item2 is List<Triangle2D> triangles_Temp && triangles_Temp.Count != 0)
                {
                    for (int i = this.i; i < triangles_Temp.Count; i++)
                    {
                        this.i = i + 1;
                        if (triangles_Temp[i]?.GetCentroid() is Point2D internalPoint && polygonalFace2D.Inside(internalPoint, tolerance))
                        {
                            outputs.Add(internalPoint!);
                            return true;
                        }
                    }
                }

                i = 0;
                j = 0;

                triangles = new(true, triangles.Item2);
            }

            if (triangles.Item1 is true)
            {
                if (triangles.Item2 is List<Triangle2D> triangles_Temp && triangles_Temp.Count != 0)
                {
                    while (triangles_Temp.Count > 0)
                    {
                        Triangle2D triangle2D = triangles_Temp[0];
                        triangles_Temp.RemoveAt(0);

                        if (triangle2D.GetPoints() is not List<Point2D> point2Ds || point2Ds.Count < 3)
                        {
                            continue;
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            int index_1 = i;
                            int index_2 = DiGi.Core.Query.Next(2, i + 1);
                            int index_3 = DiGi.Core.Query.Next(2, i + 2);

                            Point2D point2D_1 = point2Ds[index_1];
                            Point2D point2D_2 = point2Ds[index_2];
                            Point2D point2D_3 = point2Ds[index_3];

                            if (point2D_1.Distance(point2D_2) < 4 * tolerance)
                            {
                                continue;
                            }

                            if (point2D_1.Mid(point2D_2) is not Point2D point2D_Temp)
                            {
                                continue;
                            }

                            Triangle2D triangle2D_1 = new(point2D_1, point2D_3, point2D_Temp);
                            Triangle2D triangle2D_2 = new(point2D_2, point2D_3, point2D_Temp);

                            triangles_Temp.Add(triangle2D_1);
                            triangles_Temp.Add(triangle2D_2);

                            if (triangle2D_1?.GetCentroid() is Point2D internalPoint_1 && polygonalFace2D.Inside(internalPoint_1, tolerance))
                            {
                                outputs.Add(internalPoint_1!);
                                return true;
                            }

                            if (triangle2D_2?.GetCentroid() is Point2D internalPoint_2 && polygonalFace2D.Inside(internalPoint_2, tolerance))
                            {
                                outputs.Add(internalPoint_2!);
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

    }
}
