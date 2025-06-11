using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Mesh3D Mesh3D(this Ellipsoid ellipsoid, int stacks, int slices)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            List<Point3D> point3Ds = new List<Point3D>();

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
                Point3D ellipsoidVertex = ellipsoid.Center + (ellipsoid.DirectionA * scaledX) + (ellipsoid.DirectionB * scaledY) + (ellipsoid.DirectionC * scaledZ);

                point3Ds[i] = ellipsoidVertex; // Update the vertex
            }

            // 3. Generate Triangles (Indices)

            List<int[]> indices = new List<int[]>();
            // North Pole triangles
            for (int j = 0; j < slices; j++)
            {
                indices.Add(new int[] { 0, (j + 1) % slices + 1, j + 1 });
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
                    indices.Add(new int[] { v1, v3, v2 });

                    // Triangle 2
                    indices.Add(new int[] { v1, v4, v3 });
                }
            }

            // South Pole triangles
            int southPoleIndex = point3Ds.Count - 1;
            int lastStackStart = 1 + (stacks - 2) * slices;
            for (int j = 0; j < slices; j++)
            {
                indices.Add(new int[] { southPoleIndex, lastStackStart + j, lastStackStart + (j + 1) % slices });
            }

            return new Mesh3D(point3Ds, indices);
        }

        public static Mesh3D Mesh3D(this IEnumerable<Triangle3D> triangle3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (triangle3Ds == null || triangle3Ds.Count() == 0)
            {
                return null;
            }

            List<Point3D> point3Ds = new List<Point3D>();
            List<int[]> indexes = new List<int[]>();
            foreach (Triangle3D triangle3D in triangle3Ds)
            {
                List<Point3D> point3D_Triangle3D = triangle3D?.GetPoints();
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
                        point3Ds[index] = point3Ds[index].Mid(point3D);
                    }

                    indexes_Triangle3D[i] = index;
                }

                indexes.Add(indexes_Triangle3D);
            }

            return new Mesh3D(point3Ds, indexes);
        }

        public static Mesh3D Mesh3D(this Polyhedron polyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<PolygonalFace3D> polygonalFace3Ds = polyhedron?.PolygonalFaces;
            if (polygonalFace3Ds == null || polygonalFace3Ds.Count == 0)
            {
                return null;
            }

            List<Triangle3D> triangle3Ds = new List<Triangle3D>();
            foreach (PolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                List<Triangle3D> triangle3Ds_PolygonalFace3D = polygonalFace3D?.Triangulate(tolerance);
                if (triangle3Ds_PolygonalFace3D != null && triangle3Ds_PolygonalFace3D.Count == 0)
                {
                    continue;
                }

                triangle3Ds.AddRange(triangle3Ds_PolygonalFace3D);
            }

            return Mesh3D(triangle3Ds, tolerance);
        }
    }
}
