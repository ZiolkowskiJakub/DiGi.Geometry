using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Polyline3D : Geometry3D, ISegmentable3D
    {
        [JsonInclude, JsonPropertyName("Points")]
        protected List<Point3D> points = new List<Point3D>();

        public double Length
        {
            get
            {
                List<Segment3D> segment3Ds = GetSegments();
                if (segment3Ds == null)
                {
                    return double.NaN;
                }

                double result = 0;
                for (int i = 0; i < segment3Ds.Count; i++)
                {
                    Segment3D segment3D = segment3Ds[i];
                    if (segment3D == null)
                    {
                        continue;
                    }

                    result += segment3D.Length;
                }

                return result;
            }
        }

        public Polyline3D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Polyline3D()
        {

        }

        public Polyline3D(Polyline3D polyline3D)
            :base(polyline3D)
        {
            if(polyline3D != null)
            {
                points = DiGi.Core.Query.Clone(polyline3D.points);
            }
        }

        public Polyline3D(IEnumerable<Point3D> point3Ds)
            :base()
        {
            points = DiGi.Core.Query.Clone(point3Ds);
        }

        public Polyline3D(IEnumerable<Point3D> point3Ds, bool close)
        {
            points = DiGi.Core.Query.Clone(point3Ds);

            if (close)
            {
                Close();
            }
            else
            {
                Open();
            }
        }

        public List<Segment3D> GetSegments()
        {
            return Create.Segment3Ds(points, false);
        }

        public override ISerializableObject Clone()
        {
            return new Polyline3D(this);
        }

        public bool IsClosed()
        {
            if(points == null || points.Count < 3)
            {
                return false;
            }

            return points[0].Equals(points[points.Count - 1]);
        }

        public void Close()
        {
            if (IsClosed())
            {
                return;
            }

            if(points == null || points.Count < 3)
            {
                return;
            }

            points.Add(new Point3D(points[0]));
        }

        public void Open()
        {
            if (!IsClosed())
            {
                return;
            }

            if(points == null || points.Count < 3)
            {
                return;
            }

            points.RemoveAt(points.Count - 1);
        }

        public override bool Move(Vector3D vector3D)
        {
            if(points == null || points.Count == 0)
            {
                return false;
            }

            for(int i=0; i < points.Count; i++)
            {
                points[i].Move(vector3D);
            }

            return true;
        }

        public List<Point3D> GetPoints()
        {
            return DiGi.Core.Query.Clone(points);
        }

        public double Distance(Point3D point3D)
        {
            if (point3D == null || points == null)
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

        public Point3D ClosestPoint(Point3D point3D)
        {
            return Query.ClosestPoint(point3D, this);
        }

        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Query.On(this, point3D, tolerance);
        }

        public BoundingBox3D GetBoundingBox()
        {
            if(points == null || points.Count == 0)
            {
                return null;
            }

            return new BoundingBox3D(points);
        }

        public void Inverse()
        {
            points.Reverse();
        }
    }
}
