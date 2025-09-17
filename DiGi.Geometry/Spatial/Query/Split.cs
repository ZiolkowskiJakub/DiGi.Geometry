using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static List<IPolygonalFace3D>? Split(this IPolygonalFace3D? polygonalFace3D, IEnumerable<IPolygonalFace3D>? polygonalFace3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonalFace3D == null || polygonalFace3Ds == null)
            {
                return null;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(polygonalFace3D, polygonalFace3Ds, tolerance);
            if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return [DiGi.Core.Query.Clone(polygonalFace3D)];
            }

            List<ISegmentable2D> segmentable2Ds = [];

            List<IGeometry2D>? geometry2Ds = planarIntersectionResult.GetGeometry2Ds<IGeometry2D>();
            if(geometry2Ds != null)
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

            if(segmentable2Ds.Count == 0)
            {
                return [DiGi.Core.Query.Clone(polygonalFace3D)];
            }

            Plane? plane = polygonalFace3D.Plane;
            if(plane == null)
            {
                return null;
            }

            List<IPolygonalFace2D>? polygonalFace2Ds = Planar.Query.Split(polygonalFace3D?.Geometry2D, segmentable2Ds, tolerance);
            if(polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> result = [];
            for(int i =0; i < polygonalFace2Ds.Count; i++)
            {
                result.Add(new PolygonalFace3D(plane, polygonalFace2Ds[i]));
            }

            return result;
        }

        public static Polyhedron? Split(this Polyhedron? polyhedron, IEnumerable<Polyhedron>? polyhedrons, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polyhedron == null || polyhedrons == null)
            {
                return null;
            }

            int count;

            count = polyhedron.Count;
            if(count == 0)
            {
                return DiGi.Core.Query.Clone(polyhedron);
            }

            List<Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>> tuples = [];
            for (int i = 0; i < count; i++)
            {
                IPolygonalFace3D? polygonalFace3D = polyhedron[i];
                if (polygonalFace3D == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>(polygonalFace3D, []));
            }

            foreach (Polyhedron polyhedron_Temp in polyhedrons)
            {
                if(polyhedron_Temp == null)
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
                    IPolygonalFace3D? polygonalFace3D = polyhedron_Temp[i];
                    if (polygonalFace3D == null)
                    {
                        continue;
                    }

                    BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();
                    if(boundingBox3D is null)
                    {
                        continue;
                    }

                    for(int j = 0; j < tuples.Count; j++)
                    {
                        if (boundingBox3D.InRange(tuples[j].Item1.GetBoundingBox(), tolerance))
                        {
                            tuples[j].Item2.Add(polygonalFace3D);
                        }
                    }
                }
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];
            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<IPolygonalFace3D, List<IPolygonalFace3D>> tuple = tuples[i];

                List<IPolygonalFace3D>? polygonalFace3Ds_Temp = Split(tuple.Item1, tuple.Item2, tolerance);
                if(polygonalFace3Ds_Temp != null && polygonalFace3Ds_Temp.Count != 0)
                {
                    foreach(IPolygonalFace3D polygonalFace3D_Temp in polygonalFace3Ds_Temp)
                    {
                        polygonalFace3Ds.Add(polygonalFace3D_Temp);
                    }
                }
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        public static List<Polyhedron>? Split(this Plane plane, Polyhedron? polyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || polyhedron == null)
            {
                return null;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(plane, polyhedron, tolerance);
            if (planarIntersectionResult is null || !planarIntersectionResult.Intersect || planarIntersectionResult.GetGeometry3Ds<IPolygonalFace3D>() is not List<IPolygonalFace3D> polygonalFace3Ds_Plane || polygonalFace3Ds_Plane.Count == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];

            foreach(IPolygonalFace3D polygonalFace3D in polyhedron.PolygonalFaces!)
            {
                if(Split(plane, polygonalFace3D, tolerance) is List<IPolygonalFace3D> polygonalFace3Ds_Split && polygonalFace3Ds_Split.Count != 0)
                {
                    polygonalFace3Ds.AddRange(polygonalFace3Ds_Split);
                }
                else
                {
                    polygonalFace3Ds.Add(polygonalFace3D);
                }
            }

            if(!DiGi.Core.Query.Filter(polygonalFace3Ds, x => plane.Above(x?.GetBoundingBox()?.GetCentroid(), tolerance), out List<IPolygonalFace3D>? polygonalFace3Ds_Above, out List<IPolygonalFace3D>? polygonalFace3Ds_Below))
            {
                return null;
            }

            Func<List<IPolygonalFace3D>?, List<Polyhedron>> createPolyhedrons = new (x => 
            {
                List<Polyhedron> result = [];

                if (x is null)
                {
                    return result;
                }

                x.AddRange(polygonalFace3Ds_Plane);

                while (x.Count > 0)
                {
                    IPolygonalFace3D polygonalFace3D_Above = x[0];
                    x.RemoveAt(0);

                    List<IPolygonalFace3D>? polygonalFace3Ds_Polyhedron = ConnectedPolygonalFace3Ds(polygonalFace3D_Above, x, tolerance);
                    if (polygonalFace3Ds_Polyhedron is null)
                    {
                        continue;
                    }

                    polygonalFace3Ds_Polyhedron.Add(polygonalFace3D_Above);

                    polygonalFace3Ds_Polyhedron.ForEach(y => x.Remove(y));

                    Polyhedron? polyhedron_Temp = Create.Polyhedron(polygonalFace3Ds_Polyhedron);
                    if(polyhedron_Temp is null)
                    {
                        continue;
                    }

                    result.Add(polyhedron_Temp);
                }

                return result; 
            });

            List<Polyhedron> result = [];

            result.AddRange(createPolyhedrons.Invoke(polygonalFace3Ds_Above));
            result.AddRange(createPolyhedrons.Invoke(polygonalFace3Ds_Below));

            return result;
        }

        public static List<IPolygonalFace3D>? Split(this Plane plane, IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || polygonalFace3D == null)
            {
                return null;
            }

            if(polygonalFace3D.Plane is not Plane plane_PolygonalFace3D || polygonalFace3D.Geometry2D is not IPolygonalFace2D polygonalFace2D)
            {
                return null;
            }

            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(plane, polygonalFace3D, tolerance);
            if (planarIntersectionResult is null || !planarIntersectionResult.Intersect || planarIntersectionResult.GetGeometry3Ds<Segment3D>() is not List<Segment3D> segment3Ds || segment3Ds.Count == 0)
            {
                return null;
            }

            if(segment3Ds.ConvertAll(plane_PolygonalFace3D.Convert).FilterNulls() is not List<Segment2D> segment2Ds)
            {
                return null;
            }

            List<IPolygonalFace2D>? polygonalFace2Ds = Planar.Query.Split(polygonalFace2D, segment2Ds, tolerance);
            if(polygonalFace2Ds is null)
            {
                return null;
            }

            return polygonalFace2Ds.ConvertAll(plane_PolygonalFace3D.Convert).FilterNulls();
        }
    }
}
