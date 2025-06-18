using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Polyhedron Polyhedron(this IPolygonalFace3D polygonalFace3D, Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonalFace3D == null || vector3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane;
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

            List<IPolygonal3D> edges = polygonalFace3D.Edges;
            if(edges == null || edges.Count == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = new List<IPolygonalFace3D>() { polygonalFace3D };

            foreach (IPolygonal3D edge in edges)
            {
                List<Segment3D> segment3Ds = edge?.GetSegments();
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

                    List<Point3D> point3Ds = new List<Point3D>()
                    {
                        segment3D[0],
                        segment3D[1],
                        segment3D[1].GetMoved(vector3D),
                        segment3D[0].GetMoved(vector3D),

                    };

                    Plane plane_Temp = Plane(point3Ds[0], point3Ds[1], point3Ds[2]);

                    List<Point2D> point2Ds = new List<Point2D>();
                    for(int i = 0; i < point3Ds.Count; i++)
                    {
                        point2Ds.Add(plane_Temp.Convert(point3Ds[i]));
                    }

                    PolygonalFace2D polygonalFace2D = new PolygonalFace2D(new Polygon2D(point2Ds));

                    polygonalFace3Ds.Add(new PolygonalFace3D(plane_Temp, polygonalFace2D));
                }
            }

            polygonalFace3D = DiGi.Core.Query.Clone(polygonalFace3D);
            polygonalFace3D.Move(vector3D);
            polygonalFace3Ds.Add(polygonalFace3D);

            return new Polyhedron(polygonalFace3Ds);
        }

        public static Polyhedron Polyhedron(this BoundingBox3D boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            List<Polygon3D> polygon3Ds = Polygon3Ds(boundingBox3D);
            if (polygon3Ds == null || polygon3Ds.Count < 3)
            {
                return null;
            }


            List<PolygonalFace3D> polygonalFace3Ds = new List<PolygonalFace3D>();
            for(int i =0; i < polygon3Ds.Count; i++)
            {
                polygonalFace3Ds.Add(PolygonalFace3D(polygon3Ds[i]));
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        public static Polyhedron Polyhedron(this IEnumerable<IPolygonalFace3D> polygonalFace3Ds)
        {
            if(polygonalFace3Ds  == null || polygonalFace3Ds.Count() < 4)
            {
                return null;
            }

            return new Polyhedron(polygonalFace3Ds);
        }
    }
}
