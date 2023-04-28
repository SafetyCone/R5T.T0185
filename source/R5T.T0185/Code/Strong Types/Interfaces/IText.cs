using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as text.
    /// <para>
    /// This type is for any string that is meant to be read by humans (and is thus text).
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IText : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
