# DiGi.Geometry

`DiGi.Geometry` is a high-performance, warning-free C# geometry and spatial computation library suite designed for engineering and architectural plugin development (e.g., Revit API, RhinoCommon, Grasshopper, and Dynamo BIM).

The library provides comprehensive representations and algorithms for 2D (Planar) and 3D (Spatial) geometry, drawing serialization/rendering wrappers, and domain-object mappings.

---

## 🏗️ Project Architecture & Assemblies

The repository is structured into three main assemblies:

### 1. [DiGi.Geometry](DiGi.Geometry/DiGi.Geometry)
The core library containing geometry representations, mathematical algorithms, and solvers.
- **Planar (2D)**: Data models located in [Planar/Classes](DiGi.Geometry/DiGi.Geometry/Planar/Classes), including:
  - Coordinate/Point/Vector: `Coordinate2D`, `Point2D`, `Vector2D`
  - Linear/Parametric: `Segment2D`, `Line2D`, `Ray2D`, `Polyline2D`
  - Enclosed/Curved Shapes: `Circle2D`, `Ellipse2D`, `Triangle2D`, `Rectangle2D`, `Polygon2D`, `PolygonalFace2D`
  - Boundary/Spatial Structures: `BoundingBox2D`, `Mesh2D`, `Grid2D`
  - Transforms: `Transform2D`, `TransformGroup2D`, `CoordinateSystem2D`
  - Intersections & Tracing: `IntersectionResult2D`, `SegmentableTraceResult2D`
- **Spatial (3D)**: Data models located in [Spatial/Classes](DiGi.Geometry/DiGi.Geometry/Spatial/Classes), including:
  - Coordinate/Point/Vector: `Coordinate3D`, `Point3D`, `Vector3D`
  - Linear/Parametric: `Segment3D`, `Line3D`, `Ray3D`, `Polyline3D`
  - Curves/Planar Shapes: `Ellipse3D`, `Plane`, `Triangle3D`, `Rectangle3D`, `Polygon3D`, `Polyloop`, `PolygonalFace3D`
  - Curved Volumes: `Sphere`, `Spheroid`, `Ellipsoid`
  - Extrusion & Polyhedra: `Extrusion`, `PolygonalFaceExtrusion`, `Polyhedron`
  - Boundary/Spatial Structures: `BoundingBox3D`, `Mesh3D`
  - Transforms: `Transform3D`, `TransformGroup3D`, `CoordinateSystem3D`
  - Intersections & Projections: `IntersectionResult3D`, `PlanarIntersectionResult`, `PlanarResult`, `ProjectionResult`

### 2. [DiGi.Geometry.Drawing](DiGi.Geometry/DiGi.Geometry.Drawing)
A GDI+ extension assembly containing utility methods to draw and render 2D geometric shapes (such as `Segment2D`, `IPolygonal2D`, `BoundingBox2D`, `Point2D`, `IPolygonalFace2D`, and `Mesh2D`) onto a standard `System.Drawing.Graphics` drawing surface using standard pens/brushes or `DiGi.Core.Drawing` pen models.

### 3. [DiGi.Geometry.Object](DiGi.Geometry/DiGi.Geometry.Object)
Defines abstract geometry-binding interfaces that map host or domain objects to geometric primitives.
- Key interfaces include:
  - `IGeometryObject` / `IGeometryObject<TGeometry>`
  - `IGeometry2DObject<T>` / `IPoint2DObject` / `IPolygon2DObject`
  - `IGeometry3DObject<T>` / `IPoint3DObject` / `IPolygonalFace3DObject`

---

## 📐 Core Architectural Pattern (DiGi.Core Pattern)

This project strictly separates **Data Models** from **Business/Calculation Logic**:

```mermaid
graph TD
    subgraph Data Models (Anemic)
        C[Classes]
        I[Interfaces]
        E[Enums]
    end
    subgraph Business Logic (Static Extensions)
        Q[Query Class]
        M[Modify Class]
        Cr[Create Class]
    end
    C -->|Query / Read| Q
    C -->|Modify / Mutate| M
    C -->|Create / Instantiate| Cr
```

