#### [DiGi\.Geometry](DiGi.Geometry.Overview.md 'DiGi\.Geometry\.Overview')

## DiGi\.Geometry\.Planar\.Classes Namespace
### Classes

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D'></a>

## BooleanOperationResult2D Class

Represents the abstract base class for a 2D boolean operation result\.

```csharp
public abstract class BooleanOperationResult2D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → BooleanOperationResult2D

Derived  
↳ [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D')  
↳ [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
↳ [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D')

Implements [IBooleanOperationResult2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D()'></a>

## BooleanOperationResult2D\(\) Constructor

Initializes a new instance of the [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') class\.

```csharp
protected BooleanOperationResult2D();
```

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(DiGi.Geometry.Planar.Classes.BooleanOperationResult2D)'></a>

## BooleanOperationResult2D\(BooleanOperationResult2D\) Constructor

Initializes a new instance of the [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') class using another instance\.

```csharp
protected BooleanOperationResult2D(DiGi.Geometry.Planar.Classes.BooleanOperationResult2D? booleanOperationResult2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(DiGi.Geometry.Planar.Classes.BooleanOperationResult2D).booleanOperationResult2D'></a>

`booleanOperationResult2D` [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D')

The instance to copy from\.

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## BooleanOperationResult2D\(IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') class with the specified geometries\.

```csharp
protected BooleanOperationResult2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The geometries to store in the result\.

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool)'></a>

## BooleanOperationResult2D\(List\<IGeometry2D\>, bool\) Constructor

Initializes a new instance of the [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') class from a prebuilt list of geometries\.

```csharp
protected BooleanOperationResult2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of geometries to store in the result\.

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), each geometry is cloned defensively; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied list is adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created geometries that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Text.Json.Nodes.JsonObject)'></a>

## BooleanOperationResult2D\(JsonObject\) Constructor

