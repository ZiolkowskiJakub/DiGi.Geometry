using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional grid geometry defined by its total width, total height, and the number of cells along each axis.
    /// </summary>
    public class Grid2D : Geometry2D
    {
        [JsonInclude, JsonPropertyName(nameof(HeightCount))]
        private readonly int heightCount;

        [JsonInclude, JsonPropertyName(nameof(Rectangle2D))]
        private readonly Rectangle2D? rectangle2D;

        [JsonInclude, JsonPropertyName(nameof(WidthCount))]
        private readonly int widthCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid2D"/> class.
        /// </summary>
        /// <param name="origin">The origin point of the grid.</param>
        /// <param name="width">The total width of the grid.</param>
        /// <param name="height">The total height of the grid.</param>
        /// <param name="heightDirection">The direction of the height axis.</param>
        /// <param name="widthCount">The number of cells in the width direction.</param>
        /// <param name="heightCount">The number of cells in the height direction.</param>
        public Grid2D(Point2D? origin, double width, double height, Vector2D? heightDirection, int widthCount, int heightCount)
                : base()
        {
            rectangle2D = new Rectangle2D(origin, width, height, heightDirection);
            this.widthCount = widthCount;
            this.heightCount = heightCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid2D"/> class.
        /// </summary>
        /// <param name="rectangle2D">The bounding rectangle of the grid.</param>
        /// <param name="widthCount">The number of cells in the width direction.</param>
        /// <param name="heightCount">The number of cells in the height direction.</param>
        public Grid2D(Rectangle2D? rectangle2D, int widthCount, int heightCount)
                : base()
        {
            this.rectangle2D = DiGi.Core.Query.Clone(rectangle2D);
            this.widthCount = widthCount;
            this.heightCount = heightCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing grid data.</param>
        public Grid2D(JsonObject jsonObject)
                : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid2D"/> class by cloning an existing grid.
        /// </summary>
        /// <param name="grid2D">The source grid to clone.</param>
        public Grid2D(Grid2D grid2D)
                : base(grid2D)
        {
            if (grid2D is not null)
            {
                rectangle2D = grid2D.Rectangle2D;
                widthCount = grid2D.widthCount;
                heightCount = grid2D.heightCount;
            }
        }

        /// <summary>
        /// Gets the number of cells in the height direction.
        /// </summary>
        [JsonIgnore]
        public int HeightCount
        {
            get
            {
                return heightCount;
            }
        }

        /// <summary>
        /// Gets the height of a single cell in the grid.
        /// </summary>
        [JsonIgnore]
        public double HeightFactor
        {
            get
            {
                if (rectangle2D is null || heightCount == 0)
                {
                    return double.NaN;
                }

                return rectangle2D.Height / heightCount;
            }
        }

        /// <summary>
        /// Gets the bounding rectangle of the grid.
        /// </summary>
        [JsonIgnore]
        public Rectangle2D? Rectangle2D
        {
            get
            {
                return DiGi.Core.Query.Clone(rectangle2D);
            }
        }

        /// <summary>
        /// Gets the number of cells in the width direction.
        /// </summary>
        [JsonIgnore]
        public int WidthCount
        {
            get
            {
                return widthCount;
            }
        }

        /// <summary>
        /// Gets the width of a single cell in the grid.
        /// </summary>
        [JsonIgnore]
        public double WidthFactor
        {
            get
            {
                if (rectangle2D is null || widthCount == 0)
                {
                    return double.NaN;
                }

                return rectangle2D.Width / widthCount;
            }
        }

        /// <summary>
        /// Gets the rectangle at the specified grid indices.
        /// </summary>
        /// <param name="index_width">The index along the width axis.</param>
        /// <param name="index_height">The index along the height axis.</param>
        /// <returns>The <see cref="Rectangle2D"/> at the specified position, or null if it cannot be determined.</returns>
        [JsonIgnore]
        public Rectangle2D? this[int index_width, int index_height]
        {
            get
            {
                return GetRectangle(index_width, index_height);
            }
        }

        /// <summary>
        /// Gets the rectangle at the specified grid indices.
        /// </summary>
        /// <param name="index_width">The index along the width axis.</param>
        /// <param name="index_height">The index along the height axis.</param>
        /// <returns>The <see cref="Rectangle2D"/> at the specified position, or null if it cannot be determined.</returns>
        public Rectangle2D? GetRectangle(int index_width, int index_height)
        {
            if (rectangle2D is null)
            {
                return null;
            }

            double widthFactor = WidthFactor;
            if (double.IsNaN(widthFactor))
            {
                return null;
            }

            Vector2D? widthDirection = rectangle2D.WidthDirection;
            if (widthDirection is null)
            {
                return null;
            }

            Vector2D? widthVector = widthDirection * WidthFactor;
            if (widthVector is null)
            {
                return null;
            }

            double heightFactor = HeightFactor;
            if (double.IsNaN(heightFactor))
            {
                return null;
            }

            Vector2D? heightDirection = rectangle2D.HeightDirection;
            if (heightDirection is null)
            {
                return null;
            }

            Vector2D? heightVector = heightDirection * heightFactor;
            if (heightVector is null)
            {
                return null;
            }

            Point2D? origin = rectangle2D.Origin;
            if (origin is null)
            {
                return null;
            }

            origin.Move((heightDirection * index_height) + (widthDirection * index_width));

            return new Rectangle2D(origin, widthFactor, heightFactor, heightDirection);
        }

        /// <summary>
        /// Gets all rectangles in the grid.
        /// </summary>
        /// <returns>A list of all cell rectangles, or null if the grid is invalid.</returns>
        public List<Rectangle2D>? GetRectangles()
        {
            if (rectangle2D is null || widthCount == 0 || heightCount == 0)
            {
                return null;
            }

            List<Rectangle2D> result = [];
            for (int i = 0; i < widthCount; i++)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    if (this[i, j] is Rectangle2D rectangle2D)
                    {
                        result.Add(rectangle2D);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Moves the grid by the specified vector.
        /// </summary>
        /// <param name="vector2D">The movement vector.</param>
        /// <returns>True if the move was successful; otherwise, false.</returns>
        public override bool Move(Vector2D? vector2D)
        {
            return rectangle2D is not null && rectangle2D.Move(vector2D);
        }

        /// <summary>
        /// Transforms the grid using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public override bool Transform(ITransform2D? transform)
        {
            return rectangle2D is not null && rectangle2D.Transform(transform);
        }
    }
}
