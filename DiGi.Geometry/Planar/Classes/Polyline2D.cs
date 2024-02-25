using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Polyline2D : Segmentable2D
    {
        public Polyline2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Polyline2D()
        {

        }

        public Polyline2D(Polyline2D polyline2D)
            : base(polyline2D)
        {

        }

        public Polyline2D(IEnumerable<Point2D> point2Ds)
            : base(point2Ds)
        {

        }

        public override List<Segment2D> GetSegments()
        {
            return Create.Segment2Ds(points, false);
        }
    }
}
