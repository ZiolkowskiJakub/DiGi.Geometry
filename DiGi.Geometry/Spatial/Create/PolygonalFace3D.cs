using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static PolygonalFace3D PolygonalFace3D<T>(this Planar<T> planar) where T : IPolygonal2D
        {
            if(planar == null)
            {
                return null;
            }

            Plane plane = planar.Plane;
            if(plane == null)
            {
                return null;
            }

            T polygonal2D = planar.Geometry2D;
            if(polygonal2D == null)
            {
                return null;
            }

            return new PolygonalFace3D(plane, new PolygonalFace2D(polygonal2D));
        }

        public static PolygonalFace3D PolygonalFace3D(Plane plane, params Point2D[] points)
        {
            if(plane == null || points == null || points.Length < 3)
            {
                return null;
            }

            return new PolygonalFace3D(plane, Planar.Create.PolygonalFace2D(points));
        }

        public static PolygonalFace3D PolygonalFace3D(IPolygonal3D externalEdge, IEnumerable<IPolygonal3D> internalEdges = null, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Plane plane = externalEdge?.Plane;
            if(plane == null)
            {
                return null;
            }

            IPolygonal2D externalEdge2D = plane.Convert(externalEdge);

            List<IPolygonal2D> internalEdge2Ds = null;
            if(internalEdges != null)
            {
                internalEdge2Ds = new List<IPolygonal2D>();
                foreach (IPolygonal3D internalEdge in internalEdges)
                {
                    IPolygonal2D internalEdge2D = plane.Convert(plane.Project<IPolygonal3D>(internalEdge));
                    if (internalEdge2D == null)
                    {
                        continue;
                    }

                    internalEdge2Ds.Add(internalEdge2D);
                }
            }

            PolygonalFace2D polygonalFace2D = Planar.Create.PolygonalFace2D(externalEdge2D, internalEdge2Ds, tolerance);
            if(polygonalFace2D == null)
            {
                return null;
            }

            return new PolygonalFace3D(plane, polygonalFace2D);
        }
    }
}
