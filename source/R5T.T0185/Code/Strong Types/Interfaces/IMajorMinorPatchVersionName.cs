using System;

using R5T.T0178;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a major-minor-patch version name.
    /// Example: 6.0.18
    /// </summary>
    [StrongTypeMarker]
    public interface IMajorMinorPatchVersionName : IStrongTypeMarker,
        N001.IVersionName
    {
    }
}