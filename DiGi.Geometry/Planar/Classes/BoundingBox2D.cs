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
    /// <summary>
    /// Represents an axis-aligned bounding box in 2D space.
    /// </summary>
    public class BoundingBox2D : Geometry2D, IBoundingBox<Point2D>
    {
        [JsonInclude, JsonPropertyName("Max")]
        private Point2D? max;

        [JsonInclude, JsonPropertyName("Min")]
        private Point2D? min;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing bounding box data.</param>
        public BoundingBox2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class that encompasses all given points.
        /// </summary>
        /// <param name="point2Ds">The collection of points to encompass.</param>
        public BoundingBox2D(IEnumerable<Point2D>? point2Ds)
        {
            min = Query.Min(point2Ds, out max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class that encompasses all given bounding boxes.
        /// </summary>
        /// <param name="boundingBox2Ds">The collection of bounding boxes to encompass.</param>
        public BoundingBox2D(IEnumerable<BoundingBox2D?>? boundingBox2Ds)
        {
            if (boundingBox2Ds is not null)
            {
                foreach (BoundingBox2D? boundingBox2D in boundingBox2Ds)
                {
                    if (boundingBox2D is null)
                    {
                        continue;
                    }

                    max = max is null ? boundingBox2D.Max : Query.Max(max, boundingBox2D.Max);
                    min = min is null ? boundingBox2D.Min : Query.Min(min, boundingBox2D.Min);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class that encompasses all given points with an added offset.
        /// </summary>
        /// <param name="point2Ds">The collection of points to encompass.</param>
        /// <param name="offset">The distance to expand the bounding box in all directions.</param>
        public BoundingBox2D(IEnumerable<Point2D>? point2Ds, double offset)
        {
            min = Query.Min(point2Ds, out max);

            Offset(offset);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class defined by two points as opposite corners.
        /// </summary>
        /// <param name="point2D_1">The first corner point.</param>
        /// <param name="point2D_2">The second corner point.</param>
        public BoundingBox2D(Point2D? point2D_1, Point2D? point2D_2)
        {
            min = Query.Min([point2D_1, point2D_2], out max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class by cloning an existing bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The source bounding box to clone.</param>
        public BoundingBox2D(BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D != null)
            {
                min = new Point2D(boundingBox2D.min);
                max = new Point2D(boundingBox2D.max);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class defined by X and Y ranges.
        /// </summary>
        /// <param name="x">The range of the X axis.</param>
        /// <param name="y">The range of the Y axis.</param>
        public BoundingBox2D(Range<double>? x, Range<double>? y)
        {
            if (x != null && y != null)
            {
                min = new Point2D(x.Min, y.Min);
                max = new Point2D(x.Max, y.Max);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class defined by its origin and size.
        /// </summary>
        /// <param name="x">The X coordinate of the origin.</param>
        /// <param name="y">The Y coordinate of the origin.</param>
        /// <param name="width">The width of the bounding box.</param>
        /// <param name="height">The height of the bounding box.</param>
        public BoundingBox2D(double x, double y, double width, double height)
            : this(new Point2D(x, y), new Point2D(x + width, y + height))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox2D"/> class directly from corner coordinates, without intermediate allocations.
        /// </summary>
        /// <param name="x_1">The X coordinate of the first corner.</param>
        /// <param name="y_1">The Y coordinate of the first corner.</param>
        /// <param name="x_2">The X coordinate of the second corner.</param>
        /// <param name="y_2">The Y coordinate of the second corner.</param>
        /// <param name="sorted">When <see langword="true"/>, the caller guarantees the first corner is the minimum and the second the maximum; when <see langword="false"/>, the coordinates are normalized.</param>
        internal BoundingBox2D(double x_1, double y_1, double x_2, double y_2, bool sorted)
        {
            if (!sorted)
            {
                if (x_2 < x_1)
                {
                    (x_1, x_2) = (x_2, x_1);
                }

                if (y_2 < y_1)
                {
                    (y_1, y_2) = (y_2, y_1);
                }
            }

            min = new Point2D(x_1, y_1);
            max = new Point2D(x_2, y_2);
        }

        /// <summary>
        /// Gets the bottom-left corner of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets the bottom-right corner of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets the height of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the maximum corner (top-right) of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets the minimum corner (bottom-left) of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets the top-left corner of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets the top-right corner of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Gets the width of the bounding box.
        /// </summary>
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

        /// <summary>
        /// Implicitly converts a BoundingBox2D to a Polygon2D.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box to convert.</param>
        /// <returns>A Polygon2D representation of the bounding box.</returns>
        public static implicit operator Polygon2D?(BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D is null)
            {
                return null;
            }

            return new Polygon2D(boundingBox2D.GetPoints());
        }

        /// <summary>
        /// Adds another bounding box to this one, expanding it to encompass the new area.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box to add.</param>
        /// <returns>True if the bounding box was successfully added.</returns>
        public bool Add(BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null || boundingBox2D.min == null || boundingBox2D.max == null)
            {
                return false;
            }

            if (min == null || max == null)
            {
                min = new Point2D(boundingBox2D.min);
                max = new Point2D(boundingBox2D.max);
                return true;
            }

            Point2D point2D_OtherMin = boundingBox2D.min;
            Point2D point2D_OtherMax = boundingBox2D.max;

            if (point2D_OtherMin.X < min.X)
            {
                min.X = point2D_OtherMin.X;
            }
            if (point2D_OtherMin.Y < min.Y)
            {
                min.Y = point2D_OtherMin.Y;
            }

            if (point2D_OtherMax.X > max.X)
            {
                max.X = point2D_OtherMax.X;
            }
            if (point2D_OtherMax.Y > max.Y)
            {
                max.Y = point2D_OtherMax.Y;
            }

            return true;
        }

        /// <summary>
        /// Adds a point to this bounding box, expanding it to encompass the point.
        /// </summary>
        /// <param name="point2D">The point to add.</param>
        /// <returns>True if the point was successfully added.</returns>
        public bool Add(Point2D? point2D)
        {
            if (point2D == null)
            {
                return false;
            }

            if (min == null || max == null)
            {
                min = new Point2D(point2D);
                max = new Point2D(point2D);
                return true;
            }

            double px = point2D.X;
            double py = point2D.Y;

            if (px < min.X)
            {
                min.X = px;
            }
            if (py < min.Y)
            {
                min.Y = py;
            }

            if (px > max.X)
            {
                max.X = px;
            }
            if (py > max.Y)
            {
                max.Y = py;
            }

            return true;
        }

        /// <summary>
        /// Creates a clone of the current bounding box.
        /// </summary>
        /// <returns>A cloned instance of the bounding box.</returns>
        public override ISerializableObject? Clone()
        {
            return new BoundingBox2D(this);
        }

        /// <summary>
        /// Finds the point on the bounding box closest to the given point.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The closest point on the bounding box boundary.</returns>
        public Point2D? ClosestPoint(Point2D? point2D)
        {
            if (point2D == null || min == null || max == null)
            {
                return null;
            }

            double px = point2D.X;
            double py = point2D.Y;

            double minX = min.X;
            double minY = min.Y;
            double maxX = max.X;
            double maxY = max.Y;

            double cx = px < minX ? minX : px > maxX ? maxX : px;
            double cy = py < minY ? minY : py > maxY ? maxY : py;

            if (cx != px || cy != py)
            {
                return new Point2D(cx, cy);
            }

            double distLeft = px - minX;
            double distRight = maxX - px;
            double distBottom = py - minY;
            double distTop = maxY - py;

            double minDist = System.Math.Min(System.Math.Min(distLeft, distRight), System.Math.Min(distBottom, distTop));

            if (minDist == distLeft)
            {
                return new Point2D(minX, py);
            }
            if (minDist == distBottom)
            {
                return new Point2D(px, minY);
            }
            if (minDist == distRight)
            {
                return new Point2D(maxX, py);
            }
            return new Point2D(px, maxY);
        }

        /// <summary>
        /// Calculates the distance from a point to the bounding box boundary.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The shortest distance to the boundary.</returns>
        public double Distance(Point2D? point2D)
        {
            if (point2D == null || min == null || max == null)
            {
                return double.NaN;
            }

            double px = point2D.X;
            double py = point2D.Y;

            double minX = min.X;
            double minY = min.Y;
            double maxX = max.X;
            double maxY = max.Y;

            double dx = 0;
            double dy = 0;

            if (px < minX)
            {
                dx = minX - px;
            }
            else if (px > maxX)
            {
                dx = px - maxX;
            }

            if (py < minY)
            {
                dy = minY - py;
            }
            else if (py > maxY)
            {
                dy = py - maxY;
            }

            if (dx == 0 && dy == 0)
            {
                return System.Math.Min(System.Math.Min(px - minX, maxX - px), System.Math.Min(py - minY, maxY - py));
            }

            return System.Math.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// Calculates the area of the bounding box.
        /// </summary>
        /// <returns>The area of the bounding box.</returns>
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

        /// <summary>
        /// Gets the centroid of the bounding box.
        /// </summary>
        /// <returns>The center point of the bounding box.</returns>
        public Point2D? GetCentroid()
        {
            return min?.Mid(max);
        }

        /// <summary>
        /// Gets the diagonals of the bounding box.
        /// </summary>
        /// <returns>An array containing the two diagonal segments.</returns>
        public Segment2D[]? GetDiagonals()
        {
            List<Point2D>? points = GetPoints();
            if (points == null)
            {
                return null;
            }

            return [new Segment2D(points[0], points[2]), new Segment2D(points[1], points[3])];
        }

        /// <summary>
        /// Calculates the perimeter length of the bounding box.
        /// </summary>
        /// <returns>The total length of the boundary.</returns>
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

        /// <summary>
        /// Gets the point corresponding to a specific corner of the bounding box.
        /// </summary>
        /// <param name="corner">The corner to retrieve.</param>
        /// <returns>The point at the specified corner.</returns>
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

        /// <summary>
        /// Gets the four corner points of the bounding box.
        /// </summary>
        /// <returns>A list containing the bottom-left, top-left, top-right, and bottom-right corners.</returns>
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

        /// <summary>
        /// Gets the four segments forming the boundary of the bounding box.
        /// </summary>
        /// <returns>A list of segments that define the perimeter.</returns>
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
        /// Checks if another bounding box is within or intersects this bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the bounding box is on or inside this bounding box.</returns>
        public bool InRange(BoundingBox2D? boundingBox2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (boundingBox2D == null || min == null || max == null || boundingBox2D.min == null || boundingBox2D.max == null)
            {
                return false;
            }

            if (max.X + tolerance < boundingBox2D.min.X || min.X - tolerance > boundingBox2D.max.X)
            {
                return false;
            }

            if (max.Y + tolerance < boundingBox2D.min.Y || min.Y - tolerance > boundingBox2D.max.Y)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if a line is within or intersects the bounding box.
        /// </summary>
        /// <param name="line2D">The line to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the line is in range of the bounding box.</returns>
        public bool InRange(Line2D? line2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null || line2D is null)
            {
                return false;
            }

            if (!line2D.TryGetCoordinates(out double x_Origin, out double y_Origin, out double x_Direction, out double y_Direction))
            {
                return false;
            }

            double minX = min.X - tolerance;
            double minY = min.Y - tolerance;
            double maxX = max.X + tolerance;
            double maxY = max.Y + tolerance;

            double t0 = double.NegativeInfinity;
            double t1 = double.PositiveInfinity;

            for (int i = 0; i < 2; i++)
            {
                double p = (i == 0) ? x_Direction : y_Direction;
                double minB = (i == 0) ? minX : minY;
                double maxB = (i == 0) ? maxX : maxY;
                double p0Val = (i == 0) ? x_Origin : y_Origin;

                if (System.Math.Abs(p) < tolerance)
                {
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

        /// <summary>
        /// Checks if a segment is within or intersects the bounding box.
        /// </summary>
        /// <param name="segment2D">The segment to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the segment is in range of the bounding box.</returns>
        public bool InRange(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min is null || max is null)
            {
                return false;
            }

            if (segment2D is null || !segment2D.TryGetCoordinates(out double x_Start, out double y_Start, out double x_End, out double y_End))
            {
                return false;
            }

            double minX = min.X - tolerance;
            double minY = min.Y - tolerance;
            double maxX = max.X + tolerance;
            double maxY = max.Y + tolerance;

            double t0 = 0.0;
            double t1 = 1.0;

            // For each axis (X and Y); use actual delta vector, not normalized direction
            for (int i = 0; i < 2; i++)
            {
                double p = (i == 0) ? x_End - x_Start : y_End - y_Start;
                double minB = (i == 0) ? minX : minY;
                double maxB = (i == 0) ? maxX : maxY;
                double p0Val = (i == 0) ? x_Start : y_Start;

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

        /// <summary>
        /// Checks if a segmentable geometry is within or intersects the bounding box.
        /// </summary>
        /// <param name="segmentable2D">The geometry to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if any part of the geometry is in range of the bounding box.</returns>
        public bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            List<Segment2D>? segment2Ds;

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

            if (segmentable2D is IClosedCurve2D closedCurve2D)
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
        /// Checks if a point is within or on the boundary of this bounding box.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on or inside the bounding box.</returns>
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return false;
            }

            return Inside(point2D, tolerance) || On(point2D, tolerance);
        }

        /// <summary>
        /// Legacy method to check if a segment is within or intersects the bounding box.
        /// </summary>
        /// <param name="segment2D">The segment to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the segment is in range of the bounding box.</returns>
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

        /// <summary>
        /// Checks if a point is strictly inside the bounding box boundaries.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is strictly inside.</returns>
        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || min == null || max == null)
            {
                return false;
            }

            return point2D.X > min.X + tolerance && point2D.X < max.X - tolerance && point2D.Y < max.Y - tolerance && point2D.Y > min.Y + tolerance;
        }

        /// <summary>
        /// Checks if a collection of points are all strictly inside the bounding box boundaries.
        /// </summary>
        /// <param name="point2Ds">The collection of points to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if all points are strictly inside.</returns>
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

        /// <summary>
        /// Checks if a segmentable geometry is strictly inside the bounding box boundaries.
        /// </summary>
        /// <param name="segmentable2D">The geometry to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if all points of the geometry are strictly inside.</returns>
        public bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            return Inside(segmentable2D?.GetPoints(), tolerance);
        }

        /// <summary>
        /// Checks if boundingBox2D is inside this BoundingBox2D
        /// </summary>
        /// <param name="boundingBox2D">BoundingBox2D</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>True if given boundingBox2D is inside this BoundingBox2D with given tolerance</returns>
        public bool Inside(BoundingBox2D? boundingBox2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null)
            {
                return false;
            }

            return Inside(boundingBox2D?.GetPoints(), tolerance);
        }

        /// <summary>
        /// Moves the bounding box by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
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

        /// <summary>
        /// Offsets the bounding box boundaries by a specified distance in all directions.
        /// </summary>
        /// <param name="value">The offset value.</param>
        public void Offset(double value)
        {
            if (double.IsNaN(value) || min == null || max == null)
            {
                return;
            }

            min = new Point2D(min.X - value, min.Y - value);
            max = new Point2D(max.X + value, max.Y + value);
        }

        /// <summary>
        /// Checks if a point lies on the boundary of the bounding box.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the boundary.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || min == null || max == null)
            {
                return false;
            }

            double px = point2D.X;
            double py = point2D.Y;
            double minX = min.X;
            double minY = min.Y;
            double maxX = max.X;
            double maxY = max.Y;

            bool onXBoundary = (System.Math.Abs(px - minX) < tolerance || System.Math.Abs(px - maxX) < tolerance) && (py >= minY - tolerance && py <= maxY + tolerance);
            bool onYBoundary = (System.Math.Abs(py - minY) < tolerance || System.Math.Abs(py - maxY) < tolerance) && (px >= minX - tolerance && px <= maxX + tolerance);

            return onXBoundary || onYBoundary;
        }

        /// <summary>
        /// Transforms the bounding box using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
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