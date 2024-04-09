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

        public static IntersectionResult3D IntersectionResult3D(this BoundingBox3D boundingBox3D, ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(boundingBox3D == null || linear3D == null)
            {
                return null;
            }

            VolatilePolyhedron volatilePolyhedron = Polyhedron(boundingBox3D);
            if(volatilePolyhedron == null)
            {
                return null;
            }

            return IntersectionResult3D(volatilePolyhedron, linear3D, tolerance);
        }

        public static IntersectionResult3D IntersectionResult3D(this BoundingBox3D boundingBox3D, Point3D point3D, Vector3D direction, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(boundingBox3D == null || direction == null || point3D == null)
            {
                return null;
            }

            IntersectionResult3D intersectionResult3D = IntersectionResult3D(boundingBox3D, new Line3D(point3D, direction), tolerance);
            if(intersectionResult3D == null)
            {
                return null;
            }

            if(!intersectionResult3D.Intersect)
            {
                return intersectionResult3D;
            }

            Vector3D unit = direction.Unit;

            List<IGeometry3D> geometry3Ds = new List<IGeometry3D>();
            foreach(IGeometry3D geometry3D in intersectionResult3D.GetGeometry3Ds<IGeometry3D>())
            {
                if(geometry3D is Point3D)
                {
                    Vector3D unit_Temp = new Vector3D(point3D, (Point3D)geometry3D).Unit;
                    if(unit.AlmostEquals(unit_Temp))
                    {
                        geometry3Ds.Add(geometry3D);
                    }
                }
                else if(geometry3D is Segment3D)
                {
                    Segment3D segment3D = (Segment3D)geometry3D;
                    Vector3D unit_Temp = new Vector3D(point3D, segment3D[0]).Unit;
                    if (unit.AlmostEquals(unit_Temp))
                    {
                        geometry3Ds.Add(new Segment3D(point3D, segment3D[0]));
                    }
                    else
                    {
                        geometry3Ds.Add(new Segment3D(point3D, segment3D[1]));
                    }
                }
            }

            if(geometry3Ds == null || geometry3Ds.Count == 0)
            {
                return new IntersectionResult3D();
            }

            return new IntersectionResult3D(geometry3Ds);
        }
    }
}
