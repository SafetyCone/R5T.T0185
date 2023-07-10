using System;


namespace R5T.T0185.Extensions
{
    public static class IntegerExtensions
    {
        /// <inheritdoc cref="IIntegerOperator.ToMajorVersionNumber(int)"/>
        public static IMajorVersionNumber ToMajorVersionNumber(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToMajorVersionNumber(value);
        }
    }
}
