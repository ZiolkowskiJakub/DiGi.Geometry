using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents an abstract base class for results that are defined on a 2D plane.
    /// </summary>
    public abstract class PlanarResult : SerializableObject, ISerializableResult
    {
        [JsonInclude, JsonPropertyName("Geometry2Ds")]
        private readonly List<IGeometry2D>? geometry2Ds;

        [JsonInclude, JsonPropertyName("Plane")]
        private readonly Plane? plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarResult"/> class.
        /// </summary>
        public PlanarResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarResult"/> class using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to initialize the result with, or null.</param>
        public PlanarResult(Plane? plane)
            : base()
        {
            this.plane = plane == null ? null : new(plane);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarResult"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance. This value can be null.</param>
        public PlanarResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarResult"/> class by copying the data from an existing <see cref="PlanarResult"/> instance.
        /// </summary>
        /// <param name="planarResult">The source <see cref="PlanarResult"/> instance to copy.</param>
        public PlanarResult(PlanarResult? planarResult)
            : base()
        {
            if (planarResult != null)
            {
                geometry2Ds = DiGi.Core.Query.Clone(planarResult.geometry2Ds)?.FilterNulls();
                plane = planarResult.plane == null ? null : new Plane(planarResult.plane);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarResult"/> class.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to associate with this result, or null.</param>
        /// <param name="geometry2Ds">A collection of <see cref="IGeometry2D"/> objects to associate with this result, or null.</param>
        public PlanarResult(Plane? plane, IEnumerable<IGeometry2D>? geometry2Ds)
        {
            this.plane = plane == null ? null : new Plane(plane);
            this.geometry2Ds = DiGi.Core.Query.Clone(geometry2Ds)?.FilterNulls();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarResult"/> class.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to associate with this result, or null.</param>
        /// <param name="geometry2D">The <see cref="IGeometry2D"/> geometry to include in the result, or null.</param>
        public PlanarResult(Plane? plane, IGeometry2D? geometry2D)
        {
            this.plane = plane == null ? null : new(plane);
            if (geometry2D != null && DiGi.Core.Query.Clone(geometry2D) is IGeometry2D geometry2D_Temp)
            {
                geometry2Ds = [geometry2D_Temp];
            }
        }

        /// <summary>
        /// Gets the number of geometry elements contained in this object.
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
        /// Gets the associated <see cref="Plane"/> instance.
        /// </summary>
        /// <value>
        /// The <see cref="Plane"/> object, or <c>null</c> if no plane is defined.
        /// </value>
        [JsonIgnore]
        public Plane? Plane
        {
            get
            {
                return plane == null ? null : new Plane(plane);
            }
        }

        /// <summary>
        /// Determines whether the collection contains any geometry objects of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to search for, which must implement the <see cref="IGeometry2D"/> interface.</typeparam>
        /// <returns>A <see cref="bool"/> value indicating whether an object of type <typeparamref name="T"/> is present in the collection.</returns>
        public bool Contains<T>() where T : IGeometry2D
        {
            return geometry2Ds != null && geometry2Ds.Find(x => x is T) != null;
        }

        /// <summary>
        /// Retrieves a list of cloned 2D geometry objects of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve, which must implement IGeometry2D.</typeparam>
        /// <returns>A <c>List&lt;T&gt;</c> containing clones of the 2D geometry objects if the collection is not null; otherwise, null.</returns>
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
                    T? t_Temp = DiGi.Core.Query.Clone(t);
                    if (t_Temp == null)
                    {
                        continue;
                    }

                    result.Add(t_Temp);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of 3D geometry objects of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of 3D geometry to retrieve, which must implement the <see cref="IGeometry3D"/> interface.</typeparam>
        /// <returns>A <see cref="List{T}"/> containing the converted 3D geometries, or <see langword="null"/> if no source 2D geometries are available.</returns>
        public List<T>? GetGeometry3Ds<T>() where T : IGeometry3D
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<T> result = [];
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                if (Query.Convert(plane, geometry2Ds[i] as dynamic) is not IGeometry3D geometry3D)
                {
                    continue;
                }

                if (Query.Convert<T>(geometry3D) is not List<T> ts)
                {
                    continue;
                }

                result.AddRange(ts);
            }

            return result;
        }
    }
}