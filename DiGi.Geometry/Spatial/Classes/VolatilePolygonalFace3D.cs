using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class VolatilePolygonalFace3D : VolatileObject<PolygonalFace3D>
    {
        private BoundingBox3D boundingBox;
        private Point3D internalPoint;
        public VolatilePolygonalFace3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VolatilePolygonalFace3D(PolygonalFace3D polygonalFace3D)
            : base(polygonalFace3D)
        {

        }

        public VolatilePolygonalFace3D(VolatilePolygonalFace3D volatilePolygonalFace3D)
            : base(volatilePolygonalFace3D)
        {
            if(volatilePolygonalFace3D != null)
            {
                internalPoint = volatilePolygonalFace3D.internalPoint == null ? null : new Point3D(volatilePolygonalFace3D.internalPoint);
                boundingBox = volatilePolygonalFace3D.boundingBox == null ? null : new BoundingBox3D(volatilePolygonalFace3D.boundingBox);
            }
        }

        public BoundingBox3D BoundingBox
        {
            get
            {
                if (boundingBox == null)
                {
                    boundingBox = @object.GetBoundingBox();
                }

                return boundingBox == null ? null : new BoundingBox3D(boundingBox);
            }
        }

        public Point3D InternalPoint
        {
            get
            {
                if (internalPoint == null)
                {
                    internalPoint = @object.GetInternalPoint();
                }

                return internalPoint == null ? null : new Point3D(internalPoint);
            }
        }

        public static implicit operator VolatilePolygonalFace3D(PolygonalFace3D polygonalFace3D)
        {
            if (polygonalFace3D == null)
            {
                return default;
            }

            return new VolatilePolygonalFace3D(polygonalFace3D);
        }

        public override ISerializableObject Clone()
        {
            return new VolatilePolygonalFace3D(this);
        }
    }
}
