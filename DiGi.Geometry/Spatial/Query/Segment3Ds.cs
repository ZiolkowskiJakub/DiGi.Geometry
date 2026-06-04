using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of <see cref="Segment3D"/> objects from the specified <see cref="IPolygonalFace3D"/>, optionally including external and internal edges.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to extract segments from.</param>
        /// <param name="external">A <see cref="bool"/> value indicating whether the external edge segments should be included in the result. Defaults to <c>true</c>.</param>
        /// <param name="internal">A <see cref="bool"/> value indicating whether the internal edge segments should be included in the result. Defaults to <c>true</c>.</param>
        /// <returns>A <see cref="List{Segment3D}"/> containing the extracted segments, or <c>null</c> if the provided <see cref="IPolygonalFace3D"/> is null.</returns>
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