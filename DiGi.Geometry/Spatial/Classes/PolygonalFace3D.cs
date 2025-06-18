using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFace3D : Planar<IPolygonalFace2D>, IPolygonalFace3D
    {
        public PolygonalFace3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public PolygonalFace3D(Plane plane, IPolygonalFace2D polygonalFace2D)
            : base(plane, polygonalFace2D)
        {

        }

        public PolygonalFace3D(PolygonalFace3D polygonalFace3D)
            : base(polygonalFace3D)
        {

        }

        [JsonIgnore]
        public List<IPolygonal3D> Edges
        {
            get
            {

                IPolygonal3D externalEdge = ExternalEdge;
                if (externalEdge == null)
                {
                    return null;
                }

                List<IPolygonal3D> result = new List<IPolygonal3D>() { externalEdge };

                List<IPolygonal3D> internalEdges = InternalEdges;
                if (internalEdges == null || internalEdges.Count == 0)
                {
                    return result;
                }

                for (int i = 0; i < internalEdges.Count; i++)
                {
                    if (internalEdges[i] != null)
                    {
                        result.Add(internalEdges[i]);
                    }
                }

                return result;
            }
        }

        [JsonIgnore]
        public IPolygonal3D ExternalEdge
        {
            get
            {
                if (plane == null || geometry2D == null)
                {
                    return null;
                }

                IPolygonal2D polygonal2D = geometry2D.ExternalEdge;
                if (polygonal2D == null)
                {
                    return null;
                }

                return plane.Convert(polygonal2D);
            }
        }

        [JsonIgnore]
        public List<IPolygonal3D> InternalEdges
        {
            get
            {
                if (plane == null || geometry2D == null)
                {
                    return null;
                }

                List<IPolygonal2D> polygonal2Ds = geometry2D.InternalEdges;
                if (polygonal2Ds == null)
                {
                    return null;
                }

                List<IPolygonal3D> result = new List<IPolygonal3D>();
                for(int i=0; i < polygonal2Ds.Count; i++)
                {
                    result.Add(plane.Convert(polygonal2Ds[i]));
                }

                return result;
            }
        }

        public override ISerializableObject Clone()
        {
            return new PolygonalFace3D(this);
        }

        public Point3D ClosestPoint(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || plane == null || geometry2D == null)
            {
                return null;
            }

            Point2D point2D = plane.Convert(plane.Project(point3D));
            if (point2D == null)
            {
                return null;
            }


            return plane.Convert(geometry2D.ClosestPoint(point2D));
        }

        public double GetArea()
        {
            if (geometry2D == null)
            {
                return double.NaN;
            }

            return geometry2D.GetArea();
        }

        public BoundingBox3D GetBoundingBox()
        {
            return ExternalEdge?.GetBoundingBox();
        }

        public Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return plane?.Convert(geometry2D?.GetInternalPoint(tolerance));
        }

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point3D == null || plane == null || geometry2D == null)
            {
                return false;
            }

            if(!plane.On(point3D, tolerance))
            {
                return false;
            }

            return geometry2D.InRange(plane.Convert(point3D), tolerance);
        }

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || plane == null || geometry2D == null)
            {
                return false;
            }

            if (!plane.On(point3D, tolerance))
            {
                return false;
            }

            return geometry2D.Inside(plane.Convert(point3D), tolerance);
        }

        public bool OnEdge(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || plane == null || geometry2D == null)
            {
                return false;
            }

            if (!plane.On(point3D, tolerance))
            {
                return false;
            }

            return geometry2D.OnEdge(plane.Convert(point3D), tolerance);
        }

        public List<Triangle3D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if (plane == null)
            {
                return null;
            }

            List<Triangle2D> triangle2Ds = geometry2D?.Triangulate(tolerance);
            if (triangle2Ds == null)
            {
                return null;
            }

            List<Triangle3D> result = new List<Triangle3D>();
            for (int i = 0; i < triangle2Ds.Count; i++)
            {
                result.Add(plane.Convert(triangle2Ds[i]));
            }

            return result;
        }
    }
}
