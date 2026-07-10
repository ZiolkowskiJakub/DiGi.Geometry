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
        /// Initializes a new instance of the <see cref="Mesh3D"/> class from prebuilt lists.
        /// </summary>
        /// <param name="point3Ds">The <see cref="List{Point3D}"/> containing the vertices of the mesh.</param>
        /// <param name="indexes">The <see cref="List{T}"/> of <c>int[]</c> defining the triangle indices of the mesh.</param>
        /// <param name="clone">When <see langword="true"/>, the inputs are defensively copied and validated; when <see langword="false"/>, the supplied lists are adopted directly without cloning. Use <see langword="false"/> only when the caller owns freshly created, valid data that is not shared.</param>
        internal Mesh3D(List<Point3D>? point3Ds, List<int[]>? indexes, bool clone)
            : base(clone ? point3Ds : null, clone ? indexes : null)
        {
            if (!clone)
            {
                points = point3Ds;
                this.indexes = indexes;
            }
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

            List<Segment3D> result = new(auxiliaryIndexes.Count);
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

            List<Polyloop>? result = new(indexesList.Count);
            foreach (List<int> indexes_Polygon3D in indexesList)
            {
                List<Point3D> point3Ds = new(indexes_Polygon3D.Count);
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
                auxiliarySegments = new List<Segment3D>(auxiliaryIndexes.Count);
                foreach (int[] indexes_Segment3D in auxiliaryIndexes)
                {
                    auxiliarySegments.Add(new Segment3D(points[indexes_Segment3D[0]], points[indexes_Segment3D[1]]));
                }
            }

            List<Polyloop>? result = null;
            if (indexesList is not null)
            {
                result = new List<Polyloop>(indexesList.Count);
                foreach (List<int> indexes_Polygon2D in indexesList)
                {
                    List<Point3D> point3Ds = new(indexes_Polygon2D.Count);
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
        /// Calculates the total surface area of the mesh as the sum of the areas of its triangles.
        /// <para>Uses scalar coordinate arithmetic only, without allocating intermediate vector objects.</para>
        /// </summary>
        /// <returns>A <see cref="double"/> representing the total surface area, or <see cref="double.NaN"/> if the points or indexes are unavailable.</returns>
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

                Point3D point3D_1 = points[index_1];
                Point3D point3D_2 = points[index_2];
                Point3D point3D_3 = points[index_3];

                double x_1 = point3D_2.X - point3D_1.X;
                double y_1 = point3D_2.Y - point3D_1.Y;
                double z_1 = point3D_2.Z - point3D_1.Z;

                double x_2 = point3D_3.X - point3D_1.X;
                double y_2 = point3D_3.Y - point3D_1.Y;
                double z_2 = point3D_3.Z - point3D_1.Z;

                double x_Cross = (y_1 * z_2) - (z_1 * y_2);
                double y_Cross = (z_1 * x_2) - (x_1 * z_2);
                double z_Cross = (x_1 * y_2) - (y_1 * x_2);

                result += System.Math.Sqrt((x_Cross * x_Cross) + (y_Cross * y_Cross) + (z_Cross * z_Cross));
            }

            return result * 0.5;
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

            int count = points.Count;

            List<Triangle3D> result = new(indexes.Count);
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

                result.Add(new Triangle3D(points[index_1], points[index_2], points[index_3]));
            }

            return result;
        }

        /// <summary>
        /// Calculates the enclosed volume of the mesh using the divergence theorem (sum of signed tetrahedron volumes relative to the origin).
        /// <para>The result is only meaningful for a closed mesh with consistently oriented triangles; use <see cref="Mesh{TPoint}.IsClosed"/> to verify closedness first.</para>
        /// </summary>
        /// <returns>A <see cref="double"/> representing the absolute enclosed volume, or <see cref="double.NaN"/> if the points or indexes are unavailable.</returns>
        public double GetVolume()
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

                Point3D point3D_1 = points[index_1];
                Point3D point3D_2 = points[index_2];
                Point3D point3D_3 = points[index_3];

                double x_Cross = (point3D_2.Y * point3D_3.Z) - (point3D_2.Z * point3D_3.Y);
                double y_Cross = (point3D_2.Z * point3D_3.X) - (point3D_2.X * point3D_3.Z);
                double z_Cross = (point3D_2.X * point3D_3.Y) - (point3D_2.Y * point3D_3.X);

                result += (point3D_1.X * x_Cross) + (point3D_1.Y * y_Cross) + (point3D_1.Z * z_Cross);
            }

            return System.Math.Abs(result) / 6.0;
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