using System;
namespace SdfElmar
{
	public class BAppendProcessor : IStringProcessor
    {
        private IStringProcessor _nextProcessor;

        public string Process(string input)
        {
            return input + "B";
        }

        public void SetNextProcessor(IStringProcessor nextProcessor)
        {
            _nextProcessor = nextProcessor;
        }
    }
}

