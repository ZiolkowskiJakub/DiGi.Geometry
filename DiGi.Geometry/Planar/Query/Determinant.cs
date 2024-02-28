﻿using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double Determinant(this Point2D point2D_1, Point2D point2D_2, Point2D point2D_3)
        {
            return (point2D_2.Y - point2D_1.Y) * (point2D_3.X - point2D_2.X) - (point2D_2.X - point2D_1.X) * (point2D_3.Y - point2D_2.Y);
        }

        public static double Determinant(this Vector2D vector2D_1, Vector2D vector2D_2)
        {
            return (vector2D_1.X * vector2D_2.Y) - (vector2D_1.Y * vector2D_2.X);
        }
    }
}
