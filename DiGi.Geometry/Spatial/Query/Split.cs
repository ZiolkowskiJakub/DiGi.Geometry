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
        public static List<IPolygonalFace3D> Split(this IPolygonalFace3D polygonalFace3D, IEnumerable<IPolygonalFace3D> polygonalFace3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonalFace3D == null || polygonalFace3Ds == null)
            {
                return null;
            }

            PlanarIntersectionResult planarIntersectionResult = Create.PlanarIntersectionResult(polygonalFace3D, polygonalFace3Ds, tolerance);
            if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return new List<IPolygonalFace3D>() { DiGi.Core.Query.Clone(polygonalFace3D) };
            }

            List<ISegmentable2D> segmentable2Ds = new List<ISegmentable2D>();
            foreach(IGeometry2D geometry2D in planarIntersectionResult.GetGeometry2Ds<IGeometry2D>())
            {
                if(geometry2D is ISegmentable2D)
                {
                    segmentable2Ds.Add((ISegmentable2D)geometry2D);
                }
                else if(geometry2D is IPolygonalFace2D)
                {
                    IPolygonalFace2D polygonalFace2D_Temp = (IPolygonalFace2D)geometry2D;

                    IPolygonal2D externalEdge = polygonalFace2D_Temp.ExternalEdge;
                    if(externalEdge != null)
                    {
                        segmentable2Ds.Add(externalEdge);
                    }

                    List<IPolygonal2D> internalEdges = polygonalFace2D_Temp.InternalEdges;
                    if(internalEdges != null)
                    {
                        segmentable2Ds.AddRange(internalEdges);
                    }
                }
            }

            if(segmentable2Ds.Count == 0)
            {
                return new List<IPolygonalFace3D>() { DiGi.Core.Query.Clone(polygonalFace3D) };
            }

            Plane plane = polygonalFace3D.Plane;
            if(plane == null)
            {
                return null;
            }

            List<IPolygonalFace2D> polygonalFace2Ds = Planar.Query.Split(polygonalFace3D.Geometry2D, segmentable2Ds, tolerance);
            if(polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> result = new List<IPolygonalFace3D>();
            for(int i =0; i < polygonalFace2Ds.Count; i++)
            {
                result.Add(new PolygonalFace3D(plane, polygonalFace2Ds[i]));
            }

            return result;
        }

        public static Polyhedron Split(this Polyhedron polyhedron, IEnumerable<Polyhedron> polyhedrons, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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

            List<Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>> tuples = new List<Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>>();
            for (int i = 0; i < count; i++)
            {
                IPolygonalFace3D polygonalFace3D = polyhedron[i];
                if (polygonalFace3D == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<IPolygonalFace3D, List<IPolygonalFace3D>>(polygonalFace3D, new List<IPolygonalFace3D>()));
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
                    IPolygonalFace3D polygonalFace3D = polyhedron_Temp[i];
                    if (polygonalFace3D == null)
                    {
                        continue;
                    }

                    BoundingBox3D boundingBox3D = polygonalFace3D.GetBoundingBox();

                    for(int j = 0; j < tuples.Count; j++)
                    {
                        if (boundingBox3D.InRange(tuples[j].Item1.GetBoundingBox(), tolerance))
                        {
                            tuples[j].Item2.Add(polygonalFace3D);
                        }
                    }
                }
            }

            List<IPolygonalFace3D> polygonalFace3Ds = new List<IPolygonalFace3D>();
            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<IPolygonalFace3D, List<IPolygonalFace3D>> tuple = tuples[i];

                List<IPolygonalFace3D> polygonalFace3Ds_Temp = Split(tuple.Item1, tuple.Item2, tolerance);
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
    }
}
