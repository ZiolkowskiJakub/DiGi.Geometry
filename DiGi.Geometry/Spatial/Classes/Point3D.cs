using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a point in three-dimensional space.
    /// </summary>
    public class Point3D : Coordinate3D, IMovable3D, IPoint<Point3D>, ITransformable3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the point.</param>
        public Point3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class with the specified double x, double y, and double z coordinates.
        /// </summary>
        /// <param name="x">The double value for the X coordinate.</param>
        /// <param name="y">The double value for the Y coordinate.</param>
        /// <param name="z">The double value for the Z coordinate.</param>
        public Point3D(double x, double y, double z)
            : base(x, y, z)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class using an array of <see cref="double"/>.
        /// </summary>
        /// <param name="values">An array of <see cref="double"/> containing the coordinate values.</param>
        public Point3D(double[]? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class using the values from an existing <see cref="Point3D"/> instance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> instance to copy values from.</param>
        public Point3D(Point3D? point3D)
            : base(point3D)
        {
        }

        /// <summary>
        /// Implicitly converts a tuple of three <see cref="double"/> values representing X, Y, and Z coordinates to a <see cref="Point3D"/>.
        /// </summary>
        /// <param name="object">The tuple containing the X, Y, and Z coordinate values.</param>
        /// <returns>A new <see cref="Point3D"/> instance created from the provided coordinates.</returns>
        public static implicit operator Point3D?((double x, double y, double z) @object)
        {
            return new Point3D(@object.x, @object.y, @object.z);
        }

        /// <summary>
        /// Creates a copy of the current instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Point3D(values);
        }

        /// <summary>
        /// Calculates the distance between this point and a specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to calculate the distance to.</param>
        /// <returns>The distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the provided <see cref="Point3D"/> is null.</returns>
        public double Distance(Point3D? point3D)
        {
            if (point3D == null)
            {
                return double.NaN;
            }

            double dx = values[0] - point3D.values[0];
            double dy = values[1] - point3D.values[1];
            double dz = values[2] - point3D.values[2];
            return System.Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        /// <summary>
        /// Returns a new <see cref="Point3D"/> instance containing the absolute values of the current point's coordinates.
        /// </summary>
        /// <returns>A new <see cref="Point3D"/> object with absolute coordinate values.</returns>
        public Point3D GetAbs()
        {
            Point3D result = new(this);

            result.Abs();

            return result;
        }

        /// <summary>
        /// Returns a new <see cref="Point3D"/> that is the result of moving this point by the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to move the point by.</param>
        /// <returns>A new <see cref="Point3D"/> representing the moved position, or <c>null</c> if the provided <see cref="Vector3D"/> is <c>null</c>.</returns>
        public Point3D? GetMoved(Vector3D? vector3D)
        {
            if (vector3D is null)
            {
                return null;
            }

            Point3D result = new(this);
            result.Move(vector3D);

            return result;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is within a given distance, accounting for an optional tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="distance">The maximum allowed distance as a <see cref="double"/>.</param>
        /// <param name="tolerance">The tolerance value as a <see cref="double"/> to be added to the distance threshold.</param>
        /// <returns>A <see cref="bool"/> indicating whether the point is within the specified distance and tolerance; returns <c>false</c> if <paramref name="point3D"/> is null.</returns>
        public bool InDistance(Point3D? point3D, double distance, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            double dx = values[0] - point3D.values[0];
            double maxDist = distance + tolerance;
            if (System.Math.Abs(dx) > maxDist)
            {
                return false;
            }

            double dy = values[1] - point3D.values[1];
            if (System.Math.Abs(dy) > maxDist)
            {
                return false;
            }

            double dz = values[2] - point3D.values[2];
            if (System.Math.Abs(dz) > maxDist)
            {
                return false;
            }

            double threshold = distance - tolerance;
            if (threshold < 0)
            {
                return false;
            }

            return (dx * dx + dy * dy + dz * dz) < (threshold * threshold);
        }

        /// <summary>
        /// Calculates the midpoint between this point and another <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The other <see cref="Point3D"/> to calculate the midpoint with.</param>
        /// <returns>A <see cref="Point3D"/> representing the midpoint, or <see langword="null"/> if the provided <see cref="Point3D"/> is <see langword="null"/>.</returns>
        public Point3D? Mid(Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new Point3D((point3D.values[0] + values[0]) * 0.5, (point3D.values[1] + values[1]) * 0.5, (point3D.values[2] + values[2]) * 0.5);
        }

        /// <summary>Subtracts a <see cref="Vector3D"/> from a <see cref="Point3D"/> to produce a new point.</summary>
        /// <param name="point3D">The starting <see cref="Point3D"/>.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> to subtract from the point.</param>
        /// <returns>A new <see cref="Point3D"/> resulting from the subtraction, or <see langword="null"/> if either input is <see langword="null"/>.</returns>
        public static Point3D? operator -(Point3D? point3D, Vector3D? vector3D)
        {
            if (point3D is null || vector3D is null)
            {
                return null;
            }

            return new Point3D(point3D.values[0] - vector3D[0], point3D.values[1] - vector3D[1], point3D.values[2] - vector3D[2]);
        }

        /// <summary>Subtracts one <see cref="Point3D"/> from another to produce a <see cref="Vector3D"/>.</summary>
        /// <param name="point3D_1">The first <see cref="Point3D"/>.</param>
        /// <param name="point3D_2">The second <see cref="Point3D"/>.</param>
        /// <returns>A new <see cref="Vector3D"/> resulting from the subtraction, or <see langword="null"/> if either input is <see langword="null"/>.</returns>
        public static Vector3D? operator -(Point3D? point3D_1, Point3D? point3D_2)
        {
            if (point3D_1 is null || point3D_2 is null)
            {
                return null;
            }

            return new Vector3D(point3D_1.values[0] - point3D_2[0], point3D_1.values[1] - point3D_2[1], point3D_1.values[2] - point3D_2[2]);
        }

        /// <summary>Adds a <see cref="Vector3D"/> to a <see cref="Point3D"/> to produce a new point.</summary>
        /// <param name="point3D">The starting <see cref="Point3D"/>.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> to add to the point.</param>
        /// <returns>A new <see cref="Point3D"/> resulting from the addition, or <see langword="null"/> if either input is <see langword="null"/>.</returns>
        public static Point3D? operator +(Point3D? point3D, Vector3D? vector3D)
        {
            if (point3D is null || vector3D is null)
            {
                return null;
            }

            return new Point3D(point3D.values[0] + vector3D[0], point3D.values[1] + vector3D[1], point3D.values[2] + vector3D[2]);
        }
    }
}
