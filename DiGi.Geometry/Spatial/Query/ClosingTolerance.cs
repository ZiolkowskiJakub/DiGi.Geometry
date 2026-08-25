using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Finds the finest of the given distance tolerances at which the specified <see cref="Polyhedron{TPolygonalFace3D}"/> is closed.
        /// <para>This is the question a caller checking watertightness usually has - not whether the polyhedron closes at one particular value, but whether it closes at that value or any finer one, and which. Reading a requirement literally as <see cref="IsClosed{TPolygonalFace3D}(Polyhedron{TPolygonalFace3D}?, double)"/> at a single coarse tolerance inflated the failures reported by a 76 600 model audit roughly six-fold.</para>
        /// <para><paramref name="tolerances"/> is the ladder of candidates to consider. It is sorted ascending and de-duplicated first, so the order it arrives in does not matter, and values of zero or less are ignored rather than being folded onto <see cref="DiGi.Core.Constants.Tolerance.MicroDistance"/>.</para>
        /// <para>Because the default closure criterion is monotonic in tolerance the ladder is searched by bisection, which costs at most four evaluations on a nine-step ladder instead of nine. The <c>manifold</c> criterion is scale-relative and therefore has to be walked one step at a time; see <see cref="IsClosed{TPolygonalFace3D}(Polyhedron{TPolygonalFace3D}?, bool, double)"/>.</para>
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The <see cref="Polyhedron{TPolygonalFace3D}"/> to evaluate.</param>
        /// <param name="tolerances">The candidate distance tolerances to try.</param>
        /// <param name="manifold">When <see langword="true"/>, every edge must be shared by exactly two faces at the tolerance returned.</param>
        /// <returns>The finest candidate tolerance at which the polyhedron is closed, or <see langword="null"/> when it closes at none of them.</returns>
        public static double? ClosingTolerance<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron, IEnumerable<double>? tolerances, bool manifold = false) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron is null || tolerances is null)
            {
                return null;
            }

            List<double> tolerances_Temp = [];
            foreach (double tolerance in tolerances)
            {
                if (tolerance > 0.0)
                {
                    tolerances_Temp.Add(tolerance);
                }
            }

            if (tolerances_Temp.Count == 0)
            {
                return null;
            }

            tolerances_Temp.Sort();

            if (manifold)
            {
                for (int i = 0; i < tolerances_Temp.Count; i++)
                {
                    if (i > 0 && tolerances_Temp[i] == tolerances_Temp[i - 1])
                    {
                        continue;
                    }

                    if (IsClosed(polyhedron, true, tolerances_Temp[i]))
                    {
                        return tolerances_Temp[i];
                    }
                }

                return null;
            }

            int index_Closed = -1;
            int index_Low = 0;
            int index_High = tolerances_Temp.Count - 1;

            while (index_Low <= index_High)
            {
                int index_Middle = index_Low + ((index_High - index_Low) / 2);

                if (IsClosed(polyhedron, false, tolerances_Temp[index_Middle]))
                {
                    index_Closed = index_Middle;
                    index_High = index_Middle - 1;
                }
                else
                {
                    index_Low = index_Middle + 1;
                }
            }

            return index_Closed < 0 ? null : tolerances_Temp[index_Closed];
        }
    }
}
