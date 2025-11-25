using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Polyhedron? Polyhedron(this IPolygonalFace3D? polygonalFace3D, Vector3D? vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonalFace3D == null || vector3D == null)
            {
                return null;
            }

            Plane? plane = polygonalFace3D.Plane;
            if(plane == null)
            {
                return null;
            }
            
            if(vector3D.Length < tolerance)
            {
                return null;
            }

            if(plane.On(vector3D, tolerance))
            {
                return null;
            }

            List<IPolygonal3D>? edges = polygonalFace3D.Edges;
            if(edges == null || edges.Count == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [polygonalFace3D];

            foreach (IPolygonal3D edge in edges)
            {
                List<Segment3D>? segment3Ds = edge?.GetSegments();
                if(segment3Ds == null)
                {
                    continue;
                }

                foreach(Segment3D segment3D in segment3Ds)
                {
                    if(segment3D == null)
                    {
                        continue;
                    }

                    double squareLength = segment3D.SquaredLength;
                    if(double.IsNaN(squareLength) || squareLength == 0)
                    {
                        continue;
                    }

                    Point3D? point3D_2 = segment3D[1]?.GetMoved(vector3D);
                    if(point3D_2 is null)
                    {
                        continue;
                    }

                    Point3D? point3D_3 = segment3D[0]?.GetMoved(vector3D);
                    if (point3D_3 is null)
                    {
                        continue;
                    }

                    List<Point3D> point3Ds =
                    [
                        segment3D[0]!,
                        segment3D[1]!,
                        point3D_2,
                        point3D_3,

                    ];

                    Plane? plane_Temp = Plane(point3Ds[0], point3Ds[1], point3Ds[2]);
                    if (plane_Temp is null)
                    {
                        continue;
                    }

                    List<Point2D> point2Ds = [];
                    for(int i = 0; i < point3Ds.Count; i++)
                    {
                        Point2D? point2D = plane_Temp.Convert(point3Ds[i]);
                        if(point2D is null)
                        {
                            continue;
                        }

                        point2Ds.Add(point2D);
                    }

                    PolygonalFace2D polygonalFace2D = new (new Polygon2D(point2Ds));

                    polygonalFace3Ds.Add(new PolygonalFace3D(plane_Temp, polygonalFace2D));
                }
            }

            IPolygonalFace3D? polygonalFace3D_Temp = DiGi.Core.Query.Clone(polygonalFace3D);
            if(polygonalFace3D_Temp is not null)
            {
                polygonalFace3D_Temp.Move(vector3D);
                polygonalFace3Ds.Add(polygonalFace3D_Temp);
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        public static Polyhedron? Polyhedron(this BoundingBox3D? boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            List<Polygon3D>? polygon3Ds = Polygon3Ds(boundingBox3D);
            if (polygon3Ds == null || polygon3Ds.Count < 3)
            {
                return null;
            }

            List<PolygonalFace3D> polygonalFace3Ds = [];
            for(int i =0; i < polygon3Ds.Count; i++)
            {
                PolygonalFace3D? polygonalFace3D = polygon3Ds[i]?.PolygonalFace3D();
                if(polygonalFace3D is null)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D);
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        public static Polyhedron? Polyhedron(this IEnumerable<IPolygonalFace3D>? polygonalFace3Ds)
        {
            if(polygonalFace3Ds is null || polygonalFace3Ds.Count() < 4)
            {
                return null;
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        public static Polyhedron? Polyhedron(this IPolyhedron polyhedron)
        {
            if (polyhedron is null)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];

            int count = polyhedron.Count;
            if(count > 0)
            {
                for(int i =0; i < count; i++)
                {
                    if(polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is not IPolygonalFace3D polygonalFace3D)
                    {
                        continue;
                    }

                    polygonalFace3Ds.Add(polygonalFace3D);
                }
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        public static Polyhedron? Polyhedron(this PolygonalFaceExtrusion? polygonalFaceExtrusion, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonalFaceExtrusion is null)
            {
                return null;
            }

            return Polyhedron(polygonalFaceExtrusion.Surface, polygonalFaceExtrusion.Vector, tolerance);
        }
    }
}
