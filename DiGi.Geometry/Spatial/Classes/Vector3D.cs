using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Vector3D : Coordinate3D, IVector
    {
        public Vector3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Vector3D(Vector3D vector3D)
            : base(vector3D)
        {

        }

        public Vector3D(Point3D start, Point3D end)
            : base()
        {
            values = new double[2] { double.NaN, double.NaN };
            if(start != null && end != null)
            {
                values[0] = end[0] - start[0];
                values[1] = end[1] - start[1];
                values[2] = end[2] - start[2];
            }
        }

        public Vector3D(double x, double y, double z)
            : base(x, y, z)
        {

        }

        public Vector3D(double[] values)
            : base(values)
        {

        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return System.Math.Sqrt((values[0] * values[0]) + (values[1] * values[1]) + (values[2] * values[2]));
            }
            set
            {
                Vector3D vector3D = Unit;
                vector3D.Scale(value);
                values = new double[3] { vector3D[0], vector3D[1], vector3D[2] };
            }
        }

        [JsonIgnore]
        public Vector3D Unit
        {
            get
            {
                Vector3D result = new Vector3D(this);
                result.Normalize();

                return result;
            }
        }

        public static explicit operator Vector3D(Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new Vector3D(point3D.X, point3D.Y, point3D.Z);
        }

        public static Vector3D operator -(Vector3D vector3D_1, Vector3D vector3D_2)
        {
            return new Vector3D(vector3D_1.values[0] - vector3D_2.values[0], vector3D_1.values[1] - vector3D_2.values[1], vector3D_1.values[2] - vector3D_2.values[2]);
        }

        public static bool operator !=(Vector3D vector3D_1, Vector3D vector3D_2)
        {
            return vector3D_1?.values[0] != vector3D_2?.values[0] || vector3D_1?.values[1] != vector3D_2?.values[1] || vector3D_1?.values[2] != vector3D_2?.values[2];
        }

        public static double operator *(Vector3D vector3D_1, Vector3D vector3D_2)
        {
            return vector3D_1.values[0] * vector3D_2.values[0] + vector3D_1.values[1] * vector3D_2.values[1] + vector3D_1.values[2] * vector3D_2.values[2];
        }

        public static Vector3D operator *(Vector3D vector3D_1, double factor)
        {
            return new Vector3D(vector3D_1.values[0] * factor, vector3D_1.values[1] * factor, vector3D_1.values[2] * factor);
        }

        public static Vector3D operator *(double factor, Vector3D vector3D_1)
        {
            return new Vector3D(vector3D_1.values[0] * factor, vector3D_1.values[1] * factor, vector3D_1.values[2] * factor);
        }

        public static Vector3D operator /(Vector3D vector3D, double factor)
        {
            return new Vector3D(vector3D.X / factor, vector3D.Y / factor, vector3D.Z / factor);
        }

        public static Vector3D operator +(Vector3D vector3D_1, Vector3D vector3D_2)
        {
            return new Vector3D(vector3D_1.values[0] + vector3D_2.values[0], vector3D_1.values[1] + vector3D_2.values[1], vector3D_1.values[2] + vector3D_2.values[2]);
        }

        public static bool operator ==(Vector3D vector3D_1, Vector3D vector3D_2)
        {
            return vector3D_1?.values[0] == vector3D_2?.values[0] && vector3D_1?.values[1] == vector3D_2?.values[1];
        }

        public override ISerializableObject Clone()
        {
            return new Vector3D(this);
        }

        public void Normalize()
        {
            double length = Length;

            values[0] = values[0] / length;
            values[1] = values[1] / length;
        }

        public bool Collinear(Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (vector3D == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(this * vector3D) - (Length * vector3D.Length)) <= tolerance;
        }

        public double DotProduct(Vector3D vector3D)
        {
            if(vector3D == null)
            {
                return double.NaN;
            }

            return (values[0] * vector3D.values[0]) + (values[1] * vector3D.values[1]) + (values[2] * vector3D.values[2]);
        }

        /// <summary>
        /// Project input Vector onto this Vector
        /// </summary>
        /// <param name="vector3D">Vector to be projected</param>
        /// <returns>Projection vector</returns>
        public Vector3D Project(Vector3D vector3D)
        {
            if(vector3D == null)
            {
                return null;
            }

            Vector3D result = new Vector3D(this);
            result.Scale(vector3D.DotProduct(this) / DotProduct(this));
            return result;
        }
    }
}
