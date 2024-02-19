using DiGi.Core.Interfaces;
using NetTopologySuite.Algorithm;
using NetTopologySuite.Geometries;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Vector2D : Coordinate2D
    {
        public Vector2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Vector2D(Vector2D vector2D)
            : base(vector2D)
        {

        }

        public Vector2D(double x, double y)
            : base(x, y)
        {

        }

        public Vector2D(double[] values)
            : base(values)
        {

        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return System.Math.Sqrt((values[0] * values[0]) + (values[1] * values[1]));
            }
            set
            {
                Vector2D vector2D = new Vector2D(this);
                vector2D.Scale(value);
                values = new double[2] { vector2D[0], vector2D[1] };
            }
        }

        [JsonIgnore]
        public Vector2D Unit
        {
            get
            {
                Vector2D result = new Vector2D(this);
                result.Normalize();

                return result;
            }
        }

        public static implicit operator Vector2D(Point2D point2D)
        {
            if (point2D == null)
                return null;

            return new Vector2D(point2D.X, point2D.Y);
        }

        public static Vector2D operator -(Vector2D vector2D_1, Vector2D vector2D_2)
        {
            return new Vector2D(vector2D_1.values[0] - vector2D_2.values[0], vector2D_1.values[1] - vector2D_2.values[1]);
        }

        public static bool operator !=(Vector2D vector2D_1, Vector2D vector2D_2)
        {
            return vector2D_1?.values[0] != vector2D_2?.values[0] || vector2D_1?.values[1] != vector2D_2?.values[1];
        }

        public static double operator *(Vector2D vector2D_1, Vector2D vector2D_2)
        {
            return vector2D_1.values[0] * vector2D_2.values[0] + vector2D_1.values[1] * vector2D_2.values[1];
        }

        public static Vector2D operator *(Vector2D vector2D_1, double factor)
        {
            return new Vector2D(vector2D_1.values[0] * factor, vector2D_1.values[1] * factor);
        }

        public static Vector2D operator *(double factor, Vector2D vector2D_1)
        {
            return new Vector2D(vector2D_1.values[0] * factor, vector2D_1.values[1] * factor);
        }

        public static Vector2D operator /(Vector2D vector2D, double factor)
        {
            return new Vector2D(vector2D.X / factor, vector2D.Y / factor);
        }

        public static Vector2D operator +(Vector2D vector2D_1, Vector2D vector2D_2)
        {
            return new Vector2D(vector2D_1.values[0] + vector2D_2.values[0], vector2D_1.values[1] + vector2D_2.values[1]);
        }

        public static bool operator ==(Vector2D vector2D_1, Vector2D vector2D_2)
        {
            return vector2D_1?.values[0] == vector2D_2?.values[0] && vector2D_1?.values[1] == vector2D_2?.values[1];
        }

        public override ISerializableObject Clone()
        {
            return new Vector2D(values);
        }

        public void Normalize()
        {
            double length = Length;

            values[0] = values[0] / length;
            values[1] = values[1] / length;
        }
    }
}
