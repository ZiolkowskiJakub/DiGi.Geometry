# DiGi.Geometry#4 — Investigation Results & Implementation Plan

> Status: **Still valid.** Both code excerpts in the issue were verified against the current tree (branch `0.8.9`) on 2026-09-09. Scope is exactly the two locally-defined offenders; the `Cluster` / `IndexedObjects` base fixes from [DiGi.Core#4](https://github.com/ZiolkowskiJakub/DiGi.Core/issues/4) propagate automatically and are not touched here.

---

## 1. Verdict

| Action item | Verdict |
|---|---|
| G1 · Audit & benchmark | **Done in this investigation** (§2.4 matrix) + benchmark facts to be added (Phase 2). |
| G2 · Optimize `TransformGroup2D.GetEnumerator()` | **Fully valid.** Remove clone + null-filter from the enumeration; stream the stored list. |
| G3 · Optimize `TransformGroup3D.GetEnumerator()` | **Fully valid.** Identical change. |
| G4 · Automatic tests | **Valid.** Reproduce-before-fix fact + no-clone proof + benchmark, per *Coding - Automatic Tests*. |

---

## 2. Verification against the code (issue premises checked)

### 2.1 The defect is confirmed and isolated to two methods

- `DiGi.Geometry/Planar/Classes/TransformGroup2D.cs:54-63` — `GetEnumerator()` runs `DiGi.Core.Query.Clone(transform2Ds)?.FilterNulls()` on every call. **N deep clones + one `List` allocation + one null-filter pass per enumeration. Confirmed.**
- `DiGi.Geometry/Spatial/Classes/TransformGroup3D.cs:54-63` — identical over `transform3Ds`. **Confirmed.**
- `ITransform2D` and `ITransform3D` are **marker interfaces** (no members; `ITransform2D : ITransform`, `ITransform : ISerializableObject`). The group's only data surface is `IEnumerable<ITransform*>`, so **every consumer must go through `GetEnumerator()`** — there is no alternative accessor.

### 2.2 New finding (hot path) — the group is replayed per geometry element

- `Coordinate2D.Transform` (`Planar/Classes/Coordinate2D.cs:139`), `Coordinate3D.Transform` (`Spatial/Classes/Coordinate3D.cs:179`) and `Vector3D.Transform` (`Spatial/Classes/Vector3D.cs:519`) each do:

  ```csharp
  if (transform is TransformGroup2D transformGroup2D)
  {
      foreach (ITransform2D transform_Temp in transformGroup2D)
      {
          if (transform_Temp == null)
          {
              continue;
          }

          Transform(transform_Temp);
      }

      return true;
  }
  ```

  For a cloud/mesh transform this is **N members deep-cloned once per element** — the "transform/apply workload" the issue describes.
- `DiGi.Test/DiGi.Geometry.PointCloud.xUnit/Facts/PointCloud3D.cs:169` comment confirms the design: *"the per-point path replays the whole group for every point."*
- **Safe to drop the filter:** the consumer **already null-guards** each element (`if (transform_Temp == null) continue;`), so removing `FilterNulls()` from `GetEnumerator()` cannot change observable behavior.

### 2.3 Null filtering already happens at insertion — the enumeration filter is redundant

- The `IEnumerable` constructor and the copy constructor both store `DiGi.Core.Query.Clone(...)?.FilterNulls()`, so the stored list is null-free on those two paths.
- The `JsonObject` constructor path (`base(jsonObject)`) does not explicitly filter; a deserialized group could in theory carry a null element, but the §2.2 consumer already skips nulls, so behavior is unchanged. (Hardening that path is out of scope — see §4.)
- `Transform2D` / `Transform3D` implement **no `IEquatable` / `Equals` / `==`**; value parity in the test is asserted through the matrix indexer (`this[row, col]`).

### 2.4 G1 audit — `GetEnumerator` matrix in DiGi.Geometry

- `TransformGroup2D` / `TransformGroup3D` — **clone per enumeration (the defect, in scope).**
- Every other `IEnumerable` in the repo either derives from `Cluster` / `IndexedObjects` (fixed upstream in DiGi.Core#4 and inherited here) or already streams. A repo-wide grep for `Query.Clone` shows all other call sites are either **constructors (insertion time)** or **clone-per-call accessors** (the intentional `Core.Query.Clone(field)` snapshot pattern documented in the repo `README.md`) — **none are `GetEnumerator` materialization.**
- **Conclusion: scope is exactly these two methods.** The base-class fixes propagate; no other local offender exists.

---

## 3. Implementation plan

### Phase 0 — Reproduce before fixing (guideline: *Coding - Automatic Tests*, "Reproduce Before Fixing")

Add facts to `DiGi.Geometry.xUnit` (shared `Facts` partial class, flat `Facts/` folder) **before touching production code**.

New file `DiGi.Test/DiGi.Geometry.xUnit/Facts/TransformGroup2D.cs`:

```csharp
namespace DiGi.Geometry.xUnit
{
    public partial class Facts
    {
        /// <summary>
        /// Verifies that TransformGroup2D enumerates the stored transforms without deep-cloning on every pass.
        /// </summary>
        [Fact]
        public void TransformGroup2D_GetEnumeratorStreamsLiveTransforms()
        {
            Planar.Classes.Transform2D transform2D_A = Planar.Create.Transform2D.Translation(1.0, 2.0)!;
            Planar.Classes.Transform2D transform2D_B = Planar.Create.Transform2D.Rotation(0.6)!;
            Planar.Classes.TransformGroup2D group = new([transform2D_A, transform2D_B]);

            List<Planar.Interfaces.ITransform2D> firstPass = [];
            foreach (Planar.Interfaces.ITransform2D transform in group)
            {
                firstPass.Add(transform);
            }

            List<Planar.Interfaces.ITransform2D> secondPass = [];
            foreach (Planar.Interfaces.ITransform2D transform in group)
            {
                secondPass.Add(transform);
            }

            Assert.Equal(2, firstPass.Count);
            Assert.Equal(2, secondPass.Count);

            // No deep clone per pass: both passes must surface the same stored instances.
            Assert.True(ReferenceEquals(firstPass[0], secondPass[0]), "GetEnumerator must not deep-clone on every enumeration pass.");
            Assert.True(ReferenceEquals(firstPass[1], secondPass[1]), "GetEnumerator must not deep-clone on every enumeration pass.");

            // Value parity: enumerated transforms still agree with the intended matrices.
            Assert.Equal(transform2D_A[0, 2], ((Planar.Classes.Transform2D)firstPass[0])[0, 2], 9);
            Assert.Equal(transform2D_B[1, 0], ((Planar.Classes.Transform2D)firstPass[1])[1, 0], 9);
        }
    }
}
```

The same fact, in its 3D variant, goes in `Facts/TransformGroup3D.cs` (using `Spatial.Classes.Transform3D`, `Spatial.Create.Transform3D.Translation(1.0, 2.0, 3.0)` and a 4×4 index).

Run it and confirm it **fails on the unmodified code** (two passes surface two distinct cloned instances → `ReferenceEquals` is false). That failure is the committed reproduction evidence.

### Phase 1 — Fix the two `GetEnumerator()` methods

`DiGi.Geometry/Planar/Classes/TransformGroup2D.cs` (and the `Spatial/Classes/TransformGroup3D.cs` twin):

```csharp
public IEnumerator<ITransform2D> GetEnumerator()
{
    if (transform2Ds == null)
    {
        return Enumerable.Empty<ITransform2D>().GetEnumerator();
    }

    return transform2Ds.GetEnumerator();
}
```

- Mirrors the DiGi.Core#4 `Table` remedy exactly (`return rows.Values.GetEnumerator()`): enumeration is a read-only pass and must not allocate.
- Null filtering already happens at insertion (constructors) and the consumer null-guards, so the element sequence is unchanged.
- The `IEnumerable` constructor and copy constructor are **unchanged** — they keep the defensive clone (the intended snapshot-at-construction semantics).
- **Do not** add a `Create` factory: the issue lists it only as an alternative, null handling already lives at insertion, and no caller needs a nullable-return guard.

Documentation (same change):

- `GetEnumerator()` `<summary>`: state that it enumerates the **stored** transforms in order **without cloning**, and that the defensive clone happens at construction.
- Regenerate `documentation/API/` — the `<summary>` text is emitted into `DiGi.Geometry.Planar.Classes.md` / `DiGi.Geometry.Spatial.Classes.md` (guideline: *Coding - API Documentation*).

### Phase 2 — Tests (`DiGi.Test/DiGi.Geometry.xUnit`)

Per *Coding - Automatic Tests*:

1. `Facts/TransformGroup2D.cs` / `Facts/TransformGroup3D.cs` — `..._GetEnumeratorStreamsLiveTransforms` (Phase 0; red first, green after Phase 1).
2. `Facts/TransformGroup2D.cs` / `Facts/TransformGroup3D.cs` — `..._NullGroup_EnumeratesEmpty`: `new TransformGroup2D(null)` and `new TransformGroup2D((TransformGroup2D?)null)` both enumerate as empty (pins the null branch).
3. `Facts/TransformGroup2D.cs` / `Facts/TransformGroup3D.cs` — `..._Enumeration_Performance`: build a group of ~1000 transforms; one warm-up pass (JIT); 3 `System.Diagnostics.Stopwatch` runs, report the **range** to `Core.xUnit.Query.ReportsDirectory(Assembly.GetExecutingAssembly())`; assert a coarse threshold (e.g. `max < 2000` ms) that the fixed code clears with a wide margin **in-suite**. Measure in isolation: `dotnet test DiGi.Geometry.xUnit -c Release --filter "FullyQualifiedName~TransformGroup2D_Enumeration_Performance"`. **A/B against a real baseline:** keep a copy of the pre-change file, swap it back in, re-run isolated under identical conditions; never compare against a stale report (guideline: *Coding - Automatic Tests* §4).
4. Guard-effectiveness check (guideline: "A Guard Must Be Shown To Fail"): the Phase 0 fact **is** the guard — confirm it goes red on the pre-change file and green on the fixed file.
5. Regression: full `DiGi.Geometry.xUnit` suite green; **`DiGi.Geometry.PointCloud.xUnit` green** (the `PointCloud2D` / `PointCloud3D` group facts are the real-consumer regression net); serialization round-trip facts stay green (no signature change).

### Phase 3 — Build & cross-repo verification

- `dotnet build DiGi.Geometry.slnx` — **zero warnings** (guideline: *Coding - General* §1.4).
- `DiGi.Geometry.xUnit` reaches `DiGi.Geometry` by **`ProjectReference`** (verified in `DiGi.Geometry.xUnit.csproj`), so `dotnet test` rebuilds it; still build `DiGi.Geometry` explicitly first per *Coding - Automatic Tests* §4.
- Build the sibling consumers (`DiGi.Geometry.Object`, `DiGi.Geometry.Drawing`, `DiGi.Geometry.Random`, `DiGi.Geometry.Visual`) — no public signature changes, so expect no compile impact.
- SemVer: implementation + XML docs only, no public API signature change → **patch bump** of `DiGi.Geometry`.

---

## 4. Explicit rejections / out of scope

1. **Adding a `Create.TransformGroup2D` / `Create.TransformGroup3D` factory** — rejected; null handling already lives at insertion (constructors), no caller needs a nullable-return guard, and it would add a new public API surface for no benefit.
2. **Hardening the `JsonObject` deserialization path to null-filter** — noted but deferred; the consumer already skips nulls (§2.2), so observable behavior is unchanged. If the stored-list "no nulls" invariant must be absolute, do it in a follow-up with its own issue.
3. **Auditing other `IEnumerable` types** — done (§2.4); the base-class fixes from DiGi.Core#4 propagate, and no other local offender exists.
4. **Changing the constructor clone semantics** — rejected; the defensive clone-at-construction is intended (it is what makes the stored list null-free and independent of the caller's input).

---

## 5. Behavioral change statement

`foreach (T t in group)` on a `TransformGroup2D` / `TransformGroup3D` now yields the **stored transform instances** instead of a fresh deep clone per pass. Mutating an enumerated `Transform2D` / `Transform3D` (e.g. calling `Inverse()` / `Transpose()`) now mutates the group's stored member. No known consumer in the DiGi ecosystem mutates members obtained via enumeration — `Coordinate2D/3D.Transform` and `Vector3D.Transform` only read the matrix — so this is safe, and it removes N deep clones from the per-element transform/apply path. Call this out in the release notes / wiki.
