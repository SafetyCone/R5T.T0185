using System;


namespace R5T.T0185.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDescription(string)"/>
        public static IDescription ToDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToDescription(value);
        }

        /// <inheritdoc cref="IStringOperator.ToMessage(string)"/>
        public static IMessage ToMessage(this string value)
        {
            return Instances.StringOperator_Extensions.ToMessage(value);
        }

        /// <inheritdoc cref="IStringOperator.ToName(string)"/>
        public static IName ToName(this string value)
        {
            return Instances.StringOperator_Extensions.ToName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToText(string)"/>
        public static IText ToText(this string value)
        {
            return Instances.StringOperator_Extensions.ToText(value);
        }

        /// <inheritdoc cref="IStringOperator.ToToken(string)"/>
        public static IToken ToToken(this string value)
        {
            return Instances.StringOperator_Extensions.ToToken(value);
        }

        /// <inheritdoc cref="IStringOperator.ToTokenSeparator(string)"/>
        public static ITokenSeparator ToTokenSeparator(this string value)
        {
            return Instances.StringOperator_Extensions.ToTokenSeparator(value);
        }

        /// <inheritdoc cref="IStringOperator.ToWord(string)"/>
        public static IWord ToWord(this string value)
        {
            return Instances.StringOperator_Extensions.ToWord(value);
        }
    }
}
