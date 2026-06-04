using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to separate a collection of polygonal faces into those connected and disconnected from a specified source polygonal face based on a distance tolerance.
        /// </summary>
        /// <param name="polygonalFace3D">The source <see cref="IPolygonalFace3D"/> object.</param>
        /// <param name="polygonalFace3Ds">An <see cref="IEnumerable{IPolygonalFace3D}"/> of <see cref="IPolygonalFace3D"/> objects to be evaluated.</param>
        /// <param name="polygonalFace3Ds_Connected">When this method returns, contains a <see cref="List{IPolygonalFace3D}"/> of <see cref="IPolygonalFace3D"/> objects that are connected to the source face; otherwise, null.</param>
        /// <param name="polygonalFace3Ds_Disconnected">When this method returns, contains a <see cref="List{IPolygonalFace3D}"/> of <see cref="IPolygonalFace3D"/> objects that are not connected to the source face; otherwise, null.</param>
        /// <param name="tolerance">The distance <see cref="double"/> tolerance used to determine connectivity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the operation was successful.</returns>
        public static bool TryGetConnectedPolygonalFace3Ds(this IPolygonalFace3D? polygonalFace3D, IEnumerable<IPolygonalFace3D>? polygonalFace3Ds, out List<IPolygonalFace3D>? polygonalFace3Ds_Connected, out List<IPolygonalFace3D>? polygonalFace3Ds_Disconnected, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            polygonalFace3Ds_Connected = null;
            polygonalFace3Ds_Disconnected = null;

            if (polygonalFace3D is null || polygonalFace3Ds is null)
            {
                return false;
            }

            if (polygonalFace3D.GetBoundingBox() is not BoundingBox3D boundingBox3D)
            {
                return false;
            }

            if (polygonalFace3D.Segment3Ds() is not List<Segment3D> segment3Ds)
            {
                return false;
            }

            List<Tuple<BoundingBox3D, IPolygonalFace3D>> tuples = [];

            foreach (IPolygonalFace3D polygonalFace3D_Temp in polygonalFace3Ds)
            {
                if (polygonalFace3D_Temp is null || polygonalFace3D_Temp.GetBoundingBox() is not BoundingBox3D boundingBox3D_Temp)
                {
                    continue;
                }

                tuples.Add(new(boundingBox3D_Temp, polygonalFace3D_Temp));
            }

            polygonalFace3Ds_Connected = [];
            int count = polygonalFace3Ds_Connected.Count;

            do
            {
                count = polygonalFace3Ds_Connected.Count;
                List<Tuple<BoundingBox3D, IPolygonalFace3D>> tuples_Temp = tuples.FindAll(x => boundingBox3D.InRange(x.Item1, tolerance));
                if (tuples_Temp.Count == 0)
                {
                    continue;
                }

                foreach (Tuple<BoundingBox3D, IPolygonalFace3D> tuple_Temp in tuples_Temp)
                {
                    IPolygonalFace3D polygonalFace3D_Temp = tuple_Temp.Item2;

                    bool added = false;
                    foreach (Segment3D segment3D in segment3Ds)
                    {
                        PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(polygonalFace3D_Temp, segment3D, tolerance);
                        if (planarIntersectionResult == null || !planarIntersectionResult.Intersect || planarIntersectionResult.GetGeometry3Ds<ISegmentable3D>() is not List<ISegmentable3D> segmentable3Ds)
                        {
                            continue;
                        }

                        foreach (ISegmentable3D segmentable3D in segmentable3Ds)
                        {
                            if (segmentable3D.GetSegments().Any(x => polygonalFace3D_Temp.OnEdge(x.Mid(), tolerance)))
                            {
                                added = true;

                                tuples.Remove(tuple_Temp);
                                polygonalFace3Ds_Connected.Add(polygonalFace3D_Temp);

                                segment3Ds.AddRange(polygonalFace3D_Temp.Segment3Ds());
                                boundingBox3D.Add(tuple_Temp.Item1);

                                break;
                            }
                        }

                        if (added)
                        {
                            break;
                        }
                    }
                }
            }
            while (polygonalFace3Ds_Connected.Count != count);

            polygonalFace3Ds_Disconnected = tuples.ConvertAll(x => x.Item2);

            return true;
        }
    }
}