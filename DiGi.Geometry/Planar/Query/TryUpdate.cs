using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool TryUpdate(this IEnumerable<IGeometry2DUpdater> geometry2DFixers, IGeometry2D input, out IGeometry2D output)
        {
            output = null;

            if (geometry2DFixers == null || input == null)
            {
                return false;
            }

            output = input.Clone<IGeometry2D>();
            
            if (geometry2DFixers.Count() == 0)
            {
                return true;
            }

            foreach(IGeometry2DUpdater geometry2DFixer in geometry2DFixers)
            {
                if(geometry2DFixer == null)
                {
                    continue;
                }

                IGeometry2D geometry2D = null;
                if(!geometry2DFixer.TryUpdate(output, out geometry2D))
                {
                    continue;
                }

                output = geometry2D;
                if(output == null)
                {
                    return false;
                }
            }

            return output != null;
        }
    }
}
