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
            values = new double[3] { double.NaN, double.NaN, double.NaN };
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

        public static implicit operator Vector3D((double x, double y, double z) @object)
        {
            return new Vector3D(@object.x, @object.y, @object.z);
        }

        public static implicit operator Vector3D((Point3D start, Point3D end) @object)
        {
            return new Vector3D(@object.start, @object.end);
        }

        public static Vector3D operator -(Vector3D vector3D_1, Vector3D vector3D_2)
        {
            return new Vector3D(vector3D_1.values[0] - vector3D_2.values[0], vector3D_1.values[1] - vector3D_2.values[1], vector3D_1.values[2] - vector3D_2.values[2]);
        }

        public static Vector3D operator -(Vector3D vector3D)
        {
            Vector3D result = new Vector3D(vector3D);
            result.Inverse();
            return result;
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
            return vector3D_1?.values[0] == vector3D_2?.values[0] && vector3D_1?.values[1] == vector3D_2?.values[1] && vector3D_1?.values[2] == vector3D_2?.values[2];
        }

        //Calculate the dot product as an angle
        //Source: https://wiki.unity3d.com/index.php/3d_Math_functions
        public double Angle(Vector3D vector3D)
        {
            double dotProduct = DotProduct(vector3D);
            double length = Length * vector3D.Length;

            return (System.Math.Abs(dotProduct) < length) ? System.Math.Acos(dotProduct / length) : (dotProduct < 0) ? System.Math.PI : 0;

        }

        public override ISerializableObject Clone()
        {
            return new Vector3D(this);
        }

        public bool Collinear(Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (vector3D == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(this * vector3D) - (Length * vector3D.Length)) <= tolerance;
        }

        /// <summary> The cross product takes two vectors and produces a third vector that is
        /// orthogonal to both. For example, if you have two vectors lying on the World xy-plane,
        /// then their cross product is a vector perpendicular to the xy-plane going either in the
        /// positive or negative World z-axis direction. Sample: a​(a1, a2, a3) and ​b​(b1, b2, b3)
        /// then a​ ​×​ ​b ​=​ ​(a2​ ​*​ ​b3 – a3​ ​*​ ​b2​,​ ​a3​ ​*​ ​b1 - a1​ ​*​ ​b3, a1​ ​*​ ​b2 - a2​ ​*​ ​b1​ ​)
        /// <returns> Cross Product Vector3D </returns> 
        /// <param name="vector3D">A Vector3D</param>
        /// </summary>
        public Vector3D CrossProduct(Vector3D vector3D)
        {
            if (vector3D == null || values == null)
            {
                return null;
            }

            return new Vector3D((values[1] * vector3D.values[2]) - (values[2] * vector3D.values[1]), (values[2] * vector3D.values[0]) - (values[0] * vector3D.values[2]), (values[0] * vector3D.values[1]) - (values[1] * vector3D.values[0]));
        }

        public double DotProduct(Vector3D vector3D)
        {
            if (vector3D == null || values == null)
            {
                return double.NaN;
            }

            return (values[0] * vector3D.values[0]) + (values[1] * vector3D.values[1]) + (values[2] * vector3D.values[2]);
        }

        public Vector3D GetAbs()
        {
            Vector3D result = new Vector3D(this);

            result.Abs();

            return result;
        }

        public Vector3D GetInversed()
        {
            Vector3D result = new Vector3D(this);
            result.Inverse();

            return result;
        }

        public double MinAngle(Vector3D vector3D)
        {
            double value = System.Math.Abs(Angle(vector3D));
            if (value == 0)
            {
                return value;
            }

            return System.Math.Min(System.Math.PI - value, value);
        }

        public void Normalize()
        {
            double length = Length;

            values[0] = values[0] / length;
            values[1] = values[1] / length;
            values[2] = values[2] / length;
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
