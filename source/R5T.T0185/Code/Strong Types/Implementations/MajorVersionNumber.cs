using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IMajorVersionNumber"/>
    [StrongTypeImplementationMarker]
    public class MajorVersionNumber : TypedBase<int>, IStrongTypeMarker,
        IMajorVersionNumber
    {
        public MajorVersionNumber(int value)
            : base(value)
        {
        }
    }
}