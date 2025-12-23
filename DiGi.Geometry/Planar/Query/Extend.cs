using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Segment2D? Extend(this Segment2D? segment2D, double distance, bool extendStart = true, bool extendEnd = true)
        {
            if (segment2D == null)
            {
                return null;
            }

            Point2D? start = segment2D.Start;
            if (start is null)
            {
                return null;
            }


            Point2D? end = segment2D.End;
            if (end is null)
            {
                return null;
            }


            if (!extendStart && !extendEnd)
            {
                return new(segment2D);
            }

            Vector2D? direction = segment2D.Direction;
            if (direction is null)
            {
                return null;
            }

            Vector2D? vector2D = segment2D.Direction * distance;
            if (vector2D is null)
            {
                return null;
            }

            if (extendEnd)
            {
                end.Move(vector2D);
            }

            if (extendStart)
            {
                vector2D.Inverse();
                start.Move(vector2D);
            }

            return new(start, end);
        }
    }
}
