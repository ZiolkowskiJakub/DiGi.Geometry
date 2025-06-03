using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Polygon3D : Planar<Polygon2D>, IPolygonal3D
    {
        public Polygon3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Polygon3D(Plane plane, Polygon2D polygon2D)
            : base(plane, polygon2D)
        {

        }

        public Polygon3D(Plane plane, IEnumerable<Point2D> point2Ds)
            : base(plane, point2Ds == null ? null : new Polygon2D(point2Ds))
        {

        }

        public Polygon3D(Polygon3D polygon3D)
            : base(polygon3D)
        {

        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return geometry2D.Length;
            }

        }
        public override ISerializableObject Clone()
        {
            return new Polygon3D(this);
        }

        public Point3D ClosestPoint(Point3D point3D)
        {
            if (point3D == null || geometry2D == null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, this);
        }

        public double Distance(Point3D point3D)
        {
            if (point3D == null || geometry2D == null)
            {
                return double.NaN;
            }

            Point3D point3D_Closest = Query.ClosestPoint(point3D, this, out double result);
            if (point3D_Closest == null)
            {
                return double.NaN;
            }

            return result;
        }

        public double GetArea()
        {
            if (geometry2D == null)
            {
                return double.NaN;
            }

            return geometry2D.GetArea();
        }

        public BoundingBox3D GetBoundingBox()
        {
            List<Point3D> point3Ds = GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            return new BoundingBox3D(point3Ds);
        }

        public Point3D GetCentroid()
        {
            if(plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetCentroid());
        }

        public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {

            if (plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetInternalPoint());
        }

        public double GetPerimeter()
        {
            return Length;
        }

        public List<Point3D> GetPoints()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            List<Point2D> point2Ds = geometry2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            List<Point3D> result = new List<Point3D>();
            for (int i = 0; i < point2Ds.Count; i++)
            {
                result.Add(plane.Convert(point2Ds[i]));
            }

            return result;
        }

        public List<Segment3D> GetSegments()
        {
            List<Point3D> point3Ds = GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            return Create.Segment3Ds(point3Ds, true);
        }

        public bool InRange(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, segmentable3D, tolerance);
        }

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, point3D, tolerance);
        }

        public bool Inside(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, segmentable3D, tolerance);
        }
        
        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, point3D, tolerance);
        }

        public void Inverse()
        {
            geometry2D.Inverse();
        }

        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null)
            {
                return false;
            }

            return Query.On(this, point3D, tolerance);
        }

        public List<Triangle3D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if(plane == null)
            {
                return null;
            }

            List<Triangle2D> triangle2Ds = geometry2D?.Triangulate(tolerance);
            if(triangle2Ds == null)
            {
                return null;
            }

            List<Triangle3D> result = new List<Triangle3D>();
            for (int i = 0; i < triangle2Ds.Count; i++)
            {
                result.Add(plane.Convert(triangle2Ds[i]));
            }

            return result;
        }
    }
}
