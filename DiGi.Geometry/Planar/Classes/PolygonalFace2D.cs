using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class PolygonalFace2D : Geometry2D, IPolygonalFace2D
    {
        [JsonInclude, JsonPropertyName("ExternalEdge")]
        private IPolygonal2D externalEdge;

        [JsonInclude, JsonPropertyName("InternalEdges")]
        private List<IPolygonal2D> internalEdges;

        public PolygonalFace2D(PolygonalFace2D polygonalFace2D)
        {
            if (polygonalFace2D != null)
            {
                externalEdge = DiGi.Core.Query.Clone(polygonalFace2D.externalEdge);
                internalEdges = DiGi.Core.Query.Clone(polygonalFace2D.internalEdges);
            }
        }

        public PolygonalFace2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        internal PolygonalFace2D(IPolygonal2D externalEdge, IEnumerable<IPolygonal2D> internalEdges = null)
        {
            this.externalEdge = DiGi.Core.Query.Clone(externalEdge);
            this.internalEdges = DiGi.Core.Query.Clone(internalEdges);
        }

        [JsonIgnore]
        public List<IPolygonal2D> Edges
        {
            get
            {
                if (externalEdge == null)
                {
                    return null;
                }

                List<IPolygonal2D> result = new List<IPolygonal2D>() { DiGi.Core.Query.Clone(externalEdge) };
                if (internalEdges == null || internalEdges.Count == 0)
                {
                    return result;
                }

                for (int i = 0; i < internalEdges.Count; i++)
                {
                    if (internalEdges[i] != null)
                    {
                        result.Add(DiGi.Core.Query.Clone(internalEdges[i]));
                    }
                }

                return result;
            }
        }

        [JsonIgnore]
        public IPolygonal2D ExternalEdge
        {
            get
            {
                return DiGi.Core.Query.Clone(externalEdge);
            }
        }

        [JsonIgnore]
        public List<IPolygonal2D> InternalEdges
        {
            get
            {
                return DiGi.Core.Query.Clone(internalEdges);
            }
        }
        public override ISerializableObject Clone()
        {
            return new PolygonalFace2D(this);
        }

        public Point2D ClosestPoint(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point2D == null || externalEdge == null)
            {
                return null;
            }

            if(Inside(point2D, tolerance))
            {
                return new Point2D(point2D);
            }

            if(externalEdge.On(point2D, tolerance))
            {
                return new Point2D(point2D);
            }

            if(internalEdges != null)
            {
                for(int i =0; i < internalEdges.Count; i++)
                {
                    if (internalEdges[i] != null && internalEdges[i].On(point2D, tolerance))
                    {
                        return new Point2D(point2D);
                    }
                }
            }

            double distance = double.NaN;

            Point2D result = externalEdge.ClosestPoint(point2D);
            if(result != null)
            {
                distance = result.Distance(point2D);
                if (distance < tolerance)
                {
                    return result;
                }
            }

            if(internalEdges != null)
            {
                for (int i = 0; i < internalEdges.Count; i++)
                {
                    Point2D point2D_Temp = internalEdges[i]?.ClosestPoint(point2D);
                    if(point2D_Temp == null)
                    {
                        continue;
                    }

                    double distance_Temp = point2D_Temp.Distance(point2D);

                    if (double.IsNaN(distance) || distance_Temp < distance)
                    {
                        distance = distance_Temp;
                        result = point2D_Temp;
                    }

                    if(distance < tolerance)
                    {
                        return result;
                    }
                }
            }

            return result;
        }

        public double GetArea()
        {
            if(externalEdge == null)
            {
                return double.NaN;
            }

            double result = externalEdge.GetArea();
            if(double.IsNaN(result) || result == 0)
            {
                return result;
            }

            if(internalEdges != null && internalEdges.Count != 0)
            {
                for(int i=0; i < internalEdges.Count; i++)
                {
                    if (internalEdges[i] == null)
                    {
                        continue;
                    }

                    result -= internalEdges[i].GetArea();
                }
            }

            return result;
        }

        public BoundingBox2D GetBoundingBox()
        {
            return externalEdge?.GetBoundingBox();
        }

        public Point2D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (externalEdge == null)
            {
                return null;
            }

            if (internalEdges == null || internalEdges.Count == 0)
            {
                return externalEdge.GetInternalPoint(tolerance);
            }

            Point2D result = externalEdge.GetCentroid();
            if (Inside(result, tolerance))
            {
                return result;
            }

            List<Point2D> point2Ds = externalEdge.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }


            for (int i = 0; i < internalEdges.Count; i++)
            {
                List<Point2D> point2Ds_Internal = internalEdges[i]?.GetPoints();
                if (point2Ds_Internal != null && point2Ds_Internal.Count > 0)
                {
                    point2Ds.AddRange(point2Ds_Internal);
                }
            }

            int count = point2Ds.Count;
            for (int i = 0; i < count - 2; i++)
            {
                for (int j = 1; j < count - 1; j++)
                {
                    Point2D point2D = point2Ds[i].Mid(point2Ds[j]);
                    if (Inside(point2D, tolerance))
                    {
                        return point2D;
                    }
                }
            }

            return null;
        }

        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point2D == null || externalEdge == null)
            {
                return false;
            }

            if(Inside(point2D, tolerance))
            {
                return true;
            }

            bool result = externalEdge.On(point2D, tolerance);
            if(internalEdges == null || internalEdges.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < internalEdges.Count; i++)
            {
                if (internalEdges[i] != null && internalEdges[i].On(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null || externalEdge == null)
            {
                return false;
            }

            bool result = externalEdge.Inside(point2D, tolerance);
            if(!result)
            {
                return result;
            }

            if (internalEdges == null || internalEdges.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < internalEdges.Count; i++)
            {
                if (internalEdges[i] != null && internalEdges[i].InRange(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Move(Vector2D vector2D)
        {
            if (vector2D == null || externalEdge == null)
            {
                return false;
            }

            externalEdge.Move(vector2D);

            if (internalEdges != null && internalEdges.Count != 0)
            {
                for (int i = 0; i < internalEdges.Count; i++)
                {
                    internalEdges[i]?.Move(vector2D);
                }
            }

            return true;
        }

        public bool OnEdge(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null || externalEdge == null)
            {
                return false;
            }

            bool result = externalEdge.On(point2D, tolerance);
            if(result)
            {
                return result;
            }

            if (internalEdges == null || internalEdges.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < internalEdges.Count; i++)
            {
                if (internalEdges[i] != null && internalEdges[i].On(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }
        
        public override bool Transform(ITransform2D transform)
        {
            if (transform == null || externalEdge == null)
            {
                return false;
            }

            externalEdge.Transform(transform);

            if (internalEdges != null && internalEdges.Count != 0)
            {
                for (int i = 0; i < internalEdges.Count; i++)
                {
                    internalEdges[i]?.Transform(transform);
                }
            }

            return true;
        }

        public virtual List<Triangle2D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if(externalEdge == null)
            {
                return null;
            }

            if(internalEdges == null || internalEdges.Count == 0)
            {
                return externalEdge.Triangulate(tolerance);
            }

            List<Polygon> polygons = Query.Triangulate(this.ToNTS(), tolerance);
            if (polygons == null)
            {
                return null;
            }

            List<Triangle2D> result = new List<Triangle2D>();
            foreach (Polygon polygon in polygons)
            {
                Coordinate[] coordinates = polygon?.Coordinates;
                if (coordinates == null || coordinates.Length != 4)
                {
                    continue;
                }

                result.Add(new Triangle2D(coordinates[0].ToDiGi(), coordinates[1].ToDiGi(), coordinates[2].ToDiGi()));
            }

            return result;
        }
    }
}
