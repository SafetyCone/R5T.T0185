using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IName"/>
    [StrongTypeImplementationMarker]
    public class Name : TypedBase<string>, IStrongTypeMarker,
        IName
    {
        public Name(string value)
            : base(value)
        {
        }
    }
}
