using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the result of a 3D intersection operation.
    /// </summary>
    public class IntersectionResult3D : SerializableObject, IIntersectionResult3D
    {
        [JsonInclude, JsonPropertyName("Geometry3Ds")]
        private readonly List<IGeometry3D>? geometry3Ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class.
        /// </summary>
        public IntersectionResult3D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public IntersectionResult3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class using another <see cref="IntersectionResult3D"/> instance.
        /// </summary>
        /// <param name="intersectionResult3D">The <see cref="IntersectionResult3D"/> instance to copy from.</param>
        public IntersectionResult3D(IntersectionResult3D? intersectionResult3D)
            : this(intersectionResult3D?.geometry3Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class with the specified <see cref="IGeometry3D"/>.
        /// </summary>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> to initialize the result with. This value can be null.</param>
        public IntersectionResult3D(IGeometry3D? geometry3D)
        {
            if (geometry3D != null && geometry3D.Clone<IGeometry3D>() is IGeometry3D geometry3D_Temp)
            {
                geometry3Ds = [geometry3D_Temp];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult3D"/> class.
        /// </summary>
        /// <param name="geometry3Ds">An optional collection of <see cref="IGeometry3D"/> objects to be cloned and stored in the result.</param>
        public IntersectionResult3D(IEnumerable<IGeometry3D>? geometry3Ds)
        {
            if (geometry3Ds != null)
            {
                this.geometry3Ds = [];
                foreach (IGeometry3D geometry3D in geometry3Ds)
                {
                    if (geometry3D == null)
                    {
                        continue;
                    }

                    IGeometry3D? geometry3D_Temp = geometry3D.Clone<IGeometry3D>();
                    if (geometry3D_Temp == null)
                    {
                        continue;
                    }

                    this.geometry3Ds.Add(geometry3D_Temp);
                }
            }
        }

        /// <summary>
        /// Gets a value of type bool indicating whether there are any 3D geometries present.
        /// </summary>
        [JsonIgnore]
        public bool Intersect
        {
            get
            {
                return geometry3Ds != null && geometry3Ds.Count != 0;
            }
        }

        /// <summary>
        /// Gets the total number of <see cref="IGeometry3D"/> elements contained in the collection.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return geometry3Ds == null ? 0 : geometry3Ds.Count;
            }
        }

        [JsonIgnore]
        public IGeometry3D? this[int index]
        {
            get
            {
                if (geometry3Ds == null || geometry3Ds.Count <= index)
                {
                    return null;
                }

                return geometry3Ds[index].Clone<IGeometry3D>();
            }
        }

        /// <summary>
        /// Retrieves a list of 3D geometries of the specified type <typeparamref name="T"/>. Each matching geometry is cloned before being added to the result list.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve, which must implement the <see cref="IGeometry3D"/> interface.</typeparam>
        /// <returns>A <see cref="List{T}"/> containing clones of the geometries of type <typeparamref name="T"/>, or <see langword="null"/> if the internal geometry collection is null.</returns>
        public List<T>? GetGeometry3Ds<T>() where T : IGeometry3D
        {
            if (geometry3Ds == null)
            {
                return null;
            }

            List<T> result = [];
            for (int i = 0; i < geometry3Ds.Count; i++)
            {
                if (geometry3Ds[i] is T t)
                {
                    T? t_Temp = t.Clone<T>();
                    if (t_Temp is not null)
                    {
                        result.Add(t_Temp);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Determines whether the collection contains any object of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to search for, which must implement the <see cref="IGeometry3D"/> interface.</typeparam>
        /// <returns>A <see cref="bool"/> value indicating whether an object of type <typeparamref name="T"/> is present in the collection.</returns>
        public bool Contains<T>() where T : IGeometry3D
        {
            return geometry3Ds != null && geometry3Ds.Find(x => x is T) != null;
        }

        /// <summary>
        /// Creates a copy of the current <see cref="IntersectionResult3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new IntersectionResult3D(this);
        }
    }
}
