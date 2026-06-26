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

            return InRange(planar, [point3D], tolerance);
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

            Point3D[] point3Ds_Local = point3Ds as Point3D[] ?? point3Ds.ToArray();
            int count = point3Ds_Local.Length;

            for (int i = 0; i < count; i++)
            {
                Point3D point3D = point3Ds_Local[i];
                if (point3D == null || !plane.On(point3D, tolerance))
                {
                    return false;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Point3D point3D = point3Ds_Local[i];
                if (point3D == null)
                {
                    continue;
                }

                Point2D? point2D = plane.Convert(point3D);
                if (point2D == null)
                {
                    continue;
                }

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

            if (!On(plane, segmentable3D, tolerance))
            {
                return false;
            }

            List<Segment3D>? segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return false;
            }

            IPolygonal2D? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                Segment2D? segment2D = plane.Convert(segment3Ds[i]);
                if (segment2D == null)
                {
                    continue;
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