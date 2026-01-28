using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<IGeometry2D>? Geometry2Ds(IEnumerable<IGeometry2D>? geometry2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<IGeometry2D> result = [];

            List<Point2D> point2Ds = [];
            List<ISegmentable2D> segmentable2Ds = [];
            List<IPolygonalFace2D> polygonalFace2Ds = [];

            foreach (IGeometry2D geometry2D in geometry2Ds)
            {
                if (geometry2D is Point2D point2D)
                {
                    DiGi.Core.Modify.Add(point2Ds, point2D, x => x.Similar(point2D, tolerance));
                }
                else if (geometry2D is ISegmentable2D segmentable2D)
                {
                    DiGi.Core.Modify.Add(segmentable2Ds, segmentable2D, x => x.Similar(segmentable2D, tolerance));
                }
                else if (geometry2D is IPolygonalFace2D polygonalFace2D)
                {
                    DiGi.Core.Modify.Add(polygonalFace2Ds, polygonalFace2D, x => x.Similar(polygonalFace2D, tolerance));
                }
                else
                {
                    result.Add(geometry2D);
                }
            }

            if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
            {
                result.AddRange(polygonalFace2Ds);
            }

            List<Segment2D>? segment2Ds = null;

            if (segmentable2Ds != null && segmentable2Ds.Count != 0)
            {
                if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                {
                    List<Segment2D>? segment2Ds_PolgonalFace2D = polygonalFace2Ds.Segment2Ds();
                    if (segment2Ds_PolgonalFace2D != null)
                    {
                        segmentable2Ds.AddRange(segment2Ds_PolgonalFace2D);
                    }
                }

                segment2Ds = segmentable2Ds.Split(tolerance);

                if (segment2Ds != null && segment2Ds.Count != 0)
                {
                    if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                    {
                        foreach (IPolygonalFace2D polygonalFace2D in polygonalFace2Ds)
                        {
                            for (int i = segment2Ds.Count - 1; i >= 0; i--)
                            {
                                if (polygonalFace2D.OnEdge(segment2Ds[i].Mid(), tolerance))
                                {
                                    segment2Ds.RemoveAt(i);
                                }
                            }

                            if (segment2Ds.Count == 0)
                            {
                                break;
                            }
                        }
                    }

                    if (segment2Ds != null && segment2Ds.Count != 0)
                    {
                        List<Polygon2D>? polygon2Ds = segment2Ds.Polygon2Ds(tolerance);
                        if (polygon2Ds != null)
                        {
                            result.AddRange(polygon2Ds);

                            List<Segment2D>? segment2Ds_Polygon2D = polygon2Ds.Segments();
                            if (segment2Ds_Polygon2D != null)
                            {
                                foreach (Segment2D segment2D_Polygon2D in segment2Ds_Polygon2D)
                                {
                                    Point2D? point2D_Polygon2D = segment2D_Polygon2D.Mid();
                                    if (point2D_Polygon2D is null)
                                    {
                                        continue;
                                    }

                                    for (int i = segment2Ds.Count - 1; i >= 0; i--)
                                    {
                                        if (segment2Ds[i].On(point2D_Polygon2D, tolerance))
                                        {
                                            segment2Ds.RemoveAt(i);
                                            break;
                                        }
                                    }

                                    if (segment2Ds.Count == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }

                        List<Polyline2D>? polyline2Ds = Polyline2Ds(segment2Ds, null, false, tolerance);
                        if (polyline2Ds != null)
                        {
                            for (int i = 0; i < polyline2Ds.Count; i++)
                            {
                                List<Point2D>? point2Ds_Temp = polyline2Ds[i].GetPoints();
                                if (point2Ds_Temp == null || point2Ds_Temp.Count < 2)
                                {
                                    continue;
                                }

                                if (point2Ds_Temp.Count == 2)
                                {
                                    result.Add(new Segment2D(point2Ds_Temp[0], point2Ds_Temp[1]));
                                }
                                else
                                {
                                    result.Add(polyline2Ds[i]);
                                }
                            }
                        }

                        //result.AddRange(segment2Ds);
                    }
                }
            }

            if (point2Ds != null && point2Ds.Count != 0)
            {
                if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                {
                    for (int i = 0; i < polygonalFace2Ds.Count; i++)
                    {
                        for (int j = point2Ds.Count - 1; j >= 0; j--)
                        {
                            if (polygonalFace2Ds[i].OnEdge(point2Ds[j], tolerance))
                            {
                                point2Ds.RemoveAt(j);
                            }
                        }

                        if (point2Ds.Count == 0)
                        {
                            break;
                        }
                    }
                }

                if (point2Ds != null && point2Ds.Count != 0)
                {
                    if (segment2Ds != null && segment2Ds.Count != 0)
                    {
                        for (int i = 0; i < segment2Ds.Count; i++)
                        {
                            for (int j = point2Ds.Count - 1; j >= 0; j--)
                            {
                                if (segment2Ds[i].On(point2Ds[j], tolerance))
                                {
                                    point2Ds.RemoveAt(j);
                                }
                            }

                            if (point2Ds.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                }

                result.AddRange(point2Ds);
            }

            return result;
        }
    }
}