using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Represents the result of a density-based spatial clustering operation.
    /// </summary>
    /// <typeparam name="T">The type of point, which must implement <see cref="IPoint{T}"/>.</typeparam>
    public class DensityBasedSpatialClusteringResult<T> : SerializableResult where T : IPoint<T>
    {
        [JsonInclude, JsonPropertyName("PointCount")]
        private readonly int pointCount;

        [JsonInclude, JsonPropertyName("Tolerance")]
        private readonly double tolerance;

        [JsonInclude, JsonPropertyName("Dictionary")]
        private Dictionary<T, int>? dictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="DensityBasedSpatialClusteringResult{T}"/> class.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for spatial clustering.</param>
        /// <param name="pointCount">The <see cref="int"/> number of points processed in the clustering operation.</param>
        /// <param name="dictionary">An optional <c>Dictionary&lt;T, int&gt;</c>/> containing the mapping of elements to their respective cluster indices.</param>
        public DensityBasedSpatialClusteringResult(double tolerance, int pointCount, Dictionary<T, int>? dictionary)
        {
            this.tolerance = tolerance;
            this.pointCount = pointCount;

            Dictionary = dictionary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DensityBasedSpatialClusteringResult{T}"/> class using the specified <see cref="DensityBasedSpatialClusteringResult{T}"/> result.
        /// </summary>
        /// <param name="densityBasedSpatialClusteringResult">The <see cref="DensityBasedSpatialClusteringResult{T}"/> object containing the clustering data to be copied.</param>
        public DensityBasedSpatialClusteringResult(DensityBasedSpatialClusteringResult<T> densityBasedSpatialClusteringResult)
            : base(densityBasedSpatialClusteringResult)
        {
            if (densityBasedSpatialClusteringResult != null)
            {
                tolerance = densityBasedSpatialClusteringResult.tolerance;
                pointCount = densityBasedSpatialClusteringResult.pointCount;

                Dictionary = densityBasedSpatialClusteringResult.dictionary;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DensityBasedSpatialClusteringResult{T}"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the clustering result.</param>
        public DensityBasedSpatialClusteringResult(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets a <c>Dictionary&lt;T, int&gt;</c>/> containing mappings from keys of type <typeparamref name="T"/> to values of type <see cref="int"/>.
        /// </summary>
        /// <value>
        /// A <c>Dictionary&lt;T, int&gt;</c>/> where each key is a clone of the original key, or null if the underlying dictionary is null.
        /// </value>
        [JsonIgnore]
        public Dictionary<T, int>? Dictionary
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                Dictionary<T, int> result = [];
                foreach (KeyValuePair<T, int> keyValuePair in dictionary)
                {
                    if (keyValuePair.Key.Clone<T>() is T t)
                    {
                        result[t] = keyValuePair.Value;
                    }
                }

                return result;
            }

            private set
            {
                if (value == null)
                {
                    dictionary = null;
                    return;
                }

                dictionary = [];
                foreach (KeyValuePair<T, int> keyValuePair in value)
                {
                    if (keyValuePair.Key.Clone<T>() is T t)
                    {
                        dictionary[t] = keyValuePair.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Creates a clone of the current object.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> that is a copy of the current instance, or <c>null</c>.</returns>
        public override ISerializableObject? Clone()
        {
            return new DensityBasedSpatialClusteringResult<T>(this);
        }

        /// <summary>
        /// Retrieves a set of all indexes stored in the dictionary.
        /// </summary>
        /// <returns>A <see cref="HashSet{T}"/> of <see cref="int"/> containing the indexes, or <see langword="null"/> if the internal dictionary is null.</returns>
        public HashSet<int>? GetIndexes()
        {
            if (dictionary == null)
            {
                return null;
            }

            HashSet<int> result = [];
            foreach (int index in dictionary.Values)
            {
                result.Add(index);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a single point at the specified index. If multiple points are available,
        /// they can be processed by the provided function; otherwise, the first point is returned.
        /// </summary>
        /// <param name="index">The index of the point to retrieve.</param>
        /// <param name="func">An optional <c>Func&lt;IEnumerable&lt;T&gt;, T&gt;</c> used to select a single <typeparamref name="T"/> from the collection of points.</param>
        /// <returns>A cloned instance of <typeparamref name="T"/> if a point is found; otherwise, the default value of <typeparamref name="T"/>.</returns>
        public T? GetPoint(int index, Func<IEnumerable<T>, T>? func = null)
        {
            List<T>? points = GetPoints(index);
            if (points == null || points.Count == 0)
            {
                return default;
            }

            T point = func == null ? points[0] : func.Invoke(points);
            if (point == null)
            {
                return default;
            }

            return point.Clone<T>();
        }

        /// <summary>
        /// Retrieves a list of points associated with the specified index.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index to search for.</param>
        /// <returns>A <see cref="List{T}"/> containing the points that match the provided index, or <see langword="null"/> if the dictionary is null.</returns>
        public List<T>? GetPoints(int index)
        {
            if (dictionary == null)
            {
                return null;
            }

            List<T> result = [];
            foreach (KeyValuePair<T, int> keyValuePair in dictionary)
            {
                if (keyValuePair.Value == index)
                {
                    result.Add(keyValuePair.Key);
                }
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified index exists within the dictionary values.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index to locate.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the specified <see cref="int"/> index was found; otherwise, <see langword="false"/>.</returns>
        public bool HasIndex(int index)
        {
            if (dictionary == null)
            {
                return false;
            }

            foreach (int index_Temp in dictionary.Values)
            {
                if (index == index_Temp)
                {
                    return true;
                }
            }

            return false;
        }
    }
}