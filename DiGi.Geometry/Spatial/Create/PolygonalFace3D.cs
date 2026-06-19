using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a <see cref="Planar{T}"/> to a <see cref="Classes.PolygonalFace3D"/>.
        /// </summary>
        /// <typeparam name="T">The type of the polygonal 2D geometry, which must implement <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="Planar{T}"/> instance to convert.</param>
        /// <returns>A <see cref="Classes.PolygonalFace3D"/> if the conversion is successful; otherwise, null.</returns>
        public static PolygonalFace3D? PolygonalFace3D<T>(this Planar<T>? planar) where T : IPolygonal2D
        {
            if (planar == null)
            {
                return null;
            }

            Plane? plane = planar.Plane;
            if (plane == null)
            {
                return null;
            }

            T? polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return null;
            }

            return new PolygonalFace3D(plane, new PolygonalFace2D(polygonal2D));
        }

        /// <summary>
        /// Creates a <see cref="Classes.PolygonalFace3D"/> based on the specified <see cref="Classes.Plane"/> and a collection of <see cref="Point2D"/> vertices.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> on which the polygonal face is located.</param>
        /// <param name="points">An array of <see cref="Point2D"/> objects defining the vertices of the polygon.</param>
        /// <returns>A <see cref="Classes.PolygonalFace3D"/> instance if the <see cref="Classes.Plane"/> and <see cref="Point2D"/> array are not null and contain at least three points; otherwise, null.</returns>
        public static PolygonalFace3D? PolygonalFace3D(Plane? plane, params Point2D[]? points)
        {
            if (plane == null || points == null || points.Length < 3)
            {
                return null;
            }

            return new PolygonalFace3D(plane, Planar.Create.PolygonalFace2D(points));
        }

        /// <summary>
        /// Creates a <see cref="Classes.PolygonalFace3D"/> based on an external boundary and optional internal boundaries.
        /// </summary>
        /// <param name="externalEdge">The <see cref="IPolygonal3D"/> representing the external edge of the face.</param>
        /// <param name="internalEdges">An <see cref="IEnumerable{IPolygonal3D}"/> containing the internal edges (holes) of the face.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for distance calculations.</param>
        /// <returns>A <see cref="Classes.PolygonalFace3D"/> object if the face could be created; otherwise, <c>null</c>.</returns>
        public static PolygonalFace3D? PolygonalFace3D(IPolygonal3D? externalEdge, IEnumerable<IPolygonal3D>? internalEdges = null, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Plane? plane = externalEdge?.Plane;
            if (plane == null)
            {
                return null;
            }

            IPolygonal2D? externalEdge2D = plane.Convert(externalEdge);

            List<IPolygonal2D>? internalEdge2Ds = null;
            if (internalEdges != null)
            {
                internalEdge2Ds = [];
                foreach (IPolygonal3D internalEdge in internalEdges)
                {
                    IPolygonal2D? internalEdge2D = plane.Convert(plane.Project<IPolygonal3D>(internalEdge));
                    if (internalEdge2D == null)
                    {
                        continue;
                    }

                    internalEdge2Ds.Add(internalEdge2D);
                }
            }

            PolygonalFace2D? polygonalFace2D = Planar.Create.PolygonalFace2D(externalEdge2D, internalEdge2Ds, tolerance);
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new PolygonalFace3D(plane, polygonalFace2D);
        }

        /// <summary>
        /// Converts an <see cref="IPolygonalFace3D"/> instance to a <see cref="Classes.PolygonalFace3D"/> instance if the underlying plane is a <see cref="Classes.Plane"/> and the geometry is an <see cref="IPolygonalFace2D"/>.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to convert.</param>
        /// <returns>A new <see cref="Classes.PolygonalFace3D"/> instance if the conversion is successful; otherwise, <see langword="null"/>.</returns>
        public static PolygonalFace3D? PolygonalFace3D(this IPolygonalFace3D? polygonalFace3D)
        {
            if (polygonalFace3D is null || polygonalFace3D.Plane is not Plane plane || polygonalFace3D.Geometry2D is not IPolygonalFace2D polygonalFace2D)
            {
                return null;
            }

            return new PolygonalFace3D(plane, polygonalFace2D);
        }
    }
}