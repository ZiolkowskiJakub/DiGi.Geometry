using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Segment2D> Segments<T>(this IEnumerable<T> segmentable2Ds) where T : ISegmentable2D
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Segment2D> result = new List<Segment2D>();
            foreach (T segmentable2D in segmentable2Ds)
            {
                List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
                if (segment2Ds == null || segment2Ds.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    result.Add(segment2Ds[i]);
                }
            }

            return result;
        }

        public static List<Segment2D> Segments(this IPolygonalFace2D polygonalFace2D)
        {
            IPolygonal2D externalEdge = polygonalFace2D?.ExternalEdge;
            if(externalEdge == null)
            {
                return null;
            }

            List<Segment2D> result = externalEdge.GetSegments();
            if(result == null)
            {
                return null;
            }

            List<IPolygonal2D> internalEdges = polygonalFace2D.InternalEdges;
            if(internalEdges != null)
            {
                for(int i =0; i < internalEdges.Count; i++)
                {
                    List<Segment2D> segment2Ds = internalEdges[i]?.GetSegments();
                    if(segment2Ds != null && segment2Ds.Count != 0)
                    {
                        result.AddRange(segment2Ds);
                    }
                }
            }

            return result;
        }

        public static List<Segment2D> Segment2Ds<T>(this IEnumerable<T> polygonalFace2Ds) where T: IPolygonalFace2D
        {
            if(polygonalFace2Ds == null)
            {
                return null;
            }

            List<Segment2D> result = new List<Segment2D>();
            foreach(T polygonalFace2D in polygonalFace2Ds)
            {
                List<Segment2D> segment2Ds = polygonalFace2D?.Segments();
                if(segment2Ds == null || segment2Ds.Count == 0)
                {
                    continue;
                }

                result.AddRange(segment2Ds);
            }

            return result;
        }
    }
}
