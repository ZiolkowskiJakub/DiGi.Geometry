using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Plane : Geometry3D, IFlippable
    {
        [JsonInclude, JsonPropertyName("AxisY")]
        private Vector3D? axisY;

        [JsonInclude, JsonPropertyName("Normal")]
        private Vector3D? normal;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D? origin;

        public Plane(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Plane(Plane? plane)
        {
            if (plane != null)
            {
                normal = new Vector3D(plane.normal);
                origin = new Point3D(plane.origin);
                axisY = new Vector3D(plane.axisY);
            }
        }

        public Plane(Plane? plane, Point3D? origin)
        {
            if (plane != null)
            {
                normal = new Vector3D(plane.normal);
                axisY = new Vector3D(plane.axisY);
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        public Plane(Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3)
        {
            origin = new Point3D(point3D_1);
            normal = Query.Normal(point3D_1, point3D_2, point3D_3);
            axisY = normal.AxisY();
        }

        public Plane(Point3D? origin, Vector3D? normal)
        {
            if (normal != null)
            {
                this.normal = normal.Unit;
                axisY = normal.AxisY();
            }

            if (origin != null)
            {
                this.origin = new(origin);
            }
        }

        public Plane(Point3D? origin, Vector3D? axisX, Vector3D? axisY)
        {
            this.origin = origin == null ? null : new Point3D(origin);

            this.axisY = axisY?.Unit;

            if (axisX != null && this.axisY != null)
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
                if (normal is null)
                {
                    return double.NaN;
                }

                return normal.X;
            }
        }

        [JsonIgnore]
        public Vector3D? AxisX
        {
            get
            {
                return Query.AxisX(normal, axisY);
            }
        }

        [JsonIgnore]
        public Vector3D? AxisY
        {
            get
            {
                return axisY == null ? null : new(axisY);
            }
        }

        [JsonIgnore]
        public Vector3D? AxisZ
        {
            get
            {
                return normal == null ? null : new(normal);
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
                if (normal is null)
                {
                    return double.NaN;
                }

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
                if (normal is null)
                {
                    return double.NaN;
                }

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
                if (normal is null || origin is null)
                {
                    return double.NaN;
                }

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
                if (normal is null || origin is null)
                {
                    return double.NaN;
                }

                return normal.DotProduct((Vector3D)origin!);
            }
        }

        [JsonIgnore]
        public Vector3D? Normal
        {
            get
            {
                return new(normal);
            }
        }

        [JsonIgnore]
        public Point3D? Origin
        {
            get
            {
                return origin == null ? null : new(origin);
            }
            set
            {
                origin = value;
            }
        }

        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D is null || normal is null)
            {
                return null;
            }

            double factor = ((Vector3D)point3D!).DotProduct(normal) - K;
            return new(point3D.X - (normal.X * factor), point3D.Y - (normal.Y * factor), point3D.Z - (normal.Z * factor));
        }

        public bool Coplanar(Plane? plane, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane?.normal is null || normal is null)
            {
                return false;
            }

            return normal.AlmostEquals(plane?.normal, tolerance) || normal.AlmostEquals(-plane?.normal, tolerance);
        }

        public double Distance(Point3D? point3D)
        {
            if (point3D is null)
            {
                return double.NaN;
            }

            Point3D? closestPoint = ClosestPoint(point3D);
            if (closestPoint == null)
            {
                return double.NaN;
            }

            return closestPoint.Distance(point3D);
        }

        public Vector3D? GetAxis(Enums.SpatialAxis axis)
        {
            return axis switch
            {
                Enums.SpatialAxis.X => AxisX,

                Enums.SpatialAxis.Y => AxisY,

                Enums.SpatialAxis.Z => AxisZ,

                Enums.SpatialAxis.Undefined => null,

                _ => null,
            };
        }

        public bool Flip(Enums.SpatialAxis prmiaryAxis = Enums.SpatialAxis.Z, Enums.SpatialAxis secondaryAxis = Enums.SpatialAxis.X)
        {
            if (prmiaryAxis == secondaryAxis)
            {
                return false;
            }

            if (prmiaryAxis == Enums.SpatialAxis.Z)
            {
                if (secondaryAxis == Enums.SpatialAxis.X)
                {
                    Vector3D? axisX = AxisX;
                    normal?.Inverse();
                    axisY = normal?.CrossProduct(axisX);

                    return true;
                }
                else if (secondaryAxis == Enums.SpatialAxis.Y)
                {
                    normal?.Inverse();

                    return true;
                }
            }
            else if (prmiaryAxis == Enums.SpatialAxis.Y)
            {
                if (secondaryAxis == Enums.SpatialAxis.X)
                {
                    Vector3D? axisX = AxisX;
                    axisY?.Inverse();
                    normal = Query.Normal(axisX, axisY);

                    return true;
                }
                else if (secondaryAxis == Enums.SpatialAxis.Z)
                {
                    axisY?.Inverse();

                    return true;
                }
            }
            else if (prmiaryAxis == Enums.SpatialAxis.X)
            {
                if (secondaryAxis == Enums.SpatialAxis.Y)
                {
                    Vector3D? axisX = AxisX?.GetInversed();
                    normal = Query.Normal(axisX, axisY);

                    return true;
                }
                else if (secondaryAxis == Enums.SpatialAxis.Z)
                {
                    Vector3D? axisX = AxisX?.GetInversed();
                    axisY = normal?.CrossProduct(axisX);

                    return true;
                }
            }

            return false;
        }

        public override bool Move(Vector3D? vector3D)
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