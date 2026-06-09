using DiGi.Core.Constants;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Solves self-intersections for a 2D polygonal geometry.
    /// </summary>
    public class Polygonal2DSelfIntersectionSolver : IOneToOneGeometrySolver<IPolygonal2D, IPolygonal2D>
    {
        private readonly double tolerance = Tolerance.Distance;
        private readonly double maxLength;

        private IPolygonal2D? input = null;
        private IPolygonal2D? output = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygonal2DSelfIntersectionSolver"/> class.
        /// </summary>
        /// <param name="input">The <see cref="IPolygonal2D"/> input geometry to be analyzed for self-intersections.</param>
        /// <param name="maxLength">The maximum length as a <see cref="double"/>.</param>
        /// <param name="tolerance">The distance tolerance as a <see cref="double"/>.</param>
        public Polygonal2DSelfIntersectionSolver(IPolygonal2D input, double maxLength, double tolerance = Tolerance.Distance)
        {
            this.input = DiGi.Core.Query.Clone(input);
            this.maxLength = maxLength;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygonal2DSelfIntersectionSolver"/> class.
        /// </summary>
        /// <param name="maxLength">The maximum length as a <see cref="double"/>.</param>
        /// <param name="tolerance">The tolerance value as a <see cref="double"/>.</param>
        public Polygonal2DSelfIntersectionSolver(double maxLength, double tolerance = Tolerance.Distance)
        {
            this.maxLength = maxLength;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Gets or sets the input <see cref="IPolygonal2D"/>.
        /// </summary>
        public IPolygonal2D? Input
        {
            set
            {
                input = DiGi.Core.Query.Clone(value);
            }
        }

        /// <summary>
        /// Gets the resulting <see cref="IPolygonal2D"/> object produced by the solver.
        /// </summary>
        /// <value>
        /// The <see cref="IPolygonal2D"/> instance, or null if no output has been generated or the solve operation failed.
        /// </value>
        public IPolygonal2D? Output
        {
            get
            {
                return DiGi.Core.Query.Clone(output);
            }
        }

        /// <summary>
        /// Attempts to solve for self-intersecting polygons based on the input data, maximum length, and tolerance.
        /// </summary>
/// <returns>A <see cref="bool"/> value indicating whether a solution was successfully found.</returns>
        public bool Solve()
        {
            output = null;

            if (input == null)
            {
                return false;
            }

            if (Query.SelfIntersectionPolygons(input, maxLength, tolerance) is not List<Polygon2D> polygon2Ds)
            {
                return false;
            }

            if (polygon2Ds.Count == 0)
            {
                return false;
            }

            if (polygon2Ds.Count == 1)
            {
                output = polygon2Ds[0];
                return true;
            }

            List<Tuple<Polygon2D, double>> tuples = [];
            foreach (Polygon2D polygon2D in polygon2Ds)
            {
                if (polygon2D is null)
                {
                    continue;
                }

                double area = polygon2D.GetArea();
                if (area < tolerance)
                {
                    continue;
                }

                tuples.Add(new Tuple<Polygon2D, double>(polygon2D, area));
            }

            if (tuples.Count == 0)
            {
                return false;
            }

            if (tuples.Count == 1)
            {
                output = tuples[0].Item1;
                return true;
            }

            tuples.Sort((x, y) => y.Item2.CompareTo(x.Item2));

            output = tuples[0].Item1;
            return true;
        }
    }
}
