using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a integer as a major version number (the 'X' in version "X.Y.Z"). Example: the 6 in 6.0.18.
    /// </summary>
    [StrongTypeMarker]
    public interface IMajorVersionNumber : IStrongTypeMarker,
        ITyped<int>
    {
    }
}