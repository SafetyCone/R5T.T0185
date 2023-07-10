using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185.N001
{
    /// <summary>
    /// Strongly-types a string as a version name.
    /// This is the base type for all version names, and thus no assumptions about the version format is made.
    /// </summary>
    [StrongTypeMarker]
    public interface IVersionName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}