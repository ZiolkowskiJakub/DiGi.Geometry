using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional mesh composed of <see cref="Point2D"/> elements, implementing 2D geometry, bounding, and collection interfaces.
    /// </summary>
    public class Mesh2D : Mesh<Point2D>, IGeometry2D, IBoundable2D, ICollectable2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing mesh data.</param>
        public Mesh2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh2D"/> class by cloning an existing mesh.
        /// </summary>
        /// <param name="mesh2D">The source mesh to clone.</param>
        public Mesh2D(Mesh2D? mesh2D)
            : base(mesh2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh2D"/> class with specified points and indices.
        /// </summary>
        /// <param name="points">The collection of vertices.</param>
        /// <param name="indexes">The index arrays defining triangles.</param>
        public Mesh2D(IEnumerable<Point2D>? points, IEnumerable<int[]>? indexes)
            : base(points, indexes)
        {
        }

        /// <summary>
        /// Creates a clone of the current mesh.
        /// </summary>
        /// <returns>A cloned instance of the mesh.</returns>
        public override ISerializableObject? Clone()
        {
            return new Mesh2D(this);
        }

        /// <summary>
        /// Retrieves the auxiliary segments of the mesh.
        /// </summary>
        /// <returns>A list of auxiliary segments, or null if the mesh is invalid.</returns>
        public List<Segment2D>? GetAuxiliarySegments()
        {
            if (points is null || indexes is null)
            {
                return null;
            }

            List<int[]>? auxiliaryIndexes = Core.Query.AuxiliaryIndexes(indexes);
            if (auxiliaryIndexes is null)
            {
                return null;
            }

            List<Segment2D> result = [];
            foreach (int[] indexes_Segment2D in auxiliaryIndexes)
            {
                result.Add(new Segment2D(points[indexes_Segment2D[0]], points[indexes_Segment2D[1]]));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the boundary edges of the mesh as polygons.
        /// </summary>
        /// <returns>A list of polygons forming the boundary, or null if the mesh is invalid.</returns>
        public List<Polygon2D>? GetBoundaryEdges()
        {
            if (points is null || indexes is null)
            {
                return null;
            }

            List<List<int>>? indexesList = Core.Query.SortedBoundaryIndexes(indexes);
            if (indexesList is null)
            {
                return null;
            }

            List<Polygon2D>? result = [];
            foreach (List<int> indexes_Polygon2D in indexesList)
            {
                List<Point2D> point2Ds = [];
                foreach (int index in indexes_Polygon2D)
                {
                    point2Ds.Add(points[index]);
                }

                result.Add(new Polygon2D(point2Ds));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the boundary edges of the mesh as polygons and returns auxiliary segments via an out parameter.
        /// </summary>
        /// <param name="auxiliarySegments">The output list of auxiliary segments.</param>
        /// <returns>A list of polygons forming the boundary, or null if the mesh is invalid.</returns>
        public List<Polygon2D>? GetBoundaryEdges(out List<Segment2D>? auxiliarySegments)
        {
            auxiliarySegments = null;

            if (points is null || indexes is null)
            {
                return null;
            }

            List<List<int>>? indexesList = Core.Query.SortedBoundaryIndexes(indexes, out List<int[]>? auxiliaryIndexes);
            if (auxiliaryIndexes != null)
            {
                auxiliarySegments = [];
                foreach (int[] indexes_Segment2D in auxiliaryIndexes)
                {
                    auxiliarySegments.Add(new Segment2D(points[indexes_Segment2D[0]], points[indexes_Segment2D[1]]));
                }
            }

            List<Polygon2D>? result = null;
            if (indexesList is not null)
            {
                result = [];
                foreach (List<int> indexes_Polygon2D in indexesList)
                {
                    List<Point2D> point2Ds = [];
                    foreach (int index in indexes_Polygon2D)
                    {
                        point2Ds.Add(points[index]);
                    }

                    result.Add(new Polygon2D(point2Ds));
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the mesh.
        /// </summary>
        /// <returns>The bounding box encompassing all points in the mesh.</returns>
        public BoundingBox2D? GetBoundingBox()
        {
            if (points == null)
            {
                return null;
            }

            return new BoundingBox2D(points);
        }

        /// <summary>
        /// Retrieves all unique segments (edges) of the mesh.
        /// </summary>
        /// <returns>A list of all edges in the mesh, or null if the mesh is invalid.</returns>
        public List<Segment2D>? GetSegements()
        {
            if (points == null || indexes == null)
            {
                return null;
            }

            int count = TrianglesCount;
            if (count == -1)
            {
                return null;
            }

            List<Segment2D> result = [];

            Dictionary<int, HashSet<int>> dictionary = [];
            for (int i = 0; i < count; i++)
            {
                List<int> indexes_Triangle = [.. indexes[i]];
                indexes_Triangle.Add(indexes_Triangle.First());

                for (int j = 0; j < indexes_Triangle.Count - 1; j++)
                {
                    int index_1 = System.Math.Max(indexes_Triangle[j], indexes_Triangle[j + 1]);
                    int index_2 = System.Math.Min(indexes_Triangle[j], indexes_Triangle[j + 1]);

                    if (dictionary.TryGetValue(index_1, out HashSet<int> indexes_Index) && indexes_Index != null)
                    {
                        if (indexes_Index.Contains(index_2))
                        {
                            continue;
                        }
                    }

                    if (indexes_Index == null)
                    {
                        indexes_Index = [];
                        dictionary[index_1] = indexes_Index;
                    }

                    indexes_Index.Add(index_2);

                    result.Add(new Segment2D(points[indexes_Triangle[j]], points[indexes_Triangle[j + 1]]));
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the triangle at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the triangle.</param>
        /// <returns>The Triangle2D at the specified index, or null if out of range.</returns>
        public Triangle2D? GetTriangle(int index)
        {
            if (points == null || indexes == null)
            {
                return null;
            }

            if (index < 0 || index >= indexes.Count)
            {
                return null;
            }

            int index_1 = indexes[index][0];
            if (index_1 < 0 || index_1 >= points.Count)
            {
                return null;
            }

            int index_2 = indexes[index][1];
            if (index_2 < 0 || index_2 >= points.Count)
            {
                return null;
            }

            int index_3 = indexes[index][2];
            if (index_3 < 0 || index_3 >= points.Count)
            {
                return null;
            }

            return new Triangle2D(points[index_1], points[index_2], points[index_3]);
        }

        /// <summary>
        /// Retrieves all triangles in the mesh.
        /// </summary>
        /// <returns>A list of all Triangle2D objects in the mesh, or null if the mesh is invalid.</returns>
        public List<Triangle2D>? GetTriangles()
        {
            if (points == null || indexes == null)
            {
                return null;
            }

            int count = TrianglesCount;
            if (count == -1)
            {
                return null;
            }

            List<Triangle2D> result = [];
            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < TrianglesCount; i++)
            {
                Triangle2D? triangle2D = GetTriangle(i);
                if (triangle2D == null)
                {
                    continue;
                }

                result.Add(triangle2D);
            }

            return result;
        }

        /// <summary>
        /// Moves the mesh by translating all its vertices.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public bool Move(Vector2D? vector2D)
        {
            if (points == null || vector2D is null)
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
        /// Transforms the mesh by transforming all its vertices.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public bool Transform(ITransform2D transform)
        {
            if (transform == null || points == null)
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