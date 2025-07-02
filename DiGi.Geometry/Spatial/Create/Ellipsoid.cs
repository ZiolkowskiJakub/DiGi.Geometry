using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Ellipsoid Ellipsoid(Point3D focalPoint_1, Point3D focalPoint_2, double b, double c, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(focalPoint_1 == null || focalPoint_2 == null || double.IsNaN(b) || double.IsNaN(c))
            {
                return null;
            }

            double e = focalPoint_1.Distance(focalPoint_2) / 2;
            if(double.IsNaN(e))
            {
                return null;
            }

            double a = System.Math.Sqrt(b * b + e * e);

            if(a < b || a < c)
            {
                return null;
            }

            Vector3D axisX = new Vector3D(focalPoint_2, focalPoint_1).Unit;
            
            Vector3D axisY = axisX.Similar(Constans.Vector3D.WorldZ, tolerance) ? axisX.CrossProduct(Constans.Vector3D.WorldY).Unit : axisX.CrossProduct(Constans.Vector3D.WorldZ).Unit;

            Plane plane = new Plane(focalPoint_1.Mid(focalPoint_2), axisX, axisY);

            return new Ellipsoid(plane, a, b, c);
        }
    }
}
