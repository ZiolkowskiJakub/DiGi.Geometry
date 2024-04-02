﻿using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Polyhedron Polyhedron(this PolygonalFace3D polygonalFace3D, Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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

            List<PolygonalFace3D> polygonalFace3Ds = new List<PolygonalFace3D>();
            polygonalFace3Ds.Add(polygonalFace3D);

            foreach (IPolygonal3D edge in edges)
            {
                List<Segment3D> segment3Ds = edge?.GetSegments();
                if(segment3Ds == null)
                {
                    continue;
                }

                foreach(Segment3D segment3D in segment3Ds)
                {
                    List<Point3D> point3Ds = new List<Point3D>()
                    {
                        segment3D[0],
                        segment3D[1],
                        segment3D[1].GetMoved(vector3D),
                        segment3D[0].GetMoved(vector3D),

                    };

                    Plane plane_Temp = Create.Plane(point3Ds[0], point3Ds[1], point3Ds[2]);

                    List<Point2D> point2Ds = new List<Point2D>();
                    for(int i = 0; i < point3Ds.Count; i++)
                    {
                        point2Ds.Add(plane_Temp.Convert(point3Ds[i]));
                    }

                    PolygonalFace2D polygonalFace2D = new PolygonalFace2D(new Polygon2D(point2Ds));

                    polygonalFace3Ds.Add(new PolygonalFace3D(plane_Temp, polygonalFace2D));
                }
            }

            polygonalFace3D = new PolygonalFace3D(polygonalFace3D);
            polygonalFace3D.Move(vector3D);
            polygonalFace3Ds.Add(polygonalFace3D);

            return new Polyhedron(polygonalFace3Ds);
        }
    }
}
