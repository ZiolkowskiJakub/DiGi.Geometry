using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a specified <see cref="Segment3D"/> intersects the given <see cref="IPolygonalFace3D"/> object within a certain tolerance.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> to check against.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> segment to check.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <param name="includeStart">If true, includes intersection at the start point of the segment.</param>
        /// <param name="includeEnd">If true, includes intersection at the end point of the segment.</param>
        /// <returns>True if the segment intersects the face; otherwise, false.</returns>
        public static bool Intersect(this IPolygonalFace3D? polygonalFace3D, Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance, bool includeStart = false, bool includeEnd = false)
        {
            if (polygonalFace3D == null || segment3D == null)
            {
                return false;
            }

            PlanarIntersectionResult? planarIntersectionResult = polygonalFace3D.PlanarIntersectionResult(segment3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Any())
            {
                return false;
            }

            if (includeStart && includeEnd)
            {
                return true;
            }

            List<Point3D>? point3Ds = planarIntersectionResult.GetGeometry3Ds<Point3D>();
            if (point3Ds != null)
            {
                foreach (Point3D point3D in point3Ds)
                {
                    if (point3D == null)
                    {
                        continue;
                    }

                    bool valid = true;
                    if (!includeStart && point3D.Distance(segment3D.Start) <= tolerance)
                    {
                        valid = false;
                    }
                    if (!includeEnd && point3D.Distance(segment3D.End) <= tolerance)
                    {
                        valid = false;
                    }
                    if (valid)
                    {
                        return true;
                    }
                }
            }

            List<Segment3D>? segment3Ds = planarIntersectionResult.GetGeometry3Ds<Segment3D>();
            if (segment3Ds != null)
            {
                foreach (Segment3D segment3D_Temp in segment3Ds)
                {
                    if (segment3D_Temp == null)
                    {
                        continue;
                    }

                    bool startValid = true;
                    bool endValid = true;

                    if (segment3D_Temp.Start is Point3D point3D_Start)
                    {
                        if (!includeStart && point3D_Start.Distance(segment3D.Start) <= tolerance)
                        {
                            startValid = false;
                        }
                        if (!includeEnd && point3D_Start.Distance(segment3D.End) <= tolerance)
                        {
                            startValid = false;
                        }
                    }

                    if (segment3D_Temp.End is Point3D point3D_End)
                    {
                        if (!includeStart && point3D_End.Distance(segment3D.Start) <= tolerance)
                        {
                            endValid = false;
                        }
                        if (!includeEnd && point3D_End.Distance(segment3D.End) <= tolerance)
                        {
                            endValid = false;
                        }
                    }

                    if (startValid || endValid)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
