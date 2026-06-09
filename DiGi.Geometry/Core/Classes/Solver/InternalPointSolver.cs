using DiGi.Core.Constants;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Provides a base implementation for solvers that calculate internal points within a specific geometry.
    /// </summary>
    /// <typeparam name="TGeometry">The type of geometry, which must implement <see cref="IGeometry"/>.</typeparam>
    /// <typeparam name="TPoint">The type of point, which must implement <see cref="IPoint"/>.</typeparam>
    public abstract class InternalPointSolver<TGeometry, TPoint> : IOneToManyGeometrySolver<TGeometry, TPoint> where TPoint : IPoint where TGeometry : IGeometry
    {
        protected int maxCount = 100;

        protected List<TPoint> outputs = [];
        protected double tolerance = Tolerance.Distance;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalPointSolver{TGeometry, TPoint}"/> class.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> value used as the distance tolerance.</param>
        public InternalPointSolver(double tolerance = Tolerance.Distance)
        {
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalPointSolver{TGeometry, TPoint}"/> class.
        /// </summary>
        /// <param name="maxCount">The maximum number of iterations as an <see cref="int"/>.</param>
        /// <param name="tolerance">The convergence tolerance as a <see cref="double"/>.</param>
        public InternalPointSolver(int maxCount, double tolerance = Tolerance.Distance)
        {
            this.maxCount = maxCount;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Gets or sets the input geometry of type <typeparamref name="TGeometry"/>.
        /// </summary>
        public abstract TGeometry? Input { set; }

        /// <summary>
        /// Gets or sets the maximum count as an <see cref="int"/>.
        /// </summary>
        public int MaxCount
        {
            get
            {
                return maxCount;
            }

            set
            {
                maxCount = value;
            }
        }

        /// <summary>
        /// Gets the last <typeparamref name="TPoint"/> from the collection of outputs.
        /// </summary>
        /// <value>
        /// The cloned last <typeparamref name="TPoint"/> if any outputs exist; otherwise, the default value for <typeparamref name="TPoint"/>.
        /// </value>
        public TPoint? Output
        {
            get
            {
                if (outputs == null || outputs.Count == 0)
                {
                    return default;
                }

                return DiGi.Core.Query.Clone(outputs.Last());
            }
        }

        /// <summary>
        /// Gets a <see cref="List{TPoint}"/> of the resulting output points, filtered to remove any null values.
        /// </summary>
        /// <value>
        /// A <see cref="List{TPoint}"/> containing the calculated outputs, or null if no outputs exist.
        /// </value>
        public List<TPoint>? Outputs
        {
            get
            {
                return DiGi.Core.Query.CloneAndFilterNulls(outputs);
            }
        }

        /// <summary>
        /// Attempts to solve the problem defined by the implementation.
        /// </summary>
/// <returns>A <see cref="bool"/> value indicating whether the solution was successfully found.</returns>
        public abstract bool Solve();
    }
}
