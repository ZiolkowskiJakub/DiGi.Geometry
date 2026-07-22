using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to split the specified polygonal face using a collection of other polygonal faces.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to be split.</param>
        /// <param name="polygonalFace3Ds">A collection of <see cref="IPolygonalFace3D"/> instances used as splitting boundaries.</param>
        /// <param name="result">When this method returns, contains a <see cref="List{PolygonalFace3D}"/> of the resulting split faces if successful; otherwise, null.</param>
        /// <param name="tolerance">The double value representing the distance tolerance for intersection calculations.</param>
        /// <returns>True if the polygonal face was successfully split; otherwise, false.</returns>
        public static bool TrySplit(this IPolygonalFace3D? polygonalFace3D, IEnumerable<IPolygonalFace3D>? polygonalFace3Ds, out List<PolygonalFace3D>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (polygonalFace3D == null || polygonalFace3Ds == null)
            {
                return false;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(polygonalFace3D, polygonalFace3Ds, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any())
            {
                return false;
            }

            List<ISegmentable2D> segmentable2Ds = [];

            List<IGeometry2D>? geometry2Ds = planarIntersectionResult.GetGeometry2Ds<IGeometry2D>();
            if (geometry2Ds != null)
            {
                foreach (IGeometry2D geometry2D in geometry2Ds)
                {
                    if (geometry2D is ISegmentable2D segmentable2D)
                    {
                        segmentable2Ds.Add(segmentable2D);
                    }
                    else if (geometry2D is IPolygonalFace2D polygonalFace2D_Temp)
                    {
                        IPolygonal2D? externalEdge = polygonalFace2D_Temp.ExternalEdge;
                        if (externalEdge != null)
                        {
                            segmentable2Ds.Add(externalEdge);
                        }

                        List<IPolygonal2D>? internalEdges = polygonalFace2D_Temp.InternalEdges;
                        if (internalEdges != null)
                        {
                            segmentable2Ds.AddRange(internalEdges);
                        }
                    }
                }
            }

            if (segmentable2Ds.Count == 0)
            {
                return false;
            }

            Plane? plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return false;
            }

            List<PolygonalFace2D>? polygonalFace2Ds = Planar.Query.Split(polygonalFace3D?.Geometry2D, segmentable2Ds, tolerance);
            if (polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return false;
            }

            result = [];
            for (int i = 0; i < polygonalFace2Ds.Count; i++)
            {
                result.Add(new PolygonalFace3D(plane, polygonalFace2Ds[i]));
            }

            return result.Count != 0;
        }

        /// <summary>
        /// Attempts to split the specified polyhedron using a collection of other polyhedrons.
        /// </summary>
        /// <typeparam name="TPolyhedron">The type of polyhedrons in the collection, which must implement <see cref="IPolyhedron"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="IPolyhedron"/> to be split.</param>
        /// <param name="polyhedrons">An <see cref="IEnumerable{TPolyhedron}"/> of polyhedrons used for the splitting process.</param>
        /// <param name="result">When this method returns, contains the resulting <see cref="Polyhedron"/> if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit<TPolyhedron>(this IPolyhedron? polyhedron, IEnumerable<TPolyhedron>? polyhedrons, out Polyhedron? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolyhedron : IPolyhedron
        {
            result = null;

            if (polyhedron == null || polyhedrons == null)
            {
                return false;
            }

            int count = polyhedron.Count;
            if (count == 0)
            {
                return false;
            }

            List<Tuple<IPolygonalFace3D, BoundingBox3D?, List<IPolygonalFace3D>>> tuples = [];
            for (int i = 0; i < count; i++)
            {
                IPolygonalFace3D? polygonalFace3D = polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i);
                if (polygonalFace3D == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<IPolygonalFace3D, BoundingBox3D?, List<IPolygonalFace3D>>(polygonalFace3D, polygonalFace3D.GetBoundingBox(), []));
            }

            foreach (TPolyhedron polyhedron_Temp in polyhedrons)
            {
                if (polyhedron_Temp == null)
                {
                    continue;
                }

                count = polyhedron_Temp.Count;
                if (count == 0)
                {
                    continue;
                }

                for (int i = 0; i < count; i++)
                {
                    IPolygonalFace3D? polygonalFace3D = polyhedron_Temp.GetPolygonalFace3D<IPolygonalFace3D>(i);
                    if (polygonalFace3D == null)
                    {
                        continue;
                    }

                    BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();
                    if (boundingBox3D is null)
                    {
                        continue;
                    }

                    for (int j = 0; j < tuples.Count; j++)
                    {
                        BoundingBox3D? boundingBox3D_Target = tuples[j].Item2;
                        if (boundingBox3D_Target != null && boundingBox3D.InRange(boundingBox3D_Target, tolerance))
                        {
                            tuples[j].Item3.Add(polygonalFace3D);
                        }
                    }
                }
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];
            bool splitAny = false;

            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<IPolygonalFace3D, BoundingBox3D?, List<IPolygonalFace3D>> tuple = tuples[i];

                if (tuple.Item3.Count > 0 && TrySplit(tuple.Item1, tuple.Item3, out List<PolygonalFace3D>? polygonalFace3Ds_Temp, tolerance) && polygonalFace3Ds_Temp != null && polygonalFace3Ds_Temp.Count != 0)
                {
                    polygonalFace3Ds.AddRange(polygonalFace3Ds_Temp);
                    splitAny = true;
                }
                else
                {
                    polygonalFace3Ds.Add(tuple.Item1);
                }
            }

            if (!splitAny || polygonalFace3Ds.Count == 0)
            {
                return false;
            }

            result = new Polyhedron(polygonalFace3Ds);
            return true;
        }

        /// <summary>
        /// Attempts to split a collection of polyhedrons based on a specified tolerance.
        /// </summary>
        /// <typeparam name="TPolyhedron">The type of polyhedron, which must implement <see cref="IPolyhedron"/>.</typeparam>
        /// <param name="polyhedrons">The <see cref="IEnumerable{TPolyhedron}"/> of polyhedrons to split.</param>
        /// <param name="result">When this method returns, contains the <see cref="List{Polyhedron}"/> of resulting polyhedrons if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine splitting boundaries.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit<TPolyhedron>(this IEnumerable<TPolyhedron>? polyhedrons, out List<Polyhedron>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolyhedron : IPolyhedron
        {
            result = null;

            if (polyhedrons is null)
            {
                return false;
            }

            List<Tuple<BoundingBox3D, TPolyhedron>> tuples = [];
            foreach (TPolyhedron polyhedron in polyhedrons)
            {
                if (polyhedron?.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox3D, TPolyhedron>(boundingBox3D, polyhedron));
            }

            result = [];
            bool splitAny = false;

            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<BoundingBox3D, TPolyhedron> tuple_1 = tuples[i];

                List<TPolyhedron> polyhedrons_Temp = [];
                for (int j = 0; j < tuples.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    Tuple<BoundingBox3D, TPolyhedron> tuple_2 = tuples[j];

                    if (!tuple_1.Item1.InRange(tuple_2.Item1, tolerance))
                    {
                        continue;
                    }

                    polyhedrons_Temp.Add(tuple_2.Item2);
                }

                Polyhedron? polyhedron = null;

                if (polyhedrons_Temp.Count > 0 && TrySplit(tuple_1.Item2, polyhedrons_Temp, out Polyhedron? polyhedron_Temp, tolerance) && polyhedron_Temp is not null)
                {
                    polyhedron = polyhedron_Temp;
                    splitAny = true;
                }
                else
                {
                    polyhedron = Create.Polyhedron(tuple_1.Item2);
                }

                if (polyhedron is not null)
                {
                    result.Add(polyhedron);
                }
            }

            if (!splitAny || result.Count == 0)
            {
                result = null;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to split a polyhedron using a specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used to perform the split operation.</param>
        /// <param name="polyhedron">The <see cref="IPolyhedron"/> that is to be split.</param>
        /// <param name="polyhedrons">When this method returns, contains a <see cref="List{Polyhedron}"/> of the resulting polyhedrons if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polyhedron was successfully split.</returns>
        public static bool TrySplit(this Plane? plane, IPolyhedron? polyhedron, out List<Polyhedron>? polyhedrons, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            polyhedrons = null;

            if (plane == null || polyhedron == null)
            {
                return false;
            }

            int count = polyhedron.Count;
            if (count == 0)
            {
                return false;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(plane, polyhedron, tolerance);
            if (planarIntersectionResult is null || !planarIntersectionResult.Any() || planarIntersectionResult.GetGeometry3Ds<IPolygonalFace3D>() is not List<IPolygonalFace3D> polygonalFace3Ds_Plane || polygonalFace3Ds_Plane.Count == 0)
            {
                return false;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];

            for (int i = 0; i < count; i++)
            {
                if (polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is not IPolygonalFace3D polygonalFace3D)
                {
                    continue;
                }

                if (TrySplit(plane, polygonalFace3D, out List<PolygonalFace3D>? polygonalFace3Ds_Split, tolerance) && polygonalFace3Ds_Split is not null && polygonalFace3Ds_Split.Count != 0)
                {
                    polygonalFace3Ds.AddRange(polygonalFace3Ds_Split);
                }
                else
                {
                    polygonalFace3Ds.Add(polygonalFace3D);
                }
            }

            if (!DiGi.Core.Query.Filter(polygonalFace3Ds, x => plane.Above(x?.GetBoundingBox()?.GetCentroid(), tolerance), out List<IPolygonalFace3D>? polygonalFace3Ds_Above, out List<IPolygonalFace3D>? polygonalFace3Ds_Below))
            {
                return false;
            }

            List<Polyhedron> CreatePolyhedrons(List<IPolygonalFace3D>? polygonalFace3Ds_Input)
            {
                List<Polyhedron> result = [];

                if (polygonalFace3Ds_Input is null)
                {
                    return result;
                }

                polygonalFace3Ds_Input.AddRange(polygonalFace3Ds_Plane);

                while (polygonalFace3Ds_Input.Count > 0)
                {
                    IPolygonalFace3D polygonalFace3D = polygonalFace3Ds_Input[0];
                    polygonalFace3Ds_Input.RemoveAt(0);

                    if (!TryGetConnectedPolygonalFace3Ds(polygonalFace3D, polygonalFace3Ds_Input, out List<IPolygonalFace3D>? polygonalFace3Ds_Connected, out List<IPolygonalFace3D>? polygonalFace3Ds_Disconnected, tolerance))
                    {
                        continue;
                    }

                    if (polygonalFace3Ds_Connected is null)
                    {
                        continue;
                    }

                    polygonalFace3Ds_Connected.Add(polygonalFace3D);

                    polygonalFace3Ds_Input = polygonalFace3Ds_Disconnected ?? [];

                    Polyhedron? polyhedron_Temp = new(polygonalFace3Ds_Connected);
                    if (polyhedron_Temp is null)
                    {
                        continue;
                    }

                    result.Add(polyhedron_Temp);
                }

                return result;
            }

            polyhedrons = [];

            polyhedrons.AddRange(CreatePolyhedrons(polygonalFace3Ds_Above));
            polyhedrons.AddRange(CreatePolyhedrons(polygonalFace3Ds_Below));

            return polyhedrons.Count != 0;
        }

        /// <summary>
        /// Attempts to split a 3D polygonal face using the specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the splitting surface.</param>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to be split.</param>
        /// <param name="result">When this method returns, contains a <see cref="List{PolygonalFace3D}"/> of the resulting faces if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit(this Plane? plane, IPolygonalFace3D? polygonalFace3D, out List<PolygonalFace3D>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            result = null;

            if (plane == null || polygonalFace3D == null)
            {
                return false;
            }

            if (polygonalFace3D.Plane is not Plane plane_PolygonalFace3D || polygonalFace3D.Geometry2D is not IPolygonalFace2D polygonalFace2D)
            {
                return false;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(plane, polygonalFace3D, tolerance);
            if (planarIntersectionResult is null || !planarIntersectionResult.Any() || planarIntersectionResult.GetGeometry3Ds<Segment3D>() is not List<Segment3D> segment3Ds || segment3Ds.Count == 0)
            {
                return false;
            }

            if (segment3Ds.ConvertAll(plane_PolygonalFace3D.Convert).FilterNulls() is not List<Segment2D> segment2Ds)
            {
                return false;
            }

            List<PolygonalFace2D>? polygonalFace2Ds = Planar.Query.Split(polygonalFace2D, segment2Ds, tolerance);
            if (polygonalFace2Ds is null)
            {
                return false;
            }

            result = polygonalFace2Ds.ConvertAll(plane_PolygonalFace3D.Convert).FilterNulls();

            return result is not null && result.Count != 0;
        }

        /// <summary>
        /// Attempts to split a mesh by the specified plane, separating triangles into above and below connected components.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the splitting surface.</param>
        /// <param name="mesh3D">The <see cref="Mesh3D"/> to split.</param>
        /// <param name="mesh3Ds_Above">When this method returns, contains a <see cref="List{Mesh3D}"/> of connected components above the plane, or null.</param>
        /// <param name="mesh3Ds_Below">When this method returns, contains a <see cref="List{Mesh3D}"/> of connected components below the plane, or null.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance for classification and intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit(this Plane? plane, Mesh3D? mesh3D, out List<Mesh3D>? mesh3Ds_Above, out List<Mesh3D>? mesh3Ds_Below, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            mesh3Ds_Above = null;
            mesh3Ds_Below = null;

            if (plane == null || mesh3D == null)
            {
                return false;
            }

            Vector3D? normal = plane.Normal;
            if (normal == null)
            {
                return false;
            }

            Point3D? origin = plane.Origin;
            if (origin == null)
            {
                return false;
            }

            List<Point3D>? points = mesh3D.GetPoints();
            List<int[]>? indexes = mesh3D.GetIndexes();
            if (points == null || indexes == null || points.Count == 0 || indexes.Count == 0)
            {
                return false;
            }

            double SignedDistance(Point3D point3D)
            {
                return normal.X * (point3D.X - origin.X) + normal.Y * (point3D.Y - origin.Y) + normal.Z * (point3D.Z - origin.Z);
            }

            int Classify(Point3D point3D)
            {
                double d = SignedDistance(point3D);
                if (d > tolerance)
                {
                    return 1;
                }

                if (d < -tolerance)
                {
                    return -1;
                }

                return 0;
            }

            List<Point3D> allPoints = new(points.Count + 64);
            for (int i = 0; i < points.Count; i++)
            {
                allPoints.Add(new Point3D(points[i]));
            }

            Dictionary<(int, int), int> edgeIntersections = new();
            List<(int, int, int)> aboveTriangles = [];
            List<(int, int, int)> belowTriangles = [];

            int GetIntersectionIndex(int index_1, int index_2, double distance_1, double distance_2)
            {
                (int, int) key = index_1 < index_2 ? (index_1, index_2) : (index_2, index_1);
                if (edgeIntersections.TryGetValue(key, out int existingIndex))
                {
                    return existingIndex;
                }

                double t = distance_1 / (distance_1 - distance_2);
                Point3D point3D_1 = points[index_1];
                Point3D point3D_2 = points[index_2];
                Point3D point3D_Intersection = new(point3D_1.X + t * (point3D_2.X - point3D_1.X), point3D_1.Y + t * (point3D_2.Y - point3D_1.Y), point3D_1.Z + t * (point3D_2.Z - point3D_1.Z));

                int newIndex = allPoints.Count;
                allPoints.Add(point3D_Intersection);
                edgeIntersections[key] = newIndex;
                return newIndex;
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                int[] idx = indexes[i];
                int index_0 = idx[0], index_1 = idx[1], index_2 = idx[2];

                if (index_0 < 0 || index_0 >= points.Count || index_1 < 0 || index_1 >= points.Count || index_2 < 0 || index_2 >= points.Count)
                {
                    continue;
                }

                int classify_0 = Classify(points[index_0]);
                int classify_1 = Classify(points[index_1]);
                int classify_2 = Classify(points[index_2]);

                int aboveCount = (classify_0 == 1 ? 1 : 0) + (classify_1 == 1 ? 1 : 0) + (classify_2 == 1 ? 1 : 0);
                int belowCount = (classify_0 == -1 ? 1 : 0) + (classify_1 == -1 ? 1 : 0) + (classify_2 == -1 ? 1 : 0);

                if (belowCount == 0 && aboveCount > 0)
                {
                    aboveTriangles.Add((index_0, index_1, index_2));
                }
                else if (aboveCount == 0 && belowCount > 0)
                {
                    belowTriangles.Add((index_0, index_1, index_2));
                }
                else if (aboveCount == 0 && belowCount == 0)
                {
                    continue;
                }
                else
                {
                    double distance_0 = SignedDistance(points[index_0]);
                    double distance_1 = SignedDistance(points[index_1]);
                    double distance_2 = SignedDistance(points[index_2]);

                    // Find edges that cross the plane (one endpoint above, one below)
                    int index01 = (classify_0 == 1 && classify_1 == -1) || (classify_0 == -1 && classify_1 == 1) ? GetIntersectionIndex(index_0, index_1, distance_0, distance_1) : -1;
                    int index12 = (classify_1 == 1 && classify_2 == -1) || (classify_1 == -1 && classify_2 == 1) ? GetIntersectionIndex(index_1, index_2, distance_1, distance_2) : -1;
                    int index20 = (classify_2 == 1 && classify_0 == -1) || (classify_2 == -1 && classify_0 == 1) ? GetIntersectionIndex(index_2, index_0, distance_2, distance_0) : -1;

                    if (aboveCount == 1 && belowCount == 2)
                    {
                        // One vertex above, two below: edge from above to each below crosses
                        if (classify_0 == 1)
                        {
                            aboveTriangles.Add((index_0, index01, index20));
                            belowTriangles.Add((index_1, index_2, index20));
                            belowTriangles.Add((index_1, index20, index01));
                        }
                        else if (classify_1 == 1)
                        {
                            aboveTriangles.Add((index_1, index12, index01));
                            belowTriangles.Add((index_2, index_0, index01));
                            belowTriangles.Add((index_2, index01, index12));
                        }
                        else
                        {
                            aboveTriangles.Add((index_2, index20, index12));
                            belowTriangles.Add((index_0, index_1, index12));
                            belowTriangles.Add((index_0, index12, index20));
                        }
                    }
                    else if (aboveCount == 2 && belowCount == 1)
                    {
                        // Two vertices above, one below: two edges cross
                        if (classify_0 == -1)
                        {
                            belowTriangles.Add((index_0, index01, index20));
                            aboveTriangles.Add((index_1, index_2, index20));
                            aboveTriangles.Add((index_1, index20, index01));
                        }
                        else if (classify_1 == -1)
                        {
                            belowTriangles.Add((index_1, index12, index01));
                            aboveTriangles.Add((index_2, index_0, index01));
                            aboveTriangles.Add((index_2, index01, index12));
                        }
                        else
                        {
                            belowTriangles.Add((index_2, index20, index12));
                            aboveTriangles.Add((index_0, index_1, index12));
                            aboveTriangles.Add((index_0, index12, index20));
                        }
                    }
                    else if (aboveCount == 1 && belowCount == 1)
                    {
                        // One above, one below, one on: single edge crosses
                        int crossingIndex = index01 != -1 ? index01 : index12 != -1 ? index12 : index20;

                        int onVertex = classify_0 == 0 ? index_0 : classify_1 == 0 ? index_1 : index_2;
                        int aboveVertex = classify_0 == 1 ? index_0 : classify_1 == 1 ? index_1 : index_2;
                        int belowVertex = classify_0 == -1 ? index_0 : classify_1 == -1 ? index_1 : index_2;

                        aboveTriangles.Add((aboveVertex, onVertex, crossingIndex));
                        belowTriangles.Add((belowVertex, crossingIndex, onVertex));
                    }
                }
            }

            Mesh3D? BuildMesh(List<(int, int, int)> triangleTriples)
            {
                if (triangleTriples == null || triangleTriples.Count == 0)
                {
                    return null;
                }

                Dictionary<int, int> indexRemap = new();
                List<Point3D> compactPoints = [];
                List<int[]> compactIndexes = new(triangleTriples.Count);

                foreach ((int i0, int i1, int i2) in triangleTriples)
                {
                    int Remap(int originalIndex)
                    {
                        if (!indexRemap.TryGetValue(originalIndex, out int remappedIndex))
                        {
                            remappedIndex = compactPoints.Count;
                            compactPoints.Add(new Point3D(allPoints[originalIndex]));
                            indexRemap[originalIndex] = remappedIndex;
                        }
                        return remappedIndex;
                    }

                    if (i0 == i1 || i1 == i2 || i2 == i0)
                    {
                        continue;
                    }

                    compactIndexes.Add([Remap(i0), Remap(i1), Remap(i2)]);
                }

                if (compactIndexes.Count == 0)
                {
                    return null;
                }

                return new Mesh3D(compactPoints, compactIndexes, false);
            }

            Mesh3D? aboveMesh = BuildMesh(aboveTriangles);
            Mesh3D? belowMesh = BuildMesh(belowTriangles);

            mesh3Ds_Above = aboveMesh?.Mesh3Ds();
            mesh3Ds_Below = belowMesh?.Mesh3Ds();

            if (mesh3Ds_Above == null || mesh3Ds_Above.Count == 0)
            {
                mesh3Ds_Above = null;
            }

            if (mesh3Ds_Below == null || mesh3Ds_Below.Count == 0)
            {
                mesh3Ds_Below = null;
            }

            if (mesh3Ds_Above == null && mesh3Ds_Below == null)
            {
                return false;
            }

            mesh3Ds_Above ??= [];
            mesh3Ds_Below ??= [];

            return true;
        }

        /// <summary>
        /// Attempts to split a mesh by the specified plane, combining connected components from above and below into a single result list.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the splitting surface.</param>
        /// <param name="mesh3D">The <see cref="Mesh3D"/> to split.</param>
        /// <param name="result">When this method returns, contains a <see cref="List{Mesh3D}"/> of the resulting meshes from both sides of the plane if the operation succeeded; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance for classification and intersection calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the split was successful.</returns>
        public static bool TrySplit(this Plane? plane, Mesh3D? mesh3D, out List<Mesh3D>? result, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (!TrySplit(plane, mesh3D, out List<Mesh3D>? mesh3Ds_Above, out List<Mesh3D>? mesh3Ds_Below, tolerance))
            {
                result = null;
                return false;
            }

            result = [];
            result.AddRange(mesh3Ds_Above ?? []);
            result.AddRange(mesh3Ds_Below ?? []);

            return true;
        }
    }
}