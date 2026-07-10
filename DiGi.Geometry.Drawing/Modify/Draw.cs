using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DiGi.Geometry.Drawing
{
    public static partial class Modify
    {
        /// <summary>
        /// Draws a <see cref="Segment2D"/> using the specified <see cref="Graphics"/> context and <see cref="Pen"/>.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> object representing the line segment to be drawn.</param>
        /// <param name="pen">The <see cref="Pen"/> object used to define the color and width of the line.</param>
        public static void Draw(this Graphics? graphics, Segment2D? segment2D, Pen? pen)
        {
            if (graphics == null || segment2D == null || pen == null)
            {
                return;
            }

            PointF? start = Convert.ToDrawing(segment2D?.Start);
            if (start == null || !start.HasValue)
            {
                return;
            }

            PointF? end = Convert.ToDrawing(segment2D?.End);
            if (end == null || !end.HasValue)
            {
                return;
            }

            graphics.DrawLine(pen, start.Value, end.Value);
        }

        /// <summary>
        /// Draws a polygonal 2D shape on the specified graphics surface.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object that defines the polygon to be drawn.</param>
        /// <param name="pen">The <see cref="Pen"/> object used to draw the outline of the polygon.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the interior of the polygon should be filled.</param>
        public static void Draw(this Graphics? graphics, IPolygonal2D? polygonal2D, Pen? pen, bool fill)
        {
            if (graphics == null || pen == null || polygonal2D == null)
            {
                return;
            }

            List<Point2D>? point2Ds = polygonal2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return;
            }

            point2Ds.Add(point2Ds.First());

            List<PointF> pointFs = [];
            for (int i = 0; i < point2Ds.Count; i++)
            {
                PointF? pointF = Convert.ToDrawing(point2Ds[i]);
                if (pointF == null || !pointF.HasValue)
                {
                    continue;
                }

                pointFs.Add(pointF.Value);
            }

            if (fill)
            {
                using SolidBrush solidBrush = new(pen.Color);

                graphics.FillPolygon(solidBrush, pointFs.ToArray());
            }
            else
            {
                graphics.DrawLines(pen, pointFs.ToArray());
            }
        }

        /// <summary>
        /// Draws a <see cref="BoundingBox2D"/> using the specified <see cref="Graphics"/> object and <see cref="Pen"/>.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to be drawn.</param>
        /// <param name="pen">The <see cref="Pen"/> used for the drawing operation.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the bounding box should be filled.</param>
        public static void Draw(this Graphics? graphics, BoundingBox2D? boundingBox2D, Pen? pen, bool fill)
        {
            if (graphics == null || pen == null || boundingBox2D == null)
            {
                return;
            }

            List<Point2D>? point2Ds = boundingBox2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return;
            }

            point2Ds.Add(point2Ds.First());

            List<PointF> pointFs = [];
            for (int i = 0; i < point2Ds.Count; i++)
            {
                PointF? pointF = Convert.ToDrawing(point2Ds[i]);
                if (pointF == null || !pointF.HasValue)
                {
                    continue;
                }

                pointFs.Add(pointF.Value);
            }

            if (fill)
            {
                using SolidBrush solidBrush = new(pen.Color);

                graphics.FillPolygon(solidBrush, pointFs.ToArray());
            }
            else
            {
                graphics.DrawLines(pen, pointFs.ToArray());
            }
        }

        /// <summary>
        /// Draws an ellipse at the specified point using the provided pen, with an option to fill it.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="point2D">The <see cref="Point2D"/> coordinates where the ellipse will be drawn.</param>
        /// <param name="pen">The <see cref="Pen"/> that defines the color and width of the ellipse.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether to fill the interior of the ellipse.</param>
        public static void Draw(this Graphics? graphics, Point2D? point2D, Pen? pen, bool fill)
        {
            if (graphics == null || pen == null || point2D == null)
            {
                return;
            }

            if (fill)
            {
                using SolidBrush solidBrush = new(pen.Color);

                graphics.FillEllipse(solidBrush, System.Convert.ToSingle(point2D.X), System.Convert.ToSingle(point2D.Y), pen.Width, pen.Width);
            }
            else
            {
                graphics.DrawEllipse(pen, System.Convert.ToSingle(point2D.X), System.Convert.ToSingle(point2D.Y), pen.Width, pen.Width);
            }
        }

        /// <summary>
        /// Draws the specified <see cref="IPolygonalFace2D"/> on the provided <see cref="Graphics"/> surface using the specified <see cref="Pen"/>.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="polygonalFace2D">The <see cref="IPolygonalFace2D"/> instance to be drawn.</param>
        /// <param name="pen">The <see cref="Pen"/> used to draw the outline of the polygonal face.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the interior of the polygonal face should be filled.</param>
        public static void Draw(this Graphics? graphics, IPolygonalFace2D? polygonalFace2D, Pen? pen, bool fill)
        {
            if (graphics == null || pen == null || polygonalFace2D == null)
            {
                return;
            }

            Mesh2D? mesh2D = Create.Mesh2D(polygonalFace2D);
            if (mesh2D == null)
            {
                return;
            }

            Draw(graphics, mesh2D, pen, fill);
        }

        /// <summary>
        /// Draws a <see cref="Mesh2D"/> using the specified <see cref="Graphics"/> context, <see cref="Pen"/>, and fill option.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="mesh2D">The <see cref="Mesh2D"/> object to be drawn.</param>
        /// <param name="pen">The <see cref="Pen"/> object used for the drawing style and color.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the mesh should be filled.</param>
        public static void Draw(this Graphics? graphics, Mesh2D? mesh2D, Pen? pen, bool fill)
        {
            if (graphics == null || pen == null || mesh2D == null)
            {
                return;
            }

            if (fill)
            {
                List<Triangle2D>? triangle2Ds = mesh2D.GetTriangles();
                if (triangle2Ds == null)
                {
                    return;
                }

                foreach (Triangle2D triangle2D in triangle2Ds)
                {
                    Draw(graphics, triangle2D, pen, fill);
                }
            }
            else
            {
                List<Segment2D>? segment2Ds = mesh2D.GetSegments();
                if (segment2Ds == null)
                {
                    return;
                }

                foreach (Segment2D segment2D in segment2Ds)
                {
                    Draw(graphics, segment2D, pen);
                }
            }
        }

        /// <summary>
        /// Draws a <see cref="Segment2D"/> using the specified <see cref="Graphics"/> object and <see cref="DiGi.Core.Drawing.Classes.Pen"/>.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> to be drawn.</param>
        /// <param name="pen">The <see cref="DiGi.Core.Drawing.Classes.Pen"/> that defines the style of the line.</param>
        public static void Draw(this Graphics? graphics, Segment2D? segment2D, DiGi.Core.Drawing.Classes.Pen pen)
        {
            Draw(graphics, segment2D, DiGi.Core.Drawing.Convert.ToDrawing(pen));
        }

        /// <summary>
        /// Draws the specified polygonal 2D object using the provided pen and fill settings.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> instance used for drawing.</param>
        /// <param name="pen">The <see cref="DiGi.Core.Drawing.Classes.Pen"/> that defines the drawing style.</param>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object to draw.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the interior of the polygonal 2D object should be filled.</param>
        public static void Draw(this Graphics? graphics, DiGi.Core.Drawing.Classes.Pen? pen, IPolygonal2D polygonal2D, bool fill)
        {
            Draw(graphics, polygonal2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }

        /// <summary>
        /// Draws a <see cref="Point2D"/> using the specified <see cref="DiGi.Core.Drawing.Classes.Pen"/> and fill setting on the provided <see cref="Graphics"/> object.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> instance used for drawing operations.</param>
        /// <param name="point2D">The <see cref="Point2D"/> to be drawn.</param>
        /// <param name="pen">The <see cref="DiGi.Core.Drawing.Classes.Pen"/> that defines the drawing style.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the point should be filled.</param>
        public static void Draw(this Graphics? graphics, Point2D? point2D, DiGi.Core.Drawing.Classes.Pen? pen, bool fill)
        {
            Draw(graphics, point2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }

        /// <summary>
        /// Draws a <see cref="Mesh2D"/> using the specified <see cref="DiGi.Core.Drawing.Classes.Pen"/>.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="mesh2D">The <see cref="Mesh2D"/> object to be drawn.</param>
        /// <param name="pen">The <see cref="DiGi.Core.Drawing.Classes.Pen"/> used to define the style of the drawing.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the mesh should be filled.</param>
        public static void Draw(this Graphics? graphics, Mesh2D? mesh2D, DiGi.Core.Drawing.Classes.Pen? pen, bool fill)
        {
            Draw(graphics, mesh2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }

        /// <summary>
        /// Draws a 2D bounding box using the specified pen and fill settings.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object used for drawing.</param>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to be drawn.</param>
        /// <param name="pen">The <see cref="DiGi.Core.Drawing.Classes.Pen"/> that defines the line style and color.</param>
        /// <param name="fill">A <see cref="bool"/> value indicating whether the interior of the bounding box should be filled.</param>
        public static void Draw(this Graphics? graphics, BoundingBox2D? boundingBox2D, DiGi.Core.Drawing.Classes.Pen pen, bool fill)
        {
            Draw(graphics, boundingBox2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }
    }
}