using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFace3DInternalPointSolver : IInternalPointSolver<IPolygonalFace3D, Point3D>
    {
        private Plane? plane;

        private readonly Planar.Classes.PolygonalFace2DInternalPointSolver polygonalFace2DInternalPointSolver;

        public PolygonalFace3DInternalPointSolver(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            polygonalFace2DInternalPointSolver = new Planar.Classes.PolygonalFace2DInternalPointSolver(tolerance);
        }

        public PolygonalFace3DInternalPointSolver(int maxCount, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            polygonalFace2DInternalPointSolver = new Planar.Classes.PolygonalFace2DInternalPointSolver(maxCount, tolerance);
        }

        public Point3D? Ouput
        {
            get
            {
                return plane.Convert(polygonalFace2DInternalPointSolver.Output);
            }
        }

        public List<Point3D>? Outputs
        {
            get
            {
                return polygonalFace2DInternalPointSolver.Outputs?.ConvertAll(plane.Convert).FilterNulls();
            }
        }

        public int MaxCount
        {
            get
            {
                return polygonalFace2DInternalPointSolver.MaxCount;
            }

            set
            {
                polygonalFace2DInternalPointSolver.MaxCount = value;
            }
        }

        public IPolygonalFace3D? Input
        {
            set
            {
                plane = value?.Plane;
                polygonalFace2DInternalPointSolver.Input = value?.Geometry2D;
            }
        }

        public bool Solve()
        {
            if (polygonalFace2DInternalPointSolver is null || plane is null)
            {
                return false;
            }

            return polygonalFace2DInternalPointSolver.Solve();
        }
    }
}