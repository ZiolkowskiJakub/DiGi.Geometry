using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Polyhedron : Polyhedron<IPolygonalFace3D>
    {
        public Polyhedron(Polyhedron polyhedron)
            :base(polyhedron)
        {

        }

        public Polyhedron(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        internal Polyhedron(IEnumerable<IPolygonalFace3D> polygonalFaces)
            :base(polygonalFaces)
        {

        }

        public ISerializableObject Clone()
        {
            return new Polyhedron(this);
        }

        public override BoundingBox3D GetBoundingBox()
        {
            if (polygonalFaces == null || polygonalFaces.Count == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = new List<BoundingBox3D>();
            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                boundingBox3Ds.Add(polygonalFaces[i]?.GetBoundingBox());
            }

            return Create.BoundingBox3D(boundingBox3Ds);
        }

        public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonalFaces == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = GetBoundingBox();
            if (boundingBox3D == null)
            {
                return null;
            }

            Point3D result = boundingBox3D.GetCentroid();
            if (Inside(result, tolerance))
            {
                return result;
            }

            int count = polygonalFaces.Count;

            Dictionary<int, Point3D> dictionary = new Dictionary<int, Point3D>();
            for (int i = 0; i < count; i++)
            {
                dictionary[i] = polygonalFaces[i].GetInternalPoint(tolerance);
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count - 2; j++)
                {
                    Point3D point3D_1 = dictionary[i];
                    Point3D point3D_2 = dictionary[j];

                    IntersectionResult3D planarIntersectionResult = Create.IntersectionResult3D(this, new Line3D(point3D_1, point3D_2), tolerance);
                    if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                    {
                        continue;
                    }

                    if (planarIntersectionResult.Contains<Segment3D>())
                    {
                        continue;
                    }

                    List<Point3D> point3Ds = planarIntersectionResult.GetGeometry3Ds<Point3D>();
                    if (point3Ds == null || point3Ds.Count < 2)
                    {
                        continue;
                    }

                    point3Ds.ExtremePoints(out point3D_1, out point3D_2);

                    DiGi.Core.Modify.Sort(point3Ds, x => x.Distance(point3D_1));

                    for (int k = 0; k < point3Ds.Count - 1; k++)
                    {
                        result = point3Ds[k].Mid(point3Ds[k + 1]);
                        if (Inside(result, tolerance))
                        {
                            return result;
                        }
                    }
                }
            }

            return null;
        }

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                Point3D point3D_Temp = polygonalFaces[i].GetInternalPoint(tolerance);
                if (point3D_Temp == null)
                {
                    continue;
                }

                IntersectionResult3D planarIntersectionResult = Create.IntersectionResult3D(this, new Line3D(point3D, point3D_Temp), tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                if (planarIntersectionResult.Contains<Segment3D>())
                {
                    continue;
                }

                List<Point3D> point3Ds = planarIntersectionResult.GetGeometry3Ds<Point3D>();
                if (point3Ds == null || point3Ds.Count == 0)
                {
                    continue;
                }

                if (point3Ds.Find(x => OnEdge(x, tolerance)) != null)
                {
                    continue;
                }

                return point3Ds.Count % 2 == 0;
            }

            return false;
        }

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            if (!InRange(point3D, tolerance))
            {
                return false;
            }

            return !On(point3D, tolerance);
        }

        public override bool Move(Vector3D vector3D)
        {
            if (polygonalFaces == null)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                IPolygonalFace3D polygonalFace3D = polygonalFaces[i];
                polygonalFace3D.Move(vector3D);

                polygonalFaces[i] = polygonalFace3D;
            }

            return true;
        }
        
        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                BoundingBox3D boundingBox3D = polygonalFaces[i].GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                if (!boundingBox3D.InRange(point3D, tolerance))
                {
                    continue;
                }

                IPolygonalFace3D polygonalFace3D = polygonalFaces[i];
                if (polygonalFace3D == null)
                {
                    continue;
                }

                if (polygonalFace3D.InRange(point3D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }
        
        public bool OnEdge(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                BoundingBox3D boundingBox3D = polygonalFaces[i].GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                if (!boundingBox3D.InRange(point3D, tolerance))
                {
                    continue;
                }

                IPolygonalFace3D polygonalFace3D = polygonalFaces[i];
                if (polygonalFace3D == null)
                {
                    continue;
                }

                if (polygonalFace3D.OnEdge(point3D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public abstract class Polyhedron<TPolyhedronFace> : Geometry3D, IBoundable3D where TPolyhedronFace : IPolyhedronFace
    {
        [JsonInclude, JsonPropertyName("PolygonalFaces")]
        protected List<TPolyhedronFace> polygonalFaces;

        public Polyhedron(Polyhedron<TPolyhedronFace> polyhedron)
            : base(polyhedron)
        {
            polygonalFaces = DiGi.Core.Query.Clone(polyhedron?.polygonalFaces);
        }

        public Polyhedron(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        internal Polyhedron(IEnumerable<TPolyhedronFace> polygonalFaces)
            :base()
        {
            if (polygonalFaces != null && polygonalFaces.Count() >= 4)
            {
                this.polygonalFaces = new List<TPolyhedronFace>();
                foreach (TPolyhedronFace polygonalFace3D in polygonalFaces)
                {
                    this.polygonalFaces.Add(polygonalFace3D);
                }
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                return polygonalFaces == null ? 0 : polygonalFaces.Count;
            }
        }

        [JsonIgnore]
        public List<TPolyhedronFace> PolygonalFaces
        {
            get
            {
                if (polygonalFaces == null)
                {
                    return null;
                }

                List<TPolyhedronFace> result = new List<TPolyhedronFace>();
                for (int i = 0; i < polygonalFaces.Count; i++)
                {
                    result.Add(polygonalFaces[i]);
                }

                return result;
            }
        }

        [JsonIgnore]
        public TPolyhedronFace this[int i]
        {
            get
            {
                return DiGi.Core.Query.Clone(polygonalFaces[i]);
            }
        }

        public abstract BoundingBox3D GetBoundingBox();
    }

    //public class Polyhedron : Geometry3D, IBoundable3D
    //{
    //    [JsonInclude, JsonPropertyName("PolygonalFaces")]
    //    private List<VolatilePolygonalFace3D> polygonalFaces;

    //    public Polyhedron(Polyhedron polyhedron)
    //    {
    //        polygonalFaces = DiGi.Core.Query.Clone(polyhedron?.polygonalFaces);
    //    }

    //    public Polyhedron(JsonObject jsonObject)
    //        : base(jsonObject)
    //    {

    //    }

    //    internal Polyhedron(IEnumerable<PolygonalFace3D> polygonalFaces)
    //    {
    //        if (polygonalFaces != null && polygonalFaces.Count() >= 4)
    //        {
    //            this.polygonalFaces = new List<VolatilePolygonalFace3D>();
    //            foreach (PolygonalFace3D polygonalFace3D in polygonalFaces)
    //            {
    //                this.polygonalFaces.Add(polygonalFace3D);
    //            }
    //        }
    //    }

    //    internal Polyhedron(IEnumerable<VolatilePolygonalFace3D> volatilePolygonalFaces)
    //    {
    //        if (volatilePolygonalFaces != null && volatilePolygonalFaces.Count() >= 4)
    //        {
    //            polygonalFaces = new List<VolatilePolygonalFace3D>();
    //            foreach (VolatilePolygonalFace3D volatilePolygonalFace3D in polygonalFaces)
    //            {
    //                polygonalFaces.Add(new VolatilePolygonalFace3D(volatilePolygonalFace3D));
    //            }
    //        }
    //    }

    //    [JsonIgnore]
    //    public int Count
    //    {
    //        get
    //        {
    //            return polygonalFaces == null ? 0 : polygonalFaces.Count;
    //        }
    //    }

    //    public List<PolygonalFace3D> PolygonalFaces
    //    {
    //        get
    //        {
    //            if (polygonalFaces == null)
    //            {
    //                return null;
    //            }

    //            List<PolygonalFace3D> result = new List<PolygonalFace3D>();
    //            for (int i = 0; i < polygonalFaces.Count; i++)
    //            {
    //                result.Add(polygonalFaces[i].Geometry);
    //            }

    //            return result;
    //        }
    //    }

    //    [JsonIgnore]
    //    public VolatilePolygonalFace3D this[int i]
    //    {
    //        get
    //        {
    //            return DiGi.Core.Query.Clone(polygonalFaces[i]);
    //        }
    //    }

    //    public ISerializableObject Clone()
    //    {
    //        return new Polyhedron(this);
    //    }

    //    public BoundingBox3D GetBoundingBox()
    //    {
    //        if (polygonalFaces == null || polygonalFaces.Count == 0)
    //        {
    //            return null;
    //        }

    //        List<BoundingBox3D> boundingBox3Ds = new List<BoundingBox3D>();
    //        for (int i = 0; i < polygonalFaces.Count; i++)
    //        {
    //            boundingBox3Ds.Add(polygonalFaces[i]?.BoundingBox);
    //        }

    //        return Create.BoundingBox3D(boundingBox3Ds);
    //    }

    //    public override bool Move(Vector3D vector3D)
    //    {
    //        if (polygonalFaces == null)
    //        {
    //            return false;
    //        }

    //        for (int i = 0; i < polygonalFaces.Count; i++)
    //        {
    //            PolygonalFace3D polygonalFace3D = polygonalFaces[i].Geometry;
    //            polygonalFace3D.Move(vector3D);

    //            polygonalFaces[i] = polygonalFace3D;
    //        }

    //        return true;
    //    }

    //    public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
    //    {
    //        if (point3D == null || polygonalFaces == null)
    //        {
    //            return false;
    //        }

    //        for (int i = 0; i < polygonalFaces.Count; i++)
    //        {
    //            Point3D point3D_Temp = polygonalFaces[i].GetInternalPoint(tolerance);
    //            if (point3D_Temp == null)
    //            {
    //                continue;
    //            }

    //            IntersectionResult3D planarIntersectionResult = Create.IntersectionResult3D(this, new Line3D(point3D, point3D_Temp), tolerance);
    //            if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
    //            {
    //                continue;
    //            }

    //            if (planarIntersectionResult.Contains<Segment3D>())
    //            {
    //                continue;
    //            }

    //            List<Point3D> point3Ds = planarIntersectionResult.GetGeometry3Ds<Point3D>();
    //            if (point3Ds == null || point3Ds.Count == 0)
    //            {
    //                continue;
    //            }

    //            if (point3Ds.Find(x => OnEdge(x, tolerance)) != null)
    //            {
    //                continue;
    //            }

    //            return point3Ds.Count % 2 != 0;
    //        }

    //        return false;
    //    }

    //    public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
    //    {
    //        if (point3D == null || polygonalFaces == null)
    //        {
    //            return false;
    //        }

    //        for (int i = 0; i < polygonalFaces.Count; i++)
    //        {
    //            BoundingBox3D boundingBox3D = polygonalFaces[i].BoundingBox;
    //            if (boundingBox3D == null)
    //            {
    //                continue;
    //            }

    //            if (!boundingBox3D.InRange(point3D, tolerance))
    //            {
    //                continue;
    //            }

    //            PolygonalFace3D polygonalFace3D = polygonalFaces[i].Geometry;
    //            if (polygonalFace3D == null)
    //            {
    //                continue;
    //            }

    //            if (polygonalFace3D.InRange(point3D, tolerance))
    //            {
    //                return true;
    //            }
    //        }

    //        return false;
    //    }

    //    public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
    //    {
    //        if (point3D == null || polygonalFaces == null)
    //        {
    //            return false;
    //        }

    //        if (!InRange(point3D, tolerance))
    //        {
    //            return false;
    //        }

    //        return !On(point3D, tolerance);
    //    }

    //    public bool OnEdge(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
    //    {
    //        if (point3D == null || polygonalFaces == null)
    //        {
    //            return false;
    //        }

    //        for (int i = 0; i < polygonalFaces.Count; i++)
    //        {
    //            BoundingBox3D boundingBox3D = polygonalFaces[i].BoundingBox;
    //            if (boundingBox3D == null)
    //            {
    //                continue;
    //            }

    //            if (!boundingBox3D.InRange(point3D, tolerance))
    //            {
    //                continue;
    //            }

    //            PolygonalFace3D polygonalFace3D = polygonalFaces[i].Geometry;
    //            if (polygonalFace3D == null)
    //            {
    //                continue;
    //            }

    //            if (polygonalFace3D.OnEdge(point3D, tolerance))
    //            {
    //                return true;
    //            }
    //        }

    //        return false;
    //    }

    //    public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
    //    {
    //        if (polygonalFaces == null)
    //        {
    //            return null;
    //        }

    //        BoundingBox3D boundingBox3D = GetBoundingBox();
    //        if (boundingBox3D == null)
    //        {
    //            return null;
    //        }

    //        Point3D result = boundingBox3D.GetCentroid();
    //        if (Inside(result, tolerance))
    //        {
    //            return result;
    //        }

    //        int count = polygonalFaces.Count;

    //        for (int i = 0; i < count - 1; i++)
    //        {
    //            for (int j = i + 1; j < count - 2; j++)
    //            {
    //                Point3D point3D_1 = polygonalFaces[i].GetInternalPoint(tolerance);
    //                Point3D point3D_2 = polygonalFaces[j].GetInternalPoint(tolerance);

    //                IntersectionResult3D planarIntersectionResult = Create.IntersectionResult3D(this, new Line3D(point3D_1, point3D_2), tolerance);
    //                if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
    //                {
    //                    continue;
    //                }

    //                if (planarIntersectionResult.Contains<Segment3D>())
    //                {
    //                    continue;
    //                }

    //                List<Point3D> point3Ds = planarIntersectionResult.GetGeometry3Ds<Point3D>();
    //                if (point3Ds == null || point3Ds.Count < 2)
    //                {
    //                    continue;
    //                }

    //                point3Ds.ExtremePoints(out point3D_1, out point3D_2);

    //                DiGi.Core.Modify.Sort(point3Ds, x => x.Distance(point3D_1));

    //                for (int k = 0; k < point3Ds.Count - 1; k++)
    //                {
    //                    result = point3Ds[k].Mid(point3Ds[k + 1]);
    //                    if (Inside(result, tolerance))
    //                    {
    //                        return result;
    //                    }
    //                }
    //            }
    //        }

    //        return null;
    //    }
    //}


}
