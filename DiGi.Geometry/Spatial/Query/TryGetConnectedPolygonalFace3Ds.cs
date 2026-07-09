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

            List<Tuple<BoundingBox3D, IPolygonalFace3D>> tuples_Unvisited = new();
            foreach (IPolygonalFace3D polygonalFace3D_Temp in polygonalFace3Ds)
            {
                if (polygonalFace3D_Temp is null || polygonalFace3D_Temp.GetBoundingBox() is not BoundingBox3D boundingBox3D_Temp)
                {
                    continue;
                }

                tuples_Unvisited.Add(new(boundingBox3D_Temp, polygonalFace3D_Temp));
            }

            polygonalFace3Ds_Connected = new();
            Queue<IPolygonalFace3D> polygonalFace3Ds_ToProcess = new();
            polygonalFace3Ds_ToProcess.Enqueue(polygonalFace3D);

            while (polygonalFace3Ds_ToProcess.Count > 0)
            {
                IPolygonalFace3D polygonalFace3D_Current = polygonalFace3Ds_ToProcess.Dequeue();
                List<Segment3D>? segment3Ds_Current = polygonalFace3D_Current.Segment3Ds();
                if (segment3Ds_Current is null || segment3Ds_Current.Count == 0)
                {
                    continue;
                }

                BoundingBox3D? boundingBox_Current = polygonalFace3D_Current.GetBoundingBox();
                if (boundingBox_Current is null)
                {
                    continue;
                }

                List<Tuple<BoundingBox3D, IPolygonalFace3D>> tuples_NextUnvisited = new();

                for (int int_I = 0; int_I < tuples_Unvisited.Count; int_I++)
                {
                    Tuple<BoundingBox3D, IPolygonalFace3D> tuple_Current = tuples_Unvisited[int_I];
                    BoundingBox3D boundingBox_Unvisited = tuple_Current.Item1;
                    IPolygonalFace3D polygonalFace3D_Unvisited = tuple_Current.Item2;

                    if (boundingBox_Current.InRange(boundingBox_Unvisited, tolerance))
                    {
                        bool bool_IsConnected = false;
                        for (int int_J = 0; int_J < segment3Ds_Current.Count; int_J++)
                        {
                            Segment3D segment3D = segment3Ds_Current[int_J];
                            PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(polygonalFace3D_Unvisited, segment3D, tolerance);
                            if (planarIntersectionResult != null && planarIntersectionResult.Any() && planarIntersectionResult.GetGeometry3Ds<ISegmentable3D>() is List<ISegmentable3D> segmentable3Ds)
                            {
                                for (int int_K = 0; int_K < segmentable3Ds.Count; int_K++)
                                {
                                    if (segmentable3Ds[int_K].GetSegments().Any(x => polygonalFace3D_Unvisited.OnEdge(x.Mid(), tolerance)))
                                    {
                                        bool_IsConnected = true;
                                        break;
                                    }
                                }
                            }

                            if (bool_IsConnected)
                            {
                                break;
                            }
                        }

                        if (bool_IsConnected)
                        {
                            polygonalFace3Ds_Connected.Add(polygonalFace3D_Unvisited);
                            polygonalFace3Ds_ToProcess.Enqueue(polygonalFace3D_Unvisited);
                            continue;
                        }
                    }

                    tuples_NextUnvisited.Add(tuple_Current);
                }

                tuples_Unvisited = tuples_NextUnvisited;
            }

            polygonalFace3Ds_Disconnected = new();
            for (int int_I = 0; int_I < tuples_Unvisited.Count; int_I++)
            {
                polygonalFace3Ds_Disconnected.Add(tuples_Unvisited[int_I].Item2);
            }

            return true;
        }
    }
}