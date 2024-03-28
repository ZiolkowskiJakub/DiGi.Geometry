using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class Coordinate3D : Coordinate, IGeometry3D, ITransformable3D
    {
        public Coordinate3D(JsonObject jsonObject)
            : base(jsonObject, 3)
        {

        }

        public Coordinate3D(double x, double y, double z)
            : base(x, y, z)
        {

        }

        public Coordinate3D()
            : base()
        {

        }

        public Coordinate3D(Coordinate3D coordinate3D)
            : base(coordinate3D)
        {

        }

        public Coordinate3D(double[] values)
            : base()
        {
            this.values = new double[3];
            if (values == null || values.Length < 3)
            {
                this.values[0] = double.NaN;
                this.values[1] = double.NaN;
                this.values[2] = double.NaN;
            }
            else
            {
                this.values[0] = values[0];
                this.values[1] = values[1];
                this.values[2] = values[2];
            }
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

        public double Z
        {
            get
            {
                return values[2];
            }

            set
            {
                values[2] = value;
            }
        }

        public bool Move(Vector3D vector3D)
        {
            if (vector3D == null || values == null || values.Length < 2)
            {
                return false;
            }

            values[0] += vector3D[0];
            values[1] += vector3D[1];
            values[2] += vector3D[2];
            return true;
        }

        public bool Transform(ITransform3D transform)
        {
            if (transform == null || values == null || values.Length < 2)
            {
                return false;
            }

            if (transform is Transform3D)
            {
                Matrix4D matrix4D = ((Transform3D)transform)?.Matrix4D;
                if (matrix4D == null)
                {
                    return false;
                }

                Matrix matrix = matrix4D * ArgumentedMatrix;
                if (matrix == null)
                {
                    return false;
                }

                values[0] = matrix[0, 0];
                values[1] = matrix[1, 0];
                values[2] = matrix[2, 0];
                return true;
            }

            if (transform is TransformGroup3D)
            {
                foreach (ITransform3D transform_Temp in (TransformGroup3D)transform)
                {
                    if (transform_Temp == null)
                    {
                        continue;
                    }

                    Transform(transform_Temp);
                }

                return true;
            }

            return false;
        }
    }
}
