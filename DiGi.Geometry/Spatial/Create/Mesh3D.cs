using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a <see cref="Classes.Mesh3D"/> from the specified <see cref="Ellipsoid"/>.
        /// </summary>
        /// <param name="ellipsoid">The <see cref="Ellipsoid"/> to convert into a mesh.</param>
        /// <param name="stacks">The number of stacks (latitude divisions) as an <see cref="int"/> used to generate the mesh.</param>
        /// <param name="slices">The number of slices (longitude divisions) as an <see cref="int"/> used to generate the mesh.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> representing the ellipsoid, or <c>null</c> if the provided <see cref="Ellipsoid"/> is <c>null</c>.</returns>
        public static Mesh3D? Mesh3D(this Ellipsoid? ellipsoid, int stacks, int slices)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            List<Point3D> point3Ds = [];

            // 1. Generate Vertices for a Unit Sphere (UV Sphere method)
            // Adjust for poles
            point3Ds.Add(new Point3D(0, 0, 1)); // North Pole
            for (int i = 1; i < stacks; i++) // Stacks (latitude)
            {
                double phi = System.Math.PI * i / stacks; // Angle from North Pole
                for (int j = 0; j < slices; j++) // Slices (longitude)
                {
                    double theta = 2 * System.Math.PI * j / slices; // Angle around Z-axis

                    double x = System.Math.Sin(phi) * System.Math.Cos(theta);
                    double y = System.Math.Sin(phi) * System.Math.Sin(theta);
                    double z = System.Math.Cos(phi);

                    point3Ds.Add(new Point3D(x, y, z));
                }
            }
            point3Ds.Add(new Point3D(0, 0, -1)); // South Pole

            // 2. Transform Unit Sphere Vertices to Ellipsoid Vertices
            // Iterate through all generated vertices and apply the transformation
            for (int i = 0; i < point3Ds.Count; i++)
            {
                Point3D unitSphereVertex = point3Ds[i];

                // Scale
                double scaledX = unitSphereVertex.X * ellipsoid.A;
                double scaledY = unitSphereVertex.Y * ellipsoid.B;
                double scaledZ = unitSphereVertex.Z * ellipsoid.C;

                // Rotate and Translate
                // Assuming VectorX, VectorY, VectorZ are properties of ellipsoid
                // and are correctly normalized and orthogonal.
                Point3D? ellipsoidVertex = ellipsoid.Center + (ellipsoid.DirectionA * scaledX) + (ellipsoid.DirectionB * scaledY) + (ellipsoid.DirectionC * scaledZ);
                if (ellipsoidVertex is null)
                {
                    continue;
                }

                point3Ds[i] = ellipsoidVertex; // Update the vertex
            }

            // 3. Generate Triangles (Indices)

            List<int[]> indices = [];
            // North Pole triangles
            for (int j = 0; j < slices; j++)
            {
                indices.Add([0, (j + 1) % slices + 1, j + 1]);
            }

            // Middle quads
            for (int i = 0; i < stacks - 2; i++)
            {
                int currentStackStart = 1 + i * slices;
                int nextStackStart = 1 + (i + 1) * slices;

                for (int j = 0; j < slices; j++)
                {
                    int v1 = currentStackStart + j;
                    int v2 = currentStackStart + (j + 1) % slices;
                    int v3 = nextStackStart + (j + 1) % slices;
                    int v4 = nextStackStart + j;

                    // Triangle 1
                    indices.Add([v1, v2, v3]);

                    // Triangle 2
                    indices.Add([v1, v3, v4]);
                }
            }

            // South Pole triangles
            int southPoleIndex = point3Ds.Count - 1;
            int lastStackStart = 1 + (stacks - 2) * slices;
            for (int j = 0; j < slices; j++)
            {
                indices.Add([southPoleIndex, lastStackStart + j, lastStackStart + (j + 1) % slices]);
            }

            return new Mesh3D(point3Ds, indices);
        }

        /// <summary>
        /// Generates a <see cref="Classes.Mesh3D"/> from the specified <see cref="Ellipsoid"/> using an angle factor to determine the resolution of stacks and slices.
        /// </summary>
        /// <param name="ellipsoid">The <see cref="Ellipsoid"/> instance to be converted into a mesh.</param>
        /// <param name="angleFactor">A <see cref="double"/> value used to calculate the number of stacks and slices for the resulting mesh.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> object representing the ellipsoid, or <c>null</c> if the provided <see cref="Ellipsoid"/> is <c>null</c>.</returns>
        public static Mesh3D? Mesh3D(this Ellipsoid? ellipsoid, double angleFactor)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            double factor = angleFactor % System.Math.PI;

            int stacks = (int)(System.Math.PI / factor);
            int slices = (int)(2 * System.Math.PI / factor);

            return Mesh3D(ellipsoid, stacks, slices);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Mesh3D"/> from a collection of <see cref="Triangle3D"/> objects.
        /// </summary>
        /// <param name="triangle3Ds">The <see cref="IEnumerable{Triangle3D}"/> containing the triangles to be converted into a mesh.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for merging coincident points.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> object if the input collection is not null and contains valid triangles; otherwise, <c>null</c>.</returns>
        public static Mesh3D? Mesh3D(this IEnumerable<Triangle3D>? triangle3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (triangle3Ds == null || triangle3Ds.Count() == 0)
            {
                return null;
            }

            List<Point3D> point3Ds = [];
            List<int[]> indexes = [];
            foreach (Triangle3D triangle3D in triangle3Ds)
            {
                List<Point3D>? point3D_Triangle3D = triangle3D?.GetPoints();
                if (point3D_Triangle3D == null || point3D_Triangle3D.Count() != 3)
                {
                    continue;
                }

                int[] indexes_Triangle3D = new int[3];
                for (int i = 0; i < point3D_Triangle3D.Count; i++)
                {
                    Point3D point3D = point3D_Triangle3D[i];

                    int index = point3Ds.FindIndex(x => x.AlmostEquals(point3D, tolerance));
                    if (index == -1)
                    {
                        index = point3Ds.Count;
                        point3Ds.Add(point3D);
                    }
                    else
                    {
                        Point3D? point3D_Temp = point3Ds[index].Mid(point3D);
                        if (point3D_Temp is not null)
                        {
                            point3Ds[index] = point3D_Temp;
                        }
                    }

                    indexes_Triangle3D[i] = index;
                }

                indexes.Add(indexes_Triangle3D);
            }

            return new Mesh3D(point3Ds, indexes);
        }

        /// <summary>
        /// Converts the specified <see cref="Classes.Polyhedron"/> to a <see cref="Classes.Mesh3D"/> by triangulating its polygonal faces.
        /// </summary>
        /// <param name="polyhedron">The <see cref="Classes.Polyhedron"/> instance to convert.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used during the triangulation of the polygonal faces.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> object representing the triangulated mesh, or <c>null</c> if the <see cref="Classes.Polyhedron"/> is null or contains no valid faces.</returns>
        public static Mesh3D? Mesh3D(this Polyhedron? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<IPolygonalFace3D>? polygonalFace3Ds = polyhedron?.PolygonalFaces;
            if (polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return null;
            }

            List<Triangle3D> triangle3Ds = [];
            foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                List<Triangle3D>? triangle3Ds_PolygonalFace3D = polygonalFace3D?.Triangulate(tolerance);
                if (triangle3Ds_PolygonalFace3D != null && triangle3Ds_PolygonalFace3D.Count == 0)
                {
                    continue;
                }

                triangle3Ds.AddRange(triangle3Ds_PolygonalFace3D);
            }

            return Mesh3D(triangle3Ds, tolerance);
        }

        /// <summary>
        /// Converts a polygonal face to a 3D mesh using the specified distance tolerance.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> instance to convert.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for triangulation.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> object representing the polygonal face, or <c>null</c> if the input is <c>null</c>.</returns>
        public static Mesh3D? Mesh3D(this IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            return Mesh3D(polygonalFace3D?.Triangulate(tolerance), tolerance);
        }
    }
}