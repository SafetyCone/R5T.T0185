using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IToken"/>
    [StrongTypeImplementationMarker]
    public class Token : TypedBase<string>, IStrongTypeMarker,
        IToken
    {
        public Token(string value)
            : base(value)
        {
        }
    }
}