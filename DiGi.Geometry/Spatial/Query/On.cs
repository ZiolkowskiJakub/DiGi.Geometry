using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is on any of the segments of the <see cref="ISegmentable3D"/> object within a given tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> instance to check.</param>
        /// <param name="point3D">The <see cref="Point3D"/> point to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="Point3D"/> is on any of the segments within the specified tolerance; otherwise, false.</returns>
        public static bool On(this ISegmentable3D? segmentable3D, Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || segmentable3D == null)
            {
                return false;
            }

            if (segmentable3D is Segment3D segment3D)
            {
                return segment3D.On(point3D, tolerance);
            }

            List<Segment3D>? segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return false;
            }

            for (int int_I = 0; int_I < segment3Ds.Count; int_I++)
            {
                if (segment3Ds[int_I].On(point3D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether a specified <see cref="Point3D"/> lies on the <see cref="Plane"/> within a given tolerance.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check.</param>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on the plane within the specified tolerance; otherwise, false if either the plane or point is null.</returns>
        public static bool On(this Plane? plane, Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || plane == null)
            {
                return false;
            }

            double double_A = plane.A;
            double double_B = plane.B;
            double double_C = plane.C;
            double double_D = plane.D;

            if (double.IsNaN(double_A) || double.IsNaN(double_B) || double.IsNaN(double_C) || double.IsNaN(double_D))
            {
                return false;
            }

            return System.Math.Abs(double_A * point3D.X + double_B * point3D.Y + double_C * point3D.Z + double_D) < tolerance;
        }

        /// <summary>
        /// Determines whether a <see cref="Segment3D"/> lies on a <see cref="Plane"/> within a specified tolerance.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check against.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the segment is on the plane; otherwise, <c>false</c>.</returns>
        public static bool On(this Plane? plane, Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || segment3D == null)
            {
                return false;
            }

            return plane.On(segment3D.Start, tolerance) && plane.On(segment3D.End, tolerance);
        }

        /// <summary>
        /// Determines whether an <see cref="ISegmentable3D"/> object lies on a <see cref="Plane"/> within a specified tolerance.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check against.</param>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> indicating whether all points of the <see cref="ISegmentable3D"/> object are on the <see cref="Plane"/>.</returns>
        public static bool On(this Plane? plane, ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || segmentable3D == null)
            {
                return false;
            }

            List<Point3D>? point3Ds = segmentable3D.GetPoints();
            if (point3Ds == null)
            {
                return false;
            }

            for (int i = 0; i < point3Ds.Count; i++)
            {
                if (!plane.On(point3Ds[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified <c>Vector3D?</c> lies on the <c>Plane?</c> within a given tolerance.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check.</param>
        /// <param name="vector3D">The <c>Vector3D?</c> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> indicating whether the <c>Vector3D?</c> is on the <c>Plane?</c>.</returns>
        public static bool On(this Plane? plane, Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || vector3D == null)
            {
                return false;
            }

            double double_A = plane.A;
            double double_B = plane.B;
            double double_C = plane.C;

            if (double.IsNaN(double_A) || double.IsNaN(double_B) || double.IsNaN(double_C))
            {
                return false;
            }

            double double_Dot = vector3D.X * double_A + vector3D.Y * double_B + vector3D.Z * double_C;

            double double_ProjX = vector3D.X - double_Dot * double_A;
            double double_ProjY = vector3D.Y - double_Dot * double_B;
            double double_ProjZ = vector3D.Z - double_Dot * double_C;

            double double_LenOrig = System.Math.Sqrt(vector3D.X * vector3D.X + vector3D.Y * vector3D.Y + vector3D.Z * vector3D.Z);
            double double_LenProj = System.Math.Sqrt(double_ProjX * double_ProjX + double_ProjY * double_ProjY + double_ProjZ * double_ProjZ);

            return System.Math.Abs(double_LenOrig - double_LenProj) < tolerance;
        }
    }
}