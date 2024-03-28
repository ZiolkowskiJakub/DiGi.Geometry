using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class BoundingBox2D : Geometry2D, IBoundingBox<Point2D>
    {
        [JsonInclude, JsonPropertyName("Min")]
        private Point2D min;

        [JsonInclude, JsonPropertyName("Max")]
        private Point2D max;

        public BoundingBox2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BoundingBox2D(IEnumerable<Point2D> point2Ds)
        {
            min = Query.Min(point2Ds, out max);
        }

        public BoundingBox2D(IEnumerable<Point2D> point2Ds, double offset)
        {
            min = Query.Min(point2Ds, out max);

            Offset(offset);
        }

        public BoundingBox2D(Point2D point2D_1, Point2D point2D_2)
        {
            min = Query.Min(new Point2D[] { point2D_1, point2D_2 }, out max);
        }

        public BoundingBox2D(BoundingBox2D boundingBox2D)
        {
            if(boundingBox2D != null)
            {
                min = new Point2D(boundingBox2D.min);
                max = new Point2D(boundingBox2D.max);
            }

        }

        public BoundingBox2D(double x, double y, double width, double height)
            : this(new Point2D(x, y), new Point2D(x + width, y + height))
        {

        }

        [JsonIgnore]
        public double Height
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.Y - min.Y;
            }
        }

        [JsonIgnore]
        public Point2D Max
        {
            get
            {
                return new Point2D(max);
            }
            set
            {
                if (min == null)
                {
                    max = new Point2D(value);
                    min = new Point2D(value);
                }
                else
                {
                    max = Query.Max(min, value);
                    min = Query.Min(min, value);
                }
            }
        }

        [JsonIgnore]
        public Point2D Min
        {
            get
            {
                return new Point2D(min);
            }
            set
            {
                if (max == null)
                {
                    max = new Point2D(value);
                    min = new Point2D(value);
                }
                else
                {
                    max = Query.Max(max, value);
                    min = Query.Min(max, value);
                }
            }
        }

        [JsonIgnore]
        public double Width
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.X - min.X;
            }
        }

        public bool Add(BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
                return false;

            max = Query.Max(max, boundingBox2D.Max);
            min = Query.Min(min, boundingBox2D.Min);
            return true;
        }

        public bool Add(Point2D point2D)
        {
            if (point2D == null)
            {
                return false;
            }

            max = Query.Max(max, point2D);
            min = Query.Min(min, point2D);
            return true;
        }

        public override ISerializableObject Clone()
        {
            return new BoundingBox2D(this);
        }

        public Point2D ClosestPoint(Point2D point2D)
        {
            return Query.ClosestPoint(point2D, GetSegments());
        }

        public double Distance(Point2D point2D)
        {
            return Query.Distance(point2D, GetSegments());
        }

        public double GetArea()
        {
            double width = Width;
            if (double.IsNaN(width))
            {
                return double.NaN;
            }

            double height = Height;
            if (double.IsNaN(height))
            {
                return double.NaN;
            }

            return width * height;
        }

        public Point2D GetCentroid()
        {
            return min?.Mid(max);
        }

        public double GetLength()
        {
            double width = Width;
            if (double.IsNaN(width))
            {
                return double.NaN;
            }

            double height = Height;
            if (double.IsNaN(height))
            {
                return double.NaN;
            }

            return 2 * (width + height);
        }

        public List<Point2D> GetPoints()
        {
            double height = Height;
            if (double.IsNaN(height))
            {
                return null;
            }

            return new List<Point2D>() { new Point2D(min), new Point2D(min.X, min.Y + height), new Point2D(max), new Point2D(max.X, max.Y - height) };
        }

        public Point2D GetPoint(Corner corner)
        {
            if (corner == Corner.Undefined)
            {
                return null;
            }

            switch (corner)
            {
                case Corner.BottomLeft:
                    return new Point2D(min);

                case Corner.BottomRight:
                    return new Point2D(max.X, max.Y - Height);

                case Corner.TopLeft:
                    return new Point2D(min.X, min.Y + Height);

                case Corner.TopRight:
                    return new Point2D(max);
            }

            return null;
        }

        public List<Segment2D> GetSegments()
        {
            List<Point2D> points = GetPoints();

            return new List<Segment2D>() { new Segment2D(points[0], points[1]), new Segment2D(points[1], points[2]), new Segment2D(points[2], points[3]), new Segment2D(points[3], points[0]) };
        }

        /// <summary>
        /// boundingBox2D not outside this BoundingBox2D
        /// </summary>
        /// <param name="boundingBox2D">Point2D</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>True if boundingBox2D On or Inside this BoundingBox2D</returns>
        public bool InRange(BoundingBox2D boundingBox2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (boundingBox2D == null)
            {
                return false;
            }

            double max_1;
            double min_1;

            double max_2;
            double min_2;

            max_1 = Max.X + tolerance;
            min_1 = Min.X - tolerance;

            max_2 = boundingBox2D.Max.X;
            min_2 = boundingBox2D.Min.X;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            max_1 = Max.Y + tolerance;
            min_1 = Min.Y - tolerance;

            max_2 = boundingBox2D.Max.Y;
            min_2 = boundingBox2D.Min.Y;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            return true;
        }

        public bool InRange(Segment2D segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (min == null || max == null || segment2D == null)
            {
                return false;
            }

            if (InRange(segment2D[0], tolerance) || InRange(segment2D[1], tolerance))
            {
                return true;
            }

            List<Segment2D> segment2Ds = GetSegments();
            if(segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < segment2Ds.Count; i++)
            {
                Point2D point2D = segment2Ds[i].IntersectionPoint(segment2D, tolerance);
                if(point2D != null)
                {
                    return true;
                }
            }

            return false;
        }

        public bool InRange(ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < segment2Ds.Count; i++)
            {
                if (InRange(segment2Ds[i], tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Point2D On or Inside BoundingBox2D
        /// </summary>
        /// <param name="point2D">Point2D</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>True if point2D On or Inside BoundingBox 2D</returns>
        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null)
                return false;

            return Inside(point2D, tolerance) || On(point2D, tolerance);
        }

        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null)
                return false;

            return point2D.X > min.X + tolerance && point2D.X < max.X - tolerance && point2D.Y < max.Y - tolerance && point2D.Y > min.Y + tolerance;
        }

        public bool Inside(ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(min == null || max == null)
            {
                return false;
            }

            List<Point2D> point2Ds = segmentable2D?.GetPoints();
            if(point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            for(int i =0; i < point2Ds.Count; i++)
            {
                if (!Inside(point2Ds[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Move(Vector2D vector2D)
        {
            if(vector2D == null || max == null || min == null)
            {
                return false;
            }

            max.Move(vector2D);
            min.Move(vector2D);
            return true;
        }

        public void Offset(double value)
        {
            if(double.IsNaN(value) || min == null || max == null)
            {
                return;
            }

            min = new Point2D(min.X - value, min.Y - value);
            max = new Point2D(max.X + value, max.Y + value);
        }

        public bool On(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Query.On(GetSegments(), point2D,tolerance);
        }

        public override bool Transform(ITransform2D transform)
        {
            if(transform == null || min == null || max == null)
            {
                return false;
            }

            min.Transform(transform);
            max.Transform(transform); 
            return true;
        }

        public Segment2D[] GetDiagonals()
        {
            List<Point2D> points = GetPoints();

            return new Segment2D[] { new Segment2D(points[0], points[2]), new Segment2D(points[1], points[3]) };
        }
    }
}
