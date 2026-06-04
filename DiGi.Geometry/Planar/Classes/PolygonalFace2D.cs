using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional polygonal face defined by an external edge and a collection of internal edges.
    /// </summary>
    public class PolygonalFace2D : Geometry2D, IPolygonalFace2D
    {
        [JsonInclude, JsonPropertyName("ExternalEdge")]
        private readonly IPolygonal2D? externalEdge;

        [JsonInclude, JsonPropertyName("InternalEdges")]
        private readonly List<IPolygonal2D>? internalEdges;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace2D"/> class by cloning an existing polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The source polygonal face to clone.</param>
        public PolygonalFace2D(PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D != null)
            {
                externalEdge = DiGi.Core.Query.Clone(polygonalFace2D.externalEdge);
                internalEdges = DiGi.Core.Query.Clone(polygonalFace2D.internalEdges)?.FilterNulls();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing polygonal face data.</param>
        public PolygonalFace2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace2D"/> class with specified external and internal edges.
        /// </summary>
        /// <param name="externalEdge">The outer boundary of the face.</param>
        /// <param name="internalEdges">The inner boundaries (holes) of the face.</param>
        internal PolygonalFace2D(IPolygonal2D? externalEdge, IEnumerable<IPolygonal2D>? internalEdges = null)
        {
            this.externalEdge = DiGi.Core.Query.Clone(externalEdge);
            this.internalEdges = DiGi.Core.Query.Clone(internalEdges)?.FilterNulls();
        }

        /// <summary>
        /// Gets all edges of the polygonal face, including both external and internal boundaries.
        /// </summary>
        [JsonIgnore]
        public List<IPolygonal2D>? Edges
        {
            get
            {
                if (DiGi.Core.Query.Clone(externalEdge) is not IPolygonal2D externalEdge_Temp)
                {
                    return null;
                }

                List<IPolygonal2D> result = [externalEdge_Temp];
                if (internalEdges == null || internalEdges.Count == 0)
                {
                    return result;
                }

                for (int i = 0; i < internalEdges.Count; i++)
                {
                    if (DiGi.Core.Query.Clone(internalEdges[i]) is IPolygonal2D polygonal2D)
                    {
                        result.Add(polygonal2D);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Gets the external boundary of the polygonal face.
        /// </summary>
        [JsonIgnore]
        public IPolygonal2D? ExternalEdge
        {
            get
            {
                return DiGi.Core.Query.Clone(externalEdge);
            }
        }

        /// <summary>
        /// Gets the internal boundaries (holes) of the polygonal face.
        /// </summary>
        [JsonIgnore]
        public List<IPolygonal2D>? InternalEdges
        {
            get
            {
                return DiGi.Core.Query.Clone(internalEdges)?.FilterNulls();
            }
        }

        /// <summary>
        /// Creates a clone of the current polygonal face.
        /// </summary>
        /// <returns>A cloned instance of the polygonal face.</returns>
        public override ISerializableObject? Clone()
        {
            return new PolygonalFace2D(this);
        }

        /// <summary>
        /// Finds the point on the polygonal face closest to the given point.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>The closest point on the face (including its interior), or null if it cannot be determined.</returns>
        public Point2D? ClosestPoint(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || externalEdge == null)
            {
                return null;
            }

            if (Inside(point2D, tolerance))
            {
                return new Point2D(point2D);
            }

            if (externalEdge.On(point2D, tolerance))
            {
                return new Point2D(point2D);
            }

            if (internalEdges != null)
            {
                for (int i = 0; i < internalEdges.Count; i++)
                {
                    if (internalEdges[i] != null && internalEdges[i].On(point2D, tolerance))
                    {
                        return new(point2D);
                    }
                }
            }

            double distance = double.NaN;

            Point2D? result = externalEdge.ClosestPoint(point2D);
            if (result != null)
            {
                distance = result.Distance(point2D);
                if (distance < tolerance)
                {
                    return result;
                }
            }

            if (internalEdges != null)
            {
                for (int i = 0; i < internalEdges.Count; i++)
                {
                    Point2D? point2D_Temp = internalEdges[i]?.ClosestPoint(point2D);
                    if (point2D_Temp == null)
                    {
                        continue;
                    }

                    double distance_Temp = point2D_Temp.Distance(point2D);

                    if (double.IsNaN(distance) || distance_Temp < distance)
                    {
                        distance = distance_Temp;
                        result = point2D_Temp;
                    }

                    if (distance < tolerance)
                    {
                        return result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates the area of the polygonal face (external area minus internal hole areas).
        /// </summary>
        /// <returns>The net area of the face.</returns>
        public double GetArea()
        {
            if (externalEdge == null)
            {
                return double.NaN;
            }

            double result = externalEdge.GetArea();
            if (double.IsNaN(result) || result == 0)
            {
                return result;
            }

            if (internalEdges != null && internalEdges.Count != 0)
            {
                for (int i = 0; i < internalEdges.Count; i++)
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

        /// <summary>
        /// Gets the axis-aligned bounding box of the polygonal face.
        /// </summary>
        /// <returns>The bounding box based on the external boundary.</returns>
        public BoundingBox2D? GetBoundingBox()
        {
            return externalEdge?.GetBoundingBox();
        }

        /// <summary>
        /// Gets a point guaranteed to be inside the polygonal face (outside of any holes).
        /// </summary>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An internal point of the face, or null if it cannot be determined.</returns>
        public Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (externalEdge == null)
            {
                return null;
            }

            if (internalEdges == null || internalEdges.Count == 0)
            {
                return externalEdge.GetInternalPoint(tolerance);
            }

            Point2D? result = externalEdge.GetCentroid();
            if (Inside(result, tolerance))
            {
                return result;
            }

            List<Point2D>? point2Ds = externalEdge.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < internalEdges.Count; i++)
            {
                List<Point2D>? point2Ds_Internal = internalEdges[i]?.GetPoints();
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
                    Point2D? point2D = point2Ds[i].Mid(point2Ds[j]);
                    if (Inside(point2D, tolerance))
                    {
                        return point2D;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Checks if a point is within or on the boundary of the polygonal face.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is in range; otherwise, false.</returns>
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || externalEdge == null)
            {
                return false;
            }

            if (Inside(point2D, tolerance))
            {
                return true;
            }

            bool result = externalEdge.On(point2D, tolerance);
            if (internalEdges == null || internalEdges.Count == 0)
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

        /// <summary>
        /// Checks if a point is strictly inside the polygonal face (excluding boundaries and holes).
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is strictly inside; otherwise, false.</returns>
        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || externalEdge == null)
            {
                return false;
            }

            bool result = externalEdge.Inside(point2D, tolerance);
            if (!result)
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

        /// <summary>
        /// Reverses the orientation of both external and internal boundaries.
        /// </summary>
        /// <returns>True if at least one boundary was successfully reversed.</returns>
        public bool Inverse()
        {
            bool result = false;

            if (externalEdge is not null)
            {
                if (externalEdge.Inverse())
                {
                    result = true;
                }
            }

            if (internalEdges is not null)
            {
                foreach (IPolygonal2D internalEdge in internalEdges)
                {
                    if (internalEdge is not null && internalEdge.Inverse())
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Moves the polygonal face by translating its boundaries.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public override bool Move(Vector2D? vector2D)
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

        /// <summary>
        /// Checks if a point lies on any of the edges (external or internal) of the face.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on an edge; otherwise, false.</returns>
        public bool OnEdge(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || externalEdge == null)
            {
                return false;
            }

            bool result = externalEdge.On(point2D, tolerance);
            if (result)
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

        /// <summary>
        /// Orients the external and internal boundaries of the face.
        /// </summary>
        /// <param name="externalEdgeOrientation">The desired orientation for the external boundary.</param>
        /// <param name="internalEdgeOrientation">The desired orientation for the internal boundaries.</param>
        /// <returns>True if at least one boundary was successfully oriented.</returns>
        public bool Orient(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            bool result = false;

            if (externalEdgeOrientation is not null && externalEdge is not null)
            {
                if (externalEdge.Orient(externalEdgeOrientation.Value))
                {
                    result = true;
                }
            }

            if (internalEdgeOrientation is not null && internalEdges is not null)
            {
                foreach (IPolygonal2D internalEdge in internalEdges)
                {
                    if (internalEdge is null)
                    {
                        continue;
                    }

                    if (internalEdge.Orient(internalEdgeOrientation.Value))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Transforms the polygonal face by transforming its boundaries.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public override bool Transform(ITransform2D? transform)
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

        /// <summary>
        /// Triangulates the polygonal face into a set of triangles.
        /// </summary>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of Triangle2D objects representing the triangulated face, or null if it cannot be triangulated.</returns>
        public virtual List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
        {
            if (externalEdge == null)
            {
                return null;
            }

            if (internalEdges == null || internalEdges.Count == 0)
            {
                return externalEdge.Triangulate(tolerance);
            }

            List<Polygon>? polygons = Query.Triangulate(this.ToNTS(), tolerance);
            if (polygons == null)
            {
                return null;
            }

            List<Triangle2D> result = [];
            foreach (Polygon polygon in polygons)
            {
                Coordinate[]? coordinates = polygon?.Coordinates;
                if (coordinates == null || coordinates.Length != 4)
                {
                    continue;
                }

                result.Add(new(coordinates[0].ToDiGi(), coordinates[1].ToDiGi(), coordinates[2].ToDiGi()));
            }

            return result;
        }
    }
}