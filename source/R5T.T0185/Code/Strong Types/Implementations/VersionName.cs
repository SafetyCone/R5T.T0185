using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IVersionName"/>
    [StrongTypeImplementationMarker]
    public class VersionName : TypedBase<string>, IStrongTypeMarker,
        IVersionName
    {
        public VersionName(string value)
            : base(value)
        {
        }
    }
}