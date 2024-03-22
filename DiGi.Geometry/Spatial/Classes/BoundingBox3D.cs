using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class BoundingBox3D : Geometry3D, IBoundingBox<Point3D>
    {
        [JsonInclude, JsonPropertyName("Min")]
        private Point3D min;

        [JsonInclude, JsonPropertyName("Max")]
        private Point3D max;

        public BoundingBox3D(Point3D point2D_1, Point3D point2D_2)
            :base()
        {
            min = Query.Min(new Point3D[] { point2D_1, point2D_2 }, out max);
        }

        public BoundingBox3D(IEnumerable<Point3D> point3Ds)
        {
            min = Query.Min(point3Ds, out max);
        }

        public BoundingBox3D(IEnumerable<Point3D> point3Ds, double offset)
        {
            min = Query.Min(point3Ds, out max);

            Offset(offset);
        }

        public BoundingBox3D(BoundingBox3D boundingBox3D)
            : base(boundingBox3D)
        {
            if (boundingBox3D != null)
            {
                min = boundingBox3D.Min;
                max = boundingBox3D.Max;
            }
        }

        public BoundingBox3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public Point3D Max
        {
            get
            {
                return new Point3D(max);
            }
            set
            {
                if (min == null)
                {
                    max = new Point3D(value);
                    min = new Point3D(value);
                }
                else
                {
                    max = Query.Max(min, value);
                    min = Query.Min(min, value);
                }
            }
        }

        [JsonIgnore]
        public Point3D Min
        {
            get
            {
                return new Point3D(min);
            }
            set
            {
                if (max == null)
                {
                    max = new Point3D(value);
                    min = new Point3D(value);
                }
                else
                {
                    max = Query.Max(max, value);
                    min = Query.Min(max, value);
                }
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

                return max.Z - min.Z;
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

        [JsonIgnore]
        public double Depth
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

        public bool Add(Point3D point3D)
        {
            if (point3D == null)
            {
                return false;
            }

            max = Query.Max(max, point3D);
            min = Query.Min(min, point3D);
            return true;
        }

        public void Offset(double value)
        {
            if (double.IsNaN(value) || min == null || max == null)
            {
                return;
            }

            min = new Point3D(min.X - value, min.Y - value, min.Z - value);
            max = new Point3D(max.X + value, max.Y + value, max.Z + value);
        }

        public override ISerializableObject Clone()
        {
            return new BoundingBox3D(this);
        }

        public override bool Move(Vector3D vector3D)
        {
            if(vector3D == null || min == null || max == null)
            {
                return false;
            }

            min.Move(vector3D);
            max.Move(vector3D);
            return true;
        }

        public double GetVolume()
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

            double depth = Depth;
            if (double.IsNaN(depth))
            {
                return double.NaN;
            }

            return width * height * depth;
        }

        public Point3D GetCentroid()
        {
            return min?.Mid(max);
        }
    }
}
