#### [DiGi\.Geometry](DiGi.Geometry.Overview.md 'DiGi\.Geometry\.Overview')

## DiGi\.Geometry\.Planar Namespace
### Classes

<a name='DiGi.Geometry.Planar.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisCoordinate)'></a>

## Convert\.ToDiGi\(this Coordinate\) Method

Converts a [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') to a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D ToDiGi(this Coordinate coordinate);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisCoordinate).coordinate'></a>

`coordinate` [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')

The [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') instance to convert\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') object created from the coordinate values\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisGeometry)'></a>

## Convert\.ToDiGi\(this Geometry\) Method

Converts a [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') to an [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IGeometry2D? ToDiGi(this Geometry? geometry);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisGeometry).geometry'></a>

`geometry` [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry')

The [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') instance to convert\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')  
An [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') representation of the geometry, or `null` if the provided [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') is `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisGeometryCollection)'></a>

## Convert\.ToDiGi\(this GeometryCollection\) Method

Converts the specified [NetTopologySuite\.Geometries\.GeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometrycollection 'NetTopologySuite\.Geometries\.GeometryCollection') to a [GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.GeometryCollection2D? ToDiGi(this GeometryCollection? geometryCollection);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisGeometryCollection).geometryCollection'></a>

`geometryCollection` [NetTopologySuite\.Geometries\.GeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometrycollection 'NetTopologySuite\.Geometries\.GeometryCollection')

The [NetTopologySuite\.Geometries\.GeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometrycollection 'NetTopologySuite\.Geometries\.GeometryCollection') instance to convert\.

#### Returns
[GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D')  
A [GeometryCollection2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.GeometryCollection2D 'DiGi\.Geometry\.Planar\.Classes\.GeometryCollection2D') containing the converted elements, or `null` if the provided [NetTopologySuite\.Geometries\.GeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometrycollection 'NetTopologySuite\.Geometries\.GeometryCollection') is `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisLinearRing)'></a>

## Convert\.ToDiGi\(this LinearRing\) Method

Converts a [NetTopologySuite\.Geometries\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linearring 'NetTopologySuite\.Geometries\.LinearRing') to a [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? ToDiGi(this LinearRing? linearRing);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisLinearRing).linearRing'></a>

`linearRing` [NetTopologySuite\.Geometries\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linearring 'NetTopologySuite\.Geometries\.LinearRing')

The [NetTopologySuite\.Geometries\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linearring 'NetTopologySuite\.Geometries\.LinearRing') instance to convert\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisLineSegment)'></a>

## Convert\.ToDiGi\(this LineSegment\) Method

Converts a [NetTopologySuite\.Geometries\.LineSegment](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linesegment 'NetTopologySuite\.Geometries\.LineSegment') instance to a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? ToDiGi(this LineSegment? lineSegment);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisLineSegment).lineSegment'></a>

`lineSegment` [NetTopologySuite\.Geometries\.LineSegment](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linesegment 'NetTopologySuite\.Geometries\.LineSegment')

The [NetTopologySuite\.Geometries\.LineSegment](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linesegment 'NetTopologySuite\.Geometries\.LineSegment') instance to convert\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisLineString)'></a>

## Convert\.ToDiGi\(this LineString\) Method

