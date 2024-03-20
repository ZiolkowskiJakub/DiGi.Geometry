using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class BoundedGeometry2D<T> : SerializableObject, IBoundedGeometry<T, BoundingBox2D> where T: IBoundable2D
    { 
        private BoundingBox2D boundingBox;
        private T boundable;

        public BoundedGeometry2D(T boundable)
            : base()
        {
            Boundable = boundable;
        }

        public BoundedGeometry2D(JsonObject jsonObject)
            :base(jsonObject)
        {
            
        }

        public BoundedGeometry2D(BoundedGeometry2D<T> boundedGeometry)
            : base()
        {
            if(boundedGeometry != null)
            {
                boundable = DiGi.Core.Query.Clone(boundedGeometry.boundable);
                boundingBox = DiGi.Core.Query.Clone(boundedGeometry.boundingBox);
            }
        }

        public ISerializableObject Clone()
        {
            return new BoundedGeometry2D<T>(boundable);
        }

        public BoundingBox2D GetBoundingBox()
        {
            return new BoundingBox2D(boundingBox);
        }

        public bool Move(Vector2D vector2D)
        {
            if(boundable == null)
            {
                return false;
            }

            bool result = boundable.Move(vector2D);
            if(result)
            {
                boundingBox.Move(vector2D);
            }

            return true;
        }

        public bool Transform(ITransform2D transform)
        {
            if (boundable == null)
            {
                return false;
            }

            bool result = boundable.Transform(transform);
            if (result)
            {
                boundingBox.Transform(transform);
            }

            return true;
        }

        public T Boundable
        {
            get
            {
                return DiGi.Core.Query.Clone<T>(boundable);
            }

            set
            {
                boundable = DiGi.Core.Query.Clone<T>(value);
                if (boundable != null)
                {
                    boundingBox = boundable?.GetBoundingBox();
                }
            }
        }
    }
}
