using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Triangle3D : Geometry3D, IPlanar<Triangle2D>, IPolygonal3D
    {
        [JsonInclude, JsonPropertyName("Points")]
        private Point3D[] points = new Point3D[3];

        public Triangle3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Triangle3D(Triangle3D triangle3D)
            : base(triangle3D)
        {
            if(triangle3D != null)
            {
                points[0] = triangle3D.points[0];
                points[1] = triangle3D.points[1];
                points[2] = triangle3D.points[2];
            }
        }

        public Triangle3D(Point3D point2D_1, Point3D point2D_2, Point3D point2D_3)
            : base()
        {
            points[0] = point2D_1;
            points[1] = point2D_2;
            points[2] = point2D_3;
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                if(points == null)
                {
                    return double.NaN;
                }

                return points[0].Distance(points[1]) + points[1].Distance(points[2]) + points[2].Distance(points[0]);
            }
        }

        [JsonIgnore]
        public Triangle2D Geometry2D
        {
            get
            {
                Plane plane = Plane;
                if(plane == null)
                {
                    return null;
                }

                return new Triangle2D(plane.Convert(points[0]), plane.Convert(points[1]), plane.Convert(points[2]));

            }
        }

        [JsonIgnore]
        public Plane Plane
        {
            get
            {
                return Create.Plane(points[0], points[1], points[2]);
            }
        }

        public override ISerializableObject Clone()
        {
            return new Triangle3D(this);
        }

        public Point3D ClosestPoint(Point3D point3D)
        {
            if(point3D == null || points == null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, this);
        }

        public double Distance(Point3D point3D)
        {
            if (point3D == null || points == null)
            {
                return double.NaN;
            }

            Point3D point3D_Closest = Query.ClosestPoint(point3D, this, out double result);
            if(point3D_Closest == null)
            {
                return double.NaN;
            }

            return result;
        }

        public double GetArea()
        {
            if (points == null)
            {
                return double.NaN;
            }

            double a = points[0].Distance(points[1]);
            double b = points[1].Distance(points[2]);
            double c = points[2].Distance(points[0]);

            double s = (a + b + c) / 2;
            return System.Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public BoundingBox3D GetBoundingBox()
        {
            if(points == null)
            {
                return null;
            }

            return new BoundingBox3D(points);
        }

        public Point3D GetCentroid()
        {
            return Query.Centroid(points);
        }

        public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(points == null)
            {
                return null;
            }

            return points[0].Mid(points[1]).Mid(points[2]);
        }

        public List<Point3D> GetPoints()
        {
            return DiGi.Core.Query.Clone(points)?.ToList();
        }

        public List<Segment3D> GetSegments()
        {
            if(points == null)
            {
                return null;
            }

            return new List<Segment3D>() { new Segment3D(points[0], points[1]), new Segment3D(points[1], points[2]), new Segment3D(points[2], points[0]) };
        }

        public bool InRange(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable3D == null || points == null)
            {
                return false;
            }

            List<Point3D> point3Ds = segmentable3D.GetPoints();
            if (point3Ds == null)
            {
                return false;
            }

            return Query.InRange(this, point3Ds, tolerance);
        }

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || points == null)
            {
                return false;
            }

            return Query.InRange(this, point3D, tolerance);
        }

        public bool Inside(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable3D == null || points == null)
            {
                return false;
            }

            List<Point3D> point3Ds = segmentable3D.GetPoints();
            if(point3Ds == null)
            {
                return false;
            }

            return Query.Inside(this, point3Ds, tolerance);
        }

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point3D == null || points == null)
            {
                return false;
            }

            return Query.Inside(this, point3D, tolerance);
        }

        public void Inverse()
        {
            if(points == null)
            {
                return;
            }

            Point3D point3D = points[0];

            points[0] = points[2];
            points[2] = point3D;
        }

        public override bool Move(Vector3D vector3D)
        {
            if(vector3D == null || points == null)
            {
                return false;
            }

            for(int i =0; i < points.Length; i++)
            {
                points[i].Move(vector3D);
            }

            return true;
        }

        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || points == null)
            {
                return false;
            }

            return Query.On(this, point3D, tolerance);
        }

        public List<Triangle3D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            List<Point3D> point3Ds = GetPoints();
            if (point3Ds != null || point3Ds.Count != 3)
            {
                return null;
            }

            return new List<Triangle3D>() { new Triangle3D(points[0], points[1], points[2]) };
        }
    }
}
