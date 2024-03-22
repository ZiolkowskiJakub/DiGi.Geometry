
using DiGi.Geometry.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static DiGi.Core.Constans;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Plane : Geometry3D, IInvertible
    {
        [JsonInclude, JsonPropertyName("AxisY")]
        private Vector3D axisY;

        [JsonInclude, JsonPropertyName("Normal")]
        private Vector3D normal;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D origin;

        public Plane(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public Plane(Plane plane)
        {
            if(plane != null)
            {
                normal = new Vector3D(plane.normal);
                origin = new Point3D(plane.origin);
                axisY = new Vector3D(plane.axisY);
            }
        }

        public Plane(Plane plane, Point3D origin)
        {
            if(plane != null)
            {
                normal = new Vector3D(plane.normal);
                axisY = new Vector3D(plane.axisY);
            }

            if(origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        public Plane(Point3D point3D_1, Point3D point3D_2, Point3D point3D_3)
        {
            origin = new Point3D(point3D_1);
            normal = Query.Normal(point3D_1, point3D_2, point3D_3);
            axisY = normal.AxisY();
        }

        public Plane(Point3D origin, Vector3D normal)
        {
            if(normal != null)
            {
                this.normal = normal.Unit;
                axisY = normal.AxisY();
            }

            if(origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        public Plane(Point3D origin, Vector3D axisX, Vector3D axisY)
        {
            this.origin = origin == null ? null : new Point3D(origin);

            this.axisY = axisY == null ? null : axisY.Unit;

            if(axisX != null && this.axisY != null)
            {
                normal = Query.Normal(axisX.Unit, this.axisY);
            }
        }

        /// <summary>
        /// A factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>A value for point-normal equation</value>
        [JsonIgnore]
        public double A
        {
            get
            {
                return normal.X;
            }
        }

        [JsonIgnore]
        public Vector3D AxisX
        {
            get
            {
                return Query.AxisX(normal, axisY);
            }
        }

        [JsonIgnore]
        public Vector3D AxisY
        {
            get
            {
                return axisY == null ? null : new Vector3D(axisY);
            }
        }

        [JsonIgnore]
        public Vector3D AxisZ
        {
            get
            {
                return normal == null ? null : new Vector3D(normal);
            }
        }

        /// <summary>
        /// B factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>B value for point-normal equation</value>
        [JsonIgnore]
        public double B
        {
            get
            {
                return normal.Y;
            }
        }

        /// <summary>
        /// C factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>C value for point-normal equation</value>
        [JsonIgnore]
        public double C
        {
            get
            {
                return normal.Z;
            }
        }

        /// <summary>
        /// D factor for point-normal equation Ax+By+Cz = D where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>D value for point-normal equation</value>
        [JsonIgnore]
        public double D
        {
            get
            {
                return -(normal.X * origin.X + normal.Y * origin.Y + normal.Z * origin.Z);
            }
        }

        /// <summary>
        /// Scalar constant relating origin point to normal vector.
        /// </summary>
        [JsonIgnore]
        public double K
        {
            get
            {
                return normal.DotProduct((Vector3D)origin);
            }
        }

        [JsonIgnore]
        public Vector3D Normal
        {
            get
            {
                return new Vector3D(normal);
            }
        }

        [JsonIgnore]
        public Point3D Origin
        {
            get
            {
                return origin == null ? null : new Point3D(origin);
            }
            set
            {
                origin = value;
            }
        }
        
        public Point3D ClosestPoint(Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            double factor = ((Vector3D)point3D).DotProduct(normal) - K;
            return new Point3D(point3D.X - (normal.X * factor), point3D.Y - (normal.Y * factor), point3D.Z - (normal.Z * factor));
        }

        public bool Coplanar(Plane plane, double tolerance = Tolerance.Distance)
        {
            return normal.AlmostEqual(plane.normal, tolerance) || normal.AlmostEqual(-plane.normal, tolerance);
        }

        public double Distance(Point3D point3D)
        {
            return ClosestPoint(point3D).Distance(point3D);
        }

        public void Inverse()
        {
            normal?.Inverse();
            axisY?.Inverse();
        }

        public override bool Move(Vector3D vector3D)
        {
            if (vector3D == null || origin == null)
            {
                return false;
            }

            origin.Move(vector3D);
            return true;
        }
    }
}
