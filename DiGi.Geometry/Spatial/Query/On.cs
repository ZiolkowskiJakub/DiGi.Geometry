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

            List<Segment3D>? segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return false;
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                if (segment3Ds[i].On(point3D, tolerance))
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

            Vector3D? normal = plane.Normal;
            if (normal == null)
            {
                return false;
            }

            Point3D? origin = plane.Origin;
            if (origin == null)
            {
                return false;
            }

            return System.Math.Abs((normal.X * (point3D.X - origin.X)) + (normal.Y * (point3D.Y - origin.Y)) + (normal.Z * (point3D.Z - origin.Z))) < tolerance;
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
        /// <param name="tolerance">The <double> tolerance value used for the distance calculation.</param>
        /// <returns>A <bool> indicating whether all points of the <see cref="ISegmentable3D"/> object are on the <see cref="Plane"/>.</returns>
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
        /// Determines whether the specified <see cref="Vector3D?"/> lies on the <see cref="Plane?"/> within a given tolerance.
        /// </summary>
        /// <param name="plane">The <see cref="Plane?"/> to check.</param>
        /// <param name="vector3D">The <see cref="Vector3D?"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> indicating whether the <see cref="Vector3D?"/> is on the <see cref="Plane?"/>.</returns>
        public static bool On(this Plane? plane, Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || vector3D == null)
            {
                return false;
            }

            Point3D? point3D_1 = plane.Origin;
            if (point3D_1 == null)
            {
                return false;
            }

            Point3D? point3D_2 = point3D_1.GetMoved(vector3D);
            if (point3D_2 == null)
            {
                return false;
            }

            Point3D? point3D_Temp = plane.Project(point3D_2);
            if (point3D_Temp == null)
            {
                return false;
            }

            return System.Math.Abs(point3D_1.Distance(point3D_2) - point3D_1.Distance(point3D_Temp)) < tolerance;
        }
    }
}