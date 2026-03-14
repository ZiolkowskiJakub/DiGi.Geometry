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
        public static bool TrySplit(this IPolygonalFace3D? polygonalFace3D, IEnumerable<IPolygonalFace3D>? polygonalFace3Ds, out List<PolygonalFace3D>? result, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            result = null;

            if (polygonalFace3D == null || polygonalFace3Ds == null)
            {
                return false;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(polygonalFace3D, polygonalFace3Ds, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
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

        public static bool TrySplit<TPolyhedron>(this IPolyhedron? polyhedron, IEnumerable<TPolyhedron>? polyhedrons, out Polyhedron? result, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where TPolyhedron : IPolyhedron
        {
            result = null;

            if (polyhedron == null || polyhedrons == null)
            {
                return false;
            }

            int count;

            count = polyhedron.Count;
            if (count == 0)
            {
                return false;
            }

            List<Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>> tuples = [];
            for (int i = 0; i < count; i++)
            {
                IPolygonalFace3D? polygonalFace3D = polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i);
                if (polygonalFace3D == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>(polygonalFace3D, []));
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
                        if (boundingBox3D.InRange(tuples[j].Item1.GetBoundingBox(), tolerance))
                        {
                            tuples[j].Item2.Add(polygonalFace3D);
                        }
                    }
                }
            }

            List<PolygonalFace3D> polygonalFace3Ds = [];
            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<IPolygonalFace3D, List<IPolygonalFace3D>> tuple = tuples[i];

                if (!TrySplit(tuple.Item1, tuple.Item2, out List<PolygonalFace3D>? polygonalFace3Ds_Temp, tolerance) || polygonalFace3Ds_Temp == null)
                {
                    continue;
                }

                foreach (PolygonalFace3D polygonalFace3D_Temp in polygonalFace3Ds_Temp)
                {
                    polygonalFace3Ds.Add(polygonalFace3D_Temp);
                }
            }

            if (polygonalFace3Ds.Count == 0)
            {
                return false;
            }

            result = new Polyhedron(polygonalFace3Ds);
            return true;
        }

        public static bool TrySplit<TPolyhedron>(this IEnumerable<TPolyhedron> polyhedrons, out List<Polyhedron>? result, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where TPolyhedron : IPolyhedron
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

                if (polyhedrons_Temp == null || polyhedrons_Temp.Count == 0)
                {
                    polyhedron = Create.Polyhedron(tuple_1.Item2);
                }
                else if (TrySplit(tuple_1.Item2, polyhedrons_Temp, out Polyhedron? polyhedron_Temp, tolerance) && polyhedron_Temp is not null)
                {
                    polyhedron = polyhedron_Temp;
                }

                if (polyhedron is null)
                {
                    continue;
                }

                result.Add(polyhedron);
            }

            return result.Count != 0;
        }

        public static bool TrySplit(this Plane? plane, IPolyhedron? polyhedron, out List<Polyhedron>? polyhedrons, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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
            if (planarIntersectionResult is null || !planarIntersectionResult.Intersect || planarIntersectionResult.GetGeometry3Ds<IPolygonalFace3D>() is not List<IPolygonalFace3D> polygonalFace3Ds_Plane || polygonalFace3Ds_Plane.Count == 0)
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

            Func<List<IPolygonalFace3D>?, List<Polyhedron>> createPolyhedrons = new(x =>
            {
                List<Polyhedron> result = [];

                if (x is null)
                {
                    return result;
                }

                x.AddRange(polygonalFace3Ds_Plane);

                while (x.Count > 0)
                {
                    IPolygonalFace3D polygonalFace3D = x[0];
                    x.RemoveAt(0);

                    if (!TryGetConnectedPolygonalFace3Ds(polygonalFace3D, x, out List<IPolygonalFace3D>? polygonalFace3Ds_Connected, out List<IPolygonalFace3D>? polygonalFace3Ds_Disconnected, tolerance))
                    {
                        continue;
                    }

                    if (polygonalFace3Ds_Connected is null)
                    {
                        continue;
                    }

                    polygonalFace3Ds_Connected.Add(polygonalFace3D);

                    x = polygonalFace3Ds_Disconnected ?? [];

                    Polyhedron? polyhedron_Temp = new(polygonalFace3Ds_Connected);
                    if (polyhedron_Temp is null)
                    {
                        continue;
                    }

                    result.Add(polyhedron_Temp);
                }

                return result;
            });

            polyhedrons = [];

            polyhedrons.AddRange(createPolyhedrons.Invoke(polygonalFace3Ds_Above));
            polyhedrons.AddRange(createPolyhedrons.Invoke(polygonalFace3Ds_Below));

            return polyhedrons.Count != 0;
        }

        public static bool TrySplit(this Plane? plane, IPolygonalFace3D? polygonalFace3D, out List<PolygonalFace3D>? result, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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
            if (planarIntersectionResult is null || !planarIntersectionResult.Intersect || planarIntersectionResult.GetGeometry3Ds<Segment3D>() is not List<Segment3D> segment3Ds || segment3Ds.Count == 0)
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
    }
}