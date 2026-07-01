#### [DiGi\.Geometry](index.md 'index')

## DiGi\.Geometry\.Core Namespace
### Classes

<a name='DiGi.Geometry.Core.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int)'></a>

## Create\.DensityBasedSpatialClusteringResult\<T\>\(this IEnumerable\<T\>, double, int\) Method

Performs density\-based spatial clustering on the provided collection of points\.

```csharp
public static DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult<T>? DensityBasedSpatialClusteringResult<T>(this System.Collections.Generic.IEnumerable<T>? points, double tolerance, int pointCount)
    where T : DiGi.Geometry.Core.Interfaces.IPoint<T>;
```
#### Type parameters

<a name='DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).T'></a>

`T`

The type of point, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')\.
#### Parameters

<a name='DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).T 'DiGi\.Geometry\.Core\.Create\.DensityBasedSpatialClusteringResult\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of points to be clustered\.

<a name='DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance threshold used to determine if two points are neighbors\.

<a name='DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The minimum [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') number of points required to form a dense region\.

#### Returns
[DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult&lt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>')[T](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).T 'DiGi\.Geometry\.Core\.Create\.DensityBasedSpatialClusteringResult\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double, int\)\.T')[&gt;](DiGi.Geometry.Core.Classes.md#DiGi.Geometry.Core.Classes.DensityBasedSpatialClusteringResult_T_ 'DiGi\.Geometry\.Core\.Classes\.DensityBasedSpatialClusteringResult\<T\>')  
A [DensityBasedSpatialClusteringResult&lt;T&gt;\(this IEnumerable&lt;T&gt;, double, int\)](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int) 'DiGi\.Geometry\.Core\.Create\.DensityBasedSpatialClusteringResult\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double, int\)') containing the clustering results, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [points](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Create.DensityBasedSpatialClusteringResult_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,int).points 'DiGi\.Geometry\.Core\.Create\.DensityBasedSpatialClusteringResult\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double, int\)\.points') collection is null\.

<a name='DiGi.Geometry.Core.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Geometry.Core.Query.AdjacencyIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_)'></a>

## Query\.AdjacencyIndexes\(this IEnumerable\<int\[\]\>\) Method

Creates an adjacency dictionary from a collection of indexes\.

```csharp
public static System.Collections.Generic.Dictionary<int,System.Collections.Generic.List<int[]>>? AdjacencyIndexes(this System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.AdjacencyIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of `int[]` representing the indexes to process\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A [System\.Collections\.Generic\.Dictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2') mapping each node index to a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of its adjacent `int[]` edges, or `null` if the input is `null`\.

<a name='DiGi.Geometry.Core.Query.AuxiliaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_)'></a>

## Query\.AuxiliaryIndexes\(this IEnumerable\<int\[\]\>\) Method

Computes the auxiliary indexes based on the provided collection of index arrays\.

```csharp
public static System.Collections.Generic.List<int[]>? AuxiliaryIndexes(this System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.AuxiliaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of `int[]` containing the original indexes\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of `int[]` representing the auxiliary indexes, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Core.Query.BoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_)'></a>

## Query\.BoundaryIndexes\(this IEnumerable\<int\[\]\>\) Method

Identifies and returns the boundary indexes from the provided collection of integer arrays\.

