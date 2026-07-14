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
        /// <param name="stacks">The number of stacks (latitude divisions) as an <see cref="int"/> used to generate the mesh. Must be at least 2.</param>
        /// <param name="slices">The number of slices (longitude divisions) as an <see cref="int"/> used to generate the mesh. Must be at least 3.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> representing the ellipsoid, or <c>null</c> if the provided <see cref="Ellipsoid"/> is <c>null</c>, incomplete, or the resolution values are out of range.</returns>
        public static Mesh3D? Mesh3D(this Ellipsoid? ellipsoid, int stacks, int slices)
        {
            if (ellipsoid == null || stacks < 2 || slices < 3)
            {
                return null;
            }

            Point3D? center = ellipsoid.Center;
            Vector3D? directionA = ellipsoid.DirectionA;
            Vector3D? directionB = ellipsoid.DirectionB;
            Vector3D? directionC = ellipsoid.DirectionC;
            if (center is null || directionA is null || directionB is null || directionC is null)
            {
                return null;
            }

            double x_Center = center.X;
            double y_Center = center.Y;
            double z_Center = center.Z;

            // Basis columns pre-scaled by the semi-axis lengths, so each vertex is a single fused scale-rotate-translate evaluation
            double a = ellipsoid.A;
            double x_A = directionA.X * a;
            double y_A = directionA.Y * a;
            double z_A = directionA.Z * a;

            double b = ellipsoid.B;
            double x_B = directionB.X * b;
            double y_B = directionB.Y * b;
            double z_B = directionB.Z * b;

            double c = ellipsoid.C;
            double x_C = directionC.X * c;
            double y_C = directionC.Y * c;
            double z_C = directionC.Z * c;

            // Longitude trigonometry is shared by all stacks, so it is computed once
            double[] cosThetas = new double[slices];
            double[] sinThetas = new double[slices];
            double theta_Delta = 2 * System.Math.PI / slices;
            for (int j = 0; j < slices; j++)
            {
                double theta = theta_Delta * j;
                cosThetas[j] = System.Math.Cos(theta);
                sinThetas[j] = System.Math.Sin(theta);
            }

            List<Point3D> point3Ds = new(((stacks - 1) * slices) + 2)
            {
                // North Pole (unit sphere point (0, 0, 1))
                new Point3D(x_Center + x_C, y_Center + y_C, z_Center + z_C)
            };

            for (int i = 1; i < stacks; i++)
            {
                double phi = System.Math.PI * i / stacks;
                double sinPhi = System.Math.Sin(phi);
                double cosPhi = System.Math.Cos(phi);

                double x_Stack = x_Center + (x_C * cosPhi);
                double y_Stack = y_Center + (y_C * cosPhi);
                double z_Stack = z_Center + (z_C * cosPhi);

                for (int j = 0; j < slices; j++)
                {
                    double x = sinPhi * cosThetas[j];
                    double y = sinPhi * sinThetas[j];

                    point3Ds.Add(new Point3D(x_Stack + (x_A * x) + (x_B * y), y_Stack + (y_A * x) + (y_B * y), z_Stack + (z_A * x) + (z_B * y)));
                }
            }

            // South Pole (unit sphere point (0, 0, -1))
            point3Ds.Add(new Point3D(x_Center - x_C, y_Center - y_C, z_Center - z_C));

            List<int[]> indexes = new(2 * slices * (stacks - 1));

            // North Pole triangles
            for (int j = 0; j < slices; j++)
            {
                int j_Next = j + 1 == slices ? 0 : j + 1;

                indexes.Add([0, j_Next + 1, j + 1]);
            }

            // Middle quads split into two triangles
            for (int i = 0; i < stacks - 2; i++)
            {
                int start_Current = 1 + (i * slices);
                int start_Next = start_Current + slices;

                for (int j = 0; j < slices; j++)
                {
                    int j_Next = j + 1 == slices ? 0 : j + 1;

                    int index_1 = start_Current + j;
                    int index_2 = start_Current + j_Next;
                    int index_3 = start_Next + j_Next;
                    int index_4 = start_Next + j;

                    indexes.Add([index_1, index_2, index_3]);
                    indexes.Add([index_1, index_3, index_4]);
                }
            }

            // South Pole triangles
            int index_SouthPole = point3Ds.Count - 1;
            int start_Last = 1 + ((stacks - 2) * slices);
            for (int j = 0; j < slices; j++)
            {
                int j_Next = j + 1 == slices ? 0 : j + 1;

                indexes.Add([index_SouthPole, start_Last + j, start_Last + j_Next]);
            }

            return new Mesh3D(point3Ds, indexes, false);
        }

        /// <summary>
        /// Generates a <see cref="Classes.Mesh3D"/> from the specified <see cref="Ellipsoid"/> using an angle factor to determine the resolution of stacks and slices.
        /// </summary>
        /// <param name="ellipsoid">The <see cref="Ellipsoid"/> instance to be converted into a mesh.</param>
        /// <param name="angleFactor">A <see cref="double"/> value used to calculate the number of stacks and slices for the resulting mesh.</param>
        /// <returns>A <see cref="Classes.Mesh3D"/> object representing the ellipsoid, or <c>null</c> if the provided <see cref="Ellipsoid"/> is <c>null</c> or the angle factor does not yield a positive angular step.</returns>
        public static Mesh3D? Mesh3D(this Ellipsoid? ellipsoid, double angleFactor)
        {
            if (ellipsoid == null)
            {
                return null;
            }

            double factor = angleFactor % System.Math.PI;
            if (!(factor > 0))
            {
                return null;
            }

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
            if (triangle3Ds == null)
            {
                return null;
            }

            Triangle3D[] triangle3Ds_Cached = triangle3Ds as Triangle3D[] ?? [.. triangle3Ds];
            if (triangle3Ds_Cached.Length == 0)
            {
                return null;
            }

            List<Point3D> point3Ds = [];
            List<int[]> indexes = new(triangle3Ds_Cached.Length);

            // Spatial hash grid: points are bucketed by their tolerance-sized cell so lookups avoid an O(n) linear scan per point.
            Dictionary<(long X, long Y, long Z), List<int>> indexes_ByCell = [];

            int GetOrAddPointIndex(Point3D point3D_Triangle3D)
            {
                long cellX = (long)System.Math.Round(point3D_Triangle3D.X / tolerance);
                long cellY = (long)System.Math.Round(point3D_Triangle3D.Y / tolerance);
                long cellZ = (long)System.Math.Round(point3D_Triangle3D.Z / tolerance);

                for (long x = cellX - 1; x <= cellX + 1; x++)
                {
                    for (long y = cellY - 1; y <= cellY + 1; y++)
                    {
                        for (long z = cellZ - 1; z <= cellZ + 1; z++)
                        {
                            if (indexes_ByCell.TryGetValue((x, y, z), out List<int>? indexes_Cell) && indexes_Cell != null)
                            {
                                foreach (int index_Cell in indexes_Cell)
                                {
                                    Point3D point3D_Existing = point3Ds[index_Cell];
                                    if (point3D_Existing.AlmostEquals(point3D_Triangle3D, tolerance))
                                    {
                                        // The stored point is owned by this method, so the midpoint is applied in place without allocating
                                        point3D_Existing.X = (point3D_Existing.X + point3D_Triangle3D.X) * 0.5;
                                        point3D_Existing.Y = (point3D_Existing.Y + point3D_Triangle3D.Y) * 0.5;
                                        point3D_Existing.Z = (point3D_Existing.Z + point3D_Triangle3D.Z) * 0.5;

                                        return index_Cell;
                                    }
                                }
                            }
                        }
                    }
                }

                int index_New = point3Ds.Count;
                point3Ds.Add(new Point3D(point3D_Triangle3D.X, point3D_Triangle3D.Y, point3D_Triangle3D.Z));

                (long X, long Y, long Z) cell = (cellX, cellY, cellZ);
                if (!indexes_ByCell.TryGetValue(cell, out List<int>? indexes_New))
                {
                    indexes_New = [];
                    indexes_ByCell[cell] = indexes_New;
                }
                indexes_New.Add(index_New);

                return index_New;
            }

            foreach (Triangle3D triangle3D in triangle3Ds_Cached)
            {
                List<Point3D>? point3Ds_Triangle3D = triangle3D?.GetPoints();
                if (point3Ds_Triangle3D == null || point3Ds_Triangle3D.Count != 3)
                {
                    continue;
                }

                int[] indexes_Triangle3D = new int[3];
                for (int i = 0; i < point3Ds_Triangle3D.Count; i++)
                {
                    indexes_Triangle3D[i] = GetOrAddPointIndex(point3Ds_Triangle3D[i]);
                }

                indexes.Add(indexes_Triangle3D);
            }

            return new Mesh3D(point3Ds, indexes, false);
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
                if (triangle3Ds_PolygonalFace3D == null || triangle3Ds_PolygonalFace3D.Count == 0)
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
