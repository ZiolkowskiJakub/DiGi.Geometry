using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Rectangle3D : Planar<Rectangle2D>, IPolygonal3D
    {
        public Rectangle3D(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Rectangle3D(Plane? plane, Rectangle2D? rectangle2D)
            : base(plane, rectangle2D)
        {

        }

        public Rectangle3D(Plane? plane, double width, double height)
            : base(plane, new Rectangle2D(width, height))
        {

        }

        public Rectangle3D(Plane? plane, IEnumerable<Point2D>? point2Ds)
            : base(plane, Planar.Create.Rectangle2D(point2Ds))
        {

        }

        public Rectangle3D(Rectangle3D? rectangle3D)
            : base(rectangle3D)
        {

        }

        [JsonIgnore]
        public double Height
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.Height;
            }
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                if(geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.Length;
            }

        }
        [JsonIgnore]
        public double Width
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.Width;
            }
        }

        public override ISerializableObject? Clone()
        {
            return new Rectangle3D(this);
        }

        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D == null || geometry2D == null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, this);
        }

        public double Distance(Point3D? point3D)
        {
            if (point3D == null || geometry2D == null)
            {
                return double.NaN;
            }

            Point3D? point3D_Closest = Query.ClosestPoint(point3D, this, out double result);
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

        public BoundingBox3D? GetBoundingBox()
        {
            List<Point3D>? point3Ds = GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            return new BoundingBox3D(point3Ds);
        }

        public Point3D? GetCentroid()
        {
            if(plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetCentroid());
        }

        public Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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

        public List<Point3D>? GetPoints()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = geometry2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            List<Point3D> result = [];
            for (int i = 0; i < point2Ds.Count; i++)
            {
                Point3D? point3D = plane.Convert(point2Ds[i]);
                if (point3D is null)
                {
                    continue;
                }

                result.Add(point3D);
            }

            return result;
        }

        public List<Segment3D>? GetSegments()
        {
            List<Point3D>? point3Ds = GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            return Create.Segment3Ds(point3Ds, true);
        }

        public bool InRange(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, segmentable3D, tolerance);
        }

        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, point3D, tolerance);
        }

        public bool Inside(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, segmentable3D, tolerance);
        }
        
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, point3D, tolerance);
        }

        public void Inverse()
        {
            geometry2D?.Inverse();
        }

        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null)
            {
                return false;
            }

            return Query.On(this, point3D, tolerance);
        }

        public List<Triangle3D>? Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if(plane == null)
            {
                return null;
            }

            List<Triangle2D>? triangle2Ds = geometry2D?.Triangulate(tolerance);
            if(triangle2Ds == null)
            {
                return null;
            }

            List<Triangle3D> result = [];
            for (int i = 0; i < triangle2Ds.Count; i++)
            {
                Triangle3D? triangle3D = plane.Convert(triangle2Ds[i]);
                if (triangle3D == null)
                {
                    continue;
                }

                result.Add(triangle3D);
            }

            return result;
        }
    }
}
