using System;
namespace SdfElmar
{
	public class BaseStringProcessor : IStringProcessor
    {
        private readonly IStringProcessor _successor;

        public BaseStringProcessor(IStringProcessor successor)
        {
            _successor = successor;
        }

        public virtual string ProcessString(string input)
        {
            return _successor?.ProcessString(input) ?? input;
        }
    }
}

