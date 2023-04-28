using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0185
{
    /// <inheritdoc cref="IDescription"/>
    [StrongTypeImplementationMarker]
    public class Description : TypedBase<string>, IStrongTypeMarker,
        IDescription
    {
        public Description(string value)
            : base(value)
        {
        }
    }
}
