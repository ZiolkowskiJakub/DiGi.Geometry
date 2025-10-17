using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Ray3D? Scale(this Ray3D? ray3D, double factor)
        {
            if (ray3D == null || double.IsNaN(factor))
            {
                return null;
            }

            if (factor == 1.0)
            {
                return new Ray3D(ray3D);
            }

            Point3D? point = ray3D.Origin;
            if (point == null)
            {
                return null;
            }

            Vector3D? vector = ray3D.Direction;
            if (vector == null)
            {
                return null;
            }

            point = point.GetMoved(vector);

            vector *= factor;

            point = point?.GetMoved(vector?.GetInversed());

            return new Ray3D(point, vector);
        }

        public static List<Ray3D>? Scale(this IEnumerable<Ray3D>? ray3Ds, double factor)
        {
            if (ray3Ds == null)
            {
                return null;
            }

            List<Ray3D> result = [];
            foreach (Ray3D ray3D in ray3Ds)
            {
                if (Scale(ray3D, factor) is Ray3D ray3D_Scale)
                {
                    result.Add(ray3D_Scale);
                }
            }

            return result;
        }
    }
}
