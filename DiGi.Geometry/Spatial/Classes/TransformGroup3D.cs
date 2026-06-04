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
    /// <summary>
    /// Represents a group of 3D transformations that can be treated as a single transformation or iterated over as a collection of <see cref="ITransform3D"/> objects.
    /// </summary>
    public class TransformGroup3D : SerializableObject, ITransform3D, IEnumerable<ITransform3D>
    {
        [JsonInclude, JsonPropertyName("Transform3Ds")]
        private readonly List<ITransform3D>? transform3Ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformGroup3D"/> class with the specified collection of transforms.
        /// </summary>
        /// <param name="transform3Ds">An <see cref="IEnumerable{ITransform3D}"/> containing the transform objects to be added to the group. This value can be null.</param>
        public TransformGroup3D(IEnumerable<ITransform3D>? transform3Ds)
        {
            this.transform3Ds = DiGi.Core.Query.Clone(transform3Ds)?.FilterNulls();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformGroup3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the object. This value can be null.</param>
        public TransformGroup3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformGroup3D"/> class by cloning an existing <see cref="TransformGroup3D"/> instance.
        /// </summary>
        /// <param name="transformGroup3D">The <see cref="TransformGroup3D"/> instance to clone from, or null to initialize without a source.</param>
        public TransformGroup3D(TransformGroup3D? transformGroup3D)
        {
            if (transformGroup3D != null)
            {
                transform3Ds = DiGi.Core.Query.Clone(transformGroup3D.transform3Ds)?.FilterNulls();
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of <see cref="ITransform3D"/> objects.
        /// </summary>
        /// <returns>An <see cref="IEnumerator{T}"/> for the <see cref="ITransform3D"/> collection.</returns>
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