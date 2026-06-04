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
    /// <summary>
    /// Represents a group of 2D transformations that can be treated as a single <see cref="ITransform2D"/> or iterated over as a collection of <see cref="ITransform2D"/> objects.
    /// </summary>
    public class TransformGroup2D : SerializableObject, ITransform2D, IEnumerable<ITransform2D>
    {
        [JsonInclude, JsonPropertyName("Transform2Ds")]
        private readonly List<ITransform2D>? transform2Ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformGroup2D"/> class using the specified collection of <see cref="ITransform2D"/> transforms.
        /// </summary>
        /// <param name="transform2Ds">An <see cref="IEnumerable{ITransform2D}"/> containing the transforms to be added to the group. This value can be null.</param>
        public TransformGroup2D(IEnumerable<ITransform2D>? transform2Ds)
        {
            this.transform2Ds = DiGi.Core.Query.Clone(transform2Ds)?.FilterNulls();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformGroup2D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public TransformGroup2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformGroup2D"/> class by cloning an existing <see cref="TransformGroup2D"/> instance.
        /// </summary>
        /// <param name="transformGroup2D">The <see cref="TransformGroup2D"/> instance to clone from, or null to initialize an empty group.</param>
        public TransformGroup2D(TransformGroup2D? transformGroup2D)
        {
            if (transformGroup2D != null)
            {
                transform2Ds = DiGi.Core.Query.Clone(transformGroup2D.transform2Ds)?.FilterNulls();
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of <see cref="ITransform2D"/> objects.
        /// </summary>
        /// <returns>An <see cref="IEnumerator{T}"/> for the <see cref="ITransform2D"/> collection.</returns>
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