#### [DiGi\.Geometry](DiGi.Geometry.Overview.md 'DiGi\.Geometry\.Overview')

## DiGi\.Geometry\.Core\.Interfaces Namespace
### Interfaces

<a name='DiGi.Geometry.Core.Interfaces.IIntersectionResult'></a>

## IIntersectionResult Interface

```csharp
public interface IIntersectionResult : DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
↳ [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
↳ [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')

Implements [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Methods

<a name='DiGi.Geometry.Core.Interfaces.IIntersectionResult.Any()'></a>

## IIntersectionResult\.Any\(\) Method

Determines whether an intersection exists\.

```csharp
bool Any();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if any geometries are present; otherwise, `false`\.