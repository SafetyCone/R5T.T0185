using System;

using R5T.T0178;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a version string.
    /// Chooses <see cref="IMajorMinorPatchVersionName"/> as the default version name format.
    /// </summary>
    [StrongTypeMarker]
    public interface IVersionName : IStrongTypeMarker,
        IMajorMinorPatchVersionName
    {
    }
}