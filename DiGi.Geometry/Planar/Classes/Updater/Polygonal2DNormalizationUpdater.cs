using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;



namespace DiGi.Geometry.Planar.Classes
{
    public class Polygonal2DNormalizationUpdater : GeometryUpdater<IPolygonal2D>, Core.Interfaces.INormalizationUpdater<IPolygonal2D>
    {
        private readonly Orientation orientation;

        public Polygonal2DNormalizationUpdater(Orientation orientation)
        {
            this.orientation = orientation;
        }

        public bool Normalized()
        {
            return Query.Orientation(Value) == orientation;
        }

        public override bool Update()
        {
            if (Value is null)
            {
                return false;
            }

            return Value.Orient(orientation);
        }
    }
}
