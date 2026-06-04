using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an <see cref="Ellipsoid"/> based on two focal points and two semi-minor axes.
        /// </summary>
        /// <param name="focalPoint_1">The first <see cref="Point3D"/> representing a focal point of the ellipsoid.</param>
        /// <param name="focalPoint_2">The second <see cref="Point3D"/> representing a focal point of the ellipsoid.</param>
        /// <param name="b">A <see cref="double"/> value representing one of the semi-minor axes.</param>
        /// <param name="c">A <see cref="double"/> value representing another semi-minor axis.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance.</param>
        /// <returns>An <see cref="Ellipsoid"/> object if the parameters are valid and a valid ellipsoid can be constructed; otherwise, null.</returns>
        public static Ellipsoid? Ellipsoid(Point3D? focalPoint_1, Point3D? focalPoint_2, double b, double c, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (focalPoint_1 == null || focalPoint_2 == null || double.IsNaN(b) || double.IsNaN(c))
            {
                return null;
            }

            double e = focalPoint_1.Distance(focalPoint_2) / 2;
            if (double.IsNaN(e))
            {
                return null;
            }

            double a = System.Math.Sqrt(b * b + e * e);

            if (a < b || a < c)
            {
                return null;
            }

            Vector3D? axisX = new Vector3D(focalPoint_2, focalPoint_1)?.Unit;
            if (axisX == null)
            {
                return null;
            }

            Vector3D? axisY = axisX.Similar(Constants.Vector3D.WorldZ, tolerance) ? axisX.CrossProduct(Constants.Vector3D.WorldY)?.Unit : axisX.CrossProduct(Constants.Vector3D.WorldZ)?.Unit;

            Plane plane = new(focalPoint_1.Mid(focalPoint_2), axisX, axisY);

            return new Ellipsoid(plane, a, b, c);
        }
    }
}