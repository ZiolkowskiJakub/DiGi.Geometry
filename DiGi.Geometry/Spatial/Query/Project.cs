using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Projects a <see cref="Point3D"/> onto a <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to project the point onto.</param>
        /// <param name="point3D">The <see cref="Point3D"/> to be projected.</param>
        /// <returns>The projected <see cref="Point3D"/> on the plane, or null if either the plane or the point is null.</returns>
        public static Point3D? Project(this Plane? plane, Point3D? point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            return plane.ClosestPoint(point3D);
        }

        /// <summary>
        /// Projects the specified <see cref="Vector3D"/> onto the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> onto which the vector is projected.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> to project.</param>
        /// <returns>A <see cref="Vector3D"/> representing the projection of the <see cref="Vector3D"/> on the <see cref="Plane"/>, or <c>null</c> if either the plane or the vector3D is null.</returns>
        public static Vector3D? Project(this Plane? plane, Vector3D? vector3D)
        {
            if (plane == null || vector3D == null)
            {
                return null;
            }

            double double_A = plane.A;
            double double_B = plane.B;
            double double_C = plane.C;

            if (double.IsNaN(double_A) || double.IsNaN(double_B) || double.IsNaN(double_C))
            {
                return null;
            }

            double double_Vx = vector3D.X;
            double double_Vy = vector3D.Y;
            double double_Vz = vector3D.Z;

            double double_Dot = double_Vx * double_A + double_Vy * double_B + double_Vz * double_C;

            return new Vector3D(double_Vx - double_Dot * double_A, double_Vy - double_Dot * double_B, double_Vz - double_Dot * double_C);
        }

        /// <summary>
        /// Projects the specified 3D geometry onto the plane.
        /// </summary>
        /// <typeparam name="T">The type of the resulting projected geometry, which must implement <see cref="IGeometry3D"/>.</typeparam>
        /// <param name="plane">The <see cref="Plane"/> onto which the geometry is projected.</param>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> object to be projected.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the projection operation.</param>
        /// <returns>The projected geometry of type <typeparam ref="T"/>, or <c>null</c> if the projection fails or input parameters are null.</returns>
        public static T? Project<T>(this Plane? plane, IGeometry3D? geometry3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IGeometry3D
        {
            if (geometry3D == null || plane == null)
            {
                return default;
            }

            if (geometry3D is Point3D point3D_Temp)
            {
                if (typeof(T).IsAssignableFrom(typeof(Point3D)))
                {
                    Point3D? point3D = Project(plane, point3D_Temp);
                    if (point3D != null)
                    {
                        return (T)(object)point3D;
                    }
                }

                return default;
            }

            ProjectionResult? projectionResult = Create.ProjectionResult(plane, geometry3D, tolerance);
            if (projectionResult == null)
            {
                return default;
            }

            List<T>? ts = projectionResult.GetGeometry3Ds<T>();
            if (ts == null || ts.Count == 0)
            {
                return default;
            }

            return ts[0];
        }
    }
}