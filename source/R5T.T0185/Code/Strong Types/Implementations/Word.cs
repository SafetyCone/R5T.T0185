using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IWord"/>
    [StrongTypeImplementationMarker]
    public class Word : TypedBase<string>, IStrongTypeMarker,
        IWord
    {
        public Word(string value)
            : base(value)
        {
        }
    }
}