using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional coordinate system defined by an origin <see cref="Point2D"/> and basis vectors <see cref="Vector2D"/>.
    /// </summary>
    public class CoordinateSystem2D : SerializableObject, IMovable2D, ITransformable2D
    {
        [JsonInclude, JsonPropertyName("Origin")]
        private readonly Point2D? origin;

        [JsonInclude, JsonPropertyName("AxisX")]
        private Vector2D? axisX;

        [JsonInclude, JsonPropertyName("AxisY")]
        private Vector2D? axisY;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem2D"/> class with a specified origin and world axes.
        /// </summary>
        /// <param name="origin">The origin point of the coordinate system.</param>
        public CoordinateSystem2D(Point2D? origin)
        {
            this.origin = origin == null ? null : new Point2D(origin);
            axisX = Constants.Vector2D.WorldX;
            axisY = Constants.Vector2D.WorldY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing coordinate system data.</param>
        public CoordinateSystem2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem2D"/> class with default origin and world axes.
        /// </summary>
        public CoordinateSystem2D()
        {
            origin = Constants.Point2D.Zero;
            axisX = Constants.Vector2D.WorldX;
            axisY = Constants.Vector2D.WorldY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem2D"/> class by cloning an existing coordinate system.
        /// </summary>
        /// <param name="coordinateSystem2D">The source coordinate system to clone.</param>
        public CoordinateSystem2D(CoordinateSystem2D? coordinateSystem2D)
        {
            if (coordinateSystem2D != null)
            {
                origin = coordinateSystem2D.Origin;
                axisX = coordinateSystem2D.AxisX;
                axisY = coordinateSystem2D.AxisY;
            }
        }

        internal CoordinateSystem2D(Point2D? origin, Vector2D? axisX, Vector2D? axisY)
        {
            this.origin = origin is null ? null : new Point2D(origin);
            this.axisX = axisX is null ? null : new Vector2D(axisX);
            this.axisY = axisY is null ? null : new Vector2D(axisY);
        }

        /// <summary>
        /// Gets the X-axis vector of the coordinate system.
        /// </summary>
        public Vector2D? AxisX
        {
            get
            {
                return axisX is null ? null : new Vector2D(axisX);
            }
        }

        /// <summary>
        /// Gets the Y-axis vector of the coordinate system.
        /// </summary>
        public Vector2D? AxisY
        {
            get
            {
                return axisY is null ? null : new Vector2D(axisY);
            }
        }

        /// <summary>
        /// Gets the origin point of the coordinate system.
        /// </summary>
        public Point2D? Origin
        {
            get
            {
                return origin is null ? null : new Point2D(origin);
            }
        }

        /// <summary>
        /// Creates a clone of the current coordinate system.
        /// </summary>
        /// <returns>A cloned instance of the coordinate system.</returns>
        public override ISerializableObject? Clone()
        {
            return new CoordinateSystem2D(this);
        }

        /// <summary>
        /// Gets the vector corresponding to the specified axis.
        /// </summary>
        /// <param name="axis">The axis to retrieve.</param>
        /// <returns>The vector of the requested axis.</returns>
        public Vector2D? GetAxis(Enums.PlanarAxis axis)
        {
            return axis switch
            {
                Enums.PlanarAxis.X => AxisX,

                Enums.PlanarAxis.Y => AxisY,

                Enums.PlanarAxis.Undefined => null,

                _ => null,
            };
        }

        /// <summary>
        /// Moves the coordinate system origin by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public bool Move(Vector2D? vector2D)
        {
            if (origin == null || vector2D is null)
            {
                return false;
            }

            origin.Move(vector2D);
            return true;
        }

        /// <summary>
        /// Transforms the coordinate system using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public bool Transform(ITransform2D? transform)
        {
            if (transform == null || origin == null || axisX is null || axisY is null)
            {
                return false;
            }

            Point2D point2D_X = new(origin);
            point2D_X.Move(axisX);

            Point2D point2D_Y = new(origin);
            point2D_Y.Move(axisY);

            origin.Transform(transform);

            point2D_X.Transform(transform);
            axisX = new(origin, point2D_X);
            axisX.Normalize();

            point2D_Y.Transform(transform);
            axisY = new(origin, point2D_Y);
            axisY.Normalize();

            return true;
        }
    }
}