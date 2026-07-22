using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Simplifies a collection of geometries by merging similar ones and decomposing them into basic primitives (points, segments, polylines, polygons, etc.).
        /// </summary>
        /// <param name="geometry2Ds">The collection of geometries to simplify.</param>
        /// <param name="tolerance">The distance tolerance used for similarity and intersection checks.</param>
        /// <returns>A simplified list of unique geometries; otherwise, null if input is null.</returns>
        public static List<IGeometry2D>? Geometry2Ds(IEnumerable<IGeometry2D>? geometry2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<IGeometry2D> result = [];

            List<Point2D> point2Ds = [];
            List<ISegmentable2D> segmentable2Ds = [];
            List<IPolygonalFace2D> polygonalFace2Ds = [];

            foreach (IGeometry2D? geometry2D in geometry2Ds)
            {
                if (geometry2D is null)
                {
                    continue;
                }

                if (geometry2D is Point2D point2D)
                {
                    DiGi.Core.Modify.Add(point2Ds, point2D, x => System.Math.Abs(x.X - point2D.X) <= tolerance && System.Math.Abs(x.Y - point2D.Y) <= tolerance && x.Similar(point2D, tolerance));
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

            if (polygonalFace2Ds.Count != 0)
            {
                result.AddRange(polygonalFace2Ds);
            }

            List<Segment2D>? segment2Ds = null;
            List<Segment2D> activeSegment2Ds = [];

            if (segmentable2Ds.Count != 0)
            {
                if (polygonalFace2Ds.Count != 0)
                {
                    List<Segment2D>? segment2Ds_PolygonalFace2D = polygonalFace2Ds.Segment2Ds();
                    if (segment2Ds_PolygonalFace2D != null)
                    {
                        segmentable2Ds.AddRange(segment2Ds_PolygonalFace2D);
                    }
                }

                segment2Ds = segmentable2Ds.Split(tolerance);

                if (segment2Ds != null && segment2Ds.Count != 0)
                {
                    if (polygonalFace2Ds.Count != 0)
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
                        activeSegment2Ds = [.. segment2Ds];

                        List<Polygon2D>? polygon2Ds = segment2Ds.Polygon2Ds(tolerance);
                        if (polygon2Ds != null && polygon2Ds.Count != 0)
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
                    }
                }
            }

            if (point2Ds.Count != 0)
            {
                if (polygonalFace2Ds.Count != 0)
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

                if (point2Ds.Count != 0 && activeSegment2Ds.Count != 0)
                {
                    for (int i = 0; i < activeSegment2Ds.Count; i++)
                    {
                        Segment2D activeSegment = activeSegment2Ds[i];
                        Point2D? start = activeSegment.Start;
                        Point2D? end = activeSegment.End;
                        if (start == null || end == null)
                        {
                            continue;
                        }

                        double minX = System.Math.Min(start.X, end.X) - tolerance;
                        double maxX = System.Math.Max(start.X, end.X) + tolerance;
                        double minY = System.Math.Min(start.Y, end.Y) - tolerance;
                        double maxY = System.Math.Max(start.Y, end.Y) + tolerance;

                        for (int j = point2Ds.Count - 1; j >= 0; j--)
                        {
                            Point2D point2D = point2Ds[j];
                            if (point2D.X >= minX && point2D.X <= maxX && point2D.Y >= minY && point2D.Y <= maxY)
                            {
                                if (activeSegment.On(point2D, tolerance))
                                {
                                    point2Ds.RemoveAt(j);
                                }
                            }
                        }

                        if (point2Ds.Count == 0)
                        {
                            break;
                        }
                    }
                }

                result.AddRange(point2Ds);
            }

            return result;
        }
    }
}