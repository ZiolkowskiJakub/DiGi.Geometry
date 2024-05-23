using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PlanarIntersectionResult : PlanarResult, IIntersectionResult3D
    {
        public PlanarIntersectionResult()
            : base()
        {

        }

        public PlanarIntersectionResult(Plane plane)
            : base(plane)
        {

        }

        public PlanarIntersectionResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public PlanarIntersectionResult(PlanarIntersectionResult planarIntersectionResult)
            : base(planarIntersectionResult)
        {

        }

        public PlanarIntersectionResult(Plane plane, IEnumerable<IGeometry2D> geometry2Ds)
            : base(plane, geometry2Ds)
        {

        }

        public PlanarIntersectionResult(Plane plane, IGeometry2D geometry2D)
            : base(plane, geometry2D)
        {

        }

        [JsonIgnore]
        public bool Intersect
        {
            get
            {
                return Count > 0;
            }
        }

        public override ISerializableObject Clone()
        {
            return new PlanarIntersectionResult(this);
        }
    }
}
