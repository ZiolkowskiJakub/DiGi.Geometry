﻿using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Intersection of tw lines represented by vector3D (direction) and Point3D (origin). Source: https://github.com/arakis/Net3dBool/blob/39354914eba2f9d34aedd2a16a6528d50e19beec/src/Net3dBool/Line.cs#L46
        /// </summary>
        /// <param name="point3D_1">Origin point3D of first line</param>
        /// <param name="vector3D_1">Direction Vector3D of first line</param>
        /// <param name="point3D_2">Origin point3D of second line</param>
        /// <param name="vector3D_2">Direction Vector3D of second line</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns></returns>
        public static Point3D IntersectionPoint(this Point3D point3D_1, Vector3D vector3D_1, Point3D point3D_2, Vector3D vector3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            //x = x1 + a1*t = x2 + b1*s
            //y = y1 + a2*t = y2 + b2*s
            //z = z1 + a3*t = z2 + b3*s

            if (point3D_1 == null || vector3D_1 == null || point3D_2 == null || vector3D_2 == null)
            {
                return null;
            }

            double t;
            if (System.Math.Abs(vector3D_1.Y * vector3D_2.X - vector3D_1.X * vector3D_2.Y) > tolerance)
            {
                t = (-point3D_1.Y * vector3D_2.X + point3D_2.Y * vector3D_2.X + vector3D_2.Y * point3D_1.X - vector3D_2.Y * point3D_2.X) / (vector3D_1.Y * vector3D_2.X - vector3D_1.X * vector3D_2.Y);
            }
            else if (System.Math.Abs(-vector3D_1.X * vector3D_2.Z + vector3D_1.Z * vector3D_2.X) > tolerance)
            {
                t = -(-vector3D_2.Z * point3D_1.X + vector3D_2.Z * point3D_2.X + vector3D_2.X * point3D_1.Z - vector3D_2.X * point3D_2.Z) / (-vector3D_1.X * vector3D_2.Z + vector3D_1.Z * vector3D_2.X);
            }
            else if (System.Math.Abs(-vector3D_1.Z * vector3D_2.Y + vector3D_1.Y * vector3D_2.Z) > tolerance)
            {
                t = (point3D_1.Z * vector3D_2.Y - point3D_2.Z * vector3D_2.Y - vector3D_2.Z * point3D_1.Y + vector3D_2.Z * point3D_2.Y) / (-vector3D_1.Z * vector3D_2.Y + vector3D_1.Y * vector3D_2.Z);
            }
            else
            {
                return null;
            }

            double x = point3D_1.X + vector3D_1.X * t;
            double y = point3D_1.Y + vector3D_1.Y * t;
            double z = point3D_1.Z + vector3D_1.Z * t;

            return new Point3D(x, y, z);
        }

    }
}
