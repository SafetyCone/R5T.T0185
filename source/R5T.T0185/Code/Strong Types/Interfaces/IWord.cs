using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a word (any word).
    /// </summary>
    [StrongTypeMarker]
    public interface IWord : IStrongTypeMarker,
        ITyped<string>
    {
    }
}