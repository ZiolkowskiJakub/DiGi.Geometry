using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class SegmentableFace2D : Geometry2D, ISegmentableFace2D
    {
        [JsonInclude, JsonPropertyName("ExternalCurve")]
        private IClosedSegmentable2D externalCurve;

        [JsonInclude, JsonPropertyName("InternalCurves")]
        private List<IClosedSegmentable2D> internalCurves;

        internal SegmentableFace2D(IClosedSegmentable2D externalCurve, IEnumerable<IClosedSegmentable2D> internalCurves = null)
        {
            this.externalCurve = DiGi.Core.Query.Clone(externalCurve);
            this.internalCurves = DiGi.Core.Query.Clone(internalCurves);
        }

        public IClosedSegmentable2D ExternalCurve
        {
            get
            {
                return DiGi.Core.Query.Clone(externalCurve);
            }
        }

        public List<IClosedSegmentable2D> InternalCurves
        {
            get
            {
                return DiGi.Core.Query.Clone(internalCurves);
            }
        }
    }
}
