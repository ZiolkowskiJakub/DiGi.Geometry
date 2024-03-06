
using System.Collections;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IGeometryCollection : IGeometry, ICollection
    {

    }

    public interface IGeometryCollection<T> : IGeometryCollection where T : ICollectable
    {

    }
}
