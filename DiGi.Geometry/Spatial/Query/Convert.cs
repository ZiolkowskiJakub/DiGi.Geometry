using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Converts a <see cref="Ray2D"/> to a <see cref="Ray3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="ray2D">The <see cref="Ray2D"/> to convert.</param>
        /// <returns>A <see cref="Ray3D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Ray3D? Convert(this Plane? plane, Ray2D? ray2D)
        {
            if (plane?.Convert(ray2D?.Direction) is not Vector3D direction)
            {
                return null;
            }

            if (plane.Convert(ray2D!.Origin) is not Point3D origin)
            {
                return null;
            }

            return new Ray3D(origin, direction);
        }

        /// <summary>
        /// Converts a <see cref="Ray3D"/> to a <see cref="Ray2D"/> relative to the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="ray3D">The <see cref="Ray3D"/> to convert.</param>
        /// <returns>A <see cref="Ray2D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Ray2D? Convert(this Plane? plane, Ray3D? ray3D)
        {
            if (plane?.Convert(ray3D?.Direction) is not Vector2D direction)
            {
                return null;
            }

            if (plane.Convert(ray3D!.Origin) is not Point2D origin)
            {
                return null;
            }

            return new Ray2D(origin, direction);
        }

        /// <summary>
        /// Converts a <see cref="Point2D"/> to a <see cref="Point3D"/> based on the coordinate system of the provided <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the reference for the conversion.</param>
        /// <param name="point2D">The <see cref="Point2D"/> to convert.</param>
        /// <returns>A <see cref="Point3D"/> representing the 2D point in 3D space, or null if the <see cref="Plane"/>, the <see cref="Point2D"/>, or the plane's axes are null.</returns>
        public static Point3D? Convert(this Plane? plane, Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            Vector3D? axisX = plane?.AxisX;
            if (axisX is null)
            {
                return null;
            }

            Vector3D? axisY = plane!.AxisY;
            if (axisY is null)
            {
                return null;
            }

            Point3D? origin = plane!.Origin;
            if (origin is null)
            {
                return null;
            }

            Vector3D u = new(axisY.X * point2D.Y, axisY.Y * point2D.Y, axisY.Z * point2D.Y);
            Vector3D v = new(axisX.X * point2D.X, axisX.Y * point2D.X, axisX.Z * point2D.X);

            return new(origin.X + u.X + v.X, origin.Y + u.Y + v.Y, origin.Z + u.Z + v.Z);
        }

        /// <summary>
        /// Converts a <see cref="Vector2D"/> to a <see cref="Vector3D"/> based on the coordinate system of the provided <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the reference for the conversion.</param>
        /// <param name="vector2D">The <see cref="Vector2D"/> to convert.</param>
        /// <returns>A <see cref="Vector3D"/> representing the converted vector, or <c>null</c> if the <see cref="Plane"/>, the <see cref="Vector2D"/>, or any of the plane's axes are <c>null</c>.</returns>
        public static Vector3D? Convert(this Plane? plane, Vector2D? vector2D)
        {
            if (plane == null || vector2D == null)
            {
                return null;
            }

            Vector3D? axisX = plane.AxisX;
            if (axisX is null)
            {
                return null;
            }

            Vector3D? axisY = plane.AxisY;
            if (axisY is null)
            {
                return null;
            }

            Vector3D u = new(axisY.X * vector2D.Y, axisY.Y * vector2D.Y, axisY.Z * vector2D.Y);
            Vector3D v = new(axisX.X * vector2D.X, axisX.Y * vector2D.X, axisX.Z * vector2D.X);

            return new(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
        }

        /// <summary>
        /// Converts a <see cref="Segment2D"/> to a <see cref="Segment3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for conversion.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> to convert.</param>
        /// <returns>A <see cref="Segment3D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Segment3D? Convert(this Plane? plane, Segment2D? segment2D)
        {
            if (plane == null || segment2D == null)
            {
                return null;
            }

            Point3D? start = plane.Convert(segment2D.Start);
            if (start == null)
            {
                return null;
            }

            Point3D? end = plane.Convert(segment2D.End);
            if (end == null)
            {
                return null;
            }

            return new(start, end);
        }

        /// <summary>
        /// Converts a <see cref="Line2D"/> to a <see cref="Line3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="line2D">The <see cref="Line2D"/> instance to convert.</param>
        /// <returns>A <see cref="Line3D"/> representing the converted line, or <c>null</c> if the <see cref="Plane"/> or <see cref="Line2D"/> is <c>null</c>, or if conversion of the origin or direction fails.</returns>
        public static Line3D? Convert(this Plane? plane, Line2D? line2D)
        {
            if (plane is null || line2D is null)
            {
                return null;
            }

            Point3D? origin = plane.Convert(line2D.Origin);
            if (origin == null)
            {
                return null;
            }

            Vector3D? direction = plane.Convert(line2D.Direction);
            if (direction == null)
            {
                return null;
            }

            return new(origin, direction);
        }

        /// <summary>
        /// Converts a <see cref="Triangle2D"/> to a <see cref="Triangle3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="triangle2D">The <see cref="Triangle2D"/> to convert.</param>
        /// <returns>A <see cref="Triangle3D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Triangle3D? Convert(this Plane? plane, Triangle2D? triangle2D)
        {
            if (plane == null || triangle2D == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = triangle2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            Point3D? point3D_1 = plane.Convert(point2Ds[0]);
            if (point3D_1 == null)
            {
                return null;
            }

            Point3D? point3D_2 = plane.Convert(point2Ds[1]);
            if (point3D_2 == null)
            {
                return null;
            }

            Point3D? point3D_3 = plane.Convert(point2Ds[2]);
            if (point3D_3 == null)
            {
                return null;
            }

            return new(point3D_1, point3D_2, point3D_3);
        }

        /// <summary>
        /// Converts a <see cref="Polygon2D"/> to a <see cref="Polygon3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="polygon2D">The <see cref="Polygon2D"/> instance to convert.</param>
        /// <returns>A <see cref="Polygon3D"/> instance if both the <see cref="Plane"/> and <see cref="Polygon2D"/> are not null; otherwise, null.</returns>
        public static Polygon3D? Convert(this Plane? plane, Polygon2D? polygon2D)
        {
            if (plane == null || polygon2D == null)
            {
                return null;
            }

            return new(plane, polygon2D);
        }

        /// <summary>
        /// Converts a <see cref="Rectangle2D"/> to a <see cref="Rectangle3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="rectangle2D">The <see cref="Rectangle2D"/> to convert.</param>
        /// <returns>A <see cref="Rectangle3D"/> if both parameters are not null; otherwise, null.</returns>
        public static Rectangle3D? Convert(this Plane? plane, Rectangle2D rectangle2D)
        {
            if (plane == null || rectangle2D == null)
            {
                return null;
            }

            return new Rectangle3D(plane, rectangle2D);
        }

        /// <summary>
        /// Converts a 2D polygonal object to a 3D polygonal object based on the specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the reference for the conversion.</param>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object to be converted.</param>
        /// <returns>An <see cref="IPolygonal3D"/> representation of the 2D polygonal shape, or <see langword="null"/> if the <see cref="Plane"/> or <see cref="IPolygonal2D"/> is <see langword="null"/>.</returns>
        public static IPolygonal3D? Convert(this Plane? plane, IPolygonal2D? polygonal2D)
        {
            if (plane == null || polygonal2D == null)
            {
                return null;
            }

            return Convert(plane, polygonal2D as dynamic);
        }

        /// <summary>
        /// Converts a <see cref="Point3D"/> to a <see cref="Point2D"/> relative to the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the reference for conversion.</param>
        /// <param name="point3D">The <see cref="Point3D"/> to be converted.</param>
        /// <returns>A <see cref="Point2D"/> representing the point's coordinates on the plane, or <c>null</c> if the <see cref="Plane"/>, the <see cref="Point3D"/>, or any required plane components are null.</returns>
        public static Point2D? Convert(this Plane? plane, Point3D? point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            Vector3D? axisX = plane.AxisX;
            if (axisX is null)
            {
                return null;
            }

            Vector3D? axisY = plane.AxisY;
            if (axisY is null)
            {
                return null;
            }

            Point3D? origin = plane.Origin;
            if (origin is null)
            {
                return null;
            }

            Vector3D vector3D = new(point3D.X - origin.X, point3D.Y - origin.Y, point3D.Z - origin.Z);
            return new(axisX.DotProduct(vector3D), axisY.DotProduct(vector3D));
        }

        /// <summary>
        /// Converts a <see cref="Vector3D"/> to a <see cref="Vector2D"/> based on the coordinate system of the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the reference for the conversion.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> to be converted.</param>
        /// <returns>A <see cref="Vector2D"/> representing the projection of the <see cref="Vector3D"/> onto the plane's axes, or <c>null</c> if the <see cref="Plane"/>, <see cref="Vector3D"/>, or any of the plane's axes are null.</returns>
        public static Vector2D? Convert(this Plane? plane, Vector3D? vector3D)
        {
            if (plane == null || vector3D == null)
            {
                return null;
            }

            Vector3D? axisX = plane.AxisX;
            if (axisX is null)
            {
                return null;
            }

            Vector3D? axisY = plane.AxisY;
            if (axisY is null)
            {
                return null;
            }

            return new(axisX.DotProduct(vector3D), axisY.DotProduct(vector3D));
        }

        /// <summary>
        /// Converts a <see cref="Segment3D"/> to a <see cref="Segment2D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="segment3D">The <see cref="Segment3D"/> to convert.</param>
        /// <returns>A <see cref="Segment2D"/> if the conversion is successful; otherwise, null.</returns>
        public static Segment2D? Convert(this Plane? plane, Segment3D? segment3D)
        {
            if (plane == null || segment3D == null)
            {
                return null;
            }

            Point2D? start = plane.Convert(segment3D.Start);
            if (start == null)
            {
                return null;
            }

            Point2D? end = plane.Convert(segment3D.End);
            if (end == null)
            {
                return null;
            }

            return new(start, end);
        }

        /// <summary>
        /// Converts a <see cref="Line3D"/> to a <see cref="Line2D"/> relative to the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="line3D">The <see cref="Line3D"/> to convert.</param>
        /// <returns>A <see cref="Line2D"/> representing the converted line, or null if the plane, the line, or any of its components cannot be converted.</returns>
        public static Line2D? Convert(this Plane? plane, Line3D? line3D)
        {
            if (plane is null || line3D is null)
            {
                return null;
            }

            Point2D? origin = plane.Convert(line3D.Origin);
            if (origin == null)
            {
                return null;
            }

            Vector2D? direction = plane.Convert(line3D.Direction);
            if (direction == null)
            {
                return null;
            }

            return new(origin, direction);
        }

        /// <summary>
        /// Converts a <see cref="Triangle3D"/> to a <see cref="Triangle2D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="triangle3D">The <see cref="Triangle3D"/> to convert.</param>
        /// <returns>A <see cref="Triangle2D"/> representing the projected triangle, or <c>null</c> if the <see cref="Plane"/>, the <see cref="Triangle3D"/>, or any of its points are null or cannot be converted.</returns>
        public static Triangle2D? Convert(this Plane? plane, Triangle3D? triangle3D)
        {
            if (plane == null || triangle3D == null)
            {
                return null;
            }

            List<Point3D>? point3Ds = triangle3D.GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            Point2D? point2D_1 = plane.Convert(point3Ds[0]);
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = plane.Convert(point3Ds[1]);
            if (point2D_2 == null)
            {
                return null;
            }

            Point2D? point2D_3 = plane.Convert(point3Ds[2]);
            if (point2D_3 == null)
            {
                return null;
            }

            return new(point2D_1, point2D_2, point2D_3);
        }

        /// <summary>
        /// Converts a <see cref="Polygon3D"/> to a <see cref="Polygon2D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used to project the 3D polygon into 2D space.</param>
        /// <param name="polygon3D">The <see cref="Polygon3D"/> object to convert.</param>
        /// <returns>A <see cref="Polygon2D"/> representing the converted polygon, or <see langword="null"/> if the plane, the 3D polygon, or its points are null.</returns>
        public static Polygon2D? Convert(this Plane? plane, Polygon3D? polygon3D)
        {
            if (plane == null || polygon3D == null)
            {
                return null;
            }

            List<Point3D>? point3Ds = polygon3D.GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds = [];
            for (int i = 0; i < point3Ds.Count; i++)
            {
                Point2D? point2D = plane.Convert(point3Ds[i]);
                if (point2D is null)
                {
                    continue;
                }

                point2Ds.Add(point2D);
            }

            return new(point2Ds);
        }

        //public static IPolygonal2D? Convert(this Plane? plane, IPolygonal3D? polygonal3D)
        //{
        //    if(plane == null || polygonal3D == null)
        //    {
        //        return null;
        //    }

        //    if(polygonal3D is Rectangle3D rectangle3D)
        //    {
        //        return Convert(plane, rectangle3D);
        //    }

        //    return Convert(plane, polygonal3D as dynamic);
        //}

        /// <summary>
        /// Converts a 3D polygonal object to a 2D polygonal object based on a specified <see cref="Plane"/> and tolerance.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the projection.</param>
        /// <param name="polygonal3D">The <see cref="IPolygonal3D"/> object to be converted.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used during conversion.</param>
        /// <returns>An <see cref="IPolygonal2D"/> representation of the 3D polygon on the plane, or <see langword="null"/> if either the <see cref="Plane"/> or the <see cref="IPolygonal3D"/> is null.</returns>
        public static IPolygonal2D? Convert(this Plane? plane, IPolygonal3D? polygonal3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || polygonal3D == null)
            {
                return null;
            }

            if (polygonal3D is Rectangle3D rectangle3D)
            {
                return Convert(plane, rectangle3D, tolerance);
            }

            return Convert(plane, polygonal3D as dynamic);
        }

        /// <summary>
        /// Converts a <see cref="Rectangle3D"/> to an <see cref="IPolygonal2D"/> relative to the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="rectangle3D">The <see cref="Rectangle3D"/> to convert.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>An <see cref="IPolygonal2D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static IPolygonal2D? Convert(this Plane? plane, Rectangle3D? rectangle3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (rectangle3D == null || plane?.Normal is not Vector3D normal)
            {
                return null;
            }

            if (normal.Similar(rectangle3D.Plane?.Normal, tolerance))
            {
                return rectangle3D.Geometry2D;
            }

            IPolygonal2D? result = Convert(plane, new Polygon3D(rectangle3D.Plane, new Polygon2D(rectangle3D.Geometry2D)));
            if (result == null)
            {
                return result;
            }

            if (Planar.Create.Rectangle2D(result, tolerance) is Rectangle2D rectangle2D)
            {
                if (rectangle2D.GetArea().AlmostEquals(result.GetArea(), tolerance))
                {
                    result = rectangle2D;
                }
            }

            return result;
        }

        /// <summary>
        /// Converts a <see cref="Polyline2D"/> to a <see cref="Polyline3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="polyline2D">The <see cref="Polyline2D"/> to convert.</param>
        /// <returns>A <see cref="Polyline3D"/> resulting from the conversion, or <see langword="null"/> if the <see cref="Plane"/> or <see cref="Polyline2D"/> is null.</returns>
        public static Polyline3D? Convert(this Plane? plane, Polyline2D? polyline2D)
        {
            if (plane == null || polyline2D == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = polyline2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            List<Point3D> point3Ds = [];
            for (int i = 0; i < point2Ds.Count; i++)
            {
                Point3D? point3D = plane.Convert(point2Ds[i]);
                if (point3D is null)
                {
                    continue;
                }

                point3Ds.Add(point3D);
            }

            return new(point3Ds);
        }

        /// <summary>
        /// Converts a 3D polygonal face to a 2D polygonal face using the specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> to be converted.</param>
        /// <returns>An <see cref="IPolygonalFace2D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static IPolygonalFace2D? Convert(this Plane? plane, IPolygonalFace3D? polygonalFace3D)
        {
            return Convert(plane, polygonalFace3D as PolygonalFace3D);
        }

        /// <summary>
        /// Converts a 2D polygonal face to a 3D polygonal face using the specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace2D"/> to convert.</param>
        /// <returns>An <see cref="IPolygonalFace3D"/> if the conversion is successful; otherwise, null.</returns>
        public static IPolygonalFace3D? Convert(this Plane? plane, IPolygonalFace2D? polygonalFace3D)
        {
            return Convert(plane, polygonalFace3D as PolygonalFace2D);
        }

        /// <summary>
        /// Converts a <see cref="PolygonalFace3D"/> to a <see cref="PolygonalFace2D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="polygonalFace3D">The <see cref="PolygonalFace3D"/> to convert.</param>
        /// <returns>A <see cref="PolygonalFace2D"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static PolygonalFace2D? Convert(this Plane? plane, PolygonalFace3D? polygonalFace3D)
        {
            if (plane == null || polygonalFace3D == null)
            {
                return null;
            }

            IPolygonal2D? externalEdge = plane.Convert(polygonalFace3D.ExternalEdge);
            if (externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D>? internalEdges = null;

            List<IPolygonal3D>? internalEdges_3D = polygonalFace3D.InternalEdges;
            if (internalEdges_3D != null && internalEdges_3D.Count != 0)
            {
                internalEdges = [];
                for (int i = 0; i < internalEdges_3D.Count; i++)
                {
                    IPolygonal2D? internalEdge = plane.Convert(internalEdges_3D[i]);
                    if (internalEdge == null)
                    {
                        continue;
                    }

                    internalEdges.Add(internalEdge);
                }
            }

            return new(externalEdge, internalEdges);
        }

        /// <summary>
        /// Converts a <see cref="PolygonalFace2D"/> to a <see cref="PolygonalFace3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="polygonalFace2D">The <see cref="PolygonalFace2D"/> instance to convert.</param>
        /// <returns>A <see cref="PolygonalFace3D"/> instance if both the <see cref="Plane"/> and <see cref="PolygonalFace2D"/> are not null; otherwise, null.</returns>
        public static PolygonalFace3D? Convert(this Plane? plane, PolygonalFace2D? polygonalFace2D)
        {
            if (plane == null || polygonalFace2D == null)
            {
                return null;
            }

            return new(plane, polygonalFace2D);
        }

        /// <summary>
        /// Converts a <see cref="Ellipse2D"/> to an <see cref="Ellipse3D"/> using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used for the conversion.</param>
        /// <param name="ellipse2D">The <see cref="Ellipse2D"/> to convert.</param>
        /// <returns>An <see cref="Ellipse3D"/> if both the <see cref="Plane"/> and <see cref="Ellipse2D"/> are not null; otherwise, null.</returns>
        public static Ellipse3D? Convert(this Plane? plane, Ellipse2D? ellipse2D)
        {
            if (plane == null || ellipse2D == null)
            {
                return null;
            }

            return new(plane, ellipse2D);
        }

        /// <summary>
        /// Converts a <see cref="Plane"/> and a <see cref="BoundingBox2D"/> into a <see cref="Rectangle3D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to use for the conversion.</param>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to use for the conversion.</param>
        /// <returns>A <see cref="Rectangle3D"/> if both parameters are valid; otherwise, null.</returns>
        public static Rectangle3D? Convert(Plane? plane, BoundingBox2D? boundingBox2D)
        {
            if (plane is null)
            {
                return null;
            }

            if (boundingBox2D?.GetPoints() is not List<Point2D> point2Ds)
            {
                return null;
            }

            return new(plane, point2Ds);
        }

        /// <summary>
        /// Converts a 2D geometry object to a 3D geometry object based on the specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used as the reference for the conversion.</param>
        /// <param name="geometry2D">The <see cref="IGeometry2D"/> instance to be converted.</param>
        /// <returns>An <see cref="IGeometry3D"/> object if the conversion is successful; otherwise, <c>null</c> if either the <see cref="Plane"/> or <see cref="IGeometry2D"/> is <c>null</c>.</returns>
        public static IGeometry3D? Convert(this Plane? plane, IGeometry2D? geometry2D)
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            return Convert(plane, geometry2D as dynamic);
        }

        /// <summary>
        /// Converts an <see cref="IPlanar"/> object to an <see cref="IGeometry2D"/>.
        /// </summary>
        /// <param name="planar">The <see cref="IPlanar"/> instance to convert.</param>
        /// <returns>An <see cref="IGeometry2D"/> representation if the conversion is successful; otherwise, null.</returns>
        public static IGeometry2D? Convert(IPlanar? planar)
        {
            Plane? plane = planar?.Plane;
            if (plane == null)
            {
                return null;
            }

            return Convert(plane, planar as dynamic);
        }

        /// <summary>
        /// Converts a given <see cref="IGeometry3D"/> instance into a list of <typeparamref name="TGeometry3D"/> instances.
        /// </summary>
        /// <typeparam name="TGeometry3D">The target type that implements the <see cref="IGeometry3D"/> interface.</typeparam>
        /// <param name="geometry3D">The source <see cref="IGeometry3D"/> object to convert.</param>
        /// <returns>A <see cref="List{TGeometry3D}"/> containing the converted geometry, or <see langword="null"/> if the provided <see cref="IGeometry3D"/> is null.</returns>
        public static List<TGeometry3D>? Convert<TGeometry3D>(IGeometry3D? geometry3D) where TGeometry3D : IGeometry3D
        {
            if (geometry3D is null)
            {
                return null;
            }

            if (geometry3D is TGeometry3D geometry_Temp)
            {
                if (DiGi.Core.Query.Clone(geometry_Temp) is TGeometry3D geometry_Temp_Temp)
                {
                    return [geometry_Temp_Temp];
                }
            }

            List<TGeometry3D> result = [];

            if (typeof(TGeometry3D).IsAssignableFrom(typeof(IPolygonal3D)))
            {
                if (geometry3D is IPolygonalFace3D polygonalFace3D)
                {
                    if (polygonalFace3D.Edges is List<IPolygonal3D> polygonal3Ds)
                    {
                        foreach (IPolygonal3D polygonal3D in polygonal3Ds)
                        {
                            List<TGeometry3D>? geometry3Ds = Convert<TGeometry3D>(polygonal3D);
                            if (geometry3Ds != null)
                            {
                                result.AddRange(geometry3Ds);
                            }
                        }
                    }

                    return result;
                }
            }

            if (typeof(TGeometry3D).IsAssignableFrom(typeof(PolygonalFace3D)))
            {
                if (geometry3D is IPolygonal3D polygonal3D)
                {
                    result.Add((TGeometry3D)(object)new PolygonalFace3D(polygonal3D));
                    return result;
                }
            }

            if (typeof(TGeometry3D).IsAssignableFrom(typeof(Segment3D)))
            {
                if (geometry3D is IPolygonal3D polygonal3D)
                {
                    if (polygonal3D.GetSegments() is List<Segment3D> segments)
                    {
                        foreach (Segment3D segment in segments)
                        {
                            if (segment is TGeometry3D geometry3D_Temp)
                            {
                                result.Add(geometry3D_Temp);
                            }
                        }
                    }

                    return result;
                }
            }

            return null;
        }
    }
}