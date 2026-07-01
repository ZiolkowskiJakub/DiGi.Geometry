## DiGi\.Geometry\.Drawing Namespace
### Classes

<a name='DiGi.Geometry.Drawing.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Core.Drawing.Classes.Pen,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool)'></a>

## Modify\.Draw\(this Graphics, Pen, IPolygonal2D, bool\) Method

Draws the specified polygonal 2D object using the provided pen and fill settings\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Core.Drawing.Classes.Pen? pen, DiGi.Geometry.Planar.Interfaces.IPolygonal2D polygonal2D, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Core.Drawing.Classes.Pen,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') instance used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Core.Drawing.Classes.Pen,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).pen'></a>

`pen` [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen') that defines the drawing style\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Core.Drawing.Classes.Pen,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object to draw\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Core.Drawing.Classes.Pen,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the interior of the polygonal 2D object should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Drawing.Classes.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, BoundingBox2D, Pen, bool\) Method

Draws a 2D bounding box using the specified pen and fill settings\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Core.Drawing.Classes.Pen pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Drawing.Classes.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Drawing.Classes.Pen,bool).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Drawing.Classes.Pen,bool).pen'></a>

`pen` [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen') that defines the line style and color\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Drawing.Classes.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the interior of the bounding box should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Drawing.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, BoundingBox2D, Pen, bool\) Method

Draws a [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') using the specified [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object and [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Drawing.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Drawing.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Drawing.Pen,bool).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Drawing.Pen,bool).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen') used for the drawing operation\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Drawing.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the bounding box should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,DiGi.Core.Drawing.Classes.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, Mesh2D, Pen, bool\) Method

Draws a [DiGi\.Geometry\.Planar\.Classes\.Mesh2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.mesh2d 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') using the specified [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.Mesh2D? mesh2D, DiGi.Core.Drawing.Classes.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,DiGi.Core.Drawing.Classes.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,DiGi.Core.Drawing.Classes.Pen,bool).mesh2D'></a>

`mesh2D` [DiGi\.Geometry\.Planar\.Classes\.Mesh2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.mesh2d 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')

The [DiGi\.Geometry\.Planar\.Classes\.Mesh2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.mesh2d 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') object to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,DiGi.Core.Drawing.Classes.Pen,bool).pen'></a>

`pen` [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen') used to define the style of the drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,DiGi.Core.Drawing.Classes.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the mesh should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,System.Drawing.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, Mesh2D, Pen, bool\) Method

Draws a [DiGi\.Geometry\.Planar\.Classes\.Mesh2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.mesh2d 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') using the specified [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') context, [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen'), and fill option\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.Mesh2D? mesh2D, System.Drawing.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,System.Drawing.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,System.Drawing.Pen,bool).mesh2D'></a>

`mesh2D` [DiGi\.Geometry\.Planar\.Classes\.Mesh2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.mesh2d 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')

The [DiGi\.Geometry\.Planar\.Classes\.Mesh2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.mesh2d 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') object to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,System.Drawing.Pen,bool).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen') object used for the drawing style and color\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Mesh2D,System.Drawing.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the mesh should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Drawing.Classes.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, Point2D, Pen, bool\) Method

Draws a [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') using the specified [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen') and fill setting on the provided [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Core.Drawing.Classes.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Drawing.Classes.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') instance used for drawing operations\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Drawing.Classes.Pen,bool).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Drawing.Classes.Pen,bool).pen'></a>

`pen` [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen') that defines the drawing style\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Drawing.Classes.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,System.Drawing.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, Point2D, Pen, bool\) Method

Draws an ellipse at the specified point using the provided pen, with an option to fill it\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Drawing.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,System.Drawing.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,System.Drawing.Pen,bool).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') coordinates where the ellipse will be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,System.Drawing.Pen,bool).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen') that defines the color and width of the ellipse\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Point2D,System.Drawing.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether to fill the interior of the ellipse\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Core.Drawing.Classes.Pen)'></a>

## Modify\.Draw\(this Graphics, Segment2D, Pen\) Method

Draws a [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') using the specified [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object and [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, DiGi.Core.Drawing.Classes.Pen pen);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Core.Drawing.Classes.Pen).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Core.Drawing.Classes.Pen).segment2D'></a>

`segment2D` [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Core.Drawing.Classes.Pen).pen'></a>

`pen` [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The [DiGi\.Core\.Drawing\.Classes\.Pen](https://learn.microsoft.com/en-us/dotnet/api/digi.core.drawing.classes.pen 'DiGi\.Core\.Drawing\.Classes\.Pen') that defines the style of the line\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,System.Drawing.Pen)'></a>

## Modify\.Draw\(this Graphics, Segment2D, Pen\) Method

Draws a [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') using the specified [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') context and [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, System.Drawing.Pen? pen);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,System.Drawing.Pen).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,System.Drawing.Pen).segment2D'></a>

`segment2D` [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') object representing the line segment to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Classes.Segment2D,System.Drawing.Pen).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen') object used to define the color and width of the line\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Drawing.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, IPolygonal2D, Pen, bool\) Method

Draws a polygonal 2D shape on the specified graphics surface\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, System.Drawing.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Drawing.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Drawing.Pen,bool).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object that defines the polygon to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Drawing.Pen,bool).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen') object used to draw the outline of the polygon\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Drawing.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the interior of the polygon should be filled\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Drawing.Pen,bool)'></a>

## Modify\.Draw\(this Graphics, IPolygonalFace2D, Pen, bool\) Method

Draws the specified [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonalface2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') on the provided [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') surface using the specified [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')\.

```csharp
public static void Draw(this System.Drawing.Graphics? graphics, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D, System.Drawing.Pen? pen, bool fill);
```
#### Parameters

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Drawing.Pen,bool).graphics'></a>

`graphics` [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics')

The [System\.Drawing\.Graphics](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics 'System\.Drawing\.Graphics') object used for drawing\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Drawing.Pen,bool).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonalface2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonalface2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') instance to be drawn\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Drawing.Pen,bool).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen') used to draw the outline of the polygonal face\.

<a name='DiGi.Geometry.Drawing.Modify.Draw(thisSystem.Drawing.Graphics,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Drawing.Pen,bool).fill'></a>

`fill` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the interior of the polygonal face should be filled\.