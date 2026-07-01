#### [DiGi\.Geometry](index.md 'index')

## DiGi\.Geometry\.Spatial\.Constants Namespace
### Classes

<a name='DiGi.Geometry.Spatial.Constants.Plane'></a>

## Plane Class

Provides common world plane definitions\.

```csharp
public static class Plane
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Plane
### Properties

<a name='DiGi.Geometry.Spatial.Constants.Plane.WorldX'></a>

## Plane\.WorldX Property

Gets a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') representing the world X plane, which is perpendicular to the world X axis and passes through the origin\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane WorldX { get; }
```

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

<a name='DiGi.Geometry.Spatial.Constants.Plane.WorldY'></a>

## Plane\.WorldY Property

Gets a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') representing the world Y plane, defined by the origin point and the world Y normal vector\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane WorldY { get; }
```

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') that is perpendicular to the world Y axis\.

<a name='DiGi.Geometry.Spatial.Constants.Plane.WorldZ'></a>

## Plane\.WorldZ Property

Gets a [Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') representing the world Z plane\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane WorldZ { get; }
```

#### Property Value
[Plane](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

<a name='DiGi.Geometry.Spatial.Constants.Point3D'></a>

## Point3D Class

Provides utility members and constants for 3D point coordinates\.

```csharp
public static class Point3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Point3D
### Properties

<a name='DiGi.Geometry.Spatial.Constants.Point3D.Zero'></a>

## Point3D\.Zero Property

Gets a [Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance representing the origin point with all coordinates set to zero\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D Zero { get; }
```

#### Property Value
[Point3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Point3D 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Geometry.Spatial.Constants.Vector3D'></a>

## Vector3D Class

Provides static utility properties for common 3D vector directions\.

```csharp
public static class Vector3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Vector3D
### Properties

<a name='DiGi.Geometry.Spatial.Constants.Vector3D.WorldX'></a>

## Vector3D\.WorldX Property

Gets the unit vector representing the X\-axis in world space\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D WorldX { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instance that represents the X\-axis\.

<a name='DiGi.Geometry.Spatial.Constants.Vector3D.WorldY'></a>

## Vector3D\.WorldY Property

Gets the unit vector representing the Y\-axis in world space as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D WorldY { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Geometry.Spatial.Constants.Vector3D.WorldZ'></a>

## Vector3D\.WorldZ Property

Gets the unit vector pointing along the positive Z\-axis of the world coordinate system as a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D WorldZ { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Geometry.Spatial.Constants.Vector3D.Zero'></a>

## Vector3D\.Zero Property

Gets a [Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') where all coordinates are set to 0\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D Zero { get; }
```

#### Property Value
[Vector3D](DiGi.Geometry.Spatial.Classes.md#DiGi.Geometry.Spatial.Classes.Vector3D 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')