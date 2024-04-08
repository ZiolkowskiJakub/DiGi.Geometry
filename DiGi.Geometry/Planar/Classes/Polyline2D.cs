using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Polyline2D : Segmentable2D
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
            :base(point2Ds)
        {

        }

        public Polyline2D(IEnumerable<Point2D> point2Ds, bool close)
            : base(point2Ds)
        {
            if (close)
            {
                Close();
            }
            else
            {
                Open();
            }
        }

        public override List<Segment2D> GetSegments()
        {
            return Create.Segment2Ds(points, false);
        }

        public override ISerializableObject Clone()
        {
            return new Polyline2D(this);
        }

        public bool IsClosed()
        {
            if(points == null || points.Count < 3)
            {
                return false;
            }

            return points[0].Equals(points[points.Count - 1]);
        }

        public void Close()
        {
            if (IsClosed())
            {
                return;
            }

            if(points == null || points.Count < 3)
            {
                return;
            }

            points.Add(new Point2D(points[0]));
        }

        public void Open()
        {
            if (!IsClosed())
            {
                return;
            }

            if(points == null || points.Count < 3)
            {
                return;
            }

            points.RemoveAt(points.Count - 1);
        }
    }
}
