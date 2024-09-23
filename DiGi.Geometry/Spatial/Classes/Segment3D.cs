using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Segment3D : Geometry3D, ISegmentable3D, ILinear3D, ISegment<Point3D>
    {
        private Point3D start;
        private Vector3D vector;

        public Segment3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Segment3D(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
            :this(new Point3D(x_1, y_1, z_1), new Point3D(x_2, y_2, z_2))
        {

        }

        public Segment3D(Point3D start, Point3D end)
            : base()
        {
            if (start != null && end != null)
            {
                this.start = DiGi.Core.Query.Clone(start);
                vector = new Vector3D(start, end);
            }
        }

        public Segment3D(Point3D start, Vector3D vector)
        {
            this.start = DiGi.Core.Query.Clone(start);
            this.vector = DiGi.Core.Query.Clone(vector);
        }

        public Segment3D(Segment3D segment3D)
        : this(segment3D?.start, segment3D?.vector)
        {

        }

        [JsonIgnore]
        public Vector3D Direction
        {
            get
            {
                return vector == null ? null : vector.Unit;
            }
        }

        [JsonIgnore]
        public Point3D End
        {
            get
            {
                if (vector == null || start == null)
                {
                    return null;
                }

                Point3D result = new Point3D(start);
                result.Move(vector);

                return result;
            }

            set
            {
                if (value == null || start == null)
                {
                    return;
                }

                vector = new Vector3D(start, value);
            }
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                Point3D end = End;
                if (end == null)
                {
                    return double.NaN;
                }

                return start.Distance(end);
            }
        }

        [JsonPropertyName("Start")]
        public Point3D Start
        {
            get
            {
                return DiGi.Core.Query.Clone(start);
            }

            set
            {
                start = DiGi.Core.Query.Clone(value);
            }
        }

        [JsonPropertyName("Vector")]
        public Vector3D Vector
        {
            get
            {
                return DiGi.Core.Query.Clone(vector);
            }

            set
            {
                vector = DiGi.Core.Query.Clone(value);
            }
        }

        public Point3D this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Start;

                    case 1:
                        return End;

                    default:
                        return null;
                }
            }
        }

        public override ISerializableObject Clone()
        {
            return new Segment3D(this);
        }

        public Point3D ClosestPoint(Point3D point3D)
        {
            return Query.ClosestPoint(point3D, start, End, true);
        }

        public bool Collinear(ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            throw new System.NotImplementedException();
        }

        public double Distance(Point3D point3D)
        {
            throw new System.NotImplementedException();
        }

        public BoundingBox3D GetBoundingBox()
        {
            if(start == null || vector == null)
            {
                return null;
            }

            return new BoundingBox3D(start, End);
        }

        public List<Point3D> GetPoints()
        {
            if (start == null || vector == null)
            {
                return null;
            }

            return new List<Point3D>() { new Point3D(start), End };
        }

        public List<Segment3D> GetSegments()
        {
            return new List<Segment3D>() { new Segment3D(this) };
        }

        public void Inverse()
        {
            throw new System.NotImplementedException();
        }

        public Point3D Mid()
        {
            if (start == null || vector == null)
            {
                return null;
            }

            return start.Mid(End);
        }

        public override bool Move(Vector3D vector3D)
        {
            if(start == null || vector3D == null)
            {
                return false;
            }

            return start.Move(vector3D);
        }
        
        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Point3D point3D_Temp = ClosestPoint(point3D);
            if(point3D_Temp == null)
            {
                return false;
            }

            return point3D.Distance(point3D_Temp) < tolerance;
        }
        
        public bool Transform(ITransform3D transform)
        {
            throw new System.NotImplementedException();
        }
    }
}
