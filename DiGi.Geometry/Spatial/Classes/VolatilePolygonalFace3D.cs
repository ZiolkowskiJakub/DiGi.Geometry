using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class VolatilePolygonalFace3D : VolatileBoundable3D<PolygonalFace3D>
    {
        private Dictionary<double, Point3D> internalPoints;
        public VolatilePolygonalFace3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VolatilePolygonalFace3D(PolygonalFace3D polygonalFace3D)
            : base(polygonalFace3D)
        {

        }

        public VolatilePolygonalFace3D(VolatilePolygonalFace3D volatilePolygonalFace3D)
            : base(volatilePolygonalFace3D as VolatileBoundable3D<PolygonalFace3D>)
        {
            if (volatilePolygonalFace3D != null)
            {
                if (volatilePolygonalFace3D.internalPoints != null)
                {
                    internalPoints = new Dictionary<double, Point3D>();
                    foreach (KeyValuePair<double, Point3D> keyValuePair in volatilePolygonalFace3D.internalPoints)
                    {
                        internalPoints[keyValuePair.Key] = DiGi.Core.Query.Clone(keyValuePair.Value);
                    }
                }
            }
        }

        public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (internalPoints == null)
            {
                internalPoints = new Dictionary<double, Point3D>();
            }

            if (!internalPoints.TryGetValue(tolerance, out Point3D result))
            {
                result = @object.GetInternalPoint(tolerance);
                internalPoints[tolerance] = result;
            }

            return DiGi.Core.Query.Clone(result);
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
