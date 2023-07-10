using System;

using R5T.T0132;


namespace R5T.T0185.Extensions
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IMajorVersionNumber"/>
        public IMajorVersionNumber ToMajorVersionNumber(int value)
        {
            var output = new MajorVersionNumber(value);
            return output;
        }
    }
}
