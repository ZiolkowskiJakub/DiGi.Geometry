using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional polyline consisting of a sequence of <see cref="Point3D"/> points.
    /// </summary>
    public class Polyline3D : Geometry3D, ISegmentable3D
    {
        [JsonInclude, JsonPropertyName("Points")]
        protected List<Point3D> points = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the <see cref="Polyline3D"/> instance.</param>
        public Polyline3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline3D"/> class.
        /// </summary>
        public Polyline3D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline3D"/> class by copying another <see cref="Polyline3D"/> instance.
        /// </summary>
        /// <param name="polyline3D">The source <see cref="Polyline3D"/> object to copy from.</param>
        public Polyline3D(Polyline3D? polyline3D)
            : base(polyline3D)
        {
            if (polyline3D != null)
            {
                points = DiGi.Core.Query.Clone(polyline3D.points)?.FilterNulls() ?? [];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline3D"/> class using the specified collection of <see cref="Point3D"/> points.
        /// </summary>
        /// <param name="point3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects that define the polyline.</param>
        public Polyline3D(IEnumerable<Point3D>? point3Ds)
            : base()
        {
            points = DiGi.Core.Query.Clone(point3Ds)?.FilterNulls() ?? [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polyline3D"/> class.
        /// </summary>
        /// <param name="point3Ds">An <see cref="IEnumerable{Point3D}"/> containing the points that define the polyline.</param>
        /// <param name="close">A <see cref="bool"/> value indicating whether the polyline should be closed.</param>
        public Polyline3D(IEnumerable<Point3D>? point3Ds, bool close)
        {
            points = DiGi.Core.Query.Clone(point3Ds)?.FilterNulls() ?? [];

            if (close)
            {
                Close();
            }
            else
            {
                Open();
            }
        }

        /// <summary>
        /// Gets the total length of all 3D segments.
        /// </summary>
        /// <value>The combined length as a <see cref="double"/>, or <see cref="double.NaN"/> if the segment list is null.</value>
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
                    if (segment3D == null)
                    {
                        continue;
                    }

                    result += segment3D.Length;
                }

                return result;
            }
        }

        /// <summary>
        /// Creates a copy of the current <see cref="Polyline3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance, or <c>null</c>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Polyline3D(this);
        }

        /// <summary>
        /// Closes the path by adding a copy of the first <see cref="Point3D"/> to the end of the points collection,
        /// provided that the path is not already closed and contains at least three points.
        /// </summary>
        public void Close()
        {
            if (IsClosed())
            {
                return;
            }

            if (points == null || points.Count < 3)
            {
                return;
            }

            points.Add(new Point3D(points[0]));
        }

        /// <summary>
        /// Finds the <see cref="Point3D"/> closest to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> used as the reference point for the search.</param>
        /// <returns>The <see cref="Point3D"/> nearest to the provided point, or <c>null</c> if no closest point is found.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D == null || points == null || points.Count == 0)
            {
                return null;
            }

            if (points.Count == 1)
            {
                return new Point3D(points[0]);
            }

            double double_MinDistanceSq = double.MaxValue;
            Point3D? point3D_BestClosest = null;

            for (int int_I = 0; int_I < points.Count - 1; int_I++)
            {
                Point3D point_Start = points[int_I];
                Point3D point_End = points[int_I + 1];
                if (point_Start == null || point_End == null)
                {
                    continue;
                }

                double double_Cx = point_End.X - point_Start.X;
                double double_Cy = point_End.Y - point_Start.Y;
                double double_Cz = point_End.Z - point_Start.Z;

                double double_Ax = point3D.X - point_Start.X;
                double double_Ay = point3D.Y - point_Start.Y;
                double double_Az = point3D.Z - point_Start.Z;

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

                double double_Dx = point3D.X - double_ClosestX;
                double double_Dy = point3D.Y - double_ClosestY;
                double double_Dz = point3D.Z - double_ClosestZ;
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

        public double Distance(Point3D? point3D)
        {
            if (point3D == null || points == null || points.Count == 0)
            {
                return double.NaN;
            }

            if (points.Count == 1)
            {
                return point3D.Distance(points[0]);
            }

            double double_MinDistanceSq = double.MaxValue;

            for (int int_I = 0; int_I < points.Count - 1; int_I++)
            {
                Point3D point_Start = points[int_I];
                Point3D point_End = points[int_I + 1];
                if (point_Start == null || point_End == null)
                {
                    continue;
                }

                double double_Cx = point_End.X - point_Start.X;
                double double_Cy = point_End.Y - point_Start.Y;
                double double_Cz = point_End.Z - point_Start.Z;

                double double_Ax = point3D.X - point_Start.X;
                double double_Ay = point3D.Y - point_Start.Y;
                double double_Az = point3D.Z - point_Start.Z;

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

                double double_Dx = point3D.X - double_ClosestX;
                double double_Dy = point3D.Y - double_ClosestY;
                double double_Dz = point3D.Z - double_ClosestZ;
                double double_DistanceSq = double_Dx * double_Dx + double_Dy * double_Dy + double_Dz * double_Dz;

                if (double_DistanceSq < double_MinDistanceSq)
                {
                    double_MinDistanceSq = double_DistanceSq;
                }
            }

            return System.Math.Sqrt(double_MinDistanceSq);
        }

        /// <summary>
        /// Calculates the bounding box for the collection of points.
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
        /// Retrieves a list of <see cref="Point3D"/> objects.
        /// </summary>
        /// <returns>A <c>List&lt;Point3D&gt;</c> containing the points, or <see langword="null"/> if no points are available.</returns>
        public List<Point3D>? GetPoints()
        {
            return DiGi.Core.Query.Clone(points)?.FilterNulls();
        }

        /// <summary>
        /// Retrieves the list of 3D segments generated from the current points.
        /// </summary>
        /// <returns>A <see cref="List{Segment3D}"/> containing the segments, or null if the operation fails.</returns>
        public List<Segment3D>? GetSegments()
        {
            return Create.Segment3Ds(points, false);
        }

        /// <summary>
        /// Reverses the order of the points in the collection.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful; returns <c>true</c> if there were at least two points to reverse, otherwise <c>false</c>.</returns>
        public bool Inverse()
        {
            if (points.Count < 2)
            {
                return false;
            }

            points.Reverse();
            return true;
        }

        /// <summary>
        /// Determines whether the path is closed by checking if the first and last points are identical.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating true if the path has at least three points and the start point equals the end point; otherwise, false.</returns>
        public bool IsClosed()
        {
            if (points == null || points.Count < 3)
            {
                return false;
            }

            return points[0].Equals(points[points.Count - 1]);
        }

        /// <summary>
        /// Moves the object by the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> used to move the points.</param>
        /// <returns>True if the movement was successful; otherwise, false.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (points == null || points.Count == 0)
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
        /// Determines whether the specified <see cref="Point3D"/> is on the entity within the given tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on the entity.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Query.On(this, point3D, tolerance);
        }

        /// <summary>
        /// Opens the path by removing the closing point if the path is currently closed and contains at least three points.
        /// </summary>
        public void Open()
        {
            if (!IsClosed())
            {
                return;
            }

            if (points == null || points.Count < 3)
            {
                return;
            }

            points.RemoveAt(points.Count - 1);
        }
    }
}