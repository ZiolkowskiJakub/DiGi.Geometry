using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates a single <see cref="Classes.BoundingBox3D"/> that encompasses all provided bounding boxes in the collection.
        /// </summary>
        /// <param name="boundingBox3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Classes.BoundingBox3D"/> objects to process.</param>
        /// <returns>A <see cref="Classes.BoundingBox3D"/> representing the union of all input bounding boxes, or <c>null</c> if the collection is null or contains no valid bounding boxes.</returns>
        public static BoundingBox3D? BoundingBox3D(this IEnumerable<BoundingBox3D>? boundingBox3Ds)
        {
            if (boundingBox3Ds == null)
            {
                return null;
            }

            BoundingBox3D? result = null;
            foreach (BoundingBox3D boundingBox3D in boundingBox3Ds)
            {
                if (boundingBox3D == null)
                {
                    continue;
                }

                if (result == null)
                {
                    if (boundingBox3D.Min != null && boundingBox3D.Max != null)
                    {
                        result = new BoundingBox3D(boundingBox3D);
                    }
                    continue;
                }

                result.Add(boundingBox3D);
            }

            return result;
        }

        /// <summary>
        /// Calculates a <see cref="Classes.BoundingBox3D"/> that encompasses all provided polygonal faces.
        /// </summary>
        /// <param name="polygonalFace3Ds">An <see cref="IEnumerable{IPolygonalFace3D}"/> of faces to process.</param>
        /// <returns>A <see cref="Classes.BoundingBox3D"/> representing the bounding box, or <c>null</c> if the collection is null or contains no valid bounding boxes.</returns>
        public static BoundingBox3D? BoundingBox3D(this IEnumerable<IPolygonalFace3D>? polygonalFace3Ds)
        {
            if (polygonalFace3Ds == null)
            {
                return null;
            }

            double double_MinX = double.MaxValue;
            double double_MinY = double.MaxValue;
            double double_MinZ = double.MaxValue;
            double double_MaxX = double.MinValue;
            double double_MaxY = double.MinValue;
            double double_MaxZ = double.MinValue;
            bool bool_Any = false;

            foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                if (polygonalFace3D == null)
                {
                    continue;
                }

                BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();
                if (boundingBox3D != null)
                {
                    double_MinX = System.Math.Min(double_MinX, boundingBox3D.Min.X);
                    double_MinY = System.Math.Min(double_MinY, boundingBox3D.Min.Y);
                    double_MinZ = System.Math.Min(double_MinZ, boundingBox3D.Min.Z);
                    double_MaxX = System.Math.Max(double_MaxX, boundingBox3D.Max.X);
                    double_MaxY = System.Math.Max(double_MaxY, boundingBox3D.Max.Y);
                    double_MaxZ = System.Math.Max(double_MaxZ, boundingBox3D.Max.Z);
                    bool_Any = true;
                }
            }

            if (!bool_Any)
            {
                return null;
            }

            return new BoundingBox3D(new Point3D(double_MinX, double_MinY, double_MinZ), new Point3D(double_MaxX, double_MaxY, double_MaxZ));
        }

        /// <summary>
        /// Creates a <see cref="Classes.BoundingBox3D"/> based on the provided X, Y, and Z ranges.
        /// </summary>
        /// <param name="x">The <c>Range&lt;double&gt;</c> for the X axis.</param>
        /// <param name="y">The <c>Range&lt;double&gt;</c> for the Y axis.</param>
        /// <param name="z">The <c>Range&lt;double&gt;</c> for the Z axis.</param>
        /// <returns>A <see cref="Classes.BoundingBox3D"/> if all provided ranges are not null; otherwise, null.</returns>
        public static BoundingBox3D? BoundingBox3D(Range<double>? x, Range<double>? y, Range<double>? z)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            return new BoundingBox3D(new Point3D(x.Min, y.Min, z.Min), new Point3D(x.Max, y.Max, z.Max));
        }
    }
}