### 1. Data Models (Classes, Interfaces, Enums)
- **Anemic Models**: Keep models lightweight, holding only properties and basic constructors. Avoid putting complex business or geometric logic directly inside model classes.
- **Organization**:
  - Models are stored in `/Classes` directories (e.g., [DiGi.Geometry/Planar/Classes](DiGi.Geometry/DiGi.Geometry/Planar/Classes)).
  - Interfaces are stored in `/Interfaces` (e.g., [DiGi.Geometry/Planar/Interfaces](DiGi.Geometry/DiGi.Geometry/Planar/Interfaces)).
  - Enums are stored in `/Enums` (e.g., [DiGi.Geometry/Planar/Enums](DiGi.Geometry/DiGi.Geometry/Planar/Enums)).

### 2. Business Logic (Extension Methods)
All operations, queries, and manipulations on data models must be implemented as C# **Extension Methods** inside one of three static partial classes:
* **Query** (Read/Extract - returns calculation results, does not mutate state):
  - Class: `public static partial class Query`
  - Directory: `/Query` (e.g., `Planar/Query/DistanceTo.cs`)
* **Modify** (Update/Mutate - modifies properties of the source object in-place):
  - Class: `public static partial class Modify`
  - Directory: `/Modify` (e.g., `Planar/Modify/Scale.cs`)
* **Create** (Instantiate - constructs and returns a new object based on inputs):
  - Class: `public static partial class Create`
  - Directory: `/Create` (e.g., `Planar/Create/Circle.cs`)

---

## 💻 Coding Guidelines for Developers & AI Agents

To maintain codebase health, performance, and compatibility within Visual Studio 2026 / C# 10+ environments:

1. **English Only**: All naming, variables, comments, and documentation must be strictly in English.
2. **Explicit Typing Mandatory**: Never use implicit typing (`var`) unless it is strictly required by the compiler (e.g., returning anonymous types). Declare types explicitly.
3. **Variable Naming Conventions**:
   - Variable/object names must start with the type name in camelCase (e.g., `PointNode pointNode_Base`, `Vector3D vector3D_Direction`). Use an underscore to append more descriptive parts.
   - **Collections**: For collections (`IEnumerable`, `List`, `Array`, etc.), do NOT prefix names with collection types (e.g., avoid `listConditions`). Instead, name them based on the element type using plural naming (e.g., `FilterConditions`, `Point2Ds`).
   - **Exceptions**: Simple types (`double`, `string`, `int`, `bool`) can exclude the type prefix (e.g., `double tolerance`, `int count`).
4. **Clean Build Constraint**: The solution must build with zero compiler warnings, zero analyzer messages, and strict nullability checks.

---

## 📝 XML Documentation Protocol

All public constructors, properties, methods, and enum values must be fully documented using XML comments to ensure accurate IntelliSense:

1. **Local Doc Generation**: When auditing or creating XML comments, use the `lm_studio` MCP tool (utilizing Gemma 4 if available).
2. **Single Summary Rule**: Ensure every member has exactly one `<summary>` block. Remove or overwrite duplicate blocks.
3. **No Empty Lines**: Never include empty `///` lines inside XML documentation blocks. Use `<para>...</para>` tags to separate paragraphs.
4. **Signature Matching**: Keep parameters (`<param>`), return types (`<returns>`), and type parameters (`<typeparam>`) perfectly aligned with the method signature to avoid compiler warnings (e.g., `CS1591`, `CS1573`).
5. **Ingest External Context**: Check for matching `.xml` files next to referenced libraries (e.g., `DiGi.Core.xml` next to `DiGi.Core.dll` in sibling paths) to ensure correct cross-referencing and descriptions of external types.

---

## 🔄 Branch Synchronization & Versioning Protocol

DevOps automation and branch versioning are controlled by strict versioning policies:

### Trigger Condition
- Protocol runs **ONLY** if the current active branch name matches the semantic versioning format of `*.*.*` exactly (e.g., `0.8.2`, `1.12.0`).
- If the branch contains suffixes/prefixes (e.g. `main`, `v0.8.2`, `0.8.2-beta`, `feature/xyz`), the protocol is skipped.

### Step-by-Step Workflow
1. **Sync with Main**: Merge the active version branch into `main` and resolve any diffs.
2. **Calculate Next Version**: Increment the patch version (3rd digit) by exactly 1 (e.g., `0.8.2` becomes `0.8.3`).
3. **Create Branch**: Create a new branch named after the incremented version from the updated `main`.
4. **Update Project Version**: Locate and update the `<Major>`, `<Minor>`, and `<Build>` XML tags in the root [Directory.Build.props](DiGi.Geometry/Directory.Build.props) file to match the new version. Commit this change to the new branch.
5. **Publish**: Push both the updated `main` branch and the new version branch to GitHub (origin).
