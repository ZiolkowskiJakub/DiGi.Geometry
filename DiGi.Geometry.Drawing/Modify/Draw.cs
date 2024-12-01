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
        public static void Draw(this Graphics graphics, Segment2D segment2D, Pen pen)
        {
            if(graphics == null || segment2D == null || pen == null)
            {
                return;
            }

            PointF? start = Convert.ToDrawing(segment2D.Start);
            if(start == null || !start.HasValue)
            {
                return;
            }

            PointF? end = Convert.ToDrawing(segment2D.End);
            if (end == null || !end.HasValue)
            {
                return;
            }

            graphics.DrawLine(pen, start.Value, end.Value);
        }

        public static void Draw(this Graphics graphics, IPolygonal2D polygonal2D, Pen pen, bool fill)
        {
            if(graphics == null || pen == null || polygonal2D == null)
            {
                return;
            }

            List<Point2D> point2Ds = polygonal2D?.GetPoints();
            if(point2Ds == null || point2Ds.Count == 0)
            {
                return;
            }

            point2Ds.Add(point2Ds.First());

            List<PointF> pointFs = new List<PointF>();
            for(int i =0; i < point2Ds.Count; i++)
            {
                PointF? pointF = Convert.ToDrawing(point2Ds[i]);
                if(pointF == null || !pointF.HasValue)
                {
                    continue;
                }

                pointFs.Add(pointF.Value);
            }

            if(fill)
            {
                using (SolidBrush solidBrush = new SolidBrush(pen.Color))
                {
                    graphics.FillPolygon(solidBrush, pointFs.ToArray());
                }
            }
            else
            {
                graphics.DrawLines(pen, pointFs.ToArray());
            }
        }

        public static void Draw(this Graphics graphics, BoundingBox2D boundingBox2D, Pen pen, bool fill)
        {
            if (graphics == null || pen == null || boundingBox2D == null)
            {
                return;
            }

            List<Point2D> point2Ds = boundingBox2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return;
            }

            point2Ds.Add(point2Ds.First());

            List<PointF> pointFs = new List<PointF>();
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
                using (SolidBrush solidBrush = new SolidBrush(pen.Color))
                {
                    graphics.FillPolygon(solidBrush, pointFs.ToArray());
                }
            }
            else
            {
                graphics.DrawLines(pen, pointFs.ToArray());
            }
        }

        public static void Draw(this Graphics graphics, Point2D point2D, Pen pen, bool fill)
        {
            if (graphics == null || pen == null || point2D == null)
            {
                return;
            }

            if(fill)
            {
                using (SolidBrush solidBrush = new SolidBrush(pen.Color))
                {
                    graphics.FillEllipse(solidBrush, System.Convert.ToSingle(point2D.X), System.Convert.ToSingle(point2D.Y), pen.Width, pen.Width);
                }
            }
            else
            {
                graphics.DrawEllipse(pen, System.Convert.ToSingle(point2D.X), System.Convert.ToSingle(point2D.Y), pen.Width, pen.Width);
            }
        }

        public static void Draw(this Graphics graphics, IPolygonalFace2D polygonalFace2D, Pen pen, bool fill)
        {
            if(graphics == null || pen == null || polygonalFace2D == null)
            {
                return;
            }

            Mesh2D mesh2D = Create.Mesh2D(polygonalFace2D);
            if(mesh2D == null)
            {
                return;
            }

            Draw(graphics, mesh2D, pen, fill);
        }

        public static void Draw(this Graphics graphics, Mesh2D mesh2D, Pen pen, bool fill)
        {
            if (graphics == null || pen == null || mesh2D == null)
            {
                return;
            }

            if(fill)
            {
                List<Triangle2D> triangle2Ds = mesh2D.GetTriangles();
                if(triangle2Ds == null)
                {
                    return;
                }

                foreach(Triangle2D triangle2D in triangle2Ds)
                {
                    Draw(graphics, triangle2D, pen, fill);
                }
            }
            else
            {
                List<Segment2D> segment2Ds = mesh2D.GetSegements();
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

        public static void Draw(this Graphics graphics, Segment2D segment2D, DiGi.Core.Drawing.Classes.Pen pen)
        {
            Draw(graphics, segment2D, DiGi.Core.Drawing.Convert.ToDrawing(pen));
        }

        public static void Draw(this Graphics graphics, DiGi.Core.Drawing.Classes.Pen pen, IPolygonal2D polygonal2D, bool fill)
        {
            Draw(graphics, polygonal2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }

        public static void Draw(this Graphics graphics, Point2D point2D, DiGi.Core.Drawing.Classes.Pen pen, bool fill)
        {
            Draw(graphics, point2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }

        public static void Draw(this Graphics graphics, Mesh2D mesh2D, DiGi.Core.Drawing.Classes.Pen pen, bool fill)
        {
            Draw(graphics, mesh2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }

        public static void Draw(this Graphics graphics, BoundingBox2D boundingBox2D, DiGi.Core.Drawing.Classes.Pen pen, bool fill)
        {
            Draw(graphics, boundingBox2D, DiGi.Core.Drawing.Convert.ToDrawing(pen), fill);
        }
    }
}