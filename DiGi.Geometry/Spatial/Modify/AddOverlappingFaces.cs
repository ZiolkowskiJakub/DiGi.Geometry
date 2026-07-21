using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Modify
    {
        /// <summary>
        /// Recursively traverses a Bounding Volume Hierarchy (BVH) tree starting at <paramref name="bVHNode"/>
        /// and adds all <see cref="IPolygonalFace3D"/> elements that overlap with <paramref name="boundingBox3D"/>
        /// (within distance <paramref name="tolerance"/>) into the <paramref name="result"/> list.
        /// <para>
        /// <b>CSG Reusability:</b> This method serves as the standard performance-culling query for all 3D constructive
        /// solid geometry (CSG) boolean operations (Intersection, Union, and Difference) between two polyhedra.
        /// For each face of Polyhedron A, query the BVH tree built for Polyhedron B to cull non-intersecting faces,
        /// narrowing candidates down from \(O(N \cdot M)\) to \(O(N \log M)\) before computing splits.
        /// </para>
        /// </summary>
        /// <param name="result">The destination <see cref="List{IPolygonalFace3D}"/> where overlapping faces will be collected.</param>
        /// <param name="bVHNode">The root or subtree node of the Bounding Volume Hierarchy (BVH) to traverse.</param>
        /// <param name="boundingBox3D">The target <see cref="BoundingBox3D"/> representing the search query bounds.</param>
        /// <param name="tolerance">The distance tolerance for coordinate comparison and bounding box overlap checks.</param>
        public static void AddOverlappingFaces(this List<IPolygonalFace3D> result, BVHNode<IPolygonalFace3D>? bVHNode, BoundingBox3D boundingBox3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (result == null || bVHNode == null || boundingBox3D == null || bVHNode.Box == null || !bVHNode.Box.InRange(boundingBox3D, tolerance))
            {
                return;
            }

            if (bVHNode.Faces != null && bVHNode.Faces.Count > 0)
            {
                foreach (IPolygonalFace3D face in bVHNode.Faces)
                {
                    if (face == null)
                    {
                        continue;
                    }

                    BoundingBox3D? faceBbox = face.GetBoundingBox();
                    if (faceBbox != null && faceBbox.InRange(boundingBox3D, tolerance))
                    {
                        result.Add(face);
                    }
                }
            }
            else
            {
                result.AddOverlappingFaces(bVHNode.Left, boundingBox3D, tolerance);
                result.AddOverlappingFaces(bVHNode.Right, boundingBox3D, tolerance);
            }
        }
    }
}