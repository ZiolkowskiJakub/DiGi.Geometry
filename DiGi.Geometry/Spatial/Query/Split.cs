using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static List<VolatilePolygonalFace3D> Split(this VolatilePolygonalFace3D volatilePolygonalFace3D, IEnumerable<VolatilePolygonalFace3D> volatilePolygonalFace3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (volatilePolygonalFace3D == null || volatilePolygonalFace3Ds == null)
            {
                return null;
            }

            PlanarIntersectionResult planarIntersectionResult = Create.PlanarIntersectionResult(volatilePolygonalFace3D, volatilePolygonalFace3Ds, tolerance);
            if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return new List<VolatilePolygonalFace3D>() { new VolatilePolygonalFace3D(volatilePolygonalFace3D) };
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
                return new List<VolatilePolygonalFace3D>() { new VolatilePolygonalFace3D(volatilePolygonalFace3D) };
            }

            PolygonalFace3D polygonalFace3D = volatilePolygonalFace3D.Geometry;
            if(polygonalFace3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane;
            if(plane == null)
            {
                return null;
            }

            List<PolygonalFace2D> polygonalFace2Ds = Planar.Query.Split(polygonalFace3D.Geometry2D, segmentable2Ds, tolerance);
            if(polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return null;
            }

            List<VolatilePolygonalFace3D> result = new List<VolatilePolygonalFace3D>();
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

            List<Tuple<VolatilePolygonalFace3D, List<VolatilePolygonalFace3D>>> tuples = new List<Tuple<VolatilePolygonalFace3D, List<VolatilePolygonalFace3D>>>();
            for (int i = 0; i < count; i++)
            {
                VolatilePolygonalFace3D volatilePolygonalFace3D = polyhedron[i];
                if (volatilePolygonalFace3D == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<VolatilePolygonalFace3D, List<VolatilePolygonalFace3D>>(volatilePolygonalFace3D, new List<VolatilePolygonalFace3D>()));
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
                    VolatilePolygonalFace3D volatilePolygonalFace3D = polyhedron_Temp[i];
                    if (volatilePolygonalFace3D == null)
                    {
                        continue;
                    }

                    BoundingBox3D boundingBox3D = volatilePolygonalFace3D.BoundingBox;

                    for(int j = 0; j < tuples.Count; j++)
                    {
                        if (boundingBox3D.InRange(tuples[j].Item1.BoundingBox, tolerance))
                        {
                            tuples[j].Item2.Add(volatilePolygonalFace3D);
                        }
                    }
                }
            }

            List<VolatilePolygonalFace3D> volatilePolygonalFace3Ds = new List<VolatilePolygonalFace3D>();
            for (int i = 0; i < tuples.Count; i++)
            {
                Tuple<VolatilePolygonalFace3D, List<VolatilePolygonalFace3D>> tuple = tuples[i];

                List<VolatilePolygonalFace3D> volatilePolygonalFace3Ds_Temp = Split(tuple.Item1, tuple.Item2, tolerance);
                if(volatilePolygonalFace3Ds_Temp != null && volatilePolygonalFace3Ds_Temp.Count != 0)
                {
                    volatilePolygonalFace3Ds.AddRange(volatilePolygonalFace3Ds_Temp);
                }
            }

            return new Polyhedron(volatilePolygonalFace3Ds);
        }

        public static VolatilePolyhedron Split(this VolatilePolyhedron volatilePolyhedron, IEnumerable<VolatilePolyhedron> volatilePolyhedrons, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(volatilePolyhedron == null || volatilePolyhedrons == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = volatilePolyhedron.BoundingBox;
            if(boundingBox3D == null)
            {
                return null;
            }

            List<Polyhedron> polyhedrons = new List<Polyhedron>();
            foreach(VolatilePolyhedron volatilePolyhedron_Temp in volatilePolyhedrons)
            {
                if(!boundingBox3D.InRange(volatilePolyhedron_Temp?.BoundingBox, tolerance))
                {
                    continue;
                }

                polyhedrons.Add(volatilePolyhedron_Temp);
            }

            if(polyhedrons == null || polyhedrons.Count == 0)
            {
                return new VolatilePolyhedron(volatilePolyhedron);
            }

            return Split(volatilePolyhedron.Geometry, polyhedrons, tolerance);
        }
    }
}
