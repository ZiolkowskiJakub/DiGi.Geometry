using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Vector2D> Directions(this IEnumerable<ISegmentable2D> segmentable2Ds)
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            Dictionary<double, Vector2D> dictionary = new Dictionary<double, Vector2D>();
            if (segmentable2Ds.Count() == 0)
            {
                return new List<Vector2D>();
            }

            Vector2D vector2D_Y = Constans.Vector2D.WorldY;

            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D> segment2Ds = segmentable2D.GetSegments();
                foreach (Segment2D segment2D in segment2Ds)
                {
                    Vector2D vector2D = segment2D.Vector;
                    double angle = vector2D.Angle(vector2D_Y);

                    Vector2D vector2D_Temp;
                    if (dictionary.TryGetValue(angle, out vector2D_Temp))
                    {
                        dictionary[angle] = vector2D + vector2D_Temp;
                    }
                    else
                    {
                        dictionary[angle] = vector2D;
                    }
                }
            }

            return dictionary.Values.ToList();
        }

        public static void Directions(this Core.Enums.Corner corner, out Vector2D heightDirection, out Vector2D widthDirection)
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
