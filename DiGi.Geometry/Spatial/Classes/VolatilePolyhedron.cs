using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class VolatilePolyhedron : VolatileBoundable3D<Polyhedron>
    {
        private Dictionary<double, Point3D> internalPoints;
        
        public VolatilePolyhedron(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VolatilePolyhedron(Polyhedron polyhedron)
            : base(polyhedron)
        {

        }

        public VolatilePolyhedron(VolatilePolyhedron volatilePolyhedron)
            : base(volatilePolyhedron as VolatileBoundable3D<Polyhedron>)
        {
            if(volatilePolyhedron != null)
            {
                if(volatilePolyhedron.internalPoints != null)
                {
                    internalPoints = new Dictionary<double, Point3D>();
                    foreach(KeyValuePair<double, Point3D> keyValuePair in volatilePolyhedron.internalPoints)
                    {
                        internalPoints[keyValuePair.Key] = DiGi.Core.Query.Clone(keyValuePair.Value);
                    }
                }
            }
        }

        public static implicit operator VolatilePolyhedron(Polyhedron polyhedron)
        {
            if (polyhedron == null)
            {
                return default;
            }

            return new VolatilePolyhedron(polyhedron);
        }

        public override ISerializableObject Clone()
        {
            return new VolatilePolyhedron(this);
        }

        public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (internalPoints == null)
            {
                internalPoints = new Dictionary<double, Point3D>();
            }

            if(!internalPoints.TryGetValue(tolerance, out Point3D result))
            {
                result = @object.GetInternalPoint(tolerance);
                internalPoints[tolerance] = result;
            }

            return DiGi.Core.Query.Clone(result);
        }
    }
}
