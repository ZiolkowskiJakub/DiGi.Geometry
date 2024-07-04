using System.Collections.Generic;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IGeometryCollection : IGeometry
    {

    }

    public interface IGeometryCollection<T> : IGeometryCollection, ICollection<T> where T : ICollectable
    {

    }
}
