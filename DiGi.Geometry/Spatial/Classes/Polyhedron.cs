using DiGi.Core;
using DiGi.Core.Constants;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a polyhedron composed of polygonal faces.
    /// </summary>
    public class Polyhedron : Polyhedron<IPolygonalFace3D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polyhedron"/> class by copying an existing <see cref="Polyhedron"/> object.
        /// </summary>
        /// <param name="polyhedron">The <see cref="Polyhedron"/> object to copy from.</param>
        public Polyhedron(Polyhedron? polyhedron)
            : base(polyhedron)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyhedron"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the polyhedron.</param>
        public Polyhedron(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        internal Polyhedron(IEnumerable<IPolygonalFace3D>? polygonalFaces)
            : base(polygonalFaces)
        {
        }

        /// <summary>
        /// Creates a clone of the current instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a copy of the current instance, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new Polyhedron(this);
        }
    }

    /// <summary>
    /// Represents an abstract base class for a 3D polyhedron consisting of polygonal faces.
    /// </summary>
    /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
    public abstract class Polyhedron<TPolygonalFace3D> : Geometry3D, IPolyhedron where TPolygonalFace3D : IPolygonalFace3D
    {
        [JsonInclude, JsonPropertyName("PolygonalFaces")]
        protected List<TPolygonalFace3D>? polygonalFaces;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyhedron"/> class using an existing <see cref="Polyhedron{TPolygonalFace3D}"/> instance.
        /// </summary>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> instance to copy from.</param>
        public Polyhedron(Polyhedron<TPolygonalFace3D>? polyhedron)
            : base(polyhedron)
        {
            polygonalFaces = DiGi.Core.Query.Clone(polyhedron?.polygonalFaces)?.FilterNulls();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyhedron"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the polyhedron. This value can be null.</param>
        public Polyhedron(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        protected Polyhedron(IEnumerable<TPolygonalFace3D>? polygonalFaces)
            : base()
        {
            if (polygonalFaces != null && polygonalFaces.Count() >= 4)
            {
                this.polygonalFaces = [];
                foreach (TPolygonalFace3D polygonalFace in polygonalFaces)
                {
                    if (DiGi.Core.Query.Clone(polygonalFace) is not TPolygonalFace3D polygonalFace_Temp)
                    {
                        continue;
                    }

                    this.polygonalFaces.Add(polygonalFace_Temp);
                }
            }
        }

        /// <summary>
        /// Gets the total number of polygonal faces.
        /// </summary>
        /// <value>An <see cref="int"/> representing the count of polygonal faces.</value>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return polygonalFaces == null ? 0 : polygonalFaces.Count;
            }
        }

        /// <summary>
        /// Gets the list of <typeparamref name="TPolygonalFace3D"/> objects representing the polygonal faces.
        /// </summary>
        /// <value>
        /// A <see cref="List{TPolygonalFace3D}"/> containing the cloned polygonal faces, or null if no faces are defined.
        /// </value>
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

        /// <summary>
        /// Gets the polygonal face at the specified index.
        /// </summary>
        /// <param name="i">The zero-based index of the polygonal face to retrieve.</param>
        /// <returns>A clone of the <typeparamref name="TPolygonalFace3D"/> at the specified index, or <c>null</c> if the collection is not initialized.</returns>
        [JsonIgnore]
        public TPolygonalFace3D? this[int i]
        {
            get
            {
                if (polygonalFaces is null)
                {
                    return default;
                }

                return DiGi.Core.Query.Clone(polygonalFaces[i]);
            }
        }

        /// <summary>
        /// Calculates the bounding box that encompasses all polygonal faces of the object.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the total bounding area, or <c>null</c> if there are no polygonal faces.</returns>
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

        /// <summary>
        /// Calculates and returns a point located inside the polyhedron.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine if a point is internal.</param>
        /// <returns>A <see cref="Point3D"/> representing an internal point if one is found; otherwise, null.</returns>
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

        /// <summary>
        /// Gets the normal vector of the polygonal face at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the polygonal face.</param>
        /// <param name="side">An optional <see cref="Side"/> specifying which side of the face to use for the normal calculation.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for calculations.</param>
        /// <returns>A <see cref="Vector3D"/> representing the normal vector if successful; otherwise, <c>null</c>.</returns>
        public Vector3D? GetNormal(int index, Side? side = null, double tolerance = Tolerance.Distance)
        {
            return GetNormal(index, out _, side, tolerance);
        }

        /// <summary>
        /// Gets the normal vector of a polygonal face at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the polygonal face.</param>
        /// <param name="inversed">When called, contains a <see cref="bool"/> value indicating whether the resulting normal is inversed.</param>
        /// <param name="side">An optional <see cref="Side"/> specifying the side to consider for the normal calculation.</param>
        /// <param name="tolerance">A <see cref="double"/> representing the distance tolerance used during calculations.</param>
        /// <returns>A <c>Vector3D?</c> containing the normal vector if successful; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is within the given tolerance range.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating <see langword="true"/> if the point is within range; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located inside the object, excluding points that are on the boundary.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to check for containment.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the point is inside; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Inverts the orientation of all polygonal faces associated with this object.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether at least one polygonal face was successfully inversed; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Moves the object by the specified Vector3D vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? vector to translate the polygonal faces by.</param>
        /// <returns>A bool indicating whether the move operation was successful.</returns>
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

        /// <summary>
        /// Determines whether the polygonal face at the specified index is normalized based on the provided external and internal edge orientations and a distance tolerance.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index of the polygonal face to evaluate.</param>
        /// <param name="externalEdgeOrientation">The optional <see cref="Orientation"/> for external edges.</param>
        /// <param name="internalEdgeOrientation">The optional <see cref="Orientation"/> for internal edges.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine normalization.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the face is normalized; returns <see langword="false"/> if the polygonal faces collection is null.</returns>
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

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located on any of the polygonal faces within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance used for the range check.</param>
        /// <returns>A <see cref="bool"/> indicating whether the <see cref="Point3D"/> is on any of the polygonal faces; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located on the edge of the polygonal faces within the given tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the proximity check.</param>
        /// <returns>A <see cref="bool"/> value indicating <see langword="true"/> if the point is on the edge; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Orients the polygonal face at the specified index using the provided external and internal edge orientations.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index of the polygonal face to orient.</param>
        /// <param name="externalEdgeOrientation">An optional <see cref="Orientation"/> specifying the orientation for external edges.</param>
        /// <param name="internalEdgeOrientation">An optional <see cref="Orientation"/> specifying the orientation for internal edges.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the orientation was successful; returns false if the polygonal faces collection is null or both orientation parameters are null.</returns>
        public bool Orient(int index, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            if (polygonalFaces is null || (externalEdgeOrientation is null && internalEdgeOrientation is null))
            {
                return false;
            }

            return polygonalFaces[index].Orient(externalEdgeOrientation, internalEdgeOrientation);
        }

        /// <summary>
        /// Orients the polygonal faces using the specified external and internal edge orientations.
        /// </summary>
        /// <param name="externalEdgeOrientation">The <see cref="Orientation"/> to apply to external edges, or null if no change is desired.</param>
        /// <param name="internalEdgeOrientation">The <see cref="Orientation"/> to apply to internal edges, or null if no change is desired.</param>
        /// <returns>A <see cref="bool"/> value indicating whether at least one polygonal face was successfully oriented; otherwise, false.</returns>
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

        /// <summary>
        /// Sets the normal for the element at the specified index based on the provided side and tolerance.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index of the target element.</param>
        /// <param name="side">The <see cref="Side"/> specifying which side to process.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for calculations.</param>
        /// <returns>A <see cref="bool"/> indicating whether the normal was successfully set.</returns>
        public bool SetNormal(int index, Side side, double tolerance = Tolerance.Distance)
        {
            return SetNormal(index, side, out _, tolerance);
        }

        /// <summary>
        /// Sets the normal for a specific polygonal face based on the provided side and tolerance.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index of the polygonal face.</param>
        /// <param name="side">The <see cref="Side"/> to be used for calculating the normal.</param>
        /// <param name="normal">When this method returns, contains the calculated <c>Vector3D?</c> normal if successful; otherwise, null.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for distance calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the normal was successfully set and flipped.</returns>
        public bool SetNormal(int index, Side side, out Vector3D? normal, double tolerance = Tolerance.Distance)
        {
            normal = null;

            if (polygonalFaces is null)
            {
                return false;
            }

            normal = GetNormal(index, out bool inversed, side, tolerance);
            if (normal is null || !inversed)
            {
                return false;
            }

            if (!polygonalFaces[index].Flip())
            {
                return false;
            }

            if (!normal.Inverse())
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Retrieves the polygonal face at the specified index, cast to the requested type.
        /// </summary>
        /// <typeparam name="UPolygonalFace3D">The specific type of <see cref="IPolygonalFace3D"/> to retrieve.</typeparam>
        /// <param name="index">The zero-based integer index of the polygonal face in the collection.</param>
        /// <returns>An instance of <typeparam ref="UPolygonalFace3D"/> if the element at the specified index exists and is of the requested type; otherwise, null.</returns>
        public UPolygonalFace3D? GetPolygonalFace3D<UPolygonalFace3D>(int index) where UPolygonalFace3D : IPolygonalFace3D
        {
            if (polygonalFaces is null)
            {
                return default;
            }

            return polygonalFaces[index] is UPolygonalFace3D result ? result : default;
        }
    }
}