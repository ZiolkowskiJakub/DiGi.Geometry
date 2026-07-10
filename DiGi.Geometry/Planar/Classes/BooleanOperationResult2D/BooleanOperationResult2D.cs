using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents the abstract base class for a 2D boolean operation result.
    /// </summary>
    public abstract class BooleanOperationResult2D : SerializableObject, IBooleanOperationResult2D
    {
        /// <summary>
        /// Gets the type of the boolean operation.
        /// </summary>
        public abstract BooleanOpertaionType BooleanOpertaionType { get; }

        [JsonInclude, JsonPropertyName("Geometry2Ds")]
        private readonly List<IGeometry2D>? geometry2Ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult2D"/> class.
        /// </summary>
        protected BooleanOperationResult2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult2D"/> class using another instance.
        /// </summary>
        /// <param name="booleanOperationResult2D">The instance to copy from.</param>
        protected BooleanOperationResult2D(BooleanOperationResult2D? booleanOperationResult2D)
            : base(booleanOperationResult2D)
        {
            if (booleanOperationResult2D != null)
            {
                if (booleanOperationResult2D.geometry2Ds != null)
                {
                    geometry2Ds = [];
                    foreach (IGeometry2D geometry2D in booleanOperationResult2D.geometry2Ds)
                    {
                        if (geometry2D.Clone<IGeometry2D>() is IGeometry2D geometry2D_Temp)
                        {
                            geometry2Ds.Add(geometry2D_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult2D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        protected BooleanOperationResult2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult2D"/> class with the specified geometries.
        /// </summary>
        /// <param name="geometry2Ds">The geometries to store in the result.</param>
        protected BooleanOperationResult2D(IEnumerable<IGeometry2D>? geometry2Ds)
        {
            if (geometry2Ds != null)
            {
                this.geometry2Ds = [];
                foreach (IGeometry2D geometry2D in geometry2Ds)
                {
                    if (geometry2D == null)
                    {
                        continue;
                    }

                    IGeometry2D? geometry2D_Temp = geometry2D.Clone<IGeometry2D>();
                    if (geometry2D_Temp == null)
                    {
                        continue;
                    }

                    this.geometry2Ds.Add(geometry2D_Temp);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanOperationResult2D"/> class from a prebuilt list of geometries.
        /// </summary>
        /// <param name="geometry2Ds">The list of geometries to store in the result.</param>
        /// <param name="clone">When <see langword="true"/>, each geometry is cloned defensively; when <see langword="false"/>, the supplied list is adopted directly without cloning. Use <see langword="false"/> only when the caller owns freshly created geometries that are not shared.</param>
        protected BooleanOperationResult2D(List<IGeometry2D>? geometry2Ds, bool clone)
        {
            if (geometry2Ds == null)
            {
                return;
            }

            if (!clone)
            {
                this.geometry2Ds = geometry2Ds;
                return;
            }

            this.geometry2Ds = [];
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                IGeometry2D? geometry2D_Temp = geometry2Ds[i]?.Clone<IGeometry2D>();
                if (geometry2D_Temp == null)
                {
                    continue;
                }

                this.geometry2Ds.Add(geometry2D_Temp);
            }
        }

        /// <summary>
        /// Determines whether there are any 2D geometries present.
        /// </summary>
        /// <returns><c>true</c> if any geometries are present; otherwise, <c>false</c>.</returns>
        public bool Any()
        {
            return geometry2Ds != null && geometry2Ds.Count != 0;
        }

        /// <summary>
        /// Gets the total number of <see cref="IGeometry2D"/> elements.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return geometry2Ds == null ? 0 : geometry2Ds.Count;
            }
        }

        /// <summary>
        /// Gets the 2D geometry at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the geometry to retrieve.</param>
        /// <returns>A clone of the geometry at the specified index, or <see langword="null"/> if the index is out of range.</returns>
        [JsonIgnore]
        public IGeometry2D? this[int index]
        {
            get
            {
                if (geometry2Ds == null || geometry2Ds.Count <= index)
                {
                    return null;
                }

                return geometry2Ds[index].Clone<IGeometry2D>();
            }
        }

        /// <summary>
        /// Retrieves a list of 2D geometries of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve, which must implement the <see cref="IGeometry2D"/> interface.</typeparam>
        /// <returns>A list of matching geometries, or <see langword="null"/> if no geometries are present.</returns>
        public List<T>? GetGeometry2Ds<T>() where T : IGeometry2D
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<T> result = [];
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                if (geometry2Ds[i] is T t)
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
        public bool Contains<T>() where T : IGeometry2D
        {
            return geometry2Ds != null && geometry2Ds.Find(x => x is T) != null;
        }
    }
}
