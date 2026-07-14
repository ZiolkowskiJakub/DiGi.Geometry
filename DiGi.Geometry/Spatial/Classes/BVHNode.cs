using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents an abstract, generic split-axis Bounding Volume Hierarchy (BVH) node 
    /// designed to accelerate constructive solid geometry (CSG) queries on 3D polyhedra.
    /// This structure partitions 3D polygonal faces hierarchically for fast spatial overlap culling
    /// during boolean operations such as Intersection, Union, and Difference.
    /// </summary>
    /// <typeparam name="TPolygonalFace3D">The type of 3D polygonal face, implementing <see cref="IPolygonalFace3D"/>.</typeparam>
    public abstract class BVHNode<TPolygonalFace3D> : SerializableObject where TPolygonalFace3D : IPolygonalFace3D
    {
        [JsonInclude, JsonPropertyName(nameof(Box))]
        private readonly BoundingBox3D? box;

        [JsonInclude, JsonPropertyName(nameof(Left))]
        private readonly BVHNode<TPolygonalFace3D>? left;

        [JsonInclude, JsonPropertyName(nameof(Right))]
        private readonly BVHNode<TPolygonalFace3D>? right;

        [JsonInclude, JsonPropertyName(nameof(Faces))]
        private readonly List<TPolygonalFace3D>? faces;

        /// <summary>
        /// Initializes a new instance of the <see cref="BVHNode{TPolygonalFace3D}"/> class 
        /// by partitioning the input list of faces hierarchically.
        /// </summary>
        /// <param name="polygonalFace3Ds">The list of polygonal faces to organize inside the spatial hierarchy.</param>
        protected BVHNode(List<TPolygonalFace3D>? polygonalFace3Ds)
            : base()
        {
            if (polygonalFace3Ds == null)
            {
                return;
            }

            if (polygonalFace3Ds.Count <= 4)
            {
                faces = polygonalFace3Ds;
                List<IPolygonalFace3D> list_Faces = [];
                for (int i = 0; i < polygonalFace3Ds.Count; i++)
                {
                    list_Faces.Add(polygonalFace3Ds[i]);
                }
                box = Create.BoundingBox3D(list_Faces) ?? new BoundingBox3D(new Point3D(0, 0, 0), new Point3D(0, 0, 0));
            }
            else
            {
                faces = [];
                List<IPolygonalFace3D> list_Faces = [];
                for (int i = 0; i < polygonalFace3Ds.Count; i++)
                {
                    list_Faces.Add(polygonalFace3Ds[i]);
                }
                box = Create.BoundingBox3D(list_Faces) ?? new BoundingBox3D(new Point3D(0, 0, 0), new Point3D(0, 0, 0));

                double double_Dx = box.Max.X - box.Min.X;
                double double_Dy = box.Max.Y - box.Min.Y;
                double double_Dz = box.Max.Z - box.Min.Z;

                int int_Axis = 0;
                if (double_Dy > double_Dx && double_Dy > double_Dz)
                {
                    int_Axis = 1;
                }
                else if (double_Dz > double_Dx && double_Dz > double_Dy)
                {
                    int_Axis = 2;
                }

                List<TPolygonalFace3D> list_Sorted = [.. polygonalFace3Ds];
                list_Sorted.Sort((f1, f2) =>
                {
                    double double_C1 = GetCentroidCoordinate(f1, int_Axis);
                    double double_C2 = GetCentroidCoordinate(f2, int_Axis);
                    return double_C1.CompareTo(double_C2);
                });

                int int_Mid = list_Sorted.Count / 2;
                left = CreateNode(list_Sorted.GetRange(0, int_Mid));
                right = CreateNode(list_Sorted.GetRange(int_Mid, list_Sorted.Count - int_Mid));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BVHNode{TPolygonalFace3D}"/> class 
        /// by copying the properties from an existing node.
        /// </summary>
        /// <param name="other">The source node to copy values from.</param>
        protected BVHNode(BVHNode<TPolygonalFace3D>? other)
            : base(other)
        {
            if (other != null)
            {
                box = other.box == null ? null : new BoundingBox3D(other.box);
                left = other.left == null ? null : (BVHNode<TPolygonalFace3D>?)other.left.Clone();
                right = other.right == null ? null : (BVHNode<TPolygonalFace3D>?)other.right.Clone();
                faces = other.faces == null ? null : new List<TPolygonalFace3D>(other.faces);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BVHNode{TPolygonalFace3D}"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the node.</param>
        protected BVHNode(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the bounding box that encompasses all geometry in this node and its children.
        /// </summary>
        [JsonIgnore]
        public BoundingBox3D? Box => box;

        /// <summary>
        /// Gets the left child node in the spatial hierarchy.
        /// </summary>
        [JsonIgnore]
        public BVHNode<TPolygonalFace3D>? Left => left;

        /// <summary>
        /// Gets the right child node in the spatial hierarchy.
        /// </summary>
        [JsonIgnore]
        public BVHNode<TPolygonalFace3D>? Right => right;

        /// <summary>
        /// Gets the list of polygonal faces stored directly in this leaf node (null or empty if this is an internal node).
        /// </summary>
        [JsonIgnore]
        public List<TPolygonalFace3D>? Faces => faces;

        /// <summary>
        /// Creates a child node of the concrete hierarchy type.
        /// </summary>
        /// <param name="polygonalFace3Ds">The list of polygonal faces to assign to the child node.</param>
        /// <returns>A concrete child instance of <see cref="BVHNode{TPolygonalFace3D}"/>.</returns>
        protected abstract BVHNode<TPolygonalFace3D>? CreateNode(List<TPolygonalFace3D> polygonalFace3Ds);

        private static double GetCentroidCoordinate(TPolygonalFace3D polygonalFace3D, int int_Axis)
        {
            Point3D? point3D_Centroid = polygonalFace3D.ExternalEdge?.GetCentroid() ?? polygonalFace3D.GetInternalPoint(DiGi.Core.Constants.Tolerance.Distance);
            if (point3D_Centroid == null)
            {
                BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();
                if (boundingBox3D != null)
                {
                    point3D_Centroid = new Point3D((boundingBox3D.Min.X + boundingBox3D.Max.X) / 2.0, (boundingBox3D.Min.Y + boundingBox3D.Max.Y) / 2.0, (boundingBox3D.Min.Z + boundingBox3D.Max.Z) / 2.0);
                }
                else
                {
                    point3D_Centroid = new Point3D(0, 0, 0);
                }
            }

            return int_Axis switch
            {
                0 => point3D_Centroid.X,
                1 => point3D_Centroid.Y,
                2 => point3D_Centroid.Z,
                _ => point3D_Centroid.X
            };
        }
    }

    /// <summary>
    /// Represents a concrete, non-generic split-axis Bounding Volume Hierarchy (BVH) node
    /// that stores <see cref="IPolygonalFace3D"/> elements.
    /// </summary>
    public class BVHNode : BVHNode<IPolygonalFace3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BVHNode"/> class by partitioning the input list of faces.
        /// </summary>
        /// <param name="polygonalFace3Ds">The list of polygonal faces to partition.</param>
        public BVHNode(List<IPolygonalFace3D>? polygonalFace3Ds)
            : base(polygonalFace3Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BVHNode"/> class by copying from another node.
        /// </summary>
        /// <param name="other">The source node to copy from.</param>
        public BVHNode(BVHNode? other)
            : base(other)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BVHNode"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to deserialize.</param>
        public BVHNode(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Creates a concrete child node of type <see cref="BVHNode"/>.
        /// </summary>
        /// <param name="polygonalFace3Ds">The list of polygonal faces to assign to the child node.</param>
        /// <returns>A concrete child instance of <see cref="BVHNode"/>.</returns>
        protected override BVHNode<IPolygonalFace3D>? CreateNode(List<IPolygonalFace3D> polygonalFace3Ds)
        {
            return new BVHNode(polygonalFace3Ds);
        }

        /// <summary>
        /// Deep copies the current BVH tree.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a cloned copy of the current node.</returns>
        public override ISerializableObject? Clone()
        {
            return new BVHNode(this);
        }
    }
}
