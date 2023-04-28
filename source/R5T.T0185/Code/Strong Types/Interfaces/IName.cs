using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a name.
    /// <para>
    /// This type is for any name (of a person, or a library, of a repository), and is mainly meant to be sub-typed to a person-name or library-name, etc.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
