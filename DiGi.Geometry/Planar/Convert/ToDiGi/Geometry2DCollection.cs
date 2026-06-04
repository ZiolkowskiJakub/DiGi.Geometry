using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="GeometryCollection"/> to a <see cref="GeometryCollection2D"/>.
        /// </summary>
        /// <param name="geometryCollection">The <see cref="GeometryCollection"/> instance to convert.</param>
        /// <returns>A <see cref="GeometryCollection2D"/> containing the converted elements, or <c>null</c> if the provided <see cref="GeometryCollection"/> is <c>null</c>.</returns>
        public static GeometryCollection2D? ToDiGi(this GeometryCollection? geometryCollection)
        {
            if (geometryCollection == null)
            {
                return null;
            }

            GeometryCollection2D result = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometryCollection)
            {
                if (geometry.ToDiGi() is not ICollectable2D collectable2D)
                {
                    continue;
                }

                result.Add(collectable2D);
            }

            return result;
        }
    }
}