using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static BoundingBox3D BoundingBox3D(this IEnumerable<BoundingBox3D> boundingBox3Ds)
        {
            if(boundingBox3Ds == null)
            {
                return null;
            }

            BoundingBox3D result = null; 
            foreach(BoundingBox3D boundingBox3D in boundingBox3Ds)
            {
                if(boundingBox3D == null)
                {
                    continue;
                }

                if(result == null)
                {
                    if(boundingBox3D.Min != null && boundingBox3D.Max != null)
                    {
                        result = new BoundingBox3D(boundingBox3D);
                    }
                    continue;
                }

                result.Add(boundingBox3D);
            }

            return result;
        }

        public static BoundingBox3D BoundingBox3D(Range<double> x, Range<double> y, Range<double> z)
        {
            if(x == null || y == null || z == null)
            {
                return null;
            }

            return new BoundingBox3D(new Point3D(x.Min, y.Min, z.Min), new Point3D(x.Max, y.Max, z.Max));
        }
    }
}
