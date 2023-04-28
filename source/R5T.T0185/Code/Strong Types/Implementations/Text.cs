using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IText"/>
    [StrongTypeImplementationMarker]
    public class Text : TypedBase<string>, IStrongTypeMarker,
        IText
    {
        public Text(string value)
            : base(value)
        {
        }
    }
}
