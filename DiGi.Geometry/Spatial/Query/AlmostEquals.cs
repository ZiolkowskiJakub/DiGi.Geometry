using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two <c>Point3D?</c> points are approximately equal based on a specified distance tolerance.
        /// </summary>
        /// <param name="point3D_1">The first <c>Point3D?</c> point to compare.</param>
        /// <param name="point3D_2">The second <c>Point3D?</c> point to compare.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine equality.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two points are approximately equal.</returns>
        public static bool AlmostEquals(this Point3D? point3D_1, Point3D? point3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D_1 == point3D_2)
            {
                return true;
            }

            if (point3D_1 == null || point3D_2 == null)
            {
                return false;
            }

            double double_Dx = point3D_1.X - point3D_2.X;
            double double_Dy = point3D_1.Y - point3D_2.Y;
            double double_Dz = point3D_1.Z - point3D_2.Z;
            return (double_Dx * double_Dx + double_Dy * double_Dy + double_Dz * double_Dz) <= tolerance * tolerance;
        }

        /// <summary>
        /// Determines whether two <see cref="ISegmentable3D"/> objects are almost equal based on a specified tolerance.
        /// </summary>
        /// <param name="segmentable3D_1">The first <see cref="ISegmentable3D"/> object to compare.</param>
        /// <param name="segmentable3D_2">The second <see cref="ISegmentable3D"/> object to compare.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two objects are almost equal.</returns>
        public static bool AlmostEquals(this ISegmentable3D? segmentable3D_1, ISegmentable3D? segmentable3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable3D_1 == segmentable3D_2)
            {
                return true;
            }

            if (segmentable3D_1 == null || segmentable3D_2 == null)
            {
                return false;
            }

            if (segmentable3D_1.GetType() != segmentable3D_2.GetType())
            {
                return false;
            }

            List<Point3D>? point3Ds_1 = segmentable3D_1.GetPoints();
            List<Point3D>? point3Ds_2 = segmentable3D_2.GetPoints();

            if ((point3Ds_1 == null || point3Ds_1.Count == 0) && (point3Ds_2 == null || point3Ds_2.Count == 0))
            {
                return true;
            }

            if (point3Ds_1 == null || point3Ds_2 == null || point3Ds_1.Count != point3Ds_2.Count)
            {
                return false;
            }

            for (int i = 0; i < point3Ds_1.Count; i++)
            {
                if (!AlmostEquals(point3Ds_1[i], point3Ds_2[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}