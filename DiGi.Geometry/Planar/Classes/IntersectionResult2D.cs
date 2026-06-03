using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class IntersectionResult2D : SerializableObject, IIntersectionResult
    {
        [JsonInclude, JsonPropertyName("Geometry2Ds")]
        private readonly List<IGeometry2D>? geometry2Ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class.
        /// </summary>
        public IntersectionResult2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing intersection result data.</param>
        public IntersectionResult2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class by cloning an existing intersection result.
        /// </summary>
        /// <param name="intersectionResult2D">The source intersection result to clone.</param>
        public IntersectionResult2D(IntersectionResult2D? intersectionResult2D)
            : this(intersectionResult2D?.geometry2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class containing a single geometry.
        /// </summary>
        /// <param name="geometry2D">The geometry resulting from the intersection.</param>
        internal IntersectionResult2D(IGeometry2D? geometry2D)
        {
            if (geometry2D != null && geometry2D.Clone<IGeometry2D>() is IGeometry2D geometry2D_Temp)
            {
                geometry2Ds = [geometry2D_Temp];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResult2D"/> class containing multiple geometries.
        /// </summary>
        /// <param name="geometry2Ds">The collection of geometries resulting from the intersection.</param>
        internal IntersectionResult2D(IEnumerable<IGeometry2D>? geometry2Ds)
        {
            if (geometry2Ds != null)
            {
                this.geometry2Ds = [];
                foreach (IGeometry2D geometry2D in geometry2Ds)
                {
                    IGeometry2D? geometry2D_Temp = geometry2D?.Clone<IGeometry2D>();
                    if (geometry2D_Temp == null)
                    {
                        continue;
                    }

                    this.geometry2Ds.Add(geometry2D_Temp);
                }
            }
        }

        /// <summary>
        /// Gets the number of geometries in the intersection result.
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
        /// Gets a value indicating whether an intersection occurred.
        /// </summary>
        [JsonIgnore]
        public bool Intersect
        {
            get
            {
                return geometry2Ds != null && geometry2Ds.Count != 0;
            }
        }

        /// <summary>
        /// Gets the geometry at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the geometry to get.</param>
        /// <returns>The geometry at the specified index, or null if it is out of range.</returns>
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
        /// Creates a clone of the current intersection result.
        /// </summary>
        /// <returns>A cloned instance of the intersection result.</returns>
        public override ISerializableObject? Clone()
        {
            return new IntersectionResult2D(this);
        }

        /// <summary>
        /// Checks if the intersection result contains at least one geometry of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of geometry to look for.</typeparam>
        /// <returns>True if a geometry of the specified type is found; otherwise, false.</returns>
        public bool Contains<T>() where T : IGeometry2D
        {
            return geometry2Ds != null && geometry2Ds.Find(x => x is T) != null;
        }

        /// <summary>
        /// Retrieves all geometries of the specified type from the intersection result.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve.</typeparam>
        /// <returns>A list of geometries of the specified type, or null if none are found.</returns>
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
                    if (t_Temp is null)
                    {
                        continue;
                    }

                    result.Add(t_Temp);
                }
            }

            return result;
        }
    }
}