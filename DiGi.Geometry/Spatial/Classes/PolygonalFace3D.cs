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
    /// <summary>
    /// Represents a polygonal face in 3D space that is planar.
    /// </summary>
    public class PolygonalFace3D : Planar<IPolygonalFace2D>, IPolygonalFace3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the <see cref="PolygonalFace3D"/> instance.</param>
        public PolygonalFace3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace3D"/> class.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> that defines the surface of the polygonal face.</param>
        /// <param name="polygonalFace2D">The <see cref="IPolygonalFace2D"/> representation of the polygonal face in 2D space.</param>
        public PolygonalFace3D(Plane? plane, IPolygonalFace2D? polygonalFace2D)
            : base(plane, polygonalFace2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace3D"/> class using the specified external edge.
        /// </summary>
        /// <param name="externalEdge">The <see cref="IPolygonal3D"/> object representing the external edge used to initialize the face. This value can be null.</param>
        public PolygonalFace3D(IPolygonal3D? externalEdge)
            : base(externalEdge?.Plane, externalEdge == null ? null : new PolygonalFace2D(externalEdge?.Plane?.Convert(externalEdge)))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace3D"/> class using the values from another <see cref="PolygonalFace3D"/> instance.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="PolygonalFace3D"/> instance to copy from.</param>
        public PolygonalFace3D(PolygonalFace3D? polygonalFace3D)
            : base(polygonalFace3D)
        {
        }

        /// <summary>
        /// Gets a list of all polygonal 3D edges, combining the external edge and any internal edges.
        /// </summary>
        /// <value>
        /// A <see cref="List{IPolygonal3D}"/> containing both the external and internal edges, or <c>null</c> if no external edge exists.
        /// </value>
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

        /// <summary>
        /// Gets the external edge of the geometry as an IPolygonal3D object.
        /// </summary>
        /// <value>
        /// The IPolygonal3D representation of the external edge, or null if the plane or underlying 2D geometry is not available.
        /// </value>
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

        /// <summary>
        /// Gets the list of internal edges as <see cref="IPolygonal3D"/>.
        /// Returns null if the plane, geometry 2D, or the source internal edges are not available.
        /// </summary>
        /// <value>A <see cref="List{IPolygonal3D}"/> containing the converted internal edges, or null.</value>
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

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance, or <c>null</c>.</returns>
        public override ISerializableObject? Clone()
        {
            return new PolygonalFace3D(this);
        }

        /// <summary>
        /// Calculates the closest point on the geometry to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point3D"/> on the geometry, or null if the input point, plane, or geometry is null.</returns>
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

        /// <summary>
        /// Calculates the distance between the specified <see cref="Point3D"/> and the closest point on this object.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to calculate the distance from.</param>
        /// <returns>The distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the closest point cannot be determined.</returns>
        public double Distance(Point3D? point3D)
        {
            return ClosestPoint(point3D) is not Point3D closestPoint ? double.NaN : closestPoint.Distance(point3D);
        }

        /// <summary>
        /// Calculates the area of the 2D geometry.
        /// </summary>
        /// <returns>A <see cref="double"/> representing the area, or <see cref="double.NaN"/> if the underlying 2D geometry is null.</returns>
        public double GetArea()
        {
            if (geometry2D == null)
            {
                return double.NaN;
            }

            return geometry2D.GetArea();
        }

        /// <summary>
        /// Gets the bounding box of the object.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or null if it cannot be determined.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            return ExternalEdge?.GetBoundingBox();
        }

        /// <summary>
        /// Gets an internal point of the geometry within the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The double value representing the distance tolerance used for calculations.</param>
        /// <returns>A Point3D object if an internal point is found; otherwise, null.</returns>
        public Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return plane?.Convert(geometry2D?.GetInternalPoint(tolerance));
        }

        /// <summary>
        /// Determines whether the specified <c>Point3D?</c> is within the range of the geometry based on the provided <see cref="double"/> tolerance.
        /// </summary>
        /// <param name="point3D">The <c>Point3D?</c> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the range check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within range; returns <see langword="false"/> if the point, plane, or geometry is null.</returns>
        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located inside the geometry on the plane within a given tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the proximity check.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the point is within the geometry; otherwise, <c>false</c>.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

        /// <summary>
        /// Inverts the underlying 2D geometry.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful.</returns>
        public bool Inverse()
        {
            if (geometry2D is null)
            {
                return false;
            }

            return geometry2D.Inverse();
        }

        /// <summary>
        /// Determines whether the specified 3D point lies on the edge of the geometry within a given tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating true if the point is on the edge; otherwise, false.</returns>
        public bool OnEdge(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

        /// <summary>
        /// Orients the external and internal edges of the geometry based on the specified orientations.
        /// </summary>
        /// <param name="externalEdgeOrientation">The optional <see cref="Orientation"/> to apply to the external edge.</param>
        /// <param name="internalEdgeOrientation">The optional <see cref="Orientation"/> to apply to the internal edge.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the orientation process was successful.</returns>
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

        /// <summary>
        /// Triangulates the geometry into a list of <see cref="Triangle3D"/> objects based on the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used during the triangulation process.</param>
        /// <returns>A <c>List&lt;Triangle3D&gt;</c> containing the resulting 3D triangles, or null if the plane or underlying 2D geometry is not available.</returns>
        public List<Triangle3D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
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