```csharp
public static System.Collections.Generic.List<int[]>? BoundaryIndexes(this System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.BoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of `int[]` representing the indexes to evaluate\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of `int[]` containing the boundary indexes, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Core.Query.BoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_,System.Collections.Generic.List_int[]_)'></a>

## Query\.BoundaryIndexes\(this IEnumerable\<int\[\]\>, List\<int\[\]\>\) Method

Identifies the boundary indexes from a collection of indexes and extracts auxiliary indexes\.

```csharp
public static System.Collections.Generic.List<int[]>? BoundaryIndexes(this System.Collections.Generic.IEnumerable<int[]>? indexes, out System.Collections.Generic.List<int[]>? auxiliaryIndexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.BoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_,System.Collections.Generic.List_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of `int[]` representing the input indexes\.

<a name='DiGi.Geometry.Core.Query.BoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_,System.Collections.Generic.List_int[]_).auxiliaryIndexes'></a>

`auxiliaryIndexes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of `int[]` representing the auxiliary indexes, or null if none were identified\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of `int[]` containing the boundary indexes, or null if the input [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is null\.

<a name='DiGi.Geometry.Core.Query.IsNonManifold(thisSystem.Collections.Generic.IEnumerable_int[]_)'></a>

## Query\.IsNonManifold\(this IEnumerable\<int\[\]\>\) Method

Determines whether the provided collection of indices represents a non\-manifold mesh\.

```csharp
public static bool IsNonManifold(this System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.IsNonManifold(thisSystem.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of `int[]` containing the vertex indices for each face\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the mesh is non\-manifold; otherwise, `false`\.

<a name='DiGi.Geometry.Core.Query.IsoperimetricRatio(double,double)'></a>

## Query\.IsoperimetricRatio\(double, double\) Method

the Isoperimetric Ratio \(IR\) \(also called Isoperimetric Quotient, Circular Compactness, or Shape Factor\) is a classic geometric measure that describes how close a shape is to a perfect circle\.

```csharp
public static double IsoperimetricRatio(double area, double perimeter);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.IsoperimetricRatio(double,double).area'></a>

`area` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Area of the shape

<a name='DiGi.Geometry.Core.Query.IsoperimetricRatio(double,double).perimeter'></a>

`perimeter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Perimeter \(or boundary length\)

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Isoperimetric ratio

<a name='DiGi.Geometry.Core.Query.Opposite(thisDiGi.Geometry.Core.Enums.Alignment)'></a>

## Query\.Opposite\(this Alignment\) Method

Returns the opposite [Alignment](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment 'DiGi\.Geometry\.Core\.Enums\.Alignment') value\.

```csharp
public static DiGi.Geometry.Core.Enums.Alignment Opposite(this DiGi.Geometry.Core.Enums.Alignment alignment);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.Opposite(thisDiGi.Geometry.Core.Enums.Alignment).alignment'></a>

`alignment` [Alignment](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment 'DiGi\.Geometry\.Core\.Enums\.Alignment')

The [Alignment](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment 'DiGi\.Geometry\.Core\.Enums\.Alignment') value to invert\.

#### Returns
[Alignment](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment 'DiGi\.Geometry\.Core\.Enums\.Alignment')  
The opposite [Alignment](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment 'DiGi\.Geometry\.Core\.Enums\.Alignment') value, or [Undefined](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment.Undefined 'DiGi\.Geometry\.Core\.Enums\.Alignment\.Undefined') if no opposite is defined\.

<a name='DiGi.Geometry.Core.Query.Opposite(thisDiGi.Geometry.Core.Enums.Orientation)'></a>

## Query\.Opposite\(this Orientation\) Method

Returns the opposite of the specified [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Opposite(this DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.Opposite(thisDiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') value to invert\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
The opposite [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') value, or [Undefined](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation.Undefined 'DiGi\.Geometry\.Core\.Enums\.Orientation\.Undefined') if the input is undefined or collinear\.

<a name='DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double)'></a>

## Query\.PointsByDistance\<T\>\(this IEnumerable\<T\>, T, double\) Method

Filters a collection of points to find those within a specified distance from a given point\.

```csharp
public static System.Collections.Generic.List<T>? PointsByDistance<T>(this System.Collections.Generic.IEnumerable<T>? points, T? point, double tolerance=1E-06)
    where T : DiGi.Geometry.Core.Interfaces.IPoint<T>;
```
#### Type parameters

<a name='DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).T'></a>

`T`

The type of point, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IPoint&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.ipoint-1 'DiGi\.Geometry\.Core\.Interfaces\.IPoint\`1')\.
#### Parameters

<a name='DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).T 'DiGi\.Geometry\.Core\.Query\.PointsByDistance\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, T, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points to evaluate\.

<a name='DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).point'></a>

`point` [T](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).T 'DiGi\.Geometry\.Core\.Query\.PointsByDistance\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, T, double\)\.T')

The reference point used for distance comparison\.

<a name='DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the maximum allowable distance between points\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Geometry.Core.md#DiGi.Geometry.Core.Query.PointsByDistance_T_(thisSystem.Collections.Generic.IEnumerable_T_,T,double).T 'DiGi\.Geometry\.Core\.Query\.PointsByDistance\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, T, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of points within the specified tolerance, or `null` if either the source collection or the reference point is `null`\.

<a name='DiGi.Geometry.Core.Query.RectangularThinnessRatio(double,double)'></a>

## Query\.RectangularThinnessRatio\(double, double\) Method

The Rectangular Thinness Ratio \(RTR\) — also sometimes called the Rectangular Compactness Ratio or Rectangular Shape Factor — is a geometric shape descriptor that measures how elongated or “thin” a shape is compared to a rectangle that perfectly fits around it \(its minimum bounding rectangle\)\.

```csharp
public static double RectangularThinnessRatio(double area, double rectangleArea);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.RectangularThinnessRatio(double,double).area'></a>

`area` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

shape area

<a name='DiGi.Geometry.Core.Query.RectangularThinnessRatio(double,double).rectangleArea'></a>

`rectangleArea` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Minimal rectangle area

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Rectangular thinness ratio

<a name='DiGi.Geometry.Core.Query.SortedBoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_)'></a>

## Query\.SortedBoundaryIndexes\(this IEnumerable\<int\[\]\>\) Method

Returns the sorted boundary indexes derived from the provided collection of `int[]`\.

```csharp
public static System.Collections.Generic.List<System.Collections.Generic.List<int>>? SortedBoundaryIndexes(this System.Collections.Generic.IEnumerable<int[]>? indexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.SortedBoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of `int[]` representing the input indexes\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') if successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Core.Query.SortedBoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_,System.Collections.Generic.List_int[]_)'></a>

## Query\.SortedBoundaryIndexes\(this IEnumerable\<int\[\]\>, List\<int\[\]\>\) Method

Sorts the boundary indexes into continuous loops of vertex indices\.

```csharp
public static System.Collections.Generic.List<System.Collections.Generic.List<int>>? SortedBoundaryIndexes(this System.Collections.Generic.IEnumerable<int[]>? indexes, out System.Collections.Generic.List<int[]>? auxiliaryIndexes);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.SortedBoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_,System.Collections.Generic.List_int[]_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The IEnumerable\<int\[\]\> containing the mesh index arrays\.

<a name='DiGi.Geometry.Core.Query.SortedBoundaryIndexes(thisSystem.Collections.Generic.IEnumerable_int[]_,System.Collections.Generic.List_int[]_).auxiliaryIndexes'></a>

`auxiliaryIndexes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a List\<int\[\]\> of auxiliary indexes used during boundary detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A List\<List\<int\>\> where each inner list represents a sorted loop of boundary vertex indices; returns null if the input IEnumerable\<int\[\]\> is null\.

<a name='DiGi.Geometry.Core.Query.SquareThinnessRatio(double,double)'></a>

## Query\.SquareThinnessRatio\(double, double\) Method

The Square Thinness Ratio \(STR\) — also sometimes called the Square Compactness Ratio or Square Shape Factor — is a geometric shape descriptor that measures how elongated or “thin” a shape is compared to a square that perfectly fits around it \(its minimum bounding square\)\.

```csharp
public static double SquareThinnessRatio(double area, double squareArea);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.SquareThinnessRatio(double,double).area'></a>

`area` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

shape area

<a name='DiGi.Geometry.Core.Query.SquareThinnessRatio(double,double).squareArea'></a>

`squareArea` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

square area

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Square thinness ratio

<a name='DiGi.Geometry.Core.Query.ThinnessRatio(double,double)'></a>

## Query\.ThinnessRatio\(double, double\) Method

Calculates the thinness ratio of a shape based on its area and perimeter\.

```csharp
public static double ThinnessRatio(double area, double perimeter);
```
#### Parameters

<a name='DiGi.Geometry.Core.Query.ThinnessRatio(double,double).area'></a>

`area` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the area of the shape\.

<a name='DiGi.Geometry.Core.Query.ThinnessRatio(double,double).perimeter'></a>

`perimeter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the perimeter of the shape\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A double value representing the thinness ratio, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either input is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') or if the perimeter is zero\.