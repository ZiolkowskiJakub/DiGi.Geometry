using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the directions for a collection of segmentable 2D objects.
        /// </summary>
        /// <param name="segmentable2Ds">The <see cref="IEnumerable{ISegmentable2D}"/> of <see cref="ISegmentable2D"/> objects to process.</param>
        /// <returns>A <see cref="List{Vector2D}"/> containing the calculated directions, or null if the <paramref name="segmentable2Ds"/> collection is null.</returns>
        public static List<Vector2D>? Directions(this IEnumerable<ISegmentable2D>? segmentable2Ds)
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            Dictionary<double, Vector2D> dictionary = [];
            if (segmentable2Ds.Count() == 0)
            {
                return [];
            }

            Vector2D vector2D_Y = Constants.Vector2D.WorldY;

            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D>? segment2Ds = segmentable2D.GetSegments();
                if (segment2Ds is null)
                {
                    continue;
                }

                foreach (Segment2D segment2D in segment2Ds)
                {
                    Vector2D? vector2D = segment2D.Vector;
                    if (vector2D is null)
                    {
                        continue;
                    }

                    double angle = vector2D.Angle(vector2D_Y);

                    if (dictionary.TryGetValue(angle, out Vector2D vector2D_Temp) && vector2D_Temp is not null)
                    {
                        dictionary[angle] = (vector2D + vector2D_Temp)!;
                    }
                    else
                    {
                        dictionary[angle] = vector2D;
                    }
                }
            }

            return [.. dictionary.Values];
        }

        /// <summary>
        /// Calculates the height and width direction vectors based on the specified corner.
        /// </summary>
        /// <param name="corner">The <see cref="Core.Enums.Corner"/> value used to determine the directions.</param>
        /// <param name="heightDirection">When this method returns, contains a <c>Vector2D?</c> representing the height direction vector, or null if not applicable.</param>
        /// <param name="widthDirection">When this method returns, contains a <c>Vector2D?</c> representing the width direction vector, or null if not applicable.</param>
        public static void Directions(this Core.Enums.Corner corner, out Vector2D? heightDirection, out Vector2D? widthDirection)
        {
            widthDirection = null;
            heightDirection = null;

            switch (corner)
            {
                case Core.Enums.Corner.BottomLeft:
                    widthDirection = new Vector2D(1, 0);
                    heightDirection = new Vector2D(0, 1);
                    return;

                case Core.Enums.Corner.TopLeft:
                    widthDirection = new Vector2D(1, 0);
                    heightDirection = new Vector2D(0, -1);
                    return;

                case Core.Enums.Corner.BottomRight:
                    widthDirection = new Vector2D(-1, 0);
                    heightDirection = new Vector2D(0, 1);
                    return;

                case Core.Enums.Corner.TopRight:
                    widthDirection = new Vector2D(-1, 0);
                    heightDirection = new Vector2D(0, -1);
                    return;
            }
        }
    }
}