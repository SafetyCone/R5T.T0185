using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a description.
    /// <para>
    /// This type is for any description (of a person, or a library, of a repository), and is mainly meant to be sub-typed to a person-description or library-description, etc.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDescription : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
