using System;

using R5T.T0132;


namespace R5T.T0185.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDescription"/>
        public IDescription ToDescription(string value)
        {
            var output = new Description(value);
            return output;
        }

        /// <inheritdoc cref="IMessage"/>
        public IMessage ToMessage(string value)
        {
            var output = new Message(value);
            return output;
        }

        /// <inheritdoc cref="IName"/>
        public IName ToName(string value)
        {
            var output = new Name(value);
            return output;
        }

        /// <inheritdoc cref="IText"/>
        public IText ToText(string value)
        {
            var output = new Text(value);
            return output;
        }

        /// <inheritdoc cref="IToken"/>
        public IToken ToToken(string value)
        {
            var output = new Token(value);
            return output;
        }

        /// <inheritdoc cref="ITokenSeparator"/>
        public ITokenSeparator ToTokenSeparator(string value)
        {
            var output = new TokenSeparator(value);
            return output;
        }

        /// <inheritdoc cref="IWord"/>
        public IWord ToWord(string value)
        {
            var output = new Word(value);
            return output;
        }

        /// <inheritdoc cref="IMajorMinorPatchVersionName"/>
        public IMajorMinorPatchVersionName ToMajorMinorPatchVersionName(string value)
        {
            var output = new MajorMinorPatchVersionName(value);
            return output;
        }

        /// <inheritdoc cref="IVersionName"/>
        public IVersionName ToVersionName(string value)
        {
            var output = new VersionName(value);
            return output;
        }
    }
}
