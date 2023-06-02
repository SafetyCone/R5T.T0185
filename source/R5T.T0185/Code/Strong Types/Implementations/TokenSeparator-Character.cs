using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185.N001
{
    /// <inheritdoc cref="ITokenSeparator"/>
    [StrongTypeImplementationMarker]
    public class TokenSeparator : TypedBase<char>, IStrongTypeMarker,
        ITokenSeparator
    {
        public TokenSeparator(char value)
            : base(value)
        {
        }
    }
}