using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <summary>
    /// Strongly-types a string as a message.
    /// <para>
    /// This type is for any string that is meant to be sent from one place to another.
    /// A decision was made to *not* inherit from <see cref="IText"/> since not all messages might be text.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IMessage : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
