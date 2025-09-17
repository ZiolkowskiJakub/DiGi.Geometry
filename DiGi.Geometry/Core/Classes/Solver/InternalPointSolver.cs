using DiGi.Core.Constans;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class InternalPointSolver<TPoint> : IInternalPointSolver<TPoint> where TPoint : IPoint
    {
        protected int maxCount = 100;

        protected List<TPoint> internalPoints = [];
        protected double tolerance = Tolerance.Distance;
        
        public InternalPointSolver(double tolerance = Tolerance.Distance)
        {
            this.tolerance = tolerance;
        }

        public InternalPointSolver(int maxCount, double tolerance = Tolerance.Distance)
        {
            this.maxCount = maxCount;
            this.tolerance = tolerance;
        }

        public TPoint? InternalPoint
        {
            get
            {
                if (internalPoints == null || internalPoints.Count == 0)
                {
                    return default;
                }

                return DiGi.Core.Query.Clone(internalPoints.Last());
            }
        }

        public List<TPoint>? InternalPoints
        {
            get
            {
                return DiGi.Core.Query.CloneAndFilterNulls(internalPoints);
            }
        }

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

        public abstract bool Solve();
    }
}
