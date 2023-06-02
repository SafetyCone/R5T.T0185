using System;

using R5T.T0132;


namespace R5T.T0185.Extensions
{
    [FunctionalityMarker]
    public partial interface ICharacterOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ITokenSeparator"/>
        public N001.ITokenSeparator ToTokenSeparator(char value)
        {
            var output = new N001.TokenSeparator(value);
            return output;
        }
    }
}
