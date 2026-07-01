using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified <see cref="Polyhedron{TPolygonalFace3D}"/> is fully closed (i.e., has no naked edges) within the given distance tolerance.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polyhedron is fully closed.</returns>
        public static bool IsClosed<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron is null || polyhedron.Count < 4)
            {
                return false;
            }

            double tolerance_Temp = tolerance > 0.0 ? tolerance : 1e-9;
            double double_InvTol = 1.0 / tolerance_Temp;

            // Spatial grid using ValueTuple coordinates to avoid Point3D heap allocations
            Dictionary<(long X, long Y, long Z), List<((double X, double Y, double Z) Start, (double X, double Y, double Z) End)>> edges_ByCell = new();

            (long X, long Y, long Z) GetCell((double X, double Y, double Z) point3D_Cell)
            {
                return (
                    (long)System.Math.Floor(point3D_Cell.X * double_InvTol),
                    (long)System.Math.Floor(point3D_Cell.Y * double_InvTol),
                    (long)System.Math.Floor(point3D_Cell.Z * double_InvTol)
                );
            }

            void AddEdgeToCell((long X, long Y, long Z) cell, ((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge_New)
            {
                if (!edges_ByCell.TryGetValue(cell, out List<((double X, double Y, double Z) Start, (double X, double Y, double Z) End)>? edges_Cell))
                {
                    edges_Cell = new();
                    edges_ByCell[cell] = edges_Cell;
                }
                edges_Cell.Add(edge_New);
            }

            void RegisterEdge(((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge_New)
            {
                (long X, long Y, long Z) cell_Start = GetCell(edge_New.Start);
                (long X, long Y, long Z) cell_End = GetCell(edge_New.End);

                AddEdgeToCell(cell_Start, edge_New);
                if (cell_End != cell_Start)
                {
                    AddEdgeToCell(cell_End, edge_New);
                }
            }

            void RemoveEdge(((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge_ToRemove)
            {
                (long X, long Y, long Z) cell_Start = GetCell(edge_ToRemove.Start);
                (long X, long Y, long Z) cell_End = GetCell(edge_ToRemove.End);

                if (edges_ByCell.TryGetValue(cell_Start, out List<((double X, double Y, double Z) Start, (double X, double Y, double Z) End)>? edges_CellStart))
                {
                    edges_CellStart.Remove(edge_ToRemove);
                    if (edges_CellStart.Count == 0)
                    {
                        edges_ByCell.Remove(cell_Start);
                    }
                }
                if (cell_End != cell_Start && edges_ByCell.TryGetValue(cell_End, out List<((double X, double Y, double Z) Start, (double X, double Y, double Z) End)>? edges_CellEnd))
                {
                    edges_CellEnd.Remove(edge_ToRemove);
                    if (edges_CellEnd.Count == 0)
                    {
                        edges_ByCell.Remove(cell_End);
                    }
                }
            }

            bool Similar(((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge1, ((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge2)
            {
                // Inlined distance calculations to avoid method call overhead in inner loops
                double dx1 = edge1.Start.X - edge2.Start.X;
                double dy1 = edge1.Start.Y - edge2.Start.Y;
                double dz1 = edge1.Start.Z - edge2.Start.Z;
                double d1 = dx1 * dx1 + dy1 * dy1 + dz1 * dz1;

                double dx2 = edge1.End.X - edge2.End.X;
                double dy2 = edge1.End.Y - edge2.End.Y;
                double dz2 = edge1.End.Z - edge2.End.Z;
                double d2 = dx2 * dx2 + dy2 * dy2 + dz2 * dz2;

                double tolSq = tolerance_Temp * tolerance_Temp;

                if (d1 <= tolSq && d2 <= tolSq)
                {
                    return true;
                }

                double dx3 = edge1.Start.X - edge2.End.X;
                double dy3 = edge1.Start.Y - edge2.End.Y;
                double dz3 = edge1.Start.Z - edge2.End.Z;
                double d3 = dx3 * dx3 + dy3 * dy3 + dz3 * dz3;

                double dx4 = edge1.End.X - edge2.Start.X;
                double dy4 = edge1.End.Y - edge2.Start.Y;
                double dz4 = edge1.End.Z - edge2.Start.Z;
                double d4 = dx4 * dx4 + dy4 * dy4 + dz4 * dz4;

                return d3 <= tolSq && d4 <= tolSq;
            }

            for (int int_I = 0; int_I < polyhedron.Count; int_I++)
            {
                TPolygonalFace3D? polygonalFace3D = polyhedron.GetPolygonalFace3D<TPolygonalFace3D>(int_I);
                if (polygonalFace3D is null)
                {
                    continue;
                }

                Plane? plane = polygonalFace3D.Plane;
                if (plane is null)
                {
                    continue;
                }

                // Cache plane components once per face in local variables (thread-safe & stateless)
                Vector3D? vector3D_AxisX = plane.AxisX;
                Vector3D? vector3D_AxisY = plane.AxisY;
                Point3D? point3D_Origin = plane.Origin;

                if (vector3D_AxisX is null || vector3D_AxisY is null || point3D_Origin is null)
                {
                    continue;
                }

                double double_OriginX = point3D_Origin.X;
                double double_OriginY = point3D_Origin.Y;
                double double_OriginZ = point3D_Origin.Z;

                double double_AxisXX = vector3D_AxisX.X;
                double double_AxisXY = vector3D_AxisX.Y;
                double double_AxisXZ = vector3D_AxisX.Z;

                double double_AxisYX = vector3D_AxisY.X;
                double double_AxisYY = vector3D_AxisY.Y;
                double double_AxisYZ = vector3D_AxisY.Z;

                IPolygonalFace2D? polygonalFace2D = polygonalFace3D.Geometry2D;
                if (polygonalFace2D is null)
                {
                    continue;
                }

                List<IPolygonal2D>? polygonal2Ds_Edges = polygonalFace2D.Edges;
                if (polygonal2Ds_Edges is null)
                {
                    continue;
                }

                for (int int_J = 0; int_J < polygonal2Ds_Edges.Count; int_J++)
                {
                    IPolygonal2D? polygonal2D = polygonal2Ds_Edges[int_J];
                    if (polygonal2D is null)
                    {
                        continue;
                    }

                    List<Point2D>? point2Ds = polygonal2D.GetPoints();
                    if (point2Ds is null || point2Ds.Count < 3)
                    {
                        continue;
                    }

                    // Pre-convert 2D points to 3D coordinate tuples to avoid Point3D allocations
                    (double X, double Y, double Z)[] point3Ds_Converted = new (double X, double Y, double Z)[point2Ds.Count];
                    for (int int_K = 0; int_K < point2Ds.Count; int_K++)
                    {
                        Point2D? point2D = point2Ds[int_K];
                        if (point2D is null)
                        {
                            continue;
                        }

                        double double_X2D = point2D.X;
                        double double_Y2D = point2D.Y;

                        point3Ds_Converted[int_K] = (
                            double_OriginX + (double_AxisYX * double_Y2D) + (double_AxisXX * double_X2D),
                            double_OriginY + (double_AxisYY * double_Y2D) + (double_AxisXY * double_X2D),
                            double_OriginZ + (double_AxisYZ * double_Y2D) + (double_AxisXZ * double_X2D)
                        );
                    }

                    for (int int_K = 0; int_K < point3Ds_Converted.Length; int_K++)
                    {
                        (double X, double Y, double Z) point3D_Start = point3Ds_Converted[int_K];
                        (double X, double Y, double Z) point3D_End = point3Ds_Converted[int_K == point3Ds_Converted.Length - 1 ? 0 : int_K + 1];

                        ((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge_Candidate = (point3D_Start, point3D_End);

                        (long X, long Y, long Z) cell_Start = GetCell(edge_Candidate.Start);
                        ((double X, double Y, double Z) Start, (double X, double Y, double Z) End)? edge_Matched = null;

                        for (long x = cell_Start.X - 1; x <= cell_Start.X + 1; x++)
                        {
                            for (long y = cell_Start.Y - 1; y <= cell_Start.Y + 1; y++)
                            {
                                for (long z = cell_Start.Z - 1; z <= cell_Start.Z + 1; z++)
                                {
                                    if (!edges_ByCell.TryGetValue((x, y, z), out List<((double X, double Y, double Z) Start, (double X, double Y, double Z) End)>? edges_Cell))
                                    {
                                        continue;
                                    }

                                    for (int int_L = 0; int_L < edges_Cell.Count; int_L++)
                                    {
                                        ((double X, double Y, double Z) Start, (double X, double Y, double Z) End) edge_Existing = edges_Cell[int_L];
                                        if (Similar(edge_Existing, edge_Candidate))
                                        {
                                            edge_Matched = edge_Existing;
                                            break;
                                        }
                                    }

                                    if (edge_Matched is not null)
                                    {
                                        break;
                                    }
                                }

                                if (edge_Matched is not null)
                                {
                                    break;
                                }
                            }

                            if (edge_Matched is not null)
                            {
                                break;
                            }
                        }

                        if (edge_Matched is not null)
                        {
                            RemoveEdge(edge_Matched.Value);
                        }
                        else
                        {
                            RegisterEdge(edge_Candidate);
                        }
                    }
                }
            }

            return edges_ByCell.Count == 0;
        }
    }
}
