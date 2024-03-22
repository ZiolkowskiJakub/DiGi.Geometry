using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFace3D : PlanarGeometry<PolygonalFace2D>
    {
        public PolygonalFace3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public PolygonalFace3D(Plane plane, PolygonalFace2D polygonalFace2D)
            : base(plane, polygonalFace2D)
        {

        }

        public PolygonalFace3D(PolygonalFace3D polygonalFace3D)
            : base(polygonalFace3D)
        {

        }

        public override ISerializableObject Clone()
        {
            return new PolygonalFace3D(this);
        }
    }
}