Converts a [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString') to a [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polyline2D? ToDiGi(this LineString? linearString);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisLineString).linearString'></a>

`linearString` [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString')

The [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString') instance to convert\.

#### Returns
[Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')  
A [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') instance if the conversion is successful and contains at least 3 points; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisPoint)'></a>

## Convert\.ToDiGi\(this Point\) Method

Converts a [NetTopologySuite\.Geometries\.Point](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.point 'NetTopologySuite\.Geometries\.Point') to a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D ToDiGi(this Point point);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisPoint).point'></a>

`point` [NetTopologySuite\.Geometries\.Point](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.point 'NetTopologySuite\.Geometries\.Point')

The [NetTopologySuite\.Geometries\.Point](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.point 'NetTopologySuite\.Geometries\.Point') instance to convert\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') object created from the coordinates of the provided point\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisPolygon)'></a>

## Convert\.ToDiGi\(this Polygon\) Method

Converts the specified [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') to a [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? ToDiGi(this Polygon? polygon);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisPolygon).polygon'></a>

`polygon` [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')

The [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') instance to convert\.

#### Returns
[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') representation of the polygon, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') is null, empty, or cannot be converted\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Collections.Generic.IEnumerable_Coordinate_)'></a>

## Convert\.ToDiGi\(this IEnumerable\<Coordinate\>\) Method

Converts a collection of [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') objects to a list of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? ToDiGi(this System.Collections.Generic.IEnumerable<Coordinate>? coordinates);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Collections.Generic.IEnumerable_Coordinate_).coordinates'></a>

`coordinates` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<NetTopologySuite.Geometries.Coordinate>` containing the coordinates to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Point2D>` containing the converted points, or null if the input `IEnumerable<NetTopologySuite.Geometries.Coordinate>` is null\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.Point)'></a>

## Convert\.ToDiGi\(this Point\) Method

Converts a [System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point') instance to a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D ToDiGi(this System.Drawing.Point point);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.Point).point'></a>

`point` [System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point')

The [System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point') instance to convert\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance created from the provided [System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point')\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.PointF)'></a>

## Convert\.ToDiGi\(this PointF\) Method

Converts a [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF') instance to a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D ToDiGi(this System.Drawing.PointF pointF);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.PointF).pointF'></a>

`pointF` [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')

The [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF') instance to convert\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance created from the provided [System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.Rectangle)'></a>

## Convert\.ToDiGi\(this Rectangle\) Method

Converts a [System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle') to a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D ToDiGi(this System.Drawing.Rectangle rectangle);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.Rectangle).rectangle'></a>

`rectangle` [System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle')

The [System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle') instance to convert\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') created from the provided [System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle')\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.RectangleF)'></a>

## Convert\.ToDiGi\(this RectangleF\) Method

Converts a [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF') to a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D ToDiGi(this System.Drawing.RectangleF rectangleF);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.RectangleF).rectangleF'></a>

`rectangleF` [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF')

The [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF') instance to convert\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') instance created from the provided [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF')\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.Size)'></a>

## Convert\.ToDiGi\(this Size\) Method

Converts a [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size') object to a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D ToDiGi(this System.Drawing.Size size);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.Size).size'></a>

`size` [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size')

The [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size') instance to convert\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the dimensions of the provided [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size')\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.SizeF)'></a>

## Convert\.ToDiGi\(this SizeF\) Method

Converts a [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') instance to a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D ToDiGi(this System.Drawing.SizeF sizeF);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi(thisSystem.Drawing.SizeF).sizeF'></a>

`sizeF` [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF')

The [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') instance to convert\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') created from the width and height of the [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') instance\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi_Geometry2Ds(thisGeometry)'></a>

## Convert\.ToDiGi\_Geometry2Ds\(this Geometry\) Method

Converts a [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') of any dimension to a flat list of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects\.

Nested [NetTopologySuite\.Geometries\.GeometryCollection](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometrycollection 'NetTopologySuite\.Geometries\.GeometryCollection') instances (including [NetTopologySuite\.Geometries\.MultiPolygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multipolygon 'NetTopologySuite\.Geometries\.MultiPolygon'), [NetTopologySuite\.Geometries\.MultiLineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multilinestring 'NetTopologySuite\.Geometries\.MultiLineString') and [NetTopologySuite\.Geometries\.MultiPoint](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multipoint 'NetTopologySuite\.Geometries\.MultiPoint')) are flattened. Polygons convert to [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D'), linear rings to [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D'), two-point line strings to [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D'), longer line strings to [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') and points to [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D'). Empty components are skipped.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? ToDiGi_Geometry2Ds(this Geometry? geometry);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi_Geometry2Ds(thisGeometry).geometry'></a>

`geometry` [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry')

The [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') instance to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') objects \(possibly empty\), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided geometry is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi_Polygon2Ds(thisPolygon)'></a>

## Convert\.ToDiGi\_Polygon2Ds\(this Polygon\) Method

Converts a [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') to a list of [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? ToDiGi_Polygon2Ds(this Polygon? polygon);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi_Polygon2Ds(thisPolygon).polygon'></a>

`polygon` [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')

The [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') instance to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted polygons, or null if the provided [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') is null or has no exterior ring\.

<a name='DiGi.Geometry.Planar.Convert.ToDiGi_PolygonalFace2Ds(thisMultiPolygon)'></a>

## Convert\.ToDiGi\_PolygonalFace2Ds\(this MultiPolygon\) Method

Converts a [NetTopologySuite\.Geometries\.MultiPolygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multipolygon 'NetTopologySuite\.Geometries\.MultiPolygon') instance to a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? ToDiGi_PolygonalFace2Ds(this MultiPolygon? multiPolygon);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDiGi_PolygonalFace2Ds(thisMultiPolygon).multiPolygon'></a>

`multiPolygon` [NetTopologySuite\.Geometries\.MultiPolygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multipolygon 'NetTopologySuite\.Geometries\.MultiPolygon')

The [NetTopologySuite\.Geometries\.MultiPolygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multipolygon 'NetTopologySuite\.Geometries\.MultiPolygon') instance to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the converted [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects, or null if the input is null or cannot be processed\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Convert\.ToDrawing\(this BoundingBox2D\) Method

Converts the specified [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to a [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF')\.

```csharp
public static System.Nullable<System.Drawing.RectangleF> ToDrawing(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDrawing(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') instance to convert\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Drawing\.RectangleF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef 'System\.Drawing\.RectangleF') representing the bounding box, or `null` if the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') is null or its minimum point is null\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing(thisDiGi.Geometry.Planar.Classes.Point2D)'></a>

## Convert\.ToDrawing\(this Point2D\) Method

Converts a `Point2D?` to a `PointF?` for drawing purposes\.

```csharp
public static System.Nullable<System.Drawing.PointF> ToDrawing(this DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDrawing(thisDiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance to convert\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.PointF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pointf 'System\.Drawing\.PointF')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A `PointF?` representation of the point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided `Point2D?` is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Convert\.ToDrawing\(this Vector2D\) Method

Converts a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') instance to a [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') object\.

```csharp
public static System.Nullable<System.Drawing.SizeF> ToDrawing(this DiGi.Geometry.Planar.Classes.Vector2D vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDrawing(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') instance to convert\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Drawing\.SizeF](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.sizef 'System\.Drawing\.SizeF') representation of the [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Point(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Enums.RoundingMethod)'></a>

## Convert\.ToDrawing\_Point\(this Point2D, RoundingMethod\) Method

Converts a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a [System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point') using the specified rounding method\.

```csharp
public static System.Nullable<System.Drawing.Point> ToDrawing_Point(this DiGi.Geometry.Planar.Classes.Point2D point2D, DiGi.Core.Enums.RoundingMethod roundingMethod=DiGi.Core.Enums.RoundingMethod.Nearest);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Point(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Enums.RoundingMethod).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance to convert\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Point(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Core.Enums.RoundingMethod).roundingMethod'></a>

`roundingMethod` [DiGi\.Core\.Enums\.RoundingMethod](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod 'DiGi\.Core\.Enums\.RoundingMethod')

The [DiGi\.Core\.Enums\.RoundingMethod](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod 'DiGi\.Core\.Enums\.RoundingMethod') used to round the coordinates\. Defaults to [DiGi\.Core\.Enums\.RoundingMethod\.Nearest](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod.nearest 'DiGi\.Core\.Enums\.RoundingMethod\.Nearest')\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Drawing\.Point](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.point 'System\.Drawing\.Point') object if the conversion is successful and the rounding method is not undefined; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Rectangle(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Enums.RoundingMethod)'></a>

## Convert\.ToDrawing\_Rectangle\(this BoundingBox2D, RoundingMethod\) Method

Converts a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to a [System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle') using the specified rounding method\.

```csharp
public static System.Nullable<System.Drawing.Rectangle> ToDrawing_Rectangle(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D, DiGi.Core.Enums.RoundingMethod roundingMethod=DiGi.Core.Enums.RoundingMethod.Nearest);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Rectangle(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Enums.RoundingMethod).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') instance to convert\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Rectangle(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Enums.RoundingMethod).roundingMethod'></a>

`roundingMethod` [DiGi\.Core\.Enums\.RoundingMethod](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod 'DiGi\.Core\.Enums\.RoundingMethod')

The [DiGi\.Core\.Enums\.RoundingMethod](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod 'DiGi\.Core\.Enums\.RoundingMethod') used to round the coordinates\. Defaults to [DiGi\.Core\.Enums\.RoundingMethod\.Nearest](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod.nearest 'DiGi\.Core\.Enums\.RoundingMethod\.Nearest')\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Drawing\.Rectangle](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle 'System\.Drawing\.Rectangle') if the conversion is successful; otherwise, `null` if the [roundingMethod](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Convert.ToDrawing_Rectangle(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Enums.RoundingMethod).roundingMethod 'DiGi\.Geometry\.Planar\.Convert\.ToDrawing\_Rectangle\(this DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, DiGi\.Core\.Enums\.RoundingMethod\)\.roundingMethod') is [DiGi\.Core\.Enums\.RoundingMethod\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod.undefined 'DiGi\.Core\.Enums\.RoundingMethod\.Undefined') or the internal conversion fails\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Size(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Core.Enums.RoundingMethod)'></a>

## Convert\.ToDrawing\_Size\(this Vector2D, RoundingMethod\) Method

Converts a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') to a [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size') using the specified rounding method\.

```csharp
public static System.Nullable<System.Drawing.Size> ToDrawing_Size(this DiGi.Geometry.Planar.Classes.Vector2D vector2D, DiGi.Core.Enums.RoundingMethod roundingMethod=DiGi.Core.Enums.RoundingMethod.Nearest);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Size(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Core.Enums.RoundingMethod).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') instance to convert\.

<a name='DiGi.Geometry.Planar.Convert.ToDrawing_Size(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Core.Enums.RoundingMethod).roundingMethod'></a>

`roundingMethod` [DiGi\.Core\.Enums\.RoundingMethod](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod 'DiGi\.Core\.Enums\.RoundingMethod')

The [DiGi\.Core\.Enums\.RoundingMethod](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod 'DiGi\.Core\.Enums\.RoundingMethod') used to round the values\. Defaults to [DiGi\.Core\.Enums\.RoundingMethod\.Nearest](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod.nearest 'DiGi\.Core\.Enums\.RoundingMethod\.Nearest')\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Drawing\.Size](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.size 'System\.Drawing\.Size') object if the conversion is successful and the rounding method is not [DiGi\.Core\.Enums\.RoundingMethod\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.roundingmethod.undefined 'DiGi\.Core\.Enums\.RoundingMethod\.Undefined'); otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Point2D)'></a>

## Convert\.ToNTS\(this Point2D\) Method

Converts a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance to an NTS [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')\.

```csharp
public static Coordinate? ToNTS(this DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')  
A [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') instance if the provided [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Convert\.ToNTS\(this Point2D, double\) Method

Converts a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to an NTS [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate'), rounding the coordinates using the specified tolerance\.

```csharp
public static Coordinate? ToNTS(this DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance to convert\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value used for rounding the X and Y coordinates\.

#### Returns
[NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')  
A [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') object if the provided [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is not null; otherwise, returns null\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Polyline2D)'></a>

## Convert\.ToNTS\(this Polyline2D\) Method

Converts the specified [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') to an NTS [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString')\.

```csharp
public static LineString? ToNTS(this DiGi.Geometry.Planar.Classes.Polyline2D? polyline2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Polyline2D).polyline2D'></a>

`polyline2D` [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')

The [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString')  
An NTS [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Convert\.ToNTS\(this Segment2D\) Method

Converts the specified [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to an NTS [NetTopologySuite\.Geometries\.LineSegment](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linesegment 'NetTopologySuite\.Geometries\.LineSegment')\.

```csharp
public static LineSegment? ToNTS(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.LineSegment](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linesegment 'NetTopologySuite\.Geometries\.LineSegment')  
A [NetTopologySuite\.Geometries\.LineSegment](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linesegment 'NetTopologySuite\.Geometries\.LineSegment') if the [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') and its start and end points are not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## Convert\.ToNTS\(this IGeometry2D\) Method

Converts an [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') instance to a [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') object\.

```csharp
public static Geometry? ToNTS(this DiGi.Geometry.Planar.Interfaces.IGeometry2D? sAMGeometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Interfaces.IGeometry2D).sAMGeometry2D'></a>

`sAMGeometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') geometry to convert\.

#### Returns
[NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry')  
A [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') representation of the input geometry, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Convert\.ToNTS\(this IPolygonal2D\) Method

Converts an [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to a NetTopologySuite [NetTopologySuite\.Geometries\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linearring 'NetTopologySuite\.Geometries\.LinearRing')\.

```csharp
public static LinearRing? ToNTS(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linearring 'NetTopologySuite\.Geometries\.LinearRing')  
A [NetTopologySuite\.Geometries\.LinearRing](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linearring 'NetTopologySuite\.Geometries\.LinearRing') if the conversion is successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Convert\.ToNTS\(this IPolygonalFace2D\) Method

Converts an [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') instance to a NetTopologySuite [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')\.

```csharp
public static Polygon? ToNTS(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')  
A [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') representing the polygonal face, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') is null or its external edge cannot be converted\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Convert\.ToNTS\(this IEnumerable\<Point2D\>\) Method

Converts a collection of Point2D objects to a list of Coordinate objects\.

```csharp
public static System.Collections.Generic.List<Coordinate>? ToNTS(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The IEnumerable\<Point2D\> containing the points to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Coordinate>` containing the converted coordinates, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is null\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS_Coordinates(thisDiGi.Geometry.Planar.Classes.Segmentable2D,bool)'></a>

## Convert\.ToNTS\_Coordinates\(this Segmentable2D, bool\) Method

Converts the points of a [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') to an array of NTS [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') objects without cloning the points\.

```csharp
public static Coordinate[]? ToNTS_Coordinates(this DiGi.Geometry.Planar.Classes.Segmentable2D? segmentable2D, bool close);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS_Coordinates(thisDiGi.Geometry.Planar.Classes.Segmentable2D,bool).segmentable2D'></a>

`segmentable2D` [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D')

The [Segmentable2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segmentable2D 'DiGi\.Geometry\.Planar\.Classes\.Segmentable2D') instance to convert\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS_Coordinates(thisDiGi.Geometry.Planar.Classes.Segmentable2D,bool).close'></a>

`close` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the first coordinate is appended at the end to close the ring\.

#### Returns
[NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [NetTopologySuite\.Geometries\.Coordinate](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.coordinate 'NetTopologySuite\.Geometries\.Coordinate') objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if there are no points\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS_LineString(thisDiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Convert\.ToNTS\_LineString\(this Segment2D\) Method

Converts the specified [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to an NTS [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString')\.

```csharp
public static LineString? ToNTS_LineString(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS_LineString(thisDiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString')  
An NTS [NetTopologySuite\.Geometries\.LineString](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.linestring 'NetTopologySuite\.Geometries\.LineString') if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Convert.ToNTS_Polygon(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Convert\.ToNTS\_Polygon\(this IPolygonal2D\) Method

Converts the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to a NetTopologySuite [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')\.

```csharp
public static Polygon? ToNTS_Polygon(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNTS_Polygon(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to convert\.

#### Returns
[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')  
A [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') object if the provided [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Convert.ToNumerics(thisDiGi.Geometry.Planar.Classes.Coordinate2D)'></a>

## Convert\.ToNumerics\(this Coordinate2D\) Method

Converts a [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') instance to a nullable [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')\.

```csharp
public static System.Nullable<System.Numerics.Vector2> ToNumerics(this DiGi.Geometry.Planar.Classes.Coordinate2D coordinate2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Convert.ToNumerics(thisDiGi.Geometry.Planar.Classes.Coordinate2D).coordinate2D'></a>

`coordinate2D` [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D')

The [Coordinate2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Coordinate2D 'DiGi\.Geometry\.Planar\.Classes\.Coordinate2D') instance to convert\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2') containing the X and Y coordinates, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [coordinate2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Convert.ToNumerics(thisDiGi.Geometry.Planar.Classes.Coordinate2D).coordinate2D 'DiGi\.Geometry\.Planar\.Convert\.ToNumerics\(this DiGi\.Geometry\.Planar\.Classes\.Coordinate2D\)\.coordinate2D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Geometry.Planar.Create.AddUniqueByDistance(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Create\.AddUniqueByDistance\(List\<Point2D\>, Point2D, double\) Method

Adds a point to a collection unless a point within the squared tolerance already exists\.

```csharp
private static bool AddUniqueByDistance(System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D> point2Ds, DiGi.Geometry.Planar.Classes.Point2D point2D, double tolerance_Squared);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.AddUniqueByDistance(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The accumulated points\.

<a name='DiGi.Geometry.Planar.Create.AddUniqueByDistance(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The candidate point\.

<a name='DiGi.Geometry.Planar.Create.AddUniqueByDistance(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance_Squared'></a>

`tolerance_Squared` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The squared distance tolerance used to detect duplicates\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was added; otherwise, false\.

<a name='DiGi.Geometry.Planar.Create.AdjacencyGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double)'></a>

## Create\.AdjacencyGraph\(this IEnumerable\<ISegmentable2D\>, double\) Method

Creates an adjacency graph from a collection of segmentable geometries\.

```csharp
public static AdjacencyGraph<DiGi.Geometry.Planar.Classes.Point2D,Edge<DiGi.Geometry.Planar.Classes.Point2D>>? AdjacencyGraph(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.AdjacencyGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable geometries\.

<a name='DiGi.Geometry.Planar.Create.AdjacencyGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for rounding points\.

#### Returns
[QuikGraph\.AdjacencyGraph](https://learn.microsoft.com/en-us/dotnet/api/quikgraph.adjacencygraph 'QuikGraph\.AdjacencyGraph')  
An adjacency graph representing the connectivity; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.BooleanOperationResult2D(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Create\.BooleanOperationResult2D\(this BooleanOpertaionType, IPolygonalFace2D, IPolygonalFace2D\) Method

Calculates the 2D boolean operation result between two polygonal faces based on the specified operation type\.

```csharp
public static DiGi.Geometry.Planar.Classes.BooleanOperationResult2D? BooleanOperationResult2D(this DiGi.Geometry.Core.Enums.BooleanOpertaionType booleanOpertaionType, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.BooleanOperationResult2D(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).booleanOpertaionType'></a>

`booleanOpertaionType` [BooleanOpertaionType](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.BooleanOpertaionType 'DiGi\.Geometry\.Core\.Enums\.BooleanOpertaionType')

The type of the boolean operation\.

<a name='DiGi.Geometry.Planar.Create.BooleanOperationResult2D(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The first polygonal face\.

<a name='DiGi.Geometry.Planar.Create.BooleanOperationResult2D(thisDiGi.Geometry.Core.Enums.BooleanOpertaionType,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The second polygonal face\.

#### Returns
[BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D')  
A [BooleanOperationResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BooleanOperationResult2D 'DiGi\.Geometry\.Planar\.Classes\.BooleanOperationResult2D') containing the result of the operation, or null if the operation type is not supported\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double)'></a>

## Create\.BoundingBox2D\(this Point2D, double, double\) Method

Creates a bounding box with specified width and height, centered at the given point\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox2D(this DiGi.Geometry.Planar.Classes.Point2D? center, double width, double height);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double).center'></a>

`center` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The center point of the bounding box\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the bounding box\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the bounding box\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new BoundingBox2D; otherwise, null if any input is invalid\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Core.Enums.Corner)'></a>

## Create\.BoundingBox2D\(this Point2D, double, double, Corner\) Method

Creates a bounding box with specified width and height, using the point as a corner\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox2D(this DiGi.Geometry.Planar.Classes.Point2D? point2D, double width, double height, DiGi.Geometry.Core.Enums.Corner corner);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Core.Enums.Corner).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The anchor point\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Core.Enums.Corner).width'></a>

`width` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The width of the bounding box\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Core.Enums.Corner).height'></a>

`height` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The height of the bounding box\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D(thisDiGi.Geometry.Planar.Classes.Point2D,double,double,DiGi.Geometry.Core.Enums.Corner).corner'></a>

`corner` [Corner](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Corner 'DiGi\.Geometry\.Core\.Enums\.Corner')

The corner that the specified point represents\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new BoundingBox2D; otherwise, null if any input is invalid\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D_T_(thisSystem.Collections.Generic.IEnumerable_T_,double)'></a>

## Create\.BoundingBox2D\<T\>\(this IEnumerable\<T\>, double\) Method

Creates a bounding box that encompasses all provided boundable geometries\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D? BoundingBox2D<T>(this System.Collections.Generic.IEnumerable<T>? boundable2Ds, double offset=0.0)
    where T : DiGi.Geometry.Planar.Interfaces.IBoundable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

A type that implements IBoundable2D\.
#### Parameters

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).boundable2Ds'></a>

`boundable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.BoundingBox2D_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Create\.BoundingBox2D\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of boundable geometries\.

<a name='DiGi.Geometry.Planar.Create.BoundingBox2D_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

An optional offset to apply to the resulting bounding box\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A BoundingBox2D that encompasses all inputs; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.CoordinateSystem2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Create\.CoordinateSystem2D\(this Point2D, Vector2D\) Method

Creates a coordinate system based on an origin and a Y\-axis vector\.

```csharp
public static DiGi.Geometry.Planar.Classes.CoordinateSystem2D? CoordinateSystem2D(this DiGi.Geometry.Planar.Classes.Point2D? origin, DiGi.Geometry.Planar.Classes.Vector2D? axisY);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.CoordinateSystem2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the coordinate system\.

<a name='DiGi.Geometry.Planar.Create.CoordinateSystem2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D).axisY'></a>

`axisY` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The vector representing the Y\-axis\.

#### Returns
[CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D')  
A new CoordinateSystem2D; otherwise, null if any input is null\.

<a name='DiGi.Geometry.Planar.Create.DifferenceResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Create\.DifferenceResult2D\(this IPolygonalFace2D, IPolygonalFace2D\) Method

Calculates the 2D boolean difference between two polygonal faces\.

```csharp
public static DiGi.Geometry.Planar.Classes.DifferenceResult2D? DifferenceResult2D(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.DifferenceResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The first polygonal face \(from which to subtract\)\.

<a name='DiGi.Geometry.Planar.Create.DifferenceResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The second polygonal face \(to subtract\)\.

#### Returns
[DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D')  
A [DifferenceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.DifferenceResult2D 'DiGi\.Geometry\.Planar\.Classes\.DifferenceResult2D') containing the difference geometry, or null if polygonalFace2D\_1 is null or the computation fails\.

### Remarks

Invalid (self-intersecting) inputs are repaired before the overlay is computed.

If the first face is degenerate (zero area, collapsing under repair), the difference is lower-dimensional: the parts of the face boundary linework lying outside the second face are returned as [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)')/[Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')/[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') elements.

<a name='DiGi.Geometry.Planar.Create.Geometry2Ds(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,double)'></a>

## Create\.Geometry2Ds\(IEnumerable\<IGeometry2D\>, double\) Method

Simplifies a collection of geometries by merging similar ones and decomposing them into basic primitives \(points, segments, polylines, polygons, etc\.\)\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? Geometry2Ds(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IGeometry2D>? geometry2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Geometry2Ds(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,double).geometry2Ds'></a>

`geometry2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries to simplify\.

<a name='DiGi.Geometry.Planar.Create.Geometry2Ds(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IGeometry2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for similarity and intersection checks\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A simplified list of unique geometries; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Create\.IntersectionGeometry2D\(Line2D, Segment2D, double\) Method

Computes the raw intersection geometry between a line and a segment without allocating an [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') or cloning redundantly\.

```csharp
private static DiGi.Geometry.Planar.Interfaces.IGeometry2D? IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Line2D line2D, DiGi.Geometry.Planar.Classes.Segment2D segment2D, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line \(must be non\-null\)\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment \(must be non\-null\)\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')  
A freshly owned [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)') when the segment lies on the line, a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') when they cross, or null when they do not intersect\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double,bool)'></a>

## Create\.IntersectionGeometry2D\(Segment2D, Segment2D, double, bool\) Method

Computes the raw intersection geometry between two segments without allocating an [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') or cloning redundantly\.

```csharp
private static DiGi.Geometry.Planar.Interfaces.IGeometry2D? IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Segment2D segment2D_1, DiGi.Geometry.Planar.Classes.Segment2D segment2D_2, double tolerance, out bool handled);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double,bool).segment2D_1'></a>

`segment2D_1` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The first segment \(must be non\-null\)\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double,bool).segment2D_2'></a>

`segment2D_2` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The second segment \(must be non\-null\)\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double,bool).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

<a name='DiGi.Geometry.Planar.Create.IntersectionGeometry2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double,bool).handled'></a>

`handled` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') only for the degenerate fall\-through case where no intersection topology could be resolved; otherwise [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')  
A freshly owned [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') or [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)'), or null when the segments do not intersect\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D,double)'></a>

## Create\.IntersectionResult2D\(this Line2D, Line2D, double\) Method

Calculates the intersection result of two lines\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Classes.Line2D? line2D_1, DiGi.Geometry.Planar.Classes.Line2D? line2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D,double).line2D_1'></a>

`line2D_1` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The first line\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D,double).line2D_2'></a>

`line2D_2` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The second line\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Line2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Create\.IntersectionResult2D\(this Line2D, Segment2D, double\) Method

Calculates the intersection result of a line and a segment\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Classes.Line2D? line2D, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.IntersectionResult2D\(this Line2D, IEnumerable\<Segment2D\>, double\) Method

Calculates the intersection result of a line and a collection of segments\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Classes.Line2D? line2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing all unique intersection geometries; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Create\.IntersectionResult2D\(this Segment2D, Segment2D, double\) Method

Calculates the intersection result of two segments\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D_1, DiGi.Geometry.Planar.Classes.Segment2D? segment2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D_1'></a>

`segment2D_1` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The first segment\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D_2'></a>

`segment2D_2` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The second segment\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.IntersectionResult2D\(this Segment2D, IEnumerable\<Segment2D\>, double\) Method

Calculates the intersection result of a segment and a collection of segments\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment to check\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments to intersect with\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing all unique intersection geometries; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Create\.IntersectionResult2D\(this IPolygonalFace2D, ILinear2D, double\) Method

Calculates the intersection result of a polygonal face and a linear geometry\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D, DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The polygonal face\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D'></a>

`linear2D` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The linear geometry\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Create\.IntersectionResult2D\(this IPolygonalFace2D, IPolygonalFace2D\) Method

Calculates the intersection result of two polygonal faces\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The first polygonal face\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The second polygonal face\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null or the computation fails\.

### Remarks

Invalid (self-intersecting) inputs are repaired before the overlay is computed.

Boundary-only intersections are lower-dimensional: shared edges are returned as [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)')/[Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') elements and touching vertices as [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') elements.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Line2D,double)'></a>

## Create\.IntersectionResult2D\(this ISegmentable2D, Line2D, double\) Method

Calculates the intersection result of a segmentable geometry and a line\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, DiGi.Geometry.Planar.Classes.Line2D? line2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Line2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Line2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Line2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Create\.IntersectionResult2D\(this ISegmentable2D, ISegmentable2D, double\) Method

Calculates the intersection result of two segmentable geometries\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Create\.IntersectionResult2D\(this ISegmentable2D, double\) Method

Calculates the intersection result of a segmentable geometry with itself or other segments within it\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the self\-intersection geometries; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,int,double)'></a>

## Create\.IntersectionResult2D\(this ISegmentable2D, int, double\) Method

Calculates the intersection result of a segmentable geometry with itself or other segments within it, up to a maximum number of intersections\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, int maxCount, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,int,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,int,double).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of intersections to find\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing the self\-intersection geometries; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.IntersectionResult2D\(this IEnumerable\<Segment2D\>, IEnumerable\<Segment2D\>, double\) Method

Calculates the intersection result between two collections of segments\.

```csharp
public static DiGi.Geometry.Planar.Classes.IntersectionResult2D? IntersectionResult2D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds_1, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds_1'></a>

`segment2Ds_1` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The first collection of segments\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds_2'></a>

`segment2Ds_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The second collection of segments\.

<a name='DiGi.Geometry.Planar.Create.IntersectionResult2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An IntersectionResult2D containing all unique intersection geometries; otherwise, null if either input is null\.

<a name='DiGi.Geometry.Planar.Create.Line2D(thisDiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Create\.Line2D\(this Point2D, double\) Method

Creates a line with the specified origin and angle\.

```csharp
public static DiGi.Geometry.Planar.Classes.Line2D? Line2D(this DiGi.Geometry.Planar.Classes.Point2D? origin, double angle);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Line2D(thisDiGi.Geometry.Planar.Classes.Point2D,double).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The origin point of the line\.

<a name='DiGi.Geometry.Planar.Create.Line2D(thisDiGi.Geometry.Planar.Classes.Point2D,double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle of the line in radians\.

#### Returns
[Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')  
A new Line2D; otherwise, null if origin is null or angle is invalid\.

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Line2D)'></a>

## Create\.LinearEquation\(this Line2D\) Method

Creates a linear equation from a line\.

```csharp
public static DiGi.Math.Classes.LinearEquation? LinearEquation(this DiGi.Geometry.Planar.Classes.Line2D? line2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Line2D).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line\.

#### Returns
[DiGi\.Math\.Classes\.LinearEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.linearequation 'DiGi\.Math\.Classes\.LinearEquation')  
A LinearEquation; otherwise, null if the line is null or has no origin\.

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Create\.LinearEquation\(this Point2D, Point2D\) Method

Creates a linear equation from two points\.

```csharp
public static DiGi.Math.Classes.LinearEquation? LinearEquation(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first point\.

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second point\.

#### Returns
[DiGi\.Math\.Classes\.LinearEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.linearequation 'DiGi\.Math\.Classes\.LinearEquation')  
A LinearEquation; otherwise, null if points are identical or either is null\.

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Segment2D)'></a>

## Create\.LinearEquation\(this Segment2D\) Method

Creates a linear equation from a segment\.

```csharp
public static DiGi.Math.Classes.LinearEquation? LinearEquation(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.LinearEquation(thisDiGi.Geometry.Planar.Classes.Segment2D).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment\.

#### Returns
[DiGi\.Math\.Classes\.LinearEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.linearequation 'DiGi\.Math\.Classes\.LinearEquation')  
A LinearEquation; otherwise, null if the segment is null or has missing endpoints\.

<a name='DiGi.Geometry.Planar.Create.Mesh2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double)'></a>

## Create\.Mesh2D\(this IPolygonalFace2D, double\) Method

Converts an [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') to a [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Mesh2D? Mesh2D(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Mesh2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') instance to convert\.

<a name='DiGi.Geometry.Planar.Create.Mesh2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the conversion\.

#### Returns
[Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')  
A [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') object if the conversion is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Create.Mesh2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Triangle2D_,double)'></a>

## Create\.Mesh2D\(this IEnumerable\<Triangle2D\>, double\) Method

Creates a [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') from a collection of [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Mesh2D? Mesh2D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Triangle2D>? triangle2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Mesh2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Triangle2D_,double).triangle2Ds'></a>

`triangle2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') objects to be converted into a mesh\.

<a name='DiGi.Geometry.Planar.Create.Mesh2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Triangle2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the minimum area threshold; triangles with an area smaller than this value are ignored\.

#### Returns
[Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D')  
A [Mesh2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Mesh2D 'DiGi\.Geometry\.Planar\.Classes\.Mesh2D') object if valid triangles are provided; otherwise, null\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double,double,double,double,int)'></a>

## Create\.Point2Ds\(double, double, double, double, int\) Method

Generates a list of random points within the specified coordinate range\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(double x_min, double y_min, double x_max, double y_max, int count);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double,double,double,double,int).x_min'></a>

`x_min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum X coordinate\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double,double,double,double,int).y_min'></a>

`y_min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum Y coordinate\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double,double,double,double,int).x_max'></a>

`x_max` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum X coordinate\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double,double,double,double,int).y_max'></a>

`y_max` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum Y coordinate\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double,double,double,double,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to generate; \-1 returns null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random Point2D objects, or null if count is \-1\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double[])'></a>

## Create\.Point2Ds\(double\[\]\) Method

Creates a list of points from an array of coordinates\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(params double[]? values);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Point2Ds(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An array of X and Y coordinates \(must have an even length\)\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Point2D objects, or null if the input is null or has an invalid length\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int)'></a>

## Create\.Point2Ds\(this BoundingBox2D, int\) Method

Generates a list of random points within the specified bounding box\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int count);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Point2Ds(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box defining the area\.

<a name='DiGi.Geometry.Planar.Create.Point2Ds(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to generate; \-1 returns null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random Point2D objects, or null if parameters are invalid\.

<a name='DiGi.Geometry.Planar.Create.Polygon2Ds(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Create\.Polygon2Ds\(this ISegmentable2D, double\) Method

Creates a list of polygons from a segmentable geometry\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Polygon2Ds(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygon2Ds(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.Polygon2Ds(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for identifying loops\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Polygon2D objects; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.Polygon2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.Polygon2Ds\(this IEnumerable\<Segment2D\>, double\) Method

Creates a list of polygons from a collection of segments\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Polygon2Ds(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygon2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments\.

<a name='DiGi.Geometry.Planar.Create.Polygon2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for connecting segments into loops\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Polygon2D objects; otherwise, null if inputs are invalid or no polygons can be formed\.

<a name='DiGi.Geometry.Planar.Create.Polygonal2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Create\.Polygonal2D\(this IPolygonal2D, double\) Method

Simplifies or recreates the [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance using a specified distance tolerance\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Polygonal2D(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygonal2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to be processed\.

<a name='DiGi.Geometry.Planar.Create.Polygonal2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance\.

#### Returns
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
An [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance if the input is not null; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Create.Polygonal2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Create\.Polygonal2D\(this IEnumerable\<Point2D\>, double\) Method

Creates an [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance from a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Polygonal2D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygonal2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects used to define the polygon\.

<a name='DiGi.Geometry.Planar.Create.Polygonal2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for distance calculations\.

#### Returns
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
An [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance if the collection is not null and contains at least three points; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2D(DiGi.Geometry.Planar.Classes.Point2D[])'></a>

## Create\.PolygonalFace2D\(Point2D\[\]\) Method

Creates a [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') from the specified array of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? PolygonalFace2D(params DiGi.Geometry.Planar.Classes.Point2D[]? points);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2D(DiGi.Geometry.Planar.Classes.Point2D[]).points'></a>

`points` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An array of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects that define the vertices of the polygonal face\.

#### Returns
[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance if the provided [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') array contains at least three points; otherwise, null\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double)'></a>

## Create\.PolygonalFace2D\(this IPolygonal2D, IEnumerable\<IPolygonal2D\>, double\) Method

Creates a [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') using the specified external boundary and optional internal boundaries\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? PolygonalFace2D(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? externalEdge, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? internalEdges=null, double tolerace=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double).externalEdge'></a>

`externalEdge` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') that defines the external boundary of the face\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double).internalEdges'></a>

`internalEdges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the internal boundaries \(holes\) of the face\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double).tolerace'></a>

`tolerace` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine if an internal boundary is inside the external boundary\.

#### Returns
[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance if the [externalEdge](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.PolygonalFace2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double).externalEdge 'DiGi\.Geometry\.Planar\.Create\.PolygonalFace2D\(this DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D\>, double\)\.externalEdge') is not null; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.PolygonalFace2Ds\(this IEnumerable\<Segment2D\>, double\) Method

Creates a list of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects from a collection of [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)') segments\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? PolygonalFace2Ds(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)') segments to process\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for distance calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects if successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double)'></a>

## Create\.PolygonalFace2Ds\(this IEnumerable\<IPolygonal2D\>, double\) Method

Converts a collection of [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') objects to a list of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? PolygonalFace2Ds(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? polygonal2Ds, double tolerace=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double).polygonal2Ds'></a>

`polygonal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') objects to convert\.

<a name='DiGi.Geometry.Planar.Create.PolygonalFace2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonal2D_,double).tolerace'></a>

`tolerace` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for the conversion\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Create.Polygons(thisMultiPolygon)'></a>

## Create\.Polygons\(this MultiPolygon\) Method

Extracts a list of polygons from an NTS MultiPolygon\.

```csharp
public static System.Collections.Generic.List<Polygon>? Polygons(this MultiPolygon? multiPolygon);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygons(thisMultiPolygon).multiPolygon'></a>

`multiPolygon` [NetTopologySuite\.Geometries\.MultiPolygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.multipolygon 'NetTopologySuite\.Geometries\.MultiPolygon')

The MultiPolygon to extract polygons from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of NetTopologySuite Polygons; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.Polygons(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.Polygons\(this IEnumerable\<Segment2D\>, double\) Method

Creates a list of NTS polygons from a collection of segments\.

```csharp
public static System.Collections.Generic.List<Polygon>? Polygons(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygons(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments\.

<a name='DiGi.Geometry.Planar.Create.Polygons(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for connecting segments into loops\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of NetTopologySuite Polygons; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.Polygons(thisSystem.Collections.Generic.IEnumerable_Geometry_,double)'></a>

## Create\.Polygons\(this IEnumerable\<Geometry\>, double\) Method

Creates a list of NTS polygons from a collection of geometries by nodalizing and polygonizing them\.

```csharp
public static System.Collections.Generic.List<Polygon>? Polygons(this System.Collections.Generic.IEnumerable<Geometry>? geometries, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polygons(thisSystem.Collections.Generic.IEnumerable_Geometry_,double).geometries'></a>

`geometries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of geometries \(lines, rings, etc\.\)\.

<a name='DiGi.Geometry.Planar.Create.Polygons(thisSystem.Collections.Generic.IEnumerable_Geometry_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance used for nodalization\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of NetTopologySuite Polygons; otherwise, null if input is null\.

<a name='DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double)'></a>

## Create\.Polyline2Ds\<T\>\(this IEnumerable\<T\>, Point2D, bool, double\) Method

Creates a list of polylines from a collection of segmentable geometries\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polyline2D>? Polyline2Ds<T>(this System.Collections.Generic.IEnumerable<T>? segmentable2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D_Start=null, bool split=true, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double).T'></a>

`T`

A type that implements ISegmentable2D\.
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double).T 'DiGi\.Geometry\.Planar\.Create\.Polyline2Ds\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, bool, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable geometries to convert into polylines\.

<a name='DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double).point2D_Start'></a>

`point2D_Start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Optional starting point for the first polyline\.

<a name='DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double).split'></a>

`split` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to split segmentable geometries into basic segments before processing\.

<a name='DiGi.Geometry.Planar.Create.Polyline2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for connecting segments\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Polyline2D objects; otherwise, null if the input is empty or invalid\.

<a name='DiGi.Geometry.Planar.Create.PolynomialEquation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,int)'></a>

## Create\.PolynomialEquation\(this IEnumerable\<Point2D\>, int\) Method

Fits a polynomial equation to the specified collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static DiGi.Math.Classes.PolynomialEquation? PolynomialEquation(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, int order=-1);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.PolynomialEquation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,int).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects used for the fit\.

<a name='DiGi.Geometry.Planar.Create.PolynomialEquation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,int).order'></a>

`order` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') order of the polynomial equation to be created\.

#### Returns
[DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation')  
A [PolynomialEquation\(this IEnumerable&lt;Point2D&gt;, int\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.PolynomialEquation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,int) 'DiGi\.Geometry\.Planar\.Create\.PolynomialEquation\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Classes\.Point2D\>, int\)') if the input collection is not null and contains at least two points; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double)'></a>

## Create\.Rectangle2D\(this Rectangle2D, Rectangle2D, double\) Method

Creates the minimum area bounding rectangle that encompasses two existing rectangles\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D_1, DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double).rectangle2D_1'></a>

`rectangle2D_1` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The first rectangle\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double).rectangle2D_2'></a>

`rectangle2D_2` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The second rectangle\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Classes.Rectangle2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A Rectangle2D that bounds both inputs; otherwise, null if either is null\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double)'></a>

## Create\.Rectangle2D\(this IPolygonalFace2D, double\) Method

Creates the minimum area bounding rectangle for a polygonal face's external edge\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The polygonal face\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A Rectangle2D that bounds the outer boundary; otherwise, null if no external edge exists\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Create\.Rectangle2D\(this ISegmentable2D, double\) Method

Creates the minimum area bounding rectangle for a single segmentable geometry\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A Rectangle2D that bounds the geometry; otherwise, null if points cannot be extracted\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Create\.Rectangle2D\(this IEnumerable\<Point2D\>, Vector2D\) Method

Creates a rectangle that bounds the given points along the specified direction\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, DiGi.Geometry.Planar.Classes.Vector2D? direction);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Vector2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points to bound\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Vector2D).direction'></a>

`direction` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The primary orientation vector for the rectangle's height\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A Rectangle2D that bounds the points; otherwise, null if inputs are invalid\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Create\.Rectangle2D\(this IEnumerable\<Point2D\>, double\) Method

Creates the minimum area bounding rectangle for a set of points\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for calculations\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
The smallest Rectangle2D that contains all points; otherwise, null if too few points are provided\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double)'></a>

## Create\.Rectangle2D\(this IEnumerable\<ISegmentable2D\>, double\) Method

Creates the minimum area bounding rectangle for a set of segmentable geometries\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Rectangle2D(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable geometries\.

<a name='DiGi.Geometry.Planar.Create.Rectangle2D(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A Rectangle2D that bounds all points in the geometries; otherwise, null if no points are found\.

<a name='DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Create\.Segment2D\(this Line2D, IPolygonal2D, double\) Method

Creates a segment from the intersection of a line and a polygonal geometry\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Segment2D(this DiGi.Geometry.Planar.Classes.Line2D? line2D, DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The line to intersect\.

<a name='DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry to intersect with\.

<a name='DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A Segment2D resulting from the intersection; otherwise, null\.

<a name='DiGi.Geometry.Planar.Create.Segment2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Create\.Segment2Ds\(this IEnumerable\<Point2D\>, bool\) Method

Converts a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects into a list of [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Segment2Ds(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool closed=false);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Segment2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points to process\.

<a name='DiGi.Geometry.Planar.Create.Segment2Ds(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).closed'></a>

`closed` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the sequence should be closed by connecting the last point back to the first point\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Segment2D\(this Line2D, IPolygonal2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.Segment2D(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D,double) 'DiGi\.Geometry\.Planar\.Create\.Segment2D\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, double\)') objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is null\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Create\.SegmentableTraceResult2D\(this Point2D, Vector2D, IEnumerable\<Segment2D\>, double\) Method

Performs a segmentable trace operation and returns the first result found\.

```csharp
public static DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D? SegmentableTraceResult2D(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The starting [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for the trace\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') of the trace\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the segments to be traced\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance for the operation\.

#### Returns
[SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D')  
The first [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D') found, or null if no result exists\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double)'></a>

## Create\.SegmentableTraceResult2D\(this Point2D, Vector2D, IEnumerable\<ISegmentable2D\>, double\) Method

Traces a ray from a point in a given direction through a collection of segmentable 2D objects and returns the first intersection result\.

```csharp
public static DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D? SegmentableTraceResult2D(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The starting [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for the trace operation\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the direction of the trace\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the objects to be traced\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2D(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the operation\.

#### Returns
[SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D')  
The first [SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D') found, or null if no intersection occurs within the specified tolerance\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double)'></a>

## Create\.SegmentableTraceResult2Ds\(this Point2D, Vector2D, IEnumerable\<Segment2D\>, int, double\) Method

Traces a path from a starting point in a specified direction through a collection of 2D segments, accounting for bounces and distance tolerance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D>? SegmentableTraceResult2Ds(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, int bounces=0, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The starting [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for the trace operation\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the direction of the trace\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the segments to be traced against\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).bounces'></a>

`bounces` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') number of times the trace may bounce off segments\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the results of the trace, or `null` if any of the required inputs are null\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,int,double)'></a>

## Create\.SegmentableTraceResult2Ds\(this Point2D, Vector2D, IEnumerable\<ISegmentable2D\>, int, double\) Method

Traces a ray from the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') in the direction of the provided [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') through a collection of [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D>? SegmentableTraceResult2Ds(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, int bounces=0, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,int,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The starting [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for the trace\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,int,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') of the trace\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,int,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the objects to be traced against\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,int,double).bounces'></a>

`bounces` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of times the trace should bounce off surfaces as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

<a name='DiGi.Geometry.Planar.Create.SegmentableTraceResult2Ds(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for intersection calculations as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[SegmentableTraceResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.SegmentableTraceResult2D 'DiGi\.Geometry\.Planar\.Classes\.SegmentableTraceResult2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the results of the trace, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if any required input is null\.

<a name='DiGi.Geometry.Planar.Create.UndirectedGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double)'></a>

## Create\.UndirectedGraph\(this IEnumerable\<ISegmentable2D\>, double\) Method

Creates an undirected graph from a collection of segmentable 2D objects using a specified distance tolerance\.

```csharp
public static UndirectedGraph<DiGi.Geometry.Planar.Classes.Point2D,Edge<DiGi.Geometry.Planar.Classes.Point2D>>? UndirectedGraph(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.UndirectedGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of objects to be converted into a graph\.

<a name='DiGi.Geometry.Planar.Create.UndirectedGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for point comparison\.

#### Returns
[QuikGraph\.UndirectedGraph](https://learn.microsoft.com/en-us/dotnet/api/quikgraph.undirectedgraph 'QuikGraph\.UndirectedGraph')  
An `UndirectedGraph<Point2D, Edge<Point2D>>` representing the network of points and edges, or `null` if the [segmentable2Ds](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.UndirectedGraph(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds 'DiGi\.Geometry\.Planar\.Create\.UndirectedGraph\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\>, double\)\.segmentable2Ds') collection is `null`\.

<a name='DiGi.Geometry.Planar.Create.UnionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Create\.UnionResult2D\(this IPolygonalFace2D, IPolygonalFace2D\) Method

Calculates the 2D boolean union between two polygonal faces\.

```csharp
public static DiGi.Geometry.Planar.Classes.UnionResult2D? UnionResult2D(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.UnionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The first polygonal face\.

<a name='DiGi.Geometry.Planar.Create.UnionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The second polygonal face\.

#### Returns
[UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D')  
A [UnionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.UnionResult2D 'DiGi\.Geometry\.Planar\.Classes\.UnionResult2D') containing the union geometry, or null if both inputs are null or the computation fails\.

### Remarks

Invalid (self-intersecting) inputs are repaired before the overlay is computed. Disjoint inputs produce a result containing both faces.

<a name='DiGi.Geometry.Planar.Create.Vector2D(DiGi.Geometry.Core.Enums.Alignment)'></a>

## Create\.Vector2D\(Alignment\) Method

Calculates a unit vector based on the specified alignment\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(DiGi.Geometry.Core.Enums.Alignment alignment);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Vector2D(DiGi.Geometry.Core.Enums.Alignment).alignment'></a>

`alignment` [Alignment](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Alignment 'DiGi\.Geometry\.Core\.Enums\.Alignment')

The desired alignment\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A unit Vector2D corresponding to the alignment; otherwise, null\.

<a name='DiGi.Geometry.Planar.Create.Vector2D(double)'></a>

## Create\.Vector2D\(double\) Method

Calculates unit vector for given angle \[rad\]

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(double angle);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Vector2D(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

angle to X axis counted counterclockwise \[rad\]

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
Unit Vector2D

<a name='DiGi.Geometry.Planar.Create.Vector2D(double,double)'></a>

## Create\.Vector2D\(double, double\) Method

Calculates a vector for a given angle and length\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(double angle, double length);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Vector2D(double,double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle to the X axis counted counterclockwise \[rad\]\.

<a name='DiGi.Geometry.Planar.Create.Vector2D(double,double).length'></a>

`length` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The length of the vector\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A Vector2D with specified angle and length; otherwise, null\.

<a name='DiGi.Geometry.Planar.Create.IntersectionAccumulator'></a>

## Create\.IntersectionAccumulator Class

Accumulates unique intersection points and segments, deduplicating within a distance tolerance\.
Points use a linear scan while few, then transparently switch to a uniform spatial\-hash grid
\(cell size equal to the tolerance\) so lookups stay near O\(1\) as the result set grows\.
First\-seen ordering is preserved\.

```csharp
private sealed class Create.IntersectionAccumulator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → IntersectionAccumulator
### Constructors

<a name='DiGi.Geometry.Planar.Create.IntersectionAccumulator.IntersectionAccumulator(double)'></a>

## IntersectionAccumulator\(double\) Constructor

Initializes a new accumulator using the supplied distance tolerance\.

```csharp
public IntersectionAccumulator(double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionAccumulator.IntersectionAccumulator(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for deduplication\.
### Methods

<a name='DiGi.Geometry.Planar.Create.IntersectionAccumulator.Add(DiGi.Geometry.Planar.Interfaces.IGeometry2D)'></a>

## Create\.IntersectionAccumulator\.Add\(IGeometry2D\) Method

Adds a candidate intersection geometry unless a similar one is already present\.

```csharp
public bool Add(DiGi.Geometry.Planar.Interfaces.IGeometry2D? geometry2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.IntersectionAccumulator.Add(DiGi.Geometry.Planar.Interfaces.IGeometry2D).geometry2D'></a>

`geometry2D` [DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.igeometry2d 'DiGi\.Geometry\.Planar\.Interfaces\.IGeometry2D')

The candidate intersection geometry\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry is a point or a segment \(an intersection event\); otherwise, false\.

<a name='DiGi.Geometry.Planar.Create.IntersectionAccumulator.ToResult()'></a>

## Create\.IntersectionAccumulator\.ToResult\(\) Method

Builds the final result, adopting the accumulated geometries without cloning\.

```csharp
public DiGi.Geometry.Planar.Classes.IntersectionResult2D ToResult();
```

#### Returns
[IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D')  
An [IntersectionResult2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.IntersectionResult2D 'DiGi\.Geometry\.Planar\.Classes\.IntersectionResult2D') that owns the accumulated geometries\.

<a name='DiGi.Geometry.Planar.Create.Transform2D'></a>

## Create\.Transform2D Class

```csharp
public static class Create.Transform2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Transform2D
### Methods

<a name='DiGi.Geometry.Planar.Create.Transform2D.CoordinateSystem2DToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D,DiGi.Geometry.Planar.Classes.CoordinateSystem2D)'></a>

## Create\.Transform2D\.CoordinateSystem2DToCoordinateSystem2D\(CoordinateSystem2D, CoordinateSystem2D\) Method

Creates a transformation that converts points from one coordinate system to another\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D? CoordinateSystem2DToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D? coordinateSystem2D_From, DiGi.Geometry.Planar.Classes.CoordinateSystem2D? coordinateSystem2D_To);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.CoordinateSystem2DToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D,DiGi.Geometry.Planar.Classes.CoordinateSystem2D).coordinateSystem2D_From'></a>

`coordinateSystem2D_From` [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D')

The source coordinate system\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.CoordinateSystem2DToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D,DiGi.Geometry.Planar.Classes.CoordinateSystem2D).coordinateSystem2D_To'></a>

`coordinateSystem2D_To` [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D')

The target coordinate system\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A transformation that maps the source system to the target system; otherwise, null\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.CoordinateSystem2DToOrigin(DiGi.Geometry.Planar.Classes.CoordinateSystem2D)'></a>

## Create\.Transform2D\.CoordinateSystem2DToOrigin\(CoordinateSystem2D\) Method

Creates a 2D transformation that maps coordinates from the specified coordinate system back to the origin\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D? CoordinateSystem2DToOrigin(DiGi.Geometry.Planar.Classes.CoordinateSystem2D? coordinateSystem2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.CoordinateSystem2DToOrigin(DiGi.Geometry.Planar.Classes.CoordinateSystem2D).coordinateSystem2D'></a>

`coordinateSystem2D` [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D')

The source coordinate system to convert into a transformation\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the transformation, or `null` if the provided coordinate system or its origin is null\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Identity()'></a>

## Create\.Transform2D\.Identity\(\) Method

Creates an identity 2D transformation that does not alter the coordinates of any point it is applied to\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D Identity();
```

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the identity transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.MirrorX()'></a>

## Create\.Transform2D\.MirrorX\(\) Method

Creates a 2D transformation that mirrors across the horizontal axis \(X\-axis\) passing through the origin\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D MirrorX();
```

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the mirroring transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.MirrorX(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Create\.Transform2D\.MirrorX\(Point2D\) Method

Creates a 2D transformation that mirrors across the horizontal axis \(X\-axis\) passing through the specified point\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.ITransform2D? MirrorX(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.MirrorX(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point that defines the position of the mirroring axis\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')  
An [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') object representing the mirroring transformation, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided point is null\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.MirrorY()'></a>

## Create\.Transform2D\.MirrorY\(\) Method

Creates a 2D transformation that mirrors across the vertical axis \(Y\-axis\) passing through the origin\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D MirrorY();
```

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the mirroring transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.MirrorY(DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Create\.Transform2D\.MirrorY\(Point2D\) Method

Creates a 2D transformation that mirrors across the vertical axis passing through the specified point\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.ITransform2D? MirrorY(DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.MirrorY(DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point defining the mirror axis\. If null, the method returns null\.

#### Returns
[DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D')  
An [DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.itransform2d 'DiGi\.Geometry\.Planar\.Interfaces\.ITransform2D') object representing the mirroring transformation, or null if the provided point is null\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.OriginToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D)'></a>

## Create\.Transform2D\.OriginToCoordinateSystem2D\(CoordinateSystem2D\) Method

Creates a 2D transformation that maps the origin to the specified coordinate system\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D? OriginToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D? coordinateSystem2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.OriginToCoordinateSystem2D(DiGi.Geometry.Planar.Classes.CoordinateSystem2D).coordinateSystem2D'></a>

`coordinateSystem2D` [CoordinateSystem2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.CoordinateSystem2D 'DiGi\.Geometry\.Planar\.Classes\.CoordinateSystem2D')

The target coordinate system\. If null, the method returns null\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the transformation from the origin to the coordinate system, or null if the provided coordinate system is null\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Rotation(DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Create\.Transform2D\.Rotation\(Point2D, double\) Method

Creates a 2D rotation transformation around a specified origin point by the given angle\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D? Rotation(DiGi.Geometry.Planar.Classes.Point2D? origin, double angle);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.Rotation(DiGi.Geometry.Planar.Classes.Point2D,double).origin'></a>

`origin` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The center point of the rotation\. If null, the method returns null\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Rotation(DiGi.Geometry.Planar.Classes.Point2D,double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle of rotation\. If NaN, the method returns null\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the rotation transformation, or null if the origin is null or the angle is NaN\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Rotation(double)'></a>

## Create\.Transform2D\.Rotation\(double\) Method

Creates a 2D rotation transformation around the origin by the specified angle\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D Rotation(double angle);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.Rotation(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle of rotation\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the rotation transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Scale(double)'></a>

## Create\.Transform2D\.Scale\(double\) Method

Creates a 2D transformation that scales coordinates uniformly by the specified factor\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D Scale(double factor);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.Scale(double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor to apply to both the X and Y axes\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the uniform scaling transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Scale(double,double)'></a>

## Create\.Transform2D\.Scale\(double, double\) Method

Creates a 2D transformation that scales coordinates by the specified factors along the X and Y axes\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D Scale(double x, double y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.Scale(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor for the X\-axis\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Scale(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scale factor for the Y\-axis\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the scaling transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Translation(DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Create\.Transform2D\.Translation\(Vector2D\) Method

Creates a 2D transformation that translates coordinates by the specified vector\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D Translation(DiGi.Geometry.Planar.Classes.Vector2D vector2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.Translation(DiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The translation vector containing the X and Y offsets\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the translation transformation\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Translation(double,double)'></a>

## Create\.Transform2D\.Translation\(double, double\) Method

Creates a 2D transformation that translates coordinates by the specified x and y offsets\.

```csharp
public static DiGi.Geometry.Planar.Classes.Transform2D Translation(double x, double y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Create.Transform2D.Translation(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The translation distance along the X\-axis\.

<a name='DiGi.Geometry.Planar.Create.Transform2D.Translation(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The translation distance along the Y\-axis\.

#### Returns
[Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D')  
A [Transform2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Transform2D 'DiGi\.Geometry\.Planar\.Classes\.Transform2D') object representing the translation transformation\.

<a name='DiGi.Geometry.Planar.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Modify\.Add\(this List\<Point2D\>, Point2D, double\) Method

Adds a `Point2D?` to the `List<Point2D?>?` if it is not null and does not already exist within the specified tolerance\.

```csharp
public static bool Add(this System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D?>? point2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The `List<Point2D?>?` to which the point will be added\.

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The `Point2D?` object to add to the list\.

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine if a point is a duplicate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the point was successfully added to the list\.

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double,double)'></a>

## Modify\.Add\(this List\<Point2D\>, double, double\) Method

Adds a new [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to the specified list of nullable [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects using the provided x and y coordinates\.

```csharp
public static bool Add(this System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D?>? point2Ds, double x, double y);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of nullable [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to which the point will be added\.

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value for the X coordinate\.

<a name='DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value for the Y coordinate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A boolean value indicating whether the point was successfully added; returns false if the list is null\.

<a name='DiGi.Geometry.Planar.Modify.Connect(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Core.Enums.PointConnectMethod,double)'></a>

## Modify\.Connect\(this List\<Segment2D\>, Point2D, PointConnectMethod, double\) Method

Connect given Point2D to Segment2Ds\. If point2D is on the end of Segment2D then nothing happen\. If point2D is on the Segment2D then segment will be split otherwise point2D will be connected to closest Segment2D by adding extra segment\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Connect(this System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Core.Enums.PointConnectMethod pointConnectMethod=DiGi.Geometry.Core.Enums.PointConnectMethod.Projection, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.Connect(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Core.Enums.PointConnectMethod,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

Segment2Ds

<a name='DiGi.Geometry.Planar.Modify.Connect(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Core.Enums.PointConnectMethod,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Point2D to be connected

<a name='DiGi.Geometry.Planar.Modify.Connect(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Core.Enums.PointConnectMethod,double).pointConnectMethod'></a>

`pointConnectMethod` [PointConnectMethod](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.PointConnectMethod 'DiGi\.Geometry\.Core\.Enums\.PointConnectMethod')

Point Connect Method

<a name='DiGi.Geometry.Planar.Modify.Connect(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Core.Enums.PointConnectMethod,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
List of the segments connected to given Point2D

<a name='DiGi.Geometry.Planar.Modify.FindNear(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Modify\.FindNear\(this List\<Point2D\>, Point2D, double\) Method

Finds the first point in the `List<Point2D?>?` that lies within the specified tolerance of the given point, using the same cached spatial index as [Add\(this List&lt;Point2D&gt;, Point2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Modify\.Add\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Planar\.Classes\.Point2D\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')\.

```csharp
internal static DiGi.Geometry.Planar.Classes.Point2D? FindNear(this System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D?>? point2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.FindNear(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The `List<Point2D?>?` to search\.

<a name='DiGi.Geometry.Planar.Modify.FindNear(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The `Point2D?` to search for\.

<a name='DiGi.Geometry.Planar.Modify.FindNear(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used to determine a match\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The matching [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from the list, or `null` if none is found\.

<a name='DiGi.Geometry.Planar.Modify.GetIndex(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Modify\.GetIndex\(List\<Point2D\>, double\) Method

Returns the cached spatial index for the given list, rebuilding it \(one O\(n\) pass\) if the list was mutated outside of [Add\(this List&lt;Point2D&gt;, Point2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Modify\.Add\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Planar\.Classes\.Point2D\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)')/[FindNear\(this List&lt;Point2D&gt;, Point2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Modify.FindNear(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Modify\.FindNear\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Planar\.Classes\.Point2D\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)') or the tolerance changed; otherwise the cached index is reused as\-is\.

```csharp
private static DiGi.Geometry.Planar.Modify.PointIndex2D GetIndex(System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D?> point2Ds, double tolerance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.GetIndex(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Geometry.Planar.Modify.GetIndex(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[PointIndex2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Modify.PointIndex2D 'DiGi\.Geometry\.Planar\.Modify\.PointIndex2D')

<a name='DiGi.Geometry.Planar.Modify.Orient(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Core.Enums.Orientation)'></a>

## Modify\.Orient\(List\<Point2D\>, Orientation\) Method

Determines if the majority of point sets within the provided list exhibit the specified orientation\.

```csharp
public static bool Orient(System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, DiGi.Geometry.Core.Enums.Orientation orientation);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.Orient(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Core.Enums.Orientation).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing points to analyze\.

<a name='DiGi.Geometry.Planar.Modify.Orient(System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Core.Enums.Orientation).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The target [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation') to check for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the majority of orientations match the specified [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')\.

<a name='DiGi.Geometry.Planar.Modify.Orient(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Orientation,bool)'></a>

## Modify\.Orient\(this IPolygonal2D, Orientation, bool\) Method

Orients the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') to a target [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')\.

```csharp
public static bool Orient(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, DiGi.Geometry.Core.Enums.Orientation orientation, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Modify.Orient(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Orientation,bool).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to orient\.

<a name='DiGi.Geometry.Planar.Modify.Orient(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Orientation,bool).orientation'></a>

`orientation` [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')

The desired [Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')\.

<a name='DiGi.Geometry.Planar.Modify.Orient(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Orientation,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the convex hull should be used for orientation calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polygonal object was inverted to match the target orientation\.

<a name='DiGi.Geometry.Planar.Modify.PointIndex2D'></a>

## Modify\.PointIndex2D Class

Caches a tolerance\-bucketed spatial hash grid per [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') instance so repeated [Add\(this List&lt;Point2D&gt;, Point2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Modify.Add(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Modify\.Add\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Planar\.Classes\.Point2D\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)') / [FindNear\(this List&lt;Point2D&gt;, Point2D, double\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Modify.FindNear(thisSystem.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double) 'DiGi\.Geometry\.Planar\.Modify\.FindNear\(this System\.Collections\.Generic\.List\<DiGi\.Geometry\.Planar\.Classes\.Point2D\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)') calls on the same list avoid an O\(n\) linear scan\.

```csharp
private sealed class Modify.PointIndex2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → PointIndex2D

<a name='DiGi.Geometry.Planar.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Geometry.Planar.Query.Above(thisDiGi.Math.Classes.PolynomialEquation,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Above\(this PolynomialEquation, Point2D, double\) Method

Determines whether the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is above the curve of the [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation'), considering a given tolerance\.

```csharp
public static bool Above(this DiGi.Math.Classes.PolynomialEquation? polynomialEquation, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Above(thisDiGi.Math.Classes.PolynomialEquation,DiGi.Geometry.Planar.Classes.Point2D,double).polynomialEquation'></a>

`polynomialEquation` [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation')

The [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation') to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Above(thisDiGi.Math.Classes.PolynomialEquation,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to check against the equation\.

<a name='DiGi.Geometry.Planar.Query.Above(thisDiGi.Math.Classes.PolynomialEquation,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance for the comparison\. Defaults to 0\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the point is above the polynomial curve; returns false if either the [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation') or [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is null\.

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.AdjacentSegments\(this ISegmentable2D, ISegmentable2D, double\) Method

Retrieves the adjacent [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects between two [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instances within a specified tolerance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? AdjacentSegments(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instance\.

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instance\.

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the bounding boxes are in range\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the adjacent segments, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is null or no adjacency is found\.

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments_T_(thisSystem.Collections.Generic.IEnumerable_T_,double)'></a>

## Query\.AdjacentSegments\<T\>\(this IEnumerable\<T\>, double\) Method

Identifies and returns a list of adjacent 2D segments from a collection of segmentable objects based on a specified distance tolerance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? AdjacentSegments<T>(this System.Collections.Generic.IEnumerable<T?>? segmentable2Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

The type of the segmentable objects, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.AdjacentSegments_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Query\.AdjacentSegments\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the segmentable objects to evaluate for adjacency\.

<a name='DiGi.Geometry.Planar.Query.AdjacentSegments_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used to determine if segments are adjacent\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of adjacent segments, or `null` if the input collection is `null`\.

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.AlmostEquals\(this Point2D, Point2D, double\) Method

Determines whether two `Point2D?` points are approximately equal based on a specified distance tolerance\.

```csharp
public static bool AlmostEquals(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first `Point2D?` point to compare\.

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second `Point2D?` point to compare\.

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if the points are almost equal\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two points are considered equal within the given tolerance\.

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.AlmostEquals\(this ISegmentable2D, ISegmentable2D, double\) Method

Determines whether two [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instances are approximately equal based on a specified tolerance\.

```csharp
public static bool AlmostEquals(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instance to compare\.

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instance to compare\.

<a name='DiGi.Geometry.Planar.Query.AlmostEquals(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the tolerance for the equality check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two instances are almost equal\.

<a name='DiGi.Geometry.Planar.Query.Angle(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Angle\(this Point2D, Point2D, Point2D\) Method

Calculates the angle formed by three [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points, where the second point is the vertex of the angle\.

```csharp
public static double Angle(this DiGi.Geometry.Planar.Classes.Point2D point2D_Previous, DiGi.Geometry.Planar.Classes.Point2D point2D, DiGi.Geometry.Planar.Classes.Point2D point2D_Next);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Angle(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_Previous'></a>

`point2D_Previous` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.Angle(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point that serves as the vertex of the angle\.

<a name='DiGi.Geometry.Planar.Query.Angle(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_Next'></a>

`point2D_Next` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The third [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the angle between the vectors, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if any of the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') parameters are null\.

<a name='DiGi.Geometry.Planar.Query.Area(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Area\(this IEnumerable\<Point2D\>\) Method

Calculates the area of a polygon defined by a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static double Area(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D> point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Area(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects representing the vertices of the polygon\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated area as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is null or contains any null elements; returns 0 if there are fewer than three points\.

<a name='DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,bool)'></a>

## Query\.AspectRatio\(this BoundingBox2D, bool\) Method

Calculates the aspect ratio of the specified [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static double AspectRatio(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D, bool normalized=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,bool).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to calculate the aspect ratio for\.

<a name='DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,bool).normalized'></a>

`normalized` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the result should be normalized\. Defaults to true\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the aspect ratio, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') is null\.

<a name='DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.Rectangle2D,bool)'></a>

## Query\.AspectRatio\(this Rectangle2D, bool\) Method

Calculates the aspect ratio of the specified [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')\.

```csharp
public static double AspectRatio(this DiGi.Geometry.Planar.Classes.Rectangle2D rectangle2D, bool normalized=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.Rectangle2D,bool).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') instance to calculate the aspect ratio for\.

<a name='DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.Rectangle2D,bool).normalized'></a>

`normalized` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the result should be normalized\. Defaults to true\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the aspect ratio, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the [rectangle2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.AspectRatio(thisDiGi.Geometry.Planar.Classes.Rectangle2D,bool).rectangle2D 'DiGi\.Geometry\.Planar\.Query\.AspectRatio\(this DiGi\.Geometry\.Planar\.Classes\.Rectangle2D, bool\)\.rectangle2D') is null\.

<a name='DiGi.Geometry.Planar.Query.Average(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Average\(this IEnumerable\<Point2D\>\) Method

Calculates the average position of a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Average(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Average(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of points to average\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the average coordinates, or `null` if the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double)'></a>

## Query\.Bounce\(this Vector2D, Segment2D, double, double\) Method

Calculates the bounce vector of a given [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') against a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D'), accounting for friction and restitution\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Bounce(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D_ToBeBounced, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double friction=1.0, double restitution=1.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).vector2D_ToBeBounced'></a>

`vector2D_ToBeBounced` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The `Vector2D?` representing the velocity or direction to be bounced\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') representing the surface to bounce off of\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).friction'></a>

`friction` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the friction coefficient applied during the bounce\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).restitution'></a>

`restitution` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the restitution coefficient applied during the bounce\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
The resulting `Vector2D?` after the bounce calculation, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either the input vector or segment is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double,double)'></a>

## Query\.Bounce\(this Vector2D, Vector2D, double, double\) Method

Calculates the reflection of a [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') against another [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D'), applying friction and restitution coefficients\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Bounce(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D_ToBeBounced, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, double friction=1.0, double restitution=1.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double,double).vector2D_ToBeBounced'></a>

`vector2D_ToBeBounced` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') that is to be bounced\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the surface normal or reflection axis\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double,double).friction'></a>

`friction` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the friction coefficient applied to the tangential component of the bounce\.

<a name='DiGi.Geometry.Planar.Query.Bounce(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double,double).restitution'></a>

`restitution` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the restitution coefficient applied to the normal component of the bounce\.

#### Returns
[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
The resulting bounced [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input vector is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.Centroid(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.Centroid\(this IPolygonal2D\) Method

Calculates the centroid of the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Centroid(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Centroid(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to calculate the centroid for\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the centroid, or null if the [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') is null\.

<a name='DiGi.Geometry.Planar.Query.Centroid(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Query\.Centroid\(this IPolygonalFace2D\) Method

Calculates the centroid of the specified [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Centroid(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Centroid(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') for which to calculate the centroid\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the centroid, or `null` if the [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D') is null or has no external edge\.

<a name='DiGi.Geometry.Planar.Query.Centroid(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Centroid\(this IEnumerable\<Point2D\>\) Method

Calculates the centroid of a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Centroid(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Centroid(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to process\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing the centroid, or null if the input collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool)'></a>

## Query\.ClosestPoint\(this Point2D, Point2D, Point2D, bool\) Method

Calculates the closest point on a line or line segment defined by two points relative to a target point\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, bool bounded);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target `Point2D?` point\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first `Point2D?` point defining the line or segment\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second `Point2D?` point defining the line or segment\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool).bounded'></a>

`bounded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the result should be bounded to the line segment between the two points\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest `Point2D?` point on the line or segment, or null if any of the input points are null\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,bool)'></a>

## Query\.ClosestPoint\(this Point2D, Point2D, Point2D, bool, bool\) Method

Calculates the closest point on a line or line segment defined by two points relative to a target point\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, bool bounded_1, bool bounded_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,bool).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The `Point2D?` target point\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,bool).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The `Point2D?` first point defining the line or segment\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,bool).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The `Point2D?` second point defining the line or segment\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,bool).bounded_1'></a>

`bounded_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the result is bounded by the first point\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,bool).bounded_2'></a>

`bounded_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the result is bounded by the second point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest `Point2D?` on the line or segment, or null if any of the input points are null\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Query\.ClosestPoint\(this Point2D, ISegmentable2D\) Method

Calculates the closest point on an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to a given [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D segmentable2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for which the closest point is being sought\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to find the closest point on\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no point could be determined\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.ClosestPoint\(this Point2D, ISegmentable2D, double\) Method

Calculates the closest point on an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to a given [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from which the distance is measured\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to find the closest point on\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the distance between the input [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and the resulting closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found on the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object, or `null` if no point could be determined\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.ClosestPoint\(this Point2D, IEnumerable\<Point2D\>\) Method

Finds the closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') in a collection of points to the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for which the closest point is sought\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to search through\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found in the collection, or null if no point is found\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.ClosestPoint\(this Point2D, IEnumerable\<Point2D\>, double\) Method

Finds the closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') in a collection of points relative to a specified source point\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') used as the reference for distance calculations\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to search through\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the minimum [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance found; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from the collection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no point is found or if either input parameter is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_)'></a>

## Query\.ClosestPoint\(this Point2D, IEnumerable\<Segment2D\>\) Method

Finds the closest point on a collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects to the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') for which the closest point is being sought\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the segments to evaluate\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found on any of the provided segments, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the point is null, the collection is null, or the collection contains no elements\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.ClosestPoint\(this Point2D, IEnumerable\<Segment2D\>, double\) Method

Finds the closest point among a collection of line segments to a given point\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects to search\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the distance between the source [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and the closest point found; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found across all segments, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no valid point is found or inputs are null\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_)'></a>

## Query\.ClosestPoint\<T\>\(this Point2D, IEnumerable\<T\>\) Method

Finds the closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to the specified reference point from a collection of segmentable 2D objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint<T>(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<T>? segmentable2Ds)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

A type that implements the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') interface\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The reference [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to calculate distance from\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).T 'DiGi\.Geometry\.Planar\.Query\.ClosestPoint\<T\>\(this DiGi\.Geometry\.Planar\.Classes\.Point2D, System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of objects that implement the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') interface\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the reference point or the collection is null\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,double)'></a>

## Query\.ClosestPoint\<T\>\(this Point2D, IEnumerable\<T\>, double\) Method

Finds the closest point to a given point from a collection of segmentable 2D objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ClosestPoint<T>(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<T>? segmentable2Ds, out double distance)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

A type that implements [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to calculate the distance from\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Query\.ClosestPoint\<T\>\(this DiGi\.Geometry\.Planar\.Classes\.Point2D, System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of objects implementing [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

<a name='DiGi.Geometry.Planar.Query.ClosestPoint_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance to the closest point found; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no points are available or inputs are null\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Collinear\(this Point2D, Point2D, Point2D, double\) Method

Determines whether three [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points are collinear within a specified tolerance\.

```csharp
public static bool Collinear(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, DiGi.Geometry.Planar.Classes.Point2D? point2D_3, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_3'></a>

`point2D_3` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The third [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine collinearity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the points are collinear; returns false if any of the provided points are null\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Query\.Collinear\(this ILinear2D, ILinear2D, double\) Method

Determines whether two [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') objects are collinear within a specified tolerance\.

```csharp
public static bool Collinear(this DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D_1, DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D_1'></a>

`linear2D_1` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The first [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') object\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D_2'></a>

`linear2D_2` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The second [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') object\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance for collinearity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two objects are collinear\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.Collinear\(this IEnumerable\<Point2D\>, double\) Method

Determines whether a collection of points are collinear within a specified tolerance\.

```csharp
public static bool Collinear(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D?>? point2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Collinear(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<Point2D?>` collection of points to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Collinear(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the points lie on the same line\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the points are collinear; returns `false` if the input collection is null\.

<a name='DiGi.Geometry.Planar.Query.Concave(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool)'></a>

## Query\.Concave\(this PolygonalFace2D, bool, bool\) Method

Determines whether the specified [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') is concave\.

```csharp
public static bool Concave(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, bool externalEdge=true, bool internalEdges=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Concave(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool).polygonalFace2D'></a>

`polygonalFace2D` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Concave(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool).externalEdge'></a>

`externalEdge` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the external edge should be checked for concavity\.

<a name='DiGi.Geometry.Planar.Query.Concave(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool).internalEdges'></a>

`internalEdges` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether internal edges should be checked for concavity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value that is `true` if the polygonal face is concave; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Concave(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.Concave\(this IPolygonal2D\) Method

Determines whether the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance is concave\.

```csharp
public static bool Concave(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Concave(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polygonal object is concave; otherwise, false if the [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance is null\.

<a name='DiGi.Geometry.Planar.Query.Concave(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Concave\(this IEnumerable\<Point2D\>\) Method

Determines whether the provided collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points forms a concave polygon\.

```csharp
public static bool Concave(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Concave(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects representing the vertices of the polygon\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polygon is concave; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the collection is null or contains fewer than three points\.

<a name='DiGi.Geometry.Planar.Query.Contains(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Contains\(this IEnumerable\<Point2D\>, Point2D, double\) Method

Determines whether the collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects contains a specific [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') within the specified tolerance\.

```csharp
public static bool Contains(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D> point2Ds, DiGi.Geometry.Planar.Classes.Point2D point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Contains(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to search\.

<a name='DiGi.Geometry.Planar.Query.Contains(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') object to locate in the collection\.

<a name='DiGi.Geometry.Planar.Query.Contains(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for equality comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') was found within the given tolerance; otherwise, false\.

<a name='DiGi.Geometry.Planar.Query.Convex(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool)'></a>

## Query\.Convex\(this PolygonalFace2D, bool, bool\) Method

Determines whether the specified [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') is convex\.

```csharp
public static bool Convex(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, bool externalEdge=true, bool internalEdges=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Convex(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool).polygonalFace2D'></a>

`polygonalFace2D` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Convex(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool).externalEdge'></a>

`externalEdge` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the external edge should be included in the convexity check\.

<a name='DiGi.Geometry.Planar.Query.Convex(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,bool,bool).internalEdges'></a>

`internalEdges` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether internal edges should be included in the convexity check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value that is `true` if the face is convex; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Convex(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.Convex\(this IPolygonal2D\) Method

Determines whether the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') is convex\.

```csharp
public static bool Convex(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Convex(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the polygon is convex; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the input is null\.

<a name='DiGi.Geometry.Planar.Query.Convex(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Convex\(this IEnumerable\<Point2D\>\) Method

Determines whether the specified collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects forms a convex polygon\.

```csharp
public static bool Convex(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Convex(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the points form a convex polygon; returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the collection is null or contains fewer than three points\.

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Query\.ConvexHull\(this ISegmentable2D\) Method

Computes the convex hull for the specified [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? ConvexHull(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') instance to calculate the convex hull for\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the points of the convex hull, or null if the [segmentable2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.ConvexHull(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D 'DiGi\.Geometry\.Planar\.Query\.ConvexHull\(this DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\)\.segmentable2D') is null\.

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.ConvexHull\(this IEnumerable\<Point2D\>\) Method

Computes the convex hull for a given collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? ConvexHull(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  containing the points to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') representing the vertices of the convex hull, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Query\.ConvexHull\(this IEnumerable\<Point2D\>, bool\) Method

Computes the convex hull for a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? ConvexHull(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool keepOrder);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to process\.

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).keepOrder'></a>

`keepOrder` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the original order of the points should be preserved in the resulting list\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects forming the convex hull, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_)'></a>

## Query\.ConvexHull\(this IEnumerable\<Segment2D\>\) Method

Computes the convex hull for a collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? ConvexHull(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ConvexHull(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects used to derive points for the convex hull\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertices forming the convex hull, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Determinant\(this Point2D, Point2D, Point2D\) Method

Calculates the determinant of three 2D points\.

```csharp
public static double Determinant(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, DiGi.Geometry.Planar.Classes.Point2D? point2D_3);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_3'></a>

`point2D_3` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The third [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') determinant, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if any of the provided points are null\.

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Query\.Determinant\(this Vector2D, Vector2D\) Method

Calculates the determinant of two 2D vectors\.

```csharp
public static double Determinant(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') instance\.

<a name='DiGi.Geometry.Planar.Query.Determinant(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') instance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the determinant, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') is null\.

<a name='DiGi.Geometry.Planar.Query.Determinants(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.Determinants\(this IPolygonal2D\) Method

Calculates the determinants for the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object\.

```csharp
public static System.Collections.Generic.List<double>? Determinants(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Determinants(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values representing the determinants, or null if the input is null or contains fewer than three points\.

<a name='DiGi.Geometry.Planar.Query.Determinants(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Determinants\(this IEnumerable\<Point2D\>\) Method

Calculates the determinants for a sequence of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects by treating them as a closed loop\.

```csharp
public static System.Collections.Generic.List<double>? Determinants(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Determinants(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<Point2D>` collection of points to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<double>` containing the calculated determinants, or null if the input is null or contains fewer than 3 [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') elements\.

<a name='DiGi.Geometry.Planar.Query.DiagonalLength(thisDiGi.Geometry.Planar.Classes.BoundingBox2D)'></a>

## Query\.DiagonalLength\(this BoundingBox2D\) Method

Calculates the length of the diagonal for the specified [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static double DiagonalLength(this DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.DiagonalLength(thisDiGi.Geometry.Planar.Classes.BoundingBox2D).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') instance to calculate the diagonal length for\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the length of the diagonal, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') is null or contains no diagonals\.

<a name='DiGi.Geometry.Planar.Query.Difference(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Query\.Difference\(this PolygonalFace2D, PolygonalFace2D\) Method

Calculates the difference between two [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? Difference(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Difference(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The first [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') object from which the second is subtracted\.

<a name='DiGi.Geometry.Planar.Query.Difference(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The second [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') object to subtract from the first\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the resulting faces of the difference operation, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or conversion fails\.

### Remarks
The computation is delegated to [DifferenceResult2D\(this IPolygonalFace2D, IPolygonalFace2D\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.DifferenceResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D) 'DiGi\.Geometry\.Planar\.Create\.DifferenceResult2D\(this DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D\)'); only the polygonal faces of the result are returned\. Use the result object directly to access lower\-dimensional \(segment/point\) difference geometries\.

<a name='DiGi.Geometry.Planar.Query.Difference(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.Difference\(this IPolygonal2D, IPolygonal2D\) Method

Calculates the difference between two 2D polygonal shapes\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? Difference(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Difference(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D_1'></a>

`polygonal2D_1` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The first [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object\.

<a name='DiGi.Geometry.Planar.Query.Difference(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D_2'></a>

`polygonal2D_2` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The second [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object to subtract from the first\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') objects representing the resulting difference, or null if either input is null\.

<a name='DiGi.Geometry.Planar.Query.Difference(thisPolygon,Polygon)'></a>

## Query\.Difference\(this Polygon, Polygon\) Method

Calculates the geometric difference between two [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') objects\.

```csharp
public static System.Collections.Generic.List<Polygon>? Difference(this Polygon? polygon_1, Polygon? polygon_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Difference(thisPolygon,Polygon).polygon_1'></a>

`polygon_1` [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')

The first [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') from which the second polygon is subtracted\.

<a name='DiGi.Geometry.Planar.Query.Difference(thisPolygon,Polygon).polygon_2'></a>

`polygon_2` [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')

The second [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') to be subtracted from the first\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the resulting polygons of the difference operation, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input polygon is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.Directions(thisDiGi.Geometry.Core.Enums.Corner,DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Query\.Directions\(this Corner, Vector2D, Vector2D\) Method

Calculates the height and width direction vectors based on the specified corner\.

```csharp
public static void Directions(this DiGi.Geometry.Core.Enums.Corner corner, out DiGi.Geometry.Planar.Classes.Vector2D? heightDirection, out DiGi.Geometry.Planar.Classes.Vector2D? widthDirection);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Directions(thisDiGi.Geometry.Core.Enums.Corner,DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).corner'></a>

`corner` [Corner](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Corner 'DiGi\.Geometry\.Core\.Enums\.Corner')

The [Corner](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Corner 'DiGi\.Geometry\.Core\.Enums\.Corner') value used to determine the directions\.

<a name='DiGi.Geometry.Planar.Query.Directions(thisDiGi.Geometry.Core.Enums.Corner,DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).heightDirection'></a>

`heightDirection` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

When this method returns, contains a `Vector2D?` representing the height direction vector, or null if not applicable\.

<a name='DiGi.Geometry.Planar.Query.Directions(thisDiGi.Geometry.Core.Enums.Corner,DiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).widthDirection'></a>

`widthDirection` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

When this method returns, contains a `Vector2D?` representing the width direction vector, or null if not applicable\.

<a name='DiGi.Geometry.Planar.Query.Directions(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_)'></a>

## Query\.Directions\(this IEnumerable\<ISegmentable2D\>\) Method

Calculates the directions for a collection of segmentable 2D objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Vector2D>? Directions(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Directions(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the calculated directions, or null if the [segmentable2Ds](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Directions(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_).segmentable2Ds 'DiGi\.Geometry\.Planar\.Query\.Directions\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\>\)\.segmentable2Ds') collection is null\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Distance\(BoundingBox2D, ISegmentable2D, Point2D, Point2D, double\) Method

Calculates the distance between a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') and an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static double Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to measure the distance from\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') to measure the distance to\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest1'></a>

`point2D_Closest1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') closest to the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D'), or null if not found\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest2'></a>

`point2D_Closest2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') closest to the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D'), or null if not found\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for distance calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance between the two objects, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either input is null\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Distance\(ISegmentable2D, BoundingBox2D, Point2D, Point2D, double\) Method

Calculates the shortest distance between an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') and a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static double Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') object\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest1'></a>

`point2D_Closest1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') that is closest to the other object on the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest2'></a>

`point2D_Closest2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') that is closest to the other object on the [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for distance calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') between the two objects\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Distance\(ISegmentable2D, ISegmentable2D, Point2D, Point2D, double\) Method

Calculates the shortest distance between two segmentable 2D objects\.

```csharp
public static double Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest1'></a>

`point2D_Closest1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the first segmentable object that is closest to the second segmentable object, or null if no distance could be calculated\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest2'></a>

`point2D_Closest2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the second segmentable object that is closest to the first segmentable object, or null if no distance could be calculated\.

<a name='DiGi.Geometry.Planar.Query.Distance(DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') between the two objects, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if either object is null or contains no segments\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Query\.Distance\(this Point2D, ISegmentable2D\) Method

Calculates the shortest distance between a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static double Distance(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from which to calculate the distance\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to measure the distance to\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_)'></a>

## Query\.Distance\(this Point2D, IEnumerable\<Segment2D\>\) Method

Calculates the shortest distance between a specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and a collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects\.

```csharp
public static double Distance(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from which to calculate the distance\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects to measure the distance against\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the point or the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Distance\(this Point2D, IEnumerable\<Segment2D\>, Point2D\) Method

Calculates the shortest distance from a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects\.

```csharp
public static double Distance(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, out DiGi.Geometry.Planar.Classes.Point2D? closetPoint2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance to measure the distance from\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the segments to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Distance(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D).closetPoint2D'></a>

`closetPoint2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') that is closest to the source point; otherwise, null\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The minimum distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Distance\<T\>\(this Point2D, IEnumerable\<T\>\) Method

Calculates the shortest distance between a specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') and a collection of objects that implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static double Distance<T>(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<T>? segmentable2Ds)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

A type that implements the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') interface\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from which the distance is measured\.

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_).T 'DiGi\.Geometry\.Planar\.Query\.Distance\<T\>\(this DiGi\.Geometry\.Planar\.Classes\.Point2D, System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of objects implementing [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') to measure the distance against\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The shortest distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Distance\<T\>\(this Point2D, IEnumerable\<T\>, Point2D\) Method

Calculates the shortest distance from a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a collection of objects that implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static double Distance<T>(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Collections.Generic.IEnumerable<T>? segmentable2Ds, out DiGi.Geometry.Planar.Classes.Point2D? closetPoint2D)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).T'></a>

`T`

A type that implements [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to measure the distance from\.

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).T 'DiGi\.Geometry\.Planar\.Query\.Distance\<T\>\(this DiGi\.Geometry\.Planar\.Classes\.Point2D, System\.Collections\.Generic\.IEnumerable\<T\>, DiGi\.Geometry\.Planar\.Classes\.Point2D\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of objects that implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

<a name='DiGi.Geometry.Planar.Query.Distance_T_(thisDiGi.Geometry.Planar.Classes.Point2D,System.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).closetPoint2D'></a>

`closetPoint2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the closest [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found on the segmentable objects; otherwise, null\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The minimum distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the source point is null, the collection is null, or the collection contains no elements\.

<a name='DiGi.Geometry.Planar.Query.EqualsTopologically(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D)'></a>

## Query\.EqualsTopologically\(this ISegmentable2D, ISegmentable2D\) Method

Determines whether two [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects are topologically equal\.

```csharp
public static bool EqualsTopologically(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.EqualsTopologically(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to compare\.

<a name='DiGi.Geometry.Planar.Query.EqualsTopologically(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two objects are topologically equal\.

<a name='DiGi.Geometry.Planar.Query.Evaluate(thisDiGi.Math.Classes.PolynomialEquation,double)'></a>

## Query\.Evaluate\(this PolynomialEquation, double\) Method

Evaluates the specified [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation') at a given x\-coordinate and returns the result as a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Evaluate(this DiGi.Math.Classes.PolynomialEquation? polynominalEquation, double x);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Evaluate(thisDiGi.Math.Classes.PolynomialEquation,double).polynominalEquation'></a>

`polynominalEquation` [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation')

The [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation') instance to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Evaluate(thisDiGi.Math.Classes.PolynomialEquation,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the x\-coordinate\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') containing the x and y coordinates if the evaluation is successful; otherwise, null if the [DiGi\.Math\.Classes\.PolynomialEquation](https://learn.microsoft.com/en-us/dotnet/api/digi.math.classes.polynomialequation 'DiGi\.Math\.Classes\.PolynomialEquation') is null or if either the input x or the resulting y value is NaN\.

<a name='DiGi.Geometry.Planar.Query.Extend(thisDiGi.Geometry.Planar.Classes.Segment2D,double,bool,bool)'></a>

## Query\.Extend\(this Segment2D, double, bool, bool\) Method

Extends a 2D line segment by a specified distance at the start and/or end points\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Extend(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double distance, bool extendStart=true, bool extendEnd=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Extend(thisDiGi.Geometry.Planar.Classes.Segment2D,double,bool,bool).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance to be extended\.

<a name='DiGi.Geometry.Planar.Query.Extend(thisDiGi.Geometry.Planar.Classes.Segment2D,double,bool,bool).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance to extend the segment by\.

<a name='DiGi.Geometry.Planar.Query.Extend(thisDiGi.Geometry.Planar.Classes.Segment2D,double,bool,bool).extendStart'></a>

`extendStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the start of the segment should be extended\. Defaults to true\.

<a name='DiGi.Geometry.Planar.Query.Extend(thisDiGi.Geometry.Planar.Classes.Segment2D,double,bool,bool).extendEnd'></a>

`extendEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the end of the segment should be extended\. Defaults to true\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A new [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance representing the extended segment, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') or its endpoints are null\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.ExternalPolygons\(this IEnumerable\<Segment2D\>, double\) Method

Extracts the external polygons from a collection of 2D segments using a specified distance tolerance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? ExternalPolygons(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of segments to process\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the external polygons, or `null` if the input collection is `null`\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double)'></a>

## Query\.ExternalPolygons\<T\>\(this IEnumerable\<T\>, double\) Method

Extracts the external polygons from a collection of segmentable 2D objects using a specified distance tolerance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? ExternalPolygons<T>(this System.Collections.Generic.IEnumerable<T>? segmentable2Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

The type of the segmentable 2D objects, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Query\.ExternalPolygons\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of segmentable 2D objects to process\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the external polygons, or `null` if the input collection is `null`\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,double)'></a>

## Query\.ExternalPolygons\<T\>\(this IEnumerable\<T\>, double, double\) Method

Extracts and identifies external polygons from a collection of segmentable 2D objects, optionally extending the segments by a specified distance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? ExternalPolygons<T>(this System.Collections.Generic.IEnumerable<T>? segmentable2Ds, double maxDistance, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,double).T'></a>

`T`

The type of the segmentable 2D objects, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,double).T 'DiGi\.Geometry\.Planar\.Query\.ExternalPolygons\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of segmentable 2D objects to process\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,double).maxDistance'></a>

`maxDistance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance by which each segment should be extended\.

<a name='DiGi.Geometry.Planar.Query.ExternalPolygons_T_(thisSystem.Collections.Generic.IEnumerable_T_,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') specifying the tolerance used for distance calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the identified external polygons, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is null or contains no segments\.

<a name='DiGi.Geometry.Planar.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.ExtremePoints\(this IEnumerable\<Point2D\>, Point2D, Point2D\) Method

Finds the two points within a collection that are furthest apart from each other\.

```csharp
public static void ExtremePoints(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, out DiGi.Geometry.Planar.Classes.Point2D? point2D_1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to evaluate\.

<a name='DiGi.Geometry.Planar.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the first point of the pair with the maximum distance, or null if the collection is null or contains fewer than two points\.

<a name='DiGi.Geometry.Planar.Query.ExtremePoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the second point of the pair with the maximum distance, or null if the collection is null or contains fewer than two points\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double)'></a>

## Query\.Fit\(this BoundingBox2D, BoundingBox2D, double\) Method

Fits a source [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') into a target [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') with an optional offset\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D_Source, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The target [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to fit into\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double).boundingBox2D_Source'></a>

`boundingBox2D_Source` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The source [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the offset applied during fitting\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
The resulting [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') if successful; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double,double)'></a>

## Query\.Fit\(this BoundingBox2D, BoundingBox2D, double, double\) Method

Fits a source [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') into a target [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D_Source, out double scale, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The target [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to fit the source bounding box into\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double,double).boundingBox2D_Source'></a>

`boundingBox2D_Source` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The source [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that is being fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the calculated [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') scale factor used for fitting; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.BoundingBox2D,double,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') offset to apply during the fitting process\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') representing the fitted result, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input bounding box is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or cannot be processed\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double)'></a>

## Query\.Fit\(this BoundingBox2D, Polygon2D, double\) Method

Fits a [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') into a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to fit the polygon into\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') to be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the offset\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A new [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') that fits within the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the operation fails or any input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double,double)'></a>

## Query\.Fit\(this BoundingBox2D, Polygon2D, double, double\) Method

Fits a [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') into a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D, out double scale, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the target area for fitting\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double,double).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') to be fitted into the bounding box\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') scale factor applied to fit the polygon; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Polygon2D,double,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the offset used during the fitting process\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A new [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') that fits within the specified bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or the resulting polygon contains fewer than two points\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Query\.Fit\(this BoundingBox2D, Segment2D, double\) Method

Fits a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') into a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The target [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to fit the segment into\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The source [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the offset\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') that fits within the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is null\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double)'></a>

## Query\.Fit\(this BoundingBox2D, Segment2D, double, double\) Method

Fits a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') into a [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, out double scale, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to fit the segment into\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the calculated [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') scale factor; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Geometry.Planar.Classes.Segment2D,double,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') offset value used during the fitting process\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A new [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') that fits within the bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input parameters are null or the segment cannot be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.Fit\(this BoundingBox2D, IEnumerable\<Point2D\>, double\) Method

Fits a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects within the specified [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') to fit the points into\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the offset for the fitting process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of fitted [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is invalid\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double,double)'></a>

## Query\.Fit\(this BoundingBox2D, IEnumerable\<Point2D\>, double, double\) Method

Fits a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects into the specified [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Fit(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, out double scale, double offset=0.0);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double,double).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the target area for fitting\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the points to be fitted\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double,double).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') scale factor used to fit the points; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.Fit(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the offset applied during fitting\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Point2D>` containing the fitted points if successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.InRange(thisGeometry,Geometry,double)'></a>

## Query\.InRange\(this Geometry, Geometry, double\) Method

Determines whether two geometries are within a specified distance tolerance of each other\.

```csharp
public static bool InRange(this Geometry geometry_1, Geometry geometry_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.InRange(thisGeometry,Geometry,double).geometry_1'></a>

`geometry_1` [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry')

The first [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') to evaluate\.

<a name='DiGi.Geometry.Planar.Query.InRange(thisGeometry,Geometry,double).geometry_2'></a>

`geometry_2` [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry')

The second [NetTopologySuite\.Geometries\.Geometry](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.geometry 'NetTopologySuite\.Geometries\.Geometry') to evaluate\.

<a name='DiGi.Geometry.Planar.Query.InRange(thisGeometry,Geometry,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the maximum distance threshold for proximity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the geometries intersect or are within the specified tolerance; otherwise, false if either geometry is null\.

<a name='DiGi.Geometry.Planar.Query.Inside(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Inside\(this Point2D, Point2D, Point2D, Point2D\) Method

Checks if point is inside tree points \(triangle\)

```csharp
public static bool Inside(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, DiGi.Geometry.Planar.Classes.Point2D? point2D_3);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Inside(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Point to be checked

<a name='DiGi.Geometry.Planar.Query.Inside(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Triangle point 1

<a name='DiGi.Geometry.Planar.Query.Inside(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Triangle point 2

<a name='DiGi.Geometry.Planar.Query.Inside(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_3'></a>

`point2D_3` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Triangle point 3

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True in point2D is inside triangle created by trheer points \(point2D\_1, point2D\_2, point2D\_3\)

<a name='DiGi.Geometry.Planar.Query.Inside(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Inside\(this IEnumerable\<Point2D\>, Point2D\) Method

Determines whether a specified [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is located inside a polygon defined by a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static bool Inside(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Inside(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') vertices that define the boundary of the polygon\.

<a name='DiGi.Geometry.Planar.Query.Inside(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to check for containment within the polygon\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') is inside the polygon; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Geometry.Planar.Query.InternalPoint(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.InternalPoint\(IEnumerable\<Point2D\>, double\) Method

Calculates a point that is strictly internal to the polygon defined by the provided collection of points\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? InternalPoint(System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.InternalPoint(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of points defining the boundary\.

<a name='DiGi.Geometry.Planar.Query.InternalPoint(System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if a point lies on a segment\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') representing an internal point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is invalid or no internal point can be determined\.

<a name='DiGi.Geometry.Planar.Query.InternalVectors(thisDiGi.Geometry.Planar.Interfaces.IPolygon2D)'></a>

## Query\.InternalVectors\(this IPolygon2D\) Method

Retrieves the internal vectors of the specified [DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygon2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Vector2D?>? InternalVectors(this DiGi.Geometry.Planar.Interfaces.IPolygon2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.InternalVectors(thisDiGi.Geometry.Planar.Interfaces.IPolygon2D).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygon2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygon2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D') instance to extract internal vectors from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Vector2D?>` containing the internal vectors, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygon2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygon2D') is null, contains no segments, or has an undefined or collinear orientation\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Query\.Intersect\(this ILinear2D, ILinear2D, double\) Method

Determines whether two linear 2D objects intersect within a specified tolerance\.

```csharp
public static bool Intersect(this DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D_1, DiGi.Geometry.Planar.Interfaces.ILinear2D? linear_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D_1'></a>

`linear2D_1` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The first [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') object\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear_2'></a>

`linear_2` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The second [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') object\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine the intersection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether an intersection point exists between the two linear 2D objects within the specified tolerance\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Query\.Intersect\(this ISegmentable2D, Segment2D, double\) Method

Determines whether a [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') intersects with an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object within a specified tolerance\.

```csharp
public static bool Intersect(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersection\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') segment to intersect with the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the intersection check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the objects intersect; otherwise, false\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.Intersect\(this ISegmentable2D, ISegmentable2D, double\) Method

Determines whether two [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects intersect within a specified tolerance\.

```csharp
public static bool Intersect(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D segmentable2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersection\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersection\.

<a name='DiGi.Geometry.Planar.Query.Intersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used to determine if the objects are within range of each other\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the two [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects intersect; otherwise, false\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D,double)'></a>

## Query\.Intersection\(this Polygon2D, Polygon2D, double\) Method

Calculates the intersection of two 2D polygons\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Intersection(this DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D_1, DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D,double).polygon2D_1'></a>

`polygon2D_1` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The first [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') object to intersect\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D,double).polygon2D_2'></a>

`polygon2D_2` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The second [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') object to intersect\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the resulting intersection polygons, or null if no intersection exists or either input polygon is null\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Query\.Intersection\(this PolygonalFace2D, PolygonalFace2D\) Method

Calculates the intersection of two polygonal faces in 2D space\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? Intersection(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The first polygonal face to intersect\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The second polygonal face to intersect\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects representing the intersection area, or `null` if either input is null or cannot be converted for processing\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Polygon2D_,double)'></a>

## Query\.Intersection\(this IEnumerable\<Polygon2D\>, double\) Method

Calculates the intersection of a collection of 2D polygons\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Intersection(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Polygon2D>? polygon2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersection(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Polygon2D_,double).polygon2Ds'></a>

`polygon2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') objects to intersect\.

<a name='DiGi.Geometry.Planar.Query.Intersection(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Polygon2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the resulting intersection polygons, or null if no intersection exists or the input is null\.

<a name='DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double)'></a>

## Query\.Intersection\<X,T\>\(this IEnumerable\<T\>, double\) Method

Calculates the intersection of a collection of polygonal geometries\.

```csharp
public static System.Collections.Generic.List<X>? Intersection<X,T>(this System.Collections.Generic.IEnumerable<T>? polygonal2Ds, double tolerance=1E-06)
    where X : DiGi.Geometry.Planar.Interfaces.IPolygonal2D
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double).X'></a>

`X`

The type of the resulting polygonal geometries\.

<a name='DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

The type of the input polygonal geometries\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double).polygonal2Ds'></a>

`polygonal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Query\.Intersection\<X,T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of polygonal geometries to be intersected\.

<a name='DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[X](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Intersection_X,T_(thisSystem.Collections.Generic.IEnumerable_T_,double).X 'DiGi\.Geometry\.Planar\.Query\.Intersection\<X,T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the resulting intersection polygons, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double)'></a>

## Query\.IntersectionPoint\(Point2D, Point2D, Point2D, Point2D, bool, double\) Method

Intersection of two segments/lines represented by four point2Ds with given tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D_1_Start, DiGi.Geometry.Planar.Classes.Point2D? point2D_1_End, DiGi.Geometry.Planar.Classes.Point2D? point2D_2_Start, DiGi.Geometry.Planar.Classes.Point2D? point2D_2_End, bool bounded, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double).point2D_1_Start'></a>

`point2D_1_Start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 1 start Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double).point2D_1_End'></a>

`point2D_1_End` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 1 end Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double).point2D_2_Start'></a>

`point2D_2_Start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 2 start Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double).point2D_2_End'></a>

`point2D_2_End` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 2 end Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double).bounded'></a>

`bounded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

if bounded set to false then segments will be treated as lines \(unlimited\)

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

tolerance

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
Intersection Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.IntersectionPoint\(Point2D, Point2D, Point2D, Point2D, Point2D, Point2D, double\) Method

Intersection of two segments represented by four point2Ds with given tolerance\. Output points point2D\_Closest1 and point2D\_Closest2 are null if intersection point is on segments

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D? point2D_1_Start, DiGi.Geometry.Planar.Classes.Point2D? point2D_1_End, DiGi.Geometry.Planar.Classes.Point2D? point2D_2_Start, DiGi.Geometry.Planar.Classes.Point2D? point2D_2_End, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_1_Start'></a>

`point2D_1_Start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 1 start Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_1_End'></a>

`point2D_1_End` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 1 end Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_2_Start'></a>

`point2D_2_Start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 2 start Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_2_End'></a>

`point2D_2_End` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Segment 2 end Point2D

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest1'></a>

`point2D_Closest1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Closest point for Segment 1

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest2'></a>

`point2D_Closest2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Closest point for Segment 2

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.IntersectionPoint\(Segment2D, Segment2D, Point2D, Point2D, double\) Method

Calculates the intersection point of two [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D? segment2D_1, DiGi.Geometry.Planar.Classes.Segment2D? segment2D_2, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).segment2D_1'></a>

`segment2D_1` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The first [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') object\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).segment2D_2'></a>

`segment2D_2` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The second [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') object\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest1'></a>

`point2D_Closest1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') object on the first segment that is closest to the intersection or the other segment\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest2'></a>

`point2D_Closest2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') object on the second segment that is closest to the intersection or the other segment\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value used as a distance tolerance for calculating the intersection\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') object representing the intersection point if one exists within the specified tolerance; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double)'></a>

## Query\.IntersectionPoint\(this ILinear2D, ILinear2D, double\) Method

Calculates the intersection point of two linear 2D entities\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? IntersectionPoint(this DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D_1, DiGi.Geometry.Planar.Interfaces.ILinear2D? linear2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D_1'></a>

`linear2D_1` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The first [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') entity\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).linear2D_2'></a>

`linear2D_2` [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D')

The second [ILinear2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ILinear2D 'DiGi\.Geometry\.Planar\.Interfaces\.ILinear2D') entity\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoint(thisDiGi.Geometry.Planar.Interfaces.ILinear2D,DiGi.Geometry.Planar.Interfaces.ILinear2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for calculating the intersection\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') if an intersection point is found; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.IntersectionPoints\(double, double, double, Point2D, Point2D, double\) Method

Calculates the intersection points between a circle and a line defined by two points\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(double x, double y, double radius, DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the center of the circle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the center of the circle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).radius'></a>

`radius` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The radius of the circle as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first point defining the line as a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')?

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second point defining the line as a [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')?

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(double,double,double,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for calculations as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')? containing the intersection points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no intersections exist or input points are invalid\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Line2D,double)'></a>

## Query\.IntersectionPoints\(this Circle2D, Line2D, double\) Method

Calculates the intersection points between a circle and a line\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Circle2D? circle2D, DiGi.Geometry.Planar.Classes.Line2D? line2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Line2D,double).circle2D'></a>

`circle2D` [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')

The [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') instance to intersect\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Line2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') instance to intersect\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Line2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either input is null or required properties are missing\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Query\.IntersectionPoints\(this Circle2D, Segment2D, double\) Method

Calculates the intersection points between a circle and a line segment\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Circle2D? circle2D, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Segment2D,double).circle2D'></a>

`circle2D` [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')

The [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') instance to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either input is `null` or the circle center is not defined\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.IntersectionPoints\(this Circle2D, ISegmentable2D, double\) Method

Calculates the intersection points between a [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') and an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Circle2D? circle2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).circle2D'></a>

`circle2D` [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')

The [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Circle2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for the intersection calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either input is `null` or no segments are found\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Line2D,double)'></a>

## Query\.IntersectionPoints\(this Ellipse2D, Line2D, double\) Method

Calculates the intersection points between an ellipse and a line\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D, DiGi.Geometry.Planar.Classes.Line2D? line2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Line2D,double).ellipse2D'></a>

`ellipse2D` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') instance to intersect\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Line2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') instance to intersect\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Line2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the distance tolerance for the intersection calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either input is null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Query\.IntersectionPoints\(this Ellipse2D, Segment2D, double\) Method

Calculates the intersection points between an ellipse and a line segment\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D, DiGi.Geometry.Planar.Classes.Segment2D? segment2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Segment2D,double).ellipse2D'></a>

`ellipse2D` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') to intersect\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') to intersect\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either input is null or the segment is invalid\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.IntersectionPoints\(this Ellipse2D, ISegmentable2D, double\) Method

Calculates the intersection points between an [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') and an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Ellipse2D? ellipse2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).ellipse2D'></a>

`ellipse2D` [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D')

The [Ellipse2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Ellipse2D 'DiGi\.Geometry\.Planar\.Classes\.Ellipse2D') to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object containing segments to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Ellipse2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points if successful; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.IntersectionPoints\(this Line2D, ISegmentable2D, double\) Method

Calculates the intersection points between a [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') and an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Line2D? line2D, DiGi.Geometry.Planar.Interfaces.ISegmentable2D segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object containing segments to intersect with\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for the intersection calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if the [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') or segmentable object is null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double)'></a>

## Query\.IntersectionPoints\(this Line2D, IEnumerable\<ISegmentable2D\>, double\) Method

Calculates the intersection points between a [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') and a collection of [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Line2D? line2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

The [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D') to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects to intersect with the line\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either the [line2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).line2D 'DiGi\.Geometry\.Planar\.Query\.IntersectionPoints\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\>, double\)\.line2D') or [segmentable2Ds](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds 'DiGi\.Geometry\.Planar\.Query\.IntersectionPoints\(this DiGi\.Geometry\.Planar\.Classes\.Line2D, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D\>, double\)\.segmentable2Ds') is null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.IntersectionPoints\(this Line2D, IEnumerable\<ISegmentable2D\>, List\<Segment2D\>, double\) Method

Returns intersection points between line and segmentable2D

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Line2D? line2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D> segmentable2Ds, out System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? intersectionSegment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).line2D'></a>

`line2D` [Line2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Line2D 'DiGi\.Geometry\.Planar\.Classes\.Line2D')

Line2D to be intersected

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Segmentable2D to be intersected

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).intersectionSegment2Ds'></a>

`intersectionSegment2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

Segmentable2D segments intersected by line

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Line2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
Intersection Points

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.IntersectionPoints\(this Point2D, Vector2D, IEnumerable\<Segment2D\>, bool, bool, bool, bool, List\<Segment2D\>, double\) Method

Calculates the intersection points between a line defined by a point and a vector, and a collection of 2D segments\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, bool keepDirection, bool removeCollinear, bool sort, bool selfIntersection, out System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? intersectionSegment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The starting [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of the line\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The direction [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') of the line\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An `IEnumerable<Segment2D>` containing the segments to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).keepDirection'></a>

`keepDirection` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether to keep only points that follow the direction of the vector\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).removeCollinear'></a>

`removeCollinear` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether collinear segments should be removed from the results\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).sort'></a>

`sort` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the resulting intersection points should be sorted\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).selfIntersection'></a>

`selfIntersection` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether to include self\-intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).intersectionSegment2Ds'></a>

`intersectionSegment2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a `List<Segment2D>` of segments that were intersected\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Point2D>` containing the intersection points, or null if no intersections are found or input parameters are invalid\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.IntersectionPoints\(this Point2D, Vector2D, IEnumerable\<ISegmentable2D\>, bool, bool, bool, bool, List\<Segment2D\>, double\) Method

Calculates the intersection points between a ray or line defined by a point and a vector, and a collection of segmentable 2D objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Classes.Point2D? point2D, DiGi.Geometry.Planar.Classes.Vector2D? vector2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, bool keepDirection, bool removeCollinear, bool sort, bool selfIntersection, out System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? intersectionSegment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') starting point\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).vector2D'></a>

`vector2D` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') direction vector\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of segmentable 2D objects to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).keepDirection'></a>

`keepDirection` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether to keep the direction of the intersection points\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).removeCollinear'></a>

`removeCollinear` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether collinear points should be removed\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).sort'></a>

`sort` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether the resulting intersection points should be sorted\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).selfIntersection'></a>

`selfIntersection` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') indicating whether self\-intersections are considered\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).intersectionSegment2Ds'></a>

`intersectionSegment2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of the segments that were intersected; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Vector2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,bool,bool,bool,bool,System.Collections.Generic.List_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points if successful; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.IntersectionPoints\(this ISegmentable2D, ISegmentable2D, double\) Method

Calculates the intersection points between two segmentable 2D objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2, double tolerace=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerace'></a>

`tolerace` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if points intersect\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either [segmentable2D\_1](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1 'DiGi\.Geometry\.Planar\.Query\.IntersectionPoints\(this DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, double\)\.segmentable2D\_1') or [segmentable2D\_2](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2 'DiGi\.Geometry\.Planar\.Query\.IntersectionPoints\(this DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, double\)\.segmentable2D\_2') is `null`\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.IntersectionPoints\(this ISegmentable2D, IEnumerable\<Segment2D\>, double\) Method

Calculates the intersection points between an [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object and a collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') segments\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerace=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') containing the segments to intersect with\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerace'></a>

`tolerace` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of intersection points if successful; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.IntersectionPoints\(this IEnumerable\<Segment2D\>, IEnumerable\<Segment2D\>, double\) Method

Calculates the intersection points between two collections of 2D segments\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds_1, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds_1'></a>

`segment2Ds_1` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The first [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of segments\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds_2'></a>

`segment2Ds_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The second [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of segments\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the intersection points, or `null` if either input collection is null\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double)'></a>

## Query\.IntersectionPoints\(this IEnumerable\<Segment2D\>, IEnumerable\<Segment2D\>, int, double\) Method

Calculates the intersection points between two collections of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds_1, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds_2, int maxCount, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).segment2Ds_1'></a>

`segment2Ds_1` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The first collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).segment2Ds_2'></a>

`segment2Ds_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The second collection of [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of intersection points to find as an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the calculation as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the found intersection points, or `null` if either collection is null or empty, or if [maxCount](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.IntersectionPoints(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,int,double).maxCount 'DiGi\.Geometry\.Planar\.Query\.IntersectionPoints\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Classes\.Segment2D\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Planar\.Classes\.Segment2D\>, int, double\)\.maxCount') is less than 1\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints_T_(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double)'></a>

## Query\.IntersectionPoints\<T\>\(this ISegmentable2D, IEnumerable\<ISegmentable2D\>, double\) Method

Calculates the intersection points between a segmentable 2D object and a collection of other segmentable 2D objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? IntersectionPoints<T>(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, double tolerace=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints_T_(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).T'></a>

`T`

The type of the segmentable 2D object, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints_T_(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to check for intersections\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints_T_(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of segmentable 2D objects to intersect with the source object\.

<a name='DiGi.Geometry.Planar.Query.IntersectionPoints_T_(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,double).tolerace'></a>

`tolerace` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for intersection calculations as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the found intersection points, or `null` if either input is null\.

<a name='DiGi.Geometry.Planar.Query.IsoperimetricRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.IsoperimetricRatio\(this IPolygonal2D\) Method

Calculates the isoperimetric ratio of the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object\.

```csharp
public static double IsoperimetricRatio(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.IsoperimetricRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to calculate the ratio for\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated isoperimetric ratio as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object is null or if its area or perimeter is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.LongestPath(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.LongestPath\(this IEnumerable\<ISegmentable2D\>, Point2D, double\) Method

Returns longest path in given segmentable2Ds with exclusion of loops\. If loops exists method will find shortest path through the loop

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? LongestPath(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.ISegmentable2D>? segmentable2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D_Start=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.LongestPath(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Segmentable2Ds

<a name='DiGi.Geometry.Planar.Query.LongestPath(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Start'></a>

`point2D_Start` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

Point to start from\. If null then Method will find points with the longest paths

<a name='DiGi.Geometry.Planar.Query.LongestPath(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.ISegmentable2D_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
List of Point2Ds representing the longest path

<a name='DiGi.Geometry.Planar.Query.Max(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Max\(this Point2D, Point2D\) Method

Returns the maximum of two `Point2D?` values\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Max(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Max(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first `Point2D?` value to compare\.

<a name='DiGi.Geometry.Planar.Query.Max(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second `Point2D?` value to compare\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The maximum of the two `Point2D?` values, or `null` if either input is `null`\.

<a name='DiGi.Geometry.Planar.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Max\(this IEnumerable\<Point2D\>\) Method

Returns the maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from the specified collection\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Max(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<Point2D>` collection to evaluate\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found in the collection, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Max\(this IEnumerable\<Point2D\>, Point2D\) Method

Returns the maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from the specified collection, while also retrieving the minimum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Max(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, out DiGi.Geometry.Planar.Classes.Point2D? min);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Max(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).min'></a>

`min` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') with the minimum value, or null if the collection is empty\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') with the maximum value, or null if the collection is empty\.

<a name='DiGi.Geometry.Planar.Query.MaxDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.MaxDistance\(this IEnumerable\<Point2D\>\) Method

Calculates the maximum distance between any two points in the provided collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static double MaxDistance(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.MaxDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The `IEnumerable<Point2D>` containing the points to evaluate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The maximum distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the `IEnumerable<Point2D>` is null or empty\.

<a name='DiGi.Geometry.Planar.Query.MaxDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.MaxDistance\(this IEnumerable\<Point2D\>, Point2D, Point2D\) Method

Calculates the maximum distance between any two points in the provided collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static double MaxDistance(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, out DiGi.Geometry.Planar.Classes.Point2D? point2D_1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.MaxDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') collection of points to evaluate\.

<a name='DiGi.Geometry.Planar.Query.MaxDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the first [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of the pair with the maximum distance, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.MaxDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the second [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of the pair with the maximum distance, or null if the collection is null or empty\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The maximum distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double'), or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the `IEnumerable<Point2D>` is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Min\(this Point2D, Point2D\) Method

Returns the minimum of two `Point2D?` points\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Min(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first `Point2D?` point\.

<a name='DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second `Point2D?` point\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The minimum of the two `Point2D?` points, or `null` if either input is `null`\.

<a name='DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Min\(this ISegmentable2D, Point2D\) Method

Calculates the minimum and maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points of the specified [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Min(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, out DiGi.Geometry.Planar.Classes.Point2D? max);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') object to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D).max'></a>

`max` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The minimum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [segmentable2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Min(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D).segmentable2D 'DiGi\.Geometry\.Planar\.Query\.Min\(this DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D, DiGi\.Geometry\.Planar\.Classes\.Point2D\)\.segmentable2D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Min\(this IEnumerable\<Point2D\>\) Method

Returns the minimum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from the specified collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Min(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D?>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to evaluate\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The minimum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found in the collection, or null if the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Min\(this IEnumerable\<Point2D\>, Point2D\) Method

Calculates the minimum and maximum points from a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Min(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D?>? point2Ds, out DiGi.Geometry.Planar.Classes.Point2D? max);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Min(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).max'></a>

`max` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found; otherwise, null\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The minimum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found in the collection; otherwise, null if the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Min_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Min\<T\>\(this IEnumerable\<T\>, Point2D\) Method

Calculates the minimum and maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') coordinates from a collection of objects that implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Min<T>(this System.Collections.Generic.IEnumerable<T?>? segmentable2Ds, out DiGi.Geometry.Planar.Classes.Point2D? max)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Min_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).T'></a>

`T`

The type of elements in the collection, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Min_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Min_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).T 'DiGi\.Geometry\.Planar\.Query\.Min\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, DiGi\.Geometry\.Planar\.Classes\.Point2D\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') objects to evaluate\.

<a name='DiGi.Geometry.Planar.Query.Min_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D).max'></a>

`max` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the maximum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found in the collection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no points were found\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The minimum [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') found in the collection, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or empty\.

<a name='DiGi.Geometry.Planar.Query.MinDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.MinDistance\(this IEnumerable\<Point2D\>\) Method

Calculates the minimum distance between any two points in the provided collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static double MinDistance(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.MinDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An `IEnumerable<Point2D>` containing the points to evaluate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the minimum distance found, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.MinDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.MinDistance\(this IEnumerable\<Point2D\>, Point2D, Point2D\) Method

Calculates the minimum distance between any two points in a collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects\.

```csharp
public static double MinDistance(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, out DiGi.Geometry.Planar.Classes.Point2D? point2D_1, out DiGi.Geometry.Planar.Classes.Point2D? point2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.MinDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects to analyze\.

<a name='DiGi.Geometry.Planar.Query.MinDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the first [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of the pair with the minimum distance; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.MinDistance(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

When this method returns, contains the second [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of the pair with the minimum distance; otherwise, null\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The minimum distance as a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the collection is null or empty\.

<a name='DiGi.Geometry.Planar.Query.Normals(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Side)'></a>

## Query\.Normals\(this IPolygonal2D, Side\) Method

Calculates the normal vectors for each segment of the specified polygonal object based on the provided side\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Vector2D?>? Normals(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, DiGi.Geometry.Core.Enums.Side side=DiGi.Geometry.Core.Enums.Side.External);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Normals(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Side).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to calculate normals for\.

<a name='DiGi.Geometry.Planar.Query.Normals(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Core.Enums.Side).side'></a>

`side` [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side')

The [Side](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Side 'DiGi\.Geometry\.Core\.Enums\.Side') specifying whether the external or internal normal vectors should be calculated\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A `List<Vector2D?>` containing the normal vectors, or `null` if the [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') is null, contains invalid segments, or has a collinear or undefined orientation\.

<a name='DiGi.Geometry.Planar.Query.ObtuseAngles(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.ObtuseAngles\(this IPolygonal2D\) Method

Determines whether the angles of the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object are obtuse\.

```csharp
public static System.Collections.Generic.List<bool>? ObtuseAngles(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ObtuseAngles(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to analyze\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') values indicating if each angle is obtuse, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input object or its points are null\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Circle2D,double)'></a>

## Query\.Offset\(this Circle2D, double\) Method

Offsets the radius of the specified [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') by a given amount\.

```csharp
public static DiGi.Geometry.Planar.Classes.Circle2D? Offset(this DiGi.Geometry.Planar.Classes.Circle2D? circle2D, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Circle2D,double).circle2D'></a>

`circle2D` [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')

The [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') instance to offset\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Circle2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value to add to the radius of the circle\.

#### Returns
[Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D')  
A new [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') with the adjusted radius, or `null` if the input [Circle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Circle2D 'DiGi\.Geometry\.Planar\.Classes\.Circle2D') is `null`, its center is `null`, or its radius is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double)'></a>

## Query\.Offset\(this Polygon2D, double\) Method

Offsets the specified [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') by a given distance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Offset(this DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') to offset\. Can be null\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the offset distance\. Positive values expand the polygon, while negative values shrink it\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the resulting offset polygons, or null if the input [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') is null\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double,BufferParameters)'></a>

## Query\.Offset\(this Polygon2D, double, BufferParameters\) Method

Offsets the specified [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Offset(this DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D, double offset, BufferParameters bufferParameters);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double,BufferParameters).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') to be offset\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double,BufferParameters).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance by which to offset the polygon\. A positive [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value expands the polygon, while a negative [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value contracts it\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Polygon2D,double,BufferParameters).bufferParameters'></a>

`bufferParameters` [NetTopologySuite\.Operation\.Buffer\.BufferParameters](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.operation.buffer.bufferparameters 'NetTopologySuite\.Operation\.Buffer\.BufferParameters')

The [NetTopologySuite\.Operation\.Buffer\.BufferParameters](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.operation.buffer.bufferparameters 'NetTopologySuite\.Operation\.Buffer\.BufferParameters') used to configure the buffering operation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the resulting offset polygons, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or the [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') offset value is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Rectangle2D,double)'></a>

## Query\.Offset\(this Rectangle2D, double\) Method

Offsets the specified [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') by a given value\.

```csharp
public static DiGi.Geometry.Planar.Classes.Rectangle2D? Offset(this DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Rectangle2D,double).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') to offset\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Rectangle2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value used to offset the rectangle's origin and dimensions\.

#### Returns
[Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')  
A new [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D') that is offset by the specified value, or null if the input rectangle or its properties are invalid\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Triangle2D,double)'></a>

## Query\.Offset\(this Triangle2D, double\) Method

Offsets the specified [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') by a given distance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Triangle2D? Offset(this DiGi.Geometry.Planar.Classes.Triangle2D? triangle2D, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Triangle2D,double).triangle2D'></a>

`triangle2D` [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')

The [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') instance to offset\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Classes.Triangle2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the offset distance\.

#### Returns
[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')  
A new [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') resulting from the offset operation, or null if the input is null or the result cannot be formed into a triangle\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Query\.Offset\(this IPolygonal2D, double\) Method

Offsets the specified [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') by a given distance\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D>? Offset(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, double offset);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to offset\.

<a name='DiGi.Geometry.Planar.Query.Offset(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).offset'></a>

`offset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the offset distance\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the resulting offset polygonal shapes, or null if the input is null or no result is produced\.

<a name='DiGi.Geometry.Planar.Query.On(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.On\(this ISegmentable2D, Point2D, double\) Method

Checks if a point lies on a segmentable geometry within a given tolerance\.

```csharp
public static bool On(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.On(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry to check\.

<a name='DiGi.Geometry.Planar.Query.On(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Query.On(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the geometry, otherwise false\.

<a name='DiGi.Geometry.Planar.Query.On(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.On\(this IEnumerable\<Segment2D\>, Point2D, double\) Method

Checks if a point lies on any of the provided segments within a given tolerance\.

```csharp
public static bool On(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D?>? segment2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.On(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments to check\.

<a name='DiGi.Geometry.Planar.Query.On(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Query.On(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on any segment, otherwise false\.

<a name='DiGi.Geometry.Planar.Query.On_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.On\<T\>\(this IEnumerable\<T\>, Point2D, double\) Method

Checks if a point lies on any of the provided segmentable geometries within a given tolerance\.

```csharp
public static bool On<T>(this System.Collections.Generic.IEnumerable<T>? segmentable2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.On_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,double).T'></a>

`T`

The type of segmentable geometry, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.On_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.On_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,double).T 'DiGi\.Geometry\.Planar\.Query\.On\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, DiGi\.Geometry\.Planar\.Classes\.Point2D, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable geometries to check\.

<a name='DiGi.Geometry.Planar.Query.On_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point to evaluate\.

<a name='DiGi.Geometry.Planar.Query.On_T_(thisSystem.Collections.Generic.IEnumerable_T_,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine if the point is on the geometry\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies on any of the provided geometries within the specified tolerance; otherwise, false\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Orientation\(this Point2D, Point2D, Point2D\) Method

Determines the orientation of three points \(clockwise, counter\-clockwise, or collinear\)\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, DiGi.Geometry.Planar.Classes.Point2D? point2D_3);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first point\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second point\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D).point2D_3'></a>

`point2D_3` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The third point\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
The orientation of the triplet\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Query\.Orientation\(this Vector2D, Vector2D\) Method

Determines the orientation of two vectors \(clockwise, counter\-clockwise, or collinear\)\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
The orientation of the vectors\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool)'></a>

## Query\.Orientation\(this IPolygonal2D, bool\) Method

Determines the overall orientation of a polygonal geometry\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to use the convex hull for determination\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
The orientation of the geometry\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool)'></a>

## Query\.Orientation\(this IEnumerable\<Point2D\>, bool\) Method

Determines the overall orientation of a collection of points\.

```csharp
public static DiGi.Geometry.Core.Enums.Orientation Orientation(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, bool convexHull=true);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Orientation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points\.

<a name='DiGi.Geometry.Planar.Query.Orientation(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,bool).convexHull'></a>

`convexHull` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to use the convex hull for determination\.

#### Returns
[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')  
The orientation of the point set\.

<a name='DiGi.Geometry.Planar.Query.Orientations(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Orientations\(this IEnumerable\<Point2D\>\) Method

Calculates the orientations of all consecutive point triplets in a collection of points\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Core.Enums.Orientation>? Orientations(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Orientations(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Orientation](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.Orientation 'DiGi\.Geometry\.Core\.Enums\.Orientation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of orientations for each triplet, or null if not possible\.

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D)'></a>

## Query\.Parameter\(this IEnumerable\<Point2D\>, Point2D\) Method

Calculates the normalized parameter of a point relative to a polyline defined by a collection of points\.

```csharp
public static double Parameter(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points defining the polyline\.

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The normalized parameter value, or NaN if not possible\.

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Parameter\(this IEnumerable\<Point2D\>, Point2D, Point2D, double\) Method

Calculates the normalized parameter of a point relative to a polyline defined by a collection of points\.

```csharp
public static double Parameter(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, DiGi.Geometry.Planar.Classes.Point2D? point2D, out DiGi.Geometry.Planar.Classes.Point2D? point2D_Closest, out double distance);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points defining the polyline\.

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The target point\.

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_Closest'></a>

`point2D_Closest` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The closest point on the polyline to the target point\.

<a name='DiGi.Geometry.Planar.Query.Parameter(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance from the target point to its closest point on the polyline\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The normalized parameter value, or NaN if not possible\.

<a name='DiGi.Geometry.Planar.Query.Point(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.Point\(this IEnumerable\<Point2D\>, double\) Method

Calculates a point along a polyline defined by a collection of points, given a parameter \(normalized length\)\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, double parameter);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Point(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of points defining the polyline\.

<a name='DiGi.Geometry.Planar.Query.Point(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,double).parameter'></a>

`parameter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The normalized distance along the polyline\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The calculated point, or null if not possible\.

<a name='DiGi.Geometry.Planar.Query.Points_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Points\<T\>\(this IEnumerable\<T\>\) Method

Extracts all points from a collection of segmentable 2D geometries and flattens them into a single list\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D?>? Points<T>(this System.Collections.Generic.IEnumerable<T?>? segmentable2Ds)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Points_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the segmentable 2D geometry, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Points_T_(thisSystem.Collections.Generic.IEnumerable_T_).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Points_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Geometry\.Planar\.Query\.Points\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable 2D geometries to extract points from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all extracted [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects, or null if the input collection is null\.

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double)'></a>

## Query\.Rectangular\(this IPolygonal2D, Rectangle2D, double\) Method

Checks if a polygonal geometry is rectangular within a given tolerance and returns the resulting rectangle\.

```csharp
public static bool Rectangular(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, out DiGi.Geometry.Planar.Classes.Rectangle2D? rectangle2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry to check\.

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double).rectangle2D'></a>

`rectangle2D` [Rectangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Rectangle2D 'DiGi\.Geometry\.Planar\.Classes\.Rectangle2D')

The resulting rectangle if the geometry is rectangular\.

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Geometry.Planar.Classes.Rectangle2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry is rectangular, otherwise false\.

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Query\.Rectangular\(this IPolygonal2D, double\) Method

Checks if a polygonal geometry is rectangular within a given tolerance\.

```csharp
public static bool Rectangular(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry to check\.

<a name='DiGi.Geometry.Planar.Query.Rectangular(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry is rectangular, otherwise false\.

<a name='DiGi.Geometry.Planar.Query.Rectangularity(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Query\.Rectangularity\(this IPolygonal2D, double\) Method

Calculates the rectangularity of a polygonal geometry \(ratio of its area to the area of its bounding rectangle\)\.

```csharp
public static double Rectangularity(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Rectangularity(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry\.

<a name='DiGi.Geometry.Planar.Query.Rectangularity(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for creating the bounding rectangle\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The rectangularity value, or NaN if calculation is not possible\.

<a name='DiGi.Geometry.Planar.Query.RectangularThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Query\.RectangularThinnessRatio\(this IPolygonal2D, double\) Method

Calculates the rectangular thinness ratio of a polygonal geometry based on its bounding rectangle's area\.

```csharp
public static double RectangularThinnessRatio(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D polygonal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.RectangularThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry\.

<a name='DiGi.Geometry.Planar.Query.RectangularThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for creating the bounding rectangle\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The rectangular thinness ratio, or NaN if calculation is not possible\.

<a name='DiGi.Geometry.Planar.Query.SameHalf(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double)'></a>

## Query\.SameHalf\(this Vector2D, Vector2D, double\) Method

Checks if two vectors point in the same general direction \(half\-plane\) within a given tolerance\.

```csharp
public static bool SameHalf(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2, double tolerance=0.0349066);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.SameHalf(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector\.

<a name='DiGi.Geometry.Planar.Query.SameHalf(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector\.

<a name='DiGi.Geometry.Planar.Query.SameHalf(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle tolerance for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if vectors are in the same half\-plane, otherwise false\.

<a name='DiGi.Geometry.Planar.Query.Segment2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Segment2Ds\<T\>\(this IEnumerable\<T\>\) Method

Retrieves all segments from a collection of polygonal faces\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Segment2Ds<T>(this System.Collections.Generic.IEnumerable<T>? polygonalFace2Ds)
    where T : DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Segment2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the polygonal face elements, which must implement [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Segment2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_).polygonalFace2Ds'></a>

`polygonalFace2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Segment2Ds_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Geometry\.Planar\.Query\.Segment2Ds\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of polygonal faces to extract segments from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all extracted [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') objects, or null if the input collection is null\.

<a name='DiGi.Geometry.Planar.Query.Segments(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Query\.Segments\(this IPolygonalFace2D\) Method

Retrieves all segments \(external and internal\) from a polygonal face\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Segments(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Segments(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The polygonal face to extract segments from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of all segments in the polygonal face\.

<a name='DiGi.Geometry.Planar.Query.Segments_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Segments\<T\>\(this IEnumerable\<T\>\) Method

Retrieves all segments from a collection of segmentable 2D geometries\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Segments<T>(this System.Collections.Generic.IEnumerable<T>? segmentable2Ds)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Segments_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the segmentable geometry, which must implement [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Segments_T_(thisSystem.Collections.Generic.IEnumerable_T_).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Segments_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Geometry\.Planar\.Query\.Segments\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable 2D geometries to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all segments extracted from the provided geometries, or null if the input collection is null\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.SelfIntersect\(this ISegmentable2D, double\) Method

Checks if a segmentable geometry self\-intersects within a given tolerance\.

```csharp
public static bool SelfIntersect(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.SelfIntersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry to check\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersect(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the geometry self\-intersects, otherwise false\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionPolygons(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double)'></a>

## Query\.SelfIntersectionPolygons\(this IPolygonal2D, double, double\) Method

Identifies polygons that are formed by self\-intersections in a polygonal geometry\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? SelfIntersectionPolygons(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, double maxLength, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionPolygons(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry to analyze\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionPolygons(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double).maxLength'></a>

`maxLength` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum length for an intersection segment to be considered\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionPolygons(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of polygons formed by self\-intersections\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double,double)'></a>

## Query\.SelfIntersectionSegments\(this ISegmentable2D, double, double\) Method

Identifies segments that are part of self\-intersections in a segmentable geometry\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? SelfIntersectionSegments(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double maxLength, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry to analyze\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double,double).maxLength'></a>

`maxLength` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum length for an intersection segment to be considered\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of segments that are self\-intersections\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double,double)'></a>

## Query\.SelfIntersectionSegments\(this IEnumerable\<Segment2D\>, double, double\) Method

Identifies segments that are part of self\-intersections in a collection of segments\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? SelfIntersectionSegments(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double maxLength, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments to analyze\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double,double).maxLength'></a>

`maxLength` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum length for an intersection segment to be considered\.

<a name='DiGi.Geometry.Planar.Query.SelfIntersectionSegments(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of segments that are self\-intersections\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.Similar\(this Point2D, Point2D, double\) Method

Checks if two points are similar \(almost equal\) within a given tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Planar.Classes.Point2D? point2D_1, DiGi.Geometry.Planar.Classes.Point2D? point2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_1'></a>

`point2D_1` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The first point to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D_2'></a>

`point2D_2` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The second point to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine similarity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the points are similar; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double)'></a>

## Query\.Similar\(this Segment2D, Segment2D, double\) Method

Checks if two segments are similar \(identical endpoints regardless of order\) within a given tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D_1, DiGi.Geometry.Planar.Classes.Segment2D? segment2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D_1'></a>

`segment2D_1` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The first segment to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double).segment2D_2'></a>

`segment2D_2` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The second segment to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Segment2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine similarity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the segments are similar; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double)'></a>

## Query\.Similar\(this Vector2D, Vector2D, double\) Method

Checks if two vectors are similar \(identical or opposite\) within a specified tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Planar.Classes.Vector2D? vector2D_1, DiGi.Geometry.Planar.Classes.Vector2D? vector2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D_1'></a>

`vector2D_1` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The first vector to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double).vector2D_2'></a>

`vector2D_2` [Vector2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Vector2D 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The second vector to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Classes.Vector2D,DiGi.Geometry.Planar.Classes.Vector2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine similarity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the vectors are similar; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double)'></a>

## Query\.Similar\(this IPolygonalFace2D, IPolygonalFace2D, double\) Method

Checks if two polygonal faces are similar within a given tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).polygonalFace2D_1'></a>

`polygonalFace2D_1` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The first polygonal face to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).polygonalFace2D_2'></a>

`polygonalFace2D_2` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The second polygonal face to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the similarity check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the two polygonal faces are similar; otherwise, false\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.Similar\(this ISegmentable2D, ISegmentable2D, double\) Method

Checks if two segmentable 2D geometries are similar within a specified tolerance\.

```csharp
public static bool Similar(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_1, DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_1'></a>

`segmentable2D_1` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The first segmentable geometry to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D_2'></a>

`segmentable2D_2` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The second segmentable geometry to compare\.

<a name='DiGi.Geometry.Planar.Query.Similar(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine similarity\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the geometries are similar; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Split(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double)'></a>

## Query\.Split\(this ISegmentable2D, double\) Method

Splits a segmentable geometry into smaller segments based on their intersections\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Split(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Split(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable geometry to split\.

<a name='DiGi.Geometry.Planar.Query.Split(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the resulting split segments\.

<a name='DiGi.Geometry.Planar.Query.Split(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double)'></a>

## Query\.Split\(this IEnumerable\<Segment2D\>, double\) Method

Splits a collection of segments into smaller segments based on their intersections\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Split(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Segment2D>? segment2Ds, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Split(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).segment2Ds'></a>

`segment2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segments to split\.

<a name='DiGi.Geometry.Planar.Query.Split(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Segment2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the resulting split segments\.

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Collections.Generic.IEnumerable_T_,double)'></a>

## Query\.Split\<T\>\(this IPolygonalFace2D, IEnumerable\<T\>, double\) Method

Splits a polygonal face into multiple faces using a collection of segmentable geometries as cutting lines\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? Split<T>(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D, System.Collections.Generic.IEnumerable<T>? segmentable2Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

A type that implements the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') interface\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Collections.Generic.IEnumerable_T_,double).polygonalFace2D'></a>

`polygonalFace2D` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The polygonal face to split\.

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Collections.Generic.IEnumerable_T_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Split_T_(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Query\.Split\<T\>\(this DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D, System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable geometries used for splitting\.

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,System.Collections.Generic.IEnumerable_T_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the resulting split polygonal faces, or null if the input is null or no faces could be created\.

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisSystem.Collections.Generic.IEnumerable_T_,double)'></a>

## Query\.Split\<T\>\(this IEnumerable\<T\>, double\) Method

Splits a collection of segmentable geometries into smaller segments based on their intersections\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Segment2D>? Split<T>(this System.Collections.Generic.IEnumerable<T>? segmentable2Ds, double tolerance=1E-06)
    where T : DiGi.Geometry.Planar.Interfaces.ISegmentable2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T'></a>

`T`

A type that implements the [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D') interface\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).segmentable2Ds'></a>

`segmentable2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Split_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).T 'DiGi\.Geometry\.Planar\.Query\.Split\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, double\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segmentable geometries to split\.

<a name='DiGi.Geometry.Planar.Query.Split_T_(thisSystem.Collections.Generic.IEnumerable_T_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for intersection detection\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the resulting split segments, or null if the input is null\.

<a name='DiGi.Geometry.Planar.Query.SquareThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double)'></a>

## Query\.SquareThinnessRatio\(this IPolygonal2D, double\) Method

Calculates the square thinness ratio of a polygonal geometry based on its bounding rectangle\.

```csharp
public static double SquareThinnessRatio(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D polygonal2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.SquareThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal 2D geometry to analyze\.

<a name='DiGi.Geometry.Planar.Query.SquareThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for creating the bounding rectangle\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The square thinness ratio, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the input is null, the area is not a number, or the bounding rectangle cannot be created\.

<a name='DiGi.Geometry.Planar.Query.ThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D)'></a>

## Query\.ThinnessRatio\(this IPolygonal2D\) Method

Calculates the thinness ratio of a polygonal geometry based on its area and perimeter\.

```csharp
public static double ThinnessRatio(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D polygonal2D);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.ThinnessRatio(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry for which to calculate the thinness ratio\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated thinness ratio, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the input is null or if the area or perimeter cannot be determined\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this BoundingBox2D, Func\<Point2D,Point2D\>\) Method

Transforms a bounding box by applying the specified transformation function to its minimum and maximum points\.

```csharp
public static DiGi.Geometry.Planar.Classes.BoundingBox2D? Transform(this DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).boundingBox2D'></a>

`boundingBox2D` [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The bounding box to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.BoundingBox2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')  
A new [BoundingBox2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.BoundingBox2D 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') representing the transformed bounding box, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input bounding box or function is null, or if the transformation fails to produce valid points\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Point2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this Point2D, Func\<Point2D,Point2D\>\) Method

Transforms a point by applying the specified transformation function\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Transform(this DiGi.Geometry.Planar.Classes.Point2D? point2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Point2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Point2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map the [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The transformed [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input point or transformation function is null\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Polygon2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this Polygon2D, Func\<Point2D,Point2D\>\) Method

Transforms a polygon by applying the specified transformation function to its vertices\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Transform(this DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Polygon2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).polygon2D'></a>

`polygon2D` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The polygon to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Polygon2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A new [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') representing the transformed polygon, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input polygon or function is null, or if the transformation fails to produce a valid geometry\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.Transform\(this PolygonalFace2D, Func\<Point2D,Point2D\>, double\) Method

Transforms a polygonal face by applying the specified transformation function to its vertices\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? Transform(this DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double).polygonalFace2D'></a>

`polygonalFace2D` [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during the creation of the transformed polygonal edges\.

#### Returns
[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A new [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') representing the transformed face, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input face or function is null, or if the transformation fails to produce a valid geometry\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Polyline2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this Polyline2D, Func\<Point2D,Point2D\>\) Method

Transforms a polyline by applying the specified transformation function to its vertices\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polyline2D? Transform(this DiGi.Geometry.Planar.Classes.Polyline2D? polyline2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Polyline2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).polyline2D'></a>

`polyline2D` [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')

The polyline to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Polyline2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D')  
A new [Polyline2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polyline2D 'DiGi\.Geometry\.Planar\.Classes\.Polyline2D') representing the transformed polyline, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input polyline or function is null, or if the transformation fails to produce a valid geometry\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this Segment2D, Func\<Point2D,Point2D\>\) Method

Transforms a segment by applying the specified transformation function to its start and end points\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Transform(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The segment to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Segment2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A new [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') representing the transformed segment, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input segment or function is null, or if the transformation fails to produce valid points\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Triangle2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this Triangle2D, Func\<Point2D,Point2D\>\) Method

Transforms a triangle by applying the specified transformation function to its vertices\.

```csharp
public static DiGi.Geometry.Planar.Classes.Triangle2D? Transform(this DiGi.Geometry.Planar.Classes.Triangle2D? triangle2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Triangle2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).triangle2D'></a>

`triangle2D` [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')

The triangle to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Classes.Triangle2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D')  
A new [Triangle2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Triangle2D 'DiGi\.Geometry\.Planar\.Classes\.Triangle2D') representing the transformed triangle, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input triangle or function is null, or if the transformation fails to produce a valid geometry\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double)'></a>

## Query\.Transform\(this IPolygonal2D, Func\<Point2D,Point2D\>, double\) Method

Transforms a polygonal geometry by applying the specified transformation function to its points\.

```csharp
public static DiGi.Geometry.Planar.Interfaces.IPolygonal2D? Transform(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal geometry to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function used to transform each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') of the polygonal geometry\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used when creating the resulting polygonal geometry\.

#### Returns
[IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')  
A new transformed [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance, or `null` if the input geometry or transformation function is `null`\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_)'></a>

## Query\.Transform\(this IEnumerable\<Point2D\>, Func\<Point2D,Point2D\>\) Method

Transforms a collection of points by applying the specified transformation function to each point\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D?>? Transform(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Classes.Point2D>? point2Ds, System.Func<DiGi.Geometry.Planar.Classes.Point2D?,DiGi.Geometry.Planar.Classes.Point2D?>? func);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Transform(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).point2Ds'></a>

`point2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points to transform\.

<a name='DiGi.Geometry.Planar.Query.Transform(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Classes.Point2D_,System.Func_DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Planar.Classes.Point2D_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The transformation function used to map each [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') to a new position\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the transformed [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D') points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection or transformation function is null\.

<a name='DiGi.Geometry.Planar.Query.Triangulate(thisPolygon,double)'></a>

## Query\.Triangulate\(this Polygon, double\) Method

Triangulates the specified polygon into a set of smaller triangle polygons\.

```csharp
public static System.Collections.Generic.List<Polygon>? Triangulate(this Polygon? polygon, double tolerance=1E-09);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Triangulate(thisPolygon,double).polygon'></a>

`polygon` [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')

The polygon to be triangulated\.

<a name='DiGi.Geometry.Planar.Query.Triangulate(thisPolygon,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for precision during the triangulation process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of triangles that represent the original polygon, or null if the input polygon is null or the triangulation fails\.

<a name='DiGi.Geometry.Planar.Query.TryConvert_TPolygonal2D_(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_TPolygonal2D_,double)'></a>

## Query\.TryConvert\<TPolygonal2D\>\(this IPolygonal2D, List\<TPolygonal2D\>, double\) Method

Attempts to convert a polygonal geometry to a specific type of polygonal geometry\.

```csharp
public static bool TryConvert<TPolygonal2D>(this DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, out System.Collections.Generic.List<TPolygonal2D>? polygonal2Ds, double tolerance=1E-06)
    where TPolygonal2D : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.TryConvert_TPolygonal2D_(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_TPolygonal2D_,double).TPolygonal2D'></a>

`TPolygonal2D`

The target polygonal geometry type that implements [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.TryConvert_TPolygonal2D_(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_TPolygonal2D_,double).polygonal2D'></a>

`polygonal2D` [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The source polygonal geometry to be converted\.

<a name='DiGi.Geometry.Planar.Query.TryConvert_TPolygonal2D_(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_TPolygonal2D_,double).polygonal2Ds'></a>

`polygonal2Ds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TPolygonal2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.TryConvert_TPolygonal2D_(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_TPolygonal2D_,double).TPolygonal2D 'DiGi\.Geometry\.Planar\.Query\.TryConvert\<TPolygonal2D\>\(this DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, System\.Collections\.Generic\.List\<TPolygonal2D\>, double\)\.TPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns true, contains the list of converted polygonal geometries; otherwise, null\.

<a name='DiGi.Geometry.Planar.Query.TryConvert_TPolygonal2D_(thisDiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Collections.Generic.List_TPolygonal2D_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during conversion\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the conversion was successful; otherwise, `false`\.

<a name='DiGi.Geometry.Planar.Query.Union(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D)'></a>

## Query\.Union\(this Polygon2D, Polygon2D\) Method

Calculates the union of two 2D polygons\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Union(this DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D_1, DiGi.Geometry.Planar.Classes.Polygon2D? polygon2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Union(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D).polygon2D_1'></a>

`polygon2D_1` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The first polygon to include in the union operation\.

<a name='DiGi.Geometry.Planar.Query.Union(thisDiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Planar.Classes.Polygon2D).polygon2D_2'></a>

`polygon2D_2` [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The second polygon to include in the union operation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') objects representing the resulting union, or `null` if either input polygon is `null`\.

<a name='DiGi.Geometry.Planar.Query.Union(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D)'></a>

## Query\.Union\(this IPolygonalFace2D, IPolygonalFace2D\) Method

Calculates the geometric union of two polygonal faces\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? Union(this DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_1, DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D? polygonalFace2D_2);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Union(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_1'></a>

`polygonalFace2D_1` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The first polygonal face to unify\.

<a name='DiGi.Geometry.Planar.Query.Union(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D).polygonalFace2D_2'></a>

`polygonalFace2D_2` [IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')

The second polygonal face to unify\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') objects representing the resulting union, or `null` if either input is null\.

### Remarks
The computation is delegated to [UnionResult2D\(this IPolygonalFace2D, IPolygonalFace2D\)](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Create.UnionResult2D(thisDiGi.Geometry.Planar.Interfaces.IPolygonalFace2D,DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D) 'DiGi\.Geometry\.Planar\.Create\.UnionResult2D\(this DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D, DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D\)'); the polygonal faces of the result are returned\.

<a name='DiGi.Geometry.Planar.Query.Union(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D_)'></a>

## Query\.Union\(this IEnumerable\<IPolygonalFace2D\>\) Method

Computes the geometric union of a collection of 2D polygonal faces\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.PolygonalFace2D>? Union(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D>? polygonalFace2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Union(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D_).polygonalFace2Ds'></a>

`polygonalFace2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IPolygonalFace2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonalFace2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of polygonal faces to be unioned\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PolygonalFace2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.PolygonalFace2D 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the resulting unioned polygonal faces, or `null` if the input is null or no result could be produced\.

<a name='DiGi.Geometry.Planar.Query.Union(thisSystem.Collections.Generic.IEnumerable_Polygon_)'></a>

## Query\.Union\(this IEnumerable\<Polygon\>\) Method

Calculates the geometric union of a collection of polygons\.

```csharp
public static System.Collections.Generic.List<Polygon>? Union(this System.Collections.Generic.IEnumerable<Polygon>? polygons);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Union(thisSystem.Collections.Generic.IEnumerable_Polygon_).polygons'></a>

`polygons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') objects to unify\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [NetTopologySuite\.Geometries\.Polygon](https://learn.microsoft.com/en-us/dotnet/api/nettopologysuite.geometries.polygon 'NetTopologySuite\.Geometries\.Polygon') objects representing the resulting union, or `null` if the input is null or an error occurs during processing\.

<a name='DiGi.Geometry.Planar.Query.Union_TPolygonal2D_(thisSystem.Collections.Generic.IEnumerable_TPolygonal2D_)'></a>

## Query\.Union\<TPolygonal2D\>\(this IEnumerable\<TPolygonal2D\>\) Method

Calculates the union of a collection of polygonal geometries\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Polygon2D>? Union<TPolygonal2D>(this System.Collections.Generic.IEnumerable<TPolygonal2D>? polygonal2Ds)
    where TPolygonal2D : DiGi.Geometry.Planar.Interfaces.IPolygonal2D;
```
#### Type parameters

<a name='DiGi.Geometry.Planar.Query.Union_TPolygonal2D_(thisSystem.Collections.Generic.IEnumerable_TPolygonal2D_).TPolygonal2D'></a>

`TPolygonal2D`

The type of polygonal geometry, which must implement [IPolygonal2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.IPolygonal2D 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')\.
#### Parameters

<a name='DiGi.Geometry.Planar.Query.Union_TPolygonal2D_(thisSystem.Collections.Generic.IEnumerable_TPolygonal2D_).polygonal2Ds'></a>

`polygonal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TPolygonal2D](DiGi.Geometry.Planar.md#DiGi.Geometry.Planar.Query.Union_TPolygonal2D_(thisSystem.Collections.Generic.IEnumerable_TPolygonal2D_).TPolygonal2D 'DiGi\.Geometry\.Planar\.Query\.Union\<TPolygonal2D\>\(this System\.Collections\.Generic\.IEnumerable\<TPolygonal2D\>\)\.TPolygonal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of polygonal geometries to be united\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Polygon2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Polygon2D 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') objects representing the unioned result, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is null\.

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.VerticalPosition\(this Segment2D, Point2D, double\) Method

Determines the vertical position of a point relative to a 2D segment\.

```csharp
public static DiGi.Geometry.Core.Enums.VerticalPosition VerticalPosition(this DiGi.Geometry.Planar.Classes.Segment2D? segment2D, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,double).segment2D'></a>

`segment2D` [Segment2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Segment2D 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The 2D segment used as the reference for the vertical position check\.

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The 2D point whose vertical position is being evaluated\.

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine if the point is on the segment or within its bounds\.

#### Returns
[VerticalPosition](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.VerticalPosition 'DiGi\.Geometry\.Core\.Enums\.VerticalPosition')  
A [VerticalPosition](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.VerticalPosition 'DiGi\.Geometry\.Core\.Enums\.VerticalPosition') value indicating whether the point is above, below, on, or in an undefined position relative to the segment\.

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## Query\.VerticalPosition\(this ISegmentable2D, Point2D, double\) Method

Determines the vertical position of a point relative to a segmentable 2D geometry\.

```csharp
public static DiGi.Geometry.Core.Enums.VerticalPosition VerticalPosition(this DiGi.Geometry.Planar.Interfaces.ISegmentable2D? segmentable2D, DiGi.Geometry.Planar.Classes.Point2D? point2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double).segmentable2D'></a>

`segmentable2D` [ISegmentable2D](DiGi.Geometry.Planar.Interfaces.md#DiGi.Geometry.Planar.Interfaces.ISegmentable2D 'DiGi\.Geometry\.Planar\.Interfaces\.ISegmentable2D')

The segmentable 2D geometry to evaluate against\.

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double).point2D'></a>

`point2D` [Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The point whose vertical position is being determined\.

<a name='DiGi.Geometry.Planar.Query.VerticalPosition(thisDiGi.Geometry.Planar.Interfaces.ISegmentable2D,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the calculation\.

#### Returns
[VerticalPosition](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.VerticalPosition 'DiGi\.Geometry\.Core\.Enums\.VerticalPosition')  
A [VerticalPosition](DiGi.Geometry.Core.Enums.md#DiGi.Geometry.Core.Enums.VerticalPosition 'DiGi\.Geometry\.Core\.Enums\.VerticalPosition') value indicating whether the point is above, below, or undefined relative to the geometry\.
### Structs

<a name='DiGi.Geometry.Planar.Query.PointAlongSegmentComparer'></a>

## Query\.PointAlongSegmentComparer Struct

Comparer for sorting points along a segment based on their projection parameter\.

```csharp
private struct Query.PointAlongSegmentComparer : System.Collections.Generic.IComparer<DiGi.Geometry.Planar.Classes.Point2D>
```

Implements [System\.Collections\.Generic\.IComparer&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1 'System\.Collections\.Generic\.IComparer\`1')[Point2D](DiGi.Geometry.Planar.Classes.md#DiGi.Geometry.Planar.Classes.Point2D 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1 'System\.Collections\.Generic\.IComparer\`1')