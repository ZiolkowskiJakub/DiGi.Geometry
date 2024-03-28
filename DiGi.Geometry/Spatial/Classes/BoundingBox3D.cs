using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;
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

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            return (point3D.X > min.X + tolerance && point3D.X < max.X - tolerance && point3D.Y > min.Y + tolerance && point3D.Y < max.Y - tolerance && point3D.Z > min.Z + tolerance && point3D.Z < max.Z - tolerance);
        }

        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point3D == null)
            {
                return false;
            }

            if(Inside(point3D, tolerance))
            {
                return false;
            }

            return InRange(point3D, tolerance);
        }

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point3D == null)
            {
                return false;
            }

            return (point3D.X >= min.X - tolerance && point3D.X <= max.X + tolerance && point3D.Y >= min.Y - tolerance && point3D.Y <= max.Y + tolerance && point3D.Z >= min.Z - tolerance && point3D.Z <= max.Z + tolerance);
        }

        public bool InRange(Line3D line3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(min == null || max == null || line3D == null)
            {
                return false;
            }

            List<Plane> planes = Create.Planes(this);
            if(planes == null || planes.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < planes.Count; i++)
            {
                PlanarIntersectionResult planarIntersectionResult = Create.PlanarIntersectionResult(planes[i], line3D, tolerance);
                if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                Point3D point3D_Intersection = planarIntersectionResult.GetGeometry3Ds<Point3D>()?.FirstOrDefault();
                if(point3D_Intersection == null)
                {
                    continue;
                }

                if(On(point3D_Intersection, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public bool InRange(Segment3D segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (min == null || max == null || segment3D == null)
            {
                return false;
            }

            BoundingBox3D boundingBox3D = segment3D.GetBoundingBox();
            if(boundingBox3D == null)
            {
                return false;
            }

            if (!InRange(boundingBox3D, tolerance))
            {
                return false;
            }

            List<Plane> planes = Create.Planes(this);
            if (planes == null || planes.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < planes.Count; i++)
            {
                PlanarIntersectionResult planarIntersectionResult = Create.PlanarIntersectionResult(planes[i], segment3D, tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                Point3D point3D_Intersection = planarIntersectionResult.GetGeometry3Ds<Point3D>()?.FirstOrDefault();
                if (point3D_Intersection == null)
                {
                    continue;
                }

                if (On(point3D_Intersection, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public bool InRange(BoundingBox3D boundingBox3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (boundingBox3D == null)
            {
                return false;
            }

            double max_1;
            double min_1;

            double max_2;
            double min_2;

            max_1 = max.X + tolerance;
            min_1 = min.X - tolerance;

            max_2 = boundingBox3D.max.X;
            min_2 = boundingBox3D.min.X;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            max_1 = max.Y + tolerance;
            min_1 = min.Y - tolerance;

            max_2 = boundingBox3D.max.Y;
            min_2 = boundingBox3D.min.Y;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            max_1 = max.Z + tolerance;
            min_1 = min.Z - tolerance;

            max_2 = boundingBox3D.max.Z;
            min_2 = boundingBox3D.min.Z;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            return true;
        }

        public bool InRange(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (min == null || max == null || segmentable3D == null)
            {
                return false;
            }

            BoundingBox3D boundingBox3D = segmentable3D.GetBoundingBox();
            if (boundingBox3D == null)
            {
                return false;
            }

            List<Segment3D> segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null || segment3Ds.Count == 0)
            {
                return false;
            }

            if (!InRange(boundingBox3D, tolerance))
            {
                return false;
            }
            
            for(int i =0; i < segment3Ds.Count; i++)
            {
                if (InRange(segment3Ds[i], tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public bool InRange(Plane plane, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null)
            {
                return false;
            }

            List<Point3D> point3Ds = GetPoints();
            if(point3Ds == null || point3Ds.Count == 0)
            {
                return false;
            }

            if (InRange(point3Ds[0], tolerance))
            {
                return true;
            }

            bool above = Query.Above(plane, point3Ds[0], tolerance);
            for (int i = 1; i < point3Ds.Count; i++)
            {
                if (InRange(point3Ds[0], tolerance))
                {
                    return true;
                }

                if(Query.Above(plane, point3Ds[i], tolerance) != above)
                {
                    return true;
                }
            }

            return false;
        }

        public List<Point3D> GetPoints()
        {
            if(min == null || max == null)
            {
                return null;
            }

            double x = Width;
            double y = Depth;

            return new List<Point3D>()
            {
                new Point3D(min),
                new Point3D(min.X + x, min.Y, Min.Z),
                new Point3D(min.X + x, min.Y + y, Min.Z),
                new Point3D(min.X, min.Y + y, Min.Z),

                new Point3D(max),
                new Point3D(max.X + x, max.Y, max.Z),
                new Point3D(max.X + x, max.Y + y, max.Z),
                new Point3D(max.X, max.Y + y, max.Z),
            };
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
