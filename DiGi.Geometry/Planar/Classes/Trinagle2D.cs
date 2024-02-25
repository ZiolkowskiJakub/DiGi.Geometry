using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Trinagle2D : Polygon2D
    {
        public Trinagle2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Trinagle2D()
        {

        }

        public Trinagle2D(Trinagle2D trinagle2D)
            : base(trinagle2D)
        {

        }

        public Trinagle2D(IEnumerable<Point2D> point2Ds)
            : base(point2Ds)
        {

        }
    }
}
