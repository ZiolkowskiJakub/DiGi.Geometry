using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Vector2D : Coordinate2D, IVector
    {
        public Vector2D(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Vector2D(Vector2D? vector2D)
            : base(vector2D)
        {

        }

        public Vector2D(Point2D? start, Point2D? end)
            : base()
        {
            values = [double.NaN, double.NaN];
            if(start != null && end != null)
            {
                values[0] = end[0] - start[0];
                values[1] = end[1] - start[1];
            }
        }

        public Vector2D(double x, double y)
            : base(x, y)
        {

        }

        public Vector2D(double[]? values)
            : base(values)
        {

        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return System.Math.Sqrt(SquaredLength);
            }
            set
            {
                Vector2D? vector2D = Unit;
                vector2D?.Scale(value);
                if(vector2D is null)
                {
                    return;
                }

                values = [vector2D[0], vector2D[1]];
            }
        }

        [JsonIgnore]
        public double SquaredLength
        {
            get
            {
                return (values[0] * values[0]) + (values[1] * values[1]);
            }
        }

        [JsonIgnore]
        public Vector2D? Unit
        {
            get
            {
                Vector2D result = new (this);
                result.Normalize();

                return result;
            }
        }

        public static explicit operator Vector2D?(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new (point2D.X, point2D.Y);
        }

        public static implicit operator Vector2D?((double x, double y) @object)
        {
            return new (@object.x, @object.y);
        }

        public static implicit operator Vector2D?((Point2D? start, Point2D? end) @object)
        {
            return new (@object.start, @object.end);
        }

        public static Vector2D? operator -(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if(vector2D_1 is null || vector2D_2 is null)
            {
                return null;
            }

            return new (vector2D_1.values[0] - vector2D_2.values[0], vector2D_1.values[1] - vector2D_2.values[1]);
        }

        public static bool operator !=(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            return vector2D_1?.values[0] != vector2D_2?.values[0] || vector2D_1?.values[1] != vector2D_2?.values[1];
        }

        public static double operator *(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if(vector2D_1 is null || vector2D_2 is null)
            {
                return double.NaN;
            }

            return vector2D_1.values[0] * vector2D_2.values[0] + vector2D_1.values[1] * vector2D_2.values[1];
        }

        public static Vector2D? operator *(Vector2D? vector2D, double factor)
        {
            if(vector2D is null)
            {
                return null;
            }

            return new (vector2D.values[0] * factor, vector2D.values[1] * factor);
        }

        public static Vector2D? operator *(double factor, Vector2D? vector2D)
        {
            if (vector2D is null)
            {
                return null;
            }

            return new (vector2D.values[0] * factor, vector2D.values[1] * factor);
        }

        public static Vector2D? operator /(Vector2D? vector2D, double factor)
        {
            if (vector2D is null)
            {
                return null;
            }

            return new (vector2D.X / factor, vector2D.Y / factor);
        }

        public static Vector2D? operator +(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (vector2D_1 is null || vector2D_2 is null)
            {
                return null;
            }

            return new (vector2D_1.values[0] + vector2D_2.values[0], vector2D_1.values[1] + vector2D_2.values[1]);
        }

        public static bool operator ==(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (vector2D_1 is null && vector2D_2 is null)
            {
                return true;
            }

            if (vector2D_1 is null || vector2D_2 is null)
            {
                return false;
            }

            return vector2D_1?.values[0] == vector2D_2?.values[0] && vector2D_1?.values[1] == vector2D_2?.values[1];
        }
        
        /// <summary>
        /// Calculate the dot product as an angle
        /// Source: https://wiki.unity3d.com/index.php/3d_Math_functions
        /// </summary>
        /// <param name="vector2D">Vector2D</param>
        /// <returns>Angle in radians</returns>
        public double Angle(Vector2D? vector2D)
        {
            Vector2D? unit = Unit;
            if(unit is null)
            {
                return double.NaN;
            }

            //Get the dot product
            double dotProduct = unit.DotProduct(vector2D?.Unit);

            //Clamp to prevent NaN error. Shouldn't need this in the first place, but there could be a rounding error issue.
            if (dotProduct < -1)
            {
                dotProduct = -1;
            }
            else if (dotProduct > 1)
            {
                dotProduct = 1;
            }

            //Calculate the angle. The output is in radians
            return System.Math.Acos(dotProduct);

            //double result = System.Math.Acos(DotProduct(vector2D) / (Length * vector2D.Length));
            //if (double.IsNaN(result))
            //    result = 0;

            //return result;
        }

        public override ISerializableObject Clone()
        {
            return new Vector2D(this);
        }

        public bool Collinear(Vector2D vector2D, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (vector2D == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(this * vector2D) - (Length * vector2D.Length)) <= tolerance;
        }

        public double DotProduct(Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return double.NaN;
            }

            return (values[0] * vector2D.values[0]) + (values[1] * vector2D.values[1]);
        }

        public Vector2D GetAbs()
        {
            Vector2D result = new (this);

            result.Abs();

            return result;
        }

        public Vector2D GetInversed()
        {
            Vector2D result = new (this);
            result.Inverse();

            return result;
        }

        public Vector2D? GetPerpendicular(Orientation orientation = Orientation.Clockwise)
        {
            return orientation switch
            {
                Orientation.Clockwise => new Vector2D(values[1], -values[0]),
                Orientation.CounterClockwise => new Vector2D(-values[1], values[0]),
                Orientation.Undefined => null,
                Orientation.Collinear => null,
                _ => null,
            };
        }

        public void Normalize()
        {
            double length = Length;

            values[0] = values[0] / length;
            values[1] = values[1] / length;
        }
        
        public Point2D? Project(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            if (values[0] == 0)
            {
                return new Point2D(0, point2D.Y);
            }

            if (values[1] == 0)
            {
                return new Point2D(point2D.X, 0);
            }

            double m = values[1] / values[0];

            double x = (m * point2D.Y + point2D.X - m * 0) / (m * m + 1);
            double y = (m * m * point2D.Y + m * point2D.X) / (m * m + 1);

            return new Point2D(x, y);
        }

        /// <summary>
        /// Project input Vector onto this Vector
        /// </summary>
        /// <param name="vector2D">Vector to be projected</param>
        /// <returns>Projection vector</returns>
        public Vector2D? Project(Vector2D? vector2D)
        {
            if(vector2D == null)
            {
                return null;
            }

            Vector2D result = new (this);
            result.Scale(vector2D.DotProduct(this) / DotProduct(this));
            return result;
        }

        public override bool Equals(object? obj)
        {
            return obj is Vector2D d &&
                   base.Equals(obj) &&
                   EqualityComparer<double[]>.Default.Equals(values, d.values);
        }

        public override int GetHashCode()
        {
            int hashCode = 1501109969;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<double[]>.Default.GetHashCode(values);
            return hashCode;
        }
    }
}
