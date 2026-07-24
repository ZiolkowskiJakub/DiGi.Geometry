using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Plane"/> from three specified <see cref="Point3D"/> points.
        /// </summary>
        /// <param name="point3D_1">The first <see cref="Point3D"/> point.</param>
        /// <param name="point3D_2">The second <see cref="Point3D"/> point.</param>
        /// <param name="point3D_3">The third <see cref="Point3D"/> point.</param>
        /// <returns>A <see cref="Classes.Plane"/> if the points are valid and not collinear; otherwise, null.</returns>
        public static Plane? Plane(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return null;
            }

            Vector3D? normal = Query.Normal(point3D_1, point3D_2, point3D_3);
            if (normal == null)
            {
                return null;
            }

            Point3D point3D_Origin = new((point3D_1.X + point3D_2.X + point3D_3.X) / 3.0, (point3D_1.Y + point3D_2.Y + point3D_3.Y) / 3.0, (point3D_1.Z + point3D_2.Z + point3D_3.Z) / 3.0);
            return new Plane(point3D_Origin, normal);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Plane"/> from a collection of <see cref="Point3D"/> points using the specified tolerance.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> points used to define the plane.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for calculating the normal vector.</param>
        /// <returns>A <see cref="Classes.Plane"/> if a valid plane can be constructed from the provided points; otherwise, null.</returns>
        public static Plane? Plane(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Vector3D? normal = Query.Normal(point3Ds, tolerance);
            if (normal == null)
            {
                return null;
            }

            return new Plane(point3Ds.Average(), normal);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Plane"/> defined by an origin point and two axes.
        /// </summary>
        /// <param name="origin">The <see cref="Point3D"/> that defines the origin of the plane.</param>
        /// <param name="axisX">The <see cref="Vector3D"/> that defines the X-axis of the plane.</param>
        /// <param name="axisY">The <see cref="Vector3D"/> that defines the Y-axis of the plane.</param>
        /// <returns>A <see cref="Classes.Plane"/> instance if all parameters are non-null; otherwise, null.</returns>
        public static Plane? Plane(Point3D? origin, Vector3D? axisX, Vector3D? axisY)
        {
            if (origin == null || axisX == null || axisY == null)
            {
                return null;
            }

            return new Plane(origin, axisX, axisY);
        }

        /// <summary>
        /// Creates a plane at the specified elevation along the Z-axis.
        /// </summary>
        /// <param name="elevation">The double value representing the elevation of the plane.</param>
        /// <returns>A Plane object positioned at the given elevation, or null if the provided double is NaN.</returns>
        public static Plane? Plane(double elevation)
        {
            if (double.IsNaN(elevation))
            {
                return null;
            }

            return new Plane(new Point3D(0.0, 0.0, elevation), Constants.Vector3D.WorldZ);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Plane"/> based on the World Z axis at the specified origin point.
        /// </summary>
        /// <param name="origin">The <see cref="Point3D"/> representing the origin of the plane. If null, the method returns null.</param>
        /// <returns>A <see cref="Classes.Plane"/> instance if a valid <see cref="Point3D"/> is provided; otherwise, null.</returns>
        public static Plane? Plane(Point3D? origin)
        {
            if (origin == null)
            {
                return null;
            }

            return new Plane(Constants.Plane.WorldZ, origin);
        }

        /// <summary>
        /// Creates a plane perpendicular to the specified axis and offsets it by the given value.
        /// </summary>
        /// <param name="value">The distance of type <see cref="double"/> to move the plane along the axis.</param>
        /// <param name="dimensionIndex">The index of type <see cref="int"/> representing the dimension (0 for X, 1 for Y, 2 for Z).</param>
        /// <returns>A <see cref="Classes.Plane"/> object shifted by the value, or null if the <paramref name="dimensionIndex"/> is not a valid axis index.</returns>
        public static Plane? Plane(double value, int dimensionIndex)
        {
            if (double.IsNaN(value))
            {
                return null;
            }

            switch (dimensionIndex)
            {
                case 0:
                    return new Plane(new Point3D(value, 0.0, 0.0), Constants.Vector3D.WorldX);

                case 1:
                    return new Plane(new Point3D(0.0, value, 0.0), Constants.Vector3D.WorldY);

                case 2:
                    return new Plane(new Point3D(0.0, 0.0, value), Constants.Vector3D.WorldZ);
            }

            return null;
        }
    }
}