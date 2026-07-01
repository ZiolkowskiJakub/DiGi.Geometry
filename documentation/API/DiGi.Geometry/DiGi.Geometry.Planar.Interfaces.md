#### [DiGi\.Geometry](index.md 'index')

## DiGi\.Geometry\.Planar\.Interfaces Namespace
### Interfaces

<a name='DiGi.Geometry.Planar.Interfaces.IBoundable2D'></a>

## IBoundable2D Interface

```csharp
public interface IBoundable2D : DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable
```

Derived  
↳ [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')  
↳ [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')  
↳ [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')  
↳ [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
↳ [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
↳ [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
↳ [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
↳ [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D')  
↳ [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D')  
↳ [IEllipse2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IEllipse2D 'DiGi\.Geometry\.Planar\.Interfaces\.IEllipse2D')  
↳ [IFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D')  
↳ [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
↳ [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')  
↳ [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.IBoundable2D.GetBoundingBox()'></a>

## IBoundable2D\.GetBoundingBox\(\) Method

Gets the bounding box of the geometry\.

```csharp
DiGi.Geometry.Planar.Classes.BoundingBox2D? GetBoundingBox();
```

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The bounding box if available; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D'></a>

## IClosedCurve2D Interface

```csharp
public interface IClosedCurve2D : DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Derived  
↳ [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')  
↳ [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')  
↳ [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
↳ [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
↳ [IEllipse2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IEllipse2D 'DiGi\.Geometry\.Planar\.Interfaces\.IEllipse2D')  
↳ [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetArea()'></a>

## IClosedCurve2D\.GetArea\(\) Method

Calculates the area of the closed curve\.

```csharp
double GetArea();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the closed curve\.

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetInternalPoint(double)'></a>

## IClosedCurve2D\.GetInternalPoint\(double\) Method

Gets an internal point of the closed curve\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
An internal point if found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## IClosedCurve2D\.InRange\(Point2D, double\) Method

Determines whether the specified point is within range of the closed curve\.

```csharp
bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## IClosedCurve2D\.Inside\(Point2D, double\) Method

Determines whether the specified point is inside the closed curve\.

```csharp
bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IClosedCurve2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is inside; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IEllipse2D'></a>

## IEllipse2D Interface

```csharp
public interface IEllipse2D : DiGi.Geometry.Planar.Interfaces.IClosedCurve2D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable
```

Derived  
↳ [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')  
↳ [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

Implements [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable')
### Properties

<a name='DiGi.Geometry.Planar.Interfaces.IEllipse2D.Center'></a>

## IEllipse2D\.Center Property

Gets the center point of the ellipse\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? Center { get; }
```

#### Property Value
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D'></a>

## IFace2D Interface

```csharp
public interface IFace2D : DiGi.Geometry.Core.Interfaces.IFace, DiGi.Geometry.Core.Interfaces.ISurface, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.ISurface2D
```

Derived  
↳ [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
↳ [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

Implements [DiGi\.Geometry\.Core\.Interfaces\.IFace](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface 'DiGi\.Geometry\.Core\.Interfaces\.IFace'), [DiGi\.Geometry\.Core\.Interfaces\.ISurface](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isurface 'DiGi\.Geometry\.Core\.Interfaces\.ISurface'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## IFace2D\.ClosestPoint\(Point2D, double\) Method

Gets the closest point on the face to the specified point\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest point if found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.GetInternalPoint(double)'></a>

## IFace2D\.GetInternalPoint\(double\) Method

Gets an internal point of the face\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? GetInternalPoint(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.GetInternalPoint(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
An internal point if found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## IFace2D\.InRange\(Point2D, double\) Method

Determines whether the specified point is within range of the face\.

```csharp
bool InRange(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.InRange(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## IFace2D\.Inside\(Point2D, double\) Method

Determines whether the specified point is inside the face\.

```csharp
bool Inside(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IFace2D.Inside(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is inside; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D'></a>

## ILinear2D Interface

```csharp
public interface ILinear2D : DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IGeometry2D
```

Derived  
↳ [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')  
↳ [Ray2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ray2D 'DiGi\.Geometry\.Planar\.Classes\.Ray2D')  
↳ [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')
### Properties

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Direction'></a>

## ILinear2D\.Direction Property

Gets the direction vector of the linear geometry\.

```csharp
DiGi.Geometry.Planar.Classes.Vector2D? Direction { get; }
```

#### Property Value
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## ILinear2D\.ClosestPoint\(Point2D\) Method

Gets the closest point on the linear geometry to the specified point\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.ClosestPoint(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest point if found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## ILinear2D\.Collinear\(ILinear2D, double\) Method

Determines whether this linear geometry is collinear with another linear geometry\.

```csharp
bool Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D'></a>

`linear2D` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The other linear geometry to check\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Collinear(DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometries are collinear; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Distance(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## ILinear2D\.Distance\(Point2D\) Method

Calculates the distance from the specified point to the linear geometry\.

```csharp
double Distance(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Distance(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to calculate the distance from\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance between the point and the linear geometry\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.On(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## ILinear2D\.On\(Point2D, double\) Method

Determines whether the specified point lies on the linear geometry\.

```csharp
bool On(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.On(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the linear geometry; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Project(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## ILinear2D\.Project\(Point2D\) Method

Projects the specified point onto the linear geometry\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? Project(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.ILinear2D.Project(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to project\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The projected point if found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D'></a>

## IPolygonal2D Interface

```csharp
public interface IPolygonal2D : DiGi.Geometry.Planar.Interfaces.IClosedCurve2D, DiGi.Geometry.Core.Interfaces.IClosedCurve, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ISegmentable2D, DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Planar.Interfaces.IInvertible2D
```

Derived  
↳ [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
↳ [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

Implements [IClosedCurve2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IClosedCurve2D 'DiGi\.Geometry\.Planar\.Interfaces\.IClosedCurve2D'), [DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iclosedcurve 'DiGi\.Geometry\.Core\.Interfaces\.IClosedCurve'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.GetCentroid()'></a>

## IPolygonal2D\.GetCentroid\(\) Method

Gets the centroid of the polygonal geometry\.

```csharp
DiGi.Geometry.Planar.Classes.Point2D? GetCentroid();
```

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The centroid point if found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## IPolygonal2D\.InRange\(BoundingBox2D, double\) Method

Determines whether the polygonal geometry is within range of the specified bounding box\.

```csharp
bool InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Classes.BoundingBox2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## IPolygonal2D\.InRange\(ISegmentable2D, double\) Method

Determines whether the polygonal geometry is within range of the specified segmentable geometry\.

```csharp
bool InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.InRange(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if in range; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## IPolygonal2D\.Inside\(ISegmentable2D, double\) Method

Determines whether the specified segmentable geometry is inside the polygonal geometry\.

```csharp
bool Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Inside(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if inside; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Triangulate(double)'></a>

## IPolygonal2D\.Triangulate\(double\) Method

Triangulates the polygonal geometry into a list of triangles\.

```csharp
System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonal2D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of triangles representing the triangulation; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D'></a>

## IPolygonalFace2D Interface

```csharp
public interface IPolygonalFace2D : DiGi.Geometry.Planar.Interfaces.IFace2D<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Planar.Interfaces.IFace2D, DiGi.Geometry.Core.Interfaces.IFace, DiGi.Geometry.Core.Interfaces.ISurface, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.ISurface2D, DiGi.Geometry.Core.Interfaces.IFace<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>, DiGi.Geometry.Planar.Interfaces.IInvertible2D, DiGi.Geometry.Core.Interfaces.IInvertible
```

Derived  
↳ [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

Implements [DiGi\.Geometry\.Planar\.Interfaces\.IFace2D&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iface2d-1 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iface2d-1 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D\`1'), [IFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IFace2D'), [DiGi\.Geometry\.Core\.Interfaces\.IFace](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface 'DiGi\.Geometry\.Core\.Interfaces\.IFace'), [DiGi\.Geometry\.Core\.Interfaces\.ISurface](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isurface 'DiGi\.Geometry\.Core\.Interfaces\.ISurface'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D'), [DiGi\.Geometry\.Core\.Interfaces\.IFace&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iface-1 'DiGi\.Geometry\.Core\.Interfaces\.IFace\`1'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible')
### Properties

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Edges'></a>

## IPolygonalFace2D\.Edges Property

Gets the list of polygonal edges that define the face\.

```csharp
System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? Edges { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## IPolygonalFace2D\.OnEdge\(Point2D, double\) Method

Determines whether the specified point lies on an edge of the face\.

```csharp
bool OnEdge(DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point to check\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.OnEdge(DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on an edge; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_)'></a>

## IPolygonalFace2D\.Orient\(Nullable\<Orientation\>, Nullable\<Orientation\>\) Method

Orients the edges of the face based on the specified orientations for external and internal edges\.

```csharp
bool Orient(System.Nullable<DiGi.Geometry.Core.Enums.Orientation> externalEdgeOrientation, System.Nullable<DiGi.Geometry.Core.Enums.Orientation> internalEdgeOrientation);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).externalEdgeOrientation'></a>

`externalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The orientation for the external edge\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Orient(System.Nullable_DiGi.Geometry.Core.Enums.Orientation_,System.Nullable_DiGi.Geometry.Core.Enums.Orientation_).internalEdgeOrientation'></a>

`internalEdgeOrientation` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The orientation for internal edges \(holes\)\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if orientation was successful; otherwise, false\.

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Triangulate(double)'></a>

## IPolygonalFace2D\.Triangulate\(double\) Method

Triangulates the polygonal face into a list of triangles\.

```csharp
System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Triangle2D>? Triangulate(double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D.Triangulate(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of triangles representing the triangulation; otherwise, null\.

<a name='DiGi.Geometry.Planar.Interfaces.ISegmentable2D'></a>

## ISegmentable2D Interface

```csharp
public interface ISegmentable2D : DiGi.Geometry.Core.Interfaces.ISegmentable<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Core.Interfaces.ISegmentable, DiGi.Geometry.Core.Interfaces.IGeometry, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Core.Interfaces.IInvertible, DiGi.Geometry.Core.Interfaces.ICurve, DiGi.Geometry.Core.Interfaces.IMovable, DiGi.Geometry.Planar.Interfaces.IMovable2D, DiGi.Geometry.Core.Interfaces.IMovable<DiGi.Geometry.Planar.Classes.Vector2D>, DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Planar.Interfaces.IGeometry2D, DiGi.Geometry.Planar.Interfaces.ITransformable2D, DiGi.Geometry.Core.Interfaces.ITransformable<DiGi.Geometry.Planar.Interfaces.ITransform2D>, DiGi.Geometry.Core.Interfaces.ITransformable, DiGi.Geometry.Planar.Interfaces.ICollectable2D, DiGi.Geometry.Core.Interfaces.ICollectable, DiGi.Geometry.Planar.Interfaces.IBoundable2D, DiGi.Geometry.Core.Interfaces.IBoundable, DiGi.Geometry.Planar.Interfaces.IInvertible2D
```

Derived  
↳ [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
↳ [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
↳ [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
↳ [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D')  
↳ [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

Implements [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable-1 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ISegmentable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.isegmentable 'DiGi\.Geometry\.Core\.Interfaces\.ISegmentable'), [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Core\.Interfaces\.IInvertible](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iinvertible 'DiGi\.Geometry\.Core\.Interfaces\.IInvertible'), [DiGi\.Geometry\.Core\.Interfaces\.ICurve](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icurve 'DiGi\.Geometry\.Core\.Interfaces\.ICurve'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable 'DiGi\.Geometry\.Core\.Interfaces\.IMovable'), [DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.imovable2d 'DiGi\.Geometry\.Planar\.Interfaces\.IMovable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IMovable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.imovable-1 'DiGi\.Geometry\.Core\.Interfaces\.IMovable\`1'), [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D'), [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D'), [DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransformable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransformable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable-1 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable\`1'), [DiGi\.Geometry\.Core\.Interfaces\.ITransformable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.itransformable 'DiGi\.Geometry\.Core\.Interfaces\.ITransformable'), [DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icollectable2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICollectable2D'), [DiGi\.Geometry\.Core\.Interfaces\.ICollectable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.icollectable 'DiGi\.Geometry\.Core\.Interfaces\.ICollectable'), [IBoundable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IBoundable2D 'DiGi\.Geometry\.Planar\.Interfaces\.IBoundable2D'), [DiGi\.Geometry\.Core\.Interfaces\.IBoundable](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.iboundable 'DiGi\.Geometry\.Core\.Interfaces\.IBoundable'), [DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.iinvertible2d 'DiGi\.Geometry\.Planar\.Interfaces\.IInvertible2D')
### Methods

<a name='DiGi.Geometry.Planar.Interfaces.ISegmentable2D.GetSegments()'></a>

## ISegmentable2D\.GetSegments\(\) Method

Gets the segments that compose the segmentable geometry\.

```csharp
System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? GetSegments();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of segments; otherwise, null\.