using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Coordinate2D : Coordinate, IGeometry2D, ITransformable2D
    {
        public Coordinate2D(JsonObject jsonObject)
            : base(jsonObject, 2)
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

        public bool Transform(Transform2D transform)
        {
            Matrix3D matrix3D = transform?.Matrix3D;
            if (matrix3D == null)
            {
                return false;
            }

            Matrix matrix = matrix3D * ArgumentedMatrix;
            if (matrix == null)
            {
                return false;
            }

            values[0] = matrix[0, 0];
            values[1] = matrix[1, 0];
            return true;
        }
    }
}
