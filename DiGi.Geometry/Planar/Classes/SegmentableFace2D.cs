using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class SegmentableFace2D : Geometry2D, ISegmentableFace2D
    {
        [JsonInclude, JsonPropertyName("ExternalCurve")]
        private IClosedSegmentable2D externalCurve;

        [JsonInclude, JsonPropertyName("InternalCurves")]
        private List<IClosedSegmentable2D> internalCurves;

        public SegmentableFace2D(SegmentableFace2D segmentableFace2D)
        {
            if (segmentableFace2D != null)
            {
                externalCurve = DiGi.Core.Query.Clone(segmentableFace2D.externalCurve);
                internalCurves = DiGi.Core.Query.Clone(segmentableFace2D.internalCurves);
            }
        }

        public SegmentableFace2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        internal SegmentableFace2D(IClosedSegmentable2D externalCurve, IEnumerable<IClosedSegmentable2D> internalCurves = null)
        {
            this.externalCurve = DiGi.Core.Query.Clone(externalCurve);
            this.internalCurves = DiGi.Core.Query.Clone(internalCurves);
        }

        [JsonIgnore]
        public IClosedSegmentable2D ExternalCurve
        {
            get
            {
                return DiGi.Core.Query.Clone(externalCurve);
            }
        }

        [JsonIgnore]
        public List<IClosedSegmentable2D> InternalCurves
        {
            get
            {
                return DiGi.Core.Query.Clone(internalCurves);
            }
        }

        [JsonIgnore]
        public List<IClosedSegmentable2D> Curves
        {
            get
            {
                if (externalCurve == null)
                {
                    return null;
                }

                List<IClosedSegmentable2D> result = new List<IClosedSegmentable2D>() { DiGi.Core.Query.Clone(externalCurve) };
                if (internalCurves == null || internalCurves.Count == 0)
                {
                    return result;
                }

                foreach(IClosedSegmentable2D internalCurve in internalCurves)
                {
                    if(internalCurve != null)
                    {
                        result.Add(DiGi.Core.Query.Clone(internalCurve));
                    }
                }

                return result;
            }
        }

        public override ISerializableObject Clone()
        {
            return new SegmentableFace2D(this);
        }

        public double GetArea()
        {
            if(externalCurve == null)
            {
                return double.NaN;
            }

            double result = externalCurve.GetArea();
            if(double.IsNaN(result) || result == 0)
            {
                return result;
            }

            if(internalCurves != null && internalCurves.Count != 0)
            {
                for(int i=0; i < internalCurves.Count; i++)
                {
                    if (internalCurves[i] == null)
                    {
                        continue;
                    }

                    result -= internalCurves[i].GetArea();
                }
            }

            return result;
        }

        public override bool Move(Vector2D vector2D)
        {
            if(vector2D == null || externalCurve == null)
            {
                return false;
            }

            externalCurve.Move(vector2D);

            if (internalCurves != null && internalCurves.Count != 0)
            {
                for (int i = 0; i < internalCurves.Count; i++)
                {
                    internalCurves[i]?.Move(vector2D);
                }
            }

            return true;
        }

        public override bool Transform(ITransform2D transform)
        {
            if (transform == null || externalCurve == null)
            {
                return false;
            }

            externalCurve.Transform(transform);

            if (internalCurves != null && internalCurves.Count != 0)
            {
                for (int i = 0; i < internalCurves.Count; i++)
                {
                    internalCurves[i]?.Transform(transform);
                }
            }

            return true;
        }
    }
}
