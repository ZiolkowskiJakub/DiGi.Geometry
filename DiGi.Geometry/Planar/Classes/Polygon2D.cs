using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Polygon2D : Segmentable2D, IClosedSegmentable2D
    {
        public Polygon2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Polygon2D()
        {

        }

        public Polygon2D(Polygon2D polygon2D)
            : base(polygon2D)
        {

        }

        public Polygon2D(IEnumerable<Point2D> point2Ds)
            : base(point2Ds)
        {

        }

        public Polygon2D(IClosedSegmentable2D closedSegmentable2D)
            : base(closedSegmentable2D?.GetPoints())
        {

        }

        public override ISerializableObject Clone()
        {
            return new Polygon2D(this);
        }

        public virtual double GetArea()
        {
            return Query.Area(points);
        }

        public override List<Segment2D> GetSegments()
        {
            return Create.Segment2Ds(points, true);
        }
        
        public bool InRange(ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Point2D> point2Ds = segmentable2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            foreach (Point2D point in point2Ds)
            {
                if (!InRange(point, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return On(point2D, tolerance) || Query.Inside(points, point2D);
        }

        public bool Inside(ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Point2D> point2Ds = segmentable2D?.GetPoints();
            if(point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            foreach(Point2D point in point2Ds)
            {
                if(!Inside(point, tolerance))
                {
                    return false;
                }
            }

            return true;
        }
        
        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            bool result = Query.Inside(points, point2D);

            if (!result)
            {
                return result;
            }

            return !On(point2D, tolerance);
        }

        public Point2D GetCentroid()
        {
            return Query.Centroid(points);
        }

        public virtual Point2D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(points == null)
            {
                return null;
            }

            return Query.InternalPoint(points, tolerance);
        }
    }
}
