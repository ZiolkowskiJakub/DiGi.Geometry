using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents the extrusion of a polygonal face in three-dimensional space.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="PolygonalFaceExtrusion"/> class using an existing <see cref="PolygonalFaceExtrusion"/> object.
    /// </summary>
    /// <param name="polygonalFaceExtrusion">The <see cref="PolygonalFaceExtrusion"/> instance to copy from.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="PolygonalFaceExtrusion"/> class from a <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data for the extrusion.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="PolygonalFaceExtrusion"/> class using a polygonal face and an extrusion vector.
    /// </summary>
    /// <param name="surface">The <see cref="IPolygonalFace3D"/> surface to be extruded.</param>
    /// <param name="vector">The <see cref="Vector3D"/> defining the direction and distance of the extrusion.</param>
    public class PolygonalFaceExtrusion : Extrusion<IPolygonalFace3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFaceExtrusion"/> class using an existing <see cref="PolygonalFaceExtrusion"/> object.
        /// </summary>
        /// <param name="polygonalFaceExtrusion">The <see cref="PolygonalFaceExtrusion"/> object to copy from.</param>
        public PolygonalFaceExtrusion(PolygonalFaceExtrusion? polygonalFaceExtrusion)
            : base(polygonalFaceExtrusion)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFaceExtrusion"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the extrusion.</param>
        public PolygonalFaceExtrusion(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFaceExtrusion"/> class.
        /// </summary>
        /// <param name="surface">The <see cref="IPolygonalFace3D"/> surface to be extruded.</param>
        /// <param name="vector">The <see cref="Vector3D"/> vector defining the extrusion direction and distance.</param>
        public PolygonalFaceExtrusion(IPolygonalFace3D? surface, Vector3D? vector)
            : base(surface, vector)
        {
        }
    }
}