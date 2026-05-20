using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Grid2D : Geometry2D
    {
        [JsonInclude, JsonPropertyName(nameof(HeightCount))]
        private readonly int heightCount;

        [JsonInclude, JsonPropertyName(nameof(Rectangle2D))]
        private readonly Rectangle2D? rectangle2D;

        [JsonInclude, JsonPropertyName(nameof(WidthCount))]
        private readonly int widthCount;
        
        public Grid2D(Point2D? origin, double width, double height, Vector2D? heightDirection, int widthCount, int heightCount)
            :base()
        {
            rectangle2D = new Rectangle2D(origin, width, height, heightDirection);
            this.widthCount = widthCount;
            this.heightCount = heightCount;
        }

        public Grid2D(Rectangle2D? rectangle2D, int widthCount, int heightCount)
            :base()
        {
            this.rectangle2D = DiGi.Core.Query.Clone(rectangle2D);
            this.widthCount = widthCount;
            this.heightCount = heightCount;
        }

        public Grid2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Grid2D(Grid2D grid2D)
            : base(grid2D)
        {
            if(grid2D is not null)
            {
                rectangle2D = grid2D.Rectangle2D;
                widthCount = grid2D.widthCount;
                heightCount = grid2D.heightCount;
            }
        }

        [JsonIgnore]
        public int HeightCount
        {
            get
            {
                return heightCount;
            }
        }

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

        [JsonIgnore]
        public Rectangle2D? Rectangle2D
        {
            get
            {
                return DiGi.Core.Query.Clone(rectangle2D);
            }
        }

        [JsonIgnore]
        public int WidthCount
        {
            get
            {
                return widthCount;
            }
        }

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

        [JsonIgnore]
        public Rectangle2D? this[int index_width, int index_height]
        {
            get
            {
                return GetRectangle(index_width, index_height);
            }
        }

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

            origin.Move((heightDirection * (index_height + 1)) + (widthDirection * (index_width + 1)));

            return new Rectangle2D(origin, widthFactor, heightFactor, heightDirection);
        }

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

        public override bool Move(Vector2D? vector2D)
        {
            return rectangle2D is null ? false : rectangle2D.Move(vector2D);
        }

        public override bool Transform(ITransform2D? transform)
        {
            return rectangle2D is null ? false : rectangle2D.Transform(transform);
        }
    }
}
