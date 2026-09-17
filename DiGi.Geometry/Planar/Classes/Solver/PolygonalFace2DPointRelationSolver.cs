using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Classifies points against a polygonal face as <see cref="PointRelation.Inside"/>, <see cref="PointRelation.On"/> or <see cref="PointRelation.Outside"/> from an index built once over the face's rings.
    /// <para>
    /// Built once per face and reused for many point queries: set <see cref="Input"/> to the query point, call <see cref="Solve"/>, then read <see cref="Output"/>. It answers what <see cref="PolygonalFace2D.Inside(Point2D, double)"/> and <see cref="PolygonalFace2D.InRange(Point2D, double)"/> answer - a point within the tolerance of any ring is <see cref="PointRelation.On"/>, a point strictly inside the external ring and outside every hole is <see cref="PointRelation.Inside"/> - but reads the ring coordinates from flat arrays and visits only the edges whose vertical span covers the query point, instead of walking every vertex of every ring through its <see cref="Point2D"/> on each call. On a 4 000-vertex outline that is the difference between a 150 000-point sweep taking a minute and taking well under a second (ZiolkowskiJakub/DiGi.Geometry#5).
    /// </para>
    /// <para>
    /// Not thread-safe: instances keep the query state and a per-ring scratch buffer, so one instance serves one sweep at a time.
    /// </para>
    /// </summary>
    public class PolygonalFace2DPointRelationSolver : IOneToOneSolver<Point2D, PointRelation>
    {
        private readonly double tolerance;
        private readonly double tolerance_Squared;

        private readonly double x_Min = double.NaN;
        private readonly double x_Max = double.NaN;
        private readonly double y_Min = double.NaN;
        private readonly double y_Max = double.NaN;

        // One entry per edge of every ring, external ring first; the ring index tells the parity counts apart.
        private readonly double[] edge_X1 = [];
        private readonly double[] edge_Y1 = [];
        private readonly double[] edge_X2 = [];
        private readonly double[] edge_Y2 = [];
        private readonly int[] edge_Ring = [];

        // Uniform bins over the vertical extent: bin b lists the edges whose vertical span, widened by the
        // tolerance, meets [y_Min + b * bin_Height, y_Min + (b + 1) * bin_Height). A query at height y needs
        // only the edges of its bin, both for the ray crossings and for the distance to the boundary.
        private readonly int[][] bins = [];
        private readonly double bin_Height = 1.0;

        private readonly int ringCount = 0;
        private readonly bool[] parity_Scratch = [];

        private Point2D? point2D_Input = null;
        private PointRelation output = PointRelation.Undefined;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace2DPointRelationSolver"/> class over the rings of the given face.
        /// </summary>
        /// <param name="polygonalFace2D">The face to classify points against. Its rings are read once; later changes to the face are not seen.</param>
        /// <param name="tolerance">The distance tolerance within which a point counts as on the boundary.</param>
        public PolygonalFace2DPointRelationSolver(IPolygonalFace2D? polygonalFace2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            this.tolerance = System.Math.Abs(tolerance);
            tolerance_Squared = this.tolerance * this.tolerance;

            List<List<Point2D>> rings = [];
            if (polygonalFace2D?.ExternalEdge?.GetPoints() is List<Point2D> point2Ds_External && point2Ds_External.Count > 2)
            {
                rings.Add(point2Ds_External);
                if (polygonalFace2D.InternalEdges is List<IPolygonal2D> internalEdges)
                {
                    for (int i = 0; i < internalEdges.Count; i++)
                    {
                        if (internalEdges[i]?.GetPoints() is List<Point2D> point2Ds_Internal && point2Ds_Internal.Count > 2)
                        {
                            rings.Add(point2Ds_Internal);
                        }
                    }
                }
            }

            if (rings.Count == 0)
            {
                return;
            }

            int edgeCount = 0;
            for (int i = 0; i < rings.Count; i++)
            {
                edgeCount += rings[i].Count;
            }

            edge_X1 = new double[edgeCount];
            edge_Y1 = new double[edgeCount];
            edge_X2 = new double[edgeCount];
            edge_Y2 = new double[edgeCount];
            edge_Ring = new int[edgeCount];

            double x_Min = double.MaxValue;
            double x_Max = double.MinValue;
            double y_Min = double.MaxValue;
            double y_Max = double.MinValue;

            int edge = 0;
            for (int ring = 0; ring < rings.Count; ring++)
            {
                List<Point2D> point2Ds = rings[ring];
                int count = point2Ds.Count;
                for (int i = 0, j = count - 1; i < count; j = i++)
                {
                    Point2D point2D_1 = point2Ds[j];
                    Point2D point2D_2 = point2Ds[i];
                    if (point2D_1 is null || point2D_2 is null)
                    {
                        continue;
                    }

                    edge_X1[edge] = point2D_1.X;
                    edge_Y1[edge] = point2D_1.Y;
                    edge_X2[edge] = point2D_2.X;
                    edge_Y2[edge] = point2D_2.Y;
                    edge_Ring[edge] = ring;
                    edge++;

                    if (point2D_2.X < x_Min)
                    {
                        x_Min = point2D_2.X;
                    }

                    if (point2D_2.X > x_Max)
                    {
                        x_Max = point2D_2.X;
                    }

                    if (point2D_2.Y < y_Min)
                    {
                        y_Min = point2D_2.Y;
                    }

                    if (point2D_2.Y > y_Max)
                    {
                        y_Max = point2D_2.Y;
                    }
                }
            }

            if (edge == 0)
            {
                edge_X1 = [];
                edge_Y1 = [];
                edge_X2 = [];
                edge_Y2 = [];
                edge_Ring = [];
                return;
            }

            if (edge != edgeCount)
            {
                System.Array.Resize(ref edge_X1, edge);
                System.Array.Resize(ref edge_Y1, edge);
                System.Array.Resize(ref edge_X2, edge);
                System.Array.Resize(ref edge_Y2, edge);
                System.Array.Resize(ref edge_Ring, edge);
            }

            this.x_Min = x_Min;
            this.x_Max = x_Max;
            this.y_Min = y_Min;
            this.y_Max = y_Max;

            ringCount = rings.Count;
            parity_Scratch = new bool[ringCount];

            // About four edges per bin on average keeps a query to a handful of edge tests; the bin count is
            // capped so a tiny face does not carry a large empty index.
            int binCount = System.Math.Max(1, System.Math.Min(edge / 4, 65536));
            double height = y_Max - y_Min;
            bin_Height = height > 0.0 ? height / binCount : 1.0;
            if (height <= 0.0)
            {
                binCount = 1;
            }

            int[] counts = new int[binCount];
            for (int i = 0; i < edge; i++)
            {
                BinRange(edge_Y1[i], edge_Y2[i], binCount, out int bin_First, out int bin_Last);
                for (int b = bin_First; b <= bin_Last; b++)
                {
                    counts[b]++;
                }
            }

            bins = new int[binCount][];
            for (int b = 0; b < binCount; b++)
            {
                bins[b] = new int[counts[b]];
                counts[b] = 0;
            }

            for (int i = 0; i < edge; i++)
            {
                BinRange(edge_Y1[i], edge_Y2[i], binCount, out int bin_First, out int bin_Last);
                for (int b = bin_First; b <= bin_Last; b++)
                {
                    bins[b][counts[b]++] = i;
                }
            }
        }

        /// <summary>
        /// Sets the point to classify on the next <see cref="Solve"/> call.
        /// </summary>
        public Point2D? Input
        {
            set
            {
                point2D_Input = value;
            }
        }

        /// <summary>
        /// Gets the relation of the last solved point to the face: <see cref="PointRelation.Undefined"/> before the first successful <see cref="Solve"/> or when the face had no usable ring.
        /// </summary>
        public PointRelation Output
        {
            get
            {
                return output;
            }
        }

        /// <summary>
        /// Gets the number of edges the index holds, over all rings of the face.
        /// </summary>
        public int EdgeCount
        {
            get
            {
                return edge_X1.Length;
            }
        }

        /// <summary>
        /// Classifies <see cref="Input"/> against the face and stores the result in <see cref="Output"/>.
        /// </summary>
        /// <returns>True if the point was classified; false if <see cref="Input"/> is null or the face had no usable ring.</returns>
        public bool Solve()
        {
            output = PointRelation.Undefined;
            if (point2D_Input is not Point2D point2D || edge_X1.Length == 0)
            {
                return false;
            }

            double x = point2D.X;
            double y = point2D.Y;

            // Beyond the tolerance from the bounding box the point can be neither on the boundary nor inside.
            if (x < x_Min - tolerance || x > x_Max + tolerance || y < y_Min - tolerance || y > y_Max + tolerance)
            {
                output = PointRelation.Outside;
                return true;
            }

            for (int i = 0; i < ringCount; i++)
            {
                parity_Scratch[i] = false;
            }

            int bin = (int)((y - y_Min) / bin_Height);
            if (bin < 0)
            {
                bin = 0;
            }
            else if (bin >= bins.Length)
            {
                bin = bins.Length - 1;
            }

            int[] edges = bins[bin];
            for (int k = 0; k < edges.Length; k++)
            {
                int i = edges[k];
                double x1 = edge_X1[i];
                double y1 = edge_Y1[i];
                double x2 = edge_X2[i];
                double y2 = edge_Y2[i];

                // The same half-open crossing rule as Query.Inside, so the two agree on every point.
                if ((y1 < y && y2 >= y) || (y2 < y && y1 >= y))
                {
                    if (x1 + (y - y1) / (y2 - y1) * (x2 - x1) < x)
                    {
                        parity_Scratch[edge_Ring[i]] = !parity_Scratch[edge_Ring[i]];
                    }
                }

                double vector_X = x2 - x1;
                double vector_Y = y2 - y1;
                double length_Squared = vector_X * vector_X + vector_Y * vector_Y;

                double t = 0.0;
                if (length_Squared > 0.0)
                {
                    t = ((x - x1) * vector_X + (y - y1) * vector_Y) / length_Squared;
                    if (t < 0.0)
                    {
                        t = 0.0;
                    }
                    else if (t > 1.0)
                    {
                        t = 1.0;
                    }
                }

                double distance_X = x - (x1 + t * vector_X);
                double distance_Y = y - (y1 + t * vector_Y);
                if (distance_X * distance_X + distance_Y * distance_Y < tolerance_Squared)
                {
                    output = PointRelation.On;
                    return true;
                }
            }

            if (!parity_Scratch[0])
            {
                output = PointRelation.Outside;
                return true;
            }

            for (int i = 1; i < ringCount; i++)
            {
                if (parity_Scratch[i])
                {
                    output = PointRelation.Outside;
                    return true;
                }
            }

            output = PointRelation.Inside;
            return true;
        }

        private void BinRange(double y1, double y2, int binCount, out int bin_First, out int bin_Last)
        {
            double y_Low = (y1 < y2 ? y1 : y2) - tolerance;
            double y_High = (y1 < y2 ? y2 : y1) + tolerance;

            bin_First = (int)System.Math.Floor((y_Low - y_Min) / bin_Height);
            bin_Last = (int)System.Math.Floor((y_High - y_Min) / bin_Height);

            if (bin_First < 0)
            {
                bin_First = 0;
            }

            if (bin_Last >= binCount)
            {
                bin_Last = binCount - 1;
            }

            if (bin_Last < bin_First)
            {
                bin_Last = bin_First;
            }
        }
    }
}
