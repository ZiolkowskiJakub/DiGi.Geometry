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
        /// <para>Every edge must be used an even number of times. Use the overload taking a <c>manifold</c> flag to require that every edge is used exactly twice.</para>
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to weld coincident vertices. Values of zero or less fall back to <see cref="DiGi.Core.Constants.Tolerance.MicroDistance"/>. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polyhedron is fully closed.</returns>
        public static bool IsClosed<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            return IsClosed(polyhedron, false, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Polyhedron{TPolygonalFace3D}"/> is fully closed within the given distance tolerance.
        /// <para>Face vertices are welded into shared indices using a tolerance-sized spatial hash, and each resulting edge is counted. Edges collapsing onto a single welded vertex are ignored.</para>
        /// <para>Returns <see langword="false"/> for a <see langword="null"/> polyhedron, for fewer than four faces (the minimum for a closed solid), and for any structurally malformed face - a face with no plane, no 2D geometry, no edges, a ring holding fewer than three points, or a <see langword="null"/> point within a ring. A face that cannot be read in full is never treated as contributing no edges, because that would let a broken face pass as closed.</para>
        /// <para>Known limitations. Winding is not checked: two faces sharing an edge in the same direction are accepted, whereas a consistently oriented solid traverses a shared edge in opposite directions - use <see cref="Polyhedron{TPolygonalFace3D}.Orient(DiGi.Geometry.Core.Enums.Orientation?, DiGi.Geometry.Core.Enums.Orientation?)"/> for that. T-junctions report open: when one face's long edge is met by two shorter faces whose shared vertex lies mid-span, no vertex pair matches. Welding is not transitive, so a chain of vertices each within tolerance of the next can weld together even though the chain spans more than the tolerance.</para>
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to evaluate.</param>
        /// <param name="manifold">When <see langword="true"/>, every edge must be used exactly twice (a strict 2-manifold surface), so an edge shared by three or more faces is rejected. When <see langword="false"/>, every edge must be used an even number of times, which accepts an edge shared by four faces.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to weld coincident vertices. Values of zero or less fall back to <see cref="DiGi.Core.Constants.Tolerance.MicroDistance"/>. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polyhedron is fully closed.</returns>
        public static bool IsClosed<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron, bool manifold, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron is null || polyhedron.Count < 4)
            {
                return false;
            }

            double tolerance_Temp = tolerance > 0.0 ? tolerance : DiGi.Core.Constants.Tolerance.MicroDistance;

            double invTolerance = 1.0 / tolerance_Temp;
            double toleranceSquared = tolerance_Temp * tolerance_Temp;

            // The cell grid is only an accelerator that narrows which vertices get compared - a match is always confirmed
            // by the squared-distance test below. An extreme coordinate-to-tolerance ratio can therefore degrade the grid
            // (in the limit every vertex lands in one cell, or coincident vertices land more than one cell apart) and
            // cost time or report open, but it can never fabricate a match and report a false closure.
            // Welded vertices are held as flat X, Y, Z triplets so no Point3D is allocated per vertex. Cells hold the
            // head of a chain threaded through indexes_Next rather than a List per cell, which would allocate one list
            // object for every occupied cell - and cells are mostly occupied by a single vertex.
            List<double> coordinates = new(polyhedron.Count * 3);
            List<int> indexes_Next = new(polyhedron.Count);
            Dictionary<(long X, long Y, long Z), int> index_ByCell = [];

            int IndexInCell(long cellX, long cellY, long cellZ, double x, double y, double z)
            {
                if (!index_ByCell.TryGetValue((cellX, cellY, cellZ), out int index))
                {
                    return -1;
                }

                while (index >= 0)
                {
                    int offset = index * 3;

                    double dx = coordinates[offset] - x;
                    double dy = coordinates[offset + 1] - y;
                    double dz = coordinates[offset + 2] - z;

                    if ((dx * dx) + (dy * dy) + (dz * dz) <= toleranceSquared)
                    {
                        return index;
                    }

                    index = indexes_Next[index];
                }

                return -1;
            }

            int Index(double x, double y, double z)
            {
                long cellX = (long)System.Math.Floor(x * invTolerance);
                long cellY = (long)System.Math.Floor(y * invTolerance);
                long cellZ = (long)System.Math.Floor(z * invTolerance);

                // Nearly every match lands in the centre cell, so it is probed before the 26 neighbours.
                int index = IndexInCell(cellX, cellY, cellZ, x, y, z);
                if (index >= 0)
                {
                    return index;
                }

                for (long neighbourX = cellX - 1; neighbourX <= cellX + 1; neighbourX++)
                {
                    for (long neighbourY = cellY - 1; neighbourY <= cellY + 1; neighbourY++)
                    {
                        for (long neighbourZ = cellZ - 1; neighbourZ <= cellZ + 1; neighbourZ++)
                        {
                            if (neighbourX == cellX && neighbourY == cellY && neighbourZ == cellZ)
                            {
                                continue;
                            }

                            index = IndexInCell(neighbourX, neighbourY, neighbourZ, x, y, z);
                            if (index >= 0)
                            {
                                return index;
                            }
                        }
                    }
                }

                int index_New = indexes_Next.Count;
                coordinates.Add(x);
                coordinates.Add(y);
                coordinates.Add(z);

                // The new vertex becomes the head of its cell's chain, pointing at whatever was there before.
                (long X, long Y, long Z) cell = (cellX, cellY, cellZ);
                indexes_Next.Add(index_ByCell.TryGetValue(cell, out int index_Head) ? index_Head : -1);
                index_ByCell[cell] = index_New;

                return index_New;
            }

            // ValueTuple keys are used deliberately: their seeded rotate-combine hash distributes the highly regular edge
            // index pairs of structured models far better than a packed 64-bit key, whose default hash (low ^ high)
            // degenerates into long collision chains.
            Dictionary<(int, int), int> counts_ByEdge = new(polyhedron.Count * 2);

            // One buffer grown on demand and reused by every ring of every face.
            int[] indexes_Ring = new int[16];

            for (int i = 0; i < polyhedron.Count; i++)
            {
                TPolygonalFace3D? polygonalFace3D = polyhedron.GetPolygonalFace3D<TPolygonalFace3D>(i);
                if (polygonalFace3D is null)
                {
                    return false;
                }

                Plane? plane = polygonalFace3D.Plane;
                if (plane is null)
                {
                    return false;
                }

                Point3D? point3D_Origin = plane.Origin;
                Vector3D? vector3D_AxisX = plane.AxisX;
                Vector3D? vector3D_AxisY = plane.AxisY;

                if (point3D_Origin is null || vector3D_AxisX is null || vector3D_AxisY is null)
                {
                    return false;
                }

                // Plane components are cached once per face in locals, keeping the projection below allocation free.
                double originX = point3D_Origin.X;
                double originY = point3D_Origin.Y;
                double originZ = point3D_Origin.Z;

                double axisXX = vector3D_AxisX.X;
                double axisXY = vector3D_AxisX.Y;
                double axisXZ = vector3D_AxisX.Z;

                double axisYX = vector3D_AxisY.X;
                double axisYY = vector3D_AxisY.Y;
                double axisYZ = vector3D_AxisY.Z;

                IPolygonalFace2D? polygonalFace2D = polygonalFace3D.Geometry2D;
                if (polygonalFace2D is null)
                {
                    return false;
                }

                List<IPolygonal2D>? polygonal2Ds = polygonalFace2D.Edges;
                if (polygonal2Ds is null || polygonal2Ds.Count == 0)
                {
                    return false;
                }

                for (int j = 0; j < polygonal2Ds.Count; j++)
                {
                    IPolygonal2D? polygonal2D = polygonal2Ds[j];
                    if (polygonal2D is null)
                    {
                        return false;
                    }

                    // Segmentable2D exposes a non-cloning GetPoints overload, avoiding one full copy of the ring.
                    // Rectangle2D implements IPolygonal2D without deriving from Segmentable2D, hence the fallback.
                    // The returned list is owned by the geometry and is only read here.
                    List<Point2D>? point2Ds = polygonal2D is Segmentable2D segmentable2D ? segmentable2D.GetPoints(false) : polygonal2D.GetPoints();
                    if (point2Ds is null || point2Ds.Count < 3)
                    {
                        return false;
                    }

                    if (indexes_Ring.Length < point2Ds.Count)
                    {
                        indexes_Ring = new int[point2Ds.Count];
                    }

                    for (int k = 0; k < point2Ds.Count; k++)
                    {
                        Point2D? point2D = point2Ds[k];
                        if (point2D is null)
                        {
                            return false;
                        }

                        double x = point2D.X;
                        double y = point2D.Y;

                        indexes_Ring[k] = Index(
                            originX + (axisYX * y) + (axisXX * x),
                            originY + (axisYY * y) + (axisXY * x),
                            originZ + (axisYZ * y) + (axisXZ * x));
                    }

                    for (int k = 0; k < point2Ds.Count; k++)
                    {
                        int index_Start = indexes_Ring[k];
                        int index_End = indexes_Ring[k == point2Ds.Count - 1 ? 0 : k + 1];

                        // Welding collapses a degenerate edge onto a single vertex.
                        if (index_Start == index_End)
                        {
                            continue;
                        }

                        (int, int) key = index_Start < index_End ? (index_Start, index_End) : (index_End, index_Start);

                        counts_ByEdge.TryGetValue(key, out int count);
                        if (manifold && count >= 2)
                        {
                            return false;
                        }

                        counts_ByEdge[key] = count + 1;
                    }
                }
            }

            if (counts_ByEdge.Count == 0)
            {
                return false;
            }

            foreach (KeyValuePair<(int, int), int> keyValuePair in counts_ByEdge)
            {
                if (manifold ? keyValuePair.Value != 2 : (keyValuePair.Value & 1) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}