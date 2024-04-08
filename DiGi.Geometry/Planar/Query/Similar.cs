using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Similar(this Point2D point2D_1, Point2D point2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return AlmostEquals(point2D_1, point2D_2, tolerance);
        }

        public static bool Similar(this Segment2D segment2D_1, Segment2D segment2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2D_1 == segment2D_2)
            {
                return true;
            }

            if (segment2D_1 == null || segment2D_2 == null)
            {
                return false;
            }

            return (AlmostEquals(segment2D_1[0], segment2D_2[0], tolerance) && AlmostEquals(segment2D_1[1], segment2D_2[1], tolerance)) || (AlmostEquals(segment2D_1[0], segment2D_2[1], tolerance) && AlmostEquals(segment2D_1[1], segment2D_2[0], tolerance));
        }

        public static bool Similar(this Vector2D vector2D_1, Vector2D vector2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (vector2D_1 == vector2D_2)
            {
                return true;
            }

            if (vector2D_1 == null || vector2D_2 == null)
            {
                return false;
            }

            Vector2D vector2D_3 = new Vector2D(vector2D_2);
            vector2D_3.Inverse();

            return vector2D_1.AlmostEquals(vector2D_2, tolerance) || vector2D_1.AlmostEquals(vector2D_3, tolerance);
        }

        public static bool Similar(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D_1 == segmentable2D_2)
            {
                return true;
            }

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            if(segmentable2D_1 is Segment2D && segmentable2D_2 is Segment2D)
            {
                return Similar((Segment2D)segmentable2D_1, (Segment2D)segmentable2D_2, tolerance);
            }

            List<Point2D> point2Ds_1 = segmentable2D_1.GetPoints();
            List<Point2D> point2Ds_2 = segmentable2D_2.GetPoints();
            if(point2Ds_1.Count == 2 && point2Ds_2.Count == 2)
            {
                return Similar(new Segment2D(point2Ds_1[0], point2Ds_1[1]), new Segment2D(point2Ds_2[0], point2Ds_2[1]), tolerance);
            }

            if((point2Ds_1 == null || point2Ds_1.Count == 0) && (point2Ds_2 == null || point2Ds_2.Count == 0))
            {
                return true;
            }

            if (point2Ds_1 == null || point2Ds_1.Count == 0 || point2Ds_2 == null || point2Ds_2.Count == 0)
            {
                return false;
            }

            if (point2Ds_1.Count == point2Ds_2.Count)
            {
                bool similar = true;
                for (int i = 0; i < point2Ds_2.Count; i++)
                {
                    similar = Similar(point2Ds_1[i], point2Ds_2[i], tolerance);
                    if(!similar)
                    {
                        break;
                    }
                }

                if(similar)
                {
                    return true;
                }
            }

            List<Segment2D> segment2Ds = segmentable2D_1.GetSegments();
            segment2Ds.AddRange(segmentable2D_2.GetSegments());

            segment2Ds = segment2Ds.Split(tolerance);

            foreach(Segment2D segment2D in segment2Ds)
            {
                Point2D point2D = segment2D.Mid();

                if(!segmentable2D_1.On(point2D, tolerance))
                {
                    return false;
                }

                if (!segmentable2D_2.On(point2D, tolerance))
                {
                    return false;
                }

            }

            return true;

        }

        public static bool Similar(this IPolygonalFace2D polygonalFace2D_1, IPolygonalFace2D polygonalFace2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonalFace2D_1 == null && polygonalFace2D_2 == null)
            {
                return true;
            }

            if(polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return false;
            }

            List<IPolygonal2D> internalEdges_1 = polygonalFace2D_1.InternalEdges;
            internalEdges_1?.RemoveAll(x => x == null);
            List<IPolygonal2D> internalEdges_2 = polygonalFace2D_2.InternalEdges;
            internalEdges_2?.RemoveAll(x => x == null);

            if(internalEdges_1 != null && internalEdges_2 != null)
            {
                if(internalEdges_1.Count != internalEdges_2.Count)
                {
                    return false;
                }

                for(int i=0; i < internalEdges_1.Count; i++)
                {
                    bool result = Similar(internalEdges_1[i], internalEdges_2[i], tolerance);
                    if (!result)
                    {
                        return false;
                    }
                }
            }

            return Similar(polygonalFace2D_1.ExternalEdge, polygonalFace2D_2.ExternalEdge, tolerance);
        }
    }
}
