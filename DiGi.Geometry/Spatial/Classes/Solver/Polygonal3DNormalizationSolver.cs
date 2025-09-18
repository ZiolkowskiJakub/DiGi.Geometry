using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;


namespace DiGi.Geometry.Spatial.Classes
{
    public class Polygonal3DNormalizationSolver : Core.Interfaces.INormalizationSolver
    {
        private IPolygonal3D? polygonal3D;
        private Orientation orientation;

        public Polygonal3DNormalizationSolver(IPolygonal3D polygonal2D, Orientation orientation)
        {
            this.polygonal3D = DiGi.Core.Query.Clone(polygonal2D);
            this.orientation = orientation;
        }

        public IPolygonal3D? Polygonal2D
        {
            get
            {
                return DiGi.Core.Query.Clone(polygonal3D);
            }
        }

        public bool Solve()
        {
            if(polygonal3D is null)
            {
                return false;
            }

            return polygonal3D.Orient(orientation);
        }

        public bool Normalized()
        {
            return Query.Orientation(polygonal3D) == orientation;
        }

    }
}
