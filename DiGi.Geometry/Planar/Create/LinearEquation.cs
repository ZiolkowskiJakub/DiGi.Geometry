using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static LinearEquation LinearEquation(this Point2D point2D_1, Point2D point2D_2)
        {
            if (point2D_1 == point2D_2 || point2D_1 == null)
            {
                return null;
            }

            return Math.Create.LinearEquation(point2D_1.X, point2D_1.Y, point2D_2.X, point2D_2.Y);
        }

        public static LinearEquation LinearEquation(this Segment2D segment2D)
        {
            if(segment2D == null)
            {
                return null; 
            }

            Point2D point2D_1 = segment2D[0];
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = segment2D[1];
            if (point2D_2 == null)
            {
                return null;
            }

            return LinearEquation(point2D_1, point2D_2);
        }

        public static LinearEquation LinearEquation(this Line2D line2D)
        {
            if (line2D == null)
            {
                return null;
            }

            Point2D point2D_1 = line2D.Origin;
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = point2D_1.GetMoved(line2D.Direction);
            if (point2D_2 == null)
            {
                return null;
            }

            return LinearEquation(point2D_1, point2D_2);
        }
    }

}
