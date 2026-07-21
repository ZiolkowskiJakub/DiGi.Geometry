using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the abstract base class for a 3D boolean operation result.
    /// </summary>
    public abstract class BooleanOperationResult3D : SerializableObject, IBooleanOperationResult3D
    {
        /// <summary>
        /// Gets the type of the boolean operation.
        /// </summary>
        public abstract BooleanOpertaionType BooleanOpertaionType { get; }

        [JsonInclude, JsonPropertyName("Geometry3Ds")]
        private readonly List<IGeometry3D>? geometry3Ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult3D"/> class.
        /// </summary>
        protected BooleanOperationResult3D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult3D"/> class using another instance.
        /// </summary>
        /// <param name="booleanOperationResult3D">The instance to copy from.</param>
        protected BooleanOperationResult3D(BooleanOperationResult3D? booleanOperationResult3D)
            : base(booleanOperationResult3D)
        {
            if (booleanOperationResult3D != null)
            {
                if (booleanOperationResult3D.geometry3Ds != null)
                {
                    geometry3Ds = [];
                    foreach (IGeometry3D geometry3D in booleanOperationResult3D.geometry3Ds)
                    {
                        if (geometry3D.Clone<IGeometry3D>() is IGeometry3D geometry3D_Temp)
                        {
                            geometry3Ds.Add(geometry3D_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        protected BooleanOperationResult3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult3D"/> class with the specified geometries.
        /// </summary>
        /// <param name="geometry3Ds">The geometries to store in the result.</param>
        protected BooleanOperationResult3D(IEnumerable<IGeometry3D>? geometry3Ds)
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
        /// Determines whether there are any 3D geometries present.
        /// </summary>
        /// <returns><c>true</c> if any geometries are present; otherwise, <c>false</c>.</returns>
        public bool Any()
        {
            return geometry3Ds != null && geometry3Ds.Count != 0;
        }

        /// <summary>
        /// Gets the total number of <see cref="IGeometry3D"/> elements.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return geometry3Ds == null ? 0 : geometry3Ds.Count;
            }
        }

        /// <summary>
        /// Gets the 3D geometry at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the geometry to retrieve.</param>
        /// <returns>A clone of the geometry at the specified index, or <see langword="null"/> if the index is out of range.</returns>
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
        /// Retrieves a list of 3D geometries of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve, which must implement the <see cref="IGeometry3D"/> interface.</typeparam>
        /// <returns>A list of matching geometries, or <see langword="null"/> if no geometries are present.</returns>
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
        /// <typeparam name="T">The type of geometry to search for.</typeparam>
        /// <returns><c>true</c> if an object of type <typeparamref name="T"/> is present; otherwise, <c>false</c>.</returns>
        public bool Contains<T>() where T : IGeometry3D
        {
            return geometry3Ds != null && geometry3Ds.Find(x => x is T) != null;
        }
    }
}