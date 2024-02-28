using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static SegmentableFace2D SegmentableFace2D(this IClosedSegmentable2D externalCurve, IEnumerable<IClosedSegmentable2D> internalCurves = null, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(externalCurve == null)
            {
                return null;
            }

            List<IClosedSegmentable2D> internalCurves_Inside = null;
            if(internalCurves != null)
            {
                internalCurves_Inside = new List<IClosedSegmentable2D>();
                foreach (IClosedSegmentable2D internalCurve in internalCurves)
                {
                    if(externalCurve.Inside(internalCurve, tolerace))
                    {
                        internalCurves_Inside.Add(internalCurve);
                    }
                }

                if (internalCurves_Inside.Count > 1)
                {
                    DiGi.Core.Modify.Sort(internalCurves_Inside, x => x.GetArea());
                    internalCurves_Inside.Reverse();

                    List<IClosedSegmentable2D> internalCurves_Temp = new List<IClosedSegmentable2D>();

                    while(internalCurves_Inside.Count > 0)
                    {
                        IClosedSegmentable2D internalCurve = internalCurves_Inside[0];

                        internalCurves_Temp.Add(internalCurve);
                        internalCurves_Inside.RemoveAt(0);

                        for (int i = internalCurves_Inside.Count - 1; i >= 0; i--)
                        {
                            if (internalCurve.InRange(internalCurves_Inside[i], tolerace))
                            {
                                internalCurves_Inside.RemoveAt(i);
                            }
                        }
                    }

                    internalCurves_Inside = internalCurves_Temp;
                }

                if (internalCurves_Inside.Count == 0)
                {
                    internalCurves_Inside = null;
                }
            }

            return new SegmentableFace2D(externalCurve, internalCurves_Inside);
        }
    }

}
