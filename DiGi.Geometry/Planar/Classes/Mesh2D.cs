using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
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
        /// Initializes a new instance of the <see cref="Mesh2D"/> class from prebuilt lists.
        /// </summary>
        /// <param name="point2Ds">The <see cref="List{Point2D}"/> containing the vertices of the mesh.</param>
        /// <param name="indexes">The <see cref="List{T}"/> of <c>int[]</c> defining the triangle indices of the mesh.</param>
        /// <param name="clone">When <see langword="true"/>, the inputs are defensively copied and validated; when <see langword="false"/>, the supplied lists are adopted directly without cloning. Use <see langword="false"/> only when the caller owns freshly created, valid data that is not shared.</param>
        internal Mesh2D(List<Point2D>? point2Ds, List<int[]>? indexes, bool clone)
            : base(clone ? point2Ds : null, clone ? indexes : null)
        {
            if (!clone)
            {
                points = point2Ds;
                this.indexes = indexes;
            }
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

            List<Segment2D> result = new(auxiliaryIndexes.Count);
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

            List<Polygon2D>? result = new(indexesList.Count);
            foreach (List<int> indexes_Polygon2D in indexesList)
            {
                List<Point2D> point2Ds = new(indexes_Polygon2D.Count);
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
                auxiliarySegments = new List<Segment2D>(auxiliaryIndexes.Count);
                foreach (int[] indexes_Segment2D in auxiliaryIndexes)
                {
                    auxiliarySegments.Add(new Segment2D(points[indexes_Segment2D[0]], points[indexes_Segment2D[1]]));
                }
            }

            List<Polygon2D>? result = null;
            if (indexesList is not null)
            {
                result = new List<Polygon2D>(indexesList.Count);
                foreach (List<int> indexes_Polygon2D in indexesList)
                {
                    List<Point2D> point2Ds = new(indexes_Polygon2D.Count);
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
        /// Calculates the total area of the mesh as the sum of the areas of its triangles.
        /// <para>Uses scalar coordinate arithmetic only, without allocating intermediate objects.</para>
        /// </summary>
        /// <returns>A <see cref="double"/> representing the total area, or <see cref="double.NaN"/> if the points or indexes are unavailable.</returns>
        public double GetArea()
        {
            if (points == null || indexes == null)
            {
                return double.NaN;
            }

            int count = points.Count;

            double result = 0;
            for (int i = 0; i < indexes.Count; i++)
            {
                int[] indexes_Triangle = indexes[i];

                int index_1 = indexes_Triangle[0];
                int index_2 = indexes_Triangle[1];
                int index_3 = indexes_Triangle[2];

                if (index_1 < 0 || index_1 >= count || index_2 < 0 || index_2 >= count || index_3 < 0 || index_3 >= count)
                {
                    continue;
                }

                Point2D point2D_1 = points[index_1];
                Point2D point2D_2 = points[index_2];
                Point2D point2D_3 = points[index_3];

                double cross = ((point2D_2.X - point2D_1.X) * (point2D_3.Y - point2D_1.Y)) - ((point2D_2.Y - point2D_1.Y) * (point2D_3.X - point2D_1.X));

                result += System.Math.Abs(cross);
            }

            return result * 0.5;
        }

        /// <summary>
        /// Retrieves all unique segments (edges) of the mesh.
        /// </summary>
        /// <returns>A list of all edges in the mesh, or null if the mesh is invalid.</returns>
        public List<Segment2D>? GetSegments()
        {
            if (points == null || indexes == null)
            {
                return null;
            }

            // ValueTuple keys are used deliberately: their seeded rotate-combine hash distributes the highly regular edge index pairs
            // of structured meshes far better than a packed 64-bit integer key, whose default hash (low ^ high) degenerates into long collision chains.
            static (int, int) edgeKey(int index_1, int index_2)
            {
                return index_1 < index_2 ? (index_1, index_2) : (index_2, index_1);
            }

            int count = points.Count;

            List<Segment2D> result = new(indexes.Count * 3 / 2 + 1);
            HashSet<(int, int)> edges = [];
            for (int i = 0; i < indexes.Count; i++)
            {
                int[] indexes_Triangle = indexes[i];
                if (indexes_Triangle == null || indexes_Triangle.Length < 3)
                {
                    continue;
                }

                for (int j = 0; j < 3; j++)
                {
                    int index_1 = indexes_Triangle[j];
                    int index_2 = indexes_Triangle[j == 2 ? 0 : j + 1];

                    if (!edges.Add(edgeKey(index_1, index_2)))
                    {
                        continue;
                    }

                    if (index_1 >= 0 && index_1 < count && index_2 >= 0 && index_2 < count)
                    {
                        result.Add(new Segment2D(points[index_1], points[index_2]));
                    }
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

            int count = points.Count;

            List<Triangle2D> result = new(indexes.Count);
            for (int i = 0; i < indexes.Count; i++)
            {
                int[] indexes_Triangle = indexes[i];

                int index_1 = indexes_Triangle[0];
                int index_2 = indexes_Triangle[1];
                int index_3 = indexes_Triangle[2];

                if (index_1 < 0 || index_1 >= count || index_2 < 0 || index_2 >= count || index_3 < 0 || index_3 >= count)
                {
                    continue;
                }

                result.Add(new Triangle2D(points[index_1], points[index_2], points[index_3]));
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