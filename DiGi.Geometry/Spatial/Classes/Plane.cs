
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

        /// <summary>
        /// A factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>A value for point-normal equation</value>
        public double A
        {
            get
            {
                return normal.X;
            }
        }

        /// <summary>
        /// B factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>B value for point-normal equation</value>
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
        public double K
        {
            get
            {
                return normal.DotProduct((Vector3D)origin);
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

        public double Distance(Point3D point3D)
        {
            return ClosestPoint(point3D).Distance(point3D);
        }

        public bool On(Point3D point3D, double tolerance = Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            return System.Math.Abs((normal.X * (point3D.X - origin.X)) + (normal.Y * (point3D.Y - origin.Y)) + (normal.Z * (point3D.Z - origin.Z))) < tolerance;
        }

        public override bool Move(Vector3D vector3D)
        {
            if(vector3D == null || origin == null)
            {
                return false;
            }

            origin.Move(vector3D);
            return true;
        }

        public void Inverse()
        {
            normal?.Inverse();
            axisY?.Inverse();
        }
    }
}
