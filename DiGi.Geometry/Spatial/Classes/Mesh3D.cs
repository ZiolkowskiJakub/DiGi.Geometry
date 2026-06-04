using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional mesh composed of <see cref="Point3D"/> vertices.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Mesh3D"/> class using a <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> containing the mesh data.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Mesh3D"/> class by copying an existing <see cref="Mesh3D"/> instance.
    /// </summary>
    /// <param name="mesh3D">The <see cref="Mesh3D"/> instance to copy.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Mesh3D"/> class using a collection of vertices and indices.
    /// </summary>
    /// <param name="points">An <see cref="IEnumerable{Point3D}"/> containing the vertex points.</param>
    /// <param name="indexes">An <see cref="IEnumerable{int[]}"/> containing the index arrays for the mesh faces.</param>
    /// <summary>
    /// Creates a clone of the current <see cref="Mesh3D"/> instance.
    /// </summary>
    /// <returns>An <see cref="ISerializableObject"/> representing the cloned mesh.</returns>
    public class Mesh3D : Mesh<Point3D>, IGeometry3D, IBoundable3D, ICollectable3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the mesh.</param>
        public Mesh3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D"/> class by copying an existing <see cref="Mesh3D"/> instance.
        /// </summary>
        /// <param name="mesh3D">The <see cref="Mesh3D"/> instance to copy from.</param>
        public Mesh3D(Mesh3D? mesh3D)
            : base(mesh3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3D"/> class using the specified collection of <see cref="Point3D"/> points and integer array indexes.
        /// </summary>
        /// <param name="points">An <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects representing the vertices of the mesh.</param>
        /// <param name="indexes">An <see cref="IEnumerable{T}"/> of <see cref="int"/> arrays representing the vertex indices for each face of the mesh.</param>
        public Mesh3D(IEnumerable<Point3D>? points, IEnumerable<int[]>? indexes)
            : base(points, indexes)
        {
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Mesh3D(this);
        }

        /// <summary>
        /// Retrieves a list of auxiliary segments based on the available points and indexes.
        /// </summary>
        /// <returns>A <see cref="List{Segment3D}"/> containing the auxiliary segments, or <c>null</c> if the points, indexes, or auxiliary index data are unavailable.</returns>
        public List<Segment3D>? GetAuxiliarySegments()
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

            List<Segment3D> result = [];
            foreach (int[] indexes_Segment3D in auxiliaryIndexes)
            {
                result.Add(new Segment3D(points[indexes_Segment3D[0]], points[indexes_Segment3D[1]]));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the boundary edges of the geometry as a list of polyloops.
        /// </summary>
        /// <returns>A <see cref="List{Polyloop}"/> containing the boundary edges if they are successfully calculated; otherwise, null.</returns>
        public List<Polyloop>? GetBoundaryEdges()
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

            List<Polyloop>? result = [];
            foreach (List<int> indexes_Polygon3D in indexesList)
            {
                List<Point3D> point3Ds = [];
                foreach (int index in indexes_Polygon3D)
                {
                    point3Ds.Add(points[index]);
                }

                result.Add(new Polyloop(point3Ds));
            }

            return result;
        }

        /// <summary>
        /// Retrieves the boundary edges as a list of <see cref="Polyloop"/>.
        /// </summary>
        /// <param name="auxiliarySegments">When called, contains a <see cref="List{Segment3D}"/> of auxiliary segments, or <see langword="null"/> if none are found.</param>
        /// <returns>A <see cref="List{Polyloop}"/> containing the boundary edges, or <see langword="null"/> if the points or indexes are not available.</returns>
        public List<Polyloop>? GetBoundaryEdges(out List<Segment3D>? auxiliarySegments)
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
                foreach (int[] indexes_Segment3D in auxiliaryIndexes)
                {
                    auxiliarySegments.Add(new Segment3D(points[indexes_Segment3D[0]], points[indexes_Segment3D[1]]));
                }
            }

            List<Polyloop>? result = null;
            if (indexesList is not null)
            {
                result = [];
                foreach (List<int> indexes_Polygon2D in indexesList)
                {
                    List<Point3D> point3Ds = [];
                    foreach (int index in indexes_Polygon2D)
                    {
                        point3Ds.Add(points[index]);
                    }

                    result.Add(new Polyloop(point3Ds));
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates and returns the bounding box for the set of points.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if the points are not available.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (points == null)
            {
                return null;
            }

            return new(points);
        }

        /// <summary>
        /// Retrieves the <see cref="Triangle3D"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the triangle to retrieve as an <see cref="int"/>.</param>
        /// <returns>A <see cref="Triangle3D"/> object if the index is valid and data exists; otherwise, <c>null</c>.</returns>
        public Triangle3D? GetTriangle(int index)
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

            return new(points[index_1], points[index_2], points[index_3]);
        }

        /// <summary>
        /// Retrieves a list of <see cref="Triangle3D"/> objects based on the available points and indexes.
        /// </summary>
        /// <returns>A <see cref="List{Triangle3D}"/> containing the triangles if the data is valid; otherwise, null.</returns>
        public List<Triangle3D>? GetTriangles()
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

            List<Triangle3D> result = [];
            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < TrianglesCount; i++)
            {
                Triangle3D? triangle3D = GetTriangle(i);
                if (triangle3D is null)
                {
                    continue;
                }

                result.Add(triangle3D);
            }

            return result;
        }

        /// <summary>
        /// Moves all points by the specified Vector3D offset.
        /// </summary>
        /// <param name="vector2D">The Vector3D? translation vector used to move the points.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool Move(Vector3D? vector2D)
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
        /// Transforms the points using the specified 3D transformation.
        /// </summary>
        /// <param name="transform">The <see cref="ITransform3D"/> object used to perform the transformation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the transformation was successfully applied; returns false if the <see cref="ITransform3D"/> transform or the points collection is null.</returns>
        public bool Transform(ITransform3D? transform)
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