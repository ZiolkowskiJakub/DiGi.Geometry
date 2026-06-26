using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a specified <see cref="Point3D"/> is within the range of the provided <see cref="IPlanar{T}"/> geometry, considering a given tolerance.
        /// </summary>
        /// <typeparam name="T">The type of polygonal geometry, which must implement <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> object to check against.</param>
        /// <param name="point3D">The <see cref="Point3D"/> point to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="Point3D"/> is within range; otherwise, false.</returns>
        public static bool InRange<T>(IPlanar<T> planar, Point3D point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D
        {
            if (planar == null || point3D == null)
            {
                return false;
            }

            IPolygonal2D? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
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

            Point2D? point2D = plane.Convert(point3D);
            if (point2D == null)
            {
                return false;
            }

            return polygonal2D.InRange(point2D, tolerance);
        }

        /// <summary>
        /// Determines whether a collection of <see cref="Point3D"/> objects are within the range of the specified <see cref="IPlanar{T}"/> object.
        /// </summary>
        /// <typeparam name="T">The type of polygonal geometry, which must implement <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> object to check against.</param>
        /// <param name="point3Ds">An <see cref="IEnumerable{Point3D}"/> containing the points to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the points are within range; otherwise, <c>false</c>.</returns>
        public static bool InRange<T>(IPlanar<T>? planar, IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D
        {
            if (point3Ds == null || planar == null)
            {
                return false;
            }

            IPolygonal2D? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
            }

            Plane? plane = planar.Plane;
            if (plane == null)
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
                    continue;
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
                if (!polygonal2D.InRange(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether a segmentable 3D entity is within the range of a planar entity.
        /// </summary>
        /// <typeparam name="T">The type that implements <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> object to check against.</param>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the segmentable 3D entity is within range; otherwise, <c>false</c>.</returns>
        public static bool InRange<T>(IPlanar<T> planar, ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D
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
                    continue;
                }

                if (!plane.On(segment3D.Start, tolerance) || !plane.On(segment3D.End, tolerance))
                {
                    return false;
                }

                Segment2D? segment2D = plane.Convert(segment3D);
                if (segment2D == null)
                {
                    return false;
                }

                if (!polygonal2D.InRange(segment2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}