using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IMessage"/>
    [StrongTypeImplementationMarker]
    public class Message : TypedBase<string>, IStrongTypeMarker,
        IMessage
    {
        public Message(string value)
            : base(value)
        {
        }
    }
}
