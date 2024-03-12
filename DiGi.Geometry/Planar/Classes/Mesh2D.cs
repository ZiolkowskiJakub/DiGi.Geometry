using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Mesh2D : Mesh<Point2D>, IGeometry2D, IBoundable2D, ICollectable2D
    {
        public Mesh2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Mesh2D(Mesh2D mesh2D)
            :base(mesh2D)
        {

        }

        public Mesh2D(IEnumerable<Point2D> points, IEnumerable<int[]> indexes)
            : base(points, indexes)
        {

        }

        public override ISerializableObject Clone()
        {
            return new Mesh2D(this);
        }

        public BoundingBox2D GetBoundingBox()
        {
            if(points == null)
            {
                return null;
            }

            return new BoundingBox2D(points);
        }

        public Triangle2D GetTriangle(int index)
        {
            if (points == null || indexes == null)
            {
                return null;
            }

            if (index < 0 || index >= indexes.Count)
            {
                return null;
            }

            int index_1 = indexes[index][0];
            if (index_1 < 0 || index_1 >= points.Count)
            {
                return null;
            }

            int index_2 = indexes[index][1];
            if (index_2 < 0 || index_2 >= points.Count)
            {
                return null;
            }

            int index_3 = indexes[index][2];
            if (index_3 < 0 || index_3 >= points.Count)
            {
                return null;
            }

            return new Triangle2D(points[index_1], points[index_2], points[index_3]);
        }

        public List<Triangle2D> GetTriangles()
        {
            if (points == null || indexes == null)
            {
                return null;
            }

            int count = TrianglesCount;
            if (count == -1)
            {
                return null;
            }

            List<Triangle2D> result = new List<Triangle2D>();
            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < TrianglesCount; i++)
            {
                result.Add(GetTriangle(i));
            }

            return result;
        }

        public bool Move(Vector2D vector2D)
        {
            if(points == null || vector2D == null)
            {
                return false;
            }

            for(int i=0; i < points.Count; i++)
            {
                points[i]?.Move(vector2D);
            }

            return true;
        }

        public bool Transform(ITransform2D transform)
        {
            if(transform == null || points == null)
            {
                return false;
            }

            for (int i = 0; i < points.Count; i++)
            {
                points[i]?.Transform(transform);
            }

            return true;
        }
    }
}
