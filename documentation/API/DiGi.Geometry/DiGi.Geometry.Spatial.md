#### [DiGi\.Geometry](DiGi.Geometry.Overview.md 'DiGi\.Geometry\.Overview')

## DiGi\.Geometry\.Spatial Namespace
### Classes

<a name='DiGi.Geometry.Spatial.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Geometry.Spatial.Convert.ToDiGi(thisDiGi.Geometry.Spatial.Classes.CoordinateSystem3D)'></a>

## Convert\.ToDiGi\(this CoordinateSystem3D\) Method

Converts a [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') instance to a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? ToDiGi(this DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Convert.ToDiGi(thisDiGi.Geometry.Spatial.Classes.CoordinateSystem3D).coordinateSystem3D'></a>

`coordinateSystem3D` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') instance to convert\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') object if the provided [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Convert.ToDiGi(thisDiGi.Geometry.Spatial.Classes.Plane)'></a>

## Convert\.ToDiGi\(this Plane\) Method

Converts a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to a [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? ToDiGi(this DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Convert.ToDiGi(thisDiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance to convert\.

#### Returns
[CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')  
A [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') representing the plane's coordinate system, or null if the provided [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') is null\.

<a name='DiGi.Geometry.Spatial.Convert.ToNumerics(thisDiGi.Geometry.Spatial.Classes.Coordinate3D)'></a>

## Convert\.ToNumerics\(this Coordinate3D\) Method

Converts a [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') instance to a nullable [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')\.

```csharp
public static System.Nullable<System.Numerics.Vector3> ToNumerics(this DiGi.Geometry.Spatial.Classes.Coordinate3D coordinate3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Convert.ToNumerics(thisDiGi.Geometry.Spatial.Classes.Coordinate3D).coordinate3D'></a>

`coordinate3D` [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D')

The [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') instance to convert\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3') containing the converted coordinates, or `null` if the provided [Coordinate3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Coordinate3D 'DiGi\.Geometry\.Spatial\.Classes\.Coordinate3D') is `null`\.

<a name='DiGi.Geometry.Spatial.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double)'></a>

## Create\.AddBooleanOperationCandidates\(List\<BooleanOperationCandidate\>, List\<IPolygonalFace3D\>, BVHNode, bool, double\) Method

Splits every face of [polygonalFace3Ds](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).polygonalFace3Ds 'DiGi\.Geometry\.Spatial\.Create\.AddBooleanOperationCandidates\(System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode, bool, double\)\.polygonalFace3Ds') by the faces of the other polyhedron that
overlap it \(culled through [bVHNode](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).bVHNode 'DiGi\.Geometry\.Spatial\.Create\.AddBooleanOperationCandidates\(System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode, bool, double\)\.bVHNode')\) and appends the resulting fragments \(or the
unsplit face\) to [booleanOperationCandidates](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).booleanOperationCandidates 'DiGi\.Geometry\.Spatial\.Create\.AddBooleanOperationCandidates\(System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode, bool, double\)\.booleanOperationCandidates')\.

```csharp
private static void AddBooleanOperationCandidates(System.Collections.Generic.List<DiGi.Geometry.Spatial.Create.BooleanOperationCandidate> booleanOperationCandidates, System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> polygonalFace3Ds, DiGi.Geometry.Spatial.Classes.BVHNode bVHNode, bool fromFirst, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).booleanOperationCandidates'></a>

`booleanOperationCandidates` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[BooleanOperationCandidate](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.BooleanOperationCandidate 'DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).bVHNode'></a>

`bVHNode` [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode')

<a name='DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).fromFirst'></a>

`fromFirst` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Geometry.Spatial.Create.AddBooleanOperationCandidates(System.Collections.Generic.List_DiGi.Geometry.Spatial.Create.BooleanOperationCandidate_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationGeometry3Ds(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_)'></a>

## Create\.BooleanOperationGeometry3Ds\(List\<IPolygonalFace3D\>\) Method

Assembles the final boolean operation geometry from the deduplicated boundary faces: a single solid
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') when the faces form a valid closed volume, the individual faces as a
fallback for non\-solid remnants, or null when no geometry remains\.

```csharp
private static System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IGeometry3D>? BooleanOperationGeometry3Ds(System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationGeometry3Ds(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double)'></a>

## Create\.BooleanOperationPolygonalFace3Ds\<TPolygonalFace3D\>\(BooleanOpertaionType, Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, List\<IPolygonalFace3D\>, List\<IPolygonalFace3D\>, BVHNode, double\) Method

Shared core of the 3D boolean operations \(Union, Intersection, Difference\): splits the faces of each
polyhedron by the overlapping faces of the other, classifies every resulting fragment against the other
volume with a single BVH\-accelerated point\-relation query, and deduplicates coplanar overlapping
fragments via a spatial hash\.

```csharp
internal static System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> BooleanOperationPolygonalFace3Ds<TPolygonalFace3D>(DiGi.Geometry.Core.Enums.BooleanOpertaionType booleanOpertaionType, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D> polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D> polyhedron_2, System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> polygonalFace3Ds_1, System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> polygonalFace3Ds_2, out DiGi.Geometry.Spatial.Classes.BVHNode bVHNode_2, double tolerance)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).booleanOpertaionType'></a>

`booleanOpertaionType` [BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')

The boolean operation deciding which fragments are kept\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.BooleanOperationPolygonalFace3Ds\<TPolygonalFace3D\>\(DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The first polyhedron \(used only for the rare exact outward\-normal fallback\)\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.BooleanOperationPolygonalFace3Ds\<TPolygonalFace3D\>\(DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The second polyhedron \(used only for the rare exact outward\-normal fallback\)\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).polygonalFace3Ds_1'></a>

`polygonalFace3Ds_1` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The faces of the first polyhedron \(non\-empty\)\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).polygonalFace3Ds_2'></a>

`polygonalFace3Ds_2` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The faces of the second polyhedron \(non\-empty\)\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).bVHNode_2'></a>

`bVHNode_2` [BVHNode](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode')

The Bounding Volume Hierarchy \(BVH\) built for the second polyhedron, reusable by the caller\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationPolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the boolean computations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The deduplicated boundary faces of the result volume \(never null; possibly empty\)\. Difference results have the retained second\-polyhedron fragments inverted\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double)'></a>

## Create\.BooleanOperationResult3D\<TPolygonalFace3D\>\(this BooleanOpertaionType, Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, double\) Method

Calculates the 3D boolean operation result between two polyhedra based on the specified operation type\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BooleanOperationResult3D? BooleanOperationResult3D<TPolygonalFace3D>(this DiGi.Geometry.Core.Enums.BooleanOpertaionType booleanOpertaionType, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).booleanOpertaionType'></a>

`booleanOpertaionType` [BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')

The type of the boolean operation\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.BooleanOperationResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The first polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.BooleanOperationResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The second polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the boolean computations\.

#### Returns
[BooleanOperationResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BooleanOperationResult3D 'DiGi\.Geometry\.Spatial\.Classes\.BooleanOperationResult3D')  
A [BooleanOperationResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BooleanOperationResult3D 'DiGi\.Geometry\.Spatial\.Classes\.BooleanOperationResult3D') containing the result of the operation, or null if the operation type is not supported\.

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_)'></a>

## Create\.BoundingBox3D\(Range\<double\>, Range\<double\>, Range\<double\>\) Method

Creates a [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') based on the provided X, Y, and Z ranges\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The `Range<double>` for the X axis\.

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The `Range<double>` for the Y axis\.

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The `Range<double>` for the Z axis\.

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') if all provided ranges are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.BoundingBox3D_)'></a>

## Create\.BoundingBox3D\(this IEnumerable\<BoundingBox3D\>\) Method

Calculates a single [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that encompasses all provided bounding boxes in the collection\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.BoundingBox3D>? boundingBox3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.BoundingBox3D_).boundingBox3Ds'></a>

`boundingBox3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') objects to process\.

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the union of all input bounding boxes, or `null` if the collection is null or contains no valid bounding boxes\.

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_)'></a>

## Create\.BoundingBox3D\(this IEnumerable\<IPolygonalFace3D\>\) Method

Calculates a [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that encompasses all provided polygonal faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.BoundingBox3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of faces to process\.

#### Returns
[BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the bounding box, or `null` if the collection is null or contains no valid bounding boxes\.

<a name='DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double)'></a>

## Create\.DifferenceResult3D\<TPolygonalFace3D\>\(this Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, double\) Method

Calculates the 3D boolean difference between two polyhedra defined by TPolygonalFace3D faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.DifferenceResult3D? DifferenceResult3D<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.DifferenceResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The first polyhedron \(from which to subtract\)\.

<a name='DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.DifferenceResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The second polyhedron \(to subtract\)\.

<a name='DiGi.Geometry.Spatial.Create.DifferenceResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for boolean difference computations\.

#### Returns
[DifferenceResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.DifferenceResult3D 'DiGi\.Geometry\.Spatial\.Classes\.DifferenceResult3D')  
A [DifferenceResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.DifferenceResult3D 'DiGi\.Geometry\.Spatial\.Classes\.DifferenceResult3D') containing the difference geometry \(either a Polyhedron or individual face/segment elements\), or null if polyhedron\_1 is null\.

### Remarks

The boundary of the difference polyhedron `A \ B` is composed of:
- Faces of A that lie outside the volume of B.
- Faces of B that lie inside the volume of A, with their orientations inverted (normals flipped)
              to face outward from the resulting solid difference volume.

If the remaining boundary pieces do not form a closed solid volume (less than 4 faces, or non-closed shell),
the method falls back to returning the individual [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') elements representing the
remaining boundary surfaces.

<a name='DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double)'></a>

## Create\.Ellipsoid\(Point3D, Point3D, double, double, double\) Method

Creates an [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') based on two focal points and two semi\-minor axes\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipsoid? Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D? focalPoint_1, DiGi.Geometry.Spatial.Classes.Point3D? focalPoint_2, double b, double c, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).focalPoint_1'></a>

`focalPoint_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing a focal point of the ellipsoid\.

<a name='DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).focalPoint_2'></a>

`focalPoint_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing a focal point of the ellipsoid\.

<a name='DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing one of the semi\-minor axes\.

<a name='DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).c'></a>

`c` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing another semi\-minor axis\.

<a name='DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance\.

#### Returns
[Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')  
An [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') object if the parameters are valid and a valid ellipsoid can be constructed; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double)'></a>

## Create\.InteriorSideInsideOther\<TPolygonalFace3D\>\(BooleanOperationCandidate, Point3D, BVHNodePointRelationSolver, BVHNodePointRelationSolver, Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, double\) Method

For a candidate fragment lying on the other volume's boundary, determines whether the parent\-volume
interior side of the \(coplanar\) boundary lies inside the other volume\.

The probe is evaluated on both sides of the face plane, so the sign of the face normal is irrelevant -
this avoids the expensive outward-normal orientation ray cast of
[GetNormal\(int, bool, Nullable&lt;Side&gt;, double\)](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.GetNormal(int,bool,System.Nullable_DiGi.Geometry.Core.Enums.Side_,double) 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.GetNormal\(int, bool, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Side\>, double\)') in the common case.
The exact outward normal is only computed as a rare fallback (very thin parent volume or a probe near
a parent edge).

```csharp
private static bool InteriorSideInsideOther<TPolygonalFace3D>(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate booleanOperationCandidate, DiGi.Geometry.Spatial.Classes.Point3D point3D, DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver bVHNodePointRelationSolver_Parent, DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver bVHNodePointRelationSolver_Other, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D> polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D> polyhedron_2, double tolerance)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).booleanOperationCandidate'></a>

`booleanOperationCandidate` [BooleanOperationCandidate](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.BooleanOperationCandidate 'DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate')

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).bVHNodePointRelationSolver_Parent'></a>

`bVHNodePointRelationSolver_Parent` [BVHNodePointRelationSolver](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver 'DiGi\.Geometry\.Spatial\.Classes\.BVHNodePointRelationSolver')

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).bVHNodePointRelationSolver_Other'></a>

`bVHNodePointRelationSolver_Other` [BVHNodePointRelationSolver](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver 'DiGi\.Geometry\.Spatial\.Classes\.BVHNodePointRelationSolver')

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.InteriorSideInsideOther\<TPolygonalFace3D\>\(DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate, DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.BVHNodePointRelationSolver, DiGi\.Geometry\.Spatial\.Classes\.BVHNodePointRelationSolver, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.InteriorSideInsideOther\<TPolygonalFace3D\>\(DiGi\.Geometry\.Spatial\.Create\.BooleanOperationCandidate, DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.BVHNodePointRelationSolver, DiGi\.Geometry\.Spatial\.Classes\.BVHNodePointRelationSolver, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

<a name='DiGi.Geometry.Spatial.Create.InteriorSideInsideOther_TPolygonalFace3D_(DiGi.Geometry.Spatial.Create.BooleanOperationCandidate,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.BVHNodePointRelationSolver,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.IntersectionResult3D\(this BoundingBox3D, Point3D, Vector3D, double\) Method

Calculates the intersection between a 3D bounding box and a ray defined by a point and a direction\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D(this DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_Direction, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to check for intersection\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the starting point of the ray\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_Direction'></a>

`vector3D_Direction` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') representing the direction of the ray\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the intersection calculation\.

#### Returns
[IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') containing the result of the intersection, or null if any of the required parameters are null\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double)'></a>

## Create\.IntersectionResult3D\(this BoundingBox3D, ILinear3D, double\) Method

Calculates the intersection between a [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') and an [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D(this DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, DiGi.Geometry.Spatial.Interfaces.ILinear3D? linear3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).linear3D'></a>

`linear3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance for the intersection calculation\.

#### Returns
[IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') containing the result of the intersection, or `null` if either input is null or the operation fails\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Line3D,double)'></a>

## Create\.IntersectionResult3D\(this Sphere, Line3D, double\) Method

Calculates the intersection between a sphere and a 3D line\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D(this DiGi.Geometry.Spatial.Classes.Sphere? sphere, DiGi.Geometry.Spatial.Classes.Line3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Line3D,double).sphere'></a>

`sphere` [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Line3D,double).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Line3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the intersection calculation\.

#### Returns
[IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') containing the intersection details, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the sphere or line is null\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Create\.IntersectionResult3D\(this Sphere, Segment3D, double\) Method

Calculates the intersection between a [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') and a [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D(this DiGi.Geometry.Spatial.Classes.Sphere? sphere, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Segment3D,double).sphere'></a>

`sphere` [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere')

The [Sphere](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Sphere 'DiGi\.Geometry\.Spatial\.Classes\.Sphere') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Sphere,DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the intersection calculation\.

#### Returns
[IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') containing the result of the intersection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the sphere or segment is null\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double)'></a>

## Create\.IntersectionResult3D\<TPolygonalFace3D\>\(this Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, double\) Method

Calculates the 3D boolean intersection between two polyhedra defined by TPolygonalFace3D faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.IntersectionResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The first polyhedron to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.IntersectionResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The second polyhedron to intersect\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection computations\.

#### Returns
[IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') containing the intersection geometry, or null if either input is null\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double)'></a>

## Create\.IntersectionResult3D\<TPolygonalFace3D\>\(this Polyhedron\<TPolygonalFace3D\>, ILinear3D, double\) Method

Calculates the intersection result between a [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') and an [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron, DiGi.Geometry.Spatial.Interfaces.ILinear3D? linear3D, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.IntersectionResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') to check for intersection\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).linear3D'></a>

`linear3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ilinear3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ILinear3D') object to intersect with the polyhedron\. Supported implementations are [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D'), [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') and [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')\.

<a name='DiGi.Geometry.Spatial.Create.IntersectionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Interfaces.ILinear3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for calculations\.

#### Returns
[IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.IntersectionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D') containing the intersection details, or `null` if either input is null, the linear type is not supported or the bounding box cannot be determined\.

<a name='DiGi.Geometry.Spatial.Create.Matrix(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Create\.Matrix\(this IEnumerable\<Point3D\>\) Method

Creates a [DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix') from the specified collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public static DiGi.Math.Classes.Matrix? Matrix(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Matrix(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to convert\.

#### Returns
[DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix')  
A [DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix') containing the point coordinates, or `null` if [point3Ds](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Matrix(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds 'DiGi\.Geometry\.Spatial\.Create\.Matrix\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Classes\.Point3D\>\)\.point3Ds') is `null`\.

<a name='DiGi.Geometry.Spatial.Create.Matrix(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_)'></a>

## Create\.Matrix\(this IEnumerable\<Vector3D\>\) Method

Creates a [DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix') from a collection of [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)')\.

```csharp
public static DiGi.Math.Classes.Matrix? Matrix(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Vector3D>? vector3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Matrix(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_).vector3Ds'></a>

`vector3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') objects to be converted into a matrix\.

#### Returns
[DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix')  
A [DiGi\.Math\.Classes\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.matrix 'DiGi\.Math\.Classes\.Matrix') containing the vectors as rows, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double)'></a>

## Create\.Mesh3D\(this Ellipsoid, double\) Method

Generates a [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') from the specified [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') using an angle factor to determine the resolution of stacks and slices\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid, double angleFactor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double).ellipsoid'></a>

`ellipsoid` [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') instance to be converted into a mesh\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double).angleFactor'></a>

`angleFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value used to calculate the number of stacks and slices for the resulting mesh\.

#### Returns
[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') object representing the ellipsoid, or `null` if the provided [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') is `null` or the angle factor does not yield a positive angular step\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int)'></a>

## Create\.Mesh3D\(this Ellipsoid, int, int\) Method

Generates a [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') from the specified [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid, int stacks, int slices);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int).ellipsoid'></a>

`ellipsoid` [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') to convert into a mesh\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int).stacks'></a>

`stacks` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of stacks \(latitude divisions\) as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used to generate the mesh\. Must be at least 2\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int).slices'></a>

`slices` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of slices \(longitude divisions\) as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used to generate the mesh\. Must be at least 3\.

#### Returns
[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') representing the ellipsoid, or `null` if the provided [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') is `null`, incomplete, or the resolution values are out of range\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double)'></a>

## Create\.Mesh3D\(this Polyhedron, double\) Method

Converts the specified [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') to a [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') by triangulating its polygonal faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this DiGi.Geometry.Spatial.Classes.Polyhedron? polyhedron, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double).polyhedron'></a>

`polyhedron` [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

The [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') instance to convert\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Classes.Polyhedron,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used during the triangulation of the polygonal faces\.

#### Returns
[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') object representing the triangulated mesh, or `null` if the [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') is null or contains no valid faces\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.Mesh3D\(this IPolygonalFace3D, double\) Method

Converts a polygonal face to a 3D mesh using the specified distance tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to convert\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for triangulation\.

#### Returns
[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') object representing the polygonal face, or `null` if the input is `null`\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Triangle3D_,double)'></a>

## Create\.Mesh3D\(this IEnumerable\<Triangle3D\>, double\) Method

Creates a [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') from a collection of [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Triangle3D>? triangle3Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Triangle3D_,double).triangle3Ds'></a>

`triangle3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the triangles to be converted into a mesh\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Triangle3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for merging coincident points\.

#### Returns
[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') object if the input collection is not null and contains valid triangles; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.Mesh3Ds(thisDiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Create\.Mesh3Ds\(this Mesh3D\) Method

Decomposes the specified mesh into its connected components\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Mesh3D>? Mesh3Ds(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Mesh3Ds(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') to decompose\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instances, each representing a connected component, or `null` if the input is `null` or empty\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, BoundingBox3D, double\) Method

Calculates the planar intersection result between a plane and a 3D bounding box\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect with the bounding box\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to be intersected by the plane\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or null if either the plane or bounding box is null, or if a polyhedron cannot be created from the bounding box\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, Line3D, double\) Method

Calculates the intersection result between a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Line3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or null if the plane or line is null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, Plane, double\) Method

Calculates the intersection result of two planes\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane_1, DiGi.Geometry.Spatial.Classes.Plane? plane_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double).plane_1'></a>

`plane_1` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The first [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double).plane_2'></a>

`plane_2` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The second [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') if an intersection is found; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, Point3D, Point3D, bool, bool, double\) Method

Calculates the intersection result between a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a line segment defined by two [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, bool bounded_1=false, bool bounded_2=false, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect with\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') defining the line segment\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') defining the line segment\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).bounded_1'></a>

`bounded_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the intersection is bounded for the first point\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).bounded_2'></a>

`bounded_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the intersection is bounded for the second point\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for distance calculations\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or `null` if any input parameters are null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, Point3D, double\) Method

Calculates the planar intersection result for a given [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the intersection calculation\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to be checked against the plane\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for determining if the point lies on the plane\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the intersection details, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is null or projection fails\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, Ray3D, double\) Method

Calculates the intersection result between a plane and a 3D ray\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Ray3D? ray3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to be intersected\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') used for the intersection calculation\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the intersection\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') if an intersection is found and inputs are valid; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, Segment3D, double\) Method

Calculates the intersection result between a plane and a 3D segment\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the intersection details, or `null` if either input is null or a result cannot be determined\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, IPolygonalFace3D, double\) Method

Calculates the planar intersection result between a plane and a 3D polygonal face\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to evaluate\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for coplanar and distance checks\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') if the intersection is successfully calculated; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, IPolyhedron, double\) Method

Calculates the planar intersection between a plane and a polyhedron\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolyhedron? polyhedron, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to intersect with the polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') to be intersected by the plane\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection calculations\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or `null` if either input is `null` or the polyhedron contains no faces\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Create\.PlanarIntersectionResult\(this Plane, ISegmentable3D, double\) Method

Calculates the planar intersection result between a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and an [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the intersection calculation\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to be intersected with the plane\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if an intersection occurs\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the intersection data, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') is null, or if no segments are available\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Line3D,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, Line3D, double\) Method

Calculates the planar intersection result between a polygonal face and a line\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Line3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Line3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Line3D,double).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') instance to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Line3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or `null` if either input is null or an intersection cannot be determined\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, Point3D, Point3D, bool, bool, double\) Method

Calculates the planar intersection between a 3D polygonal face and a line segment defined by two points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, bool bounded_1, bool bounded_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to intersect with\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') defining the line segment\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') defining the line segment\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).bounded_1'></a>

`bounded_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the intersection is bounded by the first point\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).bounded_2'></a>

`bounded_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the intersection is bounded by the second point\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for distance calculations\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or `null` if the input parameters are null or an intersection cannot be determined\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, Point3D, double\) Method

Calculates the planar intersection result of a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') relative to an [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to evaluate\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance to check for intersection\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for range checking\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the plane and potentially the projected point, or `null` if either input is null or the face has no associated plane\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Ray3D,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, Ray3D, double\) Method

Calculates the planar intersection result between a polygonal face and a ray\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Ray3D? ray3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Ray3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to intersect\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Ray3D,double).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') instance representing the ray\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Ray3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculations\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the intersection details, or `null` if no intersection is found or if either input is null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, Segment3D, double\) Method

Calculates the planar intersection result between a polygonal face and a segment\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') representing the polygonal face\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') representing the line segment\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or null if the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') or [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') is null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, IPolygonalFace3D, double\) Method

Calculates the planar intersection result between two polygonal faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D_1, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D_1'></a>

`polygonalFace3D_1` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The first [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') face\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).polygonalFace3D_2'></a>

`polygonalFace3D_2` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The second [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') face\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the planar intersection, or `null` if either face is null or their planes are not defined\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, IPolyhedron, double\) Method

Calculates the planar intersection result between a polygonal face and all faces of a polyhedron\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Interfaces.IPolyhedron? polyhedron, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to be intersected\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') whose faces are used for the intersection calculation\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') containing the result of the intersection, or `null` if either the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') or the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') is null\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double)'></a>

## Create\.PlanarIntersectionResult\(this IPolygonalFace3D, IEnumerable\<IPolygonalFace3D\>, double\) Method

Calculates the planar intersection between a reference polygonal face and a collection of other polygonal faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult? PlanarIntersectionResult(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The reference [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') object\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the polygonal faces to intersect with the reference face\.

<a name='DiGi.Geometry.Spatial.Create.PlanarIntersectionResult(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the intersection calculation\.

#### Returns
[PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult')  
A [PlanarIntersectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PlanarIntersectionResult 'DiGi\.Geometry\.Spatial\.Classes\.PlanarIntersectionResult') object if a valid intersection is found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Create.Plane(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Create\.Plane\(Point3D\) Method

Creates a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') based on the World Z axis at the specified origin point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(DiGi.Geometry.Spatial.Classes.Point3D? origin);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Plane(DiGi.Geometry.Spatial.Classes.Point3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the origin of the plane\. If null, the method returns null\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance if a valid [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is provided; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Create\.Plane\(Point3D, Vector3D, Vector3D\) Method

Creates a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') defined by an origin point and two axes\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? axisX, DiGi.Geometry.Spatial.Classes.Vector3D? axisY);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') that defines the origin of the plane\.

<a name='DiGi.Geometry.Spatial.Create.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisX'></a>

`axisX` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') that defines the X\-axis of the plane\.

<a name='DiGi.Geometry.Spatial.Create.Plane(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisY'></a>

`axisY` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') that defines the Y\-axis of the plane\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance if all parameters are non\-null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Plane(double)'></a>

## Create\.Plane\(double\) Method

Creates a plane at the specified elevation along the Z\-axis\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(double elevation);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Plane(double).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the elevation of the plane\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A Plane object positioned at the given elevation, or null if the provided double is NaN\.

<a name='DiGi.Geometry.Spatial.Create.Plane(double,int)'></a>

## Create\.Plane\(double, int\) Method

Creates a plane perpendicular to the specified axis and offsets it by the given value\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(double value, int dimensionIndex);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Plane(double,int).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance of type [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') to move the plane along the axis\.

<a name='DiGi.Geometry.Spatial.Create.Plane(double,int).dimensionIndex'></a>

`dimensionIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of type [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') representing the dimension \(0 for X, 1 for Y, 2 for Z\)\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') object shifted by the value, or null if the [dimensionIndex](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Plane(double,int).dimensionIndex 'DiGi\.Geometry\.Spatial\.Create\.Plane\(double, int\)\.dimensionIndex') is not a valid axis index\.

<a name='DiGi.Geometry.Spatial.Create.Plane(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Create\.Plane\(this Point3D, Point3D, Point3D\) Method

Creates a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') from three specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Plane(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Create.Plane(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Create.Plane(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') if the points are valid and not collinear; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Plane(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Create\.Plane\(this IEnumerable\<Point3D\>, double\) Method

Creates a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') from a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points using the specified tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Plane(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points used to define the plane\.

<a name='DiGi.Geometry.Spatial.Create.Plane(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculating the normal vector\.

#### Returns
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') if a valid plane can be constructed from the provided points; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Planes(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## Create\.Planes\(this BoundingBox3D\) Method

Returns a list of [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') objects that define the boundaries of the specified [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Plane>? Planes(this DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Planes(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') instance from which to extract the planes\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Plane>` containing the boundary planes, or null if the [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') is null or contains invalid bounds\.

<a name='DiGi.Geometry.Spatial.Create.Point3Ds(thisDiGi.Geometry.Spatial.Classes.Segment3D,int)'></a>

## Create\.Point3Ds\(this Segment3D, int\) Method

Generates a list of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points from the specified [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') based on the provided count\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? Point3Ds(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, int count);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Point3Ds(thisDiGi.Geometry.Spatial.Classes.Segment3D,int).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') instance to extract points from\.

<a name='DiGi.Geometry.Spatial.Create.Point3Ds(thisDiGi.Geometry.Spatial.Classes.Segment3D,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points to retrieve\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Point3D>` containing the requested points, or null if the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') is null, the count is negative, or the points cannot be retrieved\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D[])'></a>

## Create\.Polygon3D\(Plane, Point2D\[\]\) Method

Creates a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance based on the provided [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(DiGi.Geometry.Spatial.Classes.Plane? plane, params DiGi.Geometry.Planar.Classes.Point2D?[]? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D[]).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') that defines the surface of the polygon\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D[]).point2Ds'></a>

`point2Ds` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

A variable number of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects representing the vertices of the polygon\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A new [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance if a valid [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') is provided and there are at least three non\-null [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.Polygon3D\(this Segment3D, Vector3D, double\) Method

Creates a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') from a [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') and a [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to use as the base for the polygon\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') used to define the polygon's extent or direction\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for length and similarity comparisons\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') if a valid polygon can be created; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double)'></a>

## Create\.Polygon3D\(this Segment3D, double, double\) Method

Creates a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') from the specified [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') with a given height\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double height, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to be converted into a polygon\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') height of the resulting polygon\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Segment3D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine if the segment is parallel to the Z\-axis\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance, or null if the [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') is null, height is NaN, or the segment direction is parallel to the WorldZ axis within the specified tolerance\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Vector3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Create\.Polygon3D\(this Vector3D, IEnumerable\<Point3D\>\) Method

Creates a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') from the specified normal vector and a collection of 3D points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(this DiGi.Geometry.Spatial.Classes.Vector3D? normal, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Vector3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') representing the normal vector of the plane\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisDiGi.Geometry.Spatial.Classes.Vector3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the vertices to be used for the polygon\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') if a valid polygon can be constructed; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Create\.Polygon3D\(this IEnumerable\<Point3D\>, double\) Method

Creates a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') from a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, double tolerace=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects used to define the polygon\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerace'></a>

`tolerace` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for plane calculation\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') object if a valid polygon can be created; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3D_T_(thisDiGi.Geometry.Spatial.Interfaces.IPlanar_T_)'></a>

## Create\.Polygon3D\<T\>\(this IPlanar\<T\>\) Method

Converts a planar object to a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D<T>(this DiGi.Geometry.Spatial.Interfaces.IPlanar<T>? planar)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D_T_(thisDiGi.Geometry.Spatial.Interfaces.IPlanar_T_).T'></a>

`T`

The type of the 2D polygonal geometry, which must implement [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3D_T_(thisDiGi.Geometry.Spatial.Interfaces.IPlanar_T_).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Polygon3D_T_(thisDiGi.Geometry.Spatial.Interfaces.IPlanar_T_).T 'DiGi\.Geometry\.Spatial\.Create\.Polygon3D\<T\>\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object to convert\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') if the [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object, its geometry, and its plane are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Polygon3Ds(DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## Create\.Polygon3Ds\(BoundingBox3D\) Method

Generates a list of [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') objects from the specified [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polygon3D>? Polygon3Ds(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polygon3Ds(DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') used to create the polygons\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Polygon3D>` containing the generated polygons, or null if the provided [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') or its boundaries are null\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D[])'></a>

## Create\.PolygonalFace3D\(Plane, Point2D\[\]\) Method

Creates a [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') based on the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertices\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane? plane, params DiGi.Geometry.Planar.Classes.Point2D[]? points);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D[]).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the polygonal face is located\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D[]).points'></a>

`points` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An array of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects defining the vertices of the polygon\.

#### Returns
[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') array are not null and contain at least three points; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonal3D_,double)'></a>

## Create\.PolygonalFace3D\(IPolygonal3D, IEnumerable\<IPolygonal3D\>, double\) Method

Creates a [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') based on an external boundary and optional internal boundaries\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? externalEdge, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>? internalEdges=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonal3D_,double).externalEdge'></a>

`externalEdge` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') representing the external edge of the face\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonal3D_,double).internalEdges'></a>

`internalEdges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the internal edges \(holes\) of the face\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonal3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for distance calculations\.

#### Returns
[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') object if the face could be created; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## Create\.PolygonalFace3D\(this IPolygonalFace3D\) Method

Converts an [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to a [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance if the underlying plane is a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and the geometry is an [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to convert\.

#### Returns
[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A new [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance if the conversion is successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D_T_(thisDiGi.Geometry.Spatial.Classes.Planar_T_)'></a>

## Create\.PolygonalFace3D\<T\>\(this Planar\<T\>\) Method

Converts a [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') to a [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D<T>(this DiGi.Geometry.Spatial.Classes.Planar<T>? planar)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D_T_(thisDiGi.Geometry.Spatial.Classes.Planar_T_).T'></a>

`T`

The type of the polygonal 2D geometry, which must implement [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3D_T_(thisDiGi.Geometry.Spatial.Classes.Planar_T_).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Classes\.Planar&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.PolygonalFace3D_T_(thisDiGi.Geometry.Spatial.Classes.Planar_T_).T 'DiGi\.Geometry\.Spatial\.Create\.PolygonalFace3D\<T\>\(this DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>\)\.T')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>')

The [Planar&lt;T&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Planar_T_ 'DiGi\.Geometry\.Spatial\.Classes\.Planar\<T\>') instance to convert\.

#### Returns
[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') if the conversion is successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_)'></a>

## Create\.PolygonalFace3Ds\<TPolygonalFace3D\>\(Polyhedron\<TPolygonalFace3D\>\) Method

Extracts the faces of the given polyhedron without cloning them\.

```csharp
private static System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> PolygonalFace3Ds<TPolygonalFace3D>(DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D> polyhedron)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.PolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.PolygonalFace3Ds_TPolygonalFace3D_(DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.PolygonalFace3Ds\<TPolygonalFace3D\>\(DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The source polyhedron\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the polyhedron faces \(never null; possibly empty\)\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## Create\.Polyhedron\(this BoundingBox3D\) Method

Converts the specified [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') to a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') instance to convert\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') representing the bounding box, or `null` if the provided [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') is `null` or cannot be converted into a valid polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double)'></a>

## Create\.Polyhedron\(this Ellipsoid, double\) Method

Generates a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') from the specified [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') using an angle factor to determine the resolution of stacks and slices\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid, double angleFactor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double).ellipsoid'></a>

`ellipsoid` [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') instance to be converted into a polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,double).angleFactor'></a>

`angleFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value used to calculate the number of stacks and slices for the resulting polyhedron\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') composed of triangular faces representing the ellipsoid, or `null` if the provided [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') is `null` or the angle factor does not yield a positive angular step\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int)'></a>

## Create\.Polyhedron\(this Ellipsoid, int, int\) Method

Generates a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') from the specified [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Classes.Ellipsoid? ellipsoid, int stacks, int slices);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int).ellipsoid'></a>

`ellipsoid` [Ellipsoid](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

The [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') to convert into a polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int).stacks'></a>

`stacks` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of stacks \(latitude divisions\) as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used to generate the polyhedron\. Must be at least 2\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Ellipsoid,int,int).slices'></a>

`slices` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of slices \(longitude divisions\) as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used to generate the polyhedron\. Must be at least 3\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') composed of triangular faces representing the ellipsoid, or `null` if the provided [Ellipsoid\(Point3D, Point3D, double, double, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double,double) 'DiGi\.Geometry\.Spatial\.Create\.Ellipsoid\(DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, double, double\)') is `null`, incomplete, or the resolution values are out of range\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Mesh3D)'></a>

## Create\.Polyhedron\(this Mesh3D\) Method

Converts the specified [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') to a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') by creating a triangular polygonal face for each mesh triangle\.

Faces are built with scalar plane-coordinate arithmetic and adopted directly into the polyhedron without defensive cloning, so the conversion runs without reflection-based copies.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.Mesh3D).mesh3D'></a>

`mesh3D` [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instance to convert\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') composed of triangular faces, or `null` if the [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') is `null`, invalid, or yields fewer than four valid faces\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion,double)'></a>

## Create\.Polyhedron\(this PolygonalFaceExtrusion, double\) Method

Creates a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') from the specified [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion? polygonalFaceExtrusion, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion,double).polygonalFaceExtrusion'></a>

`polygonalFaceExtrusion` [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion')

The [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') to convert into a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the operation\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') if the [PolygonalFaceExtrusion](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFaceExtrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') is not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.Polyhedron\(this IPolygonalFace3D, Vector3D, double\) Method

Creates a [Polyhedron\(this IPolygonalFace3D, Vector3D, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D,double) 'DiGi\.Geometry\.Spatial\.Create\.Polyhedron\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, DiGi\.Geometry\.Spatial\.Classes\.Vector3D, double\)') from the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') and [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') that serves as the base of the polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') defining the direction and magnitude for the polyhedron creation\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for calculations\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') if successfully created; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron)'></a>

## Create\.Polyhedron\(this IPolyhedron\) Method

Converts the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') to a [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.Geometry.Spatial.Interfaces.IPolyhedron polyhedron);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') instance to convert\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') instance if the conversion is successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_)'></a>

## Create\.Polyhedron\(this IEnumerable\<IPolygonalFace3D\>\) Method

Creates a [Polyhedron\(this IPolygonalFace3D, Vector3D, double\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Polyhedron(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Vector3D,double) 'DiGi\.Geometry\.Spatial\.Create\.Polyhedron\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, DiGi\.Geometry\.Spatial\.Classes\.Vector3D, double\)') from the specified collection of polygonal faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Polyhedron(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the polygonal faces to be used for the construction\.

#### Returns
[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A new [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') instance if the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is not null and contains at least four elements; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ellipse3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Ellipse3D, double\) Method

Calculates the projection result of a 3D ellipse onto a plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Ellipse3D? ellipse3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ellipse3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') onto which the ellipse is projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ellipse3D,double).ellipse3D'></a>

`ellipse3D` [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')

The [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ellipse3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine if the plane and the ellipse's plane are parallel\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projected 2D ellipse, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Line3D, double\) Method

Projects a [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Line3D? line3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project the line onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for similarity and intersection calculations\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projection results, or `null` if either input is null or the projection cannot be determined\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Create\.ProjectionResult\(this Plane, Point3D\) Method

Projects a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to create a [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the projection\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to be projected onto the plane\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the result of the projection, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is `null`, or if the conversion to a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') fails\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Polygon3D, double\) Method

Projects a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Polygon3D? polygon3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D,double).polygon3D'></a>

`polygon3D` [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the projection\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the result of the projection, or `null` if the input parameters are null or the resulting geometry is invalid\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D,double)'></a>

## Create\.ProjectionResult\(this Plane, PolygonalFace3D, double\) Method

Calculates the projection result of a 3D polygonal face onto a plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D,double).polygonalFace3D'></a>

`polygonalFace3D` [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the projection\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') if the projection is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Ray3D, double\) Method

Calculates the projection of a 3D ray onto a plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Ray3D? ray3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project the ray onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for similarity and distance calculations\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projection data, or `null` if either the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') is null\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Segment3D, double\) Method

Calculates the projection result of a [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance for similarity calculations\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projection details, or `null` if either the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') is `null`\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Triangle3D, double\) Method

Calculates the projection result of a 3D triangle onto a plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') object to project onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D,double).triangle3D'></a>

`triangle3D` [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') object to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for collinearity checks\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projection data, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null or the resulting points are not valid\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.ProjectionResult\(this Plane, Vector3D, double\) Method

Calculates the projection result of a [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the minimum length threshold for the projection result\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projection details, or `null` if the input parameters are null or the resulting vector length is less than the specified [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double)'></a>

## Create\.ProjectionResult\(this Plane, IGeometry3D, double\) Method

Calculates the projection result of a specified 3D geometry onto a plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') object to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the projection\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the result of the projection, or null if either the plane or geometry is null\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Create\.ProjectionResult\(this Plane, IEnumerable\<Point3D\>\) Method

Projects a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult(this DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to which the points are projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to project\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the projection data, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double)'></a>

## Create\.ProjectionResult\<T\>\(this Plane, IEnumerable\<T\>, double\) Method

Projects a collection of 3D geometry objects onto a plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.ProjectionResult? ProjectionResult<T>(this DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<T>? geometry3Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

The type of 3D geometry, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project the geometries onto\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).geometry3Ds'></a>

`geometry3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Spatial\.Create\.ProjectionResult\<T\>\(this DiGi\.Geometry\.Spatial\.Classes\.Plane, System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of 3D geometry objects to be projected\.

<a name='DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the projection process\.

#### Returns
[ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult')  
A [ProjectionResult](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.ProjectionResult 'DiGi\.Geometry\.Spatial\.Classes\.ProjectionResult') containing the results of the projection, or `null` if the [plane](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).plane 'DiGi\.Geometry\.Spatial\.Create\.ProjectionResult\<T\>\(this DiGi\.Geometry\.Spatial\.Classes\.Plane, System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.plane') or [geometry3Ds](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.ProjectionResult_T_(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_T_,double).geometry3Ds 'DiGi\.Geometry\.Spatial\.Create\.ProjectionResult\<T\>\(this DiGi\.Geometry\.Spatial\.Classes\.Plane, System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.geometry3Ds') is `null`\.

<a name='DiGi.Geometry.Spatial.Create.Segment3Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,bool)'></a>

## Create\.Segment3Ds\(this IEnumerable\<Point3D\>, bool\) Method

Converts a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects into a list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? Segment3Ds(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, bool closed=false);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Segment3Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,bool).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points to process\.

<a name='DiGi.Geometry.Spatial.Create.Segment3Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,bool).closed'></a>

`closed` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the segment list should be closed by connecting the last point back to the first point\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is null\.

<a name='DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double)'></a>

## Create\.UnionResult3D\<TPolygonalFace3D\>\(this Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, double\) Method

Calculates the 3D boolean union between two polyhedra defined by TPolygonalFace3D faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.UnionResult3D? UnionResult3D<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.UnionResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The first polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Create\.UnionResult3D\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The second polyhedron\.

<a name='DiGi.Geometry.Spatial.Create.UnionResult3D_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for boolean union computations\.

#### Returns
[UnionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.UnionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.UnionResult3D')  
A [UnionResult3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.UnionResult3D 'DiGi\.Geometry\.Spatial\.Classes\.UnionResult3D') containing the union geometry \(either a Polyhedron, multiple disjoint Polyhedrons, or individual face/segment elements\), or null if both inputs are null\.

### Remarks

The boundary of the union polyhedron `A U B` is composed of:
- Faces of A that lie outside the volume of B.
- Faces of B that lie outside the volume of A.

If the remaining boundary pieces do not form a closed solid volume (less than 4 faces, or non-closed shell),
the method falls back to returning the individual [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') elements representing the
remaining boundary surfaces.

<a name='DiGi.Geometry.Spatial.Create.UniquePolygonalFace3Ds(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double)'></a>

## Create\.UniquePolygonalFace3Ds\(List\<IPolygonalFace3D\>, double\) Method

Deduplicates coplanar faces with coincident centroids using a spatial hash on the centroid coordinates,
replacing the quadratic all\-pairs comparison with an expected linear\-time pass\. Centroids are computed
once per face instead of once per comparison\.

```csharp
private static System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> UniquePolygonalFace3Ds(System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> polygonalFace3Ds, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.UniquePolygonalFace3Ds(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Spatial.Create.UniquePolygonalFace3Ds(System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool)'></a>

## Create\.Vector3D\(Vector3D, bool\) Method

Creates a copy of the specified [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)'), with an option to normalize the resulting vector\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, bool normalize=false);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The source [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') instance to be copied\.

<a name='DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool).normalize'></a>

`normalize` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the returned vector should be normalized\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') instance if the provided [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') is not null; otherwise, returns null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D'></a>

## Create\.Transform3D Class

```csharp
public static class Create.Transform3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Transform3D
### Methods

<a name='DiGi.Geometry.Spatial.Create.Transform3D.CoordinateSystem3DToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D,DiGi.Geometry.Spatial.Classes.CoordinateSystem3D)'></a>

## Create\.Transform3D\.CoordinateSystem3DToCoordinateSystem3D\(CoordinateSystem3D, CoordinateSystem3D\) Method

Calculates the transformation from one 3D coordinate system to another 3D coordinate system\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? CoordinateSystem3DToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D_From, DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D_To);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.CoordinateSystem3DToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D,DiGi.Geometry.Spatial.Classes.CoordinateSystem3D).coordinateSystem3D_From'></a>

`coordinateSystem3D_From` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The source [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') coordinate system\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.CoordinateSystem3DToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D,DiGi.Geometry.Spatial.Classes.CoordinateSystem3D).coordinateSystem3D_To'></a>

`coordinateSystem3D_To` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The destination [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') coordinate system\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the transformation from the source to the destination, or null if either input is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.CoordinateSystem3DToOrigin(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D)'></a>

## Create\.Transform3D\.CoordinateSystem3DToOrigin\(CoordinateSystem3D\) Method

Converts a [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') to a [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') that transforms the coordinate system to the origin\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? CoordinateSystem3DToOrigin(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.CoordinateSystem3DToOrigin(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D).coordinateSystem3D'></a>

`coordinateSystem3D` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') to convert\. This value can be null\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the transformation to the origin, or null if the provided [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Identity()'></a>

## Create\.Transform3D\.Identity\(\) Method

Creates a new [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the identity transformation\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D Identity();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') instance initialized with an identity matrix\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.MirrorXY()'></a>

## Create\.Transform3D\.MirrorXY\(\) Method

Creates a transformation matrix that mirrors coordinates across the XY plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D MirrorXY();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the mirroring transformation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.MirrorXZ()'></a>

## Create\.Transform3D\.MirrorXZ\(\) Method

Creates a [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') that mirrors coordinates across the XZ plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D MirrorXZ();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the mirroring transformation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.MirrorYZ()'></a>

## Create\.Transform3D\.MirrorYZ\(\) Method

Creates a [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') that mirrors coordinates across the YZ plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D MirrorYZ();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the mirroring transformation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.OriginToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D)'></a>

## Create\.Transform3D\.OriginToCoordinateSystem3D\(CoordinateSystem3D\) Method

Creates a [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') that represents the transformation from the origin to the specified [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? OriginToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D? coordinateSystem3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.OriginToCoordinateSystem3D(DiGi.Geometry.Spatial.Classes.CoordinateSystem3D).coordinateSystem3D'></a>

`coordinateSystem3D` [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D')

The [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') to transform to\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the transformation from the origin to the coordinate system, or null if the provided [CoordinateSystem3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.CoordinateSystem3D 'DiGi\.Geometry\.Spatial\.Classes\.CoordinateSystem3D') is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.OriginToPlane(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## Create\.Transform3D\.OriginToPlane\(Plane\) Method

Calculates the transformation from the origin to the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? OriginToPlane(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.OriginToPlane(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to which the origin is transformed\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the transformation, or null if the provided [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.OriginTranslation(DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Create\.Transform3D\.OriginTranslation\(Point3D\) Method

Creates a transformation matrix that translates the origin to the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? OriginTranslation(DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.OriginTranslation(DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') specifying the translation coordinates\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the translation, or null if the provided [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Plane)'></a>

## Create\.Transform3D\.PlaneToOrigin\(Plane\) Method

Calculates the [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') required to transform a specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to the origin\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Plane? plane);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to be transformed to the origin\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the transformation from the plane to the origin, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Create\.Transform3D\.PlaneToOrigin\(Point3D, Vector3D, Vector3D, Vector3D\) Method

Creates a transformation that maps a plane defined by an origin and three axes to the coordinate system's origin\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? axisX, DiGi.Geometry.Spatial.Classes.Vector3D? axisY, DiGi.Geometry.Spatial.Classes.Vector3D? axisZ);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the origin of the plane\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisX'></a>

`axisX` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') representing the X\-axis of the plane\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisY'></a>

`axisY` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') representing the Y\-axis of the plane\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToOrigin(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisZ'></a>

`axisZ` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') representing the Z\-axis of the plane\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') object if all parameters are provided; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToPlane(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane)'></a>

## Create\.Transform3D\.PlaneToPlane\(Plane, Plane\) Method

Calculates a [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') that transforms coordinates from one [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to another\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? PlaneToPlane(DiGi.Geometry.Spatial.Classes.Plane? plane_From, DiGi.Geometry.Spatial.Classes.Plane? plane_To);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToPlane(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane).plane_From'></a>

`plane_From` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The source [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.PlaneToPlane(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane).plane_To'></a>

`plane_To` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The destination [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the transformation from the source plane to the destination plane, or null if either input plane is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.ProjectionXY()'></a>

## Create\.Transform3D\.ProjectionXY\(\) Method

Creates a transformation matrix that projects coordinates onto the XY plane by setting the Z component to zero\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D ProjectionXY();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the projection onto the XY plane\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.ProjectionXZ()'></a>

## Create\.Transform3D\.ProjectionXZ\(\) Method

Creates a transformation matrix that projects coordinates onto the XZ plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D ProjectionXZ();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the projection onto the XZ plane\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.ProjectionYZ()'></a>

## Create\.Transform3D\.ProjectionYZ\(\) Method

Creates a transformation matrix that projects points onto the YZ plane by removing the X component\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D ProjectionYZ();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the projection onto the YZ plane\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.Transform3D\.Rotation\(Point3D, Vector3D, double\) Method

Rotation Transform around given axis and origin by angle\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? Rotation(DiGi.Geometry.Spatial.Classes.Point3D? origin, DiGi.Geometry.Spatial.Classes.Vector3D? axis, double angle);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

Origin Point

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).axis'></a>

`axis` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Axis

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Create\.Transform3D\.Rotation\(Vector3D, double\) Method

Rotation Transform3D around the axis\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? Rotation(DiGi.Geometry.Spatial.Classes.Vector3D? axis, double angle);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Vector3D,double).axis'></a>

`axis` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

rotation axis Vector3D

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Rotation(DiGi.Geometry.Spatial.Classes.Vector3D,double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle in radians

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
Transform3D

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationX(double)'></a>

## Create\.Transform3D\.RotationX\(double\) Method

Gets Rotation Transform3D around the x\-axis

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D RotationX(double angle);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationX(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle in radians

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
Transform3D

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationY(double)'></a>

## Create\.Transform3D\.RotationY\(double\) Method

Gets Rotation Transform3D around the y\-axis

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D RotationY(double angle);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationY(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle in radians

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
Transform3D

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationYawPitchRoll(double,double,double)'></a>

## Create\.Transform3D\.RotationYawPitchRoll\(double, double, double\) Method

Creates a 3D rotation transformation matrix from Euler/Tait\-Bryan angles \(yaw, pitch, roll\) in radians\.

The rotation sequence applied is Yaw (around Z), then Pitch (around Y), then Roll (around X).

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D RotationYawPitchRoll(double yaw, double pitch, double roll);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationYawPitchRoll(double,double,double).yaw'></a>

`yaw` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rotation angle around the Z\-axis in radians\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationYawPitchRoll(double,double,double).pitch'></a>

`pitch` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rotation angle around the Y\-axis in radians\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationYawPitchRoll(double,double,double).roll'></a>

`roll` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The rotation angle around the X\-axis in radians\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A new [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the combined rotation transform\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationZ(double)'></a>

## Create\.Transform3D\.RotationZ\(double\) Method

Gets Rotation Transform3D around the z\-axis

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D RotationZ(double angle);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.RotationZ(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle in radians

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
Transform3D

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Create\.Transform3D\.Scale\(Point3D, double\) Method

Creates a scaling transformation relative to a specified origin point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? Scale(DiGi.Geometry.Spatial.Classes.Point3D? origin, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(DiGi.Geometry.Spatial.Classes.Point3D,double).origin'></a>

`origin` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the center of the scale operation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(DiGi.Geometry.Spatial.Classes.Point3D,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value used as the scaling factor\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') object that performs the scaling, or null if the origin is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(double)'></a>

## Create\.Transform3D\.Scale\(double\) Method

Creates a uniform scaling transformation matrix using the specified scale factor\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D Scale(double factor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to use as the scale factor for all axes\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A Classes\.Transform3D object representing the uniform scaling transformation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(double,double,double)'></a>

## Create\.Transform3D\.Scale\(double, double, double\) Method

Creates a scaling transformation matrix with specified factors for the X, Y, and Z axes\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D Scale(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor for the X axis as a double\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor for the Y axis as a double\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Scale(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor for the Z axis as a double\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the scaling transformation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.ShearXY(double,double)'></a>

## Create\.Transform3D\.ShearXY\(double, double\) Method

Creates a 3D shearing transformation matrix in the XY plane relative to the Z\-axis\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D ShearXY(double factorX, double factorY);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.ShearXY(double,double).factorX'></a>

`factorX` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The shearing factor along the X\-axis relative to Z\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.ShearXY(double,double).factorY'></a>

`factorY` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The shearing factor along the Y\-axis relative to Z\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A new [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the shearing transform\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Translation(DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Create\.Transform3D\.Translation\(Vector3D\) Method

Creates a translation transformation based on the specified [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D? Translation(DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Translation(DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') that defines the translation offset\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') representing the translation, or null if the provided [Vector3D\(Vector3D, bool\)](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Create.Vector3D(DiGi.Geometry.Spatial.Classes.Vector3D,bool) 'DiGi\.Geometry\.Spatial\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.Vector3D, bool\)') is null\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Translation(double,double,double)'></a>

## Create\.Transform3D\.Translation\(double, double, double\) Method

Creates a translation transformation matrix based on the specified coordinates\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D Translation(double x, double y, double z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Translation(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The translation distance along the X axis as a double\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Translation(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The translation distance along the Y axis as a double\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Translation(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The translation distance along the Z axis as a double\.

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A Classes\.Transform3D representing the translation transformation\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Unset()'></a>

## Create\.Transform3D\.Unset\(\) Method

Creates a [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') with an unset matrix\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D Unset();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
A [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') instance\.

<a name='DiGi.Geometry.Spatial.Create.Transform3D.Zero()'></a>

## Create\.Transform3D\.Zero\(\) Method

Zero Transform3D Diagonal = \(0,0,0,1\)

```csharp
public static DiGi.Geometry.Spatial.Classes.Transform3D Zero();
```

#### Returns
[Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')  
Transform3D

<a name='DiGi.Geometry.Spatial.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Geometry.Spatial.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Point3D_,double,double,double)'></a>

## Modify\.Add\(this List\<Point3D\>, double, double, double\) Method

Adds a new [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to the specified list of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects using the provided coordinates\.

```csharp
public static void Add(this System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, double x, double y, double z);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Point3D_,double,double,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The `List<Point3D?>` to which the point will be added\. If this list is null, no action is taken\.

<a name='DiGi.Geometry.Spatial.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Point3D_,double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the X coordinate of the point\.

<a name='DiGi.Geometry.Spatial.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Point3D_,double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the Y coordinate of the point\.

<a name='DiGi.Geometry.Spatial.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Point3D_,double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the Z coordinate of the point\.

<a name='DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double)'></a>

## Modify\.AddOverlappingFaces\(this List\<IPolygonalFace3D\>, BVHNode\<IPolygonalFace3D\>, BoundingBox3D, double\) Method

Recursively traverses a Bounding Volume Hierarchy \(BVH\) tree starting at [bVHNode](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).bVHNode 'DiGi\.Geometry\.Spatial\.Modify\.AddOverlappingFaces\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, double\)\.bVHNode')
and adds all [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') elements that overlap with [boundingBox3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Modify\.AddOverlappingFaces\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, double\)\.boundingBox3D')
\(within distance [tolerance](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).tolerance 'DiGi\.Geometry\.Spatial\.Modify\.AddOverlappingFaces\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, double\)\.tolerance')\) into the [result](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).result 'DiGi\.Geometry\.Spatial\.Modify\.AddOverlappingFaces\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, double\)\.result') list\.

<b>CSG Reusability:</b> This method serves as the standard performance-culling query for all 3D constructive
            solid geometry (CSG) boolean operations (Intersection, Union, and Difference) between two polyhedra.
            For each face of Polyhedron A, query the BVH tree built for Polyhedron B to cull non-intersecting faces,
            narrowing candidates down from \(O(N \cdot M)\) to \(O(N \log M)\) before computing splits.

```csharp
public static void AddOverlappingFaces(this System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D> result, DiGi.Geometry.Spatial.Classes.BVHNode<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? bVHNode, DiGi.Geometry.Spatial.Classes.BoundingBox3D boundingBox3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The destination [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') where overlapping faces will be collected\.

<a name='DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).bVHNode'></a>

`bVHNode` [DiGi\.Geometry\.Spatial\.Classes\.BVHNode&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BVHNode_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.BVHNode\<TPolygonalFace3D\>')

The root or subtree node of the Bounding Volume Hierarchy \(BVH\) to traverse\.

<a name='DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).boundingBox3D'></a>

`boundingBox3D` [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The target [BoundingBox3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.BoundingBox3D 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the search query bounds\.

<a name='DiGi.Geometry.Spatial.Modify.AddOverlappingFaces(thisSystem.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BVHNode_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.BoundingBox3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for coordinate comparison and bounding box overlap checks\.

<a name='DiGi.Geometry.Spatial.Modify.Orient(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,DiGi.Geometry.Core.Enums.Orientation,bool)'></a>

## Modify\.Orient\(this IPolygonal3D, Orientation, bool\) Method

Orients the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') to a target orientation, inverting it if necessary\.

```csharp
public static bool Orient(this DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D, DiGi.Geometry.Core.Enums.Orientation orientation, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Modify.Orient(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,DiGi.Geometry.Core.Enums.Orientation,bool).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') instance to orient\.

<a name='DiGi.Geometry.Spatial.Modify.Orient(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,DiGi.Geometry.Core.Enums.Orientation,bool).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The target [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to achieve\.

<a name='DiGi.Geometry.Spatial.Modify.Orient(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,DiGi.Geometry.Core.Enums.Orientation,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the convex hull should be used to determine the current orientation\. Defaults to true\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the orientation of the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') was changed\.

<a name='DiGi.Geometry.Spatial.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.Above\(this Plane, Point3D, double\) Method

Determines whether a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is located above a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static bool Above(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check against\.

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is above the plane beyond the specified tolerance; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double)'></a>

## Query\.Above\(this Plane, IPolygonal3D, double\) Method

Determines whether the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') is above the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static bool Above(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check against\.

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Above(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether all points of the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') are above the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') within the specified [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.AlmostEquals\(this Point3D, Point3D, double\) Method

Determines whether two `Point3D?` points are approximately equal based on a specified distance tolerance\.

```csharp
public static bool AlmostEquals(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` point to compare\.

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point to compare\.

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine equality\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two points are approximately equal\.

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Query\.AlmostEquals\(this ISegmentable3D, ISegmentable3D, double\) Method

Determines whether two [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') objects are almost equal based on a specified tolerance\.

```csharp
public static bool AlmostEquals(this DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D_1, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D_1'></a>

`segmentable3D_1` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The first [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to compare\.

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D_2'></a>

`segmentable3D_2` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The second [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to compare\.

<a name='DiGi.Geometry.Spatial.Query.AlmostEquals(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two objects are almost equal\.

<a name='DiGi.Geometry.Spatial.Query.Average(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Query\.Average\(this IEnumerable\<Point3D\>\) Method

Calculates the average of a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Average(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Average(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to be averaged\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the average position, or `null` if the input collection is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.Average(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_)'></a>

## Query\.Average\(this IEnumerable\<Vector3D\>\) Method

Calculates the average of a sequence of [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Average(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Vector3D>? vector3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Average(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_).vector3Ds'></a>

`vector3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of vectors to average\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the average value, or `null` if the input sequence is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.AxisX(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.AxisX\(this Vector3D\) Method

Calculates an X\-axis vector perpendicular to the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') normal\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? AxisX(this DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.AxisX(thisDiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') normal vector used as a reference\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the calculated X\-axis, or null if the provided [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') normal is null\.

<a name='DiGi.Geometry.Spatial.Query.AxisX(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.AxisX\(this Vector3D, Vector3D\) Method

Calculates the X\-axis vector based on a normal vector and a Y\-axis vector\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? AxisX(this DiGi.Geometry.Spatial.Classes.Vector3D? normal, DiGi.Geometry.Spatial.Classes.Vector3D? axisY);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.AxisX(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The `Vector3D?` normal vector\.

<a name='DiGi.Geometry.Spatial.Query.AxisX(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisY'></a>

`axisY` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The `Vector3D?` Y\-axis vector\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A `Vector3D?` representing the unit X\-axis vector, or null if either the normal or axisY is null\.

<a name='DiGi.Geometry.Spatial.Query.AxisY(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.AxisY\(this Vector3D\) Method

Calculates the Y\-axis vector based on the provided normal vector\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? AxisY(this DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.AxisY(thisDiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The `Vector3D?` normal vector used as a basis for calculating the Y\-axis\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A `Vector3D?` representing the Y\-axis, or null if the provided normal is null\.

<a name='DiGi.Geometry.Spatial.Query.AxisY(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.AxisY\(this Vector3D, Vector3D\) Method

Calculates the Y\-axis vector by computing the cross product of the normal and the X\-axis, then normalizing the result\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? AxisY(this DiGi.Geometry.Spatial.Classes.Vector3D? normal, DiGi.Geometry.Spatial.Classes.Vector3D? axisX);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.AxisY(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normal vector\.

<a name='DiGi.Geometry.Spatial.Query.AxisY(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisX'></a>

`axisX` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the X\-axis vector\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normalized Y\-axis if both inputs are non\-null and a valid unit vector can be derived; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Centroid(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Query\.Centroid\(this IEnumerable\<Point3D\>\) Method

Calculates the centroid of a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Centroid(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Centroid(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An `IEnumerable<Point3D>` containing the points to process\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')? representing the centroid, or null if the input collection is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool)'></a>

## Query\.ClosestPoint\(this Point3D, Point3D, Point3D, bool\) Method

Calculates the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on a line defined by two points relative to a given point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, bool bounded);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The target `Point3D?` for which the closest point is calculated\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` defining the line\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` defining the line\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool).bounded'></a>

`bounded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the result should be bounded to the segment between the two points\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest `Point3D?` on the line, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if any of the input points are [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool)'></a>

## Query\.ClosestPoint\(this Point3D, Point3D, Point3D, bool, bool\) Method

Calculates the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on a line or line segment defined by two points to a given target point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, bool bounded_1, bool bounded_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The target [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is calculated\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` defining the line or segment\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') defining the line or segment\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool).bounded_1'></a>

`bounded_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the result is bounded by the first point\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,bool).bounded_2'></a>

`bounded_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A bool indicating whether the result is bounded by the second point\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the line or segment, or null if any of the input points are null\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D)'></a>

## Query\.ClosestPoint\(this Point3D, ISegmentable3D\) Method

Calculates the closest point on an [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to a given [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D segmentable3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') for which the closest point is being calculated\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to find the closest point on\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found on the segmentable object, or null if no such point exists\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Query\.ClosestPoint\(this Point3D, ISegmentable3D, double\) Method

Calculates the closest point on an [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object from a given [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to find the closest point from\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object containing segments to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the distance between the source [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and the closest point found; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the segments of the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no point could be determined\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Query\.ClosestPoint\(this Point3D, IEnumerable\<Point3D\>, double\) Method

Finds the closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') in a collection of points to a specified source point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') used as the reference for distance calculations\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to search through\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the minimum [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance between the source point and the closest point found; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') from the collection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the source point is null, the collection is null, or no points are available\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_)'></a>

## Query\.ClosestPoint\(this Point3D, IEnumerable\<Segment3D\>\) Method

Calculates the closest point among a collection of 3D segments to a given 3D point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Segment3D>? segment3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') source point\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_).segment3Ds'></a>

`segment3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects to evaluate\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found on the segments, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the source point or the collection is null\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_,double)'></a>

## Query\.ClosestPoint\(this Point3D, IEnumerable\<Segment3D\>, double\) Method

Calculates the closest point on a collection of 3D segments relative to a given 3D point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Segment3D>? segment3Ds, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_,double).segment3Ds'></a>

`segment3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segments to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Segment3D_,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the distance between the source [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and the closest point found; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found among the provided segments, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no point is found or input parameters are null\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_)'></a>

## Query\.ClosestPoint\<TPolygonalFace3D\>\(this Point3D, IEnumerable\<TPolygonalFace3D\>\) Method

Calculates the closest point on a collection of polygonal faces to a given point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, System.Collections.Generic.IEnumerable<TPolygonalFace3D> polygonalFace3Ds)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of the polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source `Point3D?` point\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.ClosestPoint\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Point3D, System\.Collections\.Generic\.IEnumerable\<TPolygonalFace3D\>\)\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of polygonal faces to evaluate\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest `Point3D?` found on the provided polygonal faces, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input point or collection is null\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double)'></a>

## Query\.ClosestPoint\<TPolygonalFace3D\>\(this Point3D, IEnumerable\<TPolygonalFace3D\>, TPolygonalFace3D, double, double\) Method

Calculates the closest point to a given point from a collection of polygonal faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, System.Collections.Generic.IEnumerable<TPolygonalFace3D> polygonalFace3Ds, out TPolygonalFace3D? closestPolygonalFace3D, out double distance, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of the polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source `Point3D?` from which to find the closest point\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.ClosestPoint\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Point3D, System\.Collections\.Generic\.IEnumerable\<TPolygonalFace3D\>, TPolygonalFace3D, double, double\)\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of polygonal faces to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).closestPolygonalFace3D'></a>

`closestPolygonalFace3D` [TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.ClosestPoint\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Point3D, System\.Collections\.Generic\.IEnumerable\<TPolygonalFace3D\>, TPolygonalFace3D, double, double\)\.TPolygonalFace3D')

When this method returns, contains the `TPolygonalFace3D?` that is closest to the source point\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance between the source point and the closest point found\.

<a name='DiGi.Geometry.Spatial.Query.ClosestPoint_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_TPolygonalFace3D_,TPolygonalFace3D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for calculations\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest `Point3D?` found among all provided polygonal faces, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no closest point is found or the input point or collection is null\.

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.Collinear\(this Point3D, Point3D, Point3D, double\) Method

Determines whether three 3D points are collinear within a specified angular tolerance\.

```csharp
public static bool Collinear(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')? point\.

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')? point, acting as the vertex for the angle calculation\.

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')? point\.

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the angular tolerance used to determine collinearity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the points are collinear; returns `false` if any of the provided points are null\.

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Query\.Collinear\(this IEnumerable\<Point3D\>, double\) Method

Determines whether a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points are collinear within a specified tolerance\.

```csharp
public static bool Collinear(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Collinear(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for collinearity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the points are collinear\. Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if there are fewer than three points; otherwise, returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the collection is null or the points are not collinear\.

<a name='DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Query\.Convert\(Plane, BoundingBox2D\) Method

Converts a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') into a [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Rectangle3D? Convert(DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.BoundingBox2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to use for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to use for the conversion\.

#### Returns
[Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')  
A [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') if both parameters are valid; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Interfaces.IPlanar)'></a>

## Query\.Convert\(IPlanar\) Method

Converts an [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar') object to an [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IGeometry2D? Convert(DiGi.Geometry.Spatial.Interfaces.IPlanar? planar);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(DiGi.Geometry.Spatial.Interfaces.IPlanar).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar') instance to convert\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')  
An [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') representation if the conversion is successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ellipse2D)'></a>

## Query\.Convert\(this Plane, Ellipse2D\) Method

Converts a [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') to an [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipse3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ellipse2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ellipse2D).ellipse2D'></a>

`ellipse2D` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') to convert\.

#### Returns
[Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D')  
An [Ellipse3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ellipse3D 'DiGi\.Geometry\.Spatial\.Classes\.Ellipse3D') if both the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Line2D)'></a>

## Query\.Convert\(this Plane, Line2D\) Method

Converts a [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') to a [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Line3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Line2D? line2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Line2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Line2D).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') instance to convert\.

#### Returns
[Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')  
A [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') representing the converted line, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') is `null`, or if conversion of the origin or direction fails\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Convert\(this Plane, Point2D\) Method

Converts a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') based on the coordinate system of the provided [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the reference for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to convert\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the 2D point in 3D space, or null if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane'), the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D'), or the plane's axes are null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polygon2D)'></a>

## Query\.Convert\(this Plane, Polygon2D\) Method

Converts a [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') to a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polygon2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polygon2D).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance to convert\.

#### Returns
[Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance if both the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Query\.Convert\(this Plane, PolygonalFace2D\) Method

Converts a [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') to a [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.PolygonalFace2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance to convert\.

#### Returns
[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance if both the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polyline2D)'></a>

## Query\.Convert\(this Plane, Polyline2D\) Method

Converts a [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') to a [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyline3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Polyline2D? polyline2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polyline2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Polyline2D).polyline2D'></a>

`polyline2D` [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')

The [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') to convert\.

#### Returns
[Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')  
A [Polyline3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyline3D 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') resulting from the conversion, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') is null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ray2D)'></a>

## Query\.Convert\(this Plane, Ray2D\) Method

Converts a [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') to a [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ray3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Ray2D? ray2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ray2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Ray2D).ray2D'></a>

`ray2D` [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')

The [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') to convert\.

#### Returns
[Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')  
A [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Rectangle2D)'></a>

## Query\.Convert\(this Plane, Rectangle2D\) Method

Converts a [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') to a [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Rectangle3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Rectangle2D rectangle2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Rectangle2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Rectangle2D).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') to convert\.

#### Returns
[Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')  
A [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') if both parameters are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Query\.Convert\(this Plane, Segment2D\) Method

Converts a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to a [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Segment3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Segment2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to convert\.

#### Returns
[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')  
A [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Triangle2D)'></a>

## Query\.Convert\(this Plane, Triangle2D\) Method

Converts a [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') to a [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Triangle3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Triangle2D? triangle2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Triangle2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Triangle2D).triangle2D'></a>

`triangle2D` [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')

The [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') to convert\.

#### Returns
[Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')  
A [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Query\.Convert\(this Plane, Vector2D\) Method

Converts a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') to a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') based on the coordinate system of the provided [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Classes.Vector2D? vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Vector2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the reference for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') to convert\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the converted vector, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane'), the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D'), or any of the plane's axes are `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## Query\.Convert\(this Plane, IGeometry2D\) Method

Converts a 2D geometry object to a 3D geometry object based on the specified plane\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.IGeometry3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the reference for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') instance to be converted\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')  
An [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') object if the conversion is successful; otherwise, `null` if either the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') is `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.Convert\(this Plane, IPolygonal2D\) Method

Converts a 2D polygonal object to a 3D polygonal object based on the specified plane\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the reference for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object to be converted\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')  
An [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') representation of the 2D polygonal shape, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Query\.Convert\(this Plane, IPolygonalFace2D\) Method

Converts a 2D polygonal face to a 3D polygonal face using the specified plane\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace3D'></a>

`polygonalFace3D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')  
An [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') if the conversion is successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D)'></a>

## Query\.Convert\(this Plane, Line3D\) Method

Converts a [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to a [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') relative to the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Line2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Line3D? line3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Line3D).line3D'></a>

`line3D` [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')

The [Line3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Line3D 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') to convert\.

#### Returns
[Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')  
A [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') representing the converted line, or null if the plane, the line, or any of its components cannot be converted\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Convert\(this Plane, Point3D\) Method

Converts a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') relative to the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the reference for conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to be converted\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the point's coordinates on the plane, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane'), the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D'), or any required plane components are null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D)'></a>

## Query\.Convert\(this Plane, Polygon3D\) Method

Converts a [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') to a [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Polygon3D? polygon3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used to project the 3D polygon into 2D space\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Polygon3D).polygon3D'></a>

`polygon3D` [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The [Polygon3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polygon3D 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') object to convert\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') representing the converted polygon, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the plane, the 3D polygon, or its points are null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## Query\.Convert\(this Plane, PolygonalFace3D\) Method

Converts a [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') to a [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The [PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') to convert\.

#### Returns
[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D)'></a>

## Query\.Convert\(this Plane, Ray3D\) Method

Converts a [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to a [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') relative to the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Ray2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Ray3D? ray3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Ray3D).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') to convert\.

#### Returns
[Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')  
A [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Rectangle3D,double)'></a>

## Query\.Convert\(this Plane, Rectangle3D, double\) Method

Converts a [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') to an [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') relative to the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Rectangle3D? rectangle3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Rectangle3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Rectangle3D,double).rectangle3D'></a>

`rectangle3D` [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D')

The [Rectangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Rectangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Rectangle3D') to convert\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Rectangle3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
An [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D)'></a>

## Query\.Convert\(this Plane, Segment3D\) Method

Converts a [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to convert\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') if the conversion is successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Query\.Convert\(this Plane, Triangle3D\) Method

Converts a [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') to a [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') using the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Triangle2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') to convert\.

#### Returns
[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')  
A [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') representing the projected triangle, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane'), the [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D'), or any of its points are null or cannot be converted\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Convert\(this Plane, Vector3D\) Method

Converts a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') based on the coordinate system of the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the reference for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to be converted\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the projection of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') onto the plane's axes, or `null` if the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane'), [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D'), or any of the plane's axes are null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double)'></a>

## Query\.Convert\(this Plane, IPolygonal3D, double\) Method

Converts a 3D polygonal object to a 2D polygonal object based on a specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') and tolerance\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the projection\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') object to be converted\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonal3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used during conversion\.

#### Returns
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
An [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') representation of the 3D polygon on the plane, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') or the [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') is null\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## Query\.Convert\(this Plane, IPolygonalFace3D\) Method

Converts a 3D polygonal face to a 2D polygonal face using the specified plane\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? Convert(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used for the conversion\.

<a name='DiGi.Geometry.Spatial.Query.Convert(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to be converted\.

#### Returns
[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')  
An [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Query.Convert_TGeometry3D_(DiGi.Geometry.Spatial.Interfaces.IGeometry3D)'></a>

## Query\.Convert\<TGeometry3D\>\(IGeometry3D\) Method

Converts a given [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') instance into a list of [TGeometry3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Convert_TGeometry3D_(DiGi.Geometry.Spatial.Interfaces.IGeometry3D).TGeometry3D 'DiGi\.Geometry\.Spatial\.Query\.Convert\<TGeometry3D\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D\)\.TGeometry3D') instances\.

```csharp
public static System.Collections.Generic.List<TGeometry3D>? Convert<TGeometry3D>(DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D)
    where TGeometry3D : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.Convert_TGeometry3D_(DiGi.Geometry.Spatial.Interfaces.IGeometry3D).TGeometry3D'></a>

`TGeometry3D`

The target type that implements the [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') interface\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Convert_TGeometry3D_(DiGi.Geometry.Spatial.Interfaces.IGeometry3D).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The source [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') object to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TGeometry3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Convert_TGeometry3D_(DiGi.Geometry.Spatial.Interfaces.IGeometry3D).TGeometry3D 'DiGi\.Geometry\.Spatial\.Query\.Convert\<TGeometry3D\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D\)\.TGeometry3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted geometry, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') is null\.

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisDiGi.Geometry.Spatial.Interfaces.IPlanar,DiGi.Geometry.Spatial.Interfaces.IPlanar,double)'></a>

## Query\.Coplanar\(this IPlanar, IPlanar, double\) Method

Determines whether two [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar') objects are coplanar within a specified tolerance\.

```csharp
public static bool Coplanar(this DiGi.Geometry.Spatial.Interfaces.IPlanar? planar_1, DiGi.Geometry.Spatial.Interfaces.IPlanar? planar_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisDiGi.Geometry.Spatial.Interfaces.IPlanar,DiGi.Geometry.Spatial.Interfaces.IPlanar,double).planar_1'></a>

`planar_1` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar')

The first [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisDiGi.Geometry.Spatial.Interfaces.IPlanar,DiGi.Geometry.Spatial.Interfaces.IPlanar,double).planar_2'></a>

`planar_2` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar')

The second [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisDiGi.Geometry.Spatial.Interfaces.IPlanar,DiGi.Geometry.Spatial.Interfaces.IPlanar,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for coplanarity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two objects are coplanar\.

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Query\.Coplanar\(this IEnumerable\<Point3D\>, double\) Method

Determines whether a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points are coplanar within a specified tolerance\.

```csharp
public static bool Coplanar(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of points to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Coplanar(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the points lie on the same plane\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the points are coplanar; returns `false` if the collection is null\.

<a name='DiGi.Geometry.Spatial.Query.Decompose(thisDiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Decompose\(this Transform3D, Vector3D, Transform3D, Vector3D\) Method

Decomposes an affine 3D transformation matrix into its translation vector, pure rotation matrix, and scale factors\.

```csharp
public static bool Decompose(this DiGi.Geometry.Spatial.Classes.Transform3D? transform3D, out DiGi.Geometry.Spatial.Classes.Vector3D? translation, out DiGi.Geometry.Spatial.Classes.Transform3D? rotation, out DiGi.Geometry.Spatial.Classes.Vector3D? scale);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Decompose(thisDiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D).transform3D'></a>

`transform3D` [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')

The source [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') matrix to decompose\.

<a name='DiGi.Geometry.Spatial.Query.Decompose(thisDiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D).translation'></a>

`translation` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

When this method returns, contains the extracted translation [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D'), or null if decomposition fails\.

<a name='DiGi.Geometry.Spatial.Query.Decompose(thisDiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D).rotation'></a>

`rotation` [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D')

When this method returns, contains the extracted pure rotation [Transform3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Transform3D 'DiGi\.Geometry\.Spatial\.Classes\.Transform3D') matrix, or null if decomposition fails\.

<a name='DiGi.Geometry.Spatial.Query.Decompose(thisDiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Transform3D,DiGi.Geometry.Spatial.Classes.Vector3D).scale'></a>

`scale` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

When this method returns, contains the extracted scale factors as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D'), or null if decomposition fails\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the matrix was successfully decomposed\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Determinant\(this Point3D, Point3D, Point3D, Vector3D\) Method

Calculates the determinant of a 3x3 matrix formed by three [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points and a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') normal vector\.

```csharp
public static double Determinant(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3, DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') normal vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') determinant, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if any of the provided parameters are null\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Determinant\(this Vector3D, Vector3D, Vector3D\) Method

Calculates the determinant of a 3x3 matrix formed by three [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vectors\.

```csharp
public static double Determinant(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

<a name='DiGi.Geometry.Spatial.Query.Determinant(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The third [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the determinant, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if any of the input vectors are null\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.ExtremePoints\(this IEnumerable\<Point3D\>, Point3D, Point3D\) Method

Calculates the two extreme points from a collection of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static void ExtremePoints(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, out DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, out DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

When this method returns, contains the first extreme [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

When this method returns, contains the second extreme [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.ExtremePoints\(this IEnumerable\<Point3D\>, Point3D, Point3D, double\) Method

Finds the two points within a collection that are furthest apart and calculates the distance between them\.

```csharp
public static void ExtremePoints(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, out DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, out DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<Point3D?>` of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

When this method returns, contains the first point of the pair with the maximum distance, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the collection is null or contains fewer than two points\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

When this method returns, contains the second point of the pair with the maximum distance, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the collection is null or contains fewer than two points\.

<a name='DiGi.Geometry.Spatial.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance between the two extreme points, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the collection is null or contains fewer than two points\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.InRange\<T\>\(IPlanar\<T\>, Point3D, double\) Method

Determines whether a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within the range of the provided [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') geometry, considering a given tolerance\.

```csharp
public static bool InRange<T>(DiGi.Geometry.Spatial.Interfaces.IPlanar<T> planar, DiGi.Geometry.Spatial.Classes.Point3D point3D, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).T'></a>

`T`

The type of polygonal geometry, which must implement [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).T 'DiGi\.Geometry\.Spatial\.Query\.InRange\<T\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object to check against\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is within range; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Query\.InRange\<T\>\(IPlanar\<T\>, ISegmentable3D, double\) Method

Determines whether a segmentable 3D entity is within the range of a planar entity\.

```csharp
public static bool InRange<T>(DiGi.Geometry.Spatial.Interfaces.IPlanar<T> planar, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D segmentable3D, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).T'></a>

`T`

The type that implements [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).T 'DiGi\.Geometry\.Spatial\.Query\.InRange\<T\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>, DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object to check against\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the segmentable 3D entity is within range; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Query\.InRange\<T\>\(IPlanar\<T\>, IEnumerable\<Point3D\>, double\) Method

Determines whether a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects are within the range of the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object\.

```csharp
public static bool InRange<T>(DiGi.Geometry.Spatial.Interfaces.IPlanar<T>? planar, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).T'></a>

`T`

The type of polygonal geometry, which must implement [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).T 'DiGi\.Geometry\.Spatial\.Query\.InRange\<T\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Classes\.Point3D\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object to check against\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.InRange_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the points are within range; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.Inside\(this Point3D, Point3D, Point3D, Point3D, double\) Method

Determines whether a point is located inside the triangle formed by three points within a given tolerance\.

```csharp
public static bool Inside(this DiGi.Geometry.Spatial.Classes.Point3D? point3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point to check\.

<a name='DiGi.Geometry.Spatial.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first vertex of the triangle\.

<a name='DiGi.Geometry.Spatial.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second vertex of the triangle\.

<a name='DiGi.Geometry.Spatial.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third vertex of the triangle\.

<a name='DiGi.Geometry.Spatial.Query.Inside(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies inside or on the boundary of the triangle; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.Inside\<T\>\(IPlanar\<T\>, Point3D, double\) Method

Determines whether a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the given [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object within a certain tolerance\.

```csharp
public static bool Inside<T>(DiGi.Geometry.Spatial.Interfaces.IPlanar<T>? planar, DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).T'></a>

`T`

The type of the polygonal 2D object, which must implement [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).T 'DiGi\.Geometry\.Spatial\.Query\.Inside\<T\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object to check against\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is inside the [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object; otherwise, false if either parameter is null\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Query\.Inside\<T\>\(IPlanar\<T\>, ISegmentable3D, double\) Method

Determines whether a specified [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is located inside a specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') planar region within a given tolerance\.

```csharp
public static bool Inside<T>(DiGi.Geometry.Spatial.Interfaces.IPlanar<T>? planar, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).T'></a>

`T`

A type that implements [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).T 'DiGi\.Geometry\.Spatial\.Query\.Inside\<T\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>, DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') planar region to check against\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object is inside the planar region; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Query\.Inside\<T\>\(IPlanar\<T\>, IEnumerable\<Point3D\>, double\) Method

Determines whether a collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points are located on the plane of the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object within a given tolerance\.

```csharp
public static bool Inside<T>(DiGi.Geometry.Spatial.Interfaces.IPlanar<T>? planar, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).T'></a>

`T`

A type that implements [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).planar'></a>

`planar` [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).T 'DiGi\.Geometry\.Spatial\.Query\.Inside\<T\>\(DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\<T\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Classes\.Point3D\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.iplanar-1 'DiGi\.Geometry\.Spatial\.Interfaces\.IPlanar\`1') object whose plane is being evaluated\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points to check\.

<a name='DiGi.Geometry.Spatial.Query.Inside_T_(DiGi.Geometry.Spatial.Interfaces.IPlanar_T_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if all provided points are on the plane within the specified tolerance; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Query\.Intersect\(double, double, double, double, double, double, Triangle3D\) Method

Determines whether the specified [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') overlaps an axis\-aligned box given by its center and per\-axis half\-extents, using the Akenine\-Möller separating\-axis theorem \(thirteen candidate axes: three box face normals, one triangle face normal, and nine edge cross products\)\.

All arithmetic is performed on scalar doubles in the box's local frame, allocating nothing. A degenerate triangle whose normal is zero degrades gracefully to the box-axis and edge tests.

```csharp
public static bool Intersect(double centerX, double centerY, double centerZ, double halfX, double halfY, double halfZ, DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).centerX'></a>

`centerX` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the box center\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).centerY'></a>

`centerY` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the box center\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).centerZ'></a>

`centerZ` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z\-coordinate of the box center\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).halfX'></a>

`halfX` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The half\-extent of the box along the X axis, already expanded by any tolerance\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).halfY'></a>

`halfY` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The half\-extent of the box along the Y axis, already expanded by any tolerance\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).halfZ'></a>

`halfZ` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The half\-extent of the box along the Z axis, already expanded by any tolerance\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(double,double,double,double,double,double,DiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The [Triangle3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Triangle3D 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') to test for overlap\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` when no separating axis exists \(the triangle overlaps the box\); otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double,bool,bool)'></a>

## Query\.Intersect\(this IPolygonalFace3D, Segment3D, double, bool, bool\) Method

Determines whether a specified [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') intersects the given [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') object within a certain tolerance\.

```csharp
public static bool Intersect(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06, bool includeStart=false, bool includeEnd=false);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Intersect(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double,bool,bool).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') to check against\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double,bool,bool).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segment to check\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double,bool,bool).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, includes intersection at the start point of the segment\.

<a name='DiGi.Geometry.Spatial.Query.Intersect(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Spatial.Classes.Segment3D,double,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, includes intersection at the end point of the segment\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the segment intersects the face; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.IntersectionPoint\(Point3D, Point3D, Point3D, Point3D, double\) Method

Calculates the intersection point of two lines defined by their start and end points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D? point3D_1_Start, DiGi.Geometry.Spatial.Classes.Point3D? point3D_1_End, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2_Start, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2_End, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1_Start'></a>

`point3D_1_Start` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The starting [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') of the first line\.

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1_End'></a>

`point3D_1_End` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The ending [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') of the first line\.

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2_Start'></a>

`point3D_2_Start` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The starting [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') of the second line\.

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2_End'></a>

`point3D_2_End` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The ending [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') of the second line\.

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine if an intersection exists\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the intersection point, or `null` if no intersection is found within the specified tolerance\.

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double)'></a>

## Query\.IntersectionPoint\(this Point3D, Vector3D, Point3D, Vector3D, bool, double\) Method

Intersection of tw lines represented by vector3D \(direction\) and Point3D \(origin\)\. Source: https://github\.com/arakis/Net3dBool/blob/39354914eba2f9d34aedd2a16a6528d50e19beec/src/Net3dBool/Line\.cs\#L46

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? IntersectionPoint(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, bool bounded, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

Origin point3D of first line

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Direction Vector3D of first line

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

Origin point3D of second line

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Direction Vector3D of second line

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double).bounded'></a>

`bounded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Bounded means the intersection is limited to the line segments

<a name='DiGi.Geometry.Spatial.Query.IntersectionPoint(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,double)'></a>

## Query\.IsClosed\<TPolygonalFace3D\>\(this Polyhedron\<TPolygonalFace3D\>, bool, double\) Method

Determines whether the specified [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') is fully closed within the given distance tolerance\.

Face vertices are welded into shared indices using a tolerance-sized spatial hash, and each resulting edge is counted. Edges collapsing onto a single welded vertex are ignored.

Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') for a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') polyhedron, for fewer than four faces (the minimum for a closed solid), and for any structurally malformed face - a face with no plane, no 2D geometry, no edges, a ring holding fewer than three points, or a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') point within a ring. A face that cannot be read in full is never treated as contributing no edges, because that would let a broken face pass as closed.

Known limitations. Winding is not checked: two faces sharing an edge in the same direction are accepted, whereas a consistently oriented solid traverses a shared edge in opposite directions - use [Orient\(Nullable&lt;Orientation&gt;, Nullable&lt;Orientation&gt;\)](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_) 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>\.Orient\(System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>, System\.Nullable\<DiGi\.Geometry\.Core\.Enums\.Orientation\>\)') for that. T-junctions report open: when one face's long edge is met by two shorter faces whose shared vertex lies mid-span, no vertex pair matches. Welding is not transitive, so a chain of vertices each within tolerance of the next can weld together even though the chain spans more than the tolerance.

```csharp
public static bool IsClosed<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron, bool manifold, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of the polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.IsClosed\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,double).manifold'></a>

`manifold` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), every edge must be used exactly twice \(a strict 2\-manifold surface\), so an edge shared by three or more faces is rejected\. When [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), every edge must be used an even number of times, which accepts an edge shared by four faces\.

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to weld coincident vertices\. Values of zero or less fall back to [DiGi\.Core\.Constants\.Tolerance\.MicroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.microdistance 'DiGi\.Core\.Constants\.Tolerance\.MicroDistance')\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polyhedron is fully closed\.

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double)'></a>

## Query\.IsClosed\<TPolygonalFace3D\>\(this Polyhedron\<TPolygonalFace3D\>, double\) Method

Determines whether the specified [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') is fully closed \(i\.e\., has no naked edges\) within the given distance tolerance\.

Every edge must be used an even number of times. Use the overload taking a `manifold` flag to require that every edge is used exactly twice.

```csharp
public static bool IsClosed<TPolygonalFace3D>(this DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of the polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.IsClosed\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The [Polyhedron&lt;TPolygonalFace3D&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.IsClosed_TPolygonalFace3D_(thisDiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to weld coincident vertices\. Values of zero or less fall back to [DiGi\.Core\.Constants\.Tolerance\.MicroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.microdistance 'DiGi\.Core\.Constants\.Tolerance\.MicroDistance')\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polyhedron is fully closed\.

<a name='DiGi.Geometry.Spatial.Query.Max(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Max\(this Point3D, Point3D\) Method

Returns the maximum of two `Point3D?` points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Max(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Max(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` point to compare\.

<a name='DiGi.Geometry.Spatial.Query.Max(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point to compare\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The maximum of the two `Point3D?` points, or `null` if either input is `null`\.

<a name='DiGi.Geometry.Spatial.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Query\.Max\(this IEnumerable\<Point3D\>\) Method

Returns the maximum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') from the specified collection of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Max(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to evaluate\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The maximum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found in the collection, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Max\(this IEnumerable\<Point3D\>, Point3D\) Method

Returns the maximum `Point3D?` from the specified collection of `Point3D?` objects and outputs the minimum `Point3D?`\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Max(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, out DiGi.Geometry.Spatial.Classes.Point3D? min);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<Point3D?>?` collection to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D).min'></a>

`min` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

When this method returns, contains the minimum Point3D? found in the collection, if any\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The maximum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found in the collection, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.Min(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Min\(this Point3D, Point3D\) Method

Returns the minimum of two nullable Point3D points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Min(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Min(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first nullable Point3D point to compare\.

<a name='DiGi.Geometry.Spatial.Query.Min(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second nullable Point3D point to compare\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The minimum nullable Point3D point, or null if either [point3D\_1](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Min(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1 'DiGi\.Geometry\.Spatial\.Query\.Min\(this DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D\)\.point3D\_1') or [point3D\_2](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Min(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2 'DiGi\.Geometry\.Spatial\.Query\.Min\(this DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D\)\.point3D\_2') is null\.

<a name='DiGi.Geometry.Spatial.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## Query\.Min\(this IEnumerable\<Point3D\>\) Method

Returns the minimum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') from the specified collection of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Min(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to evaluate\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The minimum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found in the collection, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Min\(this IEnumerable\<Point3D\>, Point3D\) Method

Calculates the minimum and maximum points from a collection of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Min(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D?>? point3Ds, out DiGi.Geometry.Spatial.Classes.Point3D? max);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of nullable [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,DiGi.Geometry.Spatial.Classes.Point3D).max'></a>

`max` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

When this method returns, contains the maximum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found in the collection, or null if no valid points were found\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The minimum [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found in the collection, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Normal\(this Plane, IEnumerable\<Point2D\>\) Method

Calculates the normal vector of a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') based on a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Normal(this DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An `IEnumerable<Planar.Classes.Point2D>` containing the points used to calculate the normal vector\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normal vector, or null if the plane is null, the point collection is null, or there are fewer than three points\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Normal\(this Point3D, Point3D, Point3D\) Method

Calculates the unit normal vector of a plane defined by three points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Normal(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third `Point3D?` point\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A `Vector3D?` representing the unit normal vector, or `null` if any of the provided points are `null` or if the points are collinear\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Normal\(this Vector3D, Vector3D\) Method

Calculates the normal vector perpendicular to the two specified axes\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Normal(this DiGi.Geometry.Spatial.Classes.Vector3D? axisX, DiGi.Geometry.Spatial.Classes.Vector3D? axisY);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisX'></a>

`axisX` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first Vector3D? axis\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).axisY'></a>

`axisY` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second `Vector3D?` axis\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A normalized `Vector3D?` representing the cross product of the two axes, or null if either `Vector3D?` parameter is null\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double)'></a>

## Query\.Normal\(this IEnumerable\<Point3D\>, double\) Method

Calculates the normal vector of a plane defined by a collection of 3D points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Normal(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? point3Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Normal(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).point3Ds'></a>

`point3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of points used to determine the normal vector\.

<a name='DiGi.Geometry.Spatial.Query.Normal(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to check if the points are collinear\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the normal vector, or `null` if the collection is null, contains fewer than three points, or the points are collinear within the specified tolerance\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.On\(this Plane, Point3D, double\) Method

Determines whether a specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') lies on the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') within a given tolerance\.

```csharp
public static bool On(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point is on the plane within the specified tolerance; otherwise, false if either the plane or point is null\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Query\.On\(this Plane, Segment3D, double\) Method

Determines whether a [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') lies on a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') within a specified tolerance\.

```csharp
public static bool On(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check against\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D'></a>

`segment3D` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating `true` if the segment is on the plane; otherwise, `false`\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.On\(this Plane, Vector3D, double\) Method

Determines whether the specified `Vector3D?` lies on the `Plane?` within a given tolerance\.

```csharp
public static bool On(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The `Vector3D?` to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the distance calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the `Vector3D?` is on the `Plane?`\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double)'></a>

## Query\.On\(this Plane, ISegmentable3D, double\) Method

Determines whether an [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object lies on a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') within a specified tolerance\.

```csharp
public static bool On(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to check against\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the distance calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether all points of the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object are on the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.On\(this ISegmentable3D, Point3D, double\) Method

Determines whether the specified [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is on any of the segments of the [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') object within a given tolerance\.

```csharp
public static bool On(this DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, DiGi.Geometry.Spatial.Classes.Point3D? point3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Classes.Point3D,double).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') instance to check\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') point to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.On(thisDiGi.Geometry.Spatial.Interfaces.ISegmentable3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') is on any of the segments within the specified tolerance; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Query.Opposite(thisDiGi.Geometry.Core.Enums.Side)'></a>

## Query\.Opposite\(this Side\) Method

Returns the opposite of the specified [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')\.

```csharp
public static DiGi.Geometry.Core.Enums.Side Opposite(this DiGi.Geometry.Core.Enums.Side side);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Opposite(thisDiGi.Geometry.Core.Enums.Side).side'></a>

`side` [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')

The [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') value to invert\.

#### Returns
[Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')  
The opposite [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') value\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool)'></a>

## Query\.Orientation\(this Plane, IPolygonal2D, bool\) Method

Determines the orientation of a polygonal shape on a specified plane\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') on which the orientation is calculated\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object whose orientation is to be determined\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether to calculate the orientation based on the convex hull of the points\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
An [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') value representing the orientation of the polygonal shape\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Query\.Orientation\(this Plane, IEnumerable\<Point2D\>, bool\) Method

Determines the orientation of a collection of 2D points on a specified plane\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Spatial.Classes.Plane? plane, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used to convert 2D points into 3D space\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Plane,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether to compute the convex hull of the points before determining orientation\. Defaults to true\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
The calculated [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation'), or [Undefined](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation.Undefined 'DiGi\.Geometry\.Core\.Enums\.Orientation\.Undefined') if the plane is null, the point collection is empty, or there are fewer than three valid points\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Orientation\(this Point3D, Point3D, Point3D, Vector3D\) Method

Determines the orientation of three [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points relative to a specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') normal vector\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, DiGi.Geometry.Spatial.Classes.Point3D? point3D_3, DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` point\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point3D_3'></a>

`point3D_3` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The third `Point3D?` point\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The `Vector3D?` normal vector used to determine the orientation\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
An [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') value indicating if the points are clockwise, counter\-clockwise, collinear, or undefined\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Orientation\(this Vector3D, Vector3D, Vector3D\) Method

Determines the orientation of two vectors relative to a normal vector in 3D space\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, DiGi.Geometry.Spatial.Classes.Vector3D? normal);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')? vector\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')? vector\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D).normal'></a>

`normal` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The normal [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')? vector used to determine the orientation\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
An [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') value indicating whether the vectors are collinear, clockwise, or counter\-clockwise\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,bool)'></a>

## Query\.Orientation\(this IPolygonal3D, bool\) Method

Determines the orientation of the specified 3D polygonal object\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Spatial.Interfaces.IPolygonal3D? polygonal3D, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,bool).polygonal3D'></a>

`polygonal3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') object to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Orientation(thisDiGi.Geometry.Spatial.Interfaces.IPolygonal3D,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the convex hull should be used for orientation calculation\. Defaults to true\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
An [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') value representing the orientation of the polygonal object, or [Undefined](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation.Undefined 'DiGi\.Geometry\.Core\.Enums\.Orientation\.Undefined') if the plane is not defined\.

<a name='DiGi.Geometry.Spatial.Query.Parallel(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.Parallel\(this Vector3D, Vector3D, double\) Method

Determines whether two [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vectors are parallel within a specified tolerance\.

```csharp
public static bool Parallel(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Parallel(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Parallel(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') vector to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Parallel(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance for determining if the vectors are parallel\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two vectors are parallel; returns `false` if either vector is `null`\.

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double)'></a>

## Query\.Perpendicular\(this Plane, Plane, double\) Method

Determines whether two planes are perpendicular within a specified tolerance\.

```csharp
public static bool Perpendicular(this DiGi.Geometry.Spatial.Classes.Plane? plane_1, DiGi.Geometry.Spatial.Classes.Plane? plane_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double).plane_1'></a>

`plane_1` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The first [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double).plane_2'></a>

`plane_2` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The second [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to evaluate\.

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Plane,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance for the perpendicularity check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two planes are perpendicular\.

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.Perpendicular\(this Vector3D, Vector3D, double\) Method

Determines whether two `Vector3D?` vectors are perpendicular within a specified tolerance\.

```csharp
public static bool Perpendicular(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first `Vector3D?` vector\.

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second `Vector3D?` vector\.

<a name='DiGi.Geometry.Spatial.Query.Perpendicular(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if the vectors are perpendicular\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two `Vector3D?` vectors are perpendicular\.

<a name='DiGi.Geometry.Spatial.Query.PerpendicularVector(thisDiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.PerpendicularVector\(this Vector3D, double\) Method

Calculates a vector that is perpendicular to the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? PerpendicularVector(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.PerpendicularVector(thisDiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') for which to find a perpendicular vector\.

<a name='DiGi.Geometry.Spatial.Query.PerpendicularVector(thisDiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value used to determine the alignment of the input vector relative to world axes\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that is perpendicular to the input vector, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double)'></a>

## Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this BooleanOpertaionType, Polyhedron\<TPolygonalFace3D\>, Polyhedron\<TPolygonalFace3D\>, bool, bool, double\) Method

Performs a boolean operation on two polyhedrons and returns a list of polygonal faces resulting from the operation\.

```csharp
public static System.Collections.Generic.List<TPolygonalFace3D>? PolygonalFace3Ds<TPolygonalFace3D>(this DiGi.Geometry.Core.Enums.BooleanOpertaionType booleanOpertaionType, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_1, DiGi.Geometry.Spatial.Classes.Polyhedron<TPolygonalFace3D>? polyhedron_2, bool inlcudePolyhedron_1, bool inlcudePolyhedron_2, double tolerance=1E-06)
    where TPolygonalFace3D : DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).TPolygonalFace3D'></a>

`TPolygonalFace3D`

The type of polygonal face, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).booleanOpertaionType'></a>

`booleanOpertaionType` [BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')

The type of the boolean operation to perform\.

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).polyhedron_1'></a>

`polyhedron_1` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, bool, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The first polyhedron\.

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).polyhedron_2'></a>

`polyhedron_2` [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron&lt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, bool, double\)\.TPolygonalFace3D')[&gt;](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_ 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>')

The second polyhedron\.

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).inlcudePolyhedron_1'></a>

`inlcudePolyhedron_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to include faces originating from the first polyhedron in the result\.

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).inlcudePolyhedron_2'></a>

`inlcudePolyhedron_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to include faces originating from the second polyhedron in the result\.

<a name='DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for geometric computations and classification\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, bool, double\)\.TPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [TPolygonalFace3D](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).TPolygonalFace3D 'DiGi\.Geometry\.Spatial\.Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, bool, double\)\.TPolygonalFace3D') faces resulting from the boolean operation \(may be empty\), or `null` if either polyhedron is `null`\.

### Remarks

The boolean operation splits the faces of each polyhedron by the faces of the other, classifies every resulting fragment
against the opposite volume, and deduplicates overlapping coplanar boundaries. The operation type determines which fragments are kept:
- [Union](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType.Union 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType\.Union'): faces of A outside B plus faces of B outside A.
- [Intersection](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType.Intersection 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType\.Intersection'): faces of A inside B plus faces of B inside A.
- [Difference](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType.Difference 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType\.Difference'): faces of A outside B plus faces of B inside A (with inverted normals).

The output can be further constrained by source polyhedron via [inlcudePolyhedron\_1](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).inlcudePolyhedron_1 'DiGi\.Geometry\.Spatial\.Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, bool, double\)\.inlcudePolyhedron\_1') and [inlcudePolyhedron\_2](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.PolygonalFace3Ds_TPolygonalFace3D_(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Polyhedron_TPolygonalFace3D_,bool,bool,double).inlcudePolyhedron_2 'DiGi\.Geometry\.Spatial\.Query\.PolygonalFace3Ds\<TPolygonalFace3D\>\(this DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\<TPolygonalFace3D\>, bool, bool, double\)\.inlcudePolyhedron\_2'):
setting either to `false` excludes faces whose internal point lies on or inside the corresponding polyhedron volume.
When both flags are `true`, all faces from the boolean result are returned without additional filtering overhead.

The method returns early for trivial cases without executing the CSG pipeline:
- Intersection with disjoint bounding boxes or either polyhedron having no faces returns an empty list.
- Difference with disjoint bounding boxes or an empty second polyhedron returns the faces of the first polyhedron (subject to include flags).
- Union with disjoint bounding boxes returns the faces of both polyhedrons (subject to include flags).

<a name='DiGi.Geometry.Spatial.Query.Project(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.Project\(this Plane, Point3D\) Method

Projects a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') onto a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Project(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Project(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to project the point onto\.

<a name='DiGi.Geometry.Spatial.Query.Project(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to be projected\.

#### Returns
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The projected [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') on the plane, or null if either the plane or the point is null\.

<a name='DiGi.Geometry.Spatial.Query.Project(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Project\(this Plane, Vector3D\) Method

Projects the specified [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') onto the specified [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Project(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Project(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') onto which the vector is projected\.

<a name='DiGi.Geometry.Spatial.Query.Project(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to project\.

#### Returns
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the projection of the [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') on the [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane'), or `null` if either the plane or the vector3D is null\.

<a name='DiGi.Geometry.Spatial.Query.Project_T_(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double)'></a>

## Query\.Project\<T\>\(this Plane, IGeometry3D, double\) Method

Projects the specified 3D geometry onto the plane\.

```csharp
public static T? Project<T>(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, double tolerance=1E-06)
    where T : DiGi.Geometry.Spatial.Interfaces.IGeometry3D;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.Project_T_(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).T'></a>

`T`

The type of the resulting projected geometry, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Project_T_(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') onto which the geometry is projected\.

<a name='DiGi.Geometry.Spatial.Query.Project_T_(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') object to be projected\.

<a name='DiGi.Geometry.Spatial.Query.Project_T_(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for the projection operation\.

#### Returns
[T](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.Project_T_(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).T 'DiGi\.Geometry\.Spatial\.Query\.Project\<T\>\(this DiGi\.Geometry\.Spatial\.Classes\.Plane, DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, double\)\.T')  
The projected geometry of type \<typeparam ref="T" /\>, or `null` if the projection fails or input parameters are null\.

<a name='DiGi.Geometry.Spatial.Query.SameHalf(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.SameHalf\(this Vector3D, Vector3D, double\) Method

Determines whether two vectors are within the same half\-space based on a specified tolerance\.

```csharp
public static bool SameHalf(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.SameHalf(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first `Vector3D?` vector to compare\.

<a name='DiGi.Geometry.Spatial.Query.SameHalf(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second `Vector3D?` vector to compare\.

<a name='DiGi.Geometry.Spatial.Query.SameHalf(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance for the angle comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the vectors are in the same half; returns `false` if either vector is `null`\.

<a name='DiGi.Geometry.Spatial.Query.Scale(thisDiGi.Geometry.Spatial.Classes.Ray3D,double)'></a>

## Query\.Scale\(this Ray3D, double\) Method

Scales the specified [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') by a given factor\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Ray3D? Scale(this DiGi.Geometry.Spatial.Classes.Ray3D? ray3D, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Scale(thisDiGi.Geometry.Spatial.Classes.Ray3D,double).ray3D'></a>

`ray3D` [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')

The [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') instance to scale\.

<a name='DiGi.Geometry.Spatial.Query.Scale(thisDiGi.Geometry.Spatial.Classes.Ray3D,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the scaling factor\.

#### Returns
[Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')  
A new scaled [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') instance, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input ray is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), the factor is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN'), or the ray's origin or direction are [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Query.Scale(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Ray3D_,double)'></a>

## Query\.Scale\(this IEnumerable\<Ray3D\>, double\) Method

Scales a collection of [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') objects by the specified factor\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Ray3D>? Scale(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Ray3D>? ray3Ds, double factor);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Scale(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Ray3D_,double).ray3Ds'></a>

`ray3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') objects to scale\.

<a name='DiGi.Geometry.Spatial.Query.Scale(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Ray3D_,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') factor by which each ray is scaled\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the scaled [Ray3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Ray3D 'DiGi\.Geometry\.Spatial\.Classes\.Ray3D') objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Query.Segment3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,bool,bool)'></a>

## Query\.Segment3Ds\(this IPolygonalFace3D, bool, bool\) Method

Retrieves a list of [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') objects from the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D'), optionally including external and internal edges\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Segment3D>? Segment3Ds(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, bool external=true, bool @internal=true);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Segment3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,bool,bool).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to extract segments from\.

<a name='DiGi.Geometry.Spatial.Query.Segment3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,bool,bool).external'></a>

`external` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the external edge segments should be included in the result\. Defaults to `true`\.

<a name='DiGi.Geometry.Spatial.Query.Segment3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,bool,bool).internal'></a>

`internal` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the internal edge segments should be included in the result\. Defaults to `true`\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the extracted segments, or `null` if the provided [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') is null\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double)'></a>

## Query\.Similar\(this Point3D, Point3D, double\) Method

Determines whether two [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') points are similar within a specified tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Spatial.Classes.Point3D? point3D_1, DiGi.Geometry.Spatial.Classes.Point3D? point3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_1'></a>

`point3D_1` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first `Point3D?` point to compare\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).point3D_2'></a>

`point3D_2` [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second `Point3D?` point to compare\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two points are similar\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Segment3D,double)'></a>

## Query\.Similar\(this Segment3D, Segment3D, double\) Method

Determines whether two [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segments are similar, meaning they are either almost equal or one is the reverse of the other within a specified tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Spatial.Classes.Segment3D? segment3D_1, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D_1'></a>

`segment3D_1` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The first [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segment to compare\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Segment3D,double).segment3D_2'></a>

`segment3D_2` [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The second [Segment3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Segment3D 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') segment to compare\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Spatial.Classes.Segment3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two segments are similar\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.Similar\(this Vector3D, Vector3D, double\) Method

Determines whether two [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') objects are similar, meaning they are either almost equal or one is the inverse of the other within a specified tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_1, DiGi.Geometry.Spatial.Classes.Vector3D? vector3D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_1'></a>

`vector3D_1` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The first [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') object to compare\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).vector3D_2'></a>

`vector3D_2` [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The second [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') object to compare\.

<a name='DiGi.Geometry.Spatial.Query.Similar(thisDiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two vectors are similar\.

<a name='DiGi.Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double)'></a>

## Query\.TryGetConnectedPolygonalFace3Ds\(this IPolygonalFace3D, IEnumerable\<IPolygonalFace3D\>, List\<IPolygonalFace3D\>, List\<IPolygonalFace3D\>, double\) Method

Attempts to separate a collection of polygonal faces into those connected and disconnected from a specified source polygonal face based on a distance tolerance\.

```csharp
public static bool TryGetConnectedPolygonalFace3Ds(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds_Connected, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds_Disconnected, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The source [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') object\.

<a name='DiGi.Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') objects to be evaluated\.

<a name='DiGi.Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3Ds_Connected'></a>

`polygonalFace3Ds_Connected` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') objects that are connected to the source face; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).polygonalFace3Ds_Disconnected'></a>

`polygonalFace3Ds_Disconnected` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') objects that are not connected to the source face; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TryGetConnectedPolygonalFace3Ds(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine connectivity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the operation was successful\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double)'></a>

## Query\.TrySplit\(this Plane, Mesh3D, List\<Mesh3D\>, double\) Method

Attempts to split a mesh by the specified plane, combining connected components from above and below into a single result list\.

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Mesh3D>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the splitting surface\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).mesh3D'></a>

`mesh3D` [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') to split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting meshes from both sides of the plane if the operation succeeded; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance for classification and intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double)'></a>

## Query\.TrySplit\(this Plane, Mesh3D, List\<Mesh3D\>, List\<Mesh3D\>, double\) Method

Attempts to split a mesh by the specified plane, separating triangles into above and below connected components\.

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Mesh3D>? mesh3Ds_Above, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Mesh3D>? mesh3Ds_Below, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the splitting surface\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).mesh3D'></a>

`mesh3D` [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The [Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') to split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).mesh3Ds_Above'></a>

`mesh3Ds_Above` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of connected components above the plane, or null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).mesh3Ds_Below'></a>

`mesh3Ds_Below` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Mesh3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Mesh3D 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of connected components below the plane, or null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Mesh3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance for classification and intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double)'></a>

## Query\.TrySplit\(this Plane, IPolygonalFace3D, List\<PolygonalFace3D\>, double\) Method

Attempts to split a 3D polygonal face using the specified plane\.

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.PolygonalFace3D>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used as the splitting surface\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to be split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting faces if the operation succeeded; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double)'></a>

## Query\.TrySplit\(this Plane, IPolyhedron, List\<Polyhedron\>, double\) Method

Attempts to split a polyhedron using a specified plane\.

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Classes.Plane? plane, DiGi.Geometry.Spatial.Interfaces.IPolyhedron? polyhedron, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polyhedron>? polyhedrons, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).plane'></a>

`plane` [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') used to perform the split operation\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') that is to be split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).polyhedrons'></a>

`polyhedrons` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting polyhedrons if the operation succeeded; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Classes.Plane,DiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polyhedron was successfully split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double)'></a>

## Query\.TrySplit\(this IPolygonalFace3D, IEnumerable\<IPolygonalFace3D\>, List\<PolygonalFace3D\>, double\) Method

Attempts to split the specified polygonal face using a collection of other polygonal faces\.

```csharp
public static bool TrySplit(this DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.PolygonalFace3D>? result, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance to be split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instances used as splitting boundaries\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.PolygonalFace3D 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the resulting split faces if successful; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit(thisDiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.PolygonalFace3D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the polygonal face was successfully split; otherwise, false\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double)'></a>

## Query\.TrySplit\<TPolyhedron\>\(this IPolyhedron, IEnumerable\<TPolyhedron\>, Polyhedron, double\) Method

Attempts to split the specified polyhedron using a collection of other polyhedrons\.

```csharp
public static bool TrySplit<TPolyhedron>(this DiGi.Geometry.Spatial.Interfaces.IPolyhedron? polyhedron, System.Collections.Generic.IEnumerable<TPolyhedron>? polyhedrons, out DiGi.Geometry.Spatial.Classes.Polyhedron? result, double tolerance=1E-06)
    where TPolyhedron : DiGi.Geometry.Spatial.Interfaces.IPolyhedron;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double).TPolyhedron'></a>

`TPolyhedron`

The type of polyhedrons in the collection, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double).polyhedron'></a>

`polyhedron` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron') to be split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double).polyhedrons'></a>

`polyhedrons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TPolyhedron](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double).TPolyhedron 'DiGi\.Geometry\.Spatial\.Query\.TrySplit\<TPolyhedron\>\(this DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron, System\.Collections\.Generic\.IEnumerable\<TPolyhedron\>, DiGi\.Geometry\.Spatial\.Classes\.Polyhedron, double\)\.TPolyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of polyhedrons used for the splitting process\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double).result'></a>

`result` [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')

When this method returns, contains the resulting [Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') if the operation succeeded; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisDiGi.Geometry.Spatial.Interfaces.IPolyhedron,System.Collections.Generic.IEnumerable_TPolyhedron_,DiGi.Geometry.Spatial.Classes.Polyhedron,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisSystem.Collections.Generic.IEnumerable_TPolyhedron_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double)'></a>

## Query\.TrySplit\<TPolyhedron\>\(this IEnumerable\<TPolyhedron\>, List\<Polyhedron\>, double\) Method

Attempts to split a collection of polyhedrons based on a specified tolerance\.

```csharp
public static bool TrySplit<TPolyhedron>(this System.Collections.Generic.IEnumerable<TPolyhedron>? polyhedrons, out System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polyhedron>? result, double tolerance=1E-06)
    where TPolyhedron : DiGi.Geometry.Spatial.Interfaces.IPolyhedron;
```
#### Type parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisSystem.Collections.Generic.IEnumerable_TPolyhedron_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).TPolyhedron'></a>

`TPolyhedron`

The type of polyhedron, which must implement [DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolyhedron 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolyhedron')\.
#### Parameters

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisSystem.Collections.Generic.IEnumerable_TPolyhedron_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).polyhedrons'></a>

`polyhedrons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TPolyhedron](DiGi.Geometry.Spatial.md#DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisSystem.Collections.Generic.IEnumerable_TPolyhedron_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).TPolyhedron 'DiGi\.Geometry\.Spatial\.Query\.TrySplit\<TPolyhedron\>\(this System\.Collections\.Generic\.IEnumerable\<TPolyhedron\>, System\.Collections\.Generic\.List\<DiGi\.Geometry\.Spatial\.Classes\.Polyhedron\>, double\)\.TPolyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of polyhedrons to split\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisSystem.Collections.Generic.IEnumerable_TPolyhedron_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).result'></a>

`result` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polyhedron](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of resulting polyhedrons if the operation succeeded; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Query.TrySplit_TPolyhedron_(thisSystem.Collections.Generic.IEnumerable_TPolyhedron_,System.Collections.Generic.List_DiGi.Geometry.Spatial.Classes.Polyhedron_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine splitting boundaries\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the split was successful\.
### Structs

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationCandidate'></a>

## Create\.BooleanOperationCandidate Struct

Candidate boundary fragment produced by the face\-splitting stage of a 3D boolean operation\.
Value type \- avoids the per\-candidate heap allocations a Tuple\-based candidate list would incur\.

```csharp
private readonly struct Create.BooleanOperationCandidate
```
### Fields

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationCandidate.FromFirst'></a>

## Create\.BooleanOperationCandidate\.FromFirst Field

True when the fragment originates from the first polyhedron; false for the second polyhedron\.

```csharp
public readonly bool FromFirst;
```

#### Field Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationCandidate.ParentIndex'></a>

## Create\.BooleanOperationCandidate\.ParentIndex Field

The index of the parent face in the source polyhedron the fragment originates from\.

```csharp
public readonly int ParentIndex;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Geometry.Spatial.Create.BooleanOperationCandidate.PolygonalFace3D'></a>

## Create\.BooleanOperationCandidate\.PolygonalFace3D Field

The candidate face fragment\.

```csharp
public readonly IPolygonalFace3D PolygonalFace3D;
```

#### Field Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')