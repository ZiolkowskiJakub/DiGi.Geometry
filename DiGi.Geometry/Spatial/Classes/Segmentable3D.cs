using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class Segmentable3D : Geometry3D, ISegmentable3D
    {
        [JsonInclude, JsonPropertyName("Points")]
        protected List<Point3D> points = [];

        public Segmentable3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Segmentable3D()
        {
        }

        public Segmentable3D(Segmentable3D? segmentable3D)
            : base(segmentable3D)
        {
            points = segmentable3D?.points.Clone()?.FilterNulls() ?? [];
        }

        public Segmentable3D(IEnumerable<Point3D>? point3Ds)
        {
            points = point3Ds?.Clone()?.FilterNulls() ?? [];
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                List<Segment3D>? segment3Ds = GetSegments();
                if (segment3Ds == null)
                {
                    return double.NaN;
                }

                double result = 0;
                for (int i = 0; i < segment3Ds.Count; i++)
                {
                    Segment3D segment3D = segment3Ds[i];
                    if (segment3D is null)
                    {
                        continue;
                    }

                    result += segment3D.Length;
                }

                return result;
            }
        }

        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D is null || points is null || points.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < points.Count; i++)
            {
                points[i].Move(vector3D);
            }

            return true;
        }

        public abstract List<Segment3D>? GetSegments();

        public List<Point3D>? GetPoints()
        {
            return points?.Clone()?.FilterNulls();
        }

        public double Distance(Point3D? point)
        {
            if (point == null || points == null || points.Count == 0)
            {
                return double.NaN;
            }

            Query.ClosestPoint(point, GetSegments(), out double result);

            return result;
        }

        public Point3D? ClosestPoint(Point3D? point)
        {
            if (point == null || points == null || points.Count == 0)
            {
                return null;
            }

            return Query.ClosestPoint(point, GetSegments());
        }

        public bool On(Point3D? point, double tolerance = 1E-06)
        {
            return Query.On(this, point, tolerance);
        }

        public BoundingBox3D? GetBoundingBox()
        {
            if (points == null || points.Count == 0)
            {
                return null;
            }

            return new BoundingBox3D(points);
        }

        public bool Inverse()
        {
            if (points is null)
            {
                return false;
            }

            points.Reverse();
            return true;
        }
    }
}