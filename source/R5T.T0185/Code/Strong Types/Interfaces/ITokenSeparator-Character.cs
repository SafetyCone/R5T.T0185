using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185.N001
{
    /// <summary>
    /// Strongly-types a character as a token separator.
    /// </summary>
    [StrongTypeMarker]
    public interface ITokenSeparator : IStrongTypeMarker,
        ITyped<char>
    {
    }
}