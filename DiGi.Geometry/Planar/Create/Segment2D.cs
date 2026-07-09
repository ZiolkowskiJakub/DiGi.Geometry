using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a segment from the intersection of a line and a polygonal geometry.
        /// </summary>
        /// <param name="line2D">The line to intersect.</param>
        /// <param name="polygonal2D">The polygonal geometry to intersect with.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A Segment2D resulting from the intersection; otherwise, null.</returns>
        public static Segment2D? Segment2D(this Line2D? line2D, IPolygonal2D? polygonal2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null || polygonal2D is null)
            {
                return null;
            }

            IntersectionResult2D? intersectionResult2D = IntersectionResult2D(polygonal2D, line2D, tolerance);
            if (intersectionResult2D == null || !intersectionResult2D.Any())
            {
                return null;
            }

            if (intersectionResult2D.Contains<Segment2D>())
            {
                return intersectionResult2D.GetGeometry2Ds<Segment2D>()?.FirstOrDefault();
            }

            List<Point2D>? point2Ds = intersectionResult2D.GetGeometry2Ds<Point2D>();
            if (point2Ds == null || point2Ds.Count < 2)
            {
                return null;
            }

            return new Segment2D(point2Ds[0], point2Ds[1]);
        }
    }
}