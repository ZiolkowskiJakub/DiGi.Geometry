using DiGi.Core.Constans;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class InternalPointSolver<TGeometry, TPoint> : IOneToManyGeometrySolver<TGeometry, TPoint> where TPoint : IPoint where TGeometry : IGeometry
    {
        protected int maxCount = 100;

        protected List<TPoint> outputs = [];
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

        public abstract TGeometry? Input { set; }

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

        public List<TPoint>? Outputs
        {
            get
            {
                return DiGi.Core.Query.CloneAndFilterNulls(outputs);
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
