using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
/// <summary>
/// Represents a 2D polyline defined by a sequence of vertices.
/// </summary>
    public class Polyline2D : Segmentable2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing polyline data.</param>
        public Polyline2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline2D"/> class.
        /// </summary>
        public Polyline2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline2D"/> class by cloning an existing polyline.
        /// </summary>
        /// <param name="polyline2D">The source polyline to clone.</param>
        public Polyline2D(Polyline2D? polyline2D)
            : base(polyline2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline2D"/> class defined by a collection of points.
        /// </summary>
        /// <param name="point2Ds">The vertices of the polyline.</param>
        public Polyline2D(IEnumerable<Point2D>? point2Ds)
            : base(point2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline2D"/> class defined by vertices and whether it is closed.
        /// </summary>
        /// <param name="point2Ds">The vertices of the polyline.</param>
        /// <param name="close">True if the polyline should be closed by connecting the last point to the first.</param>
        public Polyline2D(IEnumerable<Point2D>? point2Ds, bool close)
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

        /// <summary>
        /// Creates a clone of the current polyline.
        /// </summary>
        /// <returns>A cloned instance of the polyline.</returns>
        public override ISerializableObject? Clone()
        {
            return new Polyline2D(this);
        }

        /// <summary>
        /// Closes the polyline by adding a point at the end that matches the start point.
        /// </summary>
        public void Close()
        {
            if (IsClosed())
            {
                return;
            }

            if (points == null || points.Count < 3)
            {
                return;
            }

            points.Add(new Point2D(points[0]));
        }

        /// <summary>
        /// Gets the segments that form the polyline boundary.
        /// </summary>
        /// <returns>A list of line segments.</returns>
        public override List<Segment2D>? GetSegments()
        {
            return Create.Segment2Ds(points, false);
        }

        /// <summary>
        /// Checks if the polyline is closed (start point equals end point).
        /// </summary>
        /// <returns>True if it is closed; otherwise, false.</returns>
        public bool IsClosed()
        {
            if (points == null || points.Count < 3)
            {
                return false;
            }

            return points[0].Equals(points[points.Count - 1]);
        }

        /// <summary>
        /// Opens the polyline by removing the last point if it is closed.
        /// </summary>
        public void Open()
        {
            if (!IsClosed())
            {
                return;
            }

            if (points == null || points.Count < 3)
            {
                return;
            }

            points.RemoveAt(points.Count - 1);
        }
    }
}