using DiGi.Core;
using DiGi.Core.Constans;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Polyhedron : Polyhedron<IPolygonalFace3D>
    {
        public Polyhedron(Polyhedron? polyhedron)
            :base(polyhedron)
        {

        }

        public Polyhedron(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        internal Polyhedron(IEnumerable<IPolygonalFace3D>? polygonalFaces)
            :base(polygonalFaces)
        {

        }

        public override ISerializableObject? Clone()
        {
            return new Polyhedron(this);
        }
    }

    public abstract class Polyhedron<TPolygonalFace3D> : Geometry3D, IPolyhedron where TPolygonalFace3D : IPolygonalFace3D
    {
        [JsonInclude, JsonPropertyName("PolygonalFaces")]
        protected List<TPolygonalFace3D>? polygonalFaces;

        public Polyhedron(Polyhedron<TPolygonalFace3D>? polyhedron)
            : base(polyhedron)
        {
            polygonalFaces = DiGi.Core.Query.Clone(polyhedron?.polygonalFaces)?.FilterNulls();
        }

        public Polyhedron(JsonObject? jsonObject)
            :base(jsonObject)
        {

        }

        protected Polyhedron(IEnumerable<TPolygonalFace3D>? polygonalFaces)
            :base()
        {
            if (polygonalFaces != null && polygonalFaces.Count() >= 4)
            {
                this.polygonalFaces = [];
                foreach (TPolygonalFace3D polygonalFace in polygonalFaces)
                {
                    if(DiGi.Core.Query.Clone(polygonalFace) is not TPolygonalFace3D polygonalFace_Temp)
                    {
                        continue;
                    }

                    this.polygonalFaces.Add(polygonalFace_Temp);
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
        public List<TPolygonalFace3D>? PolygonalFaces
        {
            get
            {
                if (polygonalFaces == null)
                {
                    return null;
                }

                List<TPolygonalFace3D> result = [];
                for (int i = 0; i < polygonalFaces.Count; i++)
                {
                    if (DiGi.Core.Query.Clone(polygonalFaces[i]) is not TPolygonalFace3D polygonalFace)
                    {
                        continue;
                    }

                    result.Add(polygonalFace);
                }

                return result;
            }
        }

        [JsonIgnore]
        public TPolygonalFace3D? this[int i]
        {
            get
            {
                if(polygonalFaces is null)
                {
                    return default;
                }

                return DiGi.Core.Query.Clone(polygonalFaces[i]);
            }
        }

        public BoundingBox3D? GetBoundingBox()
        {
            if (polygonalFaces == null || polygonalFaces.Count == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = [];
            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                BoundingBox3D? boundingBox3D = polygonalFaces[i]?.GetBoundingBox();
                if (boundingBox3D != null)
                {
                    boundingBox3Ds.Add(boundingBox3D);
                }
            }

            return Create.BoundingBox3D(boundingBox3Ds);
        }

        public Point3D? GetInternalPoint(double tolerance = Tolerance.Distance)
        {
            PolyhedronInternalPointSolver<IPolyhedron> polyhedronInternalPointSolver = new(tolerance)
            {
                Input = this
            };
            if (!polyhedronInternalPointSolver.Solve())
            {
                return null;
            }

            return polyhedronInternalPointSolver.Output;
        }

        public Vector3D? GetNormal(int index, Side? side = null, double tolerance = Tolerance.Distance)
        {
            return GetNormal(index, out _, side, tolerance);
        }

        public Vector3D? GetNormal(int index, out bool inversed, Side? side = null, double tolerance = Tolerance.Distance)
        {
            inversed = false;

            if (polygonalFaces is null)
            {
                return null;
            }

            if (polygonalFaces[index] is not IPolygonalFace3D polygonalFace3D)
            {
                return null;
            }

            if (side is Side.Undefined)
            {
                return null;
            }

            if (polygonalFace3D.Plane?.Normal is not Vector3D result)
            {
                return null;
            }

            if (side is null)
            {
                return result;
            }

            List<Point3D>? point3Ds = null;

            PolygonalFace3DInternalPointSolver polygonalFace3DInternalPointSolver = new(tolerance)
            {
                Input = polygonalFace3D
            };
            while (polygonalFace3DInternalPointSolver.Solve())
            {
                if (polygonalFace3DInternalPointSolver.Ouput is not Point3D internalPoint)
                {
                    break;
                }

                point3Ds = [];
                for (int i = 0; i < polygonalFaces.Count; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }

                    PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(new PolygonalFace3D(polygonalFaces[i].ExternalEdge), internalPoint, internalPoint + result, true, false, tolerance);
                    if (planarIntersectionResult is null || !planarIntersectionResult.Intersect)
                    {
                        continue;
                    }

                    if (planarIntersectionResult.Contains<ILinear2D>())
                    {
                        point3Ds = null;
                        break;
                    }

                    if (planarIntersectionResult.GetGeometry3Ds<Point3D>() is not List<Point3D> point3Ds_Intersection || point3Ds_Intersection.Count > 1)
                    {
                        point3Ds = null;
                        break;
                    }

                    point3Ds.Add(point3Ds_Intersection[0]);
                }

                if (point3Ds is not null)
                {
                    break;
                }
            }

            if (point3Ds is null)
            {
                throw new NotImplementedException();
            }

            bool even = point3Ds.Count % 2 == 0;

            if (even)
            {
                //External

                if (side.Value != Side.External)
                {
                    result.Inverse();
                    inversed = true;
                }
            }
            else
            {
                //Internal

                if (side.Value != Side.Internal)
                {
                    result.Inverse();
                    inversed = true;
                }
            }

            return result;
        }

        public bool InRange(Point3D? point3D, double tolerance = Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            if (On(point3D, tolerance))
            {
                return true;
            }

            int maxCount = 100;

            List<PolygonalFace3DInternalPointSolver?> polygonalFace3DInternalPointSolvers = [.. Enumerable.Repeat<PolygonalFace3DInternalPointSolver?>(null, polygonalFaces.Count)];

            for (int j = 0; j < maxCount; j++)
            {
                for (int i = 0; i < polygonalFaces.Count; i++)
                {
                    PolygonalFace3DInternalPointSolver? polygonalFace3DInternalPointSolver = polygonalFace3DInternalPointSolvers[i];
                    if (polygonalFace3DInternalPointSolver is null)
                    {
                        polygonalFace3DInternalPointSolver = new PolygonalFace3DInternalPointSolver(maxCount, tolerance)
                        {
                            Input = polygonalFaces[i]
                        };
                        polygonalFace3DInternalPointSolvers[i] = polygonalFace3DInternalPointSolver;
                    }

                    if (!polygonalFace3DInternalPointSolver.Solve())
                    {
                        continue;
                    }

                    Point3D? point3D_Temp = polygonalFace3DInternalPointSolver.Ouput;
                    if (point3D_Temp == null)
                    {
                        continue;
                    }

                    IntersectionResult3D? planarIntersectionResult = Create.IntersectionResult3D(this, new Ray3D(point3D, point3D_Temp), tolerance);
                    if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                    {
                        continue;
                    }

                    if (planarIntersectionResult.Contains<Segment3D>())
                    {
                        continue;
                    }

                    List<Point3D>? point3Ds = planarIntersectionResult.GetGeometry3Ds<Point3D>();
                    if (point3Ds == null || point3Ds.Count == 0)
                    {
                        continue;
                    }

                    if (point3Ds.Find(x => OnEdge(x, tolerance)) != null)
                    {
                        continue;
                    }

                    return point3Ds.Count % 2 != 0;
                }
            }

            return false;
        }

        public bool Inside(Point3D? point3D, double tolerance = Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            if (InRange(point3D, tolerance))
            {
                return !On(point3D, tolerance);
            }

            return false;
        }

        public bool Inverse()
        {
            if (polygonalFaces is null)
            {
                return false;
            }

            bool result = false;

            foreach (TPolygonalFace3D polygonalFace in polygonalFaces)
            {
                if (polygonalFace is not null && polygonalFace.Inverse())
                {
                    result = true;
                }
            }

            return result;
        }

        public override bool Move(Vector3D? vector3D)
        {
            if (polygonalFaces == null || polygonalFaces.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                polygonalFaces[i].Move(vector3D);
            }

            return true;
        }

        public bool Normalized(int index, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
        {
            if (polygonalFaces is null)
            {
                return false;
            }

            PolygonalFace3DNormalizationUpdater polygonalFace3DNormalizationSolver = new(externalEdgeOrientation, internalEdgeOrientation)
            {
                Value = polygonalFaces[index]
            };
            return polygonalFace3DNormalizationSolver.Normalized();
        }

        public bool On(Point3D? point3D, double tolerance = Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                if (polygonalFaces[i] is not TPolygonalFace3D polygonalFace3D)
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

        public bool OnEdge(Point3D? point3D, double tolerance = Tolerance.Distance)
        {
            if (point3D == null || polygonalFaces == null)
            {
                return false;
            }

            for (int i = 0; i < polygonalFaces.Count; i++)
            {
                if (polygonalFaces[i] is not TPolygonalFace3D polygonalFace3D)
                {
                    continue;
                }

                if (polygonalFace3D.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                if (!boundingBox3D.InRange(point3D, tolerance))
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

        public bool Orient(int index, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            if (polygonalFaces is null || (externalEdgeOrientation is null && internalEdgeOrientation is null))
            {
                return false;
            }

            return polygonalFaces[index].Orient(externalEdgeOrientation, internalEdgeOrientation);
        }

        public bool Orient(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            if (polygonalFaces is null || (externalEdgeOrientation is null && internalEdgeOrientation is null))
            {
                return false;
            }

            bool result = false;

            foreach (TPolygonalFace3D polygonalFace in polygonalFaces)
            {
                if (polygonalFace is not null && polygonalFace.Orient(externalEdgeOrientation, internalEdgeOrientation))
                {
                    result = true;
                }
            }

            return result;
        }

        public bool SetNormal(int index, Side side, double tolerance = Tolerance.Distance)
        {
            return SetNormal(index, side, out _, tolerance);
        }
        
        public bool SetNormal(int index, Side side, out Vector3D? normal, double tolerance = Tolerance.Distance)
        {
            normal = null;

            if(polygonalFaces is null)
            {
                return false;
            }

            normal = GetNormal(index, out bool inversed, side, tolerance);
            if(normal is null || !inversed)
            {
                return false;
            }

            if(!polygonalFaces[index].Flip())
            {
                return false;
            }

            if(!normal.Inverse())
            {
                return false;
            }

            return true;
        }

        public UPolygonalFace3D? GetPolygonalFace3D<UPolygonalFace3D>(int index) where UPolygonalFace3D : IPolygonalFace3D
        {
            if(polygonalFaces is null)
            {
                return default;
            }

            return polygonalFaces[index] is UPolygonalFace3D result ? result : default;
        }
    }
}
