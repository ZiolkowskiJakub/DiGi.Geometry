using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Segmentable2D : Geometry2D, ISegmentable2D, IBoundable2D
    {
        [JsonInclude, JsonPropertyName("Points")]
        protected List<Point2D> points = new List<Point2D>();

        public Segmentable2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Segmentable2D()
        {

        }

        public Segmentable2D(Segmentable2D segmentable2D)
            : base(segmentable2D)
        {
            points = segmentable2D?.points.Clone();
        }

        public Segmentable2D(IEnumerable<Point2D> point2Ds)
        {
            points = point2Ds?.Clone();
        }

        public Point2D ClosestPoint(Point2D point2D)
        {
            if(point2D == null || points == null || points.Count == 0)
            {
                return null;
            }

            return Query.ClosestPoint(point2D, GetSegments());
        }

        public double Distance(Point2D point2D)
        {
            if (point2D == null || points == null || points.Count == 0)
            {
                return double.NaN;
            }

            return Query.Distance(point2D, GetSegments());
        }

        public List<Point2D> GetPoints()
        {
            return points?.Clone();
        }

        public abstract List<Segment2D> GetSegments();
        
        public void Move(Vector2D vector2D)
        {
            if(points == null || vector2D == null)
            {
                return;
            }

            for(int i=0; i < points.Count; i++)
            {
                points[i].Move(vector2D);
            }
        }

        public BoundingBox2D GetBoundingBox()
        {
            if(points == null || points.Count == 0)
            {
                return null;
            }

            return new BoundingBox2D(points);
        }

        public bool On(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Query.On(point2D, this, tolerance);
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                List<Segment2D> segment2Ds = GetSegments();
                if (segment2Ds == null)
                {
                    return double.NaN;
                }

                double result = 0;
                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    Segment2D segment2D = segment2Ds[i];
                    if (segment2D == null)
                    {
                        continue;
                    }

                    result += segment2D.Length;
                }

                return result;
            }

        }

        public void Inverse()
        {
            points?.Reverse();
        }
    }
}
