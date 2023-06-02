using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="ITokenSeparator"/>
    [StrongTypeImplementationMarker]
    public class TokenSeparator : TypedBase<string>, IStrongTypeMarker,
        ITokenSeparator
    {
        public TokenSeparator(string value)
            : base(value)
        {
        }
    }
}