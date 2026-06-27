using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for 3D geometries that can be segmented.
    /// </summary>
    public abstract class Segmentable3D : Geometry3D, ISegmentable3D
    {
        [JsonInclude, JsonPropertyName("Points")]
        protected List<Point3D> points = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance. This value can be null.</param>
        public Segmentable3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable3D"/> class.
        /// </summary>
        public Segmentable3D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable3D"/> class using another <see cref="Segmentable3D"/> instance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="Segmentable3D"/> instance to copy from.</param>
        public Segmentable3D(Segmentable3D? segmentable3D)
            : base(segmentable3D)
        {
            points = segmentable3D?.points.Clone()?.FilterNulls() ?? [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentable3D"/> class.
        /// </summary>
        /// <param name="point3Ds">An optional collection of <see cref="Point3D"/> objects used to initialize the points.</param>
        public Segmentable3D(IEnumerable<Point3D>? point3Ds)
        {
            points = point3Ds?.Clone()?.FilterNulls() ?? [];
        }

        /// <summary>
        /// Gets the total length of the object calculated from its 3D segments.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> representing the total length, or <see cref="double.NaN"/> if no segments are available.
        /// </value>
        [JsonIgnore]
        public double Length
        {
            get
            {
                List<Segment3D>? segment3Ds = GetSegments();
                if (segment3Ds == null)
                {
                    return double.NaN;
                }

                double result = 0;
                for (int i = 0; i < segment3Ds.Count; i++)
                {
                    Segment3D segment3D = segment3Ds[i];
                    if (segment3D is null)
                    {
                        continue;
                    }

                    result += segment3D.Length;
                }

                return result;
            }
        }

        /// <summary>
        /// Moves all associated points by the specified Vector3D vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? vector used for translation.</param>
        /// <returns>A bool value indicating whether the move operation was successfully performed.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D is null || points is null || points.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < points.Count; i++)
            {
                points[i].Move(vector3D);
            }

            return true;
        }

        /// <summary>
        /// Retrieves the list of <see cref="Segment3D"/> objects that define the geometry of the entity.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> containing <see cref="Segment3D"/> instances, or <see langword="null"/> if no segments are available.</returns>
        public abstract List<Segment3D>? GetSegments();

        /// <summary>
        /// Retrieves a filtered clone of the point collection.
        /// </summary>
        /// <returns>A <see cref="List{Point3D}"/> containing the points if they exist; otherwise, null.</returns>
        public List<Point3D>? GetPoints()
        {
            return points?.Clone()?.FilterNulls();
        }

        /// <summary>
        /// Calculates the distance from the specified <see cref="Point3D"/> to the closest point in the collection of segments.
        /// </summary>
        /// <param name="point">The nullable <see cref="Point3D"/> used to calculate the distance.</param>
        /// <returns>A <see cref="double"/> representing the shortest distance, or <see cref="double.NaN"/> if the provided point is null or no points exist in the collection.</returns>
        public double Distance(Point3D? point)
        {
            if (point == null || points == null || points.Count == 0)
            {
                return double.NaN;
            }

            if (points.Count == 1)
            {
                return point.Distance(points[0]);
            }

            bool isClosed = this is Polyloop;
            double double_MinDistanceSq = double.MaxValue;
            int limit = isClosed ? points.Count : points.Count - 1;

            for (int int_I = 0; int_I < limit; int_I++)
            {
                Point3D point_Start = points[int_I];
                Point3D point_End = points[(int_I + 1) % points.Count];
                if (point_Start == null || point_End == null)
                {
                    continue;
                }

                double double_Cx = point_End.X - point_Start.X;
                double double_Cy = point_End.Y - point_Start.Y;
                double double_Cz = point_End.Z - point_Start.Z;

                double double_Ax = point.X - point_Start.X;
                double double_Ay = point.Y - point_Start.Y;
                double double_Az = point.Z - point_Start.Z;

                double double_Dot = double_Ax * double_Cx + double_Ay * double_Cy + double_Az * double_Cz;
                double double_SquareLength = double_Cx * double_Cx + double_Cy * double_Cy + double_Cz * double_Cz;

                double double_Parameter = -1;
                if (double_SquareLength != 0.0)
                {
                    double_Parameter = double_Dot / double_SquareLength;
                }

                double double_ClosestX, double_ClosestY, double_ClosestZ;

                if (double_Parameter < 0.0)
                {
                    double_ClosestX = point_Start.X;
                    double_ClosestY = point_Start.Y;
                    double_ClosestZ = point_Start.Z;
                }
                else if (double_Parameter > 1.0)
                {
                    double_ClosestX = point_End.X;
                    double_ClosestY = point_End.Y;
                    double_ClosestZ = point_End.Z;
                }
                else
                {
                    double_ClosestX = point_Start.X + double_Parameter * double_Cx;
                    double_ClosestY = point_Start.Y + double_Parameter * double_Cy;
                    double_ClosestZ = point_Start.Z + double_Parameter * double_Cz;
                }

                double double_Dx = point.X - double_ClosestX;
                double double_Dy = point.Y - double_ClosestY;
                double double_Dz = point.Z - double_ClosestZ;
                double double_DistanceSq = double_Dx * double_Dx + double_Dy * double_Dy + double_Dz * double_Dz;

                if (double_DistanceSq < double_MinDistanceSq)
                {
                    double_MinDistanceSq = double_DistanceSq;
                }
            }

            return System.Math.Sqrt(double_MinDistanceSq);
        }

        /// <summary>
        /// Calculates the closest <see cref="Point3D"/> on the geometry to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point">The <see cref="Point3D"/> used as the reference for finding the closest point.</param>
        /// <returns>The closest <see cref="Point3D"/> found, or <see langword="null"/> if the provided <see cref="Point3D"/> is <see langword="null"/> or no points are available.</returns>
        public Point3D? ClosestPoint(Point3D? point)
        {
            if (point == null || points == null || points.Count == 0)
            {
                return null;
            }

            if (points.Count == 1)
            {
                return new Point3D(points[0]);
            }

            bool isClosed = this is Polyloop;
            double double_MinDistanceSq = double.MaxValue;
            Point3D? point3D_BestClosest = null;
            int limit = isClosed ? points.Count : points.Count - 1;

            for (int int_I = 0; int_I < limit; int_I++)
            {
                Point3D point_Start = points[int_I];
                Point3D point_End = points[(int_I + 1) % points.Count];
                if (point_Start == null || point_End == null)
                {
                    continue;
                }

                double double_Cx = point_End.X - point_Start.X;
                double double_Cy = point_End.Y - point_Start.Y;
                double double_Cz = point_End.Z - point_Start.Z;

                double double_Ax = point.X - point_Start.X;
                double double_Ay = point.Y - point_Start.Y;
                double double_Az = point.Z - point_Start.Z;

                double double_Dot = double_Ax * double_Cx + double_Ay * double_Cy + double_Az * double_Cz;
                double double_SquareLength = double_Cx * double_Cx + double_Cy * double_Cy + double_Cz * double_Cz;

                double double_Parameter = -1;
                if (double_SquareLength != 0.0)
                {
                    double_Parameter = double_Dot / double_SquareLength;
                }

                double double_ClosestX, double_ClosestY, double_ClosestZ;

                if (double_Parameter < 0.0)
                {
                    double_ClosestX = point_Start.X;
                    double_ClosestY = point_Start.Y;
                    double_ClosestZ = point_Start.Z;
                }
                else if (double_Parameter > 1.0)
                {
                    double_ClosestX = point_End.X;
                    double_ClosestY = point_End.Y;
                    double_ClosestZ = point_End.Z;
                }
                else
                {
                    double_ClosestX = point_Start.X + double_Parameter * double_Cx;
                    double_ClosestY = point_Start.Y + double_Parameter * double_Cy;
                    double_ClosestZ = point_Start.Z + double_Parameter * double_Cz;
                }

                double double_Dx = point.X - double_ClosestX;
                double double_Dy = point.Y - double_ClosestY;
                double double_Dz = point.Z - double_ClosestZ;
                double double_DistanceSq = double_Dx * double_Dx + double_Dy * double_Dy + double_Dz * double_Dz;

                if (double_DistanceSq < double_MinDistanceSq)
                {
                    double_MinDistanceSq = double_DistanceSq;
                    if (point3D_BestClosest == null)
                    {
                        point3D_BestClosest = new Point3D(double_ClosestX, double_ClosestY, double_ClosestZ);
                    }
                    else
                    {
                        point3D_BestClosest.X = double_ClosestX;
                        point3D_BestClosest.Y = double_ClosestY;
                        point3D_BestClosest.Z = double_ClosestZ;
                    }
                }
            }

            return point3D_BestClosest;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> lies on the object within a given tolerance.
        /// </summary>
        /// <param name="point">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value specifying the tolerance for the operation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on the object.</returns>
        public bool On(Point3D? point, double tolerance = 1E-06)
        {
            return Query.On(this, point, tolerance);
        }

        /// <summary>
        /// Calculates the bounding box for the current set of points.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if there are no points available.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (points == null || points.Count == 0)
            {
                return null;
            }

            return new BoundingBox3D(points);
        }

        /// <summary>
        /// Reverses the order of the points.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful.</returns>
        public bool Inverse()
        {
            if (points is null)
            {
                return false;
            }

            points.Reverse();
            return true;
        }
    }
}