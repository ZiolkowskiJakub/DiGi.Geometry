﻿using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<Polygon2D> Polygon2Ds(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D == null)
            {
                return null;
            }

            List<Polygon2D> result = new List<Polygon2D>();
            if(segmentable2D is Rectangle2D)
            {
                result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else if(segmentable2D is Triangle2D)
            {
                result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else if(segmentable2D is BoundingBox2D)
            {
                result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else
            {
                List<Segment2D> segment2Ds = segmentable2D.GetSegments();
                if(segment2Ds != null && segment2Ds.Count > 2)
                {
                    segment2Ds = Query.Split(segment2Ds, tolerance);
                    List<PolygonalFace2D> polygonalFace2Ds = PolygonalFace2Ds(segment2Ds, tolerance);
                    if(polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                    {
                        foreach(PolygonalFace2D polygonalFace2D in polygonalFace2Ds)
                        {
                            List<IPolygonal2D> polygonal2Ds = polygonalFace2D.Edges;
                            if(polygonal2Ds != null)
                            {
                                foreach(IPolygonal2D polygonal2D in polygonal2Ds)
                                {
                                    if(polygonal2D != null)
                                    {
                                        result.Add(new Polygon2D(polygonal2D.GetPoints()));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }

}
