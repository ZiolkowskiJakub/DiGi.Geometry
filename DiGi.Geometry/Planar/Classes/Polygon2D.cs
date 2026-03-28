using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Polygon2D : Segmentable2D, IPolygon2D
    {
        public Polygon2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Polygon2D()
        {
        }

        public Polygon2D(Polygon2D? polygon2D)
            : base(polygon2D)
        {
        }

        public Polygon2D(IEnumerable<Point2D>? point2Ds)
            : base(point2Ds)
        {
        }

        public Polygon2D(IPolygonal2D? polygonal2D)
            : base(polygonal2D?.GetPoints())
        {
        }

        public override ISerializableObject? Clone()
        {
            return new Polygon2D(this);
        }

        public virtual double GetArea()
        {
            return Query.Area(points);
        }

        public Point2D? GetCentroid()
        {
            return Query.Centroid(points);
        }

        public virtual Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (points == null)
            {
                return null;
            }

            return Query.InternalPoint(points, tolerance);
        }

        public double GetPerimeter()
        {
            return Length;
        }

        public override List<Segment2D>? GetSegments()
        {
            return Create.Segment2Ds(points, true);
        }

        public bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Point2D>? point2Ds = segmentable2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            //For large number of points convert and use NetTopologySuite
            if (point2Ds.Count > 16 || points.Count > 16)
            {
                if (Convert.ToNTS_Polygon(this) is Polygon polygon && segmentable2D.ToNTS() is NetTopologySuite.Geometries.Geometry geometry)
                {
                    return Query.InRange(polygon, geometry, tolerance);
                }
            }

            for (int i = 0; i < point2Ds.Count; i++)
            {
                if (InRange(point2Ds[i], tolerance))
                {
                    return true;
                }
            }

            if (segmentable2D is IClosedCurve2D closedCurve2D)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    if (closedCurve2D.InRange(points[i], tolerance))
                    {
                        return true;
                    }
                }
            }

            List<Segment2D>? segment2Ds_1 = segmentable2D?.GetSegments();
            if (segment2Ds_1 == null)
            {
                return false;
            }

            List<Segment2D>? segment2Ds_2 = GetSegments();
            if (segment2Ds_2 == null)
            {
                return false;
            }

            for (int i = 0; i < segment2Ds_1.Count; i++)
            {
                for (int j = 0; j < segment2Ds_2.Count; j++)
                {
                    IntersectionResult2D? intersectionResult2D = Create.IntersectionResult2D(segment2Ds_1[i], segment2Ds_2[j], tolerance);
                    if (intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return On(point2D, tolerance) || Query.Inside(points, point2D);
        }

        public bool InRange(BoundingBox2D? boundingBox2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (boundingBox2D is null)
            {
                return false;
            }

            return boundingBox2D.InRange(this, tolerance);
        }

        public bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Point2D>? point2Ds = segmentable2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            foreach (Point2D point in point2Ds)
            {
                if (!Inside(point, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            bool result = Query.Inside(points, point2D);

            if (!result)
            {
                return result;
            }

            return !On(point2D, tolerance);
        }

        public virtual List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
        {
            if (points == null || points.Count < 3)
            {
                return null;
            }

            if (points.Count == 3)
            {
                return [new(new Point2D(points[0]), new Point2D(points[1]), new Point2D(points[2]))];
            }

            if (points.Count == 4)
            {
                return [new(new Point2D(points[0]), new Point2D(points[1]), new Point2D(points[2])), new Triangle2D(new Point2D(points[2]), new Point2D(points[3]), new Point2D(points[0]))];
            }

            List<Polygon>? polygons = Query.Triangulate(this.ToNTS_Polygon(), tolerance);
            if (polygons == null)
            {
                return null;
            }

            List<Triangle2D> result = [];
            foreach (Polygon polygon in polygons)
            {
                Coordinate[]? coordinates = polygon?.Coordinates;
                if (coordinates == null || coordinates.Length != 4)
                {
                    continue;
                }

                result.Add(new Triangle2D(coordinates[0].ToDiGi(), coordinates[1].ToDiGi(), coordinates[2].ToDiGi()));
            }

            return result;
        }
    }
}