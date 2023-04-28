using System;

using R5T.T0132;


namespace R5T.T0185.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IDescription ToDescription(string value)
        {
            var output = new Description(value);
            return output;
        }

        public IMessage ToMessage(string value)
        {
            var output = new Message(value);
            return output;
        }

        public IName ToName(string value)
        {
            var output = new Name(value);
            return output;
        }

        public IText ToText(string value)
        {
            var output = new Text(value);
            return output;
        }
    }
}
