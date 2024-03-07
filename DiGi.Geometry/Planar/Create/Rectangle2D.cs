using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static Rectangle2D Rectangle2D(this IEnumerable<Point2D> point2Ds, Vector2D direction)
        {
            if (point2Ds == null || direction == null || point2Ds.Count() < 2)
            {
                return null;
            }

            Vector2D direction_Height = new Vector2D(direction);
            direction_Height = direction_Height.Unit;
            Vector2D direction_Width = direction_Height.GetPerpendicular();

            List<Point2D> point2Ds_Height = new List<Point2D>();
            List<Point2D> point2Ds_Width = new List<Point2D>();

            foreach (Point2D point2D in point2Ds)
            {
                point2Ds_Height.Add(direction_Height.Project(point2D));
                point2Ds_Width.Add(direction_Width.Project(point2D));
            }

            double height = Query.MaxDistance(point2Ds_Height, out Point2D point2D_1_Height, out Point2D point2D_2_Height);
            if (point2D_1_Height == null || point2D_2_Height == null)
            {
                return null;
            }

            double width = Query.MaxDistance(point2Ds_Width, out Point2D point2D_1_Width, out Point2D point2D_2_Width);
            if (point2D_1_Width == null || point2D_2_Width == null)
            {
                return null;
            }

            Segment2D segment2D_Height = new Segment2D(point2D_1_Height, point2D_2_Height);
            Segment2D segment2D_Width = new Segment2D(point2D_1_Width, point2D_2_Width);

            if (!segment2D_Height.Direction.AlmostEqual(direction_Height))
            {
                segment2D_Height.Inverse();
            }

            if (!segment2D_Width.Direction.AlmostEqual(direction_Width))
            {
                segment2D_Width.Inverse();
            }

            Point2D point2D_Temp = segment2D_Height[0];
            segment2D_Height.Start = segment2D_Width[0];
            segment2D_Width.Start = point2D_Temp;

            Point2D point2D_Intersection = ((Line2D)segment2D_Height).IntersectionPoint((Line2D)segment2D_Width);
            if (point2D_Intersection == null)
            {
                return null;
            }

            return new Rectangle2D(point2D_Intersection, width, height, direction_Height);
        }

        public static Rectangle2D Rectangle2D(this IEnumerable<Point2D> point2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2Ds == null || point2Ds.Count() <= 2)
            {
                return null;
            }

            List<Point2D> point2Ds_ConvexHull = Query.ConvexHull(point2Ds);
            if (point2Ds_ConvexHull == null || point2Ds_ConvexHull.Count < 2)
            {
                return null;
            }

            double area = double.MaxValue;
            Rectangle2D result = null;

            Vector2D vector2D = Constans.Vector2D.WorldY;

            HashSet<double> angleHashSet = new HashSet<double>();
            for (int i = 0; i < point2Ds_ConvexHull.Count - 1; i++)
            {
                Vector2D direction = new Vector2D(point2Ds_ConvexHull[i], point2Ds_ConvexHull[i + 1]);
                double angle = direction.Angle(vector2D);
                if (!angleHashSet.Contains(angle))
                {
                    angleHashSet.Add(angle);
                    Rectangle2D rectangle_Temp = Rectangle2D(point2Ds_ConvexHull, direction);
                    if (rectangle_Temp == null)
                    {
                        continue;
                    }

                    double area_Temp = rectangle_Temp.GetArea();
                    if (DiGi.Core.Query.AlmostEqual(area_Temp, area, tolerance))
                    {
                        List<Point2D> point2Ds_1 = result.GetPoints();
                        List<Point2D> point2Ds_2 = rectangle_Temp.GetPoints();

                        int count_1 = point2Ds_1.Count(x => point2Ds_ConvexHull.Find(y => y.AlmostEquals(x, tolerance)) != null);
                        int count_2 = point2Ds_2.Count(x => point2Ds_ConvexHull.Find(y => y.AlmostEquals(x, tolerance)) != null);

                        if (count_2 > count_1)
                        {
                            area = area_Temp;
                            result = rectangle_Temp;
                        }
                    }
                    else if (area_Temp < area)
                    {
                        area = area_Temp;
                        result = rectangle_Temp;
                    }
                }
            }

            return result;
        }

        public static Rectangle2D Rectangle2D(this IEnumerable<ISegmentable2D> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds = segmentable2Ds.Points();


            return Rectangle2D(point2Ds, tolerance);
        }

        public static Rectangle2D Rectangle2D(this Rectangle2D rectangle2D_1, Rectangle2D rectangle2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (rectangle2D_1 == null || rectangle2D_2 == null)
            {
                return null;
            }

            List<Point2D> point2Ds = rectangle2D_1.GetPoints();
            point2Ds.AddRange(rectangle2D_2.GetPoints());

            return Rectangle2D(point2Ds, tolerance);
        }
    }

}
