﻿using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static Line2D Line2D(this Point2D origin, double angle)
        {
            if (origin == null || double.IsNaN(angle) || double.IsInfinity(angle))
            {
                return null;
            }

            return new Line2D(origin, Vector2D(angle));
        }
    }

}
