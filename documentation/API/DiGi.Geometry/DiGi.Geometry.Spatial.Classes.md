#### [DiGi\.Geometry](index.md 'index')

## DiGi\.Geometry\.Spatial\.Classes Namespace
### Classes

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D'></a>

## BoundingBox3D Class

Represents a three\-dimensional bounding box defined by minimum and maximum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public class BoundingBox3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Core.Interfaces.IBoundingBox<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.IBoundingBox, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → BoundingBox3D

Implements [DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## BoundingBox3D\(BoundingBox3D\) Constructor

Initializes a new instance of the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') class using an existing [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') object\.

```csharp
public BoundingBox3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') object to copy values from\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## BoundingBox3D\(Point3D, Point3D\) Constructor

Initializes a new instance of the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') class using two [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points to define the boundaries\.

```csharp
public BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` point used to calculate the minimum and maximum bounds\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point used to calculate the minimum and maximum bounds\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## BoundingBox3D\(Point3D, double\) Constructor

Initializes a new instance of the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') class using a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and an offset value\.

```csharp
public BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The optional [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to serve as the center point for the bounding box\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(DiGi.Geometry.Spatial.Classes.Point3D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') offset used to determine the extent of the bounding box from the center point\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## BoundingBox3D\(IEnumerable\<Point3D\>\) Constructor

Initializes a new instance of the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') class using a collection of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public BoundingBox3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects used to determine the minimum and maximum boundaries of the bounding box\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## BoundingBox3D\(IEnumerable\<Point3D\>, double\) Constructor

Initializes a new instance of the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') class using a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points and a specified offset\.

```csharp
public BoundingBox3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects used to determine the minimum and maximum boundaries\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value to apply as an offset to the bounding box\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Text.Json.Nodes.JsonObject)'></a>

## BoundingBox3D\(JsonObject\) Constructor

Initializes a new instance of the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public BoundingBox3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.BoundingBox3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the bounding box\. This value can be null\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Depth'></a>

## BoundingBox3D\.Depth Property

Gets the depth value, calculated as the difference between the Y\-coordinate of the maximum point and the Y\-coordinate of the minimum point\.
Returns a [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either the maximum or minimum points are null\.

```csharp
public double Depth { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the depth\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Height'></a>

## BoundingBox3D\.Height Property

Gets the height of the object, calculated as the difference between the Z\-coordinate of the maximum point and the Z\-coordinate of the minimum point\.

```csharp
public double Height { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the height, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the bounds are not defined\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Max'></a>

## BoundingBox3D\.Max Property

Gets or sets the maximum boundary point of the bounding volume\.
Setting this value expands the bounds to include the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D Max { get; set; }
```

Implements [Max](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1.max 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1\.Max')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the maximum coordinates\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Min'></a>

## BoundingBox3D\.Min Property

Gets or sets the minimum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point of the boundary\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D Min { get; set; }
```

Implements [Min](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundingbox-1.min 'DiGi\.Geometry\.Core\.Interfaces\.IBoundingBox\`1\.Min')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the minimum coordinates\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Width'></a>

## BoundingBox3D\.Width Property

Gets the width of the bounding area\.

```csharp
public double Width { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the difference between the maximum X coordinate and the minimum X coordinate, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either point is null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Add(DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## BoundingBox3D\.Add\(BoundingBox3D\) Method

Adds a [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to the collection\.

```csharp
public bool Add(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Add(DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') instance to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') was successfully added; returns `false` if the provided [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') or its minimum and maximum points are null\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Add(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## BoundingBox3D\.Add\(Point3D\) Method

Adds a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the bounding volume and updates the minimum and maximum bounds\.

```csharp
public bool Add(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Add(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point was successfully added; returns false if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Clone()'></a>

## BoundingBox3D\.Clone\(\) Method

Creates a copy of the current [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.GetCentroid()'></a>

## BoundingBox3D\.GetCentroid\(\) Method

Calculates the centroid of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetCentroid();
```

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the centroid, or null if it cannot be calculated\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.GetPoints()'></a>

## BoundingBox3D\.GetPoints\(\) Method

Retrieves a list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects representing the corners of the volume\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the calculated points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the minimum or maximum bounds are not defined\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.GetVolume()'></a>

## BoundingBox3D\.GetVolume\(\) Method

Calculates the volume based on the width, height, and depth properties\.

```csharp
public double GetVolume();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated volume as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if any of the dimensions are [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.BoundingBox3D,double)'></a>

## BoundingBox3D\.InRange\(BoundingBox3D, double\) Method

Determines whether the specified [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') is within range, considering a given tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the range check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the bounding box is within range; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Line3D,double)'></a>

## BoundingBox3D\.InRange\(Line3D, double\) Method

Determines whether the object is within a specified tolerance of the given [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Line3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Line3D,double).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to check against\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Line3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the object is within range of the line\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Plane,double)'></a>

## BoundingBox3D\.InRange\(Plane, double\) Method

Determines whether the object is within a specified tolerance of the given plane\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Plane? plane, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Plane,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check against\. If null, the method returns false\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Plane,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the object is in range\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the object is within the specified tolerance of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double)'></a>

## BoundingBox3D\.InRange\(Point3D, Point3D, bool, bool, double\) Method

Determines whether the range defined by two points intersects any of the associated planes within a specified tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, bool bounded_1, bool bounded_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point defining the range\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point defining the range\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).bounded_1'></a>

`bounded_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the first point is bounded\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).bounded_2'></a>

`bounded_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the second point is bounded\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for distance calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the range is within the specified criteria\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## BoundingBox3D\.InRange\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within the defined range, considering a given tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the allowed distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within the range\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Ray3D,double)'></a>

## BoundingBox3D\.InRange\(Ray3D, double\) Method

Determines whether the specified [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') is within the range, considering a given tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Ray3D? ray3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Ray3D,double).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to check for being in range\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Ray3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') is within the range\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## BoundingBox3D\.InRange\(Segment3D, double\) Method

Determines whether the specified [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') is within the range\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the distance calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') is within the range\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## BoundingBox3D\.InRange\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is within the defined range, considering a distance tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for the range check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is within range; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## BoundingBox3D\.Inside\(Point3D, double\) Method

Determines whether a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the bounding volume, accounting for a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used to shrink the boundary\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the volume; returns `false` if the point or bounding limits are null\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## BoundingBox3D\.Move\(Vector3D\) Method

Moves the object by the specified Vector3D vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? vector to use for the movement\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Offset(double)'></a>

## BoundingBox3D\.Offset\(double\) Method

Offsets the minimum and maximum points of the bounding box by the specified double value\.

```csharp
public void Offset(double value);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.Offset(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to offset the boundaries by\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## BoundingBox3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on the entity within the given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.BoundingBox3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the entity\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode'></a>

## BVHNode Class

Represents a concrete, non\-generic split\-axis Bounding Volume Hierarchy \(BVH\) node
that stores [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') elements\.

```csharp
public class BVHNode : DiGi.Geometry.Spatial.Classes.BVHNode<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>') → BVHNode
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.BVHNode(DiGi.Geometry.Spatial.Classes.BVHNode)'></a>

## BVHNode\(BVHNode\) Constructor

Initializes a new instance of the [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode') class by copying from another node\.

```csharp
public BVHNode(DiGi.Geometry.Spatial.Classes.BVHNode? other);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.BVHNode(DiGi.Geometry.Spatial.Classes.BVHNode).other'></a>

`other` [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode')

The source node to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.BVHNode(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_)'></a>

## BVHNode\(List\<IPolygonalFace3D\>\) Constructor

Initializes a new instance of the [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode') class by partitioning the input list of faces\.

```csharp
public BVHNode(System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.BVHNode(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of polygonal faces to partition\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.BVHNode(System.Text.Json.Nodes.JsonObject)'></a>

## BVHNode\(JsonObject\) Constructor

Initializes a new instance of the [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public BVHNode(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.BVHNode(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to deserialize\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.Clone()'></a>

## BVHNode\.Clone\(\) Method

Deep copies the current BVH tree\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a cloned copy of the current node\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.CreateNode(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_)'></a>

## BVHNode\.CreateNode\(List\<IPolygonalFace3D\>\) Method

Creates a concrete child node of type [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode')\.

```csharp
protected override DiGi.Geometry.Spatial.Classes.BVHNode<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? CreateNode(System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode.CreateNode(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of polygonal faces to assign to the child node\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')  
A concrete child instance of [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode')\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_'></a>

## BVHNode\<TPolygonalFace3D\> Class

Represents an abstract, generic split\-axis Bounding Volume Hierarchy \(BVH\) node 
designed to accelerate constructive solid geometry \(CSG\) queries on 3D polyhedra\.
This structure partitions 3D polygonal faces hierarchically for fast spatial overlap culling
during boolean operations such as Intersection, Union, and Difference\.

```csharp
public abstract class BVHNode<TPolygonalFace3D> : DiGi.Core.Classes.SerializableObject
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of 3D polygonal face, implementing [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → BVHNode\<TPolygonalFace3D\>

Derived  
↳ [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.BVHNode(DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_)'></a>

## BVHNode\(BVHNode\<TPolygonalFace3D\>\) Constructor

Initializes a new instance of the [BVHNode&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>') class 
by copying the properties from an existing node\.

```csharp
protected BVHNode(DiGi.Geometry.Spatial.Classes.BVHNode<TPolygonalFace3D>? other);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.BVHNode(DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_).other'></a>

`other` [DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')

The source node to copy values from\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.BVHNode(System.Collections.Generic.List_TPolygonalFace3D_)'></a>

## BVHNode\(List\<TPolygonalFace3D\>\) Constructor

Initializes a new instance of the [BVHNode&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>') class 
by partitioning the input list of faces hierarchically\.

```csharp
protected BVHNode(System.Collections.Generic.List<TPolygonalFace3D>? polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.BVHNode(System.Collections.Generic.List_TPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of polygonal faces to organize inside the spatial hierarchy\.

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.BVHNode(System.Text.Json.Nodes.JsonObject)'></a>

## BVHNode\(JsonObject\) Constructor

Initializes a new instance of the [BVHNode&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
protected BVHNode(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.BVHNode(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the node\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.Box'></a>

## BVHNode\<TPolygonalFace3D\>\.Box Property

Gets the bounding box that encompasses all geometry in this node and its children\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? Box { get; }
```

#### Property Value
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.Faces'></a>

## BVHNode\<TPolygonalFace3D\>\.Faces Property

Gets the list of polygonal faces stored directly in this leaf node \(null or empty if this is an internal node\)\.

```csharp
public System.Collections.Generic.List<TPolygonalFace3D>? Faces { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.Left'></a>

## BVHNode\<TPolygonalFace3D\>\.Left Property

Gets the left child node in the spatial hierarchy\.

```csharp
public DiGi.Geometry.Spatial.Classes.BVHNode<TPolygonalFace3D>? Left { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.Right'></a>

## BVHNode\<TPolygonalFace3D\>\.Right Property

Gets the right child node in the spatial hierarchy\.

```csharp
public DiGi.Geometry.Spatial.Classes.BVHNode<TPolygonalFace3D>? Right { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.CreateNode(System.Collections.Generic.List_TPolygonalFace3D_)'></a>

## BVHNode\<TPolygonalFace3D\>\.CreateNode\(List\<TPolygonalFace3D\>\) Method

Creates a child node of the concrete hierarchy type\.

```csharp
protected abstract DiGi.Geometry.Spatial.Classes.BVHNode<TPolygonalFace3D>? CreateNode(System.Collections.Generic.List<TPolygonalFace3D> polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.CreateNode(System.Collections.Generic.List_TPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of polygonal faces to assign to the child node\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')  
A concrete child instance of [BVHNode&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D'></a>

## Coordinate3D Class

Represents a three\-dimensional coordinate in space\.

```csharp
public abstract class Coordinate3D : DiGi.Geometry.Core.Classes.Coordinate, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ITransformable3D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') → Coordinate3D

Derived  
↳ [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
↳ [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransformable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D()'></a>

## Coordinate3D\(\) Constructor

Initializes a new instance of the [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') class\.

```csharp
public Coordinate3D();
```

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(DiGi.Geometry.Spatial.Classes.Coordinate3D)'></a>

## Coordinate3D\(Coordinate3D\) Constructor

Initializes a new instance of the [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') class using an existing [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') object\.

```csharp
public Coordinate3D(DiGi.Geometry.Spatial.Classes.Coordinate3D? coordinate3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(DiGi.Geometry.Spatial.Classes.Coordinate3D).coordinate3D'></a>

`coordinate3D` [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D')

The [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') instance to copy values from\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(double,double,double)'></a>

## Coordinate3D\(double, double, double\) Constructor

Initializes a new instance of the [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') class with specified X, Y, and Z coordinates\.

```csharp
public Coordinate3D(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate as a double value\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate as a double value\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z coordinate as a double value\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(double[])'></a>

## Coordinate3D\(double\[\]\) Constructor

Initializes a new instance of the [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') class using an array of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values\.

```csharp
public Coordinate3D(double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An optional array of double values\. If the array is null or contains fewer than three elements, all coordinates are initialized to [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(System.Text.Json.Nodes.JsonObject)'></a>

## Coordinate3D\(JsonObject\) Constructor

Initializes a new instance of the [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Coordinate3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Coordinate3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the coordinate\. This value can be null\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.X'></a>

## Coordinate3D\.X Property

Gets or sets the X\-coordinate value as a double\.

```csharp
public double X { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Y'></a>

## Coordinate3D\.Y Property

Gets or sets the Y\-coordinate value as a double\.

```csharp
public double Y { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Z'></a>

## Coordinate3D\.Z Property

Gets or sets the Z\-coordinate value as a double\.

```csharp
public double Z { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Coordinate3D\.Move\(Vector3D\) Method

Moves the object by adding the specified Vector3D offset to its current values\.

```csharp
public bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? vector used for translation\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool value indicating whether the movement was successfully applied\.

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D)'></a>

## Coordinate3D\.Transform\(ITransform3D\) Method

Transforms the current values using the specified 3D transformation\.

```csharp
public virtual bool Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Coordinate3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D).transform'></a>

`transform` [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') object used to perform the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D'></a>

## CoordinateSystem3D Class

Represents a three\-dimensional coordinate system defined by an origin and axes\.

```csharp
public class CoordinateSystem3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.ICoordinateSystem3D, DiGi.Geometry.Core.Interfaces.ICoordinateSystem<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ICoordinateSystem, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → CoordinateSystem3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ICoordinateSystem3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icoordinatesystem3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICoordinateSystem3D'), [DiGi\.Geometry\.Core\.Interfaces\.ICoordinateSystem&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icoordinatesystem-1 'DiGi\.Geometry\.Core\.Interfaces\.ICoordinateSystem\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icoordinatesystem-1 'DiGi\.Geometry\.Core\.Interfaces\.ICoordinateSystem\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ICoordinateSystem](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icoordinatesystem 'DiGi\.Geometry\.Core\.Interfaces\.ICoordinateSystem'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D)'></a>

## CoordinateSystem3D\(CoordinateSystem3D\) Constructor

Initializes a new instance of the [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') class by copying the properties from an existing [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') object\.

```csharp
public CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D).coordinateSystem3D'></a>

`coordinateSystem3D` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The source [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') object to copy data from\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## CoordinateSystem3D\(CoordinateSystem3D, Point3D\) Constructor

Initializes a new instance of the [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') class using the axes from an existing [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') and a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') as the origin\.

```csharp
public CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D, DiGi.Geometry.Spatial.Classes.Point3D? origin);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D,DiGi.Geometry.Spatial.Classes.Point3D).coordinateSystem3D'></a>

`coordinateSystem3D` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') from which to copy the axis vectors\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D,DiGi.Geometry.Spatial.Classes.Point3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the coordinate system\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CoordinateSystem3D\(Point3D, Vector3D\) Constructor

Initializes a new instance of the [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') class with the specified origin and Z\-axis\.

```csharp
public CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? axisZ);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The optional [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the coordinate system\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisZ'></a>

`axisZ` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The optional [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the direction of the Z\-axis\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CoordinateSystem3D\(Point3D, Vector3D, Vector3D\) Constructor

Initializes a new instance of the [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') class using the specified origin, X\-axis, and Y\-axis\.

```csharp
public CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? axisX, DiGi.Geometry.Spatial.Classes.Vector3D? axisY);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the origin of the coordinate system\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisX'></a>

`axisX` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction of the X\-axis\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisY'></a>

`axisY` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction of the Y\-axis\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(System.Text.Json.Nodes.JsonObject)'></a>

## CoordinateSystem3D\(JsonObject\) Constructor

Initializes a new instance of the [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public CoordinateSystem3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.CoordinateSystem3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.AxisX'></a>

## CoordinateSystem3D\.AxisX Property

Gets the X\-axis vector\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? AxisX { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the X\-axis, or null if it is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.AxisY'></a>

## CoordinateSystem3D\.AxisY Property

Gets the Y\-axis vector\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? AxisY { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Y\-axis, or null if it is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.AxisZ'></a>

## CoordinateSystem3D\.AxisZ Property

Gets the Z\-axis vector\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? AxisZ { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Z\-axis, or null if it is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.Origin'></a>

## CoordinateSystem3D\.Origin Property

Gets or sets the origin [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Origin { get; set; }
```

Implements [Origin](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icoordinatesystem-1.origin 'DiGi\.Geometry\.Core\.Interfaces\.ICoordinateSystem\`1\.Origin')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## CoordinateSystem3D\.ClosestPoint\(Point3D\) Method

Calculates the closest point on the line to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the line, or null if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D'), origin, or axis Z is null\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## CoordinateSystem3D\.Distance\(Point3D\) Method

Calculates the distance between the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and the closest point on this object\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to calculate the distance from\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if no closest point is found\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.GetAxis(DiGi.Geometry.Spatial.Enums.SpatialAxis)'></a>

## CoordinateSystem3D\.GetAxis\(SpatialAxis\) Method

Retrieves the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') associated with the specified [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? GetAxis(DiGi.Geometry.Spatial.Enums.SpatialAxis axis);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.GetAxis(DiGi.Geometry.Spatial.Enums.SpatialAxis).axis'></a>

`axis` [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')

The [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') to retrieve\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the axis, or null if the axis is undefined or invalid\.

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.Inverse()'></a>

## CoordinateSystem3D\.Inverse\(\) Method

Inverts the direction of the Z and Y axes\.

```csharp
public void Inverse();
```

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## CoordinateSystem3D\.Move\(Vector3D\) Method

Moves the object using the specified Vector3D? vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.CoordinateSystem3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? value representing the displacement\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D'></a>

## Ellipse3D Class

Represents a three\-dimensional ellipse defined on a plane\.

```csharp
public class Ellipse3D : DiGi.Geometry.Spatial.Classes.Planar<DiGi.Geometry.Planar.Classes.Ellipse2D>, DiGi.Geometry.Spatial.Interfaces.IEllipse3D, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IClosedPlanarCurve3D, DiGi.Geometry.Spatial.Interfaces.IClosedCurve3D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.IPlanar
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')[Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') → Ellipse3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IEllipse3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipse3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipse3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(DiGi.Geometry.Spatial.Classes.Ellipse3D)'></a>

## Ellipse3D\(Ellipse3D\) Constructor

Initializes a new instance of the [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') class using an existing [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') instance\.

```csharp
public Ellipse3D(DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(DiGi.Geometry.Spatial.Classes.Ellipse3D).ellipse3D'></a>

`ellipse3D` [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Ellipse3D\(Plane, Ellipse2D\) Constructor

Initializes a new instance of the [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')\.

```csharp
public Ellipse3D(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ellipse2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the ellipse is located\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') that defines the geometry of the ellipse\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(System.Text.Json.Nodes.JsonObject)'></a>

## Ellipse3D\(JsonObject\) Constructor

Initializes a new instance of the [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Ellipse3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Ellipse3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.A'></a>

## Ellipse3D\.A Property

Gets or sets the A value of the 2D geometry\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the underlying geometry is null\.

```csharp
public double A { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the A component\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.B'></a>

## Ellipse3D\.B Property

Gets or sets the double value for B from the associated 2D geometry\.
Returns double\.NaN if the underlying geometry is null\.

```csharp
public double B { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Center'></a>

## Ellipse3D\.Center Property

Gets the center point of the geometry converted to a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Center { get; }
```

Implements [Center](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipse3d.center 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipse3D\.Center')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the center, or null if the conversion cannot be performed\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Direction'></a>

## Ellipse3D\.Direction Property

Gets the direction of the ellipse as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Direction { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction, or null if it cannot be determined\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Clone()'></a>

## Ellipse3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.GetArea()'></a>

## Ellipse3D\.GetArea\(\) Method

Calculates the area of the 2D geometry\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getarea 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetArea')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the area, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the 2D geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.GetBoundingBox()'></a>

## Ellipse3D\.GetBoundingBox\(\) Method

Calculates the 3D bounding box of the geometry based on the associated plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the geometry is empty or the plane is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.GetFocalPoints()'></a>

## Ellipse3D\.GetFocalPoints\(\) Method

Retrieves the focal points of the geometry converted to 3D space\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D[]? GetFocalPoints();
```

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects representing the focal points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane or geometry is not defined or no focal points exist\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.GetInternalPoint(double)'></a>

## Ellipse3D\.GetInternalPoint\(double\) Method

Gets an internal point of the geometry converted to 3D space\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the calculation\.

Implements [GetInternalPoint\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getinternalpoint#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-getinternalpoint(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetInternalPoint\(System\.Double\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the internal point if the plane and geometry are available; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.GetPerimeter()'></a>

## Ellipse3D\.GetPerimeter\(\) Method

Calculates and returns the perimeter of the 2D geometry\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the perimeter, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the underlying geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Ellipse3D\.InRange\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within range of the geometry, given a specific tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the calculation\.

Implements [InRange\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inrange#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inrange(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.InRange\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within range\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Ellipse3D\.Inside\(Point3D, double\) Method

Determines whether the specified Point3D is inside the geometry within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The Point3D object to check\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the distance tolerance for the operation\.

Implements [Inside\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inside#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inside(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.Inside\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the point is inside the geometry\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipse3D.Inverse()'></a>

## Ellipse3D\.Inverse\(\) Method

Inverts the underlying 2D geometry if it is not null\.

```csharp
public void Inverse();
```

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid'></a>

## Ellipsoid Class

Represents an ellipsoid geometry in 3D space\.

```csharp
public class Ellipsoid : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IEllipsoid, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Ellipsoid

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid)'></a>

## Ellipsoid\(Ellipsoid\) Constructor

Initializes a new instance of the [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') class by copying the properties from an existing [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') object\.

```csharp
public Ellipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Ellipsoid).ellipsoid'></a>

`ellipsoid` [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') object to copy data from, or null to initialize a default instance\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Plane,double,double,double)'></a>

## Ellipsoid\(Plane, double, double, double\) Constructor

Initializes a new instance of the [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') class with the specified plane and semi\-axis lengths\.

```csharp
public Ellipsoid(DiGi.Geometry.Spatial.Classes.Plane? plane, double a, double b, double c);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Plane,double,double,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') that defines the ellipsoid's orientation, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Plane,double,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the first semi\-axis as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Plane,double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the second semi\-axis as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Plane,double,double,double).c'></a>

`c` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the third semi\-axis as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,double,double,double)'></a>

## Ellipsoid\(Point3D, double, double, double\) Constructor

Initializes a new instance of the [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') class with the specified center and semi\-axes lengths\.

```csharp
public Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D? center, double a, double b, double c);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).center'></a>

`center` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The `Point3D?` coordinates of the center point\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') length of the first semi\-axis\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') length of the second semi\-axis\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).c'></a>

`c` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') length of the third semi\-axis\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(System.Text.Json.Nodes.JsonObject)'></a>

## Ellipsoid\(JsonObject\) Constructor

Initializes a new instance of the [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Ellipsoid(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Ellipsoid(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.A'></a>

## Ellipsoid\.A Property

Gets the double value of A\.

```csharp
public double A { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.B'></a>

## Ellipsoid\.B Property

Gets the double value of B\.

```csharp
public double B { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.C'></a>

## Ellipsoid\.C Property

Gets the C constant of the plane equation as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

```csharp
public double C { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Center'></a>

## Ellipsoid\.Center Property

Gets the center point of the plane as a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Center { get; }
```

Implements [Center](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid.center 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid\.Center')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.DirectionA'></a>

## Ellipsoid\.DirectionA Property

Gets the X\-axis direction vector of the plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? DirectionA { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the first direction axis, or null if the plane is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.DirectionB'></a>

## Ellipsoid\.DirectionB Property

Gets the direction vector B, which represents the Y\-axis of the associated plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? DirectionB { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Y\-axis of the plane, or null if no plane is defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.DirectionC'></a>

## Ellipsoid\.DirectionC Property

Gets the direction vector for axis C, typically corresponding to the Z\-axis of the associated plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? DirectionC { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')? representing the direction of axis C, or null if no plane is defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Extent'></a>

## Ellipsoid\.Extent Property

Gets the extent of the ellipsoid as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Extent { get; }
```

Implements [Extent](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid.extent 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid\.Extent')

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the spatial extent, or null if not defined\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetBoundingBox()'></a>

## Ellipsoid\.GetBoundingBox\(\) Method

Calculates the bounding box of the object based on its center and extent\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the center or extent is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetFocalPoints(double)'></a>

## Ellipsoid\.GetFocalPoints\(double\) Method

Calculates the focal points of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D[]? GetFocalPoints(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetFocalPoints(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculations\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects representing the focal points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the center or directions are not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetPoint(double,double)'></a>

## Ellipsoid\.GetPoint\(double, double\) Method

Calculates a point in 3D space based on the specified theta and phi angles\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetPoint(double theta, double phi);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetPoint(double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The theta angle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetPoint(double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The phi angle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') if the plane axes are defined; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.GetVolume()'></a>

## Ellipsoid\.GetVolume\(\) Method

Calculates the volume of the ellipsoid\.

```csharp
public double GetVolume();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the calculated volume\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Ellipsoid\.Inside\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the boundary within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the point is inside the boundary\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Ellipsoid\.Move\(Vector3D\) Method

Moves the object using the specified Vector3D? vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? instance representing the movement vector\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A boolean value indicating whether the move operation was successful\.
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.op_ImplicitDiGi.Geometry.Spatial.Classes.Ellipsoid(DiGi.Geometry.Spatial.Classes.Sphere)'></a>

## Ellipsoid\.implicit operator Ellipsoid\(Sphere\) Operator

Implicitly converts a [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') to an [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipsoid? implicit operator DiGi.Geometry.Spatial.Classes.Ellipsoid?(DiGi.Geometry.Spatial.Classes.Sphere? sphere);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.op_ImplicitDiGi.Geometry.Spatial.Classes.Ellipsoid(DiGi.Geometry.Spatial.Classes.Sphere).sphere'></a>

`sphere` [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') instance to convert\.

#### Returns
[Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')  
An [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') created from the provided sphere, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the sphere is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.op_ImplicitDiGi.Geometry.Spatial.Classes.Ellipsoid(DiGi.Geometry.Spatial.Classes.Spheroid)'></a>

## Ellipsoid\.implicit operator Ellipsoid\(Spheroid\) Operator

Implicitly converts a [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') to an [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipsoid? implicit operator DiGi.Geometry.Spatial.Classes.Ellipsoid?(DiGi.Geometry.Spatial.Classes.Spheroid? spheroid);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ellipsoid.op_ImplicitDiGi.Geometry.Spatial.Classes.Ellipsoid(DiGi.Geometry.Spatial.Classes.Spheroid).spheroid'></a>

`spheroid` [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid')

The [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') instance to convert\.

#### Returns
[Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')  
An [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid') created from the provided spheroid, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the spheroid is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_'></a>

## Extrusion\<TSurface3D\> Class

Represents an abstract base class for a 3D geometry created by extruding a surface along a specific vector\.

```csharp
public abstract class Extrusion<TSurface3D> : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Core.Interfaces.IBoundable
    where TSurface3D : DiGi.Geometry.Spatial.Interfaces.ISurface3D
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D'></a>

`TSurface3D`

The type of the surface being extruded, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Extrusion\<TSurface3D\>

Derived  
↳ [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion')

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_)'></a>

## Extrusion\(Extrusion\<TSurface3D\>\) Constructor

Initializes a new instance of the [Extrusion&lt;TSurface3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>') class by cloning an existing [Extrusion&lt;TSurface3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>') object\.

```csharp
public Extrusion(DiGi.Geometry.Spatial.Classes.Extrusion<TSurface3D>? extrusion);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_).extrusion'></a>

`extrusion` [DiGi\.Geometry\.Spatial\.Classes\.Extrusion&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>')[TSurface3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>\.TSurface3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>')

The [Extrusion&lt;TSurface3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>') object to clone from\.

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(System.Text.Json.Nodes.JsonObject)'></a>

## Extrusion\(JsonObject\) Constructor

Initializes a new instance of the [Extrusion&lt;TSurface3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Extrusion(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the extrusion\.

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(TSurface3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Extrusion\(TSurface3D, Vector3D\) Constructor

Initializes a new instance of the [Extrusion&lt;TSurface3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>') class with the specified [TSurface3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>\.TSurface3D') surface and [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

```csharp
public Extrusion(TSurface3D? surface, DiGi.Geometry.Spatial.Classes.Vector3D? vector);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(TSurface3D,DiGi.Geometry.Spatial.Classes.Vector3D).surface'></a>

`surface` [TSurface3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>\.TSurface3D')

The [TSurface3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>\.TSurface3D') surface to extrude\.

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Extrusion(TSurface3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector'></a>

`vector` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector defining the extrusion direction and distance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Surface'></a>

## Extrusion\<TSurface3D\>\.Surface Property

Gets the 3D surface\.

```csharp
public TSurface3D? Surface { get; }
```

#### Property Value
[TSurface3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>\.TSurface3D')  
The [TSurface3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.TSurface3D 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>\.TSurface3D') instance representing the surface, or null if it is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Vector'></a>

## Extrusion\<TSurface3D\>\.Vector Property

Gets the associated [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Vector { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') object, or null if no vector is defined\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.GetBoundingBox()'></a>

## Extrusion\<TSurface3D\>\.GetBoundingBox\(\) Method

Calculates the bounding box of the object, incorporating the surface and any associated vector points\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the calculated bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no bounding box is available\.

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Extrusion\<TSurface3D\>\.Move\(Vector3D\) Method

Moves the object by the specified Vector3D? vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? value representing the displacement\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D'></a>

## Geometry3D Class

Represents an abstract base class for 3D geometry objects\.

```csharp
public abstract class Geometry3D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Geometry3D

Derived  
↳ [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
↳ [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')  
↳ [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')  
↳ [Extrusion&lt;TSurface3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>')  
↳ [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')  
↳ [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')  
↳ [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
↳ [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')  
↳ [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')  
↳ [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')  
↳ [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')  
↳ [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D')  
↳ [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')  
↳ [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid')  
↳ [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Geometry3D()'></a>

## Geometry3D\(\) Constructor

Initializes a new instance of the [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') class\.

```csharp
public Geometry3D();
```

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Geometry3D(DiGi.Geometry.Spatial.Classes.Geometry3D)'></a>

## Geometry3D\(Geometry3D\) Constructor

Initializes a new instance of the [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') class using the specified [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') instance\.

```csharp
public Geometry3D(DiGi.Geometry.Spatial.Classes.Geometry3D? geometry3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Geometry3D(DiGi.Geometry.Spatial.Classes.Geometry3D).geometry3D'></a>

`geometry3D` [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D')

The [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Geometry3D(System.Text.Json.Nodes.JsonObject)'></a>

## Geometry3D\(JsonObject\) Constructor

Initializes a new instance of the [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Geometry3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Geometry3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Geometry3D\.Move\(Vector3D\) Method

Moves the object by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public abstract bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Geometry3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The optional [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the displacement vector\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D'></a>

## IntersectionResult3D Class

Represents the result of a 3D intersection operation\.

```csharp
public class IntersectionResult3D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D, DiGi.Geometry.Core.Interfaces.IIntersectionResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → IntersectionResult3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D'), [IIntersectionResult](DiGi.Geometry.Core.Interfaces.md#DiGi.Geometry.Core.Interfaces.IIntersectionResult 'DiGi\.Geometry\.Core\.Interfaces\.IIntersectionResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D()'></a>

## IntersectionResult3D\(\) Constructor

Initializes a new instance of the [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') class\.

```csharp
public IntersectionResult3D();
```

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(DiGi.Geometry.Spatial.Classes.IntersectionResult3D)'></a>

## IntersectionResult3D\(IntersectionResult3D\) Constructor

Initializes a new instance of the [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') class using another [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') instance\.

```csharp
public IntersectionResult3D(DiGi.Geometry.Spatial.Classes.IntersectionResult3D? intersectionResult3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(DiGi.Geometry.Spatial.Classes.IntersectionResult3D).intersectionResult3D'></a>

`intersectionResult3D` [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')

The [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(DiGi.Geometry.Spatial.Interfaces.IGeometry3D)'></a>

## IntersectionResult3D\(IGeometry3D\) Constructor

Initializes a new instance of the [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') class with the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

```csharp
public IntersectionResult3D(DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(DiGi.Geometry.Spatial.Interfaces.IGeometry3D).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') to initialize the result with\. This value can be null\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IGeometry3D_)'></a>

## IntersectionResult3D\(IEnumerable\<IGeometry3D\>\) Constructor

Initializes a new instance of the [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') class\.

```csharp
public IntersectionResult3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IGeometry3D>? geometry3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IGeometry3D_).geometry3Ds'></a>

`geometry3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') objects to be cloned and stored in the result\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(System.Text.Json.Nodes.JsonObject)'></a>

## IntersectionResult3D\(JsonObject\) Constructor

Initializes a new instance of the [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public IntersectionResult3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.IntersectionResult3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Count'></a>

## IntersectionResult3D\.Count Property

Gets the total number of [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') elements contained in the collection\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.this[int]'></a>

## IntersectionResult3D\.this\[int\] Property

Gets the 3D geometry at the specified index\. The returned geometry is a clone of the original object to ensure encapsulation\.

```csharp
public DiGi.Geometry.Spatial.Interfaces.IGeometry3D? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the geometry to retrieve\.

#### Property Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Any()'></a>

## IntersectionResult3D\.Any\(\) Method

Determines whether there are any 3D geometries present\.

```csharp
public bool Any();
```

Implements [Any\(\)](DiGi.Geometry.Core.Interfaces.md#DiGi.Geometry.Core.Interfaces.IIntersectionResult.Any() 'DiGi\.Geometry\.Core\.Interfaces\.IIntersectionResult\.Any\(\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if any geometries are present; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Clone()'></a>

## IntersectionResult3D\.Clone\(\) Method

Creates a copy of the current [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Contains_T_()'></a>

## IntersectionResult3D\.Contains\<T\>\(\) Method

Determines whether the collection contains any object of the specified type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Contains_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D\.Contains\<T\>\(\)\.T')\.

```csharp
public bool Contains<T>()
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Contains_T_().T'></a>

`T`

The type of geometry to search for, which must implement the [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') interface\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether an object of type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D.Contains_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D\.Contains\<T\>\(\)\.T') is present in the collection\.

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.GetGeometry3Ds_T_()'></a>

## IntersectionResult3D\.GetGeometry3Ds\<T\>\(\) Method

Retrieves a list of 3D geometries of the specified type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D\.GetGeometry3Ds\<T\>\(\)\.T')\. Each matching geometry is cloned before being added to the result list\.

```csharp
public System.Collections.Generic.List<T>? GetGeometry3Ds<T>()
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.IntersectionResult3D.GetGeometry3Ds_T_().T'></a>

`T`

The type of geometry to retrieve, which must implement the [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') interface\.

Implements [GetGeometry3Ds&lt;T&gt;\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d.getgeometry3ds--1 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D\.GetGeometry3Ds\`\`1')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D\.GetGeometry3Ds\<T\>\(\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing clones of the geometries of type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D\.GetGeometry3Ds\<T\>\(\)\.T'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the internal geometry collection is null\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D'></a>

## Line3D Class

Represents a line in 3D space defined by an origin point and a direction vector\.

```csharp
public class Line3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.ILinear3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.ITransformable3D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Line3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransformable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Line3D)'></a>

## Line3D\(Line3D\) Constructor

Initializes a new instance of the [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') class by cloning an existing [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') object\.

```csharp
public Line3D(DiGi.Geometry.Spatial.Classes.Line3D? line3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Line3D).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The source [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') object to clone\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Line3D\(Point3D, Point3D\) Constructor

Initializes a new instance of the [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') class using two [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points to define the origin and direction\.

```csharp
public Line3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the line\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used to determine the unit direction vector from the origin\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Line3D\(Point3D, Vector3D\) Constructor

Initializes a new instance of the [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') class with the specified origin point and direction vector\.

```csharp
public Line3D(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? direction);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the line\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).direction'></a>

`direction` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the direction of the line\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(System.Text.Json.Nodes.JsonObject)'></a>

## Line3D\(JsonObject\) Constructor

Initializes a new instance of the [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') class\.

```csharp
public Line3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Line3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Direction'></a>

## Line3D\.Direction Property

Gets or sets the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Direction { get; set; }
```

Implements [Direction](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.direction 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Direction')

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A nullable [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the direction\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Origin'></a>

## Line3D\.Origin Property

Gets or sets the origin point of the 3D line\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Origin { get; set; }
```

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the origin, or null if not specified\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Clone()'></a>

## Line3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Line3D\.ClosestPoint\(Point3D\) Method

Calculates the closest point on the geometry to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

Implements [ClosestPoint\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.closestpoint#digi-geometry-spatial-interfaces-ilinear3d-closestpoint(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.ClosestPoint\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the geometry, or null if it cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double)'></a>

## Line3D\.Collinear\(ILinear3D, double\) Method

Determines whether this linear object is collinear with the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object within a given tolerance\.

```csharp
public bool Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D? linear3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).linear3D'></a>

`linear3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object to check for collinearity\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance used for the comparison\.

Implements [Collinear\(ILinear3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.collinear#digi-geometry-spatial-interfaces-ilinear3d-collinear(digi-geometry-spatial-interfaces-ilinear3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Collinear\(DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the objects are collinear; returns false if either linear object is null\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Line3D\.Distance\(Point3D\) Method

Calculates the distance between a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and this object\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance to calculate the distance from\.

Implements [Distance\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.distance#digi-geometry-spatial-interfaces-ilinear3d-distance(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Distance\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null or cannot be projected\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Equals(object)'></a>

## Line3D\.Equals\(object\) Method

Determines whether the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is equal to the current [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')\.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') to compare with the current [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is a [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') and has the same origin and direction as the current instance; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.GetHashCode()'></a>

## Line3D\.GetHashCode\(\) Method

Returns a hash code for the current object based on its origin and direction\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the hash code of the instance\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Line3D,double)'></a>

## Line3D\.IntersectionPoint\(Line3D, double\) Method

Calculates the intersection point between this object and the specified [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? IntersectionPoint(DiGi.Geometry.Spatial.Classes.Line3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Line3D,double).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to intersect with\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Line3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the intersection calculation\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the intersection point if one exists; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Line3D\.IntersectionPoint\(Segment3D, double\) Method

Calculates the intersection point between this object and a specified [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to intersect with\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the intersection point if it exists and lies on the segment; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Line3D\.Move\(Vector3D\) Method

Moves the object by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the translation\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Line3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on the object within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the maximum allowable distance for the point to be considered on the object\.

Implements [On\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.on#digi-geometry-spatial-interfaces-ilinear3d-on(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.On\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within the specified tolerance of the object\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Project(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Line3D\.Project\(Point3D\) Method

Projects a given [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') onto the line defined by the origin and direction\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Project(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Project(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to project\.

Implements [Project\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.project#digi-geometry-spatial-interfaces-ilinear3d-project(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Project\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The projected [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D'), or null if the projection cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D)'></a>

## Line3D\.Transform\(ITransform3D\) Method

Transforms the origin and direction of the object using the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') transformation\.

```csharp
public bool Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D).transform'></a>

`transform` [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') instance to apply for the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied; returns `false` if the [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') transform, origin, or direction is null\.
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Line3D.op_Equality(DiGi.Geometry.Spatial.Classes.Line3D,DiGi.Geometry.Spatial.Classes.Line3D)'></a>

## Line3D\.operator ==\(Line3D, Line3D\) Operator

Indicates whether the two specified [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') objects are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Spatial.Classes.Line3D? line3D_1, DiGi.Geometry.Spatial.Classes.Line3D? line3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.op_Equality(DiGi.Geometry.Spatial.Classes.Line3D,DiGi.Geometry.Spatial.Classes.Line3D).line3D_1'></a>

`line3D_1` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The first [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') object to compare\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.op_Equality(DiGi.Geometry.Spatial.Classes.Line3D,DiGi.Geometry.Spatial.Classes.Line3D).line3D_2'></a>

`line3D_2` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The second [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') object to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Line3D,DiGi.Geometry.Spatial.Classes.Line3D)'></a>

## Line3D\.operator \!=\(Line3D, Line3D\) Operator

Indicates whether the two specified [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') objects are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Spatial.Classes.Line3D? line3D_1, DiGi.Geometry.Spatial.Classes.Line3D? line3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Line3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Line3D,DiGi.Geometry.Spatial.Classes.Line3D).line3D_1'></a>

`line3D_1` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The first [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') object to compare\.

<a name='DiGi.Geometry.Spatial.Classes.Line3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Line3D,DiGi.Geometry.Spatial.Classes.Line3D).line3D_2'></a>

`line3D_2` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The second [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') object to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D'></a>

## Mesh3D Class

Represents a three\-dimensional mesh composed of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') vertices\.

```csharp
public class Mesh3D : DiGi.Geometry.Core.Classes.Mesh<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.ICollectable3D, DiGi.Geometry.Core.Interfaces.ICollectable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Geometry\.Core\.Classes\.Mesh&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Mesh_TPoint_ 'DiGi\.Geometry\.Core\.Classes\.Mesh\<TPoint\>') → Mesh3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICollectable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icollectable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICollectable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Mesh3D\(Mesh3D\) Constructor

Initializes a new instance of the [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') class by copying an existing [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instance\.

```csharp
public Mesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,System.Collections.Generic.IEnumerable_int[]_)'></a>

## Mesh3D\(IEnumerable\<Point3D\>, IEnumerable\<int\[\]\>\) Constructor

Initializes a new instance of the [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') class using the specified collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points and integer array indexes\.

```csharp
public Mesh3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? points, System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,System.Collections.Generic.IEnumerable_int[]_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects representing the vertices of the mesh\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,System.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') arrays representing the vertex indices for each face of the mesh\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(System.Text.Json.Nodes.JsonObject)'></a>

## Mesh3D\(JsonObject\) Constructor

Initializes a new instance of the [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Mesh3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Mesh3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the mesh\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Clone()'></a>

## Mesh3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetAuxiliarySegments()'></a>

## Mesh3D\.GetAuxiliarySegments\(\) Method

Retrieves a list of auxiliary segments based on the available points and indexes\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetAuxiliarySegments();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the auxiliary segments, or `null` if the points, indexes, or auxiliary index data are unavailable\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetBoundaryEdges()'></a>

## Mesh3D\.GetBoundaryEdges\(\) Method

Retrieves the boundary edges of the geometry as a list of polyloops\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polyloop>? GetBoundaryEdges();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the boundary edges if they are successfully calculated; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetBoundaryEdges(System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Segment3D_)'></a>

## Mesh3D\.GetBoundaryEdges\(List\<Segment3D\>\) Method

Retrieves the boundary edges as a list of [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop')\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polyloop>? GetBoundaryEdges(out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? auxiliarySegments);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetBoundaryEdges(System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Segment3D_).auxiliarySegments'></a>

`auxiliarySegments` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When called, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of auxiliary segments, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if none are found\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the boundary edges, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the points or indexes are not available\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetBoundingBox()'></a>

## Mesh3D\.GetBoundingBox\(\) Method

Calculates and returns the bounding box for the set of points\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the points are not available\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetTriangle(int)'></a>

## Mesh3D\.GetTriangle\(int\) Method

Retrieves the [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') at the specified index\.

```csharp
public DiGi.Geometry.Spatial.Classes.Triangle3D? GetTriangle(int index);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetTriangle(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the triangle to retrieve as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

#### Returns
[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')  
A [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') object if the index is valid and data exists; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.GetTriangles()'></a>

## Mesh3D\.GetTriangles\(\) Method

Retrieves a list of [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects based on the available points and indexes\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Triangle3D>? GetTriangles();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the triangles if the data is valid; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Mesh3D\.Move\(Vector3D\) Method

Moves all points by the specified Vector3D offset\.

```csharp
public bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector2D'></a>

`vector2D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? translation vector used to move the points\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D)'></a>

## Mesh3D\.Transform\(ITransform3D\) Method

Transforms the points using the specified 3D transformation\.

```csharp
public bool Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Mesh3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D).transform'></a>

`transform` [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') object used to perform the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied; returns false if the [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') transform or the points collection is null\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_'></a>

## Planar\<T\> Class

Represents an abstract 3D geometry that exists on a plane and is associated with a corresponding 2D geometry of type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.T 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.T')\.

```csharp
public abstract class Planar<T> : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IPlanar<T>, DiGi.Geometry.Spatial.Interfaces.IPlanar, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IFlippable
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.T'></a>

`T`

The type of the 2D geometry, which must implement the [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') interface\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Planar\<T\>

Derived  
↳ [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')  
↳ [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
↳ [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
↳ [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.T 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iflippable 'DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Planar_T_)'></a>

## Planar\(Planar\<T\>\) Constructor

Initializes a new instance of the [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') class by cloning an existing [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') instance\.

```csharp
public Planar(DiGi.Geometry.Spatial.Classes.Planar<T>? planar);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Planar_T_).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')[T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.T 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.T')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')

The source [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## Planar\(Plane\) Constructor

Initializes a new instance of the [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.Plane')\.

```csharp
public Planar(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.Plane') used to initialize the planar object\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Plane,T)'></a>

## Planar\(Plane, T\) Constructor

Initializes a new instance of the [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') class\.

```csharp
public Planar(DiGi.Geometry.Spatial.Classes.Plane? plane, T? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Plane,T).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.Plane') that defines the planar surface\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(DiGi.Geometry.Spatial.Classes.Plane,T).geometry2D'></a>

`geometry2D` [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.T 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.T')

The 2D geometry of type \<typeparam ref="T" /\> to be associated with this instance\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(System.Text.Json.Nodes.JsonObject)'></a>

## Planar\(JsonObject\) Constructor

Initializes a new instance of the [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Planar(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Planar(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Geometry2D'></a>

## Planar\<T\>\.Geometry2D Property

Gets the 2D geometry representation\.

```csharp
public T? Geometry2D { get; }
```

Implements [Geometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1.geometry2d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1\.Geometry2D')

#### Property Value
[T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.T 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.T')

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Plane'></a>

## Planar\<T\>\.Plane Property

Gets the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.Plane') associated with this object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Plane? Plane { get; }
```

Implements [Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar.plane 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\.Plane')

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\.Plane') instance if one exists; otherwise, null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis,DiGi.Geometry.Spatial.Enums.SpatialAxis)'></a>

## Planar\<T\>\.Flip\(SpatialAxis, SpatialAxis\) Method

Flips the orientation of the plane based on the specified primary and secondary axes\.

```csharp
public bool Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis prmiaryAxis=DiGi.Geometry.Spatial.Enums.SpatialAxis.Z, DiGi.Geometry.Spatial.Enums.SpatialAxis secondaryAxis=DiGi.Geometry.Spatial.Enums.SpatialAxis.X);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis,DiGi.Geometry.Spatial.Enums.SpatialAxis).prmiaryAxis'></a>

`prmiaryAxis` [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')

The [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') representing the primary axis for the flip operation\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis,DiGi.Geometry.Spatial.Enums.SpatialAxis).secondaryAxis'></a>

`secondaryAxis` [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')

The [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') representing the secondary axis for the flip operation\.

Implements [Flip\(SpatialAxis, SpatialAxis\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iflippable.flip#digi-geometry-spatial-interfaces-iflippable-flip(digi-geometry-spatial-enums-spatialaxis-digi-geometry-spatial-enums-spatialaxis) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable\.Flip\(DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis,DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the flip operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Planar\<T\>\.Move\(Vector3D\) Method

Moves the object based on the provided Vector3D vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Planar_T_.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The optional Vector3D value specifying the direction and distance to move\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A boolean value indicating whether the movement was successful\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult'></a>

## PlanarIntersectionResult Class

Represents the result of a planar intersection operation in 3D space\.

```csharp
public class PlanarIntersectionResult : DiGi.Geometry.Spatial.Classes.PlanarResult, DiGi.Geometry.Spatial.Interfaces.IIntersectionResult3D, DiGi.Geometry.Core.Interfaces.IIntersectionResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') → PlanarIntersectionResult

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iintersectionresult3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IIntersectionResult3D'), [IIntersectionResult](DiGi.Geometry.Core.Interfaces.md#DiGi.Geometry.Core.Interfaces.IIntersectionResult 'DiGi\.Geometry\.Core\.Interfaces\.IIntersectionResult'), [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult()'></a>

## PlanarIntersectionResult\(\) Constructor

Initializes a new instance of the [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') class\.

```csharp
public PlanarIntersectionResult();
```

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult)'></a>

## PlanarIntersectionResult\(PlanarIntersectionResult\) Constructor

Initializes a new instance of the [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') class using another [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') instance\.

```csharp
public PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? planarIntersectionResult);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult).planarIntersectionResult'></a>

`planarIntersectionResult` [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')

The [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## PlanarIntersectionResult\(Plane\) Constructor

Initializes a new instance of the [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used to initialize the result\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## PlanarIntersectionResult\(Plane, IGeometry2D\) Constructor

Initializes a new instance of the [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') class\.

```csharp
public PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the intersection\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') resulting from the intersection\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## PlanarIntersectionResult\(Plane, IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') class with the specified plane and a collection of 2D geometries\.

```csharp
public PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') that defines the planar intersection, or null if not applicable\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the 2D geometries resulting from the intersection, or null if no geometries were found\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(System.Text.Json.Nodes.JsonObject)'></a>

## PlanarIntersectionResult\(JsonObject\) Constructor

Initializes a new instance of the [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public PlanarIntersectionResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.PlanarIntersectionResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.Any()'></a>

## PlanarIntersectionResult\.Any\(\) Method

Determines whether an intersection exists\.

```csharp
public bool Any();
```

Implements [Any\(\)](DiGi.Geometry.Core.Interfaces.md#DiGi.Geometry.Core.Interfaces.IIntersectionResult.Any() 'DiGi\.Geometry\.Core\.Interfaces\.IIntersectionResult\.Any\(\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value that is true if the count of intersecting elements is greater than zero; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult.Clone()'></a>

## PlanarIntersectionResult\.Clone\(\) Method

Creates a copy of the current [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult'></a>

## PlanarResult Class

Represents an abstract base class for results that are defined on a 2D plane\.

```csharp
public abstract class PlanarResult : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PlanarResult

Derived  
↳ [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
↳ [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')

Implements [DiGi\.Core\.Interfaces\.ISerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableresult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [DiGi\.Core\.Interfaces\.IResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iresult 'DiGi\.Core\.Interfaces\.IResult'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult()'></a>

## PlanarResult\(\) Constructor

Initializes a new instance of the [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') class\.

```csharp
public PlanarResult();
```

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.PlanarResult)'></a>

## PlanarResult\(PlanarResult\) Constructor

Initializes a new instance of the [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') class by copying the data from an existing [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') instance\.

```csharp
public PlanarResult(DiGi.Geometry.Spatial.Classes.PlanarResult? planarResult);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.PlanarResult).planarResult'></a>

`planarResult` [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult')

The source [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') instance to copy\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## PlanarResult\(Plane\) Constructor

Initializes a new instance of the [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Plane 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Plane')\.

```csharp
public PlanarResult(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Plane 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Plane') to initialize the result with, or null\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## PlanarResult\(Plane, IGeometry2D\) Constructor

Initializes a new instance of the [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') class\.

```csharp
public PlanarResult(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Plane 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Plane') to associate with this result, or null\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') geometry to include in the result, or null\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## PlanarResult\(Plane, IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') class\.

```csharp
public PlanarResult(DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Plane 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Plane') to associate with this result, or null\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects to associate with this result, or null\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(System.Text.Json.Nodes.JsonObject)'></a>

## PlanarResult\(JsonObject\) Constructor

Initializes a new instance of the [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public PlanarResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.PlanarResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\. This value can be null\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.Count'></a>

## PlanarResult\.Count Property

Gets the number of geometry elements contained in this object\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.Plane'></a>

## PlanarResult\.Plane Property

Gets the associated [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Plane 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Plane') instance\.

```csharp
public DiGi.Geometry.Spatial.Classes.Plane? Plane { get; }
```

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Plane 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Plane') object, or `null` if no plane is defined\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.Contains_T_()'></a>

## PlanarResult\.Contains\<T\>\(\) Method

Determines whether the collection contains any geometry objects of the specified type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Contains_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Contains\<T\>\(\)\.T')\.

```csharp
public bool Contains<T>()
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.Contains_T_().T'></a>

`T`

The type of geometry to search for, which must implement the [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') interface\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether an object of type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.Contains_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.Contains\<T\>\(\)\.T') is present in the collection\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry2Ds_T_()'></a>

## PlanarResult\.GetGeometry2Ds\<T\>\(\) Method

Retrieves a list of cloned 2D geometry objects of the specified type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry2Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.GetGeometry2Ds\<T\>\(\)\.T')\.

```csharp
public System.Collections.Generic.List<T>? GetGeometry2Ds<T>()
    where T : DiGi.Geometry.Planar.Interfaces.IGeometry2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry2Ds_T_().T'></a>

`T`

The type of geometry to retrieve, which must implement IGeometry2D\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry2Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.GetGeometry2Ds\<T\>\(\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<T>` containing clones of the 2D geometry objects if the collection is not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry3Ds_T_()'></a>

## PlanarResult\.GetGeometry3Ds\<T\>\(\) Method

Retrieves a list of 3D geometry objects of the specified type [T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.GetGeometry3Ds\<T\>\(\)\.T')\.

```csharp
public System.Collections.Generic.List<T>? GetGeometry3Ds<T>()
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry3Ds_T_().T'></a>

`T`

The type of 3D geometry to retrieve, which must implement the [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') interface\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult.GetGeometry3Ds_T_().T 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult\.GetGeometry3Ds\<T\>\(\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted 3D geometries, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no source 2D geometries are available\.

<a name='DiGi.Geometry.Spatial.Classes.Plane'></a>

## Plane Class

Represents a plane in 3D space, inheriting from [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') and implementing [DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iflippable 'DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable')\.

```csharp
public class Plane : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IFlippable, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Plane

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iflippable 'DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## Plane\(Plane\) Constructor

Initializes a new instance of the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') class by copying the values from an existing [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') object\.

```csharp
public Plane(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The source [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') object to copy data from\. If null, the current instance remains uninitialized\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Plane\(Plane, Point3D\) Constructor

Initializes a new instance of the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') class using an existing [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') for orientation and an optional [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for the origin\.

```csharp
public Plane(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? origin);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') object to copy the normal and axisY vectors from\. Can be null\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') object to set as the origin of the plane\. Can be null\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Plane\(Point3D, Point3D, Point3D\) Constructor

Initializes a new instance of the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') class using three points to define the plane's origin and orientation\.

```csharp
public Plane(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?`, which is used as the origin of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` used to determine the normal vector of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third `Point3D?` used to determine the normal vector of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Plane\(Point3D, Vector3D\) Constructor

Initializes a new instance of the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') class using the specified origin point and normal vector\.

```csharp
public Plane(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The optional [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The optional [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the normal vector of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Plane\(Point3D, Vector3D, Vector3D\) Constructor

Initializes a new instance of the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') class using an origin point and two basis vectors\.

```csharp
public Plane(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? axisX, DiGi.Geometry.Spatial.Classes.Vector3D? axisY);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The `Point3D?` representing the origin point of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisX'></a>

`axisX` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The `Vector3D?` representing the X\-axis vector of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisY'></a>

`axisY` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Y\-axis vector of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(System.Text.Json.Nodes.JsonObject)'></a>

## Plane\(JsonObject\) Constructor

Initializes a new instance of the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Plane(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Plane(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the plane\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Plane.A'></a>

## Plane\.A Property

A factor for point\-normal equation A\(x−a\)\+B\(y−b\)\+C\(z−c\) = 0 where origin\(a,b,c\), normal\(A,B,C\)

```csharp
public double A { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A value for point\-normal equation

<a name='DiGi.Geometry.Spatial.Classes.Plane.AxisX'></a>

## Plane\.AxisX Property

Gets the X\-axis vector of the coordinate system\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? AxisX { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the X\-axis, or null if it cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.AxisY'></a>

## Plane\.AxisY Property

Gets the Y\-axis as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? AxisY { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Y\-axis, or null if it is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.AxisZ'></a>

## Plane\.AxisZ Property

Gets the Z\-axis vector derived from the normal\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? AxisZ { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Z\-axis if the normal is defined; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.B'></a>

## Plane\.B Property

B factor for point\-normal equation A\(x−a\)\+B\(y−b\)\+C\(z−c\) = 0 where origin\(a,b,c\), normal\(A,B,C\)

```csharp
public double B { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
B value for point\-normal equation

<a name='DiGi.Geometry.Spatial.Classes.Plane.C'></a>

## Plane\.C Property

C factor for point\-normal equation A\(x−a\)\+B\(y−b\)\+C\(z−c\) = 0 where origin\(a,b,c\), normal\(A,B,C\)

```csharp
public double C { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
C value for point\-normal equation

<a name='DiGi.Geometry.Spatial.Classes.Plane.D'></a>

## Plane\.D Property

D factor for point\-normal equation Ax\+By\+Cz = D where origin\(a,b,c\), normal\(A,B,C\)

```csharp
public double D { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
D value for point\-normal equation

<a name='DiGi.Geometry.Spatial.Classes.Plane.Normal'></a>

## Plane\.Normal Property

Gets the normal vector of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Normal { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normal vector, or null if it is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Origin'></a>

## Plane\.Origin Property

Gets or sets the origin point in 3D space\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Origin { get; set; }
```

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A `Point3D?` representing the origin coordinates\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Plane.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Plane\.ClosestPoint\(Point3D\) Method

Calculates the closest point on the plane to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the plane, or null if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') or the plane normal is null\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Coplanar(DiGi.Geometry.Spatial.Classes.Plane,double)'></a>

## Plane\.Coplanar\(Plane, double\) Method

Determines whether this plane is coplanar with the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public bool Coplanar(DiGi.Geometry.Spatial.Classes.Plane? plane, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Coplanar(DiGi.Geometry.Spatial.Classes.Plane,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to compare against\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Coplanar(DiGi.Geometry.Spatial.Classes.Plane,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the planes are coplanar\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Plane\.Distance\(Point3D\) Method

Calculates the distance between the current object and the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to calculate the distance to\. This value can be null\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided point is null or a closest point cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis,DiGi.Geometry.Spatial.Enums.SpatialAxis)'></a>

## Plane\.Flip\(SpatialAxis, SpatialAxis\) Method

Flips the orientation based on the specified primary and secondary spatial axes\.

```csharp
public bool Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis prmiaryAxis=DiGi.Geometry.Spatial.Enums.SpatialAxis.Z, DiGi.Geometry.Spatial.Enums.SpatialAxis secondaryAxis=DiGi.Geometry.Spatial.Enums.SpatialAxis.X);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis,DiGi.Geometry.Spatial.Enums.SpatialAxis).prmiaryAxis'></a>

`prmiaryAxis` [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')

The [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') representing the primary axis\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Flip(DiGi.Geometry.Spatial.Enums.SpatialAxis,DiGi.Geometry.Spatial.Enums.SpatialAxis).secondaryAxis'></a>

`secondaryAxis` [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')

The [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') representing the secondary axis\.

Implements [Flip\(SpatialAxis, SpatialAxis\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iflippable.flip#digi-geometry-spatial-interfaces-iflippable-flip(digi-geometry-spatial-enums-spatialaxis-digi-geometry-spatial-enums-spatialaxis) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable\.Flip\(DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis,DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the flip operation was successfully performed\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.GetAxis(DiGi.Geometry.Spatial.Enums.SpatialAxis)'></a>

## Plane\.GetAxis\(SpatialAxis\) Method

Retrieves the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') associated with the specified [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? GetAxis(DiGi.Geometry.Spatial.Enums.SpatialAxis axis);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.GetAxis(DiGi.Geometry.Spatial.Enums.SpatialAxis).axis'></a>

`axis` [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis')

The [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') to retrieve\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the axis, or null if the [SpatialAxis](DiGi.Geometry.Spatial.Enums.md#DiGi.Geometry.Spatial.Enums.SpatialAxis 'DiGi\.Geometry\.Spatial\.Enums\.SpatialAxis') is undefined\.

<a name='DiGi.Geometry.Spatial.Classes.Plane.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Plane\.Move\(Vector3D\) Method

Moves the object by the specified Vector3D? vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Plane.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? value representing the displacement\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D'></a>

## Point3D Class

Represents a point in three\-dimensional space\.

```csharp
public class Point3D : DiGi.Geometry.Spatial.Classes.Coordinate3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Core.Interfaces.IPoint<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.IPoint, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.ITransformable3D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') → [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') → Point3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IPoint](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint 'DiGi\.Geometry\.Core\.Interfaces\.IPoint'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransformable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Point3D\(Point3D\) Constructor

Initializes a new instance of the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') class using the values from an existing [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance\.

```csharp
public Point3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance to copy values from\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(double,double,double)'></a>

## Point3D\(double, double, double\) Constructor

Initializes a new instance of the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') class with the specified double x, double y, and double z coordinates\.

```csharp
public Point3D(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value for the X coordinate\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value for the Y coordinate\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value for the Z coordinate\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(double[])'></a>

## Point3D\(double\[\]\) Constructor

Initializes a new instance of the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') class using an array of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

```csharp
public Point3D(double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An array of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') containing the coordinate values\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(System.Text.Json.Nodes.JsonObject)'></a>

## Point3D\(JsonObject\) Constructor

Initializes a new instance of the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Point3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Point3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the point\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Clone()'></a>

## Point3D\.Clone\(\) Method

Creates a copy of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Point3D\.Distance\(Point3D\) Method

Calculates the distance between this point and a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to calculate the distance to\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.GetAbs()'></a>

## Point3D\.GetAbs\(\) Method

Returns a new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance containing the absolute values of the current point's coordinates\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D GetAbs();
```

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') object with absolute coordinate values\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.GetMoved(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Point3D\.GetMoved\(Vector3D\) Method

Returns a new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that is the result of moving this point by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetMoved(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.GetMoved(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to move the point by\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the moved position, or `null` if the provided [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') is `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.InDistance(DiGi.Geometry.Spatial.Classes.Point3D,double,double)'></a>

## Point3D\.InDistance\(Point3D, double, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within a given distance, accounting for an optional tolerance\.

```csharp
public bool InDistance(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double distance, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.InDistance(DiGi.Geometry.Spatial.Classes.Point3D,double,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.InDistance(DiGi.Geometry.Spatial.Classes.Point3D,double,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum allowed distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.InDistance(DiGi.Geometry.Spatial.Classes.Point3D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') to be added to the distance threshold\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the point is within the specified distance and tolerance; returns `false` if [point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D.InDistance(DiGi.Geometry.Spatial.Classes.Point3D,double,double).point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D\.InDistance\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double\)\.point3D') is null\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Mid(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Point3D\.Mid\(Point3D\) Method

Calculates the midpoint between this point and another [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Mid(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.Mid(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The other [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to calculate the midpoint with\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the midpoint, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Addition(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Point3D\.operator \+\(Point3D, Vector3D\) Operator

Adds a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to produce a new point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? operator +(DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Addition(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The starting [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Addition(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to add to the point\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') resulting from the addition, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Point3D\.operator \-\(Point3D, Point3D\) Operator

Subtracts one [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') from another to produce a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator -(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') resulting from the subtraction, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Point3D\.operator \-\(Point3D, Vector3D\) Operator

Subtracts a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') from a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to produce a new point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? operator -(DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The starting [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

<a name='DiGi.Geometry.Spatial.Classes.Point3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to subtract from the point\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') resulting from the subtraction, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D'></a>

## Polygon3D Class

Represents a three\-dimensional polygon defined on a specific plane\.

```csharp
public class Polygon3D : DiGi.Geometry.Spatial.Classes.Planar<DiGi.Geometry.Planar.Classes.Polygon2D>, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D<DiGi.Geometry.Planar.Classes.Polygon2D>, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D, DiGi.Geometry.Spatial.Interfaces.IClosedPlanarCurve3D, DiGi.Geometry.Spatial.Interfaces.IClosedCurve3D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D, DiGi.Geometry.Spatial.Interfaces.IPlanar, DiGi.Geometry.Spatial.Interfaces.IPlanar<DiGi.Geometry.Planar.Classes.Polygon2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') → Polygon3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polygon2D)'></a>

## Polygon3D\(Plane, Polygon2D\) Constructor

Initializes a new instance of the [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

```csharp
public Polygon3D(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polygon2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the polygon is defined\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polygon2D).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') that defines the 2D shape of the polygon\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Polygon3D\(Plane, IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public Polygon3D(DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the polygon is defined\. This value can be null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the 2D points that define the vertices of the polygon\. This value can be null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Polygon3D)'></a>

## Polygon3D\(Polygon3D\) Constructor

Initializes a new instance of the [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') class by copying an existing [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') object\.

```csharp
public Polygon3D(DiGi.Geometry.Spatial.Classes.Polygon3D? polygon3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(DiGi.Geometry.Spatial.Classes.Polygon3D).polygon3D'></a>

`polygon3D` [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(System.Text.Json.Nodes.JsonObject)'></a>

## Polygon3D\(JsonObject\) Constructor

Initializes a new instance of the [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Polygon3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Polygon3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the polygon\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Length'></a>

## Polygon3D\.Length Property

Gets the length of the geometry\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the length, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the underlying geometry is null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Clone()'></a>

## Polygon3D\.Clone\(\) Method

Creates a copy of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Polygon3D\.ClosestPoint\(Point3D\) Method

Calculates the closest point on the geometry to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is sought\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found, or null if the input [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null or the geometry is not available\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetArea()'></a>

## Polygon3D\.GetArea\(\) Method

Calculates the area of the 2D geometry\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getarea 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetArea')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the area, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the 2D geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetBoundingBox()'></a>

## Polygon3D\.GetBoundingBox\(\) Method

Calculates the 3D bounding box for the current geometry based on its points\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') containing all points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no points are available\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetCentroid()'></a>

## Polygon3D\.GetCentroid\(\) Method

Calculates the centroid of the geometry and converts it to a 3D point\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetCentroid();
```

Implements [GetCentroid\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.getcentroid 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.GetCentroid')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the centroid, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane or geometry is not available\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetInternalPoint(double)'></a>

## Polygon3D\.GetInternalPoint\(double\) Method

Gets an internal point of the geometry converted to 3D space\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the calculation\.

Implements [GetInternalPoint\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getinternalpoint#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-getinternalpoint(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetInternalPoint\(System\.Double\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the internal point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane or geometry is not available\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetPerimeter()'></a>

## Polygon3D\.GetPerimeter\(\) Method

Gets the perimeter of the geometry\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the total length of the perimeter\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetPoints()'></a>

## Polygon3D\.GetPoints\(\) Method

Retrieves a list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects by converting the 2D points from the geometry using the associated plane\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane, geometry, or source points are unavailable\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.GetSegments()'></a>

## Polygon3D\.GetSegments\(\) Method

Retrieves a list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segments\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects if points are available; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polygon3D\.InRange\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within range based on the provided tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the range check\.

Implements [InRange\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inrange#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inrange(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.InRange\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within range; otherwise, false if the point or required internal geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Polygon3D\.InRange\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is within a given distance tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to check\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

Implements [InRange\(ISegmentable3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.inrange#digi-geometry-spatial-interfaces-ipolygonal3d-inrange(digi-geometry-spatial-interfaces-isegmentable3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.InRange\(DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the object is within range; otherwise, false if any required components are null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polygon3D\.Inside\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the geometry within the given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the check\.

Implements [Inside\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inside#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inside(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.Inside\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is inside; returns false if the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D'), geometry, or plane is null\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Polygon3D\.Inside\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside the geometry\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to check\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the distance calculation\.

Implements [Inside\(ISegmentable3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.inside#digi-geometry-spatial-interfaces-ipolygonal3d-inside(digi-geometry-spatial-interfaces-isegmentable3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.Inside\(DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside the geometry\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Inverse()'></a>

## Polygon3D\.Inverse\(\) Method

Inverts the geometry\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polygon3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is on the geometry within the given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the distance calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the geometry\.

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Triangulate(double)'></a>

## Polygon3D\.Triangulate\(double\) Method

Triangulates the geometry into a list of [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Triangle3D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygon3D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the triangulation process\.

Implements [Triangulate\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.triangulate#digi-geometry-spatial-interfaces-ipolygonal3d-triangulate(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.Triangulate\(System\.Double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the resulting 3D triangles, or `null` if the plane is null or the 2D triangulation fails\.

<a name='DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater'></a>

## Polygonal3DNormalizationUpdater Class

Updates the normalization of a 3D polygonal geometry to ensure it matches a specified orientation\.

```csharp
public class Polygonal3DNormalizationUpdater : DiGi.Geometry.Core.Classes.GeometryUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>, DiGi.Geometry.Core.Interfaces.INormalizationUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → Polygonal3DNormalizationUpdater

Implements [DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater.Polygonal3DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation)'></a>

## Polygonal3DNormalizationUpdater\(Orientation\) Constructor

Initializes a new instance of the [Polygonal3DNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.Polygonal3DNormalizationUpdater') class\.

```csharp
public Polygonal3DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater.Polygonal3DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to which the polygonal 3D object should be normalized\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater.Normalized()'></a>

## Polygonal3DNormalizationUpdater\.Normalized\(\) Method

Determines whether the current value is normalized based on the specified orientation\.

```csharp
public bool Normalized();
```

Implements [Normalized\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1.normalized 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1\.Normalized')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating true if the value is normalized; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Polygonal3DNormalizationUpdater.Update()'></a>

## Polygonal3DNormalizationUpdater\.Update\(\) Method

Updates the orientation of the current value\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D'></a>

## PolygonalFace3D Class

Represents a polygonal face in 3D space that is planar\.

```csharp
public class PolygonalFace3D : DiGi.Geometry.Spatial.Classes.Planar<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Spatial.Interfaces.IFace3D<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>, DiGi.Geometry.Spatial.Interfaces.IFace3D, DiGi.Geometry.Core.Interfaces.IFace, DiGi.Geometry.Core.Interfaces.ISurface, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.ISurface3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IPlanar, DiGi.Geometry.Core.Interfaces.IFace<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>, DiGi.Geometry.Spatial.Interfaces.IPlanar<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>, DiGi.Geometry.Spatial.Interfaces.IInvertible3D, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Spatial.Interfaces.IFlippable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') → PolygonalFace3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D'), [DiGi\.Geometry\.Core\.Interfaces\.IFace](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface 'DiGi\.Geometry\.Core\.Interfaces\.IFace'), [DiGi\.Geometry\.Core\.Interfaces\.ISurface](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isurface 'DiGi\.Geometry\.Core\.Interfaces\.ISurface'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isurface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISurface3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar'), [DiGi\.Geometry\.Core\.Interfaces\.IFace&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iflippable 'DiGi\.Geometry\.Spatial\.Interfaces\.IFlippable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## PolygonalFace3D\(Plane, IPolygonalFace2D\) Constructor

Initializes a new instance of the [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') class\.

```csharp
public PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') that defines the surface of the polygonal face\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') representation of the polygonal face in 2D space\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## PolygonalFace3D\(PolygonalFace3D\) Constructor

Initializes a new instance of the [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') class using the values from another [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance\.

```csharp
public PolygonalFace3D(DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D)'></a>

## PolygonalFace3D\(IPolygonal3D\) Constructor

Initializes a new instance of the [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') class using the specified external edge\.

```csharp
public PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? externalEdge);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D).externalEdge'></a>

`externalEdge` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') object representing the external edge used to initialize the face\. This value can be null\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(System.Text.Json.Nodes.JsonObject)'></a>

## PolygonalFace3D\(JsonObject\) Constructor

Initializes a new instance of the [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public PolygonalFace3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.PolygonalFace3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Edges'></a>

## PolygonalFace3D\.Edges Property

Gets a list of all polygonal 3D edges, combining the external edge and any internal edges\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>? Edges { get; }
```

Implements [Edges](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d.edges 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\.Edges')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing both the external and internal edges, or `null` if no external edge exists\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.ExternalEdge'></a>

## PolygonalFace3D\.ExternalEdge Property

Gets the external edge of the geometry as an IPolygonal3D object\.

```csharp
public DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? ExternalEdge { get; }
```

Implements [ExternalEdge](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1.externaledge 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1\.ExternalEdge')

#### Property Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')  
The IPolygonal3D representation of the external edge, or null if the plane or underlying 2D geometry is not available\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.InternalEdges'></a>

## PolygonalFace3D\.InternalEdges Property

Gets the list of internal edges as [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')\.
Returns null if the plane, geometry 2D, or the source internal edges are not available\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>? InternalEdges { get; }
```

Implements [InternalEdges](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1.internaledges 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1\.InternalEdges')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted internal edges, or null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Clone()'></a>

## PolygonalFace3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance, or `null`\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## PolygonalFace3D\.ClosestPoint\(Point3D\) Method

Calculates the closest point on the geometry to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

Implements [ClosestPoint\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d.closestpoint#digi-geometry-spatial-interfaces-iface3d-closestpoint(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\.ClosestPoint\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the geometry, or null if the input point, plane, or geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.GetArea()'></a>

## PolygonalFace3D\.GetArea\(\) Method

Calculates the area of the 2D geometry\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface.getarea 'DiGi\.Geometry\.Core\.Interfaces\.IFace\.GetArea')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the area, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the underlying 2D geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.GetBoundingBox()'></a>

## PolygonalFace3D\.GetBoundingBox\(\) Method

Gets the bounding box of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or null if it cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.GetInternalPoint(double)'></a>

## PolygonalFace3D\.GetInternalPoint\(double\) Method

Gets an internal point of the geometry within the specified tolerance\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the distance tolerance used for calculations\.

Implements [GetInternalPoint\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d.getinternalpoint#digi-geometry-spatial-interfaces-iface3d-getinternalpoint(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\.GetInternalPoint\(System\.Double\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A Point3D object if an internal point is found; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## PolygonalFace3D\.InRange\(Point3D, double\) Method

Determines whether the specified `Point3D?` is within the range of the geometry based on the provided [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The `Point3D?` to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the range check\.

Implements [InRange\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d.inrange#digi-geometry-spatial-interfaces-iface3d-inrange(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\.InRange\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within range; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the point, plane, or geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## PolygonalFace3D\.Inside\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located inside the geometry on the plane within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the proximity check\.

Implements [Inside\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d.inside#digi-geometry-spatial-interfaces-iface3d-inside(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\.Inside\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the point is within the geometry; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Inverse()'></a>

## PolygonalFace3D\.Inverse\(\) Method

Inverts the underlying 2D geometry\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.OnEdge(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## PolygonalFace3D\.OnEdge\(Point3D, double\) Method

Determines whether the specified 3D point lies on the edge of the geometry within a given tolerance\.

```csharp
public bool OnEdge(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.OnEdge(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.OnEdge(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the calculation\.

Implements [OnEdge\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iface3d.onedge#digi-geometry-spatial-interfaces-iface3d-onedge(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IFace3D\.OnEdge\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating true if the point is on the edge; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## PolygonalFace3D\.Orient\(Nullable\<Orientation\>, Nullable\<Orientation\>\) Method

Orients the external and internal edges of the geometry based on the specified orientations\.

```csharp
public bool Orient(System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to apply to the external edge\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to apply to the internal edge\.

Implements [Orient\(Nullable&lt;Orientation&gt;, Nullable&lt;Orientation&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d.orient#digi-geometry-spatial-interfaces-ipolygonalface3d-orient(system-nullable{digi-geometry-core-enums-orientation}-system-nullable{digi-geometry-core-enums-orientation}) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\.Orient\(System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Orientation\},System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Orientation\}\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the orientation process was successful\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Triangulate(double)'></a>

## PolygonalFace3D\.Triangulate\(double\) Method

Triangulates the geometry into a list of [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects based on the specified tolerance\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Triangle3D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used during the triangulation process\.

Implements [Triangulate\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d.triangulate#digi-geometry-spatial-interfaces-ipolygonalface3d-triangulate(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\.Triangulate\(System\.Double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Triangle3D>` containing the resulting 3D triangles, or null if the plane or underlying 2D geometry is not available\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver'></a>

## PolygonalFace3DInternalPointSolver Class

Provides a solver to find an internal point within a 3D polygonal face by utilizing a 2D planar projection\.

```csharp
public class PolygonalFace3DInternalPointSolver : DiGi.Geometry.Core.Interfaces.IInternalPointSolver<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.IGeometrySolver, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator, DiGi.Geometry.Core.Interfaces.IOneToManyGeometrySolver<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Core.Interfaces.IOneToManySolver<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Spatial.Classes.Point3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → PolygonalFace3DInternalPointSolver

Implements [DiGi\.Geometry\.Core\.Interfaces\.IInternalPointSolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinternalpointsolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IInternalPointSolver\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinternalpointsolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IInternalPointSolver\`2')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinternalpointsolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IInternalPointSolver\`2'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometrySolver](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometrysolver 'DiGi\.Geometry\.Core\.Interfaces\.IGeometrySolver'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetomanygeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetomanygeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver\`2')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ionetomanygeometrysolver-2 'DiGi\.Geometry\.Core\.Interfaces\.IOneToManyGeometrySolver\`2'), [DiGi\.Core\.Interfaces\.IOneToManySolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.PolygonalFace3DInternalPointSolver(double)'></a>

## PolygonalFace3DInternalPointSolver\(double\) Constructor

Initializes a new instance of the [PolygonalFace3DInternalPointSolver](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3DInternalPointSolver') class\.

```csharp
public PolygonalFace3DInternalPointSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.PolygonalFace3DInternalPointSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for internal point calculations\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.PolygonalFace3DInternalPointSolver(int,double)'></a>

## PolygonalFace3DInternalPointSolver\(int, double\) Constructor

Initializes a new instance of the [PolygonalFace3DInternalPointSolver](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3DInternalPointSolver') class\.

```csharp
public PolygonalFace3DInternalPointSolver(int maxCount, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.PolygonalFace3DInternalPointSolver(int,double).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of internal points to be calculated as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.PolygonalFace3DInternalPointSolver(int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for calculations as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.Input'></a>

## PolygonalFace3DInternalPointSolver\.Input Property

Gets or sets the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') input for the polygonal face internal point solver\.

```csharp
public DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? Input { set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.input 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Input')

#### Property Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.MaxCount'></a>

## PolygonalFace3DInternalPointSolver\.MaxCount Property

Gets or sets the maximum count for the polygonal face 2D internal point solver\.

```csharp
public int MaxCount { get; set; }
```

Implements [MaxCount](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinternalpointsolver-2.maxcount 'DiGi\.Geometry\.Core\.Interfaces\.IInternalPointSolver\`2\.MaxCount')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the maximum count\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.Ouput'></a>

## PolygonalFace3DInternalPointSolver\.Ouput Property

Gets the calculated internal point as a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Ouput { get; }
```

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The converted [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') result from the internal point solver, or null if no output is available\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.Outputs'></a>

## PolygonalFace3DInternalPointSolver\.Outputs Property

Gets the list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') outputs generated by the internal point solver, converted to the plane coordinates and filtered for null values\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? Outputs { get; }
```

Implements [Outputs](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.outputs 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Outputs')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DInternalPointSolver.Solve()'></a>

## PolygonalFace3DInternalPointSolver\.Solve\(\) Method

Solves for the internal point of the polygonal face 2D\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater'></a>

## PolygonalFace3DNormalizationUpdater Class

Provides functionality to update and normalize the orientation of a 3D polygonal face\.

```csharp
public class PolygonalFace3DNormalizationUpdater : DiGi.Geometry.Core.Classes.GeometryUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>, DiGi.Geometry.Core.Interfaces.INormalizationUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → PolygonalFace3DNormalizationUpdater

Implements [DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.PolygonalFace3DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation)'></a>

## PolygonalFace3DNormalizationUpdater\(Orientation\) Constructor

Initializes a new instance of the [PolygonalFace3DNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3DNormalizationUpdater') class using the specified [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for both internal and external edges\.

```csharp
public PolygonalFace3DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.PolygonalFace3DNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to be applied to both internal and external edge orientations\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.PolygonalFace3DNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## PolygonalFace3DNormalizationUpdater\(Nullable\<Orientation\>, Nullable\<Orientation\>\) Constructor

Initializes a new instance of the [PolygonalFace3DNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3DNormalizationUpdater') class with the specified orientation requirements for external and internal edges\.

```csharp
public PolygonalFace3DNormalizationUpdater(System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.PolygonalFace3DNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The required [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for external edges, or null if no specific orientation is required\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.PolygonalFace3DNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The required [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for internal edges, or null if no specific orientation is required\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.Normalized()'></a>

## PolygonalFace3DNormalizationUpdater\.Normalized\(\) Method

Determines whether the value is normalized based on the external and internal edge orientations\.

```csharp
public bool Normalized();
```

Implements [Normalized\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1.normalized 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1\.Normalized')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the value is normalized\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFace3DNormalizationUpdater.Update()'></a>

## PolygonalFace3DNormalizationUpdater\.Update\(\) Method

Updates the orientation of the value using the external and internal edge orientations\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the update was successfully performed\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion'></a>

## PolygonalFaceExtrusion Class

Represents the extrusion of a polygonal face in three\-dimensional space\.

```csharp
public class PolygonalFaceExtrusion : DiGi.Geometry.Spatial.Classes.Extrusion<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Extrusion&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Extrusion_TSurface3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Extrusion\<TSurface3D\>') → PolygonalFaceExtrusion
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion)'></a>

## PolygonalFaceExtrusion\(PolygonalFaceExtrusion\) Constructor

Initializes a new instance of the [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') class using an existing [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') object\.

```csharp
public PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion? polygonalFaceExtrusion);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion).polygonalFaceExtrusion'></a>

`polygonalFaceExtrusion` [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion')

The [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## PolygonalFaceExtrusion\(IPolygonalFace3D, Vector3D\) Constructor

Initializes a new instance of the [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') class\.

```csharp
public PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? surface, DiGi.Geometry.Spatial.Classes.Vector3D? vector);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D).surface'></a>

`surface` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') surface to be extruded\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector'></a>

`vector` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector defining the extrusion direction and distance\.

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(System.Text.Json.Nodes.JsonObject)'></a>

## PolygonalFaceExtrusion\(JsonObject\) Constructor

Initializes a new instance of the [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public PolygonalFaceExtrusion(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion.PolygonalFaceExtrusion(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the extrusion\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron'></a>

## Polyhedron Class

Represents a polyhedron composed of polygonal faces\.

```csharp
public class Polyhedron : DiGi.Geometry.Spatial.Classes.Polyhedron<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') → Polyhedron
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron.Polyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron)'></a>

## Polyhedron\(Polyhedron\) Constructor

Initializes a new instance of the [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') class by copying an existing [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') object\.

```csharp
public Polyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron.Polyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron).polyhedron'></a>

`polyhedron` [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron.Polyhedron(System.Text.Json.Nodes.JsonObject)'></a>

## Polyhedron\(JsonObject\) Constructor

Initializes a new instance of the [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Polyhedron(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron.Polyhedron(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the polyhedron\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron.Clone()'></a>

## Polyhedron\.Clone\(\) Method

Creates a clone of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current instance, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_'></a>

## Polyhedron\<TPolygonalFace3D\> Class

Represents an abstract base class for a 3D polyhedron consisting of polygonal faces\.

```csharp
public abstract class Polyhedron<TPolygonalFace3D> : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IPolyhedron, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D, DiGi.Geometry.Core.Interfaces.IInvertible
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of the polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Polyhedron\<TPolygonalFace3D\>

Derived  
↳ [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Polyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_)'></a>

## Polyhedron\(Polyhedron\<TPolygonalFace3D\>\) Constructor

Initializes a new instance of the [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') class using an existing [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') instance\.

```csharp
public Polyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Polyhedron(DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Polyhedron(System.Text.Json.Nodes.JsonObject)'></a>

## Polyhedron\(JsonObject\) Constructor

Initializes a new instance of the [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Polyhedron(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Polyhedron(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the polyhedron\. This value can be null\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Count'></a>

## Polyhedron\<TPolygonalFace3D\>\.Count Property

Gets the total number of polygonal faces\.

```csharp
public int Count { get; }
```

Implements [Count](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.count 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.Count')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the count of polygonal faces\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.PolygonalFaces'></a>

## Polyhedron\<TPolygonalFace3D\>\.PolygonalFaces Property

Gets the list of [TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.TPolygonalFace3D') objects representing the polygonal faces\.

```csharp
public System.Collections.Generic.List<TPolygonalFace3D>? PolygonalFaces { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the cloned polygonal faces, or null if no faces are defined\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.this[int]'></a>

## Polyhedron\<TPolygonalFace3D\>\.this\[int\] Property

Gets the polygonal face at the specified index\.

```csharp
public TPolygonalFace3D? this[int i] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.this[int].i'></a>

`i` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the polygonal face to retrieve\.

#### Property Value
[TPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.TPolygonalFace3D')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetBoundingBox()'></a>

## Polyhedron\<TPolygonalFace3D\>\.GetBoundingBox\(\) Method

Calculates the bounding box that encompasses all polygonal faces of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the total bounding area, or `null` if there are no polygonal faces\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetInternalPoint(double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.GetInternalPoint\(double\) Method

Calculates and returns a point located inside the polyhedron\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if a point is internal\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing an internal point if one is found; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,bool,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.GetNormal\(int, bool, Nullable\<Side\>, double\) Method

Gets the normal vector of a polygonal face at the specified index\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? GetNormal(int index, out bool inversed, System.Nullable<DiGi.Geometry.Core.Enums.Side> side=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,bool,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the polygonal face\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,bool,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).inversed'></a>

`inversed` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When called, contains a [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the resulting normal is inversed\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,bool,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).side'></a>

`side` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') specifying the side to consider for the normal calculation\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,bool,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance used during calculations\.

Implements [GetNormal\(int, bool, Nullable&lt;Side&gt;, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.getnormal#digi-geometry-spatial-interfaces-ipolyhedron-getnormal(system-int32-system-boolean@-system-nullable{digi-geometry-core-enums-side}-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.GetNormal\(System\.Int32,System\.Boolean@,System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Side\},System\.Double\)')

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A `Vector3D?` containing the normal vector if successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.GetNormal\(int, Nullable\<Side\>, double\) Method

Gets the normal vector of the polygonal face at the specified index\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? GetNormal(int index, System.Nullable<DiGi.Geometry.Core.Enums.Side> side=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the polygonal face\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).side'></a>

`side` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') specifying which side of the face to use for the normal calculation\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for calculations\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normal vector if successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetPolygonalFace3D_UPolygonalFace3D_(int)'></a>

## Polyhedron\<TPolygonalFace3D\>\.GetPolygonalFace3D\<UPolygonalFace3D\>\(int\) Method

Retrieves the polygonal face at the specified index, cast to the requested type\.

```csharp
public UPolygonalFace3D? GetPolygonalFace3D<UPolygonalFace3D>(int index)
    where UPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetPolygonalFace3D_UPolygonalFace3D_(int).UPolygonalFace3D'></a>

`UPolygonalFace3D`

The specific type of [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to retrieve\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetPolygonalFace3D_UPolygonalFace3D_(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based integer index of the polygonal face in the collection\.

Implements [GetPolygonalFace3D&lt;TPolygonalFace3D&gt;\(int\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.getpolygonalface3d--1#digi-geometry-spatial-interfaces-ipolyhedron-getpolygonalface3d--1(system-int32) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.GetPolygonalFace3D\`\`1\(System\.Int32\)')

#### Returns
[UPolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetPolygonalFace3D_UPolygonalFace3D_(int).UPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.GetPolygonalFace3D\<UPolygonalFace3D\>\(int\)\.UPolygonalFace3D')  
An instance of \<typeparam ref="UPolygonalFace3D" /\> if the element at the specified index exists and is of the requested type; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.InRange\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within the given tolerance range\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the point is within range; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.Inside\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located inside the object, excluding points that are on the boundary\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check for containment\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for the calculation\.

Implements [Inside\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.inside#digi-geometry-spatial-interfaces-ipolyhedron-inside(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.Inside\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the point is inside; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Inverse()'></a>

## Polyhedron\<TPolygonalFace3D\>\.Inverse\(\) Method

Inverts the orientation of all polygonal faces associated with this object\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether at least one polygonal face was successfully inversed; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Polyhedron\<TPolygonalFace3D\>\.Move\(Vector3D\) Method

Moves the object by the specified Vector3D vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? vector to translate the polygonal faces by\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Normalized(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.Normalized\(int, Nullable\<Orientation\>, Nullable\<Orientation\>, double\) Method

Determines whether the polygonal face at the specified index is normalized based on the provided external and internal edge orientations and a distance tolerance\.

```csharp
public bool Normalized(int index, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Normalized(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index of the polygonal face to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Normalized(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for external edges\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Normalized(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for internal edges\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Normalized(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine normalization\.

Implements [Normalized\(int, Nullable&lt;Orientation&gt;, Nullable&lt;Orientation&gt;, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.normalized#digi-geometry-spatial-interfaces-ipolyhedron-normalized(system-int32-system-nullable{digi-geometry-core-enums-orientation}-system-nullable{digi-geometry-core-enums-orientation}-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.Normalized\(System\.Int32,System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Orientation\},System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Orientation\},System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the face is normalized; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the polygonal faces collection is null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on any of the polygonal faces within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for the range check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is on any of the polygonal faces; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.OnEdge(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.OnEdge\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on the edge of the polygonal faces within the given tolerance\.

```csharp
public bool OnEdge(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.OnEdge(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.OnEdge(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the proximity check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the point is on the edge; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## Polyhedron\<TPolygonalFace3D\>\.Orient\(int, Nullable\<Orientation\>, Nullable\<Orientation\>\) Method

Orients the polygonal face at the specified index using the provided external and internal edge orientations\.

```csharp
public bool Orient(int index, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index of the polygonal face to orient\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') specifying the orientation for external edges\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(int,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') specifying the orientation for internal edges\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the orientation was successful; returns false if the polygonal faces collection is null or both orientation parameters are null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## Polyhedron\<TPolygonalFace3D\>\.Orient\(Nullable\<Orientation\>, Nullable\<Orientation\>\) Method

Orients the polygonal faces using the specified external and internal edge orientations\.

```csharp
public bool Orient(System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to apply to external edges, or null if no change is desired\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to apply to internal edges, or null if no change is desired\.

Implements [Orient\(Nullable&lt;Orientation&gt;, Nullable&lt;Orientation&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.orient#digi-geometry-spatial-interfaces-ipolyhedron-orient(system-nullable{digi-geometry-core-enums-orientation}-system-nullable{digi-geometry-core-enums-orientation}) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.Orient\(System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Orientation\},System\.Nullable\{DiGi\.Geometry\.Core\.Enums\.Orientation\}\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether at least one polygonal face was successfully oriented; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.SetNormal\(int, Side, Vector3D, double\) Method

Sets the normal for a specific polygonal face based on the provided side and tolerance\.

```csharp
public bool SetNormal(int index, DiGi.Geometry.Core.Enums.Side side, out DiGi.Geometry.Spatial.Classes.Vector3D? normal, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,DiGi.Geometry.Spatial.Classes.Vector3D,double).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index of the polygonal face\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,DiGi.Geometry.Spatial.Classes.Vector3D,double).side'></a>

`side` [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')

The [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') to be used for calculating the normal\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,DiGi.Geometry.Spatial.Classes.Vector3D,double).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

When this method returns, contains the calculated `Vector3D?` normal if successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for distance calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the normal was successfully set and flipped\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,double)'></a>

## Polyhedron\<TPolygonalFace3D\>\.SetNormal\(int, Side, double\) Method

Sets the normal for the element at the specified index based on the provided side and tolerance\.

```csharp
public bool SetNormal(int index, DiGi.Geometry.Core.Enums.Side side, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,double).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') index of the target element\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,double).side'></a>

`side` [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')

The [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') specifying which side to process\.

<a name='DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.SetNormal(int,DiGi.Geometry.Core.Enums.Side,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculations\.

Implements [SetNormal\(int, Side, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron.setnormal#digi-geometry-spatial-interfaces-ipolyhedron-setnormal(system-int32-digi-geometry-core-enums-side-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron\.SetNormal\(System\.Int32,DiGi\.Geometry\.Core\.Enums\.Side,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the normal was successfully set\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_'></a>

## PolyhedronInternalPointSolver\<TPolyhedron\> Class

Solves for an internal point within a polyhedron of type [TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>\.TPolyhedron')\.

```csharp
public class PolyhedronInternalPointSolver<TPolyhedron> : DiGi.Geometry.Core.Classes.InternalPointSolver<TPolyhedron, DiGi.Geometry.Spatial.Classes.Point3D>
    where TPolyhedron : DiGi.Geometry.Spatial.Interfaces.IPolyhedron
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.TPolyhedron'></a>

`TPolyhedron`

The type of the polyhedron, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.InternalPointSolver&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>')[TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>\.TPolyhedron')[,](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.InternalPointSolver_TGeometry,TPoint_ 'DiGi\.Geometry\.Core\.Classes\.InternalPointSolver\<TGeometry,TPoint\>') → PolyhedronInternalPointSolver\<TPolyhedron\>
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.PolyhedronInternalPointSolver(double)'></a>

## PolyhedronInternalPointSolver\(double\) Constructor

Initializes a new instance of the [PolyhedronInternalPointSolver&lt;TPolyhedron&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_ 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>') class\.

```csharp
public PolyhedronInternalPointSolver(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.PolyhedronInternalPointSolver(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for calculations\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.PolyhedronInternalPointSolver(int,double)'></a>

## PolyhedronInternalPointSolver\(int, double\) Constructor

Initializes a new instance of the [PolyhedronInternalPointSolver&lt;TPolyhedron&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_ 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>') class\.

```csharp
public PolyhedronInternalPointSolver(int maxCount, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.PolyhedronInternalPointSolver(int,double).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of iterations to perform as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.PolyhedronInternalPointSolver(int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for calculations as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.Input'></a>

## PolyhedronInternalPointSolver\<TPolyhedron\>\.Input Property

Gets or sets the input [TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>\.TPolyhedron')\.

```csharp
public override TPolyhedron? Input { set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetomanysolver-2.input 'DiGi\.Core\.Interfaces\.IOneToManySolver\`2\.Input')

#### Property Value
[TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronInternalPointSolver\<TPolyhedron\>\.TPolyhedron')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronInternalPointSolver_TPolyhedron_.Solve()'></a>

## PolyhedronInternalPointSolver\<TPolyhedron\>\.Solve\(\) Method

Attempts to solve for an internal point within the polyhedron\.

```csharp
public override bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether a solution was successfully found\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater'></a>

## PolyhedronNormalizationUpdater Class

Provides functionality to update the normalization of a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

```csharp
public class PolyhedronNormalizationUpdater : DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater<DiGi.Geometry.Spatial.Classes.Polyhedron>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → [DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_ 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>')[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_ 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>') → PolyhedronNormalizationUpdater
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation)'></a>

## PolyhedronNormalizationUpdater\(Orientation\) Constructor

Initializes a new instance of the [PolyhedronNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater') class with the specified [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')\.

```csharp
public PolyhedronNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to be used for normalization\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double)'></a>

## PolyhedronNormalizationUpdater\(Nullable\<Side\>, Nullable\<Orientation\>, Nullable\<Orientation\>, double\) Constructor

Initializes a new instance of the [PolyhedronNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater') class with the specified normal side, external edge orientation, internal edge orientation, and tolerance\.

```csharp
public PolyhedronNormalizationUpdater(System.Nullable<DiGi.Geometry.Core.Enums.Side> normalSide, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).normalSide'></a>

`normalSide` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') to be normalized\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for external edges\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for internal edges\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_'></a>

## PolyhedronNormalizationUpdater\<TPolyhedron\> Class

Provides functionality to update the normalization of a polyhedron, ensuring consistent normals and edge orientations\.

```csharp
public class PolyhedronNormalizationUpdater<TPolyhedron> : DiGi.Geometry.Core.Classes.GeometryUpdater<TPolyhedron>, DiGi.Geometry.Core.Interfaces.INormalizationUpdater<TPolyhedron>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater<TPolyhedron>, DiGi.Geometry.Core.Interfaces.IGeometryUpdater, DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator, DiGi.Core.Interfaces.IUpdater<TPolyhedron>
    where TPolyhedron : DiGi.Geometry.Spatial.Interfaces.IPolyhedron
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.TPolyhedron'></a>

`TPolyhedron`

The type of the polyhedron, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Geometry\.Core\.Classes\.GeometryUpdater&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>')[TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>\.TPolyhedron')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.GeometryUpdater_TGeometry_ 'DiGi\.Geometry\.Core\.Classes\.GeometryUpdater\<TGeometry\>') → PolyhedronNormalizationUpdater\<TPolyhedron\>

Derived  
↳ [PolyhedronNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater')

Implements [DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1')[TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>\.TPolyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1')[TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>\.TPolyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater-1 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometryupdater 'DiGi\.Geometry\.Core\.Interfaces\.IGeometryUpdater'), [DiGi\.Core\.Interfaces\.IUpdater](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater 'DiGi\.Core\.Interfaces\.IUpdater'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator'), [DiGi\.Core\.Interfaces\.IUpdater&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')[TPolyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.TPolyhedron 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater\<TPolyhedron\>\.TPolyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater-1 'DiGi\.Core\.Interfaces\.IUpdater\`1')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation)'></a>

## PolyhedronNormalizationUpdater\(Orientation\) Constructor

Initializes a new instance of the [PolyhedronNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater') class using the specified orientation for both external and internal edges\.

```csharp
public PolyhedronNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to be applied to both external and internal edge orientations\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double)'></a>

## PolyhedronNormalizationUpdater\(Nullable\<Side\>, Nullable\<Orientation\>, Nullable\<Orientation\>, double\) Constructor

Initializes a new instance of the [PolyhedronNormalizationUpdater](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater 'DiGi\.Geometry\.Spatial\.Classes\.PolyhedronNormalizationUpdater') class\.

```csharp
public PolyhedronNormalizationUpdater(System.Nullable<DiGi.Geometry.Core.Enums.Side> normalSide, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).normalSide'></a>

`normalSide` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') specifying the normal side\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for external edges\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') for internal edges\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.PolyhedronNormalizationUpdater(System.Nullable_DiGi.Geometry.Core.Enums.Side_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.Normalized()'></a>

## PolyhedronNormalizationUpdater\<TPolyhedron\>\.Normalized\(\) Method

Determines whether the current value is normalized based on the specified edge orientations and tolerance\.

```csharp
public bool Normalized();
```

Implements [Normalized\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.inormalizationupdater-1.normalized 'DiGi\.Geometry\.Core\.Interfaces\.INormalizationUpdater\`1\.Normalized')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the instance is normalized\.

<a name='DiGi.Geometry.Spatial.Classes.PolyhedronNormalizationUpdater_TPolyhedron_.Update()'></a>

## PolyhedronNormalizationUpdater\<TPolyhedron\>\.Update\(\) Method

Updates the normal values based on the provided normal side and tolerance\.

```csharp
public override bool Update();
```

Implements [Update\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iupdater.update 'DiGi\.Core\.Interfaces\.IUpdater\.Update')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether any of the values were successfully updated\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D'></a>

## Polyline3D Class

Represents a three\-dimensional polyline consisting of a sequence of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public class Polyline3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Polyline3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D()'></a>

## Polyline3D\(\) Constructor

Initializes a new instance of the [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') class\.

```csharp
public Polyline3D();
```

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(DiGi.Geometry.Spatial.Classes.Polyline3D)'></a>

## Polyline3D\(Polyline3D\) Constructor

Initializes a new instance of the [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') class by copying another [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') instance\.

```csharp
public Polyline3D(DiGi.Geometry.Spatial.Classes.Polyline3D? polyline3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(DiGi.Geometry.Spatial.Classes.Polyline3D).polyline3D'></a>

`polyline3D` [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')

The source [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Polyline3D\(IEnumerable\<Point3D\>\) Constructor

Initializes a new instance of the [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') class using the specified collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public Polyline3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects that define the polyline\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,bool)'></a>

## Polyline3D\(IEnumerable\<Point3D\>, bool\) Constructor

Initializes a new instance of the [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') class\.

```csharp
public Polyline3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, bool close);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,bool).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points that define the polyline\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,bool).close'></a>

`close` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polyline should be closed\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Text.Json.Nodes.JsonObject)'></a>

## Polyline3D\(JsonObject\) Constructor

Initializes a new instance of the [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Polyline3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Polyline3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Length'></a>

## Polyline3D\.Length Property

Gets the total length of all 3D segments\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The combined length as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the segment list is null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Clone()'></a>

## Polyline3D\.Clone\(\) Method

Creates a copy of the current [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance, or `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Close()'></a>

## Polyline3D\.Close\(\) Method

Closes the path by adding a copy of the first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the end of the points collection,
provided that the path is not already closed and contains at least three points\.

```csharp
public void Close();
```

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Polyline3D\.ClosestPoint\(Point3D\) Method

Finds the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') closest to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used as the reference point for the search\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') nearest to the provided point, or `null` if no closest point is found\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.GetBoundingBox()'></a>

## Polyline3D\.GetBoundingBox\(\) Method

Calculates the bounding box for the collection of points\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if there are no points available\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.GetPoints()'></a>

## Polyline3D\.GetPoints\(\) Method

Retrieves a list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Point3D>` containing the points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no points are available\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.GetSegments()'></a>

## Polyline3D\.GetSegments\(\) Method

Retrieves the list of 3D segments generated from the current points\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the segments, or null if the operation fails\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Inverse()'></a>

## Polyline3D\.Inverse\(\) Method

Reverses the order of the points in the collection\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful; returns `true` if there were at least two points to reverse, otherwise `false`\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.IsClosed()'></a>

## Polyline3D\.IsClosed\(\) Method

Determines whether the path is closed by checking if the first and last points are identical\.

```csharp
public bool IsClosed();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating true if the path has at least three points and the start point equals the end point; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Polyline3D\.Move\(Vector3D\) Method

Moves the object by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') used to move the points\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the movement was successful; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Polyline3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is on the entity within the given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the entity\.

<a name='DiGi.Geometry.Spatial.Classes.Polyline3D.Open()'></a>

## Polyline3D\.Open\(\) Method

Opens the path by removing the closing point if the path is currently closed and contains at least three points\.

```csharp
public void Open();
```

<a name='DiGi.Geometry.Spatial.Classes.Polyloop'></a>

## Polyloop Class

Represents a closed polyline in 3D space\.

```csharp
public class Polyloop : DiGi.Geometry.Spatial.Classes.Segmentable3D, DiGi.Geometry.Spatial.Interfaces.IClosedCurve3D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') → Polyloop

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop()'></a>

## Polyloop\(\) Constructor

Initializes a new instance of the [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop') class\.

```csharp
public Polyloop();
```

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop(DiGi.Geometry.Spatial.Classes.Polyloop)'></a>

## Polyloop\(Polyloop\) Constructor

Initializes a new instance of the [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop') class by copying the points from an existing [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop') instance\.

```csharp
public Polyloop(DiGi.Geometry.Spatial.Classes.Polyloop? polyloop);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop(DiGi.Geometry.Spatial.Classes.Polyloop).polyloop'></a>

`polyloop` [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop')

The source [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop') instance to copy from\. This parameter can be null\.

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Polyloop\(IEnumerable\<Point3D\>\) Constructor

Initializes a new instance of the [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop') class using a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public Polyloop(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects that define the points of the loop\.

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop(System.Text.Json.Nodes.JsonObject)'></a>

## Polyloop\(JsonObject\) Constructor

Initializes a new instance of the [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Polyloop(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.Polyloop(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.GetPerimeter()'></a>

## Polyloop\.GetPerimeter\(\) Method

Gets the perimeter of the object\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the total length of the perimeter\.

<a name='DiGi.Geometry.Spatial.Classes.Polyloop.GetSegments()'></a>

## Polyloop\.GetSegments\(\) Method

Gets the collection of 3D segments\.

```csharp
public override System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated 3D segments, or null if no segments are available\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult'></a>

## ProjectionResult Class

Represents the result of a projection operation, inheriting from [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult')\.

```csharp
public class ProjectionResult : DiGi.Geometry.Spatial.Classes.PlanarResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [PlanarResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarResult') → ProjectionResult
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult()'></a>

## ProjectionResult\(\) Constructor

Initializes a new instance of the [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') class\.

```csharp
public ProjectionResult();
```

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## ProjectionResult\(Plane\) Constructor

Initializes a new instance of the [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the projection\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## ProjectionResult\(Plane, IGeometry2D\) Constructor

Initializes a new instance of the [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') class\.

```csharp
public ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the projection\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') resulting from the projection\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_)'></a>

## ProjectionResult\(Plane, IEnumerable\<IGeometry2D\>\) Constructor

Initializes a new instance of the [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') class with the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a collection of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects\.

```csharp
public ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the projection\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects to be projected\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.ProjectionResult)'></a>

## ProjectionResult\(ProjectionResult\) Constructor

Initializes a new instance of the [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') class using an existing [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') instance\.

```csharp
public ProjectionResult(DiGi.Geometry.Spatial.Classes.ProjectionResult? projectionResult);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(DiGi.Geometry.Spatial.Classes.ProjectionResult).projectionResult'></a>

`projectionResult` [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')

The [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(System.Text.Json.Nodes.JsonObject)'></a>

## ProjectionResult\(JsonObject\) Constructor

Initializes a new instance of the [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public ProjectionResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.ProjectionResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.ProjectionResult.Clone()'></a>

## ProjectionResult\.Clone\(\) Method

Creates a clone of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a copy of the current object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D'></a>

## Ray3D Class

Represents a ray in three\-dimensional space, defined by an origin point and a direction vector\.

```csharp
public class Ray3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.ILinear3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.ITransformable3D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Spatial.Interfaces.IGeometry3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Ray3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransformable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Ray3D\(Point3D, Point3D\) Constructor

Initializes a new instance of the [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') class using two [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points to define the origin and direction\.

```csharp
public Ray3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the ray\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used to calculate the unit direction vector from the origin\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Ray3D\(Point3D, Vector3D\) Constructor

Initializes a new instance of the [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') class with the specified origin and direction\.

```csharp
public Ray3D(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? direction);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the starting point of the ray\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).direction'></a>

`direction` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the direction of the ray\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## Ray3D\(Ray3D\) Constructor

Initializes a new instance of the [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') class by cloning an existing [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') object\.

```csharp
public Ray3D(DiGi.Geometry.Spatial.Classes.Ray3D? ray3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(DiGi.Geometry.Spatial.Classes.Ray3D).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The source [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') object to clone\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(System.Text.Json.Nodes.JsonObject)'></a>

## Ray3D\(JsonObject\) Constructor

Initializes a new instance of the [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') class from the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Ray3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Ray3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Direction'></a>

## Ray3D\.Direction Property

Gets or sets the direction as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Direction { get; set; }
```

Implements [Direction](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.direction 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Direction')

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the direction, or null if not specified\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Origin'></a>

## Ray3D\.Origin Property

Gets or sets the origin point of the ray as a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Origin { get; set; }
```

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the origin, or null if not specified\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Clone()'></a>

## Ray3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current instance, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Ray3D\.ClosestPoint\(Point3D\) Method

Calculates the closest point on the linear entity to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

Implements [ClosestPoint\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.closestpoint#digi-geometry-spatial-interfaces-ilinear3d-closestpoint(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.ClosestPoint\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') if found; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double)'></a>

## Ray3D\.Collinear\(ILinear3D, double\) Method

Determines whether this linear object is collinear with the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object within a given tolerance\.

```csharp
public bool Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D? linear3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).linear3D'></a>

`linear3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object to check for collinearity\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if the directions are collinear\.

Implements [Collinear\(ILinear3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.collinear#digi-geometry-spatial-interfaces-ilinear3d-collinear(digi-geometry-spatial-interfaces-ilinear3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Collinear\(DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the objects are collinear; otherwise, false if either direction is null\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Ray3D\.Distance\(Point3D\) Method

Calculates the distance between the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and this object\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The `Point3D?` point to calculate the distance from\.

Implements [Distance\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.distance#digi-geometry-spatial-interfaces-ilinear3d-distance(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Distance\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided `Point3D?` is null or cannot be projected\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Equals(object)'></a>

## Ray3D\.Equals\(object\) Method

Indicates whether the specified object is equal to the current [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')\.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the specified object is equal to the current instance\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.GetHashCode()'></a>

## Ray3D\.GetHashCode\(\) Method

Returns a hash code for the current object based on its origin and direction\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the hash code of the object\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Ray3D,double)'></a>

## Ray3D\.IntersectionPoint\(Ray3D, double\) Method

Calculates the intersection point between this ray and another [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? IntersectionPoint(DiGi.Geometry.Spatial.Classes.Ray3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Ray3D,double).line3D'></a>

`line3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to intersect with this ray\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Ray3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the intersection calculation\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the intersection point if one exists; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Ray3D\.IntersectionPoint\(Segment3D, double\) Method

Calculates the intersection point between this object and a specified 3D segment\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to intersect with\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the intersection point if it exists and lies on the segment; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Inverse()'></a>

## Ray3D\.Inverse\(\) Method

Inverts the current direction\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Ray3D\.Move\(Vector3D\) Method

Moves the object by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') translation vector\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Ray3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') lies on the object within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the point is on the object\.

Implements [On\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.on#digi-geometry-spatial-interfaces-ilinear3d-on(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.On\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within the specified tolerance of the object\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Project(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Ray3D\.Project\(Point3D\) Method

Projects a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') onto the ray, clamping points behind the origin to the origin\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Project(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Project(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to project\.

Implements [Project\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.project#digi-geometry-spatial-interfaces-ilinear3d-project(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Project\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The projected [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the ray, or null if the input point is null or the ray is not properly defined\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D)'></a>

## Ray3D\.Transform\(ITransform3D\) Method

Transforms the origin and direction of the object using the specified 3D transformation\.

```csharp
public bool Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D).transform'></a>

`transform` [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') instance to apply for the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied; returns false if the [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') transform, origin, or direction is null\.
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.op_Equality(DiGi.Geometry.Spatial.Classes.Ray3D,DiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## Ray3D\.operator ==\(Ray3D, Ray3D\) Operator

Indicates whether the two specified [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') objects are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Spatial.Classes.Ray3D? ray3D_1, DiGi.Geometry.Spatial.Classes.Ray3D? ray3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.op_Equality(DiGi.Geometry.Spatial.Classes.Ray3D,DiGi.Geometry.Spatial.Classes.Ray3D).ray3D_1'></a>

`ray3D_1` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The first [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to compare\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.op_Equality(DiGi.Geometry.Spatial.Classes.Ray3D,DiGi.Geometry.Spatial.Classes.Ray3D).ray3D_2'></a>

`ray3D_2` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The second [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Ray3D,DiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## Ray3D\.operator \!=\(Ray3D, Ray3D\) Operator

Indicates whether the two specified [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') objects are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Spatial.Classes.Ray3D? ray3D_1, DiGi.Geometry.Spatial.Classes.Ray3D? ray3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Ray3D,DiGi.Geometry.Spatial.Classes.Ray3D).ray3D_1'></a>

`ray3D_1` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The first [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to compare\.

<a name='DiGi.Geometry.Spatial.Classes.Ray3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Ray3D,DiGi.Geometry.Spatial.Classes.Ray3D).ray3D_2'></a>

`ray3D_2` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The second [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D'></a>

## Rectangle3D Class

Represents a three\-dimensional rectangle defined on a specific plane\.

```csharp
public class Rectangle3D : DiGi.Geometry.Spatial.Classes.Planar<DiGi.Geometry.Planar.Classes.Rectangle2D>, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D<DiGi.Geometry.Planar.Classes.Rectangle2D>, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D, DiGi.Geometry.Spatial.Interfaces.IClosedPlanarCurve3D, DiGi.Geometry.Spatial.Interfaces.IClosedCurve3D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D, DiGi.Geometry.Spatial.Interfaces.IPlanar, DiGi.Geometry.Spatial.Interfaces.IPlanar<DiGi.Geometry.Planar.Classes.Rectangle2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') → Rectangle3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\`1')[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Rectangle3D\(Plane, Rectangle2D\) Constructor

Initializes a new instance of the [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')\.

```csharp
public Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Rectangle2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the rectangle is defined\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') that defines the dimensions and position of the rectangle within the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,double,double)'></a>

## Rectangle3D\(Plane, double, double\) Constructor

Initializes a new instance of the [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') class with the specified plane, width, and height\.

```csharp
public Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane? plane, double width, double height);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,double,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the rectangle is defined\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the rectangle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the rectangle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Rectangle3D\(Plane, IEnumerable\<Point2D\>\) Constructor

Initializes a new instance of the [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') class using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the rectangle is located\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points that define the 2D geometry of the rectangle\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Rectangle3D)'></a>

## Rectangle3D\(Rectangle3D\) Constructor

Initializes a new instance of the [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') class using an existing [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') instance\.

```csharp
public Rectangle3D(DiGi.Geometry.Spatial.Classes.Rectangle3D? rectangle3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(DiGi.Geometry.Spatial.Classes.Rectangle3D).rectangle3D'></a>

`rectangle3D` [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')

The [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(System.Text.Json.Nodes.JsonObject)'></a>

## Rectangle3D\(JsonObject\) Constructor

Initializes a new instance of the [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Rectangle3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Rectangle3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the rectangle\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Height'></a>

## Rectangle3D\.Height Property

Gets the height of the object\.

```csharp
public double Height { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the height, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the underlying 2D geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Length'></a>

## Rectangle3D\.Length Property

Gets the length of the 2D geometry\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the geometry is null\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the length\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Width'></a>

## Rectangle3D\.Width Property

Gets the width of the rectangle\.

```csharp
public double Width { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the width, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the geometry is not defined\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Clone()'></a>

## Rectangle3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a clone of the current object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Rectangle3D\.ClosestPoint\(Point3D\) Method

Calculates the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the geometry to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is sought\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found, or null if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null or the geometry is not available\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Rectangle3D\.Distance\(Point3D\) Method

Calculates the distance from the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the geometry\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point used to calculate the distance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null, the geometry is null, or no closest point can be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetArea()'></a>

## Rectangle3D\.GetArea\(\) Method

Calculates the area of the 2D geometry\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getarea 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetArea')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the calculated area, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the 2D geometry is null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetBoundingBox()'></a>

## Rectangle3D\.GetBoundingBox\(\) Method

Calculates and returns the bounding box for the current object in 3D space\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no points are available\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetCentroid()'></a>

## Rectangle3D\.GetCentroid\(\) Method

Calculates the centroid of the geometry and converts it to a 3D point\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetCentroid();
```

Implements [GetCentroid\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.getcentroid 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.GetCentroid')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the centroid if both the plane and geometry are available; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetInternalPoint(double)'></a>

## Rectangle3D\.GetInternalPoint\(double\) Method

Gets an internal point of the geometry\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculations\.

Implements [GetInternalPoint\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getinternalpoint#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-getinternalpoint(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetInternalPoint\(System\.Double\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the internal point if successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetPerimeter()'></a>

## Rectangle3D\.GetPerimeter\(\) Method

Gets the perimeter of the geometry\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The perimeter as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetPoints()'></a>

## Rectangle3D\.GetPoints\(\) Method

Retrieves a list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects by converting the 2D points from the geometry using the associated plane\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane, geometry, or source points are unavailable\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.GetSegments()'></a>

## Rectangle3D\.GetSegments\(\) Method

Retrieves the list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') if segments are available; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Rectangle3D\.InRange\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within range based on the provided tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

Implements [InRange\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inrange#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inrange(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.InRange\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within range; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Rectangle3D\.InRange\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is within a given distance tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

Implements [InRange\(ISegmentable3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.inrange#digi-geometry-spatial-interfaces-ipolygonal3d-inrange(digi-geometry-spatial-interfaces-isegmentable3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.InRange\(DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the object is within range; returns `false` if the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object, geometry2D, or plane is null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Rectangle3D\.Inside\(Point3D, double\) Method

Determines whether the specified Point3D is inside the geometry within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The Point3D object to check\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the distance tolerance for the operation\.

Implements [Inside\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inside#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inside(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.Inside\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the point is inside the geometry; returns false if the point, geometry, or plane is null\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Rectangle3D\.Inside\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside the geometry within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to check\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the operation\.

Implements [Inside\(ISegmentable3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.inside#digi-geometry-spatial-interfaces-ipolygonal3d-inside(digi-geometry-spatial-interfaces-isegmentable3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.Inside\(DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside the geometry\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Inverse()'></a>

## Rectangle3D\.Inverse\(\) Method

Inverts the current geometry\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Rectangle3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on the geometry within the given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the geometry\.

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Triangulate(double)'></a>

## Rectangle3D\.Triangulate\(double\) Method

Triangulates the geometry into a list of 3D triangles using the specified tolerance\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Triangle3D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Rectangle3D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the distance tolerance used during the triangulation process\.

Implements [Triangulate\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.triangulate#digi-geometry-spatial-interfaces-ipolygonal3d-triangulate(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.Triangulate\(System\.Double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Triangle3D>` containing the resulting 3D triangles, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane is not defined or the 2D triangulation fails\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D'></a>

## Segment3D Class

Represents a three\-dimensional line segment defined by two points in 3D space\.

```csharp
public class Segment3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D, DiGi.Geometry.Spatial.Interfaces.ILinear3D, DiGi.Geometry.Spatial.Interfaces.ITransformable3D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Core.Interfaces.ISegment<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegment
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Segment3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransformable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Core\.Interfaces\.ISegment&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegment](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment 'DiGi\.Geometry\.Core\.Interfaces\.ISegment')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Segment3D\(Point3D, Point3D\) Constructor

Initializes a new instance of the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') class using a starting point and an ending point\.

```csharp
public Segment3D(DiGi.Geometry.Spatial.Classes.Point3D? start, DiGi.Geometry.Spatial.Classes.Point3D? end);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).start'></a>

`start` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the start of the segment\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).end'></a>

`end` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the end of the segment\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Segment3D\(Point3D, Vector3D\) Constructor

Initializes a new instance of the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') class using the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') start point and [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

```csharp
public Segment3D(DiGi.Geometry.Spatial.Classes.Point3D? start, DiGi.Geometry.Spatial.Classes.Vector3D? vector);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).start'></a>

`start` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the starting point of the segment\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector'></a>

`vector` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that defines the direction and length of the segment\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Segment3D)'></a>

## Segment3D\(Segment3D\) Constructor

Initializes a new instance of the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') class based on an existing [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') object\.

```csharp
public Segment3D(DiGi.Geometry.Spatial.Classes.Segment3D? segment3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(DiGi.Geometry.Spatial.Classes.Segment3D).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double)'></a>

## Segment3D\(double, double, double, double, double, double\) Constructor

Initializes a new instance of the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') class using the coordinates of two points\.

```csharp
public Segment3D(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double x\-coordinate of the first point\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double y\-coordinate of the first point\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double).z_1'></a>

`z_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double z\-coordinate of the first point\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double x\-coordinate of the second point\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double y\-coordinate of the second point\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(double,double,double,double,double,double).z_2'></a>

`z_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double z\-coordinate of the second point\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(System.Text.Json.Nodes.JsonObject)'></a>

## Segment3D\(JsonObject\) Constructor

Initializes a new instance of the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') class from the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Segment3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Segment3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Direction'></a>

## Segment3D\.Direction Property

Gets the normalized direction as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.
Returns null if the underlying vector is not defined\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Direction { get; }
```

Implements [Direction](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.direction 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Direction')

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.End'></a>

## Segment3D\.End Property

Gets or sets the end point of the line segment\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? End { get; set; }
```

Implements [End](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1.end 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1\.End')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the calculated end point, or `null` if the start point or vector is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Length'></a>

## Segment3D\.Length Property

Gets the length of the segment\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance between the start and end points, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either point is null\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.SquaredLength'></a>

## Segment3D\.SquaredLength Property

Gets the squared length of the vector\.

```csharp
public double SquaredLength { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the squared length, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the vector is null\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Start'></a>

## Segment3D\.Start Property

Gets or sets the starting [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') position\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Start { get; set; }
```

Implements [Start](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegment-1.start 'DiGi\.Geometry\.Core\.Interfaces\.ISegment\`1\.Start')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.this[int]'></a>

## Segment3D\.this\[int\] Property

Gets the point at the specified index of the segment\. Index 0 represents the start point and index 1 represents the end point\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the point to retrieve\.

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Vector'></a>

## Segment3D\.Vector Property

Gets or sets the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') value\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Vector { get; set; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Clone()'></a>

## Segment3D\.Clone\(\) Method

Creates a copy of the current instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current instance, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Segment3D\.ClosestPoint\(Point3D\) Method

Calculates the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the object to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

Implements [ClosestPoint\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.closestpoint#digi-geometry-spatial-interfaces-ilinear3d-closestpoint(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.ClosestPoint\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found, or null if it cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double)'></a>

## Segment3D\.Collinear\(ILinear3D, double\) Method

Determines whether this linear object is collinear with the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object within a given tolerance\.

```csharp
public bool Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D? linear3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).linear3D'></a>

`linear3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object to check for collinearity\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Collinear(DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if the directions are collinear\.

Implements [Collinear\(ILinear3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.collinear#digi-geometry-spatial-interfaces-ilinear3d-collinear(digi-geometry-spatial-interfaces-ilinear3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Collinear\(DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the objects are collinear; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Segment3D\.Distance\(Point3D\) Method

Calculates the distance between this object and the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to calculate the distance to\.

Implements [Distance\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.distance#digi-geometry-spatial-interfaces-ilinear3d-distance(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Distance\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the calculated distance\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.GetBoundingBox()'></a>

## Segment3D\.GetBoundingBox\(\) Method

Calculates and returns the 3D bounding box for the current object\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the start point or vector is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.GetPoints()'></a>

## Segment3D\.GetPoints\(\) Method

Retrieves the list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points defining the segment\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects containing the start and end points if they are valid; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.GetSegments()'></a>

## Segment3D\.GetSegments\(\) Method

Retrieves a list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segments\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') instances, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Inverse()'></a>

## Segment3D\.Inverse\(\) Method

Inverts the direction of the vector and swaps the start point with the end point\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\. Returns true if the end point is a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and the vector is not null; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Mid()'></a>

## Segment3D\.Mid\(\) Method

Calculates the midpoint of the segment\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Mid();
```

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the midpoint if the starting point and vector are valid; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Segment3D\.Move\(Vector3D\) Method

Moves the object by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') translation vector\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the move operation was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Segment3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on the entity within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the point is on the entity\.

Implements [On\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.on#digi-geometry-spatial-interfaces-ilinear3d-on(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.On\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the point is within the specified tolerance; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Project(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Segment3D\.Project\(Point3D\) Method

Projects the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') onto the line segment\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Project(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Project(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to project\.

Implements [Project\(Point3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d.project#digi-geometry-spatial-interfaces-ilinear3d-project(digi-geometry-spatial-classes-point3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D\.Project\(DiGi\.Geometry\.Spatial\.Classes\.Point3D\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The projected [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D'), or null if the projection cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D)'></a>

## Segment3D\.Transform\(ITransform3D\) Method

Transforms the object using the specified 3D transformation\.

```csharp
public bool Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segment3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D).transform'></a>

`transform` [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') instance used to perform the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D'></a>

## Segmentable3D Class

Provides an abstract base implementation for 3D geometries that can be segmented\.

```csharp
public abstract class Segmentable3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Segmentable3D

Derived  
↳ [Polyloop](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyloop 'DiGi\.Geometry\.Spatial\.Classes\.Polyloop')

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D()'></a>

## Segmentable3D\(\) Constructor

Initializes a new instance of the [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') class\.

```csharp
public Segmentable3D();
```

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D(DiGi.Geometry.Spatial.Classes.Segmentable3D)'></a>

## Segmentable3D\(Segmentable3D\) Constructor

Initializes a new instance of the [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') class using another [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') instance\.

```csharp
public Segmentable3D(DiGi.Geometry.Spatial.Classes.Segmentable3D? segmentable3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D(DiGi.Geometry.Spatial.Classes.Segmentable3D).segmentable3D'></a>

`segmentable3D` [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D')

The [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Segmentable3D\(IEnumerable\<Point3D\>\) Constructor

Initializes a new instance of the [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') class\.

```csharp
public Segmentable3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects used to initialize the points\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D(System.Text.Json.Nodes.JsonObject)'></a>

## Segmentable3D\(JsonObject\) Constructor

Initializes a new instance of the [Segmentable3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segmentable3D 'DiGi\.Geometry\.Spatial\.Classes\.Segmentable3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Segmentable3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Segmentable3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the instance\. This value can be null\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Length'></a>

## Segmentable3D\.Length Property

Gets the total length of the object calculated from its 3D segments\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the total length, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if no segments are available\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Segmentable3D\.ClosestPoint\(Point3D\) Method

Calculates the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the geometry to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point'></a>

`point` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used as the reference for finding the closest point\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or no points are available\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Segmentable3D\.Distance\(Point3D\) Method

Calculates the distance from the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the closest point in the collection of segments\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point'></a>

`point` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used to calculate the distance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the shortest distance, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided point is null or no points exist in the collection\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.GetBoundingBox()'></a>

## Segmentable3D\.GetBoundingBox\(\) Method

Calculates the bounding box for the current set of points\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if there are no points available\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.GetPoints()'></a>

## Segmentable3D\.GetPoints\(\) Method

Retrieves a filtered clone of the point collection\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the points if they exist; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.GetSegments()'></a>

## Segmentable3D\.GetSegments\(\) Method

Retrieves the list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects that define the geometry of the entity\.

```csharp
public abstract System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') instances, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no segments are available\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Inverse()'></a>

## Segmentable3D\.Inverse\(\) Method

Reverses the order of the points\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Segmentable3D\.Move\(Vector3D\) Method

Moves all associated points by the specified Vector3D vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? vector used for translation\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool value indicating whether the move operation was successfully performed\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Segmentable3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') lies on the object within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point'></a>

`point` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Segmentable3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the tolerance for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the object\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere'></a>

## Sphere Class

Represents a sphere in three\-dimensional space\.

```csharp
public class Sphere : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IEllipsoid, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Sphere

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Sphere\(Point3D, double\) Constructor

Initializes a new instance of the [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') class with the specified center and radius\.

```csharp
public Sphere(DiGi.Geometry.Spatial.Classes.Point3D? center, double radius);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(DiGi.Geometry.Spatial.Classes.Point3D,double).center'></a>

`center` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the center of the sphere\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(DiGi.Geometry.Spatial.Classes.Point3D,double).radius'></a>

`radius` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the radius of the sphere\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(DiGi.Geometry.Spatial.Classes.Sphere)'></a>

## Sphere\(Sphere\) Constructor

Initializes a new instance of the [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') class by copying the properties from an existing [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') object\.

```csharp
public Sphere(DiGi.Geometry.Spatial.Classes.Sphere? sphere);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(DiGi.Geometry.Spatial.Classes.Sphere).sphere'></a>

`sphere` [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(System.Text.Json.Nodes.JsonObject)'></a>

## Sphere\(JsonObject\) Constructor

Initializes a new instance of the [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Sphere(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Sphere(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the sphere data\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Center'></a>

## Sphere\.Center Property

Gets the center point of the object as a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Center { get; }
```

Implements [Center](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid.center 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid\.Center')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the center, or null if it is not specified\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Extent'></a>

## Sphere\.Extent Property

Gets the extent of the object as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Extent { get; }
```

Implements [Extent](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid.extent 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid\.Extent')

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the dimensions of the object, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Radius'></a>

## Sphere\.Radius Property

Gets the radius of the object as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

```csharp
public double Radius { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Sphere.GetBoundingBox()'></a>

## Sphere\.GetBoundingBox\(\) Method

Calculates the axis\-aligned bounding box of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the center is null, the radius is NaN, or the extent cannot be determined\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.GetPoint(double,double)'></a>

## Sphere\.GetPoint\(double, double\) Method

Calculates a 3D point on the surface of the sphere based on the provided spherical coordinates\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetPoint(double theta, double phi);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.GetPoint(double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuthal angle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.GetPoint(double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The polar angle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the calculated point, or `null` if the center is null or the radius is NaN\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.GetVolume()'></a>

## Sphere\.GetVolume\(\) Method

Calculates the volume of the sphere\.

```csharp
public double GetVolume();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A double value representing the calculated volume\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Sphere\.Inside\(Point3D, double\) Method

Determines whether the specified 3D point is located within the volume, considering a distance tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')? point to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance to be added to the radius\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the point is inside or on the boundary of the volume; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Sphere\.Inside\(IPolygonalFace3D, double\) Method

Determines whether the current object is inside the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to check against\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the distance calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the object is inside the specified polygonal face\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Sphere\.Inside\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside, using a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether all points of the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object are inside; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Sphere\.Move\(Vector3D\) Method

Moves the object by the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector to move the object by\. This parameter can be null\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the movement was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Sphere\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') lies on the surface of the object within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Sphere.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Sphere.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the point is on the surface; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid'></a>

## Spheroid Class

Represents a spheroid geometry in 3D space, which is a special case of an ellipsoid where two axes are equal\.

```csharp
public class Spheroid : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IEllipsoid, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Spheroid

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Plane,double,double)'></a>

## Spheroid\(Plane, double, double\) Constructor

Initializes a new instance of the [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') class with the specified plane and axis lengths\.

```csharp
public Spheroid(DiGi.Geometry.Spatial.Classes.Plane? plane, double a, double b);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Plane,double,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid\.Plane') that defines the orientation of the spheroid, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Plane,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The first semi\-axis length as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Plane,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The second semi\-axis length as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Point3D,double,double)'></a>

## Spheroid\(Point3D, double, double\) Constructor

Initializes a new instance of the [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') class using a specified center point and semi\-axis lengths\.

```csharp
public Spheroid(DiGi.Geometry.Spatial.Classes.Point3D? center, double a, double b);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Point3D,double,double).center'></a>

`center` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the center of the spheroid\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Point3D,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the first semi\-axis length\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Point3D,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the second semi\-axis length\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Spheroid)'></a>

## Spheroid\(Spheroid\) Constructor

Initializes a new instance of the [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') class by copying the properties from an existing [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') object\.

```csharp
public Spheroid(DiGi.Geometry.Spatial.Classes.Spheroid? spheroid);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(DiGi.Geometry.Spatial.Classes.Spheroid).spheroid'></a>

`spheroid` [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid')

The [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') object to copy data from\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(System.Text.Json.Nodes.JsonObject)'></a>

## Spheroid\(JsonObject\) Constructor

Initializes a new instance of the [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') class\.

```csharp
public Spheroid(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Spheroid(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.A'></a>

## Spheroid\.A Property

Gets the double value of A\.

```csharp
public double A { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.B'></a>

## Spheroid\.B Property

Gets the double value of B\.

```csharp
public double B { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Center'></a>

## Spheroid\.Center Property

Gets the center point of the plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Center { get; }
```

Implements [Center](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid.center 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid\.Center')

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the center, or null if no plane is defined\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.DirectionA'></a>

## Spheroid\.DirectionA Property

Gets the primary direction vector \([Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\) representing the X\-axis of the plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? DirectionA { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') value of the X\-axis, or null if no plane is associated\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.DirectionB'></a>

## Spheroid\.DirectionB Property

Gets the second direction vector, which corresponds to the Y\-axis of the associated plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? DirectionB { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A nullable [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the Y\-axis of the plane\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.DirectionC'></a>

## Spheroid\.DirectionC Property

Gets the direction vector C, which corresponds to the Z\-axis of the plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? DirectionC { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Extent'></a>

## Spheroid\.Extent Property

Gets the extent of the object\. Returns a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') if the plane is defined; otherwise, returns null\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Extent { get; }
```

Implements [Extent](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iellipsoid.extent 'DiGi\.Geometry\.Spatial\.Interfaces\.IEllipsoid\.Extent')

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the calculated extent, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Plane'></a>

## Spheroid\.Plane Property

Gets the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid\.Plane') associated with this instance\.

```csharp
public DiGi.Geometry.Spatial.Classes.Plane? Plane { get; }
```

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid\.Plane'), or `null` if no plane is defined\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.GetBoundingBox()'></a>

## Spheroid\.GetBoundingBox\(\) Method

Calculates and returns the 3D bounding box of the object based on its center and extent\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the center or extent is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.GetPoint(double,double)'></a>

## Spheroid\.GetPoint\(double, double\) Method

Calculates a point on the surface of the ellipsoid based on the provided spherical coordinates\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetPoint(double theta, double phi);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.GetPoint(double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuthal angle as a double\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.GetPoint(double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The polar angle as a double\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A Point3D? representing the calculated point in 3D space, or null if the plane is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.GetVolume()'></a>

## Spheroid\.GetVolume\(\) Method

Calculates the volume of the ellipsoid\.

```csharp
public double GetVolume();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated volume as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Spheroid\.Inside\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the boundaries of the object within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for the boundary calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the point is inside; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Spheroid\.Move\(Vector3D\) Method

Moves the object by the specified Vector3D? vector\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? value representing the movement vector\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the move operation was successful; otherwise, false\.
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.op_ImplicitDiGi.Geometry.Spatial.Classes.Spheroid(DiGi.Geometry.Spatial.Classes.Sphere)'></a>

## Spheroid\.implicit operator Spheroid\(Sphere\) Operator

Implicitly converts a [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') to a [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Spheroid? implicit operator DiGi.Geometry.Spatial.Classes.Spheroid?(DiGi.Geometry.Spatial.Classes.Sphere? sphere);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Spheroid.op_ImplicitDiGi.Geometry.Spatial.Classes.Spheroid(DiGi.Geometry.Spatial.Classes.Sphere).sphere'></a>

`sphere` [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The sphere instance to convert\.

#### Returns
[Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid')  
A new [Spheroid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Spheroid 'DiGi\.Geometry\.Spatial\.Classes\.Spheroid') instance with radii equal to the sphere's radius, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided sphere is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Transform3D'></a>

## Transform3D Class

Represents a 3D transformation\.

```csharp
public class Transform3D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Spatial.Interfaces.ITransform3D, DiGi.Geometry.Core.Interfaces.ITransform, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Transform3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransform](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransform 'DiGi\.Geometry\.Core\.Interfaces\.ITransform'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transform3D(DiGi.Geometry.Spatial.Classes.Transform3D)'></a>

## Transform3D\(Transform3D\) Constructor

Initializes a new instance of the [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') class by copying another [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') instance\.

```csharp
public Transform3D(DiGi.Geometry.Spatial.Classes.Transform3D? transform3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transform3D(DiGi.Geometry.Spatial.Classes.Transform3D).transform3D'></a>

`transform3D` [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')

The source [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') object to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transform3D(DiGi.Math.Classes.Matrix4D)'></a>

## Transform3D\(Matrix4D\) Constructor

Initializes a new instance of the [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') class using the specified [Matrix4D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D.Matrix4D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D\.Matrix4D')\.

```csharp
public Transform3D(DiGi.Math.Classes.Matrix4D? matrix4D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transform3D(DiGi.Math.Classes.Matrix4D).matrix4D'></a>

`matrix4D` [DiGi\.Math\.Classes\.Matrix4D](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix4d 'DiGi\.Math\.Classes\.Matrix4D')

The [Matrix4D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D.Matrix4D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D\.Matrix4D') to initialize the transform with\.

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transform3D(System.Text.Json.Nodes.JsonObject)'></a>

## Transform3D\(JsonObject\) Constructor

Initializes a new instance of the [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Transform3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transform3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Matrix4D'></a>

## Transform3D\.Matrix4D Property

Gets the 4x4 transformation matrix\.

```csharp
public DiGi.Math.Classes.Matrix4D? Matrix4D { get; }
```

#### Property Value
[DiGi\.Math\.Classes\.Matrix4D](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix4d 'DiGi\.Math\.Classes\.Matrix4D')  
A [Matrix4D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D.Matrix4D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D\.Matrix4D') instance, or `null` if the matrix is not defined\.

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.this[int,int]'></a>

## Transform3D\.this\[int, int\] Property

Gets or sets the element at the specified row and column of the transformation matrix\.

```csharp
public double this[int row, int column] { get; set; }
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.this[int,int].row'></a>

`row` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.this[int,int].column'></a>

`column` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Inverse()'></a>

## Transform3D\.Inverse\(\) Method

Inverts the current matrix\.

```csharp
public void Inverse();
```

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.Transpose()'></a>

## Transform3D\.Transpose\(\) Method

Transposes the internal 4D matrix\.

```csharp
public void Transpose();
```
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Transform3D)'></a>

## Transform3D\.operator \*\(Transform3D, Transform3D\) Operator

Multiplies two 3D transformations together to create a combined transformation\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? operator *(DiGi.Geometry.Spatial.Classes.Transform3D? transform3D_1, DiGi.Geometry.Spatial.Classes.Transform3D? transform3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Transform3D).transform3D_1'></a>

`transform3D_1` [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')

The first 3D transformation\.

<a name='DiGi.Geometry.Spatial.Classes.Transform3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Transform3D).transform3D_2'></a>

`transform3D_2` [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')

The second 3D transformation\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A new [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the combined result, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either operand is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D'></a>

## TransformGroup3D Class

Represents a group of 3D transformations that can be treated as a single transformation or iterated over as a collection of [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') objects\.

```csharp
public class TransformGroup3D : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Spatial.Interfaces.ITransform3D, DiGi.Geometry.Core.Interfaces.ITransform, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TransformGroup3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransform](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransform 'DiGi\.Geometry\.Core\.Interfaces\.ITransform'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.TransformGroup3D(DiGi.Geometry.Spatial.Classes.TransformGroup3D)'></a>

## TransformGroup3D\(TransformGroup3D\) Constructor

Initializes a new instance of the [TransformGroup3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.TransformGroup3D 'DiGi\.Geometry\.Spatial\.Classes\.TransformGroup3D') class by cloning an existing [TransformGroup3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.TransformGroup3D 'DiGi\.Geometry\.Spatial\.Classes\.TransformGroup3D') instance\.

```csharp
public TransformGroup3D(DiGi.Geometry.Spatial.Classes.TransformGroup3D? transformGroup3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.TransformGroup3D(DiGi.Geometry.Spatial.Classes.TransformGroup3D).transformGroup3D'></a>

`transformGroup3D` [TransformGroup3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.TransformGroup3D 'DiGi\.Geometry\.Spatial\.Classes\.TransformGroup3D')

The [TransformGroup3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.TransformGroup3D 'DiGi\.Geometry\.Spatial\.Classes\.TransformGroup3D') instance to clone from, or null to initialize without a source\.

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.TransformGroup3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.ITransform3D_)'></a>

## TransformGroup3D\(IEnumerable\<ITransform3D\>\) Constructor

Initializes a new instance of the [TransformGroup3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.TransformGroup3D 'DiGi\.Geometry\.Spatial\.Classes\.TransformGroup3D') class with the specified collection of transforms\.

```csharp
public TransformGroup3D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>? transform3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.TransformGroup3D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.ITransform3D_).transform3Ds'></a>

`transform3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the transform objects to be added to the group\. This value can be null\.

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.TransformGroup3D(System.Text.Json.Nodes.JsonObject)'></a>

## TransformGroup3D\(JsonObject\) Constructor

Initializes a new instance of the [TransformGroup3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.TransformGroup3D 'DiGi\.Geometry\.Spatial\.Classes\.TransformGroup3D') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public TransformGroup3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.TransformGroup3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the object\. This value can be null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.TransformGroup3D.GetEnumerator()'></a>

## TransformGroup3D\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') objects\.

```csharp
public System.Collections.Generic.IEnumerator<DiGi.Geometry.Spatial.Interfaces.ITransform3D> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An [System\.Collections\.Generic\.IEnumerator&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1') for the [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') collection\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D'></a>

## Triangle3D Class

Represents a three\-dimensional triangle geometry\.

```csharp
public class Triangle3D : DiGi.Geometry.Spatial.Classes.Geometry3D, DiGi.Geometry.Spatial.Interfaces.IPlanar<DiGi.Geometry.Planar.Classes.Triangle2D>, DiGi.Geometry.Spatial.Interfaces.IPlanar, DiGi.Geometry.Spatial.Interfaces.IGeometry3D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.IMovable3D, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D<DiGi.Geometry.Planar.Classes.Triangle2D>, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D, DiGi.Geometry.Spatial.Interfaces.IClosedPlanarCurve3D, DiGi.Geometry.Spatial.Interfaces.IClosedCurve3D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Spatial.Interfaces.ICurve3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Spatial.Interfaces.IBoundable3D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Spatial.Interfaces.IInvertible3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Geometry3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Geometry3D 'DiGi\.Geometry\.Spatial\.Classes\.Geometry3D') → Triangle3D

Implements [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar'), [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\`1'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedcurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedCurve3D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.icurve3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ICurve3D'), [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iinvertible3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IInvertible3D')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Triangle3D\(Point3D, Point3D, Point3D\) Constructor

Initializes a new instance of the [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') class using three specified 3D points\.

```csharp
public Triangle3D(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point of the triangle\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point of the triangle\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point of the triangle\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(DiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Triangle3D\(Triangle3D\) Constructor

Initializes a new instance of the [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') class using another [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') instance\.

```csharp
public Triangle3D(DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(DiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') instance to copy from\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(System.Text.Json.Nodes.JsonObject)'></a>

## Triangle3D\(JsonObject\) Constructor

Initializes a new instance of the [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Triangle3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangle3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize this instance\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Geometry2D'></a>

## Triangle3D\.Geometry2D Property

Gets the 2D geometry representation of the triangle\.

```csharp
public DiGi.Geometry.Planar.Classes.Triangle2D? Geometry2D { get; }
```

Implements [Geometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1.geometry2d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1\.Geometry2D')

#### Property Value
[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')  
A [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') representing the projected coordinates if the plane is available and conversion succeeds; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Length'></a>

## Triangle3D\.Length Property

Gets the total length of the perimeter formed by the three points\.
Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the points collection is null or any individual point is null\.

```csharp
public double Length { get; }
```

Implements [Length](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable.length 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\.Length')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the calculated length\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Plane'></a>

## Triangle3D\.Plane Property

Gets the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D\.Plane') defined by the first three points of the collection\.

```csharp
public DiGi.Geometry.Spatial.Classes.Plane? Plane { get; }
```

Implements [Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar.plane 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\.Plane')

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
The calculated [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D\.Plane') instance, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.this[int]'></a>

## Triangle3D\.this\[int\] Property

Gets the point at the specified index\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? this[int index] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the point to retrieve\.

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Clone()'></a>

## Triangle3D\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
An [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a copy of the current instance, or null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Triangle3D\.ClosestPoint\(Point3D\) Method

Finds the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the specified point\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.ClosestPoint(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used as the reference for finding the nearest neighbor\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided point is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or no points are available\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Triangle3D\.Distance\(Point3D\) Method

Calculates the distance from the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the closest point in the collection\.

```csharp
public double Distance(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Distance(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance used as the reference point for the distance calculation\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance to the closest point, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null, the internal points collection is null, or no closest point is found\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetArea()'></a>

## Triangle3D\.GetArea\(\) Method

Calculates the area of the triangle formed by the points using Heron's formula\.

```csharp
public double GetArea();
```

Implements [GetArea\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getarea 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetArea')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the calculated area, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the points array is null or contains null elements\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetBoundingBox()'></a>

## Triangle3D\.GetBoundingBox\(\) Method

Calculates the bounding box for the set of points\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? GetBoundingBox();
```

Implements [GetBoundingBox\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iboundable3d.getboundingbox 'DiGi\.Geometry\.Spatial\.Interfaces\.IBoundable3D\.GetBoundingBox')

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the points are null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetCentroid()'></a>

## Triangle3D\.GetCentroid\(\) Method

Calculates the centroid of the point collection\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetCentroid();
```

Implements [GetCentroid\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.getcentroid 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.GetCentroid')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the centroid, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if it cannot be calculated\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetInternalPoint(double)'></a>

## Triangle3D\.GetInternalPoint\(double\) Method

Gets an internal point of the object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculations\.

Implements [GetInternalPoint\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.getinternalpoint#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-getinternalpoint(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.GetInternalPoint\(System\.Double\)')

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the internal point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no points are available\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetPerimeter()'></a>

## Triangle3D\.GetPerimeter\(\) Method

Gets the perimeter of the object\.

```csharp
public double GetPerimeter();
```

Implements [GetPerimeter\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve.getperimeter 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve\.GetPerimeter')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the total length of the perimeter\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetPoints()'></a>

## Triangle3D\.GetPoints\(\) Method

Retrieves a list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points, filtering out any null entries\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? GetPoints();
```

Implements [GetPoints\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1.getpoints 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1\.GetPoints')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Point3D>` containing the filtered points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the source is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.GetSegments()'></a>

## Triangle3D\.GetSegments\(\) Method

Retrieves the list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects that define the segments of the object\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? GetSegments();
```

Implements [GetSegments\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d.getsegments 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D\.GetSegments')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the segments if points are available; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Triangle3D\.InRange\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within the given tolerance distance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check for proximity\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.InRange(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the allowed distance tolerance\.

Implements [InRange\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inrange#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inrange(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.InRange\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is within range; otherwise, false if the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') or internal points are null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Triangle3D\.InRange\(ISegmentable3D, double\) Method

Determines whether the points of the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object are within a given distance tolerance\.

```csharp
public bool InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.InRange(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the range check\.

Implements [InRange\(ISegmentable3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.inrange#digi-geometry-spatial-interfaces-ipolygonal3d-inrange(digi-geometry-spatial-interfaces-isegmentable3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.InRange\(DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the points are within the specified range; returns false if the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object or internal points are null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Triangle3D\.Inside\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located inside the current object within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to check for containment\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inside(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the calculation\.

Implements [Inside\(Point3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iclosedplanarcurve3d.inside#digi-geometry-spatial-interfaces-iclosedplanarcurve3d-inside(digi-geometry-spatial-classes-point3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IClosedPlanarCurve3D\.Inside\(DiGi\.Geometry\.Spatial\.Classes\.Point3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is inside; returns false if the point or internal points are null\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Triangle3D\.Inside\(ISegmentable3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside within a given tolerance\.

```csharp
public bool Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to check\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inside(DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the operation\.

Implements [Inside\(ISegmentable3D, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.inside#digi-geometry-spatial-interfaces-ipolygonal3d-inside(digi-geometry-spatial-interfaces-isegmentable3d-system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.Inside\(DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D,System\.Double\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Inverse()'></a>

## Triangle3D\.Inverse\(\) Method

Inverts the points by swapping the first and third elements\.

```csharp
public bool Inverse();
```

Implements [Inverse\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible.inverse 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible\.Inverse')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the inversion was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Triangle3D\.Move\(Vector3D\) Method

Moves the object by the specified Vector3D\.

```csharp
public override bool Move(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Move(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The Vector3D? value to move the points by\.

Implements [Move\(Vector3D\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.imovable3d.move#digi-geometry-spatial-interfaces-imovable3d-move(digi-geometry-spatial-classes-vector3d) 'DiGi\.Geometry\.Spatial\.Interfaces\.IMovable3D\.Move\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A bool indicating whether the movement was successful\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Triangle3D\.On\(Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located on this object within a given tolerance\.

```csharp
public bool On(DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.On(DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on this object\.

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangulate(double)'></a>

## Triangle3D\.Triangulate\(double\) Method

Triangulates the object into a list of 3D triangles using the specified tolerance\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Triangle3D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Triangle3D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for triangulation\.

Implements [Triangulate\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d.triangulate#digi-geometry-spatial-interfaces-ipolygonal3d-triangulate(system-double) 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D\.Triangulate\(System\.Double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated triangles, or `null` if the object cannot be triangulated\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D'></a>

## Vector3D Class

Represents a three\-dimensional vector\.

```csharp
public class Vector3D : DiGi.Geometry.Spatial.Classes.Coordinate3D, DiGi.Geometry.Core.Interfaces.IVector, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Spatial.Interfaces.ITransformable3D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Spatial.Interfaces.ITransform3D>, DiGi.Geometry.Core.Interfaces.ITransformable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Coordinate](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.Coordinate 'DiGi\.Geometry\.Core\.Classes\.Coordinate') → [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') → Vector3D

Implements [DiGi\.Geometry\.Core\.Interfaces\.IVector](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ivector 'DiGi\.Geometry\.Core\.Interfaces\.IVector'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransformable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransformable3D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable')
### Constructors

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Vector3D\(Point3D, Point3D\) Constructor

Initializes a new instance of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') class based on two points\.

```csharp
public Vector3D(DiGi.Geometry.Spatial.Classes.Point3D? start, DiGi.Geometry.Spatial.Classes.Point3D? end);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).start'></a>

`start` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The starting [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).end'></a>

`end` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The ending [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\(Vector3D\) Constructor

Initializes a new instance of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') class using the values from an existing [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') object to copy the values from\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(double,double,double)'></a>

## Vector3D\(double, double, double\) Constructor

Initializes a new instance of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') class with the specified x, y, and z coordinates\.

```csharp
public Vector3D(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The x\-coordinate as a double\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The y\-coordinate as a double\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The z\-coordinate as a double\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(double[])'></a>

## Vector3D\(double\[\]\) Constructor

Initializes a new instance of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') class using the specified array of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

```csharp
public Vector3D(double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An optional array of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values to initialize the vector coordinates\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(System.Text.Json.Nodes.JsonObject)'></a>

## Vector3D\(JsonObject\) Constructor

Initializes a new instance of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') class using the provided [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Vector3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Vector3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the vector\.
### Properties

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Length'></a>

## Vector3D\.Length Property

Gets or sets the length \(magnitude\) of the vector\.

```csharp
public double Length { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the length of the vector\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.SquaredLength'></a>

## Vector3D\.SquaredLength Property

Gets the squared length of the vector\.

```csharp
public double SquaredLength { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared length as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Unit'></a>

## Vector3D\.Unit Property

Gets the unit vector of the current instance\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Unit { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normalized direction, or null\.
### Methods

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Angle(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.Angle\(Vector3D\) Method

Calculates the angle between this vector and another [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public double Angle(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Angle(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The other [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to calculate the angle with\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The angle in radians as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the provided [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') is null\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Clone()'></a>

## Vector3D\.Clone\(\) Method

Creates a copy of the current [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') that is a clone of the current instance\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Collinear(DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Vector3D\.Collinear\(Vector3D, double\) Method

Determines whether this vector is collinear with the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') within a given tolerance\.

```csharp
public bool Collinear(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Collinear(DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to check for collinearity\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Collinear(DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the maximum allowed difference to consider the vectors collinear\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the vectors are collinear; returns false if the provided [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') is null\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.CrossProduct(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.CrossProduct\(Vector3D\) Method

Calculates the cross product of this vector and the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\. The resulting vector is orthogonal to both original vectors\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? CrossProduct(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.CrossProduct(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to calculate the cross product with\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the cross product, or `null` if either vector is null\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.DotProduct(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.DotProduct\(Vector3D\) Method

Calculates the dot product of this vector and the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public double DotProduct(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.DotProduct(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to calculate the dot product with\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the dot product, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either vector is null\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Equals(object)'></a>

## Vector3D\.Equals\(object\) Method

Determines whether the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is equal to the current [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') to compare with the current [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the specified [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') is equal to the current [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.GetAbs()'></a>

## Vector3D\.GetAbs\(\) Method

Returns a new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') containing the absolute values of the current vector's components\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D GetAbs();
```

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the absolute value of the current vector\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.GetHashCode()'></a>

## Vector3D\.GetHashCode\(\) Method

Returns a hash code for the current object\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') that is the hash code for the current object\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.GetInversed()'></a>

## Vector3D\.GetInversed\(\) Method

Returns a new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instance that is the inverse of the current vector\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D GetInversed();
```

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the inversed vector\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.MinAngle(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.MinAngle\(Vector3D\) Method

Calculates the minimum angle between this vector and the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public double MinAngle(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.MinAngle(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to calculate the angle against\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the smallest angular distance in radians\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Normalize()'></a>

## Vector3D\.Normalize\(\) Method

Normalizes the vector to a unit length of 1\.0\.

```csharp
public void Normalize();
```

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Project(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.Project\(Vector3D\) Method

Project input Vector onto this Vector

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Project(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Project(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Vector to be projected

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
Projection vector

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D)'></a>

## Vector3D\.Transform\(ITransform3D\) Method

Transforms the current vector by applying the specified [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') transformation, ignoring the translation component\.

```csharp
public override bool Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D? transform);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.Transform(DiGi.Geometry.Spatial.Interfaces.ITransform3D).transform'></a>

`transform` [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.itransform3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ITransform3D') object used to perform the transformation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the transformation was successfully applied; otherwise, false\.
### Operators

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Addition(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator \+\(Vector3D, Vector3D\) Operator

Adds two [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instances together using component\-wise addition\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator +(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Addition(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to add\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Addition(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to add\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that is the sum of the two vectors, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either operand is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Division(DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Vector3D\.operator /\(Vector3D, double\) Operator

Divides the components of a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') by a specified scalar factor\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator /(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Division(DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to divide\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Division(DiGi.Geometry.Spatial.Classes.Vector3D,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar factor to divide by\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that is the result of the division, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input vector is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Equality(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator ==\(Vector3D, Vector3D\) Operator

Indicates whether the two specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instances are equal\.

```csharp
public static bool operator ==(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Equality(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to compare\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Equality(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the vectors are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_ExplicitDiGi.Geometry.Spatial.Classes.Vector3D(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Vector3D\.explicit operator Vector3D\(Point3D\) Operator

Explicitly converts a nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to a nullable [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? explicit operator DiGi.Geometry.Spatial.Classes.Vector3D?(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_ExplicitDiGi.Geometry.Spatial.Classes.Vector3D(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance to convert\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A nullable [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the coordinates of the point, or null if the provided point is null\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator \!=\(Vector3D, Vector3D\) Operator

Indicates whether two [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instances are not equal\.

```csharp
public static bool operator !=(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to compare\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Inequality(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the vectors are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator \*\(Vector3D, Vector3D\) Operator

Calculates the dot product of two [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vectors\.

```csharp
public static double operator *(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The dot product of the two vectors, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either vector is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Vector3D\.operator \*\(Vector3D, double\) Operator

Multiplies the components of a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') by a specified scalar factor\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator *(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to scale\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(DiGi.Geometry.Spatial.Classes.Vector3D,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar factor to multiply by\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that is the result of the multiplication, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input vector is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(double,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator \*\(double, Vector3D\) Operator

Multiplies the components of a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') by a specified scalar factor\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator *(double factor, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(double,DiGi.Geometry.Spatial.Classes.Vector3D).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar factor to multiply by\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Multiply(double,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to scale\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that is the result of the multiplication, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input vector is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator \-\(Vector3D, Vector3D\) Operator

Subtracts one [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector from another\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator -(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_Subtraction(DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector to subtract from the first\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the difference, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either operand is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_UnaryNegation(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Vector3D\.operator \-\(Vector3D\) Operator

Negates the components of the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? operator -(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Classes.Vector3D.op_UnaryNegation(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to negate\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') with negated components, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.