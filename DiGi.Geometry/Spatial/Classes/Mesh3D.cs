using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Mesh3D : Mesh<Point3D>, IGeometry3D, IBoundable3D, ICollectable3D
    {
        public Mesh3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Mesh3D(Mesh3D? mesh3D)
            : base(mesh3D)
        {
        }

        public Mesh3D(IEnumerable<Point3D>? points, IEnumerable<int[]>? indexes)
            : base(points, indexes)
        {
        }

        public override ISerializableObject? Clone()
        {
            return new Mesh3D(this);
        }

        public List<Segment3D>? GetAuxiliarySegments()
        {
            if (points is null || indexes is null)
            {
                return null;
            }

            List<int[]>? auxiliaryIndexes = Core.Query.AuxiliaryIndexes(indexes);
            if (auxiliaryIndexes is null)
            {
                return null;
            }

            List<Segment3D> result = [];
            foreach (int[] indexes_Segment3D in auxiliaryIndexes)
            {
                result.Add(new Segment3D(points[indexes_Segment3D[0]], points[indexes_Segment3D[1]]));
            }

            return result;
        }

        public List<Polyloop>? GetBoundaryEdges()
        {
            if (points is null || indexes is null)
            {
                return null;
            }

            List<List<int>>? indexesList = Core.Query.SortedBoundaryIndexes(indexes);
            if (indexesList is null)
            {
                return null;
            }

            List<Polyloop>? result = [];
            foreach (List<int> indexes_Polygon3D in indexesList)
            {
                List<Point3D> point3Ds = [];
                foreach (int index in indexes_Polygon3D)
                {
                    point3Ds.Add(points[index]);
                }

                result.Add(new Polyloop(point3Ds));
            }

            return result;
        }

        public List<Polyloop>? GetBoundaryEdges(out List<Segment3D>? auxiliarySegments)
        {
            auxiliarySegments = null;

            if (points is null || indexes is null)
            {
                return null;
            }

            List<List<int>>? indexesList = Core.Query.SortedBoundaryIndexes(indexes, out List<int[]>? auxiliaryIndexes);
            if (auxiliaryIndexes != null)
            {
                auxiliarySegments = [];
                foreach (int[] indexes_Segment3D in auxiliaryIndexes)
                {
                    auxiliarySegments.Add(new Segment3D(points[indexes_Segment3D[0]], points[indexes_Segment3D[1]]));
                }
            }

            List<Polyloop>? result = null;
            if (indexesList is not null)
            {
                result = [];
                foreach (List<int> indexes_Polygon2D in indexesList)
                {
                    List<Point3D> point3Ds = [];
                    foreach (int index in indexes_Polygon2D)
                    {
                        point3Ds.Add(points[index]);
                    }

                    result.Add(new Polyloop(point3Ds));
                }
            }

            return result;
        }

        public BoundingBox3D? GetBoundingBox()
        {
            if (points == null)
            {
                return null;
            }

            return new(points);
        }

        public Triangle3D? GetTriangle(int index)
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

            return new(points[index_1], points[index_2], points[index_3]);
        }

        public List<Triangle3D>? GetTriangles()
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

            List<Triangle3D> result = [];
            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < TrianglesCount; i++)
            {
                Triangle3D? triangle3D = GetTriangle(i);
                if (triangle3D is null)
                {
                    continue;
                }

                result.Add(triangle3D);
            }

            return result;
        }

        public bool Move(Vector3D? vector2D)
        {
            if (points == null || vector2D == null)
            {
                return false;
            }

            for (int i = 0; i < points.Count; i++)
            {
                points[i]?.Move(vector2D);
            }

            return true;
        }

        public bool Transform(ITransform3D? transform)
        {
            if (transform == null || points == null)
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