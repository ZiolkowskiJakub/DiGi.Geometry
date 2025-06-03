using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Mesh3D Mesh3D(Ellipsoid ellipsoid, int stacks, int slices)
        {
            if(ellipsoid == null)
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
    }
}
