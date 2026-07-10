using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Performs a boolean operation on two polyhedrons and returns a list of polygonal faces resulting from the operation.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The boolean operation splits the faces of each polyhedron by the faces of the other, classifies every resulting fragment
        /// against the opposite volume, and deduplicates overlapping coplanar boundaries. The operation type determines which fragments are kept:
        /// <list type="bullet">
        /// <item><see cref="BooleanOpertaionType.Union"/>: faces of A outside B plus faces of B outside A.</item>
        /// <item><see cref="BooleanOpertaionType.Intersection"/>: faces of A inside B plus faces of B inside A.</item>
        /// <item><see cref="BooleanOpertaionType.Difference"/>: faces of A outside B plus faces of B inside A (with inverted normals).</item>
        /// </list>
        /// </para>
        /// <para>
        /// The output can be further constrained by source polyhedron via <paramref name="inlcudePolyhedron_1"/> and <paramref name="inlcudePolyhedron_2"/>:
        /// setting either to <c>false</c> excludes faces whose internal point lies on or inside the corresponding polyhedron volume.
        /// When both flags are <c>true</c>, all faces from the boolean result are returned without additional filtering overhead.
        /// </para>
        /// <para>
        /// The method returns early for trivial cases without executing the CSG pipeline:
        /// <list type="bullet">
        /// <item>Intersection with disjoint bounding boxes or either polyhedron having no faces returns an empty list.</item>
        /// <item>Difference with disjoint bounding boxes or an empty second polyhedron returns the faces of the first polyhedron (subject to include flags).</item>
        /// <item>Union with disjoint bounding boxes returns the faces of both polyhedrons (subject to include flags).</item>
        /// </list>
        /// </para>
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="booleanOpertaionType">The type of the boolean operation to perform.</param>
        /// <param name="polyhedron_1">The first polyhedron.</param>
        /// <param name="polyhedron_2">The second polyhedron.</param>
        /// <param name="inlcudePolyhedron_1">Whether to include faces originating from the first polyhedron in the result.</param>
        /// <param name="inlcudePolyhedron_2">Whether to include faces originating from the second polyhedron in the result.</param>
        /// <param name="tolerance">The distance tolerance for geometric computations and classification.</param>
        /// <returns>A list of <typeparamref name="TPolygonalFace3D"/> faces resulting from the boolean operation (may be empty), or <c>null</c> if either polyhedron is <c>null</c>.</returns>
        public static List<TPolygonalFace3D>? PolygonalFace3Ds<TPolygonalFace3D>(this BooleanOpertaionType booleanOpertaionType, Polyhedron<TPolygonalFace3D>? polyhedron_1, Polyhedron<TPolygonalFace3D>? polyhedron_2, bool inlcudePolyhedron_1, bool inlcudePolyhedron_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if(polyhedron_1 is null || polyhedron_2 is null)
            {
                return null;
            }

            static List<IPolygonalFace3D> ExtractFaces(Polyhedron<TPolygonalFace3D> polyhedron)
            {
                int count = polyhedron.Count;
                List<IPolygonalFace3D> result = new(count);
                for(int i = 0; i < count; i++)
                {
                    if(polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is IPolygonalFace3D polygonalFace3D)
                    {
                        result.Add(polygonalFace3D);
                    }
                }

                return result;
            }

            static List<TPolygonalFace3D> CastResult(List<IPolygonalFace3D> polygonalFace3Ds)
            {
                List<TPolygonalFace3D> result = new(polygonalFace3Ds.Count);
                for(int i = 0; i < polygonalFace3Ds.Count; i++)
                {
                    if(polygonalFace3Ds[i] is TPolygonalFace3D tPolygonalFace3D)
                    {
                        result.Add(tPolygonalFace3D);
                    }
                }

                return result;
            }

            static List<TPolygonalFace3D> ExtractTypedFaces(Polyhedron<TPolygonalFace3D> polyhedron)
            {
                int count = polyhedron.Count;
                List<TPolygonalFace3D> result = new(count);
                for(int i = 0; i < count; i++)
                {
                    if(polyhedron.GetPolygonalFace3D<TPolygonalFace3D>(i) is TPolygonalFace3D tPolygonalFace3D)
                    {
                        result.Add(tPolygonalFace3D);
                    }
                }

                return result;
            }

            List<IPolygonalFace3D> polygonalFace3Ds_1 = ExtractFaces(polyhedron_1);
            List<IPolygonalFace3D> polygonalFace3Ds_2 = ExtractFaces(polyhedron_2);

            BoundingBox3D? boundingBox3D_1 = polyhedron_1.GetBoundingBox();
            BoundingBox3D? boundingBox3D_2 = polyhedron_2.GetBoundingBox();
            bool aabbIntersect = boundingBox3D_1 != null && boundingBox3D_2 != null && boundingBox3D_1.InRange(boundingBox3D_2, tolerance);

            switch(booleanOpertaionType)
            {
                case BooleanOpertaionType.Intersection:
                    if(!aabbIntersect || polygonalFace3Ds_1.Count == 0 || polygonalFace3Ds_2.Count == 0)
                    {
                        return [];
                    }

                    break;

                case BooleanOpertaionType.Difference:
                    if(!aabbIntersect || polygonalFace3Ds_2.Count == 0)
                    {
                        return inlcudePolyhedron_1 ? ExtractTypedFaces(polyhedron_1) : [];
                    }

                    if(polygonalFace3Ds_1.Count == 0)
                    {
                        return [];
                    }

                    break;

                case BooleanOpertaionType.Union:
                    if(!aabbIntersect)
                    {
                        List<TPolygonalFace3D> result_Disjoint = [];
                        if(inlcudePolyhedron_1)
                        {
                            result_Disjoint.AddRange(ExtractTypedFaces(polyhedron_1));
                        }

                        if(inlcudePolyhedron_2)
                        {
                            result_Disjoint.AddRange(ExtractTypedFaces(polyhedron_2));
                        }

                        return result_Disjoint;
                    }

                    if(polygonalFace3Ds_1.Count == 0 && polygonalFace3Ds_2.Count == 0)
                    {
                        return [];
                    }

                    if(polygonalFace3Ds_1.Count == 0)
                    {
                        return inlcudePolyhedron_2 ? ExtractTypedFaces(polyhedron_2) : [];
                    }

                    if(polygonalFace3Ds_2.Count == 0)
                    {
                        return inlcudePolyhedron_1 ? ExtractTypedFaces(polyhedron_1) : [];
                    }

                    break;
            }

            List<IPolygonalFace3D> polygonalFace3Ds_Result = Create.BooleanOperationPolygonalFace3Ds(booleanOpertaionType, polyhedron_1, polyhedron_2, polygonalFace3Ds_1, polygonalFace3Ds_2, out BVHNode _, tolerance);

            if(inlcudePolyhedron_1 && inlcudePolyhedron_2)
            {
                return CastResult(polygonalFace3Ds_Result);
            }

            PolyhedronPointRelationSolver? polyhedronPointRelationSolver_1 = !inlcudePolyhedron_1 ? new PolyhedronPointRelationSolver(new BVHNode(polygonalFace3Ds_1), tolerance) : null;
            PolyhedronPointRelationSolver? polyhedronPointRelationSolver_2 = !inlcudePolyhedron_2 ? new PolyhedronPointRelationSolver(new BVHNode(polygonalFace3Ds_2), tolerance) : null;

            List<TPolygonalFace3D> result = new(polygonalFace3Ds_Result.Count);
            for(int i = 0; i < polygonalFace3Ds_Result.Count; i++)
            {
                if(polygonalFace3Ds_Result[i] is not TPolygonalFace3D tPolygonalFace3D)
                {
                    continue;
                }

                bool keep = true;
                Point3D? point3D = null;

                if(polyhedronPointRelationSolver_1 != null)
                {
                    point3D = tPolygonalFace3D.GetInternalPoint(tolerance);
                    if(point3D != null && polyhedronPointRelationSolver_1.GetPointRelation(point3D) != PointRelation.Outside)
                    {
                        keep = false;
                    }
                }

                if(keep && polyhedronPointRelationSolver_2 != null)
                {
                    point3D ??= tPolygonalFace3D.GetInternalPoint(tolerance);
                    if(point3D != null && polyhedronPointRelationSolver_2.GetPointRelation(point3D) != PointRelation.Outside)
                    {
                        keep = false;
                    }
                }

                if(keep)
                {
                    result.Add(tPolygonalFace3D);
                }
            }

            return result;
        }
    }
}