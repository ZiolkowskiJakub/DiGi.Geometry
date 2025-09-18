using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;


namespace DiGi.Geometry.Planar.Classes
{
    public class Polygonal2DNormalizationSolver : Core.Interfaces.INormalizationSolver
    {
        private IPolygonal2D? polygonal2D;
        private Orientation orientation;

        public Polygonal2DNormalizationSolver(IPolygonal2D polygonal2D, Orientation orientation)
        {
            this.polygonal2D = DiGi.Core.Query.Clone(polygonal2D);
            this.orientation = orientation;
        }

        public IPolygonal2D? Polygonal2D
        {
            get
            {
                return DiGi.Core.Query.Clone(polygonal2D);
            }
        }

        public bool Solve()
        {
            if(polygonal2D is null)
            {
                return false;
            }

            return polygonal2D.Orient(orientation);
        }

        public bool Normalized()
        {
            return Query.Orientation(polygonal2D) == orientation;
        }

    }
}
