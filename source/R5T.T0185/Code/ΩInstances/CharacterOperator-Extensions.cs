using System;


namespace R5T.T0185.Extensions
{
    public class CharacterOperator : ICharacterOperator
    {
        #region Infrastructure

        public static ICharacterOperator Instance { get; } = new CharacterOperator();


        private CharacterOperator()
        {
        }

        #endregion
    }
}
