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
        /// <para>Every edge must be paired with exactly one other edge. Use the overload taking a <c>manifold</c> flag to additionally reject an edge shared by more than two faces.</para>
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance, an upper bound on the gap that may be bridged between two edges. Values of zero or less fall back to <see cref="DiGi.Core.Constants.Tolerance.MicroDistance"/>. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polyhedron is fully closed.</returns>
        public static bool IsClosed<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            return IsClosed(polyhedron, false, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Polyhedron{TPolygonalFace3D}"/> is fully closed within the given distance tolerance.
        /// <para>Each ring segment of each face is taken as a half-edge and no vertex is ever merged. Two half-edges are compatible when their endpoints match pairwise within <paramref name="tolerance"/>, in either traversal direction. The polyhedron is closed when the resulting compatibility graph admits a perfect matching, that is when every half-edge can be paired off with a distinct partner at the same time.</para>
        /// <para>Monotonicity. The closure result is non-decreasing in <paramref name="tolerance"/>: broadening the tolerance only adds compatible pairs, so a polyhedron closed at one value is closed at every coarser one. The result also does not depend on the order the faces are held in. Neither held for the previous vertex-welding implementation, where a tolerance reaching the size of a genuine feature collapsed it and reported a closed solid as open.</para>
        /// <para>The <paramref name="manifold"/> form is scale-relative and deliberately not monotonic. Requiring an edge to be shared by exactly two faces is a statement about a single edge, so once <paramref name="tolerance"/> reaches the size of a genuine feature that feature stops resolving as a separate edge and the surface stops being 2-manifold at that scale. No algorithm can avoid this; judge manifoldness at the tolerance the polyhedron actually closes at.</para>
        /// <para>Returns <see langword="false"/> for a <see langword="null"/> polyhedron, for fewer than four faces (the minimum for a closed solid), and for any structurally malformed face - a face with no plane, no 2D geometry, no edges, a ring holding fewer than three points, or a <see langword="null"/> point within a ring. A face that cannot be read in full is never treated as contributing no edges, because that would let a broken face pass as closed.</para>
        /// <para>Known limitations. Winding is not checked: two faces sharing an edge in the same direction are accepted, whereas a consistently oriented solid traverses a shared edge in opposite directions - use <see cref="Polyhedron{TPolygonalFace3D}.Orient(DiGi.Geometry.Core.Enums.Orientation?, DiGi.Geometry.Core.Enums.Orientation?)"/> for that. T-junctions report open: when one face's long edge is met by two shorter faces whose shared vertex lies mid-span, no endpoint pair matches. Two half-edges of the same face are never compatible with each other, so a zero-width slit within a single face does not close against itself - without that rule a face whose every edge is shorter than <paramref name="tolerance"/> would match itself and report a false closure.</para>
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to evaluate.</param>
        /// <param name="manifold">When <see langword="true"/>, every edge must be shared by exactly two faces (a strict 2-manifold surface), so an edge shared by three or more faces is rejected. When <see langword="false"/>, only a perfect matching is required, which accepts an edge shared by four faces.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance, an upper bound on the gap that may be bridged between two edges. Values of zero or less fall back to <see cref="DiGi.Core.Constants.Tolerance.MicroDistance"/>. Defaults to <see cref="DiGi.Core.Constants.Tolerance.Distance"/>.</param>
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
            double microDistanceSquared = DiGi.Core.Constants.Tolerance.MicroDistance * DiGi.Core.Constants.Tolerance.MicroDistance;

            // Half-edges are held as flat six-double records - start then end - so no Point3D is allocated per edge,
            // alongside the index of the face each one came from. The midpoint is derived where it is needed rather
            // than stored, which keeps the buffer a third smaller and off the large object heap for longer. Both
            // buffers are grown by doubling.
            int capacity = polyhedron.Count * 3;

            double[] coordinates = new double[capacity * 6];
            int[] indexes_Face = new int[capacity];
            long[] keys_Edge = new long[capacity];
            int count_Edges = 0;

            void AddEdge(double startX, double startY, double startZ, double endX, double endY, double endZ, long key_Start, long key_End, int index_Face)
            {
                if (count_Edges == indexes_Face.Length)
                {
                    System.Array.Resize(ref coordinates, coordinates.Length * 2);
                    System.Array.Resize(ref indexes_Face, indexes_Face.Length * 2);
                    System.Array.Resize(ref keys_Edge, keys_Edge.Length * 2);
                }

                int offset = count_Edges * 6;

                coordinates[offset] = startX;
                coordinates[offset + 1] = startY;
                coordinates[offset + 2] = startZ;
                coordinates[offset + 3] = endX;
                coordinates[offset + 4] = endY;
                coordinates[offset + 5] = endZ;

                indexes_Face[count_Edges] = index_Face;

                // One key per half-edge, taken from its two endpoint keys in a fixed order so that a half-edge and
                // the one facing it - the same edge traversed the other way - land on the same value.
                unchecked
                {
                    ulong hash = key_Start <= key_End ? (ulong)key_Start : (ulong)key_End;
                    hash = (hash ^ (key_Start <= key_End ? (ulong)key_End : (ulong)key_Start)) * 0x100000001B3UL;
                    hash ^= hash >> 33;

                    keys_Edge[count_Edges] = (long)hash;
                }

                count_Edges++;
            }

            // The cell a point falls in, mixed down to a single value.
            // Rounded rather than floored, deliberately: flooring puts the cell boundary on every exact multiple of
            // the tolerance, which is exactly where clean geometry sits - a face at z = 0 whose neighbour reprojects
            // to -1E-16 lands one cell lower - so the two halves of nearly every pair were keyed apart and the fast
            // path never fired. Rounding moves the boundary to the half-cell, away from the round numbers real
            // models are built on.
            // Every ordinate is mixed in turn, each exclusive-or immediately followed by a multiply, and the result
            // is avalanched. Both cheaper-looking alternatives are degenerate on the regular lattices geometry
            // produces: an exclusive-or of multiplied ordinates collided 108 of the 1500 edge keys of a 500-gon
            // extrusion, and combining two ordinates before the first multiply collided 694 of them, because
            // exclusive-or is symmetric and a polygon on a circle carries the vertex with its two ordinates swapped.
            // Either was enough to send the whole solid down the slow path. A collision only groups unrelated
            // half-edges, which the compatibility test then rejects, so it costs time and never fabricates a match.
            long PointKey(double x, double y, double z)
            {
                unchecked
                {
                    ulong hash = 0xCBF29CE484222325UL;
                    hash = (hash ^ (ulong)(long)System.Math.Round(x * invTolerance)) * 0x100000001B3UL;
                    hash = (hash ^ (ulong)(long)System.Math.Round(y * invTolerance)) * 0x100000001B3UL;
                    hash = (hash ^ (ulong)(long)System.Math.Round(z * invTolerance)) * 0x100000001B3UL;
                    hash ^= hash >> 33;
                    hash *= 0xFF51AFD7ED558CCDUL;
                    hash ^= hash >> 33;

                    return (long)hash;
                }
            }

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

                    double firstX = 0.0;
                    double firstY = 0.0;
                    double firstZ = 0.0;
                    long key_First = 0L;

                    double previousX = 0.0;
                    double previousY = 0.0;
                    double previousZ = 0.0;
                    long key_Previous = 0L;

                    for (int k = 0; k < point2Ds.Count; k++)
                    {
                        Point2D? point2D = point2Ds[k];
                        if (point2D is null)
                        {
                            return false;
                        }

                        double x = point2D.X;
                        double y = point2D.Y;

                        double currentX = originX + (axisYX * y) + (axisXX * x);
                        double currentY = originY + (axisYY * y) + (axisXY * x);
                        double currentZ = originZ + (axisYZ * y) + (axisXZ * x);

                        // Computed once per ring point rather than once per half-edge: consecutive half-edges of a
                        // ring share the point between them, so keying them separately did the work twice.
                        long key_Current = PointKey(currentX, currentY, currentZ);

                        if (k == 0)
                        {
                            firstX = currentX;
                            firstY = currentY;
                            firstZ = currentZ;
                            key_First = key_Current;
                        }
                        else
                        {
                            double dx = currentX - previousX;
                            double dy = currentY - previousY;
                            double dz = currentZ - previousZ;

                            // Only a segment below MicroDistance is dropped, so a repeated corner never becomes a
                            // naked edge while every genuine feature is kept as an edge of its own.
                            if ((dx * dx) + (dy * dy) + (dz * dz) > microDistanceSquared)
                            {
                                AddEdge(previousX, previousY, previousZ, currentX, currentY, currentZ, key_Previous, key_Current, i);
                            }
                        }

                        previousX = currentX;
                        previousY = currentY;
                        previousZ = currentZ;
                        key_Previous = key_Current;
                    }

                    double dx_Closing = firstX - previousX;
                    double dy_Closing = firstY - previousY;
                    double dz_Closing = firstZ - previousZ;

                    if ((dx_Closing * dx_Closing) + (dy_Closing * dy_Closing) + (dz_Closing * dz_Closing) > microDistanceSquared)
                    {
                        AddEdge(previousX, previousY, previousZ, firstX, firstY, firstZ, key_Previous, key_First, i);
                    }
                }
            }

            // Every component of the compatibility graph must hold an even number of half-edges, so an odd total
            // can never be matched.
            if (count_Edges == 0 || (count_Edges & 1) != 0)
            {
                return false;
            }

            double SquaredDistance(int offset_1, int offset_2)
            {
                double dx = coordinates[offset_1] - coordinates[offset_2];
                double dy = coordinates[offset_1 + 1] - coordinates[offset_2 + 1];
                double dz = coordinates[offset_1 + 2] - coordinates[offset_2 + 2];

                return (dx * dx) + (dy * dy) + (dz * dz);
            }

            // Two half-edges are compatible when their endpoints match pairwise within the tolerance, taken in the
            // opposite traversal direction (a consistently oriented solid) or in the same one (an inverted face).
            bool Compatible(int index_1, int index_2)
            {
                if (indexes_Face[index_1] == indexes_Face[index_2])
                {
                    return false;
                }

                int offset_1 = index_1 * 6;
                int offset_2 = index_2 * 6;

                if (SquaredDistance(offset_1, offset_2 + 3) <= toleranceSquared && SquaredDistance(offset_1 + 3, offset_2) <= toleranceSquared)
                {
                    return true;
                }

                return SquaredDistance(offset_1, offset_2) <= toleranceSquared && SquaredDistance(offset_1 + 3, offset_2 + 3) <= toleranceSquared;
            }

            long Cell(double value)
            {
                return (long)System.Math.Floor(value * invTolerance);
            }

            // Fast path. Every half-edge already carries one key, so the pairing is read straight out of a single
            // lookup per half-edge on a plain 64-bit key - no neighbourhood probing, and no composite key to hash.
            // A bucket holding exactly two compatible half-edges is a matched pair, and once every half-edge is
            // matched a perfect matching of the whole graph is in hand, which is the closure criterion itself
            // rather than a second, weaker one - so this is a shortcut to the same answer, never a different one.
            // Half-edges whose keys straddle a cell boundary, and the rare pair that collides onto another key,
            // simply fall through to the full pass below. This can only cost time, never decide wrongly.
            // The manifold form cannot be settled this way - no bucket of two can show that a third half-edge is
            // absent - so it always takes the full pass.
            if (!manifold)
            {
                Dictionary<long, int> index_ByKey = new(count_Edges);
                int[] indexes_NextByKey = new int[count_Edges];

                for (int i = 0; i < count_Edges; i++)
                {
                    indexes_NextByKey[i] = index_ByKey.TryGetValue(keys_Edge[i], out int index_Head) ? index_Head : -1;
                    index_ByKey[keys_Edge[i]] = i;
                }

                int count_Matched = 0;

                foreach (KeyValuePair<long, int> keyValuePair in index_ByKey)
                {
                    int index_1 = keyValuePair.Value;
                    int index_2 = indexes_NextByKey[index_1];

                    // A bucket holding one half-edge, or three or more, decides nothing.
                    if (index_2 < 0 || indexes_NextByKey[index_2] >= 0)
                    {
                        continue;
                    }

                    if (Compatible(index_1, index_2))
                    {
                        count_Matched += 2;
                    }
                }

                if (count_Matched == count_Edges)
                {
                    return true;
                }
            }

            // Full pass. Midpoints are hashed into tolerance-sized cells, since two compatible half-edges have
            // midpoints no further apart than the tolerance and therefore land in the same cell or a neighbouring
            // one.
            Dictionary<(long X, long Y, long Z), int> index_ByCell = new(count_Edges);
            int[] indexes_Next = new int[count_Edges];

            for (int i = 0; i < count_Edges; i++)
            {
                int offset = i * 6;

                (long X, long Y, long Z) cell = (
                    Cell((coordinates[offset] + coordinates[offset + 3]) * 0.5),
                    Cell((coordinates[offset + 1] + coordinates[offset + 4]) * 0.5),
                    Cell((coordinates[offset + 2] + coordinates[offset + 5]) * 0.5));

                indexes_Next[i] = index_ByCell.TryGetValue(cell, out int index_Head) ? index_Head : -1;
                index_ByCell[cell] = i;
            }

            // Only the thirteen lexicographically forward neighbours are probed, and the cells are walked rather
            // than the half-edges. A cell never probes backwards, so every cross-cell pair is still examined
            // exactly once - at a quarter of the dictionary lookups a full 27-cell probe per half-edge would cost.
            (long X, long Y, long Z)[] offsets_Neighbour =
            [
                (1, -1, -1), (1, -1, 0), (1, -1, 1),
                (1, 0, -1), (1, 0, 0), (1, 0, 1),
                (1, 1, -1), (1, 1, 0), (1, 1, 1),
                (0, 1, -1), (0, 1, 0), (0, 1, 1),
                (0, 0, 1)
            ];

            int[] indexes_Component = new int[count_Edges];
            for (int i = 0; i < count_Edges; i++)
            {
                indexes_Component[i] = i;
            }

            int Root(int index)
            {
                int index_Root = index;
                while (indexes_Component[index_Root] != index_Root)
                {
                    index_Root = indexes_Component[index_Root];
                }

                while (indexes_Component[index] != index_Root)
                {
                    int index_Next = indexes_Component[index];
                    indexes_Component[index] = index_Root;
                    index = index_Next;
                }

                return index_Root;
            }

            List<int> indexes_Compatible = [];

            void Test(int index_1, int index_2)
            {
                if (!Compatible(index_1, index_2))
                {
                    return;
                }

                indexes_Compatible.Add(index_1);
                indexes_Compatible.Add(index_2);

                int root_1 = Root(index_1);
                int root_2 = Root(index_2);

                if (root_1 != root_2)
                {
                    indexes_Component[root_1] = root_2;
                }
            }

            foreach (KeyValuePair<(long X, long Y, long Z), int> keyValuePair in index_ByCell)
            {
                for (int index_1 = keyValuePair.Value; index_1 >= 0; index_1 = indexes_Next[index_1])
                {
                    for (int index_2 = indexes_Next[index_1]; index_2 >= 0; index_2 = indexes_Next[index_2])
                    {
                        Test(index_1, index_2);
                    }
                }

                (long X, long Y, long Z) cell = keyValuePair.Key;

                for (int i = 0; i < offsets_Neighbour.Length; i++)
                {
                    (long X, long Y, long Z) offset = offsets_Neighbour[i];

                    if (!index_ByCell.TryGetValue((cell.X + offset.X, cell.Y + offset.Y, cell.Z + offset.Z), out int index_Head))
                    {
                        continue;
                    }

                    for (int index_1 = keyValuePair.Value; index_1 >= 0; index_1 = indexes_Next[index_1])
                    {
                        for (int index_2 = index_Head; index_2 >= 0; index_2 = indexes_Next[index_2])
                        {
                            Test(index_1, index_2);
                        }
                    }
                }
            }

            int[] counts_Component = new int[count_Edges];
            for (int i = 0; i < count_Edges; i++)
            {
                counts_Component[Root(i)]++;
            }

            // A component holding a single half-edge is a naked edge, and an odd one cannot be paired off however
            // its members are assigned. A component of exactly two is matched by construction, since the two were
            // joined by a compatibility test in the first place.
            HashSet<int> roots_Large = [];

            for (int i = 0; i < count_Edges; i++)
            {
                if (Root(i) != i)
                {
                    continue;
                }

                int count_Component = counts_Component[i];

                if (count_Component < 2 || (count_Component & 1) != 0)
                {
                    return false;
                }

                if (manifold && count_Component != 2)
                {
                    return false;
                }

                if (count_Component > 2)
                {
                    roots_Large.Add(i);
                }
            }

            if (roots_Large.Count == 0)
            {
                return true;
            }

            // Anything larger than a pair needs a real decision: an even component does not have to be matchable,
            // as a star of one centre and three leaves shows. Members are numbered within their own component so
            // each one gets an adjacency list of its own size.
            Dictionary<int, List<int>[]> adjacencies_ByRoot = new(roots_Large.Count);
            Dictionary<int, int> counts_Assigned = new(roots_Large.Count);
            Dictionary<int, int> indexes_Local = [];

            for (int i = 0; i < count_Edges; i++)
            {
                int root = Root(i);
                if (!roots_Large.Contains(root))
                {
                    continue;
                }

                if (!adjacencies_ByRoot.TryGetValue(root, out List<int>[]? adjacency))
                {
                    adjacency = new List<int>[counts_Component[root]];
                    adjacencies_ByRoot[root] = adjacency;
                }

                counts_Assigned.TryGetValue(root, out int count_Assigned);

                indexes_Local[i] = count_Assigned;
                adjacency[count_Assigned] = [];
                counts_Assigned[root] = count_Assigned + 1;
            }

            for (int i = 0; i < indexes_Compatible.Count; i += 2)
            {
                int index_1 = indexes_Compatible[i];
                int index_2 = indexes_Compatible[i + 1];

                int root = Root(index_1);
                if (!roots_Large.Contains(root))
                {
                    continue;
                }

                List<int>[] adjacency = adjacencies_ByRoot[root];

                int local_1 = indexes_Local[index_1];
                int local_2 = indexes_Local[index_2];

                adjacency[local_1].Add(local_2);
                adjacency[local_2].Add(local_1);
            }

            // Edmonds blossom algorithm, so the decision holds for a general graph - the compatibility graph is
            // not bipartite, and odd cycles do occur where three or more half-edges sit within a tolerance of one
            // another. Components are small, so the cubic bound never shows.
            bool PerfectMatching(List<int>[] adjacency)
            {
                int count = adjacency.Length;

                int[] indexes_Match = new int[count];
                int[] indexes_Parent = new int[count];
                int[] indexes_Base = new int[count];
                bool[] used = new bool[count];
                bool[] used_Lowest = new bool[count];
                bool[] blossom = new bool[count];

                void ClearFlags(bool[] flags)
                {
                    for (int i = 0; i < count; i++)
                    {
                        flags[i] = false;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    indexes_Match[i] = -1;
                }

                int Lowest(int index_1, int index_2)
                {
                    ClearFlags(used_Lowest);

                    int index = index_1;
                    while (true)
                    {
                        index = indexes_Base[index];
                        used_Lowest[index] = true;

                        if (indexes_Match[index] == -1)
                        {
                            break;
                        }

                        index = indexes_Parent[indexes_Match[index]];
                    }

                    index = index_2;
                    while (true)
                    {
                        index = indexes_Base[index];

                        if (used_Lowest[index])
                        {
                            return index;
                        }

                        index = indexes_Parent[indexes_Match[index]];
                    }
                }

                void MarkPath(int index, int index_Base, int index_Child)
                {
                    while (indexes_Base[index] != index_Base)
                    {
                        blossom[indexes_Base[index]] = true;
                        blossom[indexes_Base[indexes_Match[index]]] = true;
                        indexes_Parent[index] = index_Child;
                        index_Child = indexes_Match[index];
                        index = indexes_Parent[indexes_Match[index]];
                    }
                }

                int FindPath(int index_Root)
                {
                    ClearFlags(used);

                    for (int i = 0; i < count; i++)
                    {
                        indexes_Parent[i] = -1;
                        indexes_Base[i] = i;
                    }

                    used[index_Root] = true;

                    Queue<int> indexes_Queue = new();
                    indexes_Queue.Enqueue(index_Root);

                    while (indexes_Queue.Count > 0)
                    {
                        int index = indexes_Queue.Dequeue();
                        List<int> indexes_Adjacent = adjacency[index];

                        for (int i = 0; i < indexes_Adjacent.Count; i++)
                        {
                            int index_Adjacent = indexes_Adjacent[i];

                            if (indexes_Base[index] == indexes_Base[index_Adjacent] || indexes_Match[index] == index_Adjacent)
                            {
                                continue;
                            }

                            if (index_Adjacent == index_Root || (indexes_Match[index_Adjacent] != -1 && indexes_Parent[indexes_Match[index_Adjacent]] != -1))
                            {
                                int index_Lowest = Lowest(index, index_Adjacent);

                                ClearFlags(blossom);
                                MarkPath(index, index_Lowest, index_Adjacent);
                                MarkPath(index_Adjacent, index_Lowest, index);

                                for (int j = 0; j < count; j++)
                                {
                                    if (!blossom[indexes_Base[j]])
                                    {
                                        continue;
                                    }

                                    indexes_Base[j] = index_Lowest;

                                    if (!used[j])
                                    {
                                        used[j] = true;
                                        indexes_Queue.Enqueue(j);
                                    }
                                }
                            }
                            else if (indexes_Parent[index_Adjacent] == -1)
                            {
                                indexes_Parent[index_Adjacent] = index;

                                if (indexes_Match[index_Adjacent] == -1)
                                {
                                    return index_Adjacent;
                                }

                                used[indexes_Match[index_Adjacent]] = true;
                                indexes_Queue.Enqueue(indexes_Match[index_Adjacent]);
                            }
                        }
                    }

                    return -1;
                }

                for (int i = 0; i < count; i++)
                {
                    if (indexes_Match[i] != -1)
                    {
                        continue;
                    }

                    int index = FindPath(i);
                    while (index != -1)
                    {
                        int index_Parent = indexes_Parent[index];
                        int index_Next = indexes_Match[index_Parent];

                        indexes_Match[index] = index_Parent;
                        indexes_Match[index_Parent] = index;

                        index = index_Next;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    if (indexes_Match[i] == -1)
                    {
                        return false;
                    }
                }

                return true;
            }

            foreach (KeyValuePair<int, List<int>[]> keyValuePair in adjacencies_ByRoot)
            {
                if (!PerfectMatching(keyValuePair.Value))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
