using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Collections;

namespace DiGi.Geometry.Spatial.Classes
{
    public class TransformGroup3D : SerializableObject, ITransform3D, IEnumerable<ITransform3D>
    {
        [JsonInclude, JsonPropertyName("Transform3Ds")]
        private List<ITransform3D> transform3Ds;

        public TransformGroup3D(IEnumerable<ITransform3D> transform3Ds)
        {
            transform3Ds = DiGi.Core.Query.Clone(transform3Ds);
        }

        public TransformGroup3D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public TransformGroup3D(TransformGroup3D transformGroup3D)
        {
            if(transformGroup3D != null)
            {
                transform3Ds = DiGi.Core.Query.Clone(transformGroup3D.transform3Ds);
            }
        }

        public IEnumerator<ITransform3D> GetEnumerator()
        {
            return DiGi.Core.Query.Clone(transform3Ds)?.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
