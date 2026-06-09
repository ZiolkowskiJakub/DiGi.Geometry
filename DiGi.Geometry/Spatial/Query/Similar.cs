using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
/// Determines whether two <see cref="Point3D" /> points are similar within a specified tolerance.
        /// </summary>
/// <param name="point3D_1">The first <c>Point3D?</c> point to compare.</param>
/// <param name="point3D_2">The second <c>Point3D?</c> point to compare.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value used for the comparison.</param>
        /// <returns>A <see cref="bool" /> value indicating whether the two points are similar.</returns>
        public static bool Similar(this Point3D? point3D_1, Point3D? point3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return AlmostEquals(point3D_1, point3D_2, tolerance);
        }

        /// <summary>
        /// Determines whether two <see cref="Vector3D"/> objects are similar, meaning they are either almost equal or one is the inverse of the other within a specified tolerance.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/> object to compare.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/> object to compare.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two vectors are similar.</returns>
        public static bool Similar(this Vector3D? vector3D_1, Vector3D? vector3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (vector3D_1 == vector3D_2)
            {
                return true;
            }

            if (vector3D_1 == null || vector3D_2 == null)
            {
                return false;
            }

            Vector3D vector3D_3 = new(vector3D_2);
            vector3D_3.Inverse();

            return vector3D_1.AlmostEquals(vector3D_2, tolerance) || vector3D_1.AlmostEquals(vector3D_3, tolerance);
        }

        /// <summary>
        /// Determines whether two <see cref="Segment3D"/> segments are similar, meaning they are either almost equal or one is the reverse of the other within a specified tolerance.
        /// </summary>
        /// <param name="segment3D_1">The first <see cref="Segment3D"/> segment to compare.</param>
        /// <param name="segment3D_2">The second <see cref="Segment3D"/> segment to compare.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two segments are similar.</returns>
        public static bool Similar(this Segment3D? segment3D_1, Segment3D? segment3D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment3D_1 == segment3D_2)
            {
                return true;
            }

            if (segment3D_1 == null || segment3D_2 == null)
            {
                return false;
            }

            Segment3D segment3D_3 = new(segment3D_2);
            segment3D_3.Inverse();

            return segment3D_1.AlmostEquals(segment3D_2, tolerance) || segment3D_1.AlmostEquals(segment3D_3, tolerance);
        }
    }
}