using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Collections;

namespace DiGi.Geometry.Planar.Classes
{
    public class TransformGroup2D : SerializableObject, ITransform2D, IEnumerable<ITransform2D>
    {
        [JsonInclude, JsonPropertyName("Transform2Ds")]
        private List<ITransform2D> transform2Ds;

        public TransformGroup2D(IEnumerable<ITransform2D> transform2Ds)
        {
            transform2Ds = DiGi.Core.Query.Clone(transform2Ds);
        }

        public TransformGroup2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public TransformGroup2D(TransformGroup2D transformGroup2D)
        {
            if(transformGroup2D != null)
            {
                transform2Ds = DiGi.Core.Query.Clone(transformGroup2D.transform2Ds);
            }
        }

        public IEnumerator<ITransform2D> GetEnumerator()
        {
            return DiGi.Core.Query.Clone(transform2Ds)?.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
