using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Base class for 2D geometries that can be represented as a collection of segments.
    /// </summary>
    public abstract class Segmentable2D : Geometry2D, ISegmentable2D
    {
        [JsonInclude, JsonPropertyName("Points")]
        protected List<Point2D> points = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing geometry data.</param>
        public Segmentable2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable2D"/> class.
        /// </summary>
        public Segmentable2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable2D"/> class by cloning an existing segmentable geometry.
        /// </summary>
        /// <param name="segmentable2D">The source geometry to clone.</param>
        public Segmentable2D(Segmentable2D? segmentable2D)
            : base(segmentable2D)
        {
            List<Point2D>? points_Source = segmentable2D?.points;
            if (points_Source == null)
            {
                return;
            }

            points = new List<Point2D>(points_Source.Count);
            for (int i = 0; i < points_Source.Count; i++)
            {
                if (points_Source[i]?.Clone() is Point2D point2D)
                {
                    points.Add(point2D);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable2D"/> class defined by a collection of points.
        /// </summary>
        /// <param name="point2Ds">The vertices of the geometry.</param>
        public Segmentable2D(IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return;
            }

            if (point2Ds is ICollection<Point2D> point2Ds_Collection)
            {
                points = new List<Point2D>(point2Ds_Collection.Count);
            }

            foreach (Point2D point2D in point2Ds)
            {
                if (point2D?.Clone() is Point2D point2D_Temp)
                {
                    points.Add(point2D_Temp);
                }
            }
        }

        /// <summary>
        /// Gets the total length of the segments that form the geometry.
        /// </summary>
        [JsonIgnore]
        public double Length
        {
            get
            {
                List<Segment2D>? segment2Ds = GetSegments();
                if (segment2Ds == null)
                {
                    return double.NaN;
                }

                double result = 0;
                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    Segment2D segment2D = segment2Ds[i];
                    if (segment2D is null)
                    {
                        continue;
                    }

                    result += segment2D.Length;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets the point on the geometry closest to the specified point.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The closest point on the geometry, or null if it cannot be determined.</returns>
        public Point2D? ClosestPoint(Point2D? point2D)
        {
            if (point2D == null || points == null || points.Count == 0)
            {
                return null;
            }

            return Query.ClosestPoint(point2D, GetSegments());
        }

        /// <summary>
        /// Calculates the shortest distance from the geometry to the specified point.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The distance to the point, or NaN if it cannot be calculated.</returns>
        public double Distance(Point2D? point2D)
        {
            if (point2D == null || points == null || points.Count == 0)
            {
                return double.NaN;
            }

            return Query.Distance(point2D, GetSegments());
        }

        /// <summary>
        /// Gets the bounding box of the geometry.
        /// </summary>
        /// <returns>The bounding box, or null if it cannot be determined.</returns>
        public BoundingBox2D? GetBoundingBox()
        {
            if (points == null || points.Count == 0)
            {
                return null;
            }

            return new BoundingBox2D(points);
        }

        /// <summary>
        /// Gets the collection of points that define the geometry.
        /// </summary>
        /// <returns>A cloned list of vertices, or null if none exist.</returns>
        public List<Point2D>? GetPoints()
        {
            if (points == null)
            {
                return null;
            }

            List<Point2D> result = new(points.Count);
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i]?.Clone() is Point2D point2D)
                {
                    result.Add(point2D);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the segments that form the geometry.
        /// </summary>
        /// <returns>A list of boundary segments, or null if none exist.</returns>
        public abstract List<Segment2D>? GetSegments();

        /// <summary>
        /// Reverses the order of the points defining the geometry.
        /// </summary>
        /// <returns>True if the reversal was successful; otherwise, false.</returns>
        public bool Inverse()
        {
            if (points is null)
            {
                return false;
            }

            points.Reverse();
            return true;
        }

        /// <summary>
        /// Moves the geometry by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful; otherwise, false.</returns>
        public override bool Move(Vector2D? vector2D)
        {
            if (points == null || vector2D == null)
            {
                return false;
            }

            for (int i = 0; i < points.Count; i++)
            {
                points[i]?.Move(vector2D);
            }

            return true;
        }

        /// <summary>
        /// Checks if the specified point lies on the geometry within a given tolerance.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the geometry; otherwise, false.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Query.On(this, point2D, tolerance);
        }

        /// <summary>
        /// Transforms the geometry using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful; otherwise, false.</returns>
        public override bool Transform(ITransform2D? transform)
        {
            if (points == null || transform == null)
            {
                return false;
            }

            for (int i = 0; i < points.Count; i++)
            {
                points[i]?.Transform(transform);
            }

            return true;
        }
    }
}