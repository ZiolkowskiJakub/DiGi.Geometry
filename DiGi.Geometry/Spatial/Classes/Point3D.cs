using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Point3D : Coordinate3D, IMovable3D, IPoint<Point3D>
    {
        public Point3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Point3D(double x, double y, double z)
            : base(x, y, z)
        {

        }

        public Point3D(double[] values)
            : base(values)
        {

        }

        public Point3D(Point3D point3D)
            : base(point3D)
        {

        }

        public static implicit operator Point3D((double x, double y, double z) @object)
        {
            return new Point3D(@object.x, @object.y, @object.z);
        }

        public override ISerializableObject Clone()
        {
            return new Point3D(values);
        }

        public double Distance(Point3D point3D)
        {
            if (point3D == null)
            {
                return double.NaN;
            }

            return new Vector3D(this, point3D).Length;
        }

        public Point3D GetMoved(Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            Point3D result = new Point3D(this);
            result.Move(vector3D);

            return result;
        }

        public bool InDistance(Point3D point3D, double distance, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            if (System.Math.Abs(X - point3D.X) > distance + tolerance)
            {
                return false;
            }

            if (System.Math.Abs(Y - point3D.Y) > distance + tolerance)
            {
                return false;
            }

            if (System.Math.Abs(Z - point3D.Z) > distance + tolerance)
            {
                return false;
            }

            return Distance(point3D) < distance - tolerance;

        }

        public Point3D Mid(Point3D point3D)
        {
            if(point3D == null)
            {
                return null;
            }

            return new Point3D((point3D[0] + values[0]) / 2, (point3D[1] + values[1]) / 2, (point3D[2] + values[2]) / 2);
        }
    }
}
