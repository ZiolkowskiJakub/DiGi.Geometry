#### [DiGi\.Geometry](DiGi.Geometry.Overview.md 'DiGi\.Geometry\.Overview')

## DiGi\.Geometry\.Core\.Classes Namespace
### Classes

<a name='DiGi.Geometry.Core.Classes.Coordinate'></a>

## Coordinate Class

Represents an abstract base class for a coordinate system that is serializable, geometric, and invertible\.

```csharp
public abstract class Coordinate : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Coordinate

Derived  
↳ [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D')  
↳ [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible')
### Constructors

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(DiGi.Geometry.Core.Classes.Coordinate)'></a>

## Coordinate\(Coordinate\) Constructor

Initializes a new instance of the [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') class using the values from an existing [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') instance\.

```csharp
public Coordinate(DiGi.Geometry.Core.Classes.Coordinate? coordinate);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(DiGi.Geometry.Core.Classes.Coordinate).coordinate'></a>

`coordinate` [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')

The [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') instance to copy values from\. This parameter can be null\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(double[])'></a>

## Coordinate\(double\[\]\) Constructor

Initializes a new instance of the [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') class using a variable number of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values\.

```csharp
public Coordinate(params double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An optional array of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values to initialize the coordinate\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(System.Text.Json.Nodes.JsonObject,int)'></a>

## Coordinate\(JsonObject, int\) Constructor

Initializes a new instance of the [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') and a specified length\.

```csharp
public Coordinate(System.Text.Json.Nodes.JsonObject? jsonObject, int length);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(System.Text.Json.Nodes.JsonObject,int).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing coordinate data, or null if no data is provided\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Coordinate(System.Text.Json.Nodes.JsonObject,int).length'></a>

`length` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') specifying the number of elements for the internal values array\.
### Properties

<a name='DiGi.Geometry.Core.Classes.Coordinate.ArgumentedMatrix'></a>

## Coordinate\.ArgumentedMatrix Property

Gets the augmented matrix representation of the current values\.

```csharp
public DiGi.Math.Classes.Matrix? ArgumentedMatrix { get; }
```

#### Property Value
[DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix')  
A [DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix') object representing the augmented matrix, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the underlying values are null\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.this[int]'></a>

## Coordinate\.this\[int\] Property

Gets or sets the coordinate value at the specified index\.

```csharp
public double this[int index] { get; set; }
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the coordinate value to get or set\.

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Core.Classes.Coordinate.Abs()'></a>

## Coordinate\.Abs\(\) Method

Computes the absolute value for each element in the values array\.

```csharp
public void Abs();
```

<a name='DiGi.Geometry.Core.Classes.Coordinate.AlmostEquals(DiGi.Geometry.Core.Classes.Coordinate,double)'></a>

## Coordinate\.AlmostEquals\(Coordinate, double\) Method

Determines whether the current instance is approximately equal to the specified [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')\.

```csharp
public bool AlmostEquals(DiGi.Geometry.Core.Classes.Coordinate? coordinate, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.AlmostEquals(DiGi.Geometry.Core.Classes.Coordinate,double).coordinate'></a>

`coordinate` [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')

The [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') instance to compare with the current instance\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.AlmostEquals(DiGi.Geometry.Core.Classes.Coordinate,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the maximum allowed difference for two coordinates to be considered equal\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the coordinates are almost equal based on the specified tolerance\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Equals(object)'></a>

## Coordinate\.Equals\(object\) Method

Determines whether the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is equal to the current [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the specified object is equal to the current instance\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.GetHashCode()'></a>

## Coordinate\.GetHashCode\(\) Method

Returns a hash code for the current object based on its internal values\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An int representing the hash code of the current object\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Inverse()'></a>

## Coordinate\.Inverse\(\) Method

Inverts the signs of all elements in the values array\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Round(double)'></a>

## Coordinate\.Round\(double\) Method

Rounds each value in the collection using the specified double tolerance\.

```csharp
public void Round(double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.Round(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the precision used for rounding\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.Scale(double)'></a>

## Coordinate\.Scale\(double\) Method

Scales all elements of the values array by the specified multiplier\.

```csharp
public void Scale(double value);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.Scale(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value to multiply each element by\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.ToString()'></a>

## Coordinate\.ToString\(\) Method

Returns a string representation of the current object, formatting the internal values as a semicolon\-separated list enclosed in square brackets\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the formatted values, or an empty string if the values are null\.
### Operators

<a name='DiGi.Geometry.Core.Classes.Coordinate.op_Equality(DiGi.Geometry.Core.Classes.Coordinate,DiGi.Geometry.Core.Classes.Coordinate)'></a>

## Coordinate\.operator ==\(Coordinate, Coordinate\) Operator

Compares two [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') instances for equality based on their types and the values they contain\.

```csharp
public static bool operator ==(DiGi.Geometry.Core.Classes.Coordinate? coordinate_1, DiGi.Geometry.Core.Classes.Coordinate? coordinate_2);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.op_Equality(DiGi.Geometry.Core.Classes.Coordinate,DiGi.Geometry.Core.Classes.Coordinate).coordinate_1'></a>

`coordinate_1` [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')

The first coordinate to compare\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.op_Equality(DiGi.Geometry.Core.Classes.Coordinate,DiGi.Geometry.Core.Classes.Coordinate).coordinate_2'></a>

`coordinate_2` [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')

The second coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the coordinates are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.op_Inequality(DiGi.Geometry.Core.Classes.Coordinate,DiGi.Geometry.Core.Classes.Coordinate)'></a>

## Coordinate\.operator \!=\(Coordinate, Coordinate\) Operator

Compares two [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') instances to determine if they are not equal based on their types and the values they contain\.

```csharp
public static bool operator !=(DiGi.Geometry.Core.Classes.Coordinate? coordinate_1, DiGi.Geometry.Core.Classes.Coordinate? coordinate_2);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Coordinate.op_Inequality(DiGi.Geometry.Core.Classes.Coordinate,DiGi.Geometry.Core.Classes.Coordinate).coordinate_1'></a>

`coordinate_1` [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')

The first coordinate to compare\.

<a name='DiGi.Geometry.Core.Classes.Coordinate.op_Inequality(DiGi.Geometry.Core.Classes.Coordinate,DiGi.Geometry.Core.Classes.Coordinate).coordinate_2'></a>

`coordinate_2` [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate')

The second coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the coordinates are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_'></a>

## DensityBasedSpatialClusteringResult\<T\> Class

Represents the result of a density\-based spatial clustering operation\.

```csharp
public class DensityBasedSpatialClusteringResult<T> : DiGi.Core.Classes.SerializableResult
    where T : DiGi.Geometry.Core.Interfaces.IPoint<T>
```
#### Type parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T'></a>

`T`

The type of point, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableresult 'DiGi\.Core\.Classes\.SerializableResult') → DensityBasedSpatialClusteringResult\<T\>
### Constructors

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_)'></a>

## DensityBasedSpatialClusteringResult\(DensityBasedSpatialClusteringResult\<T\>\) Constructor

Initializes a new instance of the [DensityBasedSpatialClusteringResult&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>') class using the specified [DensityBasedSpatialClusteringResult&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>') result\.

```csharp
public DensityBasedSpatialClusteringResult(DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult<T> densityBasedSpatialClusteringResult);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_).densityBasedSpatialClusteringResult'></a>

`densityBasedSpatialClusteringResult` [DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>')

The [DensityBasedSpatialClusteringResult&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>') object containing the clustering data to be copied\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(double,int,System.Collections.Generic.Dictionary_T,int_)'></a>

## DensityBasedSpatialClusteringResult\(double, int, Dictionary\<T,int\>\) Constructor

Initializes a new instance of the [DensityBasedSpatialClusteringResult&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>') class\.

```csharp
public DensityBasedSpatialClusteringResult(double tolerance, int pointCount, System.Collections.Generic.Dictionary<T,int>? dictionary);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(double,int,System.Collections.Generic.Dictionary_T,int_).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for spatial clustering\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(double,int,System.Collections.Generic.Dictionary_T,int_).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') number of points processed in the clustering operation\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(double,int,System.Collections.Generic.Dictionary_T,int_).dictionary'></a>

`dictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

An optional `Dictionary<T, int>`/\> containing the mapping of elements to their respective cluster indices\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(System.Text.Json.Nodes.JsonObject)'></a>

## DensityBasedSpatialClusteringResult\(JsonObject\) Constructor

Initializes a new instance of the [DensityBasedSpatialClusteringResult&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public DensityBasedSpatialClusteringResult(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.DensityBasedSpatialClusteringResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the clustering result\.
### Properties

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.Dictionary'></a>

## DensityBasedSpatialClusteringResult\<T\>\.Dictionary Property

Gets a `Dictionary<T, int>`/\> containing mappings from keys of type [T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T') to values of type [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

```csharp
public System.Collections.Generic.Dictionary<T,int>? Dictionary { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A `Dictionary<T, int>`/\> where each key is a clone of the original key, or null if the underlying dictionary is null\.
### Methods

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.Clone()'></a>

## DensityBasedSpatialClusteringResult\<T\>\.Clone\(\) Method

Creates a clone of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current instance, or `null`\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.GetIndexes()'></a>

## DensityBasedSpatialClusteringResult\<T\>\.GetIndexes\(\) Method

Retrieves a set of all indexes stored in the dictionary\.

```csharp
public System.Collections.Generic.HashSet<int>? GetIndexes();
```

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') of [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') containing the indexes, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the internal dictionary is null\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.GetPoint(int,System.Func_System.Collections.Generic.IEnumerable_T_,T_)'></a>

## DensityBasedSpatialClusteringResult\<T\>\.GetPoint\(int, Func\<IEnumerable\<T\>,T\>\) Method

Retrieves a single point at the specified index\. If multiple points are available,
they can be processed by the provided function; otherwise, the first point is returned\.

```csharp
public T? GetPoint(int index, System.Func<System.Collections.Generic.IEnumerable<T>,T>? func=null);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.GetPoint(int,System.Func_System.Collections.Generic.IEnumerable_T_,T_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the point to retrieve\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.GetPoint(int,System.Func_System.Collections.Generic.IEnumerable_T_,T_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional `Func<IEnumerable<T>, T>` used to select a single [T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T') from the collection of points\.

#### Returns
[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')  
A cloned instance of [T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T') if a point is found; otherwise, the default value of [T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.GetPoints(int)'></a>

## DensityBasedSpatialClusteringResult\<T\>\.GetPoints\(int\) Method

Retrieves a list of points associated with the specified index\.

```csharp
public System.Collections.Generic.List<T>? GetPoints(int index);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.GetPoints(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index to search for\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.T 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the points that match the provided index, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the dictionary is null\.

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.HasIndex(int)'></a>

## DensityBasedSpatialClusteringResult\<T\>\.HasIndex\(int\) Method

Determines whether the specified index exists within the dictionary values\.

```csharp
public bool HasIndex(int index);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_.HasIndex(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index to locate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the specified [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index was found; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_'></a>

## GeometryCollection\<T\> Class

Represents an abstract collection of geometry objects that implements the [DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection\`1') interface\.

```csharp
public abstract class GeometryCollection<T> : DiGi.Core.Classes.SerializableObjectCollection<T>, DiGi.Geometry.Core.Interfaces.IGeometryCollection<T>, DiGi.Geometry.Core.Interfaces.IGeometryCollection, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    where T : DiGi.Geometry.Core.Interfaces.ICollectable
```
#### Type parameters

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.T'></a>

`T`

The type of elements in the collection, which must implement [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectcollection-1 'DiGi\.Core\.Classes\.SerializableObjectCollection\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_.T 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectcollection-1 'DiGi\.Core\.Classes\.SerializableObjectCollection\`1') → GeometryCollection\<T\>

Derived  
↳ [GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_.T 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrycollection 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryCollection'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_.T 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_.T 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection()'></a>

## GeometryCollection\(\) Constructor

Initializes a new instance of the [GeometryCollection&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') class\.

```csharp
public GeometryCollection();
```

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection(DiGi.Geometry.Core.Classes.GeometryCollection_T_)'></a>

## GeometryCollection\(GeometryCollection\<T\>\) Constructor

Initializes a new instance of the [GeometryCollection&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') class using the specified [GeometryCollection&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') object\.

```csharp
public GeometryCollection(DiGi.Geometry.Core.Classes.GeometryCollection<T>? geometryCollection);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection(DiGi.Geometry.Core.Classes.GeometryCollection_T_).geometryCollection'></a>

`geometryCollection` [DiGi\.Geometry\.Core\.Classes\.GeometryCollection&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_.T 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>\.T')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>')

The [GeometryCollection&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') object to copy from\. This value can be null\.

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection(System.Collections.Generic.IEnumerable_T_)'></a>

## GeometryCollection\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [GeometryCollection&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') class using the specified collection of items\.

```csharp
public GeometryCollection(System.Collections.Generic.IEnumerable<T>? collectables);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection(System.Collections.Generic.IEnumerable_T_).collectables'></a>

`collectables` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_.T 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the items to be added to the geometry collection\.

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection(System.Text.Json.Nodes.JsonObject)'></a>

## GeometryCollection\(JsonObject\) Constructor

Initializes a new instance of the [GeometryCollection&lt;T&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryCollection_T_ 'DiGi\.Geometry\.Core\.Classes\.GeometryCollection\<T\>') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GeometryCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.GeometryCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the collection\.
### Methods

<a name='DiGi.Geometry.Core.Classes.GeometryCollection_T_.Clone()'></a>

## GeometryCollection\<T\>\.Clone\(\) Method

Creates a deep copy of the current object by converting it to a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') and recreating it as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the conversion to [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') fails\.

<a name='DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_'></a>

## GeometryUpdater\<TGeometry\> Class

Provides an abstract base class for updating a geometry object of type [TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>\.TGeometry')\.

```csharp
public abstract class GeometryUpdater<TGeometry> : DiGi.Geometry.Core.Interfaces.IGeometryUpdater<TGeometry>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<TGeometry>
    where TGeometry : DiGi.Geometry.Core.Interfaces.IGeometry
```
#### Type parameters

<a name='DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.TGeometry'></a>

`TGeometry`

The type of geometry to be updated, which must implement the [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GeometryUpdater\<TGeometry\>

Derived  
↳ [DouglasPeuckerUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DouglasPeuckerUpdater 'DiGi\.Geometry\.Planar\.Classes\.DouglasPeuckerUpdater')  
↳ [Polygonal2DNormalizationUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygonal2DNormalizationUpdater 'DiGi\.Geometry\.Planar\.Classes\.Polygonal2DNormalizationUpdater')  
↳ [PolygonalFace2DNormalizationUpdater](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2DNormalizationUpdater 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2DNormalizationUpdater')  
↳ [Polygonal3DNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.Polygonal3DNormalizationUpdater')  
↳ [PolygonalFace3DNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3DNormalizationUpdater')  
↳ [PolyhedronNormalizationUpdater&lt;TPolyhedron&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_ 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>\.TGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>\.TGeometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Properties

<a name='DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.Value'></a>

## GeometryUpdater\<TGeometry\>\.Value Property

Gets or sets the geometry value of type [TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>\.TGeometry')\.

```csharp
public TGeometry? Value { get; set; }
```

Implements [Value](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1.value 'DiGi\.Core\.Interfaces\.IUpdater\`1\.Value')

#### Property Value
[TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>\.TGeometry')
### Methods

<a name='DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_.Update()'></a>

## GeometryUpdater\<TGeometry\>\.Update\(\) Method

Updates the state of the object\.

```csharp
public abstract bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the update was successful\.

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_'></a>

## InternalPointSolver\<TGeometry,TPoint\> Class

Provides a base implementation for solvers that calculate internal points within a specific geometry\.

```csharp
public abstract class InternalPointSolver<TGeometry,TPoint> : DiGi.Geometry.Core.Interfaces.IOneToManyGeometrySolver<TGeometry, TPoint>, DiGi.Geometry.Core.Interfaces.IGeometrySolver, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IOneToManySolver<TGeometry, TPoint>
    where TGeometry : DiGi.Geometry.Core.Interfaces.IGeometry
    where TPoint : DiGi.Geometry.Core.Interfaces.IPoint
```
#### Type parameters

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TGeometry'></a>

`TGeometry`

The type of geometry, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint'></a>

`TPoint`

The type of point, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IPoint](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint 'DiGi\.Geometry\.Core\.Interfaces\.IPoint')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → InternalPointSolver\<TGeometry,TPoint\>

Derived  
↳ [PolygonalFace2DInternalPointSolver](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2DInternalPointSolver 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2DInternalPointSolver')  
↳ [PolyhedronInternalPointSolver&lt;TPolyhedron&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_ 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetomanygeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver\`2')[TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TGeometry')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetomanygeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver\`2')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetomanygeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver\`2'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometrySolver](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrysolver 'DiGi\.Geometry\.Core\.Interfaces\.IGeometrySolver'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IOneToManySolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')[TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TGeometry')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')
### Constructors

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.InternalPointSolver(double)'></a>

## InternalPointSolver\(double\) Constructor

Initializes a new instance of the [InternalPointSolver&lt;TGeometry,TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>') class\.

```csharp
public InternalPointSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.InternalPointSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value used as the distance tolerance\.

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.InternalPointSolver(int,double)'></a>

## InternalPointSolver\(int, double\) Constructor

Initializes a new instance of the [InternalPointSolver&lt;TGeometry,TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>') class\.

```csharp
public InternalPointSolver(int maxCount, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.InternalPointSolver(int,double).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of iterations as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.InternalPointSolver(int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The convergence tolerance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.
### Properties

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.Input'></a>

## InternalPointSolver\<TGeometry,TPoint\>\.Input Property

Gets or sets the input geometry of type [TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TGeometry')\.

```csharp
public abstract TGeometry? Input { set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.input 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Input')

#### Property Value
[TGeometry](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TGeometry 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TGeometry')

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.MaxCount'></a>

## InternalPointSolver\<TGeometry,TPoint\>\.MaxCount Property

Gets or sets the maximum count as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

```csharp
public int MaxCount { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.Output'></a>

## InternalPointSolver\<TGeometry,TPoint\>\.Output Property

Gets the last [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint') from the collection of outputs\.

```csharp
public TPoint? Output { get; }
```

#### Property Value
[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint')  
The cloned last [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint') if any outputs exist; otherwise, the default value for [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint')\.

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.Outputs'></a>

## InternalPointSolver\<TGeometry,TPoint\>\.Outputs Property

Gets a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting output points, filtered to remove any null values\.

```csharp
public System.Collections.Generic.List<TPoint>? Outputs { get; }
```

Implements [Outputs](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.outputs 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Outputs')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the calculated outputs, or null if no outputs exist\.
### Methods

<a name='DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_.Solve()'></a>

## InternalPointSolver\<TGeometry,TPoint\>\.Solve\(\) Method

Attempts to solve the problem defined by the implementation\.

```csharp
public abstract bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the solution was successfully found\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_'></a>

## Mesh\<TPoint\> Class

Represents an abstract base class for a mesh structure consisting of points and indices\.

```csharp
public abstract class Mesh<TPoint> : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Core.Interfaces.IMesh, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TPoint : DiGi.Geometry.Core.Interfaces.IPoint<TPoint>
```
#### Type parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint'></a>

`TPoint`

The type of point used in the mesh, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Mesh\<TPoint\>

Derived  
↳ [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')  
↳ [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IMesh](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imesh 'DiGi\.Geometry\.Core\.Interfaces\.IMesh'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(DiGi.Geometry.Core.Classes.Mesh_TPoint_)'></a>

## Mesh\(Mesh\<TPoint\>\) Constructor

Initializes a new instance of the [Mesh&lt;TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') class by cloning points from an existing [Mesh&lt;TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') object\.

```csharp
public Mesh(DiGi.Geometry.Core.Classes.Mesh<TPoint>? mesh);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(DiGi.Geometry.Core.Classes.Mesh_TPoint_).mesh'></a>

`mesh` [DiGi\.Geometry\.Core\.Classes\.Mesh&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>')

The source [Mesh&lt;TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') object to clone points from\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(System.Collections.Generic.IEnumerable_TPoint_,System.Collections.Generic.IEnumerable_int[]_)'></a>

## Mesh\(IEnumerable\<TPoint\>, IEnumerable\<int\[\]\>\) Constructor

Initializes a new instance of the [Mesh&lt;TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') class with the specified points and indexes\.

```csharp
public Mesh(System.Collections.Generic.IEnumerable<TPoint>? points, System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(System.Collections.Generic.IEnumerable_TPoint_,System.Collections.Generic.IEnumerable_int[]_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the vertices of the mesh\. This value can be null\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(System.Collections.Generic.IEnumerable_TPoint_,System.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of integer arrays defining the indices for the mesh faces\. This value can be null\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(System.Text.Json.Nodes.JsonObject)'></a>

## Mesh\(JsonObject\) Constructor

Initializes a new instance of the [Mesh&lt;TPoint&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Mesh(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.Mesh(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the mesh\. This value can be null\.
### Properties

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.PointsCount'></a>

## Mesh\<TPoint\>\.PointsCount Property

Gets the number of points in the collection\. Returns \-1 if the point collection is null\.

```csharp
public int PointsCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An int representing the count of points, or \-1 if the collection is null\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.TrianglesCount'></a>

## Mesh\<TPoint\>\.TrianglesCount Property

Gets the total number of triangles\.

```csharp
public int TrianglesCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the count of triangles, or \-1 if the index collection is null\.
### Methods

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetConnectedIndexes(int)'></a>

## Mesh\<TPoint\>\.GetConnectedIndexes\(int\) Method

Retrieves the set of indexes connected to the specified index\.

```csharp
public System.Collections.Generic.HashSet<int>? GetConnectedIndexes(int index);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetConnectedIndexes(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The int index for which to find connections\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A `HashSet<int>` containing all connected indexes, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the internal collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or the provided int index is negative\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetConnectedPoints(int)'></a>

## Mesh\<TPoint\>\.GetConnectedPoints\(int\) Method

Retrieves a set of points connected to the point at the specified index\.

```csharp
public System.Collections.Generic.HashSet<TPoint>? GetConnectedPoints(int index);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetConnectedPoints(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index of the point\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the connected points, or `null` if the internal points collection is null or no connected indexes are found\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetIndexes()'></a>

## Mesh\<TPoint\>\.GetIndexes\(\) Method

Retrieves a list of integer arrays containing the indexes\.

```csharp
public System.Collections.Generic.List<int[]>? GetIndexes();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of `int[]` if the indexes are available; otherwise, null\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetIndexes(int)'></a>

## Mesh\<TPoint\>\.GetIndexes\(int\) Method

Retrieves the indices for the element at the specified index\.

```csharp
public int[]? GetIndexes(int index);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetIndexes(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index of the element to retrieve\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An `int[]` containing the indices if available; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetPoints()'></a>

## Mesh\<TPoint\>\.GetPoints\(\) Method

Retrieves a list of cloned [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint') objects\.

```csharp
public System.Collections.Generic.List<TPoint>? GetPoints();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A List\<TPoint\> containing the cloned points, or null if the internal collection is null\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.GetSortedBoundaryPoints()'></a>

## Mesh\<TPoint\>\.GetSortedBoundaryPoints\(\) Method

Retrieves the sorted boundary points based on the available indexes and point data\.

```csharp
public System.Collections.Generic.List<System.Collections.Generic.List<TPoint>>? GetSortedBoundaryPoints();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint') objects representing the sorted boundaries, or `null` if the internal indexes or points are null, or if the boundary index query fails\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.IndexOf(TPoint)'></a>

## Mesh\<TPoint\>\.IndexOf\(TPoint\) Method

Returns the zero\-based index of the first occurrence of the specified [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint') object in the collection\.

```csharp
public int IndexOf(TPoint? point);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.IndexOf(TPoint).point'></a>

`point` [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint')

The [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint') object to locate in the collection\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The zero\-based index of the first occurrence of the specified [TPoint](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_.TPoint 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>\.TPoint') object if found; otherwise, \-1\.

<a name='DiGi.Geometry.Core.Classes.Mesh_TPoint_.IsClosed()'></a>

## Mesh\<TPoint\>\.IsClosed\(\) Method

Determines whether the mesh forms a closed \(watertight, manifold\) surface, i\.e\. every edge is shared by exactly two triangles\.

Runs in a single pass over the triangles, keying each edge on its ordered pair of vertex indices, and exits early when a non-manifold edge (shared by more than two triangles) or a degenerate triangle is found.

This is the index-based counterpart of `DiGi.Geometry.Spatial.Query.IsClosed` for a polyhedron, which has no shared vertex table and so must weld coincident vertices within a tolerance before it can count edges the same way.

```csharp
public bool IsClosed();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if every edge of the mesh is shared by exactly two triangles; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\. Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the indexes are unavailable or the mesh has fewer than four triangles\.

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_'></a>

## UndirectedSegmentGraph\<T,X\> Class

Represents an abstract base class for an undirected graph composed of segments\.

```csharp
public abstract class UndirectedSegmentGraph<T,X> : DiGi.Core.Classes.SerializableObject
    where T : DiGi.Geometry.Core.Interfaces.IPoint<T>
    where X : DiGi.Geometry.Core.Interfaces.ISegment<T>
```
#### Type parameters

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.T'></a>

`T`

The type of point in the graph, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')\.

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.X'></a>

`X`

The type of segment in the graph, which must implement [DiGi\.Geometry\.Core\.Interfaces\.ISegment&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → UndirectedSegmentGraph\<T,X\>
### Properties

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.Segments'></a>

## UndirectedSegmentGraph\<T,X\>\.Segments Property

Gets or sets the list of [X](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.X 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.X') segments\.

```csharp
public abstract System.Collections.Generic.List<X>? Segments { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[X](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.X 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.Add(X)'></a>

## UndirectedSegmentGraph\<T,X\>\.Add\(X\) Method

Adds a segment to the collection\.

```csharp
public bool Add(X? segment);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.Add(X).segment'></a>

`segment` [X](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.X 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.X')

The [X](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.X 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.X') segment to be added\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the segment was successfully added; returns false if the [X](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.X 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.X') segment is null or if its start or end points are null\.

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.GetIndex(T)'></a>

## UndirectedSegmentGraph\<T,X\>\.GetIndex\(T\) Method

Retrieves the index of the specified point within the vertices of the undirected graph\.

```csharp
public int GetIndex(T? point);
```
#### Parameters

<a name='DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.GetIndex(T).point'></a>

`point` [T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.T 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.T')

The [T](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.UndirectedSegmentGraph_T,X_.T 'DiGi\.Geometry\.Core\.Classes\.UndirectedSegmentGraph\<T,X\>\.T') point to locate\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the zero\-based index of the point if it is found; otherwise, \-1\.