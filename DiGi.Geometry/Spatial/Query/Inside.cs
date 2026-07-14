using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a specified <see cref="Point3D"/> is inside the given <see cref="IPlanar{T}"/> object within a certain tolerance.
        /// </summary>
        /// <typeparam name="T">The type of the polygonal 2D object, which must implement <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> object to check against.</param>
        /// <param name="point3D">The <see cref="Point3D"/> point to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the operation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="Point3D"/> is inside the <see cref="IPlanar{T}"/> object; otherwise, false if either parameter is null.</returns>
        public static bool Inside<T>(IPlanar<T>? planar, Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D
        {
            if (planar == null || point3D == null)
            {
                return false;
            }

            if (planar is Triangle3D triangle3D)
            {
                return triangle3D.Inside(point3D, tolerance);
            }

            Plane? plane = planar.Plane;
            if (plane == null)
            {
                return false;
            }

            if (!plane.On(point3D, tolerance))
            {
                return false;
            }

            IPolygonal2D? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
            }

            Point2D? point2D = plane.Convert(point3D);
            if (point2D == null)
            {
                return false;
            }

            return polygonal2D.Inside(point2D, tolerance);
        }

        /// <summary>
        /// Determines whether a collection of <see cref="Point3D"/> points are located on the plane of the specified <see cref="IPlanar{T}"/> object within a given tolerance.
        /// </summary>
        /// <typeparam name="T">A type that implements <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> object whose plane is being evaluated.</param>
        /// <param name="point3Ds">An <see cref="IEnumerable{Point3D}"/> containing the points to check.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the operation.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if all provided points are on the plane within the specified tolerance; otherwise, <c>false</c>.</returns>
        public static bool Inside<T>(IPlanar<T>? planar, IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D
        {
            if (point3Ds == null || planar == null)
            {
                return false;
            }

            if (planar is Triangle3D triangle3D)
            {
                foreach (Point3D point3D in point3Ds)
                {
                    if (point3D == null || !triangle3D.Inside(point3D, tolerance))
                    {
                        return false;
                    }
                }

                return true;
            }

            Plane? plane = planar.Plane;
            if (plane == null)
            {
                return false;
            }

            IPolygonal2D? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
            }

            Vector3D? vector3D_PlaneNormal = plane.Normal;
            Vector3D? vector3D_AxisX = plane.AxisX;
            Vector3D? vector3D_AxisY = plane.AxisY;
            Point3D? point3D_PlaneOrigin = plane.Origin;

            if (vector3D_PlaneNormal == null || vector3D_AxisX == null || vector3D_AxisY == null || point3D_PlaneOrigin == null)
            {
                return false;
            }

            double double_NormalX = vector3D_PlaneNormal.X;
            double double_NormalY = vector3D_PlaneNormal.Y;
            double double_NormalZ = vector3D_PlaneNormal.Z;

            double double_AxisXX = vector3D_AxisX.X;
            double double_AxisXY = vector3D_AxisX.Y;
            double double_AxisXZ = vector3D_AxisX.Z;

            double double_AxisYX = vector3D_AxisY.X;
            double double_AxisYY = vector3D_AxisY.Y;
            double double_AxisYZ = vector3D_AxisY.Z;

            double double_OriginX = point3D_PlaneOrigin.X;
            double double_OriginY = point3D_PlaneOrigin.Y;
            double double_OriginZ = point3D_PlaneOrigin.Z;

            foreach (Point3D point3D in point3Ds)
            {
                if (point3D == null)
                {
                    return false;
                }

                double double_Dx = point3D.X - double_OriginX;
                double double_Dy = point3D.Y - double_OriginY;
                double double_Dz = point3D.Z - double_OriginZ;

                double double_Dot = (double_NormalX * double_Dx) +
                                    (double_NormalY * double_Dy) +
                                    (double_NormalZ * double_Dz);

                if (System.Math.Abs(double_Dot) >= tolerance)
                {
                    return false;
                }

                double double_ProjX = (double_AxisXX * double_Dx) + (double_AxisXY * double_Dy) + (double_AxisXZ * double_Dz);
                double double_ProjY = (double_AxisYX * double_Dx) + (double_AxisYY * double_Dy) + (double_AxisYZ * double_Dz);

                Point2D point2D = new(double_ProjX, double_ProjY);
                if (!polygonal2D.Inside(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether a specified <see cref="ISegmentable3D"/> object is located inside a specified <see cref="IPlanar{T}"/> planar region within a given tolerance.
        /// </summary>
        /// <typeparam name="T">A type that implements <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> planar region to check against.</param>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the operation.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the <see cref="ISegmentable3D"/> object is inside the planar region; otherwise, <c>false</c>.</returns>
        public static bool Inside<T>(IPlanar<T>? planar, ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D
        {
            if (planar == null || segmentable3D == null)
            {
                return false;
            }

            Plane? plane = planar.Plane;
            if (plane == null)
            {
                return false;
            }

            IPolygonal2D? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
            }

            List<Segment3D>? segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return false;
            }

            for (int int_I = 0; int_I < segment3Ds.Count; int_I++)
            {
                Segment3D segment3D = segment3Ds[int_I];
                if (segment3D == null)
                {
                    return false;
                }

                if (!plane.On(segment3D, tolerance))
                {
                    return false;
                }

                Segment2D? segment2D = plane.Convert(segment3D);
                if (segment2D == null)
                {
                    return false;
                }

                if (!polygonal2D.Inside(segment2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether a point is located inside the triangle formed by three points within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> point to check.</param>
        /// <param name="point3D_1">The first vertex of the triangle.</param>
        /// <param name="point3D_2">The second vertex of the triangle.</param>
        /// <param name="point3D_3">The third vertex of the triangle.</param>
        /// <param name="tolerance">The distance tolerance value.</param>
        /// <returns>True if the point lies inside or on the boundary of the triangle; otherwise, false.</returns>
        public static bool Inside(this Point3D? point3D, Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return false;
            }

            Vector3D ab = new(point3D_1, point3D_2);
            Vector3D ac = new(point3D_1, point3D_3);
            Vector3D ap = new(point3D_1, point3D);

            Vector3D? crossProduct = ab.CrossProduct(ac);
            if (crossProduct == null)
            {
                return false;
            }

            double squaredLength = crossProduct.SquaredLength;
            double squaredTolerance = tolerance * tolerance;

            if (squaredLength <= squaredTolerance)
            {
                return false;
            }

            Vector3D? unitNormal = crossProduct.Unit;
            if (unitNormal == null)
            {
                return false;
            }

            double signedDistance = ap.DotProduct(unitNormal);

            if (System.Math.Abs(signedDistance) > tolerance)
            {
                return false;
            }

            double dot00 = ab.DotProduct(ab);
            double dot01 = ab.DotProduct(ac);
            double dot02 = ab.DotProduct(ap);
            double dot11 = ac.DotProduct(ac);
            double dot12 = ac.DotProduct(ap);

            double denom = dot00 * dot11 - dot01 * dot01;
            if (System.Math.Abs(denom) < 1e-15)
            {
                return false;
            }

            double invDenom = 1.0 / denom;
            double u = (dot11 * dot02 - dot01 * dot12) * invDenom;
            double v = (dot00 * dot12 - dot01 * dot02) * invDenom;
            double w = 1.0 - u - v;

            return (u >= -tolerance && u <= 1.0 + tolerance) &&
                   (v >= -tolerance && v <= 1.0 + tolerance) &&
                   (w >= -tolerance && w <= 1.0 + tolerance);
        }
    }
}