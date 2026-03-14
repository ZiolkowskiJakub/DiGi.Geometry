using DiGi.Core.Interfaces;
using DiGi.Geometry.Core;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar;
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
        public PolygonalFace3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public PolygonalFace3D(Plane? plane, IPolygonalFace2D? polygonalFace2D)
            : base(plane, polygonalFace2D)
        {
        }

        public PolygonalFace3D(IPolygonal3D? externalEdge)
            : base(externalEdge?.Plane, externalEdge == null ? null : new PolygonalFace2D(externalEdge?.Plane?.Convert(externalEdge)))
        {
        }

        public PolygonalFace3D(PolygonalFace3D? polygonalFace3D)
            : base(polygonalFace3D)
        {
        }

        [JsonIgnore]
        public List<IPolygonal3D>? Edges
        {
            get
            {
                IPolygonal3D? externalEdge = ExternalEdge;
                if (externalEdge == null)
                {
                    return null;
                }

                List<IPolygonal3D> result = [externalEdge];

                List<IPolygonal3D>? internalEdges = InternalEdges;
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
        public IPolygonal3D? ExternalEdge
        {
            get
            {
                if (plane == null || geometry2D == null)
                {
                    return null;
                }

                IPolygonal2D? polygonal2D = geometry2D.ExternalEdge;
                if (polygonal2D == null)
                {
                    return null;
                }

                return plane.Convert(polygonal2D);
            }
        }

        [JsonIgnore]
        public List<IPolygonal3D>? InternalEdges
        {
            get
            {
                if (plane == null || geometry2D == null)
                {
                    return null;
                }

                List<IPolygonal2D>? polygonal2Ds = geometry2D.InternalEdges;
                if (polygonal2Ds == null)
                {
                    return null;
                }

                List<IPolygonal3D> result = [];
                for (int i = 0; i < polygonal2Ds.Count; i++)
                {
                    IPolygonal3D? polygonal3D = plane.Convert(polygonal2Ds[i]);
                    if (polygonal3D is null)
                    {
                        continue;
                    }

                    result.Add(polygonal3D);
                }

                return result;
            }
        }

        public override ISerializableObject? Clone()
        {
            return new PolygonalFace3D(this);
        }

        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D == null || plane == null || geometry2D == null)
            {
                return null;
            }

            Point2D? point2D = plane.Convert(plane.Project(point3D));
            if (point2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.ClosestPoint(point2D));
        }

        public double Distance(Point3D? point3D)
        {
            return ClosestPoint(point3D) is not Point3D closestPoint ? double.NaN : closestPoint.Distance(point3D);
        }

        public double GetArea()
        {
            if (geometry2D == null)
            {
                return double.NaN;
            }

            return geometry2D.GetArea();
        }

        public BoundingBox3D? GetBoundingBox()
        {
            return ExternalEdge?.GetBoundingBox();
        }

        public Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return plane?.Convert(geometry2D?.GetInternalPoint(tolerance));
        }

        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || plane == null || geometry2D == null)
            {
                return false;
            }

            if (!plane.On(point3D, tolerance))
            {
                return false;
            }

            return geometry2D.InRange(plane.Convert(point3D), tolerance);
        }

        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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

        public bool Inverse()
        {
            if (geometry2D is null)
            {
                return false;
            }

            return geometry2D.Inverse();
        }

        public bool OnEdge(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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

        public bool Orient(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            if (externalEdgeOrientation is null && internalEdgeOrientation is null || geometry2D is null)
            {
                return false;
            }

            Orientation? externalEdgeOrientation_Temp = externalEdgeOrientation;
            Orientation? internalEdgeOrientation_Temp = internalEdgeOrientation;

            if (ExternalEdge is not IPolygonal3D externalEdge3D || geometry2D?.ExternalEdge is not IPolygonal2D externalEdge2D)
            {
                return false;
            }

            if (externalEdge3D.Orientation() != externalEdge2D.Orientation())
            {
                if (externalEdgeOrientation_Temp is not null)
                {
                    externalEdgeOrientation_Temp = externalEdgeOrientation_Temp.Value.Opposite();
                }

                if (internalEdgeOrientation_Temp is not null)
                {
                    internalEdgeOrientation_Temp = internalEdgeOrientation_Temp.Value.Opposite();
                }
            }

            return geometry2D.Orient(externalEdgeOrientation_Temp, internalEdgeOrientation_Temp);
        }

        public List<Triangle3D>? Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if (plane == null)
            {
                return null;
            }

            List<Triangle2D>? triangle2Ds = geometry2D?.Triangulate(tolerance);
            if (triangle2Ds == null)
            {
                return null;
            }

            List<Triangle3D>? result = [];
            for (int i = 0; i < triangle2Ds.Count; i++)
            {
                Triangle3D? triangle3D = plane.Convert(triangle2Ds[i]);
                if (triangle3D is null)
                {
                    continue;
                }

                result.Add(triangle3D);
            }

            return result;
        }
    }
}