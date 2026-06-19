using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a list of <see cref="Point3D"/> points from the specified <see cref="Segment3D"/> based on the provided count.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> instance to extract points from.</param>
        /// <param name="count">The number of <see cref="Point3D"/> points to retrieve.</param>
        /// <returns>A <c>List&lt;Point3D&gt;</c> containing the requested points, or null if the <see cref="Segment3D"/> is null, the count is negative, or the points cannot be retrieved.</returns>
        public static List<Point3D>? Point3Ds(this Segment3D? segment3D, int count)
        {
            if (count < 0 || segment3D == null)
            {
                return null;
            }

            switch (count)
            {
                case 1:

                    if (segment3D.Mid() is not Point3D mid)
                    {
                        return null;
                    }

                    return [mid];

                case 2:
                    return segment3D.GetPoints();

                default:

                    Vector3D? vector3D = segment3D.Direction;
                    if (vector3D == null)
                    {
                        return null;
                    }

                    if (segment3D.Start is not Point3D start)
                    {
                        return null;
                    }

                    List<Point3D> result = [start];

                    int count_Temp = count - 1;

                    vector3D *= (segment3D.Length / count_Temp);
                    for (int i = 0; i < count_Temp; i++)
                    {
                        if (result[i].GetMoved(vector3D) is Point3D point3D)
                        {
                            result.Add(point3D);
                        }
                    }

                    return result;
            }
        }
    }
}