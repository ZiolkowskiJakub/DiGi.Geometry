using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using DiGi.Geometry.Core.Enums;
using System.Text.Json.Serialization;
using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Planar.Classes
{
    public class Rectangle2D : Geometry2D, IPolygonal2D
    {
        [JsonInclude, JsonPropertyName("Height")]
        private double height;

        [JsonInclude, JsonPropertyName("HeightDirection")]
        private Vector2D? heightDirection;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point2D? origin;

        [JsonInclude, JsonPropertyName("Width")]
        private double width;
        
        public Rectangle2D(double width, double height)
        {
            origin = Constans.Point2D.Zero;
            this.width = width;
            this.height = height;
            heightDirection = Constans.Vector2D.WorldY;
        }

        public Rectangle2D(Point2D? origin, double width, double height)
        {
            this.origin = DiGi.Core.Query.Clone(origin);
            this.width = width;
            this.height = height;
            heightDirection = Constans.Vector2D.WorldY;
        }

        public Rectangle2D(BoundingBox2D? boundingBox2D)
        {
            if(boundingBox2D is not null)
            {
                origin = boundingBox2D.GetPoint(Corner.BottomLeft);
                width = boundingBox2D.Width;
                height = boundingBox2D.Height;
                heightDirection = Constans.Vector2D.WorldY;
            }
        }

        public Rectangle2D(Point2D? origin, double width, double height, Vector2D? heightDirection)
        {
            this.origin = DiGi.Core.Query.Clone(origin);
            this.width = width;
            this.height = height;
            this.heightDirection = heightDirection?.Unit;
        }

        public Rectangle2D(Rectangle2D? rectangle2D)
        {
            if (rectangle2D is not null)
            {
                origin = DiGi.Core.Query.Clone(rectangle2D.origin);
                width = rectangle2D.width;
                height = rectangle2D.height;
                heightDirection = DiGi.Core.Query.Clone(rectangle2D.heightDirection);
            }
        }

        public Rectangle2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        [JsonIgnore]
        public Vector2D? HeightDirection
        {
            get
            {
                return heightDirection;
            }
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return (2 * Width) + (2 * Height);
            }
        }

        [JsonIgnore]
        public Point2D? Origin
        {
            get
            {
                return DiGi.Core.Query.Clone(origin);
            }
            set
            {
                origin = DiGi.Core.Query.Clone(value);
            }
        }

        [JsonIgnore]
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        [JsonIgnore]
        public Vector2D? WidthDirection
        {
            get
            {
                return heightDirection?.GetPerpendicular(Orientation.Clockwise);
            }
        }

        public static explicit operator Polygon2D?(Rectangle2D? rectangle2D)
        {
            List<Point2D>? point2Ds = rectangle2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }


            return new Polygon2D(point2Ds);
        }

        public static explicit operator Rectangle2D?(BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new Rectangle2D(boundingBox2D);
        }
        
        public override ISerializableObject? Clone()
        {
            return new Rectangle2D(this);
        }

        public Point2D? ClosestPoint(Point2D? point2D)
        {
            return Query.ClosestPoint(point2D, this);
        }

        public double Distance(Point2D? point2D)
        {
            return Query.Distance(point2D, this);
        }

        public double GetArea()
        {
            return height * width;
        }

        public BoundingBox2D? GetBoundingBox()
        {
            return new BoundingBox2D(GetPoints());
        }

        public Point2D? GetCentroid()
        {
            Point2D? result = Origin;
            if (result == null)
            {
                return result;
            }

            Vector2D? vector2D = (width * WidthDirection / 2) + (height * heightDirection / 2);
            if (vector2D == null)
            {
                return null;
            }

            result.Move(vector2D);
            return result;
        }

        public Segment2D[]? GetDiagonals()
        {
            List<Point2D>? points = GetPoints();
            if(points is null)
            {
                return null;
            }

            return [new Segment2D(points[0], points[2]), new Segment2D(points[1], points[3])];
        }

        public Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return GetCentroid();
        }

        public double GetPerimeter()
        {
            return Length;
        }

        public List<Point2D>? GetPoints()
        {
            if(origin is null)
            {
                return null;
            }

            List<Point2D> points = [new Point2D(origin)];
            Vector2D? heightVector = height * heightDirection;
            if (heightVector is null)
            {
                return null;
            }

            Point2D? point2D = new (origin);
            point2D.Move(heightVector);
            points.Add(point2D);

            Vector2D? widthDirection = WidthDirection;
            Vector2D? widthVector = width * widthDirection;
            if (widthVector is null) 
            {
                return null;
            }

            point2D = new Point2D(point2D);
            point2D.Move(widthVector);
            points.Add(point2D);

            point2D = new Point2D(point2D);
            heightVector?.Inverse();
            point2D.Move(heightVector);
            points.Add(point2D);

            return points;
        }

        public List<Segment2D>? GetSegments()
        {
            List<Point2D>? points = GetPoints();
            if(points is null)
            {
                return null;
            }

            return
            [
                new Segment2D(points[0], points[1]),
                new Segment2D(points[1], points[2]),
                new Segment2D(points[2], points[3]),
                new Segment2D(points[3], points[0]),
            ];
        }

        public bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D == null)
            {
                return false;
            }

            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count < 2)
            {
                return false;
            }

            return new Polygon2D(point2Ds).InRange(segmentable2D, tolerance);
        }

        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return false;
            }

            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count < 2)
            {
                return false;
            }

            return new Polygon2D(point2Ds).InRange(point2D, tolerance);
        }

        public bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D == null)
            {
                return false;
            }

            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count < 2)
            {
                return false;
            }

            return new Polygon2D(point2Ds).Inside(segmentable2D, tolerance);
        }

        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return false;
            }

            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count < 2)
            {
                return false;
            }

            return new Polygon2D(point2Ds).Inside(point2D, tolerance);
        }

        public void Inverse()
        {
            Point2D? point2D = DiGi.Core.Query.Clone(origin);
            if(point2D is null)
            {
                return;
            }

            Vector2D? vector2D;

            vector2D = WidthDirection * width;
            point2D.Move(vector2D);

            vector2D = heightDirection * height;
            point2D.Move(vector2D);

            origin = point2D;

            heightDirection?.Inverse();
        }

        public override bool Move(Vector2D? vector2D)
        {
            if(origin == null || vector2D == null)
            {
                return false;
            }

            origin.Move(vector2D);
            return true;
        }

        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Query.On(this, point2D, tolerance);
        }

        public override bool Transform(ITransform2D? transform)
        {
            if(transform == null || origin == null || double.IsNaN(width) || double.IsNaN(height) || heightDirection == null)
            {
                return false;
            }

            Vector2D? vector3D_Width = WidthDirection * width;
            if(vector3D_Width == null)
            {
                return false;
            }

            Vector2D? vector3D_Height = heightDirection * height;
            if(vector3D_Height == null)
            {
                return false;
            }

            vector3D_Width.Transform(transform);
            vector3D_Height.Transform(transform);

            origin.Transform(transform);
            height = vector3D_Height.Length;
            vector3D_Height.Normalize();
            heightDirection = vector3D_Height;
            width = vector3D_Width.Length;

            return true;
        }
        public List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            List<Point2D>? point2Ds = GetPoints();
            if(point2Ds == null || point2Ds.Count != 4)
            {
                return null;
            }

            return [new Triangle2D(point2Ds[0], point2Ds[1], point2Ds[2]), new Triangle2D(point2Ds[2], point2Ds[3], point2Ds[0])];
        }
    }
}