Initializes a new instance of the [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
protected BooleanOperationResult2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOperationResult2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.BooleanOpertaionType'></a>

## BooleanOperationResult2D\.BooleanOpertaionType Property

Gets the type of the boolean operation\.

```csharp
public abstract DiGi.Geometry.Core.Enums.BooleanOpertaionType BooleanOpertaionType { get; }
```

Implements [BooleanOpertaionType](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.BooleanOpertaionType 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.BooleanOpertaionType')

#### Property Value
[BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.Count'></a>

## BooleanOperationResult2D\.Count Property

Gets the total number of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') elements\.

```csharp
public int Count { get; }
```

Implements [Count](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.Count 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.Count')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.this[int]'></a>

## BooleanOperationResult2D\.this\[int\] Property

Gets the 2D geometry at the specified index\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IGeometry2D? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the geometry to retrieve\.

Implements [this\[int\]](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.this[int] 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.this\[int\]')

#### Property Value
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.Any()'></a>

## BooleanOperationResult2D\.Any\(\) Method

Determines whether there are any 2D geometries present\.

```csharp
public bool Any();
```

Implements [Any\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.Any() 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.Any\(\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if any geometries are present; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.Contains_T_()'></a>

## BooleanOperationResult2D\.Contains\<T\>\(\) Method

Determines whether the collection contains any object of the specified type [T](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.Contains_T_().T 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D\.Contains\<T\>\(\)\.T')\.

```csharp
public bool Contains<T>()
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.Contains_T_().T'></a>

`T`

The type of geometry to search for\.

Implements [Contains&lt;T&gt;\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.Contains_T_() 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.Contains\<T\>\(\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if an object of type [T](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.Contains_T_().T 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D\.Contains\<T\>\(\)\.T') is present; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.GetGeometry2Ds_T_()'></a>

## BooleanOperationResult2D\.GetGeometry2Ds\<T\>\(\) Method

Retrieves a list of 2D geometries of the specified type [T](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.GetGeometry2Ds_T_().T 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D\.GetGeometry2Ds\<T\>\(\)\.T')\.

```csharp
public System.Collections.Generic.List<T>? GetGeometry2Ds<T>()
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.GetGeometry2Ds_T_().T'></a>

`T`

The type of geometry to retrieve, which must implement the [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') interface\.

Implements [GetGeometry2Ds&lt;T&gt;\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.GetGeometry2Ds_T_() 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.GetGeometry2Ds\<T\>\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D.GetGeometry2Ds_T_().T 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D\.GetGeometry2Ds\<T\>\(\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching geometries, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no geometries are present\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D'></a>

## BoundingBox2D Class

Represents an axis\-aligned bounding box in 2D space\.

```csharp
public class BoundingBox2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Core.Interfaces.IBoundingBox<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.IBoundingBox, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → BoundingBox2D

Implements [DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_)'></a>

## BoundingBox2D\(Range\<double\>, Range\<double\>\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class defined by X and Y ranges\.

```csharp
public BoundingBox2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of the X axis\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of the Y axis\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## BoundingBox2D\(BoundingBox2D\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class by cloning an existing bounding box\.

```csharp
public BoundingBox2D(DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The source bounding box to clone\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## BoundingBox2D\(Point2D, Point2D\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class defined by two points as opposite corners\.

```csharp
public BoundingBox2D(DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first corner point\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second corner point\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double)'></a>

## BoundingBox2D\(double, double, double, double\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class defined by its origin and size\.

```csharp
public BoundingBox2D(double x, double y, double width, double height);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the origin\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the origin\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double,bool)'></a>

## BoundingBox2D\(double, double, double, double, bool\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class directly from corner coordinates, without intermediate allocations\.

```csharp
internal BoundingBox2D(double x_1, double y_1, double x_2, double y_2, bool sorted);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double,bool).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the first corner\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double,bool).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the first corner\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double,bool).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the second corner\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double,bool).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the second corner\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(double,double,double,double,bool).sorted'></a>

`sorted` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the caller guarantees the first corner is the minimum and the second the maximum; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the coordinates are normalized\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.BoundingBox2D_)'></a>

## BoundingBox2D\(IEnumerable\<BoundingBox2D\>\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class that encompasses all given bounding boxes\.

```csharp
public BoundingBox2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.BoundingBox2D?>? boundingBox2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.BoundingBox2D_).boundingBox2Ds'></a>

`boundingBox2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of bounding boxes to encompass\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## BoundingBox2D\(IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class that encompasses all given points\.

```csharp
public BoundingBox2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points to encompass\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## BoundingBox2D\(IEnumerable\<Point2D\>, double\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class that encompasses all given points with an added offset\.

```csharp
public BoundingBox2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points to encompass\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance to expand the bounding box in all directions\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Text.Json.Nodes.JsonObject)'></a>

## BoundingBox2D\(JsonObject\) Constructor

Initializes a new instance of the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') class from a JSON object\.

```csharp
public BoundingBox2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BoundingBox2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing bounding box data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BottomLeft'></a>

## BoundingBox2D\.BottomLeft Property

Gets the bottom\-left corner of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? BottomLeft { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.BottomRight'></a>

## BoundingBox2D\.BottomRight Property

Gets the bottom\-right corner of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? BottomRight { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Height'></a>

## BoundingBox2D\.Height Property

Gets the height of the bounding box\.

```csharp
public double Height { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Max'></a>

## BoundingBox2D\.Max Property

Gets or sets the maximum corner \(top\-right\) of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D Max { get; set; }
```

Implements [Max](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1.max 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1\.Max')

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Min'></a>

## BoundingBox2D\.Min Property

Gets the minimum corner \(bottom\-left\) of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D Min { get; set; }
```

Implements [Min](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1.min 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1\.Min')

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.TopLeft'></a>

## BoundingBox2D\.TopLeft Property

Gets the top\-left corner of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? TopLeft { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.TopRight'></a>

## BoundingBox2D\.TopRight Property

Gets the top\-right corner of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? TopRight { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Width'></a>

## BoundingBox2D\.Width Property

Gets the width of the bounding box\.

```csharp
public double Width { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Add(DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## BoundingBox2D\.Add\(BoundingBox2D\) Method

Adds another bounding box to this one, expanding it to encompass the new area\.

```csharp
public bool Add(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Add(DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the bounding box was successfully added\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Add(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## BoundingBox2D\.Add\(Point2D\) Method

Adds a point to this bounding box, expanding it to encompass the point\.

```csharp
public bool Add(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Add(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was successfully added\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Clone()'></a>

## BoundingBox2D\.Clone\(\) Method

Creates a clone of the current bounding box\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## BoundingBox2D\.ClosestPoint\(Point2D\) Method

Finds the point on the bounding box closest to the given point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest point on the bounding box boundary\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## BoundingBox2D\.Distance\(Point2D\) Method

Calculates the distance from a point to the bounding box boundary\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance to the boundary\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetArea()'></a>

## BoundingBox2D\.GetArea\(\) Method

Calculates the area of the bounding box\.

```csharp
public double GetArea();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetCentroid()'></a>

## BoundingBox2D\.GetCentroid\(\) Method

Gets the centroid of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetCentroid();
```

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The center point of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetDiagonals()'></a>

## BoundingBox2D\.GetDiagonals\(\) Method

Gets the diagonals of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Segment2D[]? GetDiagonals();
```

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the two diagonal segments\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetLength()'></a>

## BoundingBox2D\.GetLength\(\) Method

Calculates the perimeter length of the bounding box\.

```csharp
public double GetLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The total length of the boundary\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetPoint(DiGi.Geometry.Core.Enums.Corner)'></a>

## BoundingBox2D\.GetPoint\(Corner\) Method

Gets the point corresponding to a specific corner of the bounding box\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetPoint(DiGi.Geometry.Core.Enums.Corner corner);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetPoint(DiGi.Geometry.Core.Enums.Corner).corner'></a>

`corner` [Corner](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Corner 'DiGi\.Geometry\.Core\.Enums\.Corner')

The corner to retrieve\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The point at the specified corner\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetPoints()'></a>

## BoundingBox2D\.GetPoints\(\) Method

Gets the four corner points of the bounding box\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? GetPoints();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the bottom\-left, top\-left, top\-right, and bottom\-right corners\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.GetSegments()'></a>

## BoundingBox2D\.GetSegments\(\) Method

Gets the four segments forming the boundary of the bounding box\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of segments that define the perimeter\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## BoundingBox2D\.InRange\(BoundingBox2D, double\) Method

Checks if another bounding box is within or intersects this bounding box\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the bounding box is on or inside this bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Line2D,double)'></a>

## BoundingBox2D\.InRange\(Line2D, double\) Method

Checks if a line is within or intersects the bounding box\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Line2D? line2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Line2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Line2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the line is in range of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## BoundingBox2D\.InRange\(Point2D, double\) Method

Checks if a point is within or on the boundary of this bounding box\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on or inside the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## BoundingBox2D\.InRange\(Segment2D, double\) Method

Checks if a segment is within or intersects the bounding box\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the segment is in range of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## BoundingBox2D\.InRange\(ISegmentable2D, double\) Method

Checks if a segmentable geometry is within or intersects the bounding box\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any part of the geometry is in range of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange_Old(DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## BoundingBox2D\.InRange\_Old\(Segment2D, double\) Method

Legacy method to check if a segment is within or intersects the bounding box\.

```csharp
public bool InRange_Old(DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange_Old(DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.InRange_Old(DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the segment is in range of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## BoundingBox2D\.Inside\(BoundingBox2D, double\) Method

Checks if boundingBox2D is inside this BoundingBox2D

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

BoundingBox2D

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if given boundingBox2D is inside this BoundingBox2D with given tolerance

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## BoundingBox2D\.Inside\(Point2D, double\) Method

Checks if a point is strictly inside the bounding box boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is strictly inside\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## BoundingBox2D\.Inside\(ISegmentable2D, double\) Method

Checks if a segmentable geometry is strictly inside the bounding box boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if all points of the geometry are strictly inside\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## BoundingBox2D\.Inside\(IEnumerable\<Point2D\>, double\) Method

Checks if a collection of points are all strictly inside the bounding box boundaries\.

```csharp
public bool Inside(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Inside(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if all points are strictly inside\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## BoundingBox2D\.Move\(Vector2D\) Method

Moves the bounding box by the specified vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Offset(double)'></a>

## BoundingBox2D\.Offset\(double\) Method

Offsets the bounding box boundaries by a specified distance in all directions\.

```csharp
public void Offset(double value);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Offset(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The offset value\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## BoundingBox2D\.On\(Point2D, double\) Method

Checks if a point lies on the boundary of the bounding box\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the boundary\.

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## BoundingBox2D\.Transform\(ITransform2D\) Method

Transforms the bounding box using the specified transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.op_ImplicitDiGi.Geometry.Planar.Classes.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## BoundingBox2D\.implicit operator Polygon2D\(BoundingBox2D\) Operator

Implicitly converts a BoundingBox2D to a Polygon2D\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? implicit operator DiGi.Geometry.Planar.Classes.Polygon2D?(DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.BoundingBox2D.op_ImplicitDiGi.Geometry.Planar.Classes.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to convert\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A Polygon2D representation of the bounding box\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D'></a>

## Circle2D Class

Represents a 2D circle defined by its center and radius\.

```csharp
public class Circle2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.IEllipse2D, DiGi.Geometry.Planar.Interfaces.IClosedCurve2D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Circle2D

Implements [IEllipse2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IEllipse2D 'DiGi\.Geometry\.Planar\.Interfaces\.IEllipse2D'), [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D()'></a>

## Circle2D\(\) Constructor

Initializes a new instance of the [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') class\.

```csharp
public Circle2D();
```

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(DiGi.Geometry.Planar.Classes.Circle2D)'></a>

## Circle2D\(Circle2D\) Constructor

Initializes a new instance of the [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') class by cloning an existing circle\.

```csharp
public Circle2D(DiGi.Geometry.Planar.Classes.Circle2D? circle2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(DiGi.Geometry.Planar.Classes.Circle2D).circle2D'></a>

`circle2D` [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')

The source circle to clone\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Circle2D\(Point2D, double\) Constructor

Initializes a new instance of the [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') class with a specified center and radius\.

```csharp
public Circle2D(DiGi.Geometry.Planar.Classes.Point2D? center, double radius);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(DiGi.Geometry.Planar.Classes.Point2D,double).center'></a>

`center` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The center point of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(DiGi.Geometry.Planar.Classes.Point2D,double).radius'></a>

`radius` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The radius of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(System.Text.Json.Nodes.JsonObject)'></a>

## Circle2D\(JsonObject\) Constructor

Initializes a new instance of the [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') class from a JSON object\.

```csharp
public Circle2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Circle2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing circle data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Center'></a>

## Circle2D\.Center Property

Gets or sets the center point of the circle\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Center { get; set; }
```

Implements [Center](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IEllipse2D.Center 'DiGi\.Geometry\.Planar\.Interfaces\.IEllipse2D\.Center')

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Diameter'></a>

## Circle2D\.Diameter Property

Gets or sets the diameter of the circle\.

```csharp
public double Diameter { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Length'></a>

## Circle2D\.Length Property

Gets the circumference \(length\) of the circle\.

```csharp
public double Length { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Radius'></a>

## Circle2D\.Radius Property

Gets or sets the radius of the circle\.

```csharp
public double Radius { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Clone()'></a>

## Circle2D\.Clone\(\) Method

Creates a clone of the current circle\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.GetArea()'></a>

## Circle2D\.GetArea\(\) Method

Calculates the area of the circle\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetArea() 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetArea\(\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.GetBoundingBox()'></a>

## Circle2D\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the circle\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The bounding box encompassing the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.GetInternalPoint(double)'></a>

## Circle2D\.GetInternalPoint\(double\) Method

Gets a point guaranteed to be inside the circle\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

Implements [GetInternalPoint\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetInternalPoint(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetInternalPoint\(double\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
An internal point of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.GetPerimeter()'></a>

## Circle2D\.GetPerimeter\(\) Method

Gets the perimeter \(circumference\) of the circle\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The length of the boundary\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## Circle2D\.InRange\(BoundingBox2D, double\) Method

Checks if an axis\-aligned bounding box is within or intersects the circle\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to check\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the bounding box is in range of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Circle2D\.InRange\(Point2D, double\) Method

Checks if a point is within or on the boundary of the circle\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [InRange\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Circle2D\.InRange\(ISegmentable2D, double\) Method

Checks if a segmentable geometry is within or intersects the circle\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any part of the geometry is in range of the circle\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Circle2D\.Inside\(Point2D, double\) Method

Checks if a point is strictly inside the circle boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [Inside\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.Inside\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is strictly inside\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Circle2D\.Inside\(ISegmentable2D, double\) Method

Checks if a segmentable geometry is strictly inside the circle boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if all points of the geometry are strictly inside\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Circle2D\.Move\(Vector2D\) Method

Moves the circle by the specified vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Circle2D\.On\(Point2D, double\) Method

Checks if a point lies on the boundary of the circle\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the boundary\.

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Circle2D\.Transform\(ITransform2D\) Method

Transforms the circle using the specified transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Circle2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.ConvexHullComparer'></a>

## ConvexHullComparer Class

```csharp
internal class ConvexHullComparer : System.Collections.Generic.IComparer<DiGi.Geometry.Planar.Classes.Point2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ConvexHullComparer

Implements [System\.Collections\.Generic\.IComparer&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1 'System\.Collections\.Generic\.IComparer\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1 'System\.Collections\.Generic\.IComparer\`1')
### Methods

<a name='DiGi.Geometry.Planar.Classes.ConvexHullComparer.Compare(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## ConvexHullComparer\.Compare\(Point2D, Point2D\) Method

Compares two points for the purpose of calculating a convex hull\.

```csharp
public int Compare(DiGi.Geometry.Planar.Classes.Point2D point2D_1, DiGi.Geometry.Planar.Classes.Point2D point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.ConvexHullComparer.Compare(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first point to compare\.

<a name='DiGi.Geometry.Planar.Classes.ConvexHullComparer.Compare(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second point to compare\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A value indicating the relative order of the two points\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D'></a>

## Coordinate2D Class

Base class for 2D coordinates providing basic transformation and movement functionality\.

```csharp
public abstract class Coordinate2D : DiGi.Geometry.Core.Classes.Coordinate, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') → Coordinate2D

Derived  
↳ [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
↳ [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

Implements [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D()'></a>

## Coordinate2D\(\) Constructor

Initializes a new instance of the [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') class\.

```csharp
public Coordinate2D();
```

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(DiGi.Geometry.Planar.Classes.Coordinate2D)'></a>

## Coordinate2D\(Coordinate2D\) Constructor

Initializes a new instance of the [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') class by cloning an existing coordinate\.

```csharp
public Coordinate2D(DiGi.Geometry.Planar.Classes.Coordinate2D? coordinate2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(DiGi.Geometry.Planar.Classes.Coordinate2D).coordinate2D'></a>

`coordinate2D` [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D')

The source coordinate to clone\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(double,double)'></a>

## Coordinate2D\(double, double\) Constructor

Initializes a new instance of the [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') class with specified X and Y coordinates\.

```csharp
public Coordinate2D(double x, double y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(double[])'></a>

## Coordinate2D\(double\[\]\) Constructor

Initializes a new instance of the [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') class from an array of values\.

```csharp
public Coordinate2D(double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The coordinate values\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(int)'></a>

## Coordinate2D\(int\) Constructor

Initializes a new instance of the [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') class with the specified internal values array length\.

```csharp
protected Coordinate2D(int length);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(int).length'></a>

`length` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The length of the values array\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(System.Text.Json.Nodes.JsonObject)'></a>

## Coordinate2D\(JsonObject\) Constructor

Initializes a new instance of the [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') class from a JSON object\.

```csharp
public Coordinate2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Coordinate2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing coordinate data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.X'></a>

## Coordinate2D\.X Property

Gets or sets the X coordinate\.

```csharp
public double X { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Y'></a>

## Coordinate2D\.Y Property

Gets or sets the Y coordinate\.

```csharp
public double Y { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Coordinate2D\.Move\(Vector2D\) Method

Moves the coordinate by the specified vector\.

```csharp
public bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Coordinate2D\.Transform\(ITransform2D\) Method

Transforms the coordinate using the specified transformation\.

```csharp
public bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Coordinate2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D'></a>

## CoordinateSystem2D Class

Represents a two\-dimensional coordinate system defined by an origin [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and basis vectors [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')\.

```csharp
public class CoordinateSystem2D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → CoordinateSystem2D

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D()'></a>

## CoordinateSystem2D\(\) Constructor

Initializes a new instance of the [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D') class with default origin and world axes\.

```csharp
public CoordinateSystem2D();
```

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D)'></a>

## CoordinateSystem2D\(CoordinateSystem2D\) Constructor

Initializes a new instance of the [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D') class by cloning an existing coordinate system\.

```csharp
public CoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D? coordinateSystem2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D).coordinateSystem2D'></a>

`coordinateSystem2D` [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D')

The source coordinate system to clone\.

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## CoordinateSystem2D\(Point2D\) Constructor

Initializes a new instance of the [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D') class with a specified origin and world axes\.

```csharp
public CoordinateSystem2D(DiGi.Geometry.Planar.Classes.Point2D? origin);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D(DiGi.Geometry.Planar.Classes.Point2D).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the coordinate system\.

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D(System.Text.Json.Nodes.JsonObject)'></a>

## CoordinateSystem2D\(JsonObject\) Constructor

Initializes a new instance of the [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D') class from a JSON object\.

```csharp
public CoordinateSystem2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.CoordinateSystem2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing coordinate system data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.AxisX'></a>

## CoordinateSystem2D\.AxisX Property

Gets the X\-axis vector of the coordinate system\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? AxisX { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.AxisY'></a>

## CoordinateSystem2D\.AxisY Property

Gets the Y\-axis vector of the coordinate system\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? AxisY { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.Origin'></a>

## CoordinateSystem2D\.Origin Property

Gets the origin point of the coordinate system\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Origin { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.Clone()'></a>

## CoordinateSystem2D\.Clone\(\) Method

Creates a clone of the current coordinate system\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the coordinate system\.

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.GetAxis(DiGi.Geometry.Planar.Enums.PlanarAxis)'></a>

## CoordinateSystem2D\.GetAxis\(PlanarAxis\) Method

Gets the vector corresponding to the specified axis\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? GetAxis(DiGi.Geometry.Planar.Enums.PlanarAxis axis);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.GetAxis(DiGi.Geometry.Planar.Enums.PlanarAxis).axis'></a>

`axis` [PlanarAxis](DiGi.Geometry.Planar.Enums.md#DiGi.Geometry.Planar.Enums.PlanarAxis 'DiGi\.Geometry\.Planar\.Enums\.PlanarAxis')

The axis to retrieve\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
The vector of the requested axis\.

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## CoordinateSystem2D\.Move\(Vector2D\) Method

Moves the coordinate system origin by the specified vector\.

```csharp
public bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## CoordinateSystem2D\.Transform\(ITransform2D\) Method

Transforms the coordinate system using the specified transformation\.

```csharp
public bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.CoordinateSystem2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D'></a>

## DifferenceResult2D Class

Represents the result of a 2D difference operation\.

```csharp
public class DifferenceResult2D : DiGi.Geometry.Planar.Classes.BooleanOperationResult2D, DiGi.Geometry.Planar.Interfaces.IDifferenceResult2D, DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') → DifferenceResult2D

Implements [IDifferenceResult2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IDifferenceResult2D 'DiGi\.Geometry\.Planar\.Interfaces\.IDifferenceResult2D'), [IBooleanOperationResult2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D()'></a>

## DifferenceResult2D\(\) Constructor

Initializes a new instance of the [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') class\.

```csharp
public DifferenceResult2D();
```

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(DiGi.Geometry.Planar.Classes.DifferenceResult2D)'></a>

## DifferenceResult2D\(DifferenceResult2D\) Constructor

Initializes a new instance of the [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') class using another [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') instance\.

```csharp
public DifferenceResult2D(DiGi.Geometry.Planar.Classes.DifferenceResult2D? differenceResult2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(DiGi.Geometry.Planar.Classes.DifferenceResult2D).differenceResult2D'></a>

`differenceResult2D` [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D')

The [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') instance to copy from\.

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## DifferenceResult2D\(IGeometry2D\) Constructor

Initializes a new instance of the [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') class with the specified [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

```csharp
public DifferenceResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') to initialize the result with\. This value can be null\.

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## DifferenceResult2D\(IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') class\.

```csharp
public DifferenceResult2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects to be cloned and stored in the result\.

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool)'></a>

## DifferenceResult2D\(List\<IGeometry2D\>, bool\) Constructor

Initializes a new instance of the [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') class from a prebuilt list of geometries\.

```csharp
internal DifferenceResult2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of geometries resulting from the difference\.

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), each geometry is cloned defensively; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied list is adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created geometries that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Text.Json.Nodes.JsonObject)'></a>

## DifferenceResult2D\(JsonObject\) Constructor

Initializes a new instance of the [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public DifferenceResult2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.DifferenceResult2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.BooleanOpertaionType'></a>

## DifferenceResult2D\.BooleanOpertaionType Property

Gets the type of the boolean operation, which is [Difference](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType.Difference 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType\.Difference')\.

```csharp
public override DiGi.Geometry.Core.Enums.BooleanOpertaionType BooleanOpertaionType { get; }
```

Implements [BooleanOpertaionType](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.BooleanOpertaionType 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.BooleanOpertaionType')

#### Property Value
[BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')
### Methods

<a name='DiGi.Geometry.Planar.Classes.DifferenceResult2D.Clone()'></a>

## DifferenceResult2D\.Clone\(\) Method

Creates a copy of the current [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object\.

<a name='DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater'></a>

## DouglasPeuckerUpdater Class

Provides functionality to update a 2D geometry using the Douglas\-Peucker simplification algorithm\.

```csharp
public class DouglasPeuckerUpdater : DiGi.Geometry.Core.Classes.GeometryUpdater<DiGi.Geometry.Planar.Interfaces.IGeometry2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → DouglasPeuckerUpdater
### Constructors

<a name='DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater.DouglasPeuckerUpdater()'></a>

## DouglasPeuckerUpdater\(\) Constructor

Initializes a new instance of the [DouglasPeuckerUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater 'DiGi\.Geometry\.Planar\.Classes\.DouglasPeuckerUpdater') class\.

```csharp
public DouglasPeuckerUpdater();
```

<a name='DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater.DouglasPeuckerUpdater(double)'></a>

## DouglasPeuckerUpdater\(double\) Constructor

Initializes a new instance of the [DouglasPeuckerUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater 'DiGi\.Geometry\.Planar\.Classes\.DouglasPeuckerUpdater') class with a specified tolerance\.

```csharp
public DouglasPeuckerUpdater(double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater.DouglasPeuckerUpdater(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for simplifying geometries\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater.Update()'></a>

## DouglasPeuckerUpdater\.Update\(\) Method

Updates the current value by simplifying its underlying geometry using the Douglas\-Peucker simplification algorithm\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update was successful\. Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the value is null or cannot be simplified; otherwise, returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D'></a>

## Ellipse2D Class

Represents a 2D ellipse defined by its center, semi\-axes lengths, and the direction of the major axis\.

```csharp
public class Ellipse2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.IEllipse2D, DiGi.Geometry.Planar.Interfaces.IClosedCurve2D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Ellipse2D

Implements [IEllipse2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IEllipse2D 'DiGi\.Geometry\.Planar\.Interfaces\.IEllipse2D'), [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Ellipse2D\(Ellipse2D\) Constructor

Initializes a new instance of the [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') class by cloning an existing ellipse\.

```csharp
public Ellipse2D(DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The source ellipse to clone\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double)'></a>

## Ellipse2D\(Point2D, double, double\) Constructor

Initializes a new instance of the [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') class with center and semi\-axes lengths\.

```csharp
public Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D? center, double a, double b);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double).center'></a>

`center` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The center point of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the semi\-major axis\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the semi\-minor axis\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Ellipse2D\(Point2D, double, double, Vector2D\) Constructor

Initializes a new instance of the [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') class with center, semi\-axes lengths and major axis direction\.

```csharp
public Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D? center, double a, double b, DiGi.Geometry.Planar.Classes.Vector2D? directionA);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).center'></a>

`center` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The center point of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the semi\-major axis\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the semi\-minor axis\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).directionA'></a>

`directionA` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction vector of the major axis\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(System.Text.Json.Nodes.JsonObject)'></a>

## Ellipse2D\(JsonObject\) Constructor

Initializes a new instance of the [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') class from a JSON object\.

```csharp
public Ellipse2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Ellipse2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing ellipse data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.A'></a>

## Ellipse2D\.A Property

Gets or sets the length of the semi\-major axis\.

```csharp
public double A { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.B'></a>

## Ellipse2D\.B Property

Gets or sets the length of the semi\-minor axis\.

```csharp
public double B { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.C'></a>

## Ellipse2D\.C Property

Gets the linear eccentricity of the ellipse\.

```csharp
public double C { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Center'></a>

## Ellipse2D\.Center Property

Gets or sets the center point of the ellipse\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Center { get; set; }
```

Implements [Center](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IEllipse2D.Center 'DiGi\.Geometry\.Planar\.Interfaces\.IEllipse2D\.Center')

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.DirectionA'></a>

## Ellipse2D\.DirectionA Property

Gets or sets the direction vector of the major axis\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? DirectionA { get; set; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.DirectionB'></a>

## Ellipse2D\.DirectionB Property

Gets the direction vector of the minor axis\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? DirectionB { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Clone()'></a>

## Ellipse2D\.Clone\(\) Method

Creates a clone of the current ellipse\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Ellipse2D\.Distance\(Point2D\) Method

Calculates the shortest distance from a point to the ellipse boundary\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The minimum distance to the boundary\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Equals(object)'></a>

## Ellipse2D\.Equals\(object\) Method

Determines whether the specified object is equal to the current ellipse\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current ellipse\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetArea()'></a>

## Ellipse2D\.GetArea\(\) Method

Calculates the area of the ellipse\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetArea() 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetArea\(\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetBoundingBox()'></a>

## Ellipse2D\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the ellipse\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The bounding box encompassing the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetFocalLength()'></a>

## Ellipse2D\.GetFocalLength\(\) Method

Calculates the distance between the foci of the ellipse\.

```csharp
public double GetFocalLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The focal length\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetFocalPoints()'></a>

## Ellipse2D\.GetFocalPoints\(\) Method

Gets the focal points of the ellipse\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D[]? GetFocalPoints();
```

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the two foci\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetHashCode()'></a>

## Ellipse2D\.GetHashCode\(\) Method

Gets the hash code for this ellipse\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetInternalPoint(double)'></a>

## Ellipse2D\.GetInternalPoint\(double\) Method

Gets a point guaranteed to be inside the ellipse\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

Implements [GetInternalPoint\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetInternalPoint(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetInternalPoint\(double\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
An internal point of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetPerimeter()'></a>

## Ellipse2D\.GetPerimeter\(\) Method

Calculates the approximate perimeter of the ellipse using Ramanujan's formula\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The circumference of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetPoint(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Ellipse2D\.GetPoint\(Vector2D\) Method

Gets the point on the ellipse boundary in a given direction from the center\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetPoint(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.GetPoint(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction vector\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The corresponding point on the ellipse boundary\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Ellipse2D\.InRange\(Point2D, double\) Method

Checks if a point is within or on the boundary of the ellipse\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [InRange\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range of the ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Ellipse2D\.Inside\(Point2D, double\) Method

Checks if a point is strictly inside the ellipse boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [Inside\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.Inside\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is strictly inside\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Inverse()'></a>

## Ellipse2D\.Inverse\(\) Method

Inverts the direction of the major axis\.

```csharp
public void Inverse();
```

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Ellipse2D\.Move\(Vector2D\) Method

Moves the ellipse by the specified vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Ellipse2D\.On\(Point2D, double\) Method

Checks if a point lies on the boundary of the ellipse\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the boundary\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Project(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Ellipse2D\.Project\(Point2D\) Method

Projects a point onto the ellipse boundary using an iterative approach\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Project(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected point on the ellipse boundary\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Project(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Ellipse2D\.Project\(Point2D, double\) Method

Projects a point onto the ellipse boundary with a specified tolerance for convergence\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Project(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Project(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The convergence tolerance\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected point on the ellipse boundary\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Ellipse2D\.Transform\(ITransform2D\) Method

Transforms the ellipse using the specified transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_Equality(DiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Ellipse2D\.operator ==\(Ellipse2D, Ellipse2D\) Operator

Determines whether two ellipses are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D_1, DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_Equality(DiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D_1'></a>

`ellipse2D_1` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The first ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_Equality(DiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D_2'></a>

`ellipse2D_2` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The second ellipse\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the ellipses are equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_ExplicitDiGi.Geometry.Planar.Classes.Ellipse2D(DiGi.Geometry.Planar.Classes.Circle2D)'></a>

## Ellipse2D\.explicit operator Ellipse2D\(Circle2D\) Operator

Converts a [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') to an [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Ellipse2D? explicit operator DiGi.Geometry.Planar.Classes.Ellipse2D?(DiGi.Geometry.Planar.Classes.Circle2D? circle2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_ExplicitDiGi.Geometry.Planar.Classes.Ellipse2D(DiGi.Geometry.Planar.Classes.Circle2D).circle2D'></a>

`circle2D` [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')

The source circle\.

#### Returns
[Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')  
An ellipse equivalent to the circle\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_Inequality(DiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Ellipse2D\.operator \!=\(Ellipse2D, Ellipse2D\) Operator

Determines whether two ellipses are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D_1, DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_Inequality(DiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D_1'></a>

`ellipse2D_1` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The first ellipse\.

<a name='DiGi.Geometry.Planar.Classes.Ellipse2D.op_Inequality(DiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D_2'></a>

`ellipse2D_2` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The second ellipse\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the ellipses are not equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Geometry2D'></a>

## Geometry2D Class

Represents a base class for all two\-dimensional geometric objects\.

```csharp
public abstract class Geometry2D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Geometry2D

Derived  
↳ [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
↳ [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')  
↳ [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')  
↳ [Grid2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D')  
↳ [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')  
↳ [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
↳ [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')  
↳ [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
↳ [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
↳ [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D')

Implements [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Geometry2D()'></a>

## Geometry2D\(\) Constructor

Initializes a new instance of the [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') class\.

```csharp
public Geometry2D();
```

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Geometry2D(DiGi.Geometry.Planar.Classes.Geometry2D)'></a>

## Geometry2D\(Geometry2D\) Constructor

Initializes a new instance of the [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') class by cloning an existing geometry\.

```csharp
public Geometry2D(DiGi.Geometry.Planar.Classes.Geometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Geometry2D(DiGi.Geometry.Planar.Classes.Geometry2D).geometry2D'></a>

`geometry2D` [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D')

The source geometry to clone\.

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Geometry2D(System.Text.Json.Nodes.JsonObject)'></a>

## Geometry2D\(JsonObject\) Constructor

Initializes a new instance of the [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') class from a JSON object\.

```csharp
public Geometry2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Geometry2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing geometry data\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Geometry2D\.Move\(Vector2D\) Method

Moves the geometry by the specified vector\.

```csharp
public abstract bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Geometry2D\.Transform\(ITransform2D\) Method

Transforms the geometry using the specified transformation\.

```csharp
public abstract bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Geometry2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D'></a>

## GeometryCollection2D Class

Represents a collection of two\-dimensional geometry objects that implement the [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D') interface\.

```csharp
public class GeometryCollection2D : DiGi.Geometry.Core.Classes.GeometryCollection<DiGi.Geometry.Planar.Interfaces.ICollectable2D>, DiGi.Geometry.Planar.Interfaces.IGeometryCollection2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Core.Interfaces.IGeometryCollection<DiGi.Geometry.Planar.Interfaces.ICollectable2D>, DiGi.Geometry.Core.Interfaces.IGeometryCollection, System.Collections.Generic.ICollection<DiGi.Geometry.Planar.Interfaces.ICollectable2D>, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ICollectable2D>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectcollection-1 'DiGi\.Core\.Classes\.SerializableObjectCollection\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectcollection-1 'DiGi\.Core\.Classes\.SerializableObjectCollection\`1') → [DiGi\.Geometry\.Core\.Classes\.GeometryCollection&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') → GeometryCollection2D

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IGeometryCollection2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometrycollection2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometryCollection2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection'), [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.GeometryCollection2D()'></a>

## GeometryCollection2D\(\) Constructor

Initializes a new instance of the [GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D') class\.

```csharp
public GeometryCollection2D();
```

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.GeometryCollection2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ICollectable2D_)'></a>

## GeometryCollection2D\(IEnumerable\<ICollectable2D\>\) Constructor

Initializes a new instance of the [GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D') class from a collection of geometries\.

```csharp
public GeometryCollection2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ICollectable2D> collectable2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.GeometryCollection2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ICollectable2D_).collectable2Ds'></a>

`collectable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries\.

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.GeometryCollection2D(System.Text.Json.Nodes.JsonObject)'></a>

## GeometryCollection2D\(JsonObject\) Constructor

Initializes a new instance of the [GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D') class from a JSON object\.

```csharp
public GeometryCollection2D(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.GeometryCollection2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing collection data\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## GeometryCollection2D\.Move\(Vector2D\) Method

Moves all geometries in the collection by the specified vector\.

```csharp
public bool Move(DiGi.Geometry.Planar.Classes.Vector2D vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## GeometryCollection2D\.Transform\(ITransform2D\) Method

Transforms all geometries in the collection using the specified transformation\.

```csharp
public bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.GeometryCollection2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D'></a>

## Grid2D Class

Represents a two\-dimensional grid geometry defined by its total width, total height, and the number of cells along each axis\.

```csharp
public class Grid2D : DiGi.Geometry.Planar.Classes.Geometry2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Grid2D
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Grid2D)'></a>

## Grid2D\(Grid2D\) Constructor

Initializes a new instance of the [Grid2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D') class by cloning an existing grid\.

```csharp
public Grid2D(DiGi.Geometry.Planar.Classes.Grid2D grid2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Grid2D).grid2D'></a>

`grid2D` [Grid2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D')

The source grid to clone\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int)'></a>

## Grid2D\(Point2D, double, double, Vector2D, int, int\) Constructor

Initializes a new instance of the [Grid2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D') class\.

```csharp
public Grid2D(DiGi.Geometry.Planar.Classes.Point2D? origin, double width, double height, DiGi.Geometry.Planar.Classes.Vector2D? heightDirection, int widthCount, int heightCount);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the grid\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The total width of the grid\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The total height of the grid\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int).heightDirection'></a>

`heightDirection` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction of the height axis\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int).widthCount'></a>

`widthCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of cells in the width direction\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D,int,int).heightCount'></a>

`heightCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of cells in the height direction\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Rectangle2D,int,int)'></a>

## Grid2D\(Rectangle2D, int, int\) Constructor

Initializes a new instance of the [Grid2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D') class\.

```csharp
public Grid2D(DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D, int widthCount, int heightCount);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Rectangle2D,int,int).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The bounding rectangle of the grid\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Rectangle2D,int,int).widthCount'></a>

`widthCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of cells in the width direction\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(DiGi.Geometry.Planar.Classes.Rectangle2D,int,int).heightCount'></a>

`heightCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of cells in the height direction\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(System.Text.Json.Nodes.JsonObject)'></a>

## Grid2D\(JsonObject\) Constructor

Initializes a new instance of the [Grid2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D') class from a JSON object\.

```csharp
public Grid2D(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Grid2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing grid data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Grid2D.HeightCount'></a>

## Grid2D\.HeightCount Property

Gets the number of cells in the height direction\.

```csharp
public int HeightCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Planar.Classes.Grid2D.HeightFactor'></a>

## Grid2D\.HeightFactor Property

Gets the height of a single cell in the grid\.

```csharp
public double HeightFactor { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Rectangle2D'></a>

## Grid2D\.Rectangle2D Property

Gets the bounding rectangle of the grid\.

```csharp
public DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D { get; }
```

#### Property Value
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

<a name='DiGi.Geometry.Planar.Classes.Grid2D.this[int,int]'></a>

## Grid2D\.this\[int, int\] Property

Gets the rectangle at the specified grid indices\.

```csharp
public DiGi.Geometry.Planar.Classes.Rectangle2D? this[int index_width, int index_height] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.this[int,int].index_width'></a>

`index_width` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index along the width axis\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.this[int,int].index_height'></a>

`index_height` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index along the height axis\.

#### Property Value
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

<a name='DiGi.Geometry.Planar.Classes.Grid2D.WidthCount'></a>

## Grid2D\.WidthCount Property

Gets the number of cells in the width direction\.

```csharp
public int WidthCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Planar.Classes.Grid2D.WidthFactor'></a>

## Grid2D\.WidthFactor Property

Gets the width of a single cell in the grid\.

```csharp
public double WidthFactor { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Grid2D.GetRectangle(int,int)'></a>

## Grid2D\.GetRectangle\(int, int\) Method

Gets the rectangle at the specified grid indices\.

```csharp
public DiGi.Geometry.Planar.Classes.Rectangle2D? GetRectangle(int index_width, int index_height);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.GetRectangle(int,int).index_width'></a>

`index_width` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index along the width axis\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.GetRectangle(int,int).index_height'></a>

`index_height` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index along the height axis\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
The [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Grid2D.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Grid2D\.Rectangle2D') at the specified position, or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.GetRectangles()'></a>

## Grid2D\.GetRectangles\(\) Method

Gets all rectangles in the grid\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Rectangle2D>? GetRectangles();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all cell rectangles, or null if the grid is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Grid2D\.Move\(Vector2D\) Method

Moves the grid by the specified vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The movement vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Grid2D\.Transform\(ITransform2D\) Method

Transforms the grid using the specified transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Grid2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D'></a>

## IntersectionResult2D Class

Represents the result of a 2D intersection operation\.

```csharp
public class IntersectionResult2D : DiGi.Geometry.Planar.Classes.BooleanOperationResult2D, DiGi.Geometry.Planar.Interfaces.IIntersectionResult2D, DiGi.Geometry.Core.Interfaces.IIntersectionResult, DiGi.Geometry.Core.Interfaces.IBooleanOperationResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') → IntersectionResult2D

Implements [IIntersectionResult2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IIntersectionResult2D 'DiGi\.Geometry\.Planar\.Interfaces\.IIntersectionResult2D'), [DiGi\.Geometry\.Core\.Interfaces\.IIntersectionResult](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iintersectionresult 'DiGi\.Geometry\.Core\.Interfaces\.IIntersectionResult'), [IBooleanOperationResult](DiGi.Geometry.Core.Interfaces.md#DiGi.Geometry.Core.Interfaces.IBooleanOperationResult 'DiGi\.Geometry\.Core\.Interfaces\.IBooleanOperationResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D()'></a>

## IntersectionResult2D\(\) Constructor

Initializes a new instance of the [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') class\.

```csharp
public IntersectionResult2D();
```

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(DiGi.Geometry.Planar.Classes.IntersectionResult2D)'></a>

## IntersectionResult2D\(IntersectionResult2D\) Constructor

Initializes a new instance of the [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') class using another [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') instance\.

```csharp
public IntersectionResult2D(DiGi.Geometry.Planar.Classes.IntersectionResult2D? intersectionResult2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(DiGi.Geometry.Planar.Classes.IntersectionResult2D).intersectionResult2D'></a>

`intersectionResult2D` [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')

The [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') instance to copy from\.

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## IntersectionResult2D\(IGeometry2D\) Constructor

Initializes a new instance of the [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') class with the specified [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

```csharp
public IntersectionResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') to initialize the result with\. This value can be null\.

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## IntersectionResult2D\(IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') class\.

```csharp
public IntersectionResult2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects to be cloned and stored in the result\.

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool)'></a>

## IntersectionResult2D\(List\<IGeometry2D\>, bool\) Constructor

Initializes a new instance of the [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') class from a prebuilt list of geometries\.

```csharp
internal IntersectionResult2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of geometries resulting from the intersection\.

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), each geometry is cloned defensively; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied list is adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created geometries that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Text.Json.Nodes.JsonObject)'></a>

## IntersectionResult2D\(JsonObject\) Constructor

Initializes a new instance of the [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public IntersectionResult2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.IntersectionResult2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.BooleanOpertaionType'></a>

## IntersectionResult2D\.BooleanOpertaionType Property

Gets the type of the boolean operation, which is [Intersection](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType.Intersection 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType\.Intersection')\.

```csharp
public override DiGi.Geometry.Core.Enums.BooleanOpertaionType BooleanOpertaionType { get; }
```

Implements [BooleanOpertaionType](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.BooleanOpertaionType 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.BooleanOpertaionType')

#### Property Value
[BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')
### Methods

<a name='DiGi.Geometry.Planar.Classes.IntersectionResult2D.Clone()'></a>

## IntersectionResult2D\.Clone\(\) Method

Creates a copy of the current [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object\.

<a name='DiGi.Geometry.Planar.Classes.Line2D'></a>

## Line2D Class

Represents an infinite line in 2D space defined by an origin point and a direction vector\.

```csharp
public class Line2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.ILinear2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IGeometry2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Line2D

Implements [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Line2D.Line2D(DiGi.Geometry.Planar.Classes.Line2D)'></a>

## Line2D\(Line2D\) Constructor

Initializes a new instance of the [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') class by cloning an existing line\.

```csharp
public Line2D(DiGi.Geometry.Planar.Classes.Line2D? line2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Line2D(DiGi.Geometry.Planar.Classes.Line2D).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The source line to clone\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Line2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Line2D\(Point2D, Vector2D\) Constructor

Initializes a new instance of the [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') class with a specified origin and direction\.

```csharp
public Line2D(DiGi.Geometry.Planar.Classes.Point2D? origin, DiGi.Geometry.Planar.Classes.Vector2D? direction);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Line2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Line2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).direction'></a>

`direction` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction vector of the line\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Line2D.Direction'></a>

## Line2D\.Direction Property

Gets or sets the unit direction vector of the line\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Direction { get; set; }
```

Implements [Direction](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Direction 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Direction')

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

<a name='DiGi.Geometry.Planar.Classes.Line2D.Origin'></a>

## Line2D\.Origin Property

Gets or sets the origin point of the line\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Origin { get; set; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Line2D.Clone()'></a>

## Line2D\.Clone\(\) Method

Creates a clone of the current line\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Line2D\.ClosestPoint\(Point2D\) Method

Finds the point on the line closest to the given point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

Implements [ClosestPoint\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.ClosestPoint\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected point on the line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Line2D\.Collinear\(ILinear2D, double\) Method

Checks if another linear geometry is collinear with this line\.

```csharp
public bool Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D'></a>

`linear2D` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The linear geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [Collinear\(ILinear2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Collinear\(DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they are collinear; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Line2D\.Distance\(Point2D\) Method

Calculates the shortest distance from a point to the line\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

Implements [Distance\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Distance(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Distance\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The perpendicular distance to the line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Equals(object)'></a>

## Line2D\.Equals\(object\) Method

Determines whether the specified object is equal to the current line\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current line\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.GetHashCode()'></a>

## Line2D\.GetHashCode\(\) Method

Gets the hash code for this line\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Line2D,double)'></a>

## Line2D\.IntersectionPoint\(Line2D, double\) Method

Calculates the intersection point of two lines\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Line2D? line2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Line2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The other line to intersect with\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Line2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The intersection point, or null if they are parallel or collinear\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Line2D\.IntersectionPoint\(Segment2D, double\) Method

Calculates the intersection point of a line and a segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment to intersect with\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The intersection point, or null if no intersection exists within the segment boundaries\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Inverse()'></a>

## Line2D\.Inverse\(\) Method

Reverses the direction of the line\.

```csharp
public bool Inverse();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the direction was successfully reversed\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Line2D\.Move\(Vector2D\) Method

Moves the line by translating its origin point\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Line2D\.On\(Point2D, double\) Method

Checks if a point lies on the line within the specified tolerance\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [On\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.On(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.On\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the line; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(double,double,double)'></a>

## Line2D\.On\(double, double, double\) Method

Checks if the point given by its coordinates lies on the line within the specified tolerance, without allocating\.

```csharp
internal bool On(double x, double y, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the point to check\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the point to check\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.On(double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the line; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Project(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Line2D\.Project\(Point2D\) Method

Projects a point onto the line\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Project(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

Implements [Project\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Project(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Project\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected point on the line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Line2D\.Transform\(ITransform2D\) Method

Transforms the line using the specified transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.TryGetCoordinates(double,double,double,double)'></a>

## Line2D\.TryGetCoordinates\(double, double, double, double\) Method

Gets the origin and direction coordinates of the line without allocating intermediate objects\.

```csharp
internal bool TryGetCoordinates(out double x_Origin, out double y_Origin, out double x_Direction, out double y_Direction);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.TryGetCoordinates(double,double,double,double).x_Origin'></a>

`x_Origin` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the X coordinate of the origin point\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.TryGetCoordinates(double,double,double,double).y_Origin'></a>

`y_Origin` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the Y coordinate of the origin point\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.TryGetCoordinates(double,double,double,double).x_Direction'></a>

`x_Direction` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the X component of the direction vector\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.TryGetCoordinates(double,double,double,double).y_Direction'></a>

`y_Direction` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the Y component of the direction vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the line has a valid origin and direction; otherwise, false\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_Equality(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D)'></a>

## Line2D\.operator ==\(Line2D, Line2D\) Operator

Determines whether two lines are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Planar.Classes.Line2D? line2D_1, DiGi.Geometry.Planar.Classes.Line2D? line2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_Equality(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D).line2D_1'></a>

`line2D_1` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The first line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_Equality(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D).line2D_2'></a>

`line2D_2` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The second line\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the lines are equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_ExplicitDiGi.Geometry.Planar.Classes.Line2D(DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Line2D\.explicit operator Line2D\(Segment2D\) Operator

Explicitly converts a segment to a line that extends infinitely in both directions along the segment's axis\.

```csharp
public static DiGi.Geometry.Planar.Classes.Line2D? explicit operator DiGi.Geometry.Planar.Classes.Line2D?(DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_ExplicitDiGi.Geometry.Planar.Classes.Line2D(DiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The source segment\.

#### Returns
[Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')  
A Line2D representation of the infinite line containing the segment\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_Inequality(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D)'></a>

## Line2D\.operator \!=\(Line2D, Line2D\) Operator

Determines whether two lines are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Planar.Classes.Line2D? line2D_1, DiGi.Geometry.Planar.Classes.Line2D? line2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_Inequality(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D).line2D_1'></a>

`line2D_1` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The first line\.

<a name='DiGi.Geometry.Planar.Classes.Line2D.op_Inequality(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D).line2D_2'></a>

`line2D_2` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The second line\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the lines are not equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D'></a>

## Mesh2D Class

Represents a two\-dimensional mesh composed of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') elements, implementing 2D geometry, bounding, and collection interfaces\.

```csharp
public class Mesh2D : DiGi.Geometry.Core.Classes.Mesh<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Geometry\.Core\.Classes\.Mesh&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') → Mesh2D

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(DiGi.Geometry.Planar.Classes.Mesh2D)'></a>

## Mesh2D\(Mesh2D\) Constructor

Initializes a new instance of the [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') class by cloning an existing mesh\.

```csharp
public Mesh2D(DiGi.Geometry.Planar.Classes.Mesh2D? mesh2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(DiGi.Geometry.Planar.Classes.Mesh2D).mesh2D'></a>

`mesh2D` [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')

The source mesh to clone\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.IEnumerable_int[]_)'></a>

## Mesh2D\(IEnumerable\<Point2D\>, IEnumerable\<int\[\]\>\) Constructor

Initializes a new instance of the [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') class with specified points and indices\.

```csharp
public Mesh2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? points, System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.IEnumerable_int[]_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of vertices\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The index arrays defining triangles\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.List_int[]_,bool)'></a>

## Mesh2D\(List\<Point2D\>, List\<int\[\]\>, bool\) Constructor

Initializes a new instance of the [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') class from prebuilt lists\.

```csharp
internal Mesh2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, System.Collections.Generic.List<int[]>? indexes, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.List_int[]_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the vertices of the mesh\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.List_int[]_,bool).indexes'></a>

`indexes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of `int[]` defining the triangle indices of the mesh\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,System.Collections.Generic.List_int[]_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the inputs are defensively copied and validated; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied lists are adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created, valid data that is not shared\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Text.Json.Nodes.JsonObject)'></a>

## Mesh2D\(JsonObject\) Constructor

Initializes a new instance of the [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') class from a JSON object\.

```csharp
public Mesh2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Mesh2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing mesh data\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Clone()'></a>

## Mesh2D\.Clone\(\) Method

Creates a clone of the current mesh\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the mesh\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetArea()'></a>

## Mesh2D\.GetArea\(\) Method

Calculates the total area of the mesh as the sum of the areas of its triangles\.

Uses scalar coordinate arithmetic only, without allocating intermediate objects.

```csharp
public double GetArea();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the total area, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the points or indexes are unavailable\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetAuxiliarySegments()'></a>

## Mesh2D\.GetAuxiliarySegments\(\) Method

Retrieves the auxiliary segments of the mesh\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetAuxiliarySegments();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of auxiliary segments, or null if the mesh is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetBoundaryEdges()'></a>

## Mesh2D\.GetBoundaryEdges\(\) Method

Retrieves the boundary edges of the mesh as polygons\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? GetBoundaryEdges();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of polygons forming the boundary, or null if the mesh is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetBoundaryEdges(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_)'></a>

## Mesh2D\.GetBoundaryEdges\(List\<Segment2D\>\) Method

Retrieves the boundary edges of the mesh as polygons and returns auxiliary segments via an out parameter\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? GetBoundaryEdges(out System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? auxiliarySegments);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetBoundaryEdges(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_).auxiliarySegments'></a>

`auxiliarySegments` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The output list of auxiliary segments\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of polygons forming the boundary, or null if the mesh is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetBoundingBox()'></a>

## Mesh2D\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the mesh\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The bounding box encompassing all points in the mesh\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetSegments()'></a>

## Mesh2D\.GetSegments\(\) Method

Retrieves all unique segments \(edges\) of the mesh\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all edges in the mesh, or null if the mesh is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetTriangle(int)'></a>

## Mesh2D\.GetTriangle\(int\) Method

Retrieves the triangle at the specified index\.

```csharp
public DiGi.Geometry.Planar.Classes.Triangle2D? GetTriangle(int index);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetTriangle(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the triangle\.

#### Returns
[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')  
The Triangle2D at the specified index, or null if out of range\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.GetTriangles()'></a>

## Mesh2D\.GetTriangles\(\) Method

Retrieves all triangles in the mesh\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? GetTriangles();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all Triangle2D objects in the mesh, or null if the mesh is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Mesh2D\.Move\(Vector2D\) Method

Moves the mesh by translating all its vertices\.

```csharp
public bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Mesh2D\.Transform\(ITransform2D\) Method

Transforms the mesh by transforming all its vertices\.

```csharp
public bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Mesh2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.Point2D'></a>

## Point2D Class

Represents a point in 2D space defined by X and Y coordinates\.

```csharp
public class Point2D : DiGi.Geometry.Planar.Classes.Coordinate2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IPoint<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.IPoint
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') → [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') → Point2D

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IPoint](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint 'DiGi\.Geometry\.Core\.Interfaces\.IPoint')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Point2D\(Point2D\) Constructor

Initializes a new instance of the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') class by cloning an existing point\.

```csharp
public Point2D(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source point to clone\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(double,double)'></a>

## Point2D\(double, double\) Constructor

Initializes a new instance of the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') class with specified X and Y coordinates\.

```csharp
public Point2D(double x, double y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(double[])'></a>

## Point2D\(double\[\]\) Constructor

Initializes a new instance of the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') class using an array of values\.

```csharp
public Point2D(double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array containing coordinate values\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(System.Text.Json.Nodes.JsonObject)'></a>

## Point2D\(JsonObject\) Constructor

Initializes a new instance of the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') class from a JSON object\.

```csharp
public Point2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.Point2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing point data\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Point2D.Clone()'></a>

## Point2D\.Clone\(\) Method

Creates a clone of the current point\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Point2D\.Distance\(Point2D\) Method

Calculates the distance between this point and another point\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The other point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance result, or NaN if the input is null\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.GetAbs()'></a>

## Point2D\.GetAbs\(\) Method

Gets a new point with absolute values of the coordinates\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetAbs();
```

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') with absolute coordinate values\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.GetMoved(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Point2D\.GetMoved\(Vector2D\) Method

Returns a new point moved by the specified vector\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetMoved(DiGi.Geometry.Planar.Classes.Vector2D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.GetMoved(DiGi.Geometry.Planar.Classes.Vector2D).vector3D'></a>

`vector3D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The movement vector\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') shifted by the vector, or null if input is null\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.InDistance(DiGi.Geometry.Planar.Classes.Point2D,double,double)'></a>

## Point2D\.InDistance\(Point2D, double, double\) Method

Checks if another point is within a specified distance from this point\.

```csharp
public bool InDistance(DiGi.Geometry.Planar.Classes.Point2D? point2D, double distance, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.InDistance(DiGi.Geometry.Planar.Classes.Point2D,double,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The other point to check\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.InDistance(DiGi.Geometry.Planar.Classes.Point2D,double,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum distance\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.InDistance(DiGi.Geometry.Planar.Classes.Point2D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within the specified distance; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.Mid(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Point2D\.Mid\(Point2D\) Method

Calculates the midpoint between this point and another point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Mid(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.Mid(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The other point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the midpoint, or null if input is null\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Point2D.op_Addition(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Point2D\.operator \+\(Point2D, Vector2D\) Operator

Adds a vector to a point to produce a new point\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? operator +(DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.op_Addition(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.op_Addition(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new Point2D shifted by the vector, or null if either input is null\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.op_Subtraction(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Point2D\.operator \-\(Point2D, Vector2D\) Operator

Subtracts a vector from a point to produce a new point\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? operator -(DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Point2D.op_Subtraction(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point\.

<a name='DiGi.Geometry.Planar.Classes.Point2D.op_Subtraction(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new Point2D shifted by the negative of the vector, or null if either input is null\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D'></a>

## Polygon2D Class

Represents a 2D polygon defined by a collection of vertices\.

```csharp
public class Polygon2D : DiGi.Geometry.Planar.Classes.Segmentable2D, DiGi.Geometry.Planar.Interfaces.IPolygon2D, DiGi.Geometry.Planar.Interfaces.IPolygonal2D, DiGi.Geometry.Planar.Interfaces.IClosedCurve2D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ISegmentable2D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Planar.Interfaces.IInvertible2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') → Polygon2D

Derived  
↳ [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygon2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D'), [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D'), [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D()'></a>

## Polygon2D\(\) Constructor

Initializes a new instance of the [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') class\.

```csharp
public Polygon2D();
```

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(DiGi.Geometry.Planar.Classes.Polygon2D)'></a>

## Polygon2D\(Polygon2D\) Constructor

Initializes a new instance of the [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') class by cloning an existing polygon\.

```csharp
public Polygon2D(DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(DiGi.Geometry.Planar.Classes.Polygon2D).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The source polygon to clone\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Polygon2D\(IPolygonal2D\) Constructor

Initializes a new instance of the [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') class from another polygonal geometry\.

```csharp
public Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The source polygonal geometry\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Polygon2D\(IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') class defined by a collection of points\.

```csharp
public Polygon2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The vertices of the polygon\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Polygon2D\(List\<Point2D\>, bool\) Constructor

Initializes a new instance of the [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') class from a prebuilt list of points\.

```csharp
internal Polygon2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The vertices of the polygon\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the points are defensively cloned; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied list is adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created points that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Text.Json.Nodes.JsonObject)'></a>

## Polygon2D\(JsonObject\) Constructor

Initializes a new instance of the [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') class from a JSON object\.

```csharp
public Polygon2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Polygon2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing polygon data\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Clone()'></a>

## Polygon2D\.Clone\(\) Method

Creates a clone of the current polygon\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the polygon\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.GetArea()'></a>

## Polygon2D\.GetArea\(\) Method

Calculates the area of the polygon\.

```csharp
public virtual double GetArea();
```

Implements [GetArea\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetArea() 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetArea\(\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the polygon\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.GetCentroid()'></a>

## Polygon2D\.GetCentroid\(\) Method

Gets the centroid of the polygon\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetCentroid();
```

Implements [GetCentroid\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.GetCentroid() 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.GetCentroid\(\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The center point of the polygon, or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.GetInternalPoint(double)'></a>

## Polygon2D\.GetInternalPoint\(double\) Method

Gets a point guaranteed to be inside the polygon boundaries\.

```csharp
public virtual DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

Implements [GetInternalPoint\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetInternalPoint(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetInternalPoint\(double\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
An internal point of the polygon, or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.GetPerimeter()'></a>

## Polygon2D\.GetPerimeter\(\) Method

Gets the perimeter length of the polygon\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The total length of the boundary\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.GetSegments()'></a>

## Polygon2D\.GetSegments\(\) Method

Gets the segments that form the boundary of the polygon\.

```csharp
public override System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

Implements [GetSegments\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D.GetSegments() 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\.GetSegments\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of boundary segments\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## Polygon2D\.InRange\(BoundingBox2D, double\) Method

Checks if a bounding box is within or intersects the polygon\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to check\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [InRange\(BoundingBox2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they intersect or overlap; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Polygon2D\.InRange\(Point2D, double\) Method

Checks if a point is within or on the boundary of the polygon\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [InRange\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Polygon2D\.InRange\(ISegmentable2D, double\) Method

Checks if a segmentable geometry is within or intersects the polygon boundaries\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [InRange\(ISegmentable2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.InRange\(DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any part of the geometry is in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Polygon2D\.Inside\(Point2D, double\) Method

Checks if a point is strictly inside the polygon boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [Inside\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.Inside\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is strictly inside; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Polygon2D\.Inside\(ISegmentable2D, double\) Method

Checks if a segmentable geometry is strictly inside the polygon boundaries\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The geometry to check\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [Inside\(ISegmentable2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.Inside\(DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if all points of the geometry are strictly inside; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Triangulate(double)'></a>

## Polygon2D\.Triangulate\(double\) Method

Triangulates the polygon into a set of triangles\.

```csharp
public virtual System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygon2D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

Implements [Triangulate\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Triangulate(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.Triangulate\(double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Triangle2D objects representing the triangulated polygon, or null if it cannot be triangulated\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater'></a>

## Polygonal2DNormalizationUpdater Class

Provides functionality to update and verify the normalization of a 2D polygonal geometry based on a specified orientation\.

```csharp
public class Polygonal2DNormalizationUpdater : DiGi.Geometry.Core.Classes.GeometryUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Core.Interfaces.INormalizationUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → Polygonal2DNormalizationUpdater

Implements [DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater.Polygonal2DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation)'></a>

## Polygonal2DNormalizationUpdater\(Orientation\) Constructor

Initializes a new instance of the [Polygonal2DNormalizationUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater 'DiGi\.Geometry\.Planar\.Classes\.Polygonal2DNormalizationUpdater') class\.

```csharp
public Polygonal2DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater.Polygonal2DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') that the polygonal 2D object should be normalized to\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater.Normalized()'></a>

## Polygonal2DNormalizationUpdater\.Normalized\(\) Method

Determines whether the current value is normalized based on the specified orientation\.

```csharp
public bool Normalized();
```

Implements [Normalized\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1.normalized 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1\.Normalized')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating true if the value is normalized; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater.Update()'></a>

## Polygonal2DNormalizationUpdater\.Update\(\) Method

Updates the orientation of the value\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update was successful; returns `false` if the value is null\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver'></a>

## Polygonal2DSelfIntersectionSolver Class

Solves self\-intersections for a 2D polygonal geometry\.

```csharp
public class Polygonal2DSelfIntersectionSolver : DiGi.Geometry.Core.Interfaces.IOneToOneGeometrySolver<DiGi.Geometry.Planar.Interfaces.IPolygonal2D, DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Core.Interfaces.IGeometrySolver, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IOneToOneSolver<DiGi.Geometry.Planar.Interfaces.IPolygonal2D, DiGi.Geometry.Planar.Interfaces.IPolygonal2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Polygonal2DSelfIntersectionSolver

Implements [DiGi\.Geometry\.Core\.Interfaces\.IOneToOneGeometrySolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetoonegeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToOneGeometrySolver\`2')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetoonegeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToOneGeometrySolver\`2')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetoonegeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToOneGeometrySolver\`2'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometrySolver](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrysolver 'DiGi\.Geometry\.Core\.Interfaces\.IGeometrySolver'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IOneToOneSolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double)'></a>

## Polygonal2DSelfIntersectionSolver\(IPolygonal2D, double, double\) Constructor

Initializes a new instance of the [Polygonal2DSelfIntersectionSolver](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver 'DiGi\.Geometry\.Planar\.Classes\.Polygonal2DSelfIntersectionSolver') class\.

```csharp
public Polygonal2DSelfIntersectionSolver(DiGi.Geometry.Planar.Interfaces.IPolygonal2D input, double maxLength, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double).input'></a>

`input` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') input geometry to be analyzed for self\-intersections\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double).maxLength'></a>

`maxLength` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum length as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(double,double)'></a>

## Polygonal2DSelfIntersectionSolver\(double, double\) Constructor

Initializes a new instance of the [Polygonal2DSelfIntersectionSolver](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver 'DiGi\.Geometry\.Planar\.Classes\.Polygonal2DSelfIntersectionSolver') class\.

```csharp
public Polygonal2DSelfIntersectionSolver(double maxLength, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(double,double).maxLength'></a>

`maxLength` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum length as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Polygonal2DSelfIntersectionSolver(double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Input'></a>

## Polygonal2DSelfIntersectionSolver\.Input Property

Gets or sets the input [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Input { set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2.input 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2\.Input')

#### Property Value
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Output'></a>

## Polygonal2DSelfIntersectionSolver\.Output Property

Gets the resulting [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object produced by the solver\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Output { get; }
```

Implements [Output](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2.output 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2\.Output')

#### Property Value
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance, or null if no output has been generated or the solve operation failed\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Polygonal2DSelfIntersectionSolver.Solve()'></a>

## Polygonal2DSelfIntersectionSolver\.Solve\(\) Method

Attempts to solve for self\-intersecting polygons based on the input data, maximum length, and tolerance\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether a solution was successfully found\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D'></a>

## PolygonalFace2D Class

Represents a two\-dimensional polygonal face defined by an external edge and a collection of internal edges\.

```csharp
public class PolygonalFace2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D, DiGi.Geometry.Planar.Interfaces.IFace2D<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Planar.Interfaces.IFace2D, DiGi.Geometry.Core.Interfaces.IFace, DiGi.Geometry.Core.Interfaces.ISurface, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.ISurface2D, DiGi.Geometry.Core.Interfaces.IFace<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Planar.Interfaces.IInvertible2D, DiGi.Geometry.Core.Interfaces.IInvertible
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → PolygonalFace2D

Implements [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IFace2D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iface2d-1 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iface2d-1 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\`1'), [IFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D'), [DiGi\.Geometry\.Core\.Interfaces\.IFace](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface 'DiGi\.Geometry\.Core\.Interfaces\.IFace'), [DiGi\.Geometry\.Core\.Interfaces\.ISurface](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isurface 'DiGi\.Geometry\.Core\.Interfaces\.ISurface'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D'), [DiGi\.Geometry\.Core\.Interfaces\.IFace&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## PolygonalFace2D\(PolygonalFace2D\) Constructor

Initializes a new instance of the [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') class by cloning an existing polygonal face\.

```csharp
public PolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The source polygonal face to clone\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_)'></a>

## PolygonalFace2D\(IPolygonal2D, IEnumerable\<IPolygonal2D\>\) Constructor

Initializes a new instance of the [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') class with specified external and internal edges\.

```csharp
internal PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? externalEdge, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? internalEdges=null);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_).externalEdge'></a>

`externalEdge` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The outer boundary of the face\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_).internalEdges'></a>

`internalEdges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The inner boundaries \(holes\) of the face\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,bool)'></a>

## PolygonalFace2D\(IPolygonal2D, List\<IPolygonal2D\>, bool\) Constructor

Initializes a new instance of the [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') class from prebuilt edges\.

```csharp
internal PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? externalEdge, System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? internalEdges, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,bool).externalEdge'></a>

`externalEdge` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The outer boundary of the face\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,bool).internalEdges'></a>

`internalEdges` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The inner boundaries \(holes\) of the face\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the edges are defensively cloned; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied edges are adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created edges that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(System.Text.Json.Nodes.JsonObject)'></a>

## PolygonalFace2D\(JsonObject\) Constructor

Initializes a new instance of the [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') class from a JSON object\.

```csharp
public PolygonalFace2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.PolygonalFace2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing polygonal face data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Edges'></a>

## PolygonalFace2D\.Edges Property

Gets all edges of the polygonal face, including both external and internal boundaries\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? Edges { get; }
```

Implements [Edges](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Edges 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D\.Edges')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.ExternalEdge'></a>

## PolygonalFace2D\.ExternalEdge Property

Gets the external boundary of the polygonal face\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IPolygonal2D? ExternalEdge { get; }
```

Implements [ExternalEdge](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1.externaledge 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1\.ExternalEdge')

#### Property Value
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.InternalEdges'></a>

## PolygonalFace2D\.InternalEdges Property

Gets the internal boundaries \(holes\) of the polygonal face\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? InternalEdges { get; }
```

Implements [InternalEdges](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1.internaledges 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1\.InternalEdges')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Clone()'></a>

## PolygonalFace2D\.Clone\(\) Method

Creates a clone of the current polygonal face\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the polygonal face\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## PolygonalFace2D\.ClosestPoint\(Point2D, double\) Method

Finds the point on the polygonal face closest to the given point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [ClosestPoint\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\.ClosestPoint\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest point on the face \(including its interior\), or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.GetArea()'></a>

## PolygonalFace2D\.GetArea\(\) Method

Calculates the area of the polygonal face \(external area minus internal hole areas\)\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface.getarea 'DiGi\.Geometry\.Core\.Interfaces\.IFace\.GetArea')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The net area of the face\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.GetBoundingBox()'></a>

## PolygonalFace2D\.GetBoundingBox\(\) Method

Gets the axis\-aligned bounding box of the polygonal face\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The bounding box based on the external boundary\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.GetInternalPoint(double)'></a>

## PolygonalFace2D\.GetInternalPoint\(double\) Method

Gets a point guaranteed to be inside the polygonal face \(outside of any holes\)\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

Implements [GetInternalPoint\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D.GetInternalPoint(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\.GetInternalPoint\(double\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
An internal point of the face, or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## PolygonalFace2D\.InRange\(Point2D, double\) Method

Checks if a point is within or on the boundary of the polygonal face\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [InRange\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## PolygonalFace2D\.Inside\(Point2D, double\) Method

Checks if a point is strictly inside the polygonal face \(excluding boundaries and holes\)\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [Inside\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\.Inside\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is strictly inside; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Inverse()'></a>

## PolygonalFace2D\.Inverse\(\) Method

Reverses the orientation of both external and internal boundaries\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if at least one boundary was successfully reversed\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## PolygonalFace2D\.Move\(Vector2D\) Method

Moves the polygonal face by translating its boundaries\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## PolygonalFace2D\.OnEdge\(Point2D, double\) Method

Checks if a point lies on any of the edges \(external or internal\) of the face\.

```csharp
public bool OnEdge(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [OnEdge\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D\.OnEdge\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on an edge; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## PolygonalFace2D\.Orient\(Nullable\<Orientation\>, Nullable\<Orientation\>\) Method

Orients the external and internal boundaries of the face\.

```csharp
public bool Orient(System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The desired orientation for the external boundary\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The desired orientation for the internal boundaries\.

Implements [Orient\(Nullable&lt;Orientation&gt;, Nullable&lt;Orientation&gt;\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D\.Orient\(System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if at least one boundary was successfully oriented\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## PolygonalFace2D\.Transform\(ITransform2D\) Method

Transforms the polygonal face by transforming its boundaries\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Triangulate(double)'></a>

## PolygonalFace2D\.Triangulate\(double\) Method

Triangulates the polygonal face into a set of triangles\.

```csharp
public virtual System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

Implements [Triangulate\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Triangulate(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D\.Triangulate\(double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Triangle2D objects representing the triangulated face, or null if it cannot be triangulated\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver'></a>

## PolygonalFace2DInternalPointSolver Class

Provides a solver for calculating internal points within an [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')\.

```csharp
public class PolygonalFace2DInternalPointSolver : DiGi.Geometry.Core.Classes.InternalPointSolver<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D, DiGi.Geometry.Planar.Classes.Point2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.InternalPointSolver&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[,](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>') → PolygonalFace2DInternalPointSolver
### Constructors

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.PolygonalFace2DInternalPointSolver(double)'></a>

## PolygonalFace2DInternalPointSolver\(double\) Constructor

Initializes a new instance of the [PolygonalFace2DInternalPointSolver](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2DInternalPointSolver') class\.

```csharp
public PolygonalFace2DInternalPointSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.PolygonalFace2DInternalPointSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for calculations\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.PolygonalFace2DInternalPointSolver(int,double)'></a>

## PolygonalFace2DInternalPointSolver\(int, double\) Constructor

Initializes a new instance of the [PolygonalFace2DInternalPointSolver](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2DInternalPointSolver') class\.

```csharp
public PolygonalFace2DInternalPointSolver(int maxCount, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.PolygonalFace2DInternalPointSolver(int,double).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of points to solve for as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.PolygonalFace2DInternalPointSolver(int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used in calculations as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.Input'></a>

## PolygonalFace2DInternalPointSolver\.Input Property

Gets or sets the [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') used as the input for the operation\.

```csharp
public override DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? Input { set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.input 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Input')

#### Property Value
[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')  
The [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') instance that serves as the input\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver.Solve()'></a>

## PolygonalFace2DInternalPointSolver\.Solve\(\) Method

Attempts to solve the current problem instance based on the polygonal face and existing outputs\.

```csharp
public override bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the solution was successfully found; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the polygonal face is null, the maximum output count has been reached, or the external edge area is below the specified tolerance\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater'></a>

## PolygonalFace2DNormalizationUpdater Class

Updates the normalization of a 2D polygonal face based on specified edge orientations\.

```csharp
public class PolygonalFace2DNormalizationUpdater : DiGi.Geometry.Core.Classes.GeometryUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>, DiGi.Geometry.Core.Interfaces.INormalizationUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → PolygonalFace2DNormalizationUpdater

Implements [DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.PolygonalFace2DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation)'></a>

## PolygonalFace2DNormalizationUpdater\(Orientation\) Constructor

Initializes a new instance of the [PolygonalFace2DNormalizationUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2DNormalizationUpdater') class using the specified [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for both external and internal edges\.

```csharp
public PolygonalFace2DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.PolygonalFace2DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to be used for normalization of both external and internal edges\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.PolygonalFace2DNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## PolygonalFace2DNormalizationUpdater\(Nullable\<Orientation\>, Nullable\<Orientation\>\) Constructor

Initializes a new instance of the [PolygonalFace2DNormalizationUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2DNormalizationUpdater') class with the specified orientations for external and internal edges\.

```csharp
public PolygonalFace2DNormalizationUpdater(System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.PolygonalFace2DNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') used to validate the normalization of the external edge\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.PolygonalFace2DNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') used to validate the normalization of internal edges\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.Normalized()'></a>

## PolygonalFace2DNormalizationUpdater\.Normalized\(\) Method

Determines whether the current value is normalized based on the external and internal edge orientations\.

```csharp
public bool Normalized();
```

Implements [Normalized\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1.normalized 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1\.Normalized')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the value is normalized\.

<a name='DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater.Update()'></a>

## PolygonalFace2DNormalizationUpdater\.Update\(\) Method

Updates the orientation of the value based on the external and internal edge orientations\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update was successful; returns `false` if the value is null\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D'></a>

## Polyline2D Class

Represents a 2D polyline defined by a sequence of vertices\.

```csharp
public class Polyline2D : DiGi.Geometry.Planar.Classes.Segmentable2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') → Polyline2D
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D()'></a>

## Polyline2D\(\) Constructor

Initializes a new instance of the [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') class\.

```csharp
public Polyline2D();
```

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(DiGi.Geometry.Planar.Classes.Polyline2D)'></a>

## Polyline2D\(Polyline2D\) Constructor

Initializes a new instance of the [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') class by cloning an existing polyline\.

```csharp
public Polyline2D(DiGi.Geometry.Planar.Classes.Polyline2D? polyline2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(DiGi.Geometry.Planar.Classes.Polyline2D).polyline2D'></a>

`polyline2D` [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')

The source polyline to clone\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Polyline2D\(IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') class defined by a collection of points\.

```csharp
public Polyline2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The vertices of the polyline\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Polyline2D\(IEnumerable\<Point2D\>, bool\) Constructor

Initializes a new instance of the [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') class defined by vertices and whether it is closed\.

```csharp
public Polyline2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool close);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The vertices of the polyline\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).close'></a>

`close` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

True if the polyline should be closed by connecting the last point to the first\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Text.Json.Nodes.JsonObject)'></a>

## Polyline2D\(JsonObject\) Constructor

Initializes a new instance of the [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') class from a JSON object\.

```csharp
public Polyline2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Polyline2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing polyline data\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Clone()'></a>

## Polyline2D\.Clone\(\) Method

Creates a clone of the current polyline\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance of the polyline\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Close()'></a>

## Polyline2D\.Close\(\) Method

Closes the polyline by adding a point at the end that matches the start point\.

```csharp
public void Close();
```

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.GetSegments()'></a>

## Polyline2D\.GetSegments\(\) Method

Gets the segments that form the polyline boundary\.

```csharp
public override System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

Implements [GetSegments\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D.GetSegments() 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\.GetSegments\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of line segments\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.IsClosed()'></a>

## Polyline2D\.IsClosed\(\) Method

Checks if the polyline is closed \(start point equals end point\)\.

```csharp
public bool IsClosed();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if it is closed; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Polyline2D.Open()'></a>

## Polyline2D\.Open\(\) Method

Opens the polyline by removing the last point if it is closed\.

```csharp
public void Open();
```

<a name='DiGi.Geometry.Planar.Classes.Ray2D'></a>

## Ray2D Class

Represents a ray in two\-dimensional space, defined by an origin point and a direction vector\.

```csharp
public class Ray2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.ILinear2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IInvertible2D, DiGi.Geometry.Core.Interfaces.IInvertible
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Ray2D

Implements [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Ray2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Ray2D\(Point2D, Vector2D\) Constructor

Initializes a new instance of the [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') class with the specified origin and direction\.

```csharp
public Ray2D(DiGi.Geometry.Planar.Classes.Point2D? origin, DiGi.Geometry.Planar.Classes.Vector2D? direction);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Ray2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') that represents the starting point of the ray\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Ray2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).direction'></a>

`direction` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') that represents the direction of the ray\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Ray2D(DiGi.Geometry.Planar.Classes.Ray2D)'></a>

## Ray2D\(Ray2D\) Constructor

Initializes a new instance of the [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') class by copying the values from an existing [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance\.

```csharp
public Ray2D(DiGi.Geometry.Planar.Classes.Ray2D? ray2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Ray2D(DiGi.Geometry.Planar.Classes.Ray2D).ray2D'></a>

`ray2D` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance to copy from\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Direction'></a>

## Ray2D\.Direction Property

Gets or sets the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the direction\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Direction { get; set; }
```

Implements [Direction](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Direction 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Direction')

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A nullable [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') that specifies the direction\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Origin'></a>

## Ray2D\.Origin Property

Gets or sets the origin [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Origin { get; set; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the origin, or null if it is not specified\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Clone()'></a>

## Ray2D\.Clone\(\) Method

Creates a copy of the current [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Ray2D\.ClosestPoint\(Point2D\) Method

Calculates the closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the line to the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for which the closest point is calculated\.

Implements [ClosestPoint\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.ClosestPoint\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the origin or direction is not defined\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Ray2D\.Collinear\(ILinear2D, double\) Method

Determines whether this linear 2D object is collinear with the specified [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') object within a given tolerance\.

```csharp
public bool Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D'></a>

`linear2D` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') object to check for collinearity\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used to determine collinearity\.

Implements [Collinear\(ILinear2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Collinear\(DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two linear 2D objects are collinear\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Ray2D\.Distance\(Point2D\) Method

Calculates the distance from a specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to the ray\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance for which the distance is calculated\.

Implements [Distance\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Distance(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Distance\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is null, or if the ray's origin or direction are not defined\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Equals(object)'></a>

## Ray2D\.Equals\(object\) Method

Determines whether the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is equal to the current [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') to compare with the current [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is a [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') and has the same origin and direction as the current instance; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.GetHashCode()'></a>

## Ray2D\.GetHashCode\(\) Method

Returns a hash code for the current object based on the origin and direction\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the hash code of the instance\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Ray2D,double)'></a>

## Ray2D\.IntersectionPoint\(Ray2D, double\) Method

Calculates the intersection point between this ray and another specified [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Ray2D? ray2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Ray2D,double).ray2D'></a>

`ray2D` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The other [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') to intersect with\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Ray2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the intersection calculation and verification\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the intersection point if it exists within the specified tolerance; otherwise, null\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Ray2D\.IntersectionPoint\(Segment2D, double\) Method

Calculates the intersection point between this segment and another [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to check for an intersection\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for the intersection calculation\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') if an intersection point exists and lies on both segments; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Inverse()'></a>

## Ray2D\.Inverse\(\) Method

Inverts the current direction\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Ray2D\.Move\(Vector2D\) Method

Moves the object by the specified Vector2D\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The Vector2D that defines the movement offset\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move operation was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Ray2D\.On\(Point2D, double\) Method

Determines whether the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is on the object within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to evaluate\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

Implements [On\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.On(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.On\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the object within the specified tolerance\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Project(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Ray2D\.Project\(Point2D\) Method

Projects the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') onto the ray, clamping points behind the origin to the origin\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Project(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to project\.

Implements [Project\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Project(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Project\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the ray, or null if the input point or the ray is not properly defined\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Ray2D\.Transform\(ITransform2D\) Method

Transforms the object's origin and direction using the provided 2D transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') instance used to perform the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied; returns `false` if the [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') transform, origin, or direction is null\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_Equality(DiGi.Geometry.Planar.Classes.Ray2D,DiGi.Geometry.Planar.Classes.Ray2D)'></a>

## Ray2D\.operator ==\(Ray2D, Ray2D\) Operator

Indicates whether the two specified [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instances are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Planar.Classes.Ray2D? ray2D_1, DiGi.Geometry.Planar.Classes.Ray2D? ray2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_Equality(DiGi.Geometry.Planar.Classes.Ray2D,DiGi.Geometry.Planar.Classes.Ray2D).ray2D_1'></a>

`ray2D_1` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The first [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance to compare\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_Equality(DiGi.Geometry.Planar.Classes.Ray2D,DiGi.Geometry.Planar.Classes.Ray2D).ray2D_2'></a>

`ray2D_2` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The second [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the two rays are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_ExplicitDiGi.Geometry.Planar.Classes.Ray2D(DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Ray2D\.explicit operator Ray2D\(Segment2D\) Operator

Explicitly converts a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance to a [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Ray2D? explicit operator DiGi.Geometry.Planar.Classes.Ray2D?(DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_ExplicitDiGi.Geometry.Planar.Classes.Ray2D(DiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance to convert\.

#### Returns
[Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')  
A [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance derived from the specified segment, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_Inequality(DiGi.Geometry.Planar.Classes.Ray2D,DiGi.Geometry.Planar.Classes.Ray2D)'></a>

## Ray2D\.operator \!=\(Ray2D, Ray2D\) Operator

Indicates whether the two specified [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instances are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Planar.Classes.Ray2D? ray2D_1, DiGi.Geometry.Planar.Classes.Ray2D? ray2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_Inequality(DiGi.Geometry.Planar.Classes.Ray2D,DiGi.Geometry.Planar.Classes.Ray2D).ray2D_1'></a>

`ray2D_1` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The first [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance to compare\.

<a name='DiGi.Geometry.Planar.Classes.Ray2D.op_Inequality(DiGi.Geometry.Planar.Classes.Ray2D,DiGi.Geometry.Planar.Classes.Ray2D).ray2D_2'></a>

`ray2D_2` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The second [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') instance to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the two rays are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D'></a>

## Rectangle2D Class

Represents a two\-dimensional rectangle defined by its width and height\.

```csharp
public class Rectangle2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.IPolygonal2D, DiGi.Geometry.Planar.Interfaces.IClosedCurve2D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ISegmentable2D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Planar.Interfaces.IInvertible2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Rectangle2D

Implements [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D'), [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Rectangle2D\(BoundingBox2D\) Constructor

Initializes a new instance of the [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') class from a bounding box\.

```csharp
public Rectangle2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The source bounding box\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double)'></a>

## Rectangle2D\(Point2D, double, double\) Constructor

Initializes a new instance of the [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') class with specified origin, width, and height\.

```csharp
public Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D? origin, double width, double height);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Rectangle2D\(Point2D, double, double, Vector2D\) Constructor

Initializes a new instance of the [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') class with specified origin, width, height, and height direction vector\.

```csharp
public Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D? origin, double width, double height, DiGi.Geometry.Planar.Classes.Vector2D? heightDirection);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Planar.Classes.Vector2D).heightDirection'></a>

`heightDirection` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector defining the direction of the height\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Rectangle2D\(Rectangle2D\) Constructor

Initializes a new instance of the [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') class by cloning an existing rectangle\.

```csharp
public Rectangle2D(DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(DiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The source rectangle to clone\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(double,double)'></a>

## Rectangle2D\(double, double\) Constructor

Initializes a new instance of the [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') class with specified width and height at the origin\.

```csharp
public Rectangle2D(double width, double height);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(System.Text.Json.Nodes.JsonObject)'></a>

## Rectangle2D\(JsonObject\) Constructor

Initializes a new instance of the [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') class from a JSON object\.

```csharp
public Rectangle2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Rectangle2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing rectangle data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Height'></a>

## Rectangle2D\.Height Property

Gets or sets the height of the rectangle\.

```csharp
public double Height { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.HeightDirection'></a>

## Rectangle2D\.HeightDirection Property

Gets the unit vector defining the height direction of the rectangle\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? HeightDirection { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Length'></a>

## Rectangle2D\.Length Property

Gets the perimeter of the rectangle\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Origin'></a>

## Rectangle2D\.Origin Property

Gets or sets the origin point of the rectangle\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Origin { get; set; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Width'></a>

## Rectangle2D\.Width Property

Gets or sets the width of the rectangle\.

```csharp
public double Width { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.WidthDirection'></a>

## Rectangle2D\.WidthDirection Property

Gets the unit vector defining the width direction of the rectangle\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? WidthDirection { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Clone()'></a>

## Rectangle2D\.Clone\(\) Method

Creates a clone of the current rectangle\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') representing the cloned rectangle\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Rectangle2D\.ClosestPoint\(Point2D\) Method

Calculates the closest point on the rectangle to the specified point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest point on the rectangle's boundary or interior, or null if input is invalid\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetArea()'></a>

## Rectangle2D\.GetArea\(\) Method

Calculates the area of the rectangle\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetArea() 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetArea\(\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area as a double\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetBoundingBox()'></a>

## Rectangle2D\.GetBoundingBox\(\) Method

Generates a bounding box that encloses the rectangle\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') instance, or null if it cannot be created\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetCentroid()'></a>

## Rectangle2D\.GetCentroid\(\) Method

Calculates the centroid \(center point\) of the rectangle\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetCentroid();
```

Implements [GetCentroid\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.GetCentroid() 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.GetCentroid\(\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The centroid as a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D'), or null if it cannot be calculated\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetDiagonals()'></a>

## Rectangle2D\.GetDiagonals\(\) Method

Retrieves the diagonals of the rectangle as segments\.

```csharp
public DiGi.Geometry.Planar.Classes.Segment2D[]? GetDiagonals();
```

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of two [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') representing the diagonals, or null if points cannot be retrieved\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetInternalPoint(double)'></a>

## Rectangle2D\.GetInternalPoint\(double\) Method

Finds a point known to be inside the rectangle\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for internal checking\.

Implements [GetInternalPoint\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetInternalPoint(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.GetInternalPoint\(double\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') located within the rectangle, or null\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetPerimeter()'></a>

## Rectangle2D\.GetPerimeter\(\) Method

Calculates the perimeter of the rectangle\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The total length of the boundary\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetPoints()'></a>

## Rectangle2D\.GetPoints\(\) Method

Retrieves the four corner points of the rectangle\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the corners, or null if the origin is not set\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.GetSegments()'></a>

## Rectangle2D\.GetSegments\(\) Method

Retrieves the four boundary segments of the rectangle\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

Implements [GetSegments\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D.GetSegments() 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\.GetSegments\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') representing the sides, or null if points cannot be retrieved\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## Rectangle2D\.InRange\(BoundingBox2D, double\) Method

Checks if the specified bounding box is within range of the rectangle\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The target bounding box\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the range check\.

Implements [InRange\(BoundingBox2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the bounding box is in range, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Rectangle2D\.InRange\(Point2D, double\) Method

Checks if the specified point is within range of the rectangle's boundary or interior\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the range check\.

Implements [InRange\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.InRange\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Rectangle2D\.InRange\(ISegmentable2D, double\) Method

Checks if the specified segmentable object is within range of the rectangle's boundary or interior\.

```csharp
public bool InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The object to check\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the range check\.

Implements [InRange\(ISegmentable2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.InRange\(DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is in range, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Rectangle2D\.Inside\(Point2D, double\) Method

Checks if the specified point is strictly inside the rectangle\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the inside check\.

Implements [Inside\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D\.Inside\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is inside, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Rectangle2D\.Inside\(ISegmentable2D, double\) Method

Checks if the specified segmentable object is strictly inside the rectangle\.

```csharp
public bool Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The object to check\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the inside check\.

Implements [Inside\(ISegmentable2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.Inside\(DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is inside, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Inverse()'></a>

## Rectangle2D\.Inverse\(\) Method

Inverts the orientation of the rectangle by moving its origin to the opposite corner and reversing height direction\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if inversion was successful, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Rectangle2D\.Move\(Vector2D\) Method

Moves the rectangle by the specified vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if move was successful, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Rectangle2D\.On\(Point2D, double\) Method

Checks if the specified point lies on the boundary of the rectangle\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the boundary, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Rectangle2D\.Transform\(ITransform2D\) Method

Applies a 2D transformation to the rectangle\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transform to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if transformation was successful, otherwise false\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Triangulate(double)'></a>

## Rectangle2D\.Triangulate\(double\) Method

Splits the rectangle into two triangles\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for triangulation\.

Implements [Triangulate\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Triangulate(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.Triangulate\(double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of two [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D'), or null if it cannot be triangulated\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.op_ExplicitDiGi.Geometry.Planar.Classes.Polygon2D(DiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Rectangle2D\.explicit operator Polygon2D\(Rectangle2D\) Operator

Explicitly converts a Rectangle2D to a Polygon2D\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? explicit operator DiGi.Geometry.Planar.Classes.Polygon2D?(DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.op_ExplicitDiGi.Geometry.Planar.Classes.Polygon2D(DiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The rectangle to convert\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A new Polygon2D representing the rectangle, or null if conversion fails\.

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.op_ExplicitDiGi.Geometry.Planar.Classes.Rectangle2D(DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Rectangle2D\.explicit operator Rectangle2D\(BoundingBox2D\) Operator

Explicitly converts a BoundingBox2D to a Rectangle2D\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? explicit operator DiGi.Geometry.Planar.Classes.Rectangle2D?(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Rectangle2D.op_ExplicitDiGi.Geometry.Planar.Classes.Rectangle2D(DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to convert\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A new Rectangle2D instance, or null if the input is null\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D'></a>

## Segment2D Class

Represents a two\-dimensional line segment defined by a starting [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')\.

```csharp
public class Segment2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.IInvertible2D, DiGi.Geometry.Planar.Interfaces.ILinear2D, DiGi.Geometry.Core.Interfaces.ISegment<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegment
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Segment2D

Implements [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D'), [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegment&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegment](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment 'DiGi\.Geometry\.Core\.Interfaces\.ISegment')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Segment2D\(Point2D, Point2D\) Constructor

Initializes a new instance of the [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') class using start and end points\.

```csharp
public Segment2D(DiGi.Geometry.Planar.Classes.Point2D? start, DiGi.Geometry.Planar.Classes.Point2D? end);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).start'></a>

`start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The start point of the segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).end'></a>

`end` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The end point of the segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Segment2D\(Point2D, Vector2D\) Constructor

Initializes a new instance of the [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') class using a start point and a vector\.

```csharp
public Segment2D(DiGi.Geometry.Planar.Classes.Point2D? start, DiGi.Geometry.Planar.Classes.Vector2D? vector);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).start'></a>

`start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The start point of the segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).vector'></a>

`vector` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector defining the direction and length of the segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Segment2D\(Segment2D\) Constructor

Initializes a new instance of the [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') class by cloning an existing segment\.

```csharp
public Segment2D(DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(DiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The source segment to clone\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(double,double,double,double)'></a>

## Segment2D\(double, double, double, double\) Constructor

Initializes a new instance of the [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') class defined by start and end coordinates\.

```csharp
public Segment2D(double x_1, double y_1, double x_2, double y_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the start point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the start point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the end point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the end point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(System.Text.Json.Nodes.JsonObject)'></a>

## Segment2D\(JsonObject\) Constructor

Initializes a new instance of the [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') class from a JSON object\.

```csharp
public Segment2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Segment2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing segment data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Direction'></a>

## Segment2D\.Direction Property

Gets or sets the unit direction vector of the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Direction { get; set; }
```

Implements [Direction](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Direction 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Direction')

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

<a name='DiGi.Geometry.Planar.Classes.Segment2D.End'></a>

## Segment2D\.End Property

Gets or sets the end point of the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? End { get; set; }
```

Implements [End](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1.end 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1\.End')

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Length'></a>

## Segment2D\.Length Property

Gets or sets the length of the segment\.

```csharp
public double Length { get; set; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Segment2D.SquaredLength'></a>

## Segment2D\.SquaredLength Property

Gets the squared length of the segment\.

```csharp
public double SquaredLength { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Start'></a>

## Segment2D\.Start Property

Gets or sets the start point of the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Start { get; set; }
```

Implements [Start](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1.start 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1\.Start')

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.Segment2D.this[int]'></a>

## Segment2D\.this\[int\] Property

Gets the point at the specified index of the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the point to retrieve \(0 for the start point, 1 for the end point\)\.

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Vector'></a>

## Segment2D\.Vector Property

Gets or sets the vector defining the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Vector { get; set; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Clone()'></a>

## Segment2D\.Clone\(\) Method

Creates a clone of the current segment\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Segment2D\.ClosestPoint\(Point2D\) Method

Finds the point on the segment closest to the specified point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

Implements [ClosestPoint\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.ClosestPoint\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the segment, or null if input is null\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Segment2D\.Collinear\(ILinear2D, double\) Method

Checks if the segment is collinear with another linear geometry\.

```csharp
public bool Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D'></a>

`linear2D` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The other linear geometry\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

Implements [Collinear\(ILinear2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Collinear\(DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they are collinear; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Segment2D\.Distance\(Point2D\) Method

Calculates the minimum distance from a point to the segment\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

Implements [Distance\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Distance(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Distance\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance result, or NaN if input is null\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Equals(object)'></a>

## Segment2D\.Equals\(object\) Method

Determines whether the specified object is equal to the current segment\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.GetBoundingBox()'></a>

## Segment2D\.GetBoundingBox\(\) Method

Calculates the axis\-aligned bounding box of the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D'), or null if start or vector is null\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.GetHashCode()'></a>

## Segment2D\.GetHashCode\(\) Method

Gets the hash code for this segment\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.GetPoints()'></a>

## Segment2D\.GetPoints\(\) Method

Returns a list containing the start and end points of the segment\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of two points, or null if endpoints are missing\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.GetSegments()'></a>

## Segment2D\.GetSegments\(\) Method

Returns a list containing the current segment as its only element\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

Implements [GetSegments\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D.GetSegments() 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\.GetSegments\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of one [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Segment2D\.IntersectionPoint\(Segment2D, double\) Method

Finds the intersection point between this segment and another\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The other segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for detecting an intersection\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of intersection, or null if no intersection is found\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Inverse()'></a>

## Segment2D\.Inverse\(\) Method

Inverts the direction of the segment by swapping start and end points\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if inversion was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Mid()'></a>

## Segment2D\.Mid\(\) Method

Calculates the midpoint of the segment\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Mid();
```

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The midpoint as a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D'), or null if start or vector is missing\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Segment2D\.Move\(Vector2D\) Method

Moves the segment by the specified translation vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The movement vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if move was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Segment2D\.On\(Point2D, double\) Method

Checks if the specified point lies on the segment within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

Implements [On\(Point2D, double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.On(DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.On\(DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the segment; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(double,double,double)'></a>

## Segment2D\.On\(double, double, double\) Method

Checks if the point given by its coordinates lies on the segment within a given tolerance, without allocating\.

```csharp
internal bool On(double x, double y, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the target point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the target point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.On(double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the segment; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Project(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Segment2D\.Project\(Point2D\) Method

Projects a point onto the line containing the segment, without clamping to the segment boundaries\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Project(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

Implements [Project\(Point2D\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D.Project(DiGi.Geometry.Planar.Classes.Point2D) 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D\.Project\(DiGi\.Geometry\.Planar\.Classes\.Point2D\)')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the infinite line, or null if input is missing\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Segment2D\.Transform\(ITransform2D\) Method

Applies a 2D transformation to the segment's endpoints and vector\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transform to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if transformation was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.TryGetCoordinates(double,double,double,double)'></a>

## Segment2D\.TryGetCoordinates\(double, double, double, double\) Method

Gets the endpoint coordinates of the segment without allocating intermediate points\.

```csharp
internal bool TryGetCoordinates(out double x_Start, out double y_Start, out double x_End, out double y_End);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.TryGetCoordinates(double,double,double,double).x_Start'></a>

`x_Start` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the X coordinate of the start point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.TryGetCoordinates(double,double,double,double).y_Start'></a>

`y_Start` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the Y coordinate of the start point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.TryGetCoordinates(double,double,double,double).x_End'></a>

`x_End` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the X coordinate of the end point\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.TryGetCoordinates(double,double,double,double).y_End'></a>

`y_End` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns true, the Y coordinate of the end point\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the segment has a valid start point and vector; otherwise, false\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Segment2D.op_Equality(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Segment2D\.operator ==\(Segment2D, Segment2D\) Operator

Checks if two segments are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Planar.Classes.Segment2D? segment2D_1, DiGi.Geometry.Planar.Classes.Segment2D? segment2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.op_Equality(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D).segment2D_1'></a>

`segment2D_1` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The first segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.op_Equality(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D).segment2D_2'></a>

`segment2D_2` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The second segment\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the segments have the same start point and vector; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.op_Inequality(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Segment2D\.operator \!=\(Segment2D, Segment2D\) Operator

Checks if two segments are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Planar.Classes.Segment2D? segment2D_1, DiGi.Geometry.Planar.Classes.Segment2D? segment2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segment2D.op_Inequality(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D).segment2D_1'></a>

`segment2D_1` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The first segment\.

<a name='DiGi.Geometry.Planar.Classes.Segment2D.op_Inequality(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D).segment2D_2'></a>

`segment2D_2` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The second segment\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the segments are different; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D'></a>

## Segmentable2D Class

Base class for 2D geometries that can be represented as a collection of segments\.

```csharp
public abstract class Segmentable2D : DiGi.Geometry.Planar.Classes.Geometry2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.IInvertible2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → Segmentable2D

Derived  
↳ [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
↳ [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')

Implements [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D()'></a>

## Segmentable2D\(\) Constructor

Initializes a new instance of the [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') class\.

```csharp
public Segmentable2D();
```

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(DiGi.Geometry.Planar.Classes.Segmentable2D)'></a>

## Segmentable2D\(Segmentable2D\) Constructor

Initializes a new instance of the [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') class by cloning an existing segmentable geometry\.

```csharp
public Segmentable2D(DiGi.Geometry.Planar.Classes.Segmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(DiGi.Geometry.Planar.Classes.Segmentable2D).segmentable2D'></a>

`segmentable2D` [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D')

The source geometry to clone\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Segmentable2D\(IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') class defined by a collection of points\.

```csharp
public Segmentable2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The vertices of the geometry\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Segmentable2D\(List\<Point2D\>, bool\) Constructor

Initializes a new instance of the [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') class from a prebuilt list of points\.

```csharp
internal Segmentable2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The vertices of the geometry\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the points are defensively cloned; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied list is adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created points that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Text.Json.Nodes.JsonObject)'></a>

## Segmentable2D\(JsonObject\) Constructor

Initializes a new instance of the [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') class from a JSON object\.

```csharp
public Segmentable2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Segmentable2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing geometry data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Length'></a>

## Segmentable2D\.Length Property

Gets the total length of the segments that form the geometry\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Segmentable2D\.ClosestPoint\(Point2D\) Method

Gets the point on the geometry closest to the specified point\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest point on the geometry, or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Segmentable2D\.Distance\(Point2D\) Method

Calculates the shortest distance from the geometry to the specified point\.

```csharp
public double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance to the point, or NaN if it cannot be calculated\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.GetBoundingBox()'></a>

## Segmentable2D\.GetBoundingBox\(\) Method

Gets the bounding box of the geometry\.

```csharp
public DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox() 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D\.GetBoundingBox\(\)')

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The bounding box, or null if it cannot be determined\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.GetPoints()'></a>

## Segmentable2D\.GetPoints\(\) Method

Gets the collection of points that define the geometry\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A cloned list of vertices, or null if none exist\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.GetPoints(bool)'></a>

## Segmentable2D\.GetPoints\(bool\) Method

Gets the collection of points that define the geometry\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? GetPoints(bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.GetPoints(bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the returned list contains cloned points; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the internal list is returned directly without cloning and must not be mutated by the caller\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The vertices of the geometry, or null if none exist\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.GetSegments()'></a>

## Segmentable2D\.GetSegments\(\) Method

Gets the segments that form the geometry\.

```csharp
public abstract System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

Implements [GetSegments\(\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D.GetSegments() 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\.GetSegments\(\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of boundary segments, or null if none exist\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Inverse()'></a>

## Segmentable2D\.Inverse\(\) Method

Reverses the order of the points defining the geometry\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reversal was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Move(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Segmentable2D\.Move\(Vector2D\) Method

Moves the geometry by the specified vector\.

```csharp
public override bool Move(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Move(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Segmentable2D\.On\(Point2D, double\) Method

Checks if the specified point lies on the geometry within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the geometry; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D)'></a>

## Segmentable2D\.Transform\(ITransform2D\) Method

Transforms the geometry using the specified transformation\.

```csharp
public override bool Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Segmentable2D.Transform(DiGi.Geometry.Planar.Interfaces.ITransform2D).transform'></a>

`transform` [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')

The transformation to apply\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the transformation was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D'></a>

## SegmentableTraceResult2D Class

Represents a result of a trace operation in 2D space that can be segmented into a point, segment, or vector\.

```csharp
public class SegmentableTraceResult2D : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → SegmentableTraceResult2D
### Constructors

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.SegmentableTraceResult2D(DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D)'></a>

## SegmentableTraceResult2D\(SegmentableTraceResult2D\) Constructor

Initializes a new instance of the [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D') class by copying the values from an existing [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D') instance\.

```csharp
public SegmentableTraceResult2D(DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D? segmentableTraceResult2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.SegmentableTraceResult2D(DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D).segmentableTraceResult2D'></a>

`segmentableTraceResult2D` [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D')

The [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D') instance to copy data from\.

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.SegmentableTraceResult2D(System.Text.Json.Nodes.JsonObject)'></a>

## SegmentableTraceResult2D\(JsonObject\) Constructor

Initializes a new instance of the [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public SegmentableTraceResult2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.SegmentableTraceResult2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.Point2D'></a>

## SegmentableTraceResult2D\.Point2D Property

Hit Point

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Point2D { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.Segment2D'></a>

## SegmentableTraceResult2D\.Segment2D Property

Hit Segment

```csharp
public DiGi.Geometry.Planar.Classes.Segment2D? Segment2D { get; }
```

#### Property Value
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.Vector2D'></a>

## SegmentableTraceResult2D\.Vector2D Property

Hit direction

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Vector2D { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D.Clone()'></a>

## SegmentableTraceResult2D\.Clone\(\) Method

Creates a clone of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a copy of the current object, or null\.

<a name='DiGi.Geometry.Planar.Classes.SnapperUpdater'></a>

## SnapperUpdater Class

Provides functionality to update geometry by snapping it based on a specified tolerance\.

```csharp
public class SnapperUpdater : DiGi.Geometry.Core.Interfaces.IGeometryUpdater<DiGi.Geometry.Planar.Interfaces.IGeometry2D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<DiGi.Geometry.Planar.Interfaces.IGeometry2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SnapperUpdater

Implements [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.SnapperUpdater.SnapperUpdater()'></a>

## SnapperUpdater\(\) Constructor

Initializes a new instance of the [SnapperUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SnapperUpdater 'DiGi\.Geometry\.Planar\.Classes\.SnapperUpdater') class\.

```csharp
public SnapperUpdater();
```

<a name='DiGi.Geometry.Planar.Classes.SnapperUpdater.SnapperUpdater(double)'></a>

## SnapperUpdater\(double\) Constructor

Initializes a new instance of the [SnapperUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SnapperUpdater 'DiGi\.Geometry\.Planar\.Classes\.SnapperUpdater') class\.

```csharp
public SnapperUpdater(double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.SnapperUpdater.SnapperUpdater(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for snapping operations\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.SnapperUpdater.Value'></a>

## SnapperUpdater\.Value Property

Gets or sets the [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') value to be processed during the update operation\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IGeometry2D? Value { get; set; }
```

Implements [Value](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1.value 'DiGi\.Core\.Interfaces\.IUpdater\`1\.Value')

#### Property Value
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')  
The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') instance\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.SnapperUpdater.Update()'></a>

## SnapperUpdater\.Update\(\) Method

Updates the current value by snapping the geometry to itself using a specified tolerance\.

```csharp
public bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update operation was successful\.

<a name='DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater'></a>

## TopologyPreservingUpdater Class

Provides functionality to update an [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') while preserving its topological structure\.

```csharp
public class TopologyPreservingUpdater : DiGi.Geometry.Core.Interfaces.IGeometryUpdater<DiGi.Geometry.Planar.Interfaces.IGeometry2D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<DiGi.Geometry.Planar.Interfaces.IGeometry2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → TopologyPreservingUpdater

Implements [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater.TopologyPreservingUpdater()'></a>

## TopologyPreservingUpdater\(\) Constructor

Initializes a new instance of the [TopologyPreservingUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater 'DiGi\.Geometry\.Planar\.Classes\.TopologyPreservingUpdater') class\.

```csharp
public TopologyPreservingUpdater();
```

<a name='DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater.TopologyPreservingUpdater(double)'></a>

## TopologyPreservingUpdater\(double\) Constructor

Initializes a new instance of the [TopologyPreservingUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater 'DiGi\.Geometry\.Planar\.Classes\.TopologyPreservingUpdater') class with the specified tolerance\.

```csharp
public TopologyPreservingUpdater(double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater.TopologyPreservingUpdater(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value used as the tolerance for preserving topology during updates\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater.Value'></a>

## TopologyPreservingUpdater\.Value Property

Gets or sets the [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') value\.

```csharp
public DiGi.Geometry.Planar.Interfaces.IGeometry2D? Value { get; set; }
```

Implements [Value](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1.value 'DiGi\.Core\.Interfaces\.IUpdater\`1\.Value')

#### Property Value
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.TopologyPreservingUpdater.Update()'></a>

## TopologyPreservingUpdater\.Update\(\) Method

Updates the current value by simplifying its geometry while preserving topology\.

```csharp
public bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update was successful; returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the value was successfully simplified and updated, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Planar.Classes.Transform2D'></a>

## Transform2D Class

Represents a two\-dimensional transformation defined by a [Matrix3D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D.Matrix3D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D\.Matrix3D')\.

```csharp
public class Transform2D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Planar.Interfaces.ITransform2D, DiGi.Geometry.Core.Interfaces.ITransform, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Transform2D

Implements [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransform](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransform 'DiGi\.Geometry\.Core\.Interfaces\.ITransform'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transform2D(DiGi.Geometry.Planar.Classes.Transform2D)'></a>

## Transform2D\(Transform2D\) Constructor

Initializes a new instance of the [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') class by copying the properties of an existing [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object\.

```csharp
public Transform2D(DiGi.Geometry.Planar.Classes.Transform2D? transform2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transform2D(DiGi.Geometry.Planar.Classes.Transform2D).transform2D'></a>

`transform2D` [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')

The source [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object to copy from, or null\.

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transform2D(DiGi.Math.Classes.Matrix3D)'></a>

## Transform2D\(Matrix3D\) Constructor

Initializes a new instance of the [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') class using the specified [Matrix3D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D.Matrix3D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D\.Matrix3D')\.

```csharp
public Transform2D(DiGi.Math.Classes.Matrix3D? matrix3D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transform2D(DiGi.Math.Classes.Matrix3D).matrix3D'></a>

`matrix3D` [DiGi\.Math\.Classes\.Matrix3D](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix3d 'DiGi\.Math\.Classes\.Matrix3D')

The [Matrix3D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D.Matrix3D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D\.Matrix3D') to initialize the transform with\.

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transform2D(System.Text.Json.Nodes.JsonObject)'></a>

## Transform2D\(JsonObject\) Constructor

Initializes a new instance of the [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Transform2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transform2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') instance\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Matrix3D'></a>

## Transform2D\.Matrix3D Property

Gets the 3D transformation matrix\.

```csharp
public DiGi.Math.Classes.Matrix3D? Matrix3D { get; }
```

#### Property Value
[DiGi\.Math\.Classes\.Matrix3D](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix3d 'DiGi\.Math\.Classes\.Matrix3D')  
A [Matrix3D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D.Matrix3D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D\.Matrix3D') object if a matrix is defined; otherwise, null\.

<a name='DiGi.Geometry.Planar.Classes.Transform2D.this[int,int]'></a>

## Transform2D\.this\[int, int\] Property

Gets the value at the specified row and column of the transformation matrix\.

```csharp
public double this[int row, int column] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Transform2D.this[int,int].row'></a>

`row` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Geometry.Planar.Classes.Transform2D.this[int,int].column'></a>

`column` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Inverse()'></a>

## Transform2D\.Inverse\(\) Method

Computes the inverse of the underlying 3D matrix\.

```csharp
public void Inverse();
```

<a name='DiGi.Geometry.Planar.Classes.Transform2D.Transpose()'></a>

## Transform2D\.Transpose\(\) Method

Transposes the 3D matrix\.

```csharp
public void Transpose();
```
### Operators

<a name='DiGi.Geometry.Planar.Classes.Transform2D.op_Multiply(DiGi.Geometry.Planar.Classes.Transform2D,DiGi.Geometry.Planar.Classes.Transform2D)'></a>

## Transform2D\.operator \*\(Transform2D, Transform2D\) Operator

Multiplies two 2D transformations to produce a combined transformation\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D? operator *(DiGi.Geometry.Planar.Classes.Transform2D? transform2D_1, DiGi.Geometry.Planar.Classes.Transform2D? transform2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Transform2D.op_Multiply(DiGi.Geometry.Planar.Classes.Transform2D,DiGi.Geometry.Planar.Classes.Transform2D).transform2D_1'></a>

`transform2D_1` [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')

The first transformation\.

<a name='DiGi.Geometry.Planar.Classes.Transform2D.op_Multiply(DiGi.Geometry.Planar.Classes.Transform2D,DiGi.Geometry.Planar.Classes.Transform2D).transform2D_2'></a>

`transform2D_2` [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')

The second transformation\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A new [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') representing the combined transformations, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either operand is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D'></a>

## TransformGroup2D Class

Represents a group of 2D transformations that can be treated as a single [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') or iterated over as a collection of [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') objects\.

```csharp
public class TransformGroup2D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Planar.Interfaces.ITransform2D, DiGi.Geometry.Core.Interfaces.ITransform, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TransformGroup2D

Implements [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransform](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransform 'DiGi\.Geometry\.Core\.Interfaces\.ITransform'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.TransformGroup2D(DiGi.Geometry.Planar.Classes.TransformGroup2D)'></a>

## TransformGroup2D\(TransformGroup2D\) Constructor

Initializes a new instance of the [TransformGroup2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TransformGroup2D 'DiGi\.Geometry\.Planar\.Classes\.TransformGroup2D') class by cloning an existing [TransformGroup2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TransformGroup2D 'DiGi\.Geometry\.Planar\.Classes\.TransformGroup2D') instance\.

```csharp
public TransformGroup2D(DiGi.Geometry.Planar.Classes.TransformGroup2D? transformGroup2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.TransformGroup2D(DiGi.Geometry.Planar.Classes.TransformGroup2D).transformGroup2D'></a>

`transformGroup2D` [TransformGroup2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TransformGroup2D 'DiGi\.Geometry\.Planar\.Classes\.TransformGroup2D')

The [TransformGroup2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TransformGroup2D 'DiGi\.Geometry\.Planar\.Classes\.TransformGroup2D') instance to clone from, or null to initialize an empty group\.

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.TransformGroup2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ITransform2D_)'></a>

## TransformGroup2D\(IEnumerable\<ITransform2D\>\) Constructor

Initializes a new instance of the [TransformGroup2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TransformGroup2D 'DiGi\.Geometry\.Planar\.Classes\.TransformGroup2D') class using the specified collection of [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') transforms\.

```csharp
public TransformGroup2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ITransform2D>? transform2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.TransformGroup2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ITransform2D_).transform2Ds'></a>

`transform2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the transforms to be added to the group\. This value can be null\.

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.TransformGroup2D(System.Text.Json.Nodes.JsonObject)'></a>

## TransformGroup2D\(JsonObject\) Constructor

Initializes a new instance of the [TransformGroup2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.TransformGroup2D 'DiGi\.Geometry\.Planar\.Classes\.TransformGroup2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public TransformGroup2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.TransformGroup2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.TransformGroup2D.GetEnumerator()'></a>

## TransformGroup2D\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') objects\.

```csharp
public System.Collections.Generic.IEnumerator<DiGi.Geometry.Planar.Interfaces.ITransform2D> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An [System\.Collections\.Generic\.IEnumerator&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1') for the [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') collection\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D'></a>

## Triangle2D Class

Represents a two\-dimensional triangle\.

```csharp
public class Triangle2D : DiGi.Geometry.Planar.Classes.Polygon2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Geometry2D 'DiGi\.Geometry\.Planar\.Classes\.Geometry2D') → [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') → [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') → Triangle2D
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D()'></a>

## Triangle2D\(\) Constructor

Initializes a new instance of the [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') class\.

```csharp
public Triangle2D();
```

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Triangle2D\(Point2D, Point2D, Point2D\) Constructor

Initializes a new instance of the [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') class with three specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertices\.

```csharp
public Triangle2D(DiGi.Geometry.Planar.Classes.Point2D point2D_1, DiGi.Geometry.Planar.Classes.Point2D point2D_2, DiGi.Geometry.Planar.Classes.Point2D point2D_3);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertex of the triangle\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertex of the triangle\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_3'></a>

`point2D_3` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The third [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertex of the triangle\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(DiGi.Geometry.Planar.Classes.Triangle2D)'></a>

## Triangle2D\(Triangle2D\) Constructor

Initializes a new instance of the [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') class using another [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') instance\.

```csharp
public Triangle2D(DiGi.Geometry.Planar.Classes.Triangle2D? triangle2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(DiGi.Geometry.Planar.Classes.Triangle2D).triangle2D'></a>

`triangle2D` [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')

The [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') instance to copy from\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Triangle2D\(IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') class using a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public Triangle2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects that define the vertices of the triangle\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(System.Text.Json.Nodes.JsonObject)'></a>

## Triangle2D\(JsonObject\) Constructor

Initializes a new instance of the [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Triangle2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangle2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') instance\.
### Methods

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Clone()'></a>

## Triangle2D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object\.

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangulate(double)'></a>

## Triangle2D\.Triangulate\(double\) Method

Triangulates the object into a list of [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') objects using the specified tolerance\.

```csharp
public override System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Triangle2D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for triangulation\.

Implements [Triangulate\(double\)](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Triangulate(double) 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\.Triangulate\(double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Triangle2D>` containing the resulting triangles, or null if the object cannot be triangulated\.

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D'></a>

## UnionResult2D Class

Represents the result of a 2D union operation\.

```csharp
public class UnionResult2D : DiGi.Geometry.Planar.Classes.BooleanOperationResult2D, DiGi.Geometry.Planar.Interfaces.IUnionResult2D, DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') → UnionResult2D

Implements [IUnionResult2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IUnionResult2D 'DiGi\.Geometry\.Planar\.Interfaces\.IUnionResult2D'), [IBooleanOperationResult2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D()'></a>

## UnionResult2D\(\) Constructor

Initializes a new instance of the [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') class\.

```csharp
public UnionResult2D();
```

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(DiGi.Geometry.Planar.Classes.UnionResult2D)'></a>

## UnionResult2D\(UnionResult2D\) Constructor

Initializes a new instance of the [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') class using another [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') instance\.

```csharp
public UnionResult2D(DiGi.Geometry.Planar.Classes.UnionResult2D? unionResult2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(DiGi.Geometry.Planar.Classes.UnionResult2D).unionResult2D'></a>

`unionResult2D` [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D')

The [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') instance to copy from\.

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## UnionResult2D\(IGeometry2D\) Constructor

Initializes a new instance of the [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') class with the specified [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

```csharp
public UnionResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') to initialize the result with\. This value can be null\.

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## UnionResult2D\(IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') class\.

```csharp
public UnionResult2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects to be cloned and stored in the result\.

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool)'></a>

## UnionResult2D\(List\<IGeometry2D\>, bool\) Constructor

Initializes a new instance of the [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') class from a prebuilt list of geometries\.

```csharp
internal UnionResult2D(System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds, bool clone);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of geometries resulting from the union\.

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Collections.Generic.List_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,bool).clone'></a>

`clone` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), each geometry is cloned defensively; when [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the supplied list is adopted directly without cloning\. Use [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only when the caller owns freshly created geometries that are not shared\.

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Text.Json.Nodes.JsonObject)'></a>

## UnionResult2D\(JsonObject\) Constructor

Initializes a new instance of the [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public UnionResult2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.UnionResult2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.BooleanOpertaionType'></a>

## UnionResult2D\.BooleanOpertaionType Property

Gets the type of the boolean operation, which is [Union](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType.Union 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType\.Union')\.

```csharp
public override DiGi.Geometry.Core.Enums.BooleanOpertaionType BooleanOpertaionType { get; }
```

Implements [BooleanOpertaionType](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBooleanOperationResult2D.BooleanOpertaionType 'DiGi\.Geometry\.Planar\.Interfaces\.IBooleanOperationResult2D\.BooleanOpertaionType')

#### Property Value
[BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')
### Methods

<a name='DiGi.Geometry.Planar.Classes.UnionResult2D.Clone()'></a>

## UnionResult2D\.Clone\(\) Method

Creates a copy of the current [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D'></a>

## Vector2D Class

Represents a two\-dimensional vector that inherits from [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') and implements the [DiGi\.Geometry\.Core\.Interfaces\.IVector](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ivector 'DiGi\.Geometry\.Core\.Interfaces\.IVector') interface\.

```csharp
public class Vector2D : DiGi.Geometry.Planar.Classes.Coordinate2D, DiGi.Geometry.Core.Interfaces.IVector, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') → [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') → Vector2D

Implements [DiGi\.Geometry\.Core\.Interfaces\.IVector](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ivector 'DiGi\.Geometry\.Core\.Interfaces\.IVector'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Vector2D\(Point2D, Point2D\) Constructor

Initializes a new instance of the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') class defined by two points\.

```csharp
public Vector2D(DiGi.Geometry.Planar.Classes.Point2D? start, DiGi.Geometry.Planar.Classes.Point2D? end);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).start'></a>

`start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The start point of the vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).end'></a>

`end` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The end point of the vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\(Vector2D\) Constructor

Initializes a new instance of the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') class by cloning an existing vector\.

```csharp
public Vector2D(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The source vector to clone\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(double,double)'></a>

## Vector2D\(double, double\) Constructor

Initializes a new instance of the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') class with specified X and Y components\.

```csharp
public Vector2D(double x, double y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(double[])'></a>

## Vector2D\(double\[\]\) Constructor

Initializes a new instance of the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') class using an array of values\.

```csharp
public Vector2D(double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array containing coordinate values\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(System.Text.Json.Nodes.JsonObject)'></a>

## Vector2D\(JsonObject\) Constructor

Initializes a new instance of the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') class from a JSON object\.

```csharp
public Vector2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Vector2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing vector data\.
### Properties

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Length'></a>

## Vector2D\.Length Property

Gets or sets the length of the vector\.

```csharp
public double Length { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Vector2D.SquaredLength'></a>

## Vector2D\.SquaredLength Property

Gets the squared length of the vector\.

```csharp
public double SquaredLength { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Unit'></a>

## Vector2D\.Unit Property

Gets the unit vector in the same direction as this vector\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Unit { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')
### Methods

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Angle(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.Angle\(Vector2D\) Method

Calculate the dot product as an angle\. Use SignedAngle if performance is priority
Source: https://wiki\.unity3d\.com/index\.php/3d\_Math\_functions

```csharp
public double Angle(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Angle(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

Vector2D

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Angle in radians

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Clone()'></a>

## Vector2D\.Clone\(\) Method

Creates a clone of the current vector\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Collinear(DiGi.Geometry.Planar.Classes.Vector2D,double)'></a>

## Vector2D\.Collinear\(Vector2D, double\) Method

Checks if this vector is collinear with another vector within a given tolerance\.

```csharp
public bool Collinear(DiGi.Geometry.Planar.Classes.Vector2D vector2D, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Collinear(DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector to check for collinearity\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Collinear(DiGi.Geometry.Planar.Classes.Vector2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the vectors are collinear; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.DotProduct(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.DotProduct\(Vector2D\) Method

Calculates the dot product of this vector and another vector\.

```csharp
public double DotProduct(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.DotProduct(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The other vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The dot product result, or NaN if the input is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Equals(object)'></a>

## Vector2D\.Equals\(object\) Method

Determines whether the specified object is equal to the current vector\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.GetAbs()'></a>

## Vector2D\.GetAbs\(\) Method

Gets a new vector with absolute values of the components\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D GetAbs();
```

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') with absolute component values\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.GetHashCode()'></a>

## Vector2D\.GetHashCode\(\) Method

Gets the hash code for this vector\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.GetInversed()'></a>

## Vector2D\.GetInversed\(\) Method

Gets a new vector that is the inverse of this vector\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D GetInversed();
```

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the opposite direction\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.GetPerpendicular(DiGi.Geometry.Core.Enums.Orientation)'></a>

## Vector2D\.GetPerpendicular\(Orientation\) Method

Gets a perpendicular vector to the current vector based on the specified orientation\.

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? GetPerpendicular(DiGi.Geometry.Core.Enums.Orientation orientation=DiGi.Geometry.Core.Enums.Orientation.Clockwise);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.GetPerpendicular(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The desired orientation of the perpendicular vector\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A perpendicular [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D'), or null if the orientation is undefined or collinear\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Normalize()'></a>

## Vector2D\.Normalize\(\) Method

Normalizes the current vector to have a length of 1\.

```csharp
public void Normalize();
```

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Project(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Vector2D\.Project\(Point2D\) Method

Projects a point onto the line defined by this vector passing through the origin\.

```csharp
public DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Project(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point to project\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D'), or null if the input is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Project(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.Project\(Vector2D\) Method

Project input Vector onto this Vector

```csharp
public DiGi.Geometry.Planar.Classes.Vector2D? Project(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.Project(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

Vector to be projected

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
Projection vector

<a name='DiGi.Geometry.Planar.Classes.Vector2D.SignedAngle(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.SignedAngle\(Vector2D\) Method

Calculates the signed angle between this vector and another vector\.

```csharp
public double SignedAngle(DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.SignedAngle(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The other vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The signed angle in radians, or NaN if the input is null\.
### Operators

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Addition(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.operator \+\(Vector2D, Vector2D\) Operator

Adds two vectors together\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? operator +(DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Addition(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Addition(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector to add\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new Vector2D result, or null if either input is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Division(DiGi.Geometry.Planar.Classes.Vector2D,double)'></a>

## Vector2D\.operator /\(Vector2D, double\) Operator

Divides a vector by a numeric factor\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? operator /(DiGi.Geometry.Planar.Classes.Vector2D? vector2D, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Division(DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector to divide\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Division(DiGi.Geometry.Planar.Classes.Vector2D,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The divisor factor\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new scaled Vector2D, or null if the vector is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Equality(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.operator ==\(Vector2D, Vector2D\) Operator

Checks if two vectors are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Equality(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Equality(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the vectors are identical; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_ExplicitDiGi.Geometry.Planar.Classes.Vector2D(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Vector2D\.explicit operator Vector2D\(Point2D\) Operator

Explicitly converts a Point2D to a Vector2D\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? explicit operator DiGi.Geometry.Planar.Classes.Vector2D?(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_ExplicitDiGi.Geometry.Planar.Classes.Vector2D(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to convert\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new Vector2D with the same coordinates as the point, or null if the point is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Inequality(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.operator \!=\(Vector2D, Vector2D\) Operator

Checks if two vectors are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Inequality(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Inequality(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the vectors are different; otherwise, false\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.operator \*\(Vector2D, Vector2D\) Operator

Calculates the dot product of two vectors\.

```csharp
public static double operator *(DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The scalar result of the dot product, or NaN if either input is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(DiGi.Geometry.Planar.Classes.Vector2D,double)'></a>

## Vector2D\.operator \*\(Vector2D, double\) Operator

Scales a vector by a numeric factor\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? operator *(DiGi.Geometry.Planar.Classes.Vector2D? vector2D, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector to scale\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(DiGi.Geometry.Planar.Classes.Vector2D,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new scaled Vector2D, or null if the vector is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(double,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.operator \*\(double, Vector2D\) Operator

Scales a vector by a numeric factor\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? operator *(double factor, DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(double,DiGi.Geometry.Planar.Classes.Vector2D).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Multiply(double,DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector to scale\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new scaled Vector2D, or null if the vector is null\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Subtraction(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Vector2D\.operator \-\(Vector2D, Vector2D\) Operator

Subtracts one vector from another\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? operator -(DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Subtraction(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Classes.Vector2D.op_Subtraction(DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector to subtract\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new Vector2D result, or null if either input is null\.