using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFaceExtrusion : Extrusion<IPolygonalFace3D>
    {
        public PolygonalFaceExtrusion(PolygonalFaceExtrusion? polygonalFaceExtrusion)
            : base(polygonalFaceExtrusion)
        {
        }

        public PolygonalFaceExtrusion(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public PolygonalFaceExtrusion(IPolygonalFace3D? surface, Vector3D? vector)
            : base(surface, vector)
        {
        }
    }
}