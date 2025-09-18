using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolyhedronInternalPointSolver<TPolygonalFace3D> : InternalPointSolver<Point3D> where TPolygonalFace3D : IPolygonalFace3D
    {
        private readonly Polyhedron<TPolygonalFace3D>? polyhedron;

        private List<PolygonalFace3DInternalPointSolver?>? polygonalFace3DInternalPointSolvers = null;

        private int i = 0;
        private int j = 0;
        
        public PolyhedronInternalPointSolver(Polyhedron<TPolygonalFace3D>? polyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {
            this.polyhedron = DiGi.Core.Query.Clone(polyhedron);
        }

        public PolyhedronInternalPointSolver(int maxCount, Polyhedron<TPolygonalFace3D>? polyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
            : base(maxCount, tolerance)
        {
            this.polyhedron = DiGi.Core.Query.Clone(polyhedron);
        }

        public override bool Solve()
        {
            if (polyhedron is null)
            {
                return false;
            }

            if (polygonalFace3DInternalPointSolvers is null)
            {
                polygonalFace3DInternalPointSolvers = [.. Enumerable.Repeat<PolygonalFace3DInternalPointSolver?>(null, polyhedron.Count)];

                if (polyhedron.GetBoundingBox() is BoundingBox3D boundingBox3D && boundingBox3D.GetCentroid() is Point3D centroid)
                {
                    if (polyhedron.Inside(centroid, tolerance))
                    {
                        internalPoints.Add(centroid);
                        return true;
                    }
                }
            }

            bool result = false;

            int count = polygonalFace3DInternalPointSolvers.Count;

            for (int i = this.i; i < count - 2; i++)
            {
                PolygonalFace3DInternalPointSolver? polygonalFace3DInternalPointSolver_1 = polygonalFace3DInternalPointSolvers[i];
                if (polygonalFace3DInternalPointSolver_1 is null)
                {
                    polygonalFace3DInternalPointSolver_1 = new PolygonalFace3DInternalPointSolver(MaxCount, polyhedron[i], tolerance);
                    polygonalFace3DInternalPointSolvers[i] = polygonalFace3DInternalPointSolver_1;
                }

                if (!polygonalFace3DInternalPointSolver_1.Solve())
                {
                    continue;
                }

                if (polygonalFace3DInternalPointSolver_1.InternalPoint is not Point3D point3D_1)
                {
                    continue;
                }

                for (int j = 1; j < count - 1; j++)
                {
                    if (j <= this.j)
                    {
                        continue;
                    }

                    this.j = j;

                    PolygonalFace3DInternalPointSolver? polygonalFace3DInternalPointSolver_2 = polygonalFace3DInternalPointSolvers[j];
                    if (polygonalFace3DInternalPointSolver_2 is null)
                    {
                        polygonalFace3DInternalPointSolver_2 = new PolygonalFace3DInternalPointSolver(MaxCount, polyhedron[j], tolerance);
                        polygonalFace3DInternalPointSolvers[j] = polygonalFace3DInternalPointSolver_2;
                    }

                    if (!polygonalFace3DInternalPointSolver_2.Solve())
                    {
                        continue;
                    }

                    if (polygonalFace3DInternalPointSolver_2.InternalPoint is not Point3D point3D_2)
                    {
                        continue;
                    }

                    Point3D? internalPoint = point3D_1.Mid(point3D_2);
                    if (polyhedron.Inside(internalPoint, tolerance))
                    {
                        internalPoints.Add(internalPoint!);
                        return true;
                    }
                }

                j = -1;
            }

            return result;
        }
    }
}

