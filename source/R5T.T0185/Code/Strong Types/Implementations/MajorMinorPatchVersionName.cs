using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IMajorMinorPatchVersionName"/>
    [StrongTypeImplementationMarker]
    public class MajorMinorPatchVersionName : TypedBase<string>, IStrongTypeMarker,
        IMajorMinorPatchVersionName
    {
        public MajorMinorPatchVersionName(string value)
            : base(value)
        {
        }
    }
}