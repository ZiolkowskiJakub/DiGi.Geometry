using DiGi.Geometry.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Coordinate2D : Coordinate
    {
        public Coordinate2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Coordinate2D(double x, double y)
            : base(x, y)
        {

        }

        public Coordinate2D(double[] values)
            : base()
        {
            this.values = new double[2];
            if (values == null || values.Length < 2)
            {
                this.values[0] = double.NaN;
                this.values[1] = double.NaN;
            }
            else
            {
                this.values[0] = values[0];
                this.values[1] = values[1];
            }
        }

        public Coordinate2D(Coordinate2D coordinate2D)
            :base(coordinate2D)
        {

        }

        public Coordinate2D()
            : base(0, 0)
        {

        }

        public double X
        {
            get
            {
                return values[0];
            }

            set
            {
                values[0] = value;
            }
        }

        public double Y
        {
            get
            {
                return values[1];
            }

            set
            {
                values[1] = value;
            }
        }
    }
}
