using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static DiGi.Core.Constans.Reference;

namespace DiGi.Geometry.Spatial.Classes
{
    public class CoordinateSystem3D : Geometry3D, ICoordinateSystem3D
    {
        [JsonInclude, JsonPropertyName("AxisY")]
        private Vector3D axisY;

        [JsonInclude, JsonPropertyName("AxisZ")]
        private Vector3D axisZ;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D origin;

        public CoordinateSystem3D(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public CoordinateSystem3D(CoordinateSystem3D coordinateSystem3D)
        {
            if (coordinateSystem3D != null)
            {
                axisZ = new Vector3D(coordinateSystem3D.axisZ);
                origin = new Point3D(coordinateSystem3D.origin);
                axisY = new Vector3D(coordinateSystem3D.axisY);
            }
        }

        public CoordinateSystem3D(CoordinateSystem3D coordinateSystem3D, Point3D origin)
        {
            if (coordinateSystem3D != null)
            {
                axisZ = new Vector3D(coordinateSystem3D.axisZ);
                axisY = new Vector3D(coordinateSystem3D.axisY);
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        public CoordinateSystem3D(Point3D origin, Vector3D axisZ)
        {
            if (axisZ != null)
            {
                this.axisZ = axisZ.Unit;
                axisY = axisZ.AxisY();
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        public CoordinateSystem3D(Point3D origin, Vector3D axisX, Vector3D axisY)
        {
            this.origin = origin == null ? null : new Point3D(origin);

            this.axisY = axisY == null ? null : axisY.Unit;

            if (axisX != null && this.axisY != null)
            {
                axisZ = Query.Normal(axisX.Unit, this.axisY);
            }
        }

        [JsonIgnore]
        public Vector3D AxisX
        {
            get
            {
                return Query.AxisX(axisZ, axisY);
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
                return axisZ == null ? null : new Vector3D(axisZ);
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

            double factor = ((Vector3D)point3D).DotProduct(axisZ) - axisZ.DotProduct((Vector3D)origin);
            return new Point3D(point3D.X - (axisZ.X * factor), point3D.Y - (axisZ.Y * factor), point3D.Z - (axisZ.Z * factor));
        }

        public double Distance(Point3D point3D)
        {
            return ClosestPoint(point3D).Distance(point3D);
        }

        public void Inverse()
        {
            axisZ?.Inverse();
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
