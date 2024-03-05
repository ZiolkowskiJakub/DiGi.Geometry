using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Triangle2D : Polygon2D
    {
        public Triangle2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Triangle2D()
        {

        }

        public Triangle2D(Triangle2D triangle2D)
            : base(triangle2D)
        {

        }

        public Triangle2D(IEnumerable<Point2D> point2Ds)
            : base(point2Ds)
        {

        }

        public Triangle2D(Point2D point2D_1, Point2D point2D_2, Point2D point2D_3)
            : base(new Point2D[] { point2D_1, point2D_2, point2D_3 })
        {

        }
    }
}
