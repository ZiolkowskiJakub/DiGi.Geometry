using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Ellipse3D : Planar<Ellipse2D>, IEllipse3D
    {
        public Ellipse3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Ellipse3D(Plane plane, Ellipse2D ellipse2D)
            : base(plane, ellipse2D)
        {

        }

        public Ellipse3D(Ellipse3D ellipse3D)
            : base(ellipse3D)
        {

        }

        [JsonIgnore]
        public double A
        {
            get
            {
                return geometry2D.A;
            }

            set
            {
                geometry2D.A = value;
            }
        }

        [JsonIgnore]
        public double B
        {
            get
            {
                return geometry2D.B;
            }

            set
            {
                geometry2D.B = value;
            }
        }

        [JsonIgnore]
        public Point3D Center
        {
            get
            {
                return plane?.Convert(geometry2D?.Center);
            }
        }

        [JsonIgnore]
        public Vector3D Direction
        {
            get
            {
                return plane?.Convert(geometry2D?.DirectionA);
            }
        }

        public override ISerializableObject Clone()
        {
            return new Ellipse3D(this);
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
            List<Point2D> point2Ds = Geometry2D?.GetBoundingBox()?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            Plane plane = Plane;
            if(plane == null)
            {
                return null;
            }

            return new BoundingBox3D(point2Ds.ConvertAll(x => plane.Convert(x)));
        }

        public Point3D[] GetFocalPoints()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            Point2D[] point2Ds = geometry2D.GetFocalPoints();
            if (point2Ds == null)
            {
                return null;
            }


            Point3D[] result = new Point3D[point2Ds.Length];
            for (int i = 0; i < point2Ds.Length; i++)
            {
                result[i] = plane.Convert(point2Ds[i]);
            }

            return result;
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
            return geometry2D.GetPerimeter();
        }

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            throw new System.NotImplementedException();
        }

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            throw new System.NotImplementedException();
        }

        public void Inverse()
        {
            geometry2D.Inverse();
        }
    }
}
