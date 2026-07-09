#### [DiGi\.Geometry](DiGi.Geometry.Overview.md 'DiGi\.Geometry\.Overview')

## DiGi\.Geometry\.Spatial\.Interfaces Namespace
### Interfaces

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D'></a>

## IBooleanOperationResult3D Interface

Defines a contract for a 3D boolean operation result\.

```csharp
public interface IBooleanOperationResult3D : DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [BooleanOperationResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BooleanOperationResult3D 'DiGi\.Geometry\.Spatial\.Classes\.BooleanOperationResult3D')  
↳ [DifferenceResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.DifferenceResult3D 'DiGi\.Geometry\.Spatial\.Classes\.DifferenceResult3D')  
↳ [UnionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.UnionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.UnionResult3D')  
↳ [IDifferenceResult3D](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IDifferenceResult3D 'DiGi\.Geometry\.Spatial\.Interfaces\.IDifferenceResult3D')  
↳ [IUnionResult3D](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IUnionResult3D 'DiGi\.Geometry\.Spatial\.Interfaces\.IUnionResult3D')

Implements [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Properties

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.BooleanOpertaionType'></a>

## IBooleanOperationResult3D\.BooleanOpertaionType Property

Gets the type of the boolean operation\.

```csharp
DiGi.Geometry.Core.Enums.BooleanOpertaionType BooleanOpertaionType { get; }
```

#### Property Value
[BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.Count'></a>

## IBooleanOperationResult3D\.Count Property

Gets the total number of 3D geometries in the result\.

```csharp
int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.this[int]'></a>

## IBooleanOperationResult3D\.this\[int\] Property

Gets the 3D geometry at the specified index\.

```csharp
DiGi.Geometry.Spatial.Interfaces.IGeometry3D? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the geometry to retrieve\.

#### Property Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')
### Methods

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.Any()'></a>

## IBooleanOperationResult3D\.Any\(\) Method

Determines whether any 3D geometries are present in the result\.

```csharp
bool Any();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if any geometries are present; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.Contains_T_()'></a>

## IBooleanOperationResult3D\.Contains\<T\>\(\) Method

Determines whether the result contains any geometry of type [T](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.Contains_T_().T 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D\.Contains\<T\>\(\)\.T')\.

```csharp
bool Contains<T>()
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.Contains_T_().T'></a>

`T`

The type of geometry to search for, which must implement the [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') interface\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if an object of type [T](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.Contains_T_().T 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D\.Contains\<T\>\(\)\.T') is present; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.GetGeometry3Ds_T_()'></a>

## IBooleanOperationResult3D\.GetGeometry3Ds\<T\>\(\) Method

Retrieves a list of 3D geometries of the specified type [T](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D\.GetGeometry3Ds\<T\>\(\)\.T')\.

```csharp
System.Collections.Generic.List<T>? GetGeometry3Ds<T>()
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.GetGeometry3Ds_T_().T'></a>

`T`

The type of geometry to retrieve, which must implement the [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') interface\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D\.GetGeometry3Ds\<T\>\(\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of geometries of type [T](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D\.GetGeometry3Ds\<T\>\(\)\.T'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no geometries are present\.

<a name='DiGi.Geometry.Spatial.Interfaces.IDifferenceResult3D'></a>

## IDifferenceResult3D Interface

Defines a contract for a 3D boolean difference operation result\.

```csharp
public interface IDifferenceResult3D : DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [DifferenceResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.DifferenceResult3D 'DiGi\.Geometry\.Spatial\.Classes\.DifferenceResult3D')

Implements [IBooleanOperationResult3D](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Geometry.Spatial.Interfaces.IUnionResult3D'></a>

## IUnionResult3D Interface

Defines a contract for a 3D boolean union operation result\.

```csharp
public interface IUnionResult3D : DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [UnionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.UnionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.UnionResult3D')

Implements [IBooleanOperationResult3D](DiGi.Geometry.Spatial.Interfaces.md#DiGi.Geometry.Spatial.Interfaces.IBooleanOperationResult3D 'DiGi\.Geometry\.Spatial\.Interfaces\.IBooleanOperationResult3D'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')