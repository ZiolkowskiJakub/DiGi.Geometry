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
    public class DensityBasedSpatialClusteringResult<T> : SerializableResult where T : IPoint<T>
    {
        [JsonInclude, JsonPropertyName("PointCount")]
        private readonly int pointCount;

        [JsonInclude, JsonPropertyName("Tolerance")]
        private readonly double tolerance;

        [JsonInclude, JsonPropertyName("Dictionary")]
        private Dictionary<T, int>? dictionary;

        public DensityBasedSpatialClusteringResult(double tolerance, int pointCount, Dictionary<T, int>? dictionary)
        {
            this.tolerance = tolerance;
            this.pointCount = pointCount;

            Dictionary = dictionary;
        }

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

        public DensityBasedSpatialClusteringResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

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

        public override ISerializableObject? Clone()
        {
            return new DensityBasedSpatialClusteringResult<T>(this);
        }

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
