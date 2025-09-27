using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;


namespace DiGi.Geometry.Spatial.Classes
{
    public class Polygonal3DNormalizationUpdater : GeometryUpdater<IPolygonal3D>, Core.Interfaces.INormalizationUpdater<IPolygonal3D>
    {
        private readonly Orientation orientation;

        public Polygonal3DNormalizationUpdater(Orientation orientation)
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
