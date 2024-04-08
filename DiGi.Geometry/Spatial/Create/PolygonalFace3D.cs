using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;

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
    }
}
