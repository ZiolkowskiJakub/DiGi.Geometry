using DiGi.Core.Constants;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Provides functionality to update the normalization of a <see cref="Polyhedron"/>.
    /// </summary>
    public class PolyhedronNormalizationUpdater : PolyhedronNormalizationUpdater<Polyhedron>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronNormalizationUpdater"/> class with the specified <see cref="Orientation"/>.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> to be used for normalization.</param>
        public PolyhedronNormalizationUpdater(Orientation orientation)
            : base(orientation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronNormalizationUpdater"/> class with the specified normal side, external edge orientation, internal edge orientation, and tolerance.
        /// </summary>
        /// <param name="normalSide">The <see cref="Side"/> to be normalized.</param>
        /// <param name="externalEdgeOrientation">The <see cref="Orientation"/> for external edges.</param>
        /// <param name="internalEdgeOrientation">The <see cref="Orientation"/> for internal edges.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        public PolyhedronNormalizationUpdater(Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
            : base(normalSide, externalEdgeOrientation, internalEdgeOrientation, tolerance)
        {
        }
    }

    /// <summary>
    /// Provides functionality to update the normalization of a polyhedron, ensuring consistent normals and edge orientations.
    /// </summary>
    /// <typeparam name="TPolyhedron">The type of the polyhedron, which must implement <see cref="IPolyhedron"/>.</typeparam>
    public class PolyhedronNormalizationUpdater<TPolyhedron> : GeometryUpdater<TPolyhedron>, Core.Interfaces.INormalizationUpdater<TPolyhedron> where TPolyhedron : IPolyhedron
    {
        private readonly double tolerance = Tolerance.Distance;

        private readonly Side? normalSide;
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronNormalizationUpdater"/> class using the specified orientation for both external and internal edges.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> to be applied to both external and internal edge orientations.</param>
        public PolyhedronNormalizationUpdater(Orientation orientation)
        {
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronNormalizationUpdater"/> class.
        /// </summary>
        /// <param name="normalSide">The optional <see cref="Side"/> specifying the normal side.</param>
        /// <param name="externalEdgeOrientation">The optional <see cref="Orientation"/> for external edges.</param>
        /// <param name="internalEdgeOrientation">The optional <see cref="Orientation"/> for internal edges.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        public PolyhedronNormalizationUpdater(Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
        {
            this.tolerance = tolerance;

            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
            this.normalSide = normalSide;
        }

        /// <summary>
        /// Determines whether the current value is normalized based on the specified edge orientations and tolerance.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the instance is normalized.</returns>
        public bool Normalized()
        {
            if (Value is null)
            {
                return false;
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                for (int i = 0; i < Value.Count; i++)
                {
                    if (!Value.Normalized(i, externalEdgeOrientation, internalEdgeOrientation, tolerance))
                    {
                        return false;
                    }
                }
            }

            if (normalSide is not null)
            {
                for (int i = 0; i < Value.Count; i++)
                {
                    Value.GetNormal(i, out bool inversed, normalSide, tolerance);
                    if (inversed)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Updates the normal values based on the provided normal side and tolerance.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether any of the values were successfully updated.</returns>
        public override bool Update()
        {
            if (Value is null)
            {
                return false;
            }

            bool result = false;

            if (normalSide is not null)
            {
                for (int i = 0; i < Value.Count; i++)
                {
                    if (Value.SetNormal(i, normalSide.Value, tolerance))
                    {
                        result = true;
                    }
                }
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                if (Value.Orient(externalEdgeOrientation, internalEdgeOrientation))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}