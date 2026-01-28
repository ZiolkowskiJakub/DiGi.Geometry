using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static List<Segment3D>? Segment3Ds(this IPolygonalFace3D? polygonalFace3D, bool external = true, bool @internal = true)
        {
            if (polygonalFace3D is null)
            {
                return null;
            }

            List<Segment3D> result = [];

            if (external && polygonalFace3D.ExternalEdge?.GetSegments() is List<Segment3D> segment3Ds)
            {
                result.AddRange(segment3Ds);
            }

            if (@internal && polygonalFace3D.InternalEdges is List<IPolygonal3D> polygonal3Ds)
            {
                foreach (IPolygonal3D polygonal3D in polygonal3Ds)
                {
                    if (polygonal3D?.GetSegments() is not List<Segment3D> segment3Ds_Temp)
                    {
                        continue;
                    }

                    result.AddRange(segment3Ds_Temp);
                }
            }

            return result;
        }
    }
}