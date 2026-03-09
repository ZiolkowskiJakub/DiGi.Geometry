using DiGi.Core.Classes;
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
        [JsonInclude, JsonPropertyName("Max")]
        private Point2D? max;

        [JsonInclude, JsonPropertyName("Min")]
        private Point2D? min;

        public BoundingBox2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public BoundingBox2D(IEnumerable<Point2D>? point2Ds)
        {
            min = Query.Min(point2Ds, out max);
        }

        public BoundingBox2D(IEnumerable<Point2D>? point2Ds, double offset)
        {
            min = Query.Min(point2Ds, out max);

            Offset(offset);
        }

        public BoundingBox2D(Point2D? point2D_1, Point2D? point2D_2)
        {
            min = Query.Min([point2D_1, point2D_2], out max);
        }

        public BoundingBox2D(BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D != null)
            {
                min = new Point2D(boundingBox2D.min);
                max = new Point2D(boundingBox2D.max);
            }
        }

        public BoundingBox2D(Range<double>? x, Range<double>? y)
        {
            if (x != null && y != null)
            {
                min = new Point2D(x.Min, y.Min);
                max = new Point2D(x.Max, y.Max);
            }
        }

        public BoundingBox2D(double x, double y, double width, double height)
            : this(new Point2D(x, y), new Point2D(x + width, y + height))
        {
        }

        [JsonIgnore]
        public Point2D? BottomLeft
        {
            get
            {
                if (min == null)
                {
                    return null;
                }

                return new Point2D(min);
            }
        }

        [JsonIgnore]
        public Point2D? BottomRight
        {
            get
            {
                if (max == null || min == null)
                {
                    return null;
                }

                return new Point2D(max.X, min.Y);
            }
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
        public Point2D? TopLeft
        {
            get
            {
                if (max == null || min == null)
                {
                    return null;
                }

                return new Point2D(min.X, max.Y);
            }
        }

        [JsonIgnore]
        public Point2D? TopRight
        {
            get
            {
                if (max == null)
                {
                    return null;
                }

                return new Point2D(max);
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

        public bool Add(BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return false;
            }

            max = Query.Max(max, boundingBox2D.Max);
            min = Query.Min(min, boundingBox2D.Min);
            return true;
        }

        public bool Add(Point2D? point2D)
        {
            if (point2D == null)
            {
                return false;
            }

            max = Query.Max(max, point2D);
            min = Query.Min(min, point2D);
            return true;
        }

        public override ISerializableObject? Clone()
        {
            return new BoundingBox2D(this);
        }

        public Point2D? ClosestPoint(Point2D? point2D)
        {
            return Query.ClosestPoint(point2D, GetSegments());
        }

        public double Distance(Point2D? point2D)
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

        public Point2D? GetCentroid()
        {
            return min?.Mid(max);
        }

        public Segment2D[]? GetDiagonals()
        {
            List<Point2D>? points = GetPoints();
            if (points == null)
            {
                return null;
            }

            return [new Segment2D(points[0], points[2]), new Segment2D(points[1], points[3])];
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

        public Point2D? GetPoint(Corner corner)
        {
            if (corner == Corner.Undefined)
            {
                return null;
            }

            switch (corner)
            {
                case Corner.BottomLeft:
                    return BottomLeft;

                case Corner.BottomRight:
                    return BottomRight;

                case Corner.TopLeft:
                    return TopLeft;

                case Corner.TopRight:
                    return TopRight;

                case Corner.Undefined:
                    break;

                default:
                    break;
            }

            return null;
        }

        public List<Point2D>? GetPoints()
        {
            Point2D? bottomRight = BottomRight;
            if (bottomRight is null)
            {
                return null;
            }

            if (BottomLeft is not Point2D bottomLeft || TopLeft is not Point2D topLeft || TopRight is not Point2D topRight)
            {
                return null;
            }

            return [bottomLeft, topLeft, topRight, bottomRight];
        }

        public List<Segment2D>? GetSegments()
        {
            List<Point2D>? points = GetPoints();
            if (points == null)
            {
                return null;
            }

            return [new(points[0], points[1]), new Segment2D(points[1], points[2]), new Segment2D(points[2], points[3]), new Segment2D(points[3], points[0])];
        }

        /// <summary>
        /// boundingBox2D not outside this BoundingBox2D
        /// </summary>
        /// <param name="boundingBox2D">Point2D</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>True if boundingBox2D On or Inside this BoundingBox2D</returns>
        public bool InRange(BoundingBox2D? boundingBox2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

        public bool InRange(Line2D? line2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null || line2D is null)
            {
                return false;
            }

            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < point2Ds.Count; i++)
            {
                Point2D? point2D = line2D.Project(point2Ds[i]);
                if (point2D == null)
                {
                    continue;
                }

                if (InRange(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public bool InRange(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min is null || max is null)
            {
                return false;
            }

            if (segment2D?[0] is not Point2D point2D_Start)
            {
                return false;
            }

            if (segment2D[1] is not Point2D point2D_End)
            {
                return false;
            }

            Vector2D vector2D = new(point2D_Start, point2D_End); // use actual delta vector, not normalized direction

            double minX = min.X - tolerance;
            double minY = min.Y - tolerance;
            double maxX = max.X + tolerance;
            double maxY = max.Y + tolerance;

            double t0 = 0.0;
            double t1 = 1.0;

            // For each axis (X and Y)
            for (int i = 0; i < 2; i++)
            {
                double p = (i == 0) ? vector2D.X : vector2D.Y;
                double minB = (i == 0) ? minX : minY;
                double maxB = (i == 0) ? maxX : maxY;
                double p0Val = (i == 0) ? point2D_Start.X : point2D_Start.Y;

                if (System.Math.Abs(p) < tolerance)
                {
                    // Line is parallel to the axis — outside if completely beyond bounds
                    if (p0Val < minB || p0Val > maxB)
                    {
                        return false;
                    }
                }
                else
                {
                    double tEnter = (minB - p0Val) / p;
                    double tExit = (maxB - p0Val) / p;
                    if (tEnter > tExit)
                    {
                        (tExit, tEnter) = (tEnter, tExit);
                    }

                    t0 = System.Math.Max(t0, tEnter);
                    t1 = System.Math.Min(t1, tExit);

                    if (t0 > t1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            List<Segment2D>? segment2Ds = null;

            segment2Ds = segmentable2D?.GetSegments();
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

            if(segmentable2D is IClosedCurve2D closedCurve2D)
            {
                List<Point2D>? point2Ds = GetPoints();
                if (point2Ds == null || point2Ds.Count == 0)
                {
                    return false;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    if (closedCurve2D.InRange(point2Ds[i], tolerance))
                    {
                        return true;
                    }
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
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return false;
            }

            return Inside(point2D, tolerance) || On(point2D, tolerance);
        }

        public bool InRange_Old(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null || segment2D is null)
            {
                return false;
            }

            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < point2Ds.Count; i++)
            {
                if (segment2D.ClosestPoint(point2Ds[i]) is not Point2D point2D)
                {
                    continue;
                }

                if (InRange(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || min == null || max == null)
            {
                return false;
            }

            return point2D.X > min.X + tolerance && point2D.X < max.X - tolerance && point2D.Y < max.Y - tolerance && point2D.Y > min.Y + tolerance;
        }

        public bool Inside(IEnumerable<Point2D>? point2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null)
            {
                return false;
            }

            foreach (Point2D point2D in point2Ds)
            {
                if (!Inside(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            return Inside(segmentable2D?.GetPoints(), tolerance);
        }

        public bool Inside(BoundingBox2D? boundingBox2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            return Inside(boundingBox2D?.GetPoints(), tolerance);
        }

        public override bool Move(Vector2D? vector2D)
        {
            if (vector2D is null || max == null || min == null)
            {
                return false;
            }

            max.Move(vector2D);
            min.Move(vector2D);
            return true;
        }

        public void Offset(double value)
        {
            if (double.IsNaN(value) || min == null || max == null)
            {
                return;
            }

            min = new Point2D(min.X - value, min.Y - value);
            max = new Point2D(max.X + value, max.Y + value);
        }

        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Query.On(GetSegments(), point2D, tolerance);
        }

        public override bool Transform(ITransform2D? transform)
        {
            if (transform == null || min == null || max == null)
            {
                return false;
            }

            min.Transform(transform);
            max.Transform(transform);
            return true;
        }
    }
}