using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class TransformGroup3D : SerializableObject, ITransform3D, IEnumerable<ITransform3D>
    {
        [JsonInclude, JsonPropertyName("Transform3Ds")]
        private readonly List<ITransform3D>? transform3Ds;

        public TransformGroup3D(IEnumerable<ITransform3D>? transform3Ds)
        {
            this.transform3Ds = DiGi.Core.Query.Clone(transform3Ds)?.FilterNulls();
        }

        public TransformGroup3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public TransformGroup3D(TransformGroup3D? transformGroup3D)
        {
            if (transformGroup3D != null)
            {
                transform3Ds = DiGi.Core.Query.Clone(transformGroup3D.transform3Ds)?.FilterNulls();
            }
        }

        public IEnumerator<ITransform3D> GetEnumerator()
        {
            List<ITransform3D>? transform3Ds_Temp = DiGi.Core.Query.Clone(transform3Ds).FilterNulls();
            if (transform3Ds_Temp is null)
            {
                return Enumerable.Empty<ITransform3D>().GetEnumerator();
            }

            return transform3Ds_Temp.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}