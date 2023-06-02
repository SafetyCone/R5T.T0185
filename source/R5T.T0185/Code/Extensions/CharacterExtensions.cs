using System;

using R5T.T0185.N001;


namespace R5T.T0185.Extensions
{
    public static class CharacterExtensions
    {
        /// <inheritdoc cref="ICharacterOperator.ToTokenSeparator(char)"/>
        public static N001.ITokenSeparator ToTokenSeparator(this char value)
        {
            return Instances.CharacterOperator_Extensions.ToTokenSeparator(value);
        }
    }
}
