using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class ProjectionResult : PlanarResult
    {
        public ProjectionResult()
            : base()
        {

        }

        public ProjectionResult(Plane plane)
            : base(plane)
        {

        }

        public ProjectionResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ProjectionResult(ProjectionResult projectionResult)
            : base(projectionResult)
        {

        }

        public ProjectionResult(Plane plane, IEnumerable<IGeometry2D> geometry2Ds)
            : base(plane, geometry2Ds)
        {

        }

        public ProjectionResult(Plane plane, IGeometry2D geometry2D)
            : base(plane, geometry2D)
        {

        }

        public override ISerializableObject Clone()
        {
            return new ProjectionResult(this);
        }
    }
}
