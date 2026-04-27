using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Polyloop : Segmentable3D, IClosedCurve3D, ISegmentable3D, IInvertible3D
    {
        public Polyloop(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Polyloop()
        {
        }

        public Polyloop(Polyloop? polyloop)
            : base(polyloop)
        {
            points = polyloop?.points.Clone()?.FilterNulls() ?? [];
        }

        public Polyloop(IEnumerable<Point3D>? point3Ds)
        {
            points = point3Ds?.Clone()?.FilterNulls() ?? [];
        }

        public double GetPerimeter()
        {
            return Length;
        }

        public override List<Segment3D>? GetSegments()
        {
            return Create.Segment3Ds(points, true);
        }
    }
}