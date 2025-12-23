using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolyhedronInternalPointSolver<TPolyhedron> : InternalPointSolver<TPolyhedron, Point3D> where TPolyhedron : IPolyhedron
    {
        private TPolyhedron? polyhedron;

        private List<PolygonalFace3DInternalPointSolver?>? polygonalFace3DInternalPointSolvers = null;

        private int i = 0;
        private int j = 0;

        public PolyhedronInternalPointSolver(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
            : base(tolerance)
        {

        }

        public PolyhedronInternalPointSolver(int maxCount, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
            : base(maxCount, tolerance)
        {

        }

        public override TPolyhedron? Input
        {
            set
            {
                polyhedron = DiGi.Core.Query.Clone(value);
            }
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
                        outputs.Add(centroid);
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
                    polygonalFace3DInternalPointSolver_1 = new PolygonalFace3DInternalPointSolver(MaxCount, tolerance)
                    {
                        Input = polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i)
                    };
                    polygonalFace3DInternalPointSolvers[i] = polygonalFace3DInternalPointSolver_1;
                }

                if (!polygonalFace3DInternalPointSolver_1.Solve())
                {
                    continue;
                }

                if (polygonalFace3DInternalPointSolver_1.Ouput is not Point3D point3D_1)
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
                        polygonalFace3DInternalPointSolver_2 = new PolygonalFace3DInternalPointSolver(MaxCount, tolerance)
                        {
                            Input = polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(j)
                        };
                        polygonalFace3DInternalPointSolvers[j] = polygonalFace3DInternalPointSolver_2;
                    }

                    if (!polygonalFace3DInternalPointSolver_2.Solve())
                    {
                        continue;
                    }

                    if (polygonalFace3DInternalPointSolver_2.Ouput is not Point3D point3D_2)
                    {
                        continue;
                    }

                    Point3D? internalPoint = point3D_1.Mid(point3D_2);
                    if (polyhedron.Inside(internalPoint, tolerance))
                    {
                        outputs.Add(internalPoint!);
                        this.i = i;
                        this.j = j;
                        return true;
                    }
                }

                j = -1;
            }

            return result;
        }
    }
}

