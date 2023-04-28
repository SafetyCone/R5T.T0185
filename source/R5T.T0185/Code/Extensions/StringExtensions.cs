using System;


namespace R5T.T0185.Extensions
{
    public static class StringExtensions
    {
        public static IDescription ToDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToDescription(value);
        }

        public static IMessage ToMessage(this string value)
        {
            return Instances.StringOperator_Extensions.ToMessage(value);
        }

        public static IName ToName(this string value)
        {
            return Instances.StringOperator_Extensions.ToName(value);
        }

        public static IText ToText(this string value)
        {
            return Instances.StringOperator_Extensions.ToText(value);
        }
    }
}
