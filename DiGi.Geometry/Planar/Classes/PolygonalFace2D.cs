using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
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

                foreach(IPolygonal2D internalEdge in internalEdges)
                {
                    if(internalEdge != null)
                    {
                        result.Add(DiGi.Core.Query.Clone(internalEdge));
                    }
                }

                return result;
            }
        }

        public override ISerializableObject Clone()
        {
            return new PolygonalFace2D(this);
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

        public override bool Move(Vector2D vector2D)
        {
            if(vector2D == null || externalEdge == null)
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
    }
}
