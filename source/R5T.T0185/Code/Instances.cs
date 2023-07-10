using System;


namespace R5T.T0185
{
    public static class Instances
    {
        public static Extensions.ICharacterOperator CharacterOperator_Extensions => Extensions.CharacterOperator.Instance;
        public static Extensions.IIntegerOperator IntegerOperator_Extensions => Extensions.IntegerOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
    }
}