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

        /// <summary>
        /// Determines whether the specified <see cref="Triangle3D"/> overlaps an axis-aligned box given by its center and per-axis half-extents, using the Akenine-Möller separating-axis theorem (thirteen candidate axes: three box face normals, one triangle face normal, and nine edge cross products).
        /// <para>All arithmetic is performed on scalar doubles in the box's local frame, allocating nothing. A degenerate triangle whose normal is zero degrades gracefully to the box-axis and edge tests.</para>
        /// </summary>
        /// <param name="centerX">The X-coordinate of the box center.</param>
        /// <param name="centerY">The Y-coordinate of the box center.</param>
        /// <param name="centerZ">The Z-coordinate of the box center.</param>
        /// <param name="halfX">The half-extent of the box along the X axis, already expanded by any tolerance.</param>
        /// <param name="halfY">The half-extent of the box along the Y axis, already expanded by any tolerance.</param>
        /// <param name="halfZ">The half-extent of the box along the Z axis, already expanded by any tolerance.</param>
        /// <param name="triangle3D">The <see cref="Triangle3D"/> to test for overlap.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> when no separating axis exists (the triangle overlaps the box); otherwise, <c>false</c>.</returns>
        public static bool Intersect(
            double centerX,
            double centerY,
            double centerZ,
            double halfX,
            double halfY,
            double halfZ,
            Triangle3D? triangle3D)
        {
            if (triangle3D == null)
            {
                return false;
            }

            List<Point3D>? point3Ds = triangle3D.GetPoints();
            if (point3Ds == null || point3Ds.Count != 3)
            {
                return false;
            }

            Point3D point3D_1 = point3Ds[0];
            Point3D point3D_2 = point3Ds[1];
            Point3D point3D_3 = point3Ds[2];

            // Move the triangle into the box's local frame (box centered at the origin).
            double v0X = point3D_1.X - centerX;
            double v0Y = point3D_1.Y - centerY;
            double v0Z = point3D_1.Z - centerZ;

            double v1X = point3D_2.X - centerX;
            double v1Y = point3D_2.Y - centerY;
            double v1Z = point3D_2.Z - centerZ;

            double v2X = point3D_3.X - centerX;
            double v2Y = point3D_3.Y - centerY;
            double v2Z = point3D_3.Z - centerZ;

            // Triangle edges.
            double e0X = v1X - v0X;
            double e0Y = v1Y - v0Y;
            double e0Z = v1Z - v0Z;

            double e1X = v2X - v1X;
            double e1Y = v2Y - v1Y;
            double e1Z = v2Z - v1Z;

            double e2X = v0X - v2X;
            double e2Y = v0Y - v2Y;
            double e2Z = v0Z - v2Z;

            double min_Axis;
            double max_Axis;
            double projection_0;
            double projection_1;
            double projection_2;
            double radius;
            double absX;
            double absY;
            double absZ;

            // Nine axes formed by the cross product of each triangle edge with each box axis.
            absX = System.Math.Abs(e0X);
            absY = System.Math.Abs(e0Y);
            absZ = System.Math.Abs(e0Z);

            projection_0 = e0Z * v0Y - e0Y * v0Z;
            projection_2 = e0Z * v2Y - e0Y * v2Z;
            if (projection_0 < projection_2) { min_Axis = projection_0; max_Axis = projection_2; } else { min_Axis = projection_2; max_Axis = projection_0; }
            radius = absZ * halfY + absY * halfZ;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            projection_0 = -e0Z * v0X + e0X * v0Z;
            projection_2 = -e0Z * v2X + e0X * v2Z;
            if (projection_0 < projection_2) { min_Axis = projection_0; max_Axis = projection_2; } else { min_Axis = projection_2; max_Axis = projection_0; }
            radius = absZ * halfX + absX * halfZ;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            projection_1 = e0Y * v1X - e0X * v1Y;
            projection_2 = e0Y * v2X - e0X * v2Y;
            if (projection_2 < projection_1) { min_Axis = projection_2; max_Axis = projection_1; } else { min_Axis = projection_1; max_Axis = projection_2; }
            radius = absY * halfX + absX * halfY;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            absX = System.Math.Abs(e1X);
            absY = System.Math.Abs(e1Y);
            absZ = System.Math.Abs(e1Z);

            projection_0 = e1Z * v0Y - e1Y * v0Z;
            projection_2 = e1Z * v2Y - e1Y * v2Z;
            if (projection_0 < projection_2) { min_Axis = projection_0; max_Axis = projection_2; } else { min_Axis = projection_2; max_Axis = projection_0; }
            radius = absZ * halfY + absY * halfZ;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            projection_0 = -e1Z * v0X + e1X * v0Z;
            projection_2 = -e1Z * v2X + e1X * v2Z;
            if (projection_0 < projection_2) { min_Axis = projection_0; max_Axis = projection_2; } else { min_Axis = projection_2; max_Axis = projection_0; }
            radius = absZ * halfX + absX * halfZ;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            projection_0 = e1Y * v0X - e1X * v0Y;
            projection_1 = e1Y * v1X - e1X * v1Y;
            if (projection_0 < projection_1) { min_Axis = projection_0; max_Axis = projection_1; } else { min_Axis = projection_1; max_Axis = projection_0; }
            radius = absY * halfX + absX * halfY;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            absX = System.Math.Abs(e2X);
            absY = System.Math.Abs(e2Y);
            absZ = System.Math.Abs(e2Z);

            projection_0 = e2Z * v0Y - e2Y * v0Z;
            projection_1 = e2Z * v1Y - e2Y * v1Z;
            if (projection_0 < projection_1) { min_Axis = projection_0; max_Axis = projection_1; } else { min_Axis = projection_1; max_Axis = projection_0; }
            radius = absZ * halfY + absY * halfZ;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            projection_0 = -e2Z * v0X + e2X * v0Z;
            projection_1 = -e2Z * v1X + e2X * v1Z;
            if (projection_0 < projection_1) { min_Axis = projection_0; max_Axis = projection_1; } else { min_Axis = projection_1; max_Axis = projection_0; }
            radius = absZ * halfX + absX * halfZ;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            projection_1 = e2Y * v1X - e2X * v1Y;
            projection_2 = e2Y * v2X - e2X * v2Y;
            if (projection_2 < projection_1) { min_Axis = projection_2; max_Axis = projection_1; } else { min_Axis = projection_1; max_Axis = projection_2; }
            radius = absY * halfX + absX * halfY;
            if (min_Axis > radius || max_Axis < -radius) { return false; }

            // Three axes formed by the box face normals (overlap of the triangle's AABB with the box).
            min_Axis = v0X; max_Axis = v0X;
            if (v1X < min_Axis) { min_Axis = v1X; }
            if (v1X > max_Axis) { max_Axis = v1X; }
            if (v2X < min_Axis) { min_Axis = v2X; }
            if (v2X > max_Axis) { max_Axis = v2X; }
            if (min_Axis > halfX || max_Axis < -halfX) { return false; }

            min_Axis = v0Y; max_Axis = v0Y;
            if (v1Y < min_Axis) { min_Axis = v1Y; }
            if (v1Y > max_Axis) { max_Axis = v1Y; }
            if (v2Y < min_Axis) { min_Axis = v2Y; }
            if (v2Y > max_Axis) { max_Axis = v2Y; }
            if (min_Axis > halfY || max_Axis < -halfY) { return false; }

            min_Axis = v0Z; max_Axis = v0Z;
            if (v1Z < min_Axis) { min_Axis = v1Z; }
            if (v1Z > max_Axis) { max_Axis = v1Z; }
            if (v2Z < min_Axis) { min_Axis = v2Z; }
            if (v2Z > max_Axis) { max_Axis = v2Z; }
            if (min_Axis > halfZ || max_Axis < -halfZ) { return false; }

            // Axis formed by the triangle face normal (plane against the box).
            double normalX = e0Y * e1Z - e0Z * e1Y;
            double normalY = e0Z * e1X - e0X * e1Z;
            double normalZ = e0X * e1Y - e0Y * e1X;

            radius = halfX * System.Math.Abs(normalX) + halfY * System.Math.Abs(normalY) + halfZ * System.Math.Abs(normalZ);
            double distance = normalX * v0X + normalY * v0Y + normalZ * v0Z;
            if (System.Math.Abs(distance) > radius) { return false; }

            return true;
        }
    }
}