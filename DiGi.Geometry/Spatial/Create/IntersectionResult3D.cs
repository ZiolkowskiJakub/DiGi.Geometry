using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static IntersectionResult3D IntersectionResult3D(this VolatilePolyhedron volatilePolyhedron, ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(volatilePolyhedron == null || linear3D == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = volatilePolyhedron.BoundingBox;
            if(boundingBox3D == null)
            {
                return null;
            }

            if (!boundingBox3D.InRange(linear3D as dynamic, tolerance))
            {
                return new IntersectionResult3D();
            }

            Polyhedron polyhedron = volatilePolyhedron.Geometry;
            if(polyhedron == null)
            {
                return null;
            }

            List<Point3D> point3Ds = new List<Point3D>();
            List<Segment3D> segment3Ds = new List<Segment3D>();
            for (int i = 0; i < polyhedron.Count; i++)
            {
                PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(polyhedron[i], linear3D, tolerance);
                if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                foreach(IGeometry3D geometry3D in planarIntersectionResult.GetGeometry3Ds<IGeometry3D>())
                {
                    if(geometry3D is Point3D)
                    {
                        Point3D point3D = (Point3D)geometry3D;
                        DiGi.Core.Modify.Add(point3Ds, point3D, x => point3D.Similar(x, tolerance));
                    }
                    else if (geometry3D is Segment3D)
                    {
                        Segment3D segment3D = (Segment3D)geometry3D;
                        DiGi.Core.Modify.Add(segment3Ds, segment3D, x => segment3D.Similar(x, tolerance));
                    }
                }

            }

            if(point3Ds.Count == 0 && segment3Ds.Count == 0)
            {
                return new IntersectionResult3D();
            }

            List<IGeometry3D> geometry3Ds = new List<IGeometry3D>();
            for(int i =0; i < point3Ds.Count; i++)
            {
                geometry3Ds.Add(point3Ds[i]);
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                geometry3Ds.Add(segment3Ds[i]);
            }

            return new IntersectionResult3D(geometry3Ds);
        }

        public static IntersectionResult3D IntersectionResult3D(this Polyhedron polyhedron, ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polyhedron == null || linear3D == null)
            {
                return null;
            }

            return IntersectionResult3D((VolatilePolyhedron)polyhedron, linear3D, tolerance);
        }
    }
}
