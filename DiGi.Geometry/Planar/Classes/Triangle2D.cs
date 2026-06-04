using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional triangle.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle2D"/> class using a <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the triangle.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle2D"/> class.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle2D"/> class by copying an existing <see cref="Triangle2D"/> object.
    /// </summary>
    /// <param name="triangle2D">The <see cref="Triangle2D"/> object to copy.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle2D"/> class using a collection of <see cref="Point2D"/> objects.
    /// </summary>
    /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects that define the triangle's vertices.</param>
    public class Triangle2D : Polygon2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this <see cref="Triangle2D"/> instance.</param>
        public Triangle2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2D"/> class.
        /// </summary>
        public Triangle2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2D"/> class using another <see cref="Triangle2D"/> instance.
        /// </summary>
        /// <param name="triangle2D">The <see cref="Triangle2D"/> instance to copy from.</param>
        public Triangle2D(Triangle2D? triangle2D)
            : base(triangle2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2D"/> class using a collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects that define the vertices of the triangle.</param>
        public Triangle2D(IEnumerable<Point2D>? point2Ds)
            : base(point2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2D"/> class with three specified <see cref="Point2D"/> vertices.
        /// </summary>
        /// <param name="point2D_1">The first <see cref="Point2D"/> vertex of the triangle.</param>
        /// <param name="point2D_2">The second <see cref="Point2D"/> vertex of the triangle.</param>
        /// <param name="point2D_3">The third <see cref="Point2D"/> vertex of the triangle.</param>
        public Triangle2D(Point2D point2D_1, Point2D point2D_2, Point2D point2D_3)
            : base([point2D_1, point2D_2, point2D_3])
        {
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new <ISerializableObject> instance that is a clone of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new Triangle2D(this);
        }

        /// <summary>
        /// Triangulates the object into a list of <Triangle2D> objects using the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The <double> value representing the distance tolerance used for triangulation.</param>
        /// <returns>A <List<Triangle2D>> containing the resulting triangles, or null if the object cannot be triangulated.</returns>
        public override List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
        {
            List<Point2D>? point2Ds = GetPoints();
            if (point2Ds == null || point2Ds.Count != 3)
            {
                return null;
            }

            return [new Triangle2D(point2Ds[0], point2Ds[1], point2Ds[2])];
        }
    }
}