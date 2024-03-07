using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Concave(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return false;
            }

            List<Point2D> point2Ds_Temp = new List<Point2D>(point2Ds);

            int index = point2Ds_Temp.Count - 1;

            point2Ds_Temp.Add(point2Ds_Temp[0]);
            point2Ds_Temp.Insert(0, point2Ds_Temp[index]);

            int sign = System.Math.Sign(Determinant(point2Ds_Temp[0], point2Ds_Temp[1], point2Ds_Temp[2]));
            for (int i = 2; i < point2Ds_Temp.Count - 1; i++)
            {
                int sign_Temp = System.Math.Sign(Determinant(point2Ds_Temp[i - 1], point2Ds_Temp[i], point2Ds_Temp[i + 1]));
                if (sign != sign_Temp)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Concave(this IClosedSegmentable2D closedSegmentable2D)
        {
            return Concave(closedSegmentable2D?.GetPoints());
        }

        public static bool Concave(this SegmentableFace2D segmentableFace2D, bool externalCurve = true, bool internalCurves = true)
        {
            if (segmentableFace2D == null)
            {
                return false;
            }

            if(externalCurve)
            {
                IClosedSegmentable2D closedSegmentable2D = segmentableFace2D.ExternalCurve;
                if(closedSegmentable2D == null)
                {
                    return false;
                }

                if(!closedSegmentable2D.Concave())
                {
                    return false;
                }
            }

            if(internalCurves)
            {
                List<IClosedSegmentable2D> closedSegmentable2Ds = segmentableFace2D.InternalCurves;
                if(closedSegmentable2Ds != null)
                {
                    for(int i =0; i < closedSegmentable2Ds.Count; i++)
                    {
                        if (!closedSegmentable2Ds[i].Concave())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
