using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a token (component) of some larger string.
    /// </summary>
    [StrongTypeMarker]
    public interface IToken : IStrongTypeMarker,
        ITyped<string>
    {
    }
}