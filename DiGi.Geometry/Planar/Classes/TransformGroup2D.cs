using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class TransformGroup2D : SerializableObject, ITransform2D, IEnumerable<ITransform2D>
    {
        [JsonInclude, JsonPropertyName("Transform2Ds")]
        private readonly List<ITransform2D>? transform2Ds;

        public TransformGroup2D(IEnumerable<ITransform2D>? transform2Ds)
        {
            this.transform2Ds = DiGi.Core.Query.Clone(transform2Ds)?.FilterNulls();
        }

        public TransformGroup2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public TransformGroup2D(TransformGroup2D? transformGroup2D)
        {
            if (transformGroup2D != null)
            {
                transform2Ds = DiGi.Core.Query.Clone(transformGroup2D.transform2Ds)?.FilterNulls();
            }
        }

        public IEnumerator<ITransform2D> GetEnumerator()
        {
            List<ITransform2D>? transform2Ds_Temp = DiGi.Core.Query.Clone(transform2Ds)?.FilterNulls();
            if (transform2Ds_Temp == null)
            {
                return Enumerable.Empty<ITransform2D>().GetEnumerator();
            }

            return transform2Ds_Temp.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}