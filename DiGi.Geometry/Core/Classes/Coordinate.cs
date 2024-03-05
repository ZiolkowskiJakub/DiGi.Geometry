using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class Coordinate : SerializableObject, IGeometry, IInvertible
    {
        protected double[] values;

        public Coordinate(params double[] values)
        {
            if (values != null)
            {
                this.values = new double[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    this.values[i] = values[i];
                }
            }
        }

        public Coordinate(JsonObject jsonObject, int length)
            : base()
        {
            values = new double[length];
            FromJsonObject(jsonObject);
        }

        public Coordinate(Coordinate coordinate)
            : this(coordinate?.values)
        {

        }

        [JsonIgnore]
        public double this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }

        public void Scale(double value)
        {
            if (double.IsNaN(value) || values == null)
            {
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] *= value;
            }
        }

        public void Inverse()
        {
            if (values == null)
            {
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = -values[i];
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                if(values == null)
                {
                    return -1;
                }
                
                int result = 19;
                for(int i=0; i < values.Length; i++)
                {
                    result = result * 31 + values[i].GetHashCode();
                }
                return result;
            }
        }

        public override bool Equals(object @object)
        {
            if(GetType() != @object?.GetType())
            {
                return false;
            }

            return this == (Coordinate)@object;
        }

        public void Round(double tolerance)
        {
            if(values == null)
            {
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Query.Round(values[i], tolerance); 
            }
        }

        public bool AlmostEqual(Coordinate coordinate, double tolerance = Constans.Tolerance.Distance)
        {
            if (this == coordinate)
            {
                return true;
            }
               
            if (coordinate?.GetType() == GetType())
            {
                return false;
            }

            double[] values = coordinate.values;
            if(this.values == values)
            {
                return true;
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (Query.AlmostEqual( this.values[i], values[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(Coordinate coordinate_1, Coordinate coordinate_2)
        {
            if(coordinate_1?.GetType() != coordinate_2?.GetType())
            {
                return false;
            }
            
            double[] values_1 = coordinate_1?.values;
            double[] values_2 = coordinate_2?.values;

            if(values_1 == values_2)
            {
                return true;
            }

            if(values_1.Length != values_2.Length)
            {
                return false;
            }

            for(int i =0; i < values_1.Length; i++)
            {
                if (values_1[i] != values_2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(Coordinate coordinate_1, Coordinate coordinate_2)
        {
            return !(coordinate_1 == coordinate_2);
        }

        public override string ToString()
        {
            if (values == null)
            {
                return string.Empty;
            }

            return string.Format("[{0}]", string.Join(";", values));
        }

        [JsonIgnore]
        public Matrix ArgumentedMatrix
        {
            get
            {
                if(values == null)
                {
                    return null;
                }

                int length = values.Length;

                double[,] values_Temp = new double[length + 1, 1];
                for (int i = 0; i < length; i++)
                {
                    values_Temp[i, 0] = values[i];
                }

                values_Temp[length, 0] = 1;

                return new Matrix(values_Temp);


                //return new Matrix(new double[,] { { coordinates[0] }, { coordinates[1] }, { coordinates[2] }, { 1 } });
            }
        }
    }
}
