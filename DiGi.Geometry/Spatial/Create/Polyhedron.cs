using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Polyhedron(IPolygonalFace3D?, Classes.Vector3D?, double)"/> from the specified <see cref="IPolygonalFace3D"/> and <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> that serves as the base of the polyhedron.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> defining the direction and magnitude for the polyhedron creation.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for calculations.</param>
        /// <returns>A <see cref="Classes.Polyhedron"/> if successfully created; otherwise, null.</returns>
        public static Polyhedron? Polyhedron(this IPolygonalFace3D? polygonalFace3D, Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null || vector3D == null)
            {
                return null;
            }

            Plane? plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            if (vector3D.Length < tolerance)
            {
                return null;
            }

            if (plane.On(vector3D, tolerance))
            {
                return null;
            }

            List<IPolygonal3D>? edges = polygonalFace3D.Edges;
            if (edges == null || edges.Count == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [polygonalFace3D];

            foreach (IPolygonal3D edge in edges)
            {
                List<Segment3D>? segment3Ds = edge?.GetSegments();
                if (segment3Ds == null)
                {
                    continue;
                }

                foreach (Segment3D segment3D in segment3Ds)
                {
                    if (segment3D == null)
                    {
                        continue;
                    }

                    double squareLength = segment3D.SquaredLength;
                    if (double.IsNaN(squareLength) || squareLength == 0)
                    {
                        continue;
                    }

                    Point3D? point3D_2 = segment3D[1]?.GetMoved(vector3D);
                    if (point3D_2 is null)
                    {
                        continue;
                    }

                    Point3D? point3D_3 = segment3D[0]?.GetMoved(vector3D);
                    if (point3D_3 is null)
                    {
                        continue;
                    }

                    List<Point3D> point3Ds =
                    [
                        segment3D[0]!,
                        segment3D[1]!,
                        point3D_2,
                        point3D_3,

                    ];

                    Plane? plane_Temp = Plane(point3Ds[0], point3Ds[1], point3Ds[2]);
                    if (plane_Temp is null)
                    {
                        continue;
                    }

                    List<Point2D> point2Ds = [];
                    for (int i = 0; i < point3Ds.Count; i++)
                    {
                        Point2D? point2D = plane_Temp.Convert(point3Ds[i]);
                        if (point2D is null)
                        {
                            continue;
                        }

                        point2Ds.Add(point2D);
                    }

                    PolygonalFace2D polygonalFace2D = new(new Polygon2D(point2Ds));

                    polygonalFace3Ds.Add(new PolygonalFace3D(plane_Temp, polygonalFace2D));
                }
            }

            IPolygonalFace3D? polygonalFace3D_Temp = DiGi.Core.Query.Clone(polygonalFace3D);
            if (polygonalFace3D_Temp is not null)
            {
                polygonalFace3D_Temp.Move(vector3D);
                polygonalFace3Ds.Add(polygonalFace3D_Temp);
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        /// <summary>
        /// Converts the specified <see cref="Classes.BoundingBox3D"/> to a <see cref="Classes.Polyhedron"/>.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="Classes.BoundingBox3D"/> instance to convert.</param>
        /// <returns>A <see cref="Classes.Polyhedron"/> representing the bounding box, or <c>null</c> if the provided <see cref="Classes.BoundingBox3D"/> is <c>null</c> or cannot be converted into a valid polyhedron.</returns>
        public static Polyhedron? Polyhedron(this BoundingBox3D? boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            List<Polygon3D>? polygon3Ds = Polygon3Ds(boundingBox3D);
            if (polygon3Ds == null || polygon3Ds.Count < 3)
            {
                return null;
            }

            List<PolygonalFace3D> polygonalFace3Ds = [];
            for (int i = 0; i < polygon3Ds.Count; i++)
            {
                PolygonalFace3D? polygonalFace3D = polygon3Ds[i]?.PolygonalFace3D();
                if (polygonalFace3D is null)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D);
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        /// <summary>
        /// Creates a <see cref="Polyhedron(IPolygonalFace3D?, Classes.Vector3D?, double)"/> from the specified collection of polygonal faces.
        /// </summary>
        /// <param name="polygonalFace3Ds">An <see cref="IEnumerable{IPolygonalFace3D}"/> containing the polygonal faces to be used for the construction.</param>
        /// <returns>A new <see cref="Classes.Polyhedron"/> instance if the <see cref="IEnumerable{IPolygonalFace3D}"/> is not null and contains at least four elements; otherwise, null.</returns>
        public static Polyhedron? Polyhedron(this IEnumerable<IPolygonalFace3D>? polygonalFace3Ds)
        {
            if (polygonalFace3Ds is null || polygonalFace3Ds.Count() < 4)
            {
                return null;
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        /// <summary>
        /// Converts the specified <see cref="IPolyhedron"/> to a <see cref="Classes.Polyhedron"/>.
        /// </summary>
        /// <param name="polyhedron">The <see cref="IPolyhedron"/> instance to convert.</param>
        /// <returns>A <see cref="Classes.Polyhedron"/> instance if the conversion is successful; otherwise, null.</returns>
        public static Polyhedron? Polyhedron(this IPolyhedron polyhedron)
        {
            if (polyhedron is null)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];

            int count = polyhedron.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is not IPolygonalFace3D polygonalFace3D)
                    {
                        continue;
                    }

                    polygonalFace3Ds.Add(polygonalFace3D);
                }
            }

            return new Polyhedron(polygonalFace3Ds);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polyhedron"/> from the specified <see cref="PolygonalFaceExtrusion"/>.
        /// </summary>
        /// <param name="polygonalFaceExtrusion">The <see cref="PolygonalFaceExtrusion"/> to convert into a <see cref="Classes.Polyhedron"/>.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the operation.</param>
        /// <returns>A <see cref="Classes.Polyhedron"/> if the <see cref="PolygonalFaceExtrusion"/> is not null; otherwise, null.</returns>
        public static Polyhedron? Polyhedron(this PolygonalFaceExtrusion? polygonalFaceExtrusion, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFaceExtrusion is null)
            {
                return null;
            }

            return Polyhedron(polygonalFaceExtrusion.Surface, polygonalFaceExtrusion.Vector, tolerance);
        }
    }
}