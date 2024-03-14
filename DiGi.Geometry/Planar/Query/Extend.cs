using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Segment2D Extend(this Segment2D segment2D, double distance, bool extendStart = true, bool extendEnd = true)
        {
            if(segment2D == null)
            {
                return null;
            }

            if(!extendStart && !extendEnd)
            {
                return new Segment2D(segment2D);
            }

            Point2D start = segment2D.Start;
            Point2D end = segment2D.End;

            Vector2D vector2D = segment2D.Direction * distance;
            if(extendEnd)
            {
                end.Move(vector2D);
            }

            if(extendStart)
            {
                vector2D.Inverse();
                start.Move(vector2D);
            }

            return new Segment2D(start, end);
        }
    }
}
