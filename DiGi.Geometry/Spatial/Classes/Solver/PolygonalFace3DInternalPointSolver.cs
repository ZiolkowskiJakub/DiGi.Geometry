using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFace3DInternalPointSolver : IInternalPointSolver<Point3D>
    {
        private readonly Plane? plane;

        private readonly Planar.Classes.PolygonalFace2DInternalPointSolver polygonalFace2DInternalPointSolver;

        public PolygonalFace3DInternalPointSolver(IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            polygonalFace2DInternalPointSolver = new Planar.Classes.PolygonalFace2DInternalPointSolver(polygonalFace3D?.Geometry2D, tolerance);
            plane = polygonalFace3D?.Plane;
        }

        public PolygonalFace3DInternalPointSolver(int maxCount, IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            polygonalFace2DInternalPointSolver = new Planar.Classes.PolygonalFace2DInternalPointSolver(maxCount, polygonalFace3D?.Geometry2D, tolerance);
            plane = polygonalFace3D?.Plane;
        }

        public Point3D? InternalPoint
        {
            get
            {
                return plane.Convert(polygonalFace2DInternalPointSolver.InternalPoint);
            }
        }

        public List<Point3D>? InternalPoints
        {
            get
            {
                return polygonalFace2DInternalPointSolver.InternalPoints?.ConvertAll(plane.Convert).FilterNulls();
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