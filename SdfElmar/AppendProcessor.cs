using System;
namespace SdfElmar
{
	public class AppendProcessor: IStringProcessor
    {
        private IStringProcessor _nextProcessor;

        public string Process(string input)
        {
            return input + "A";
        }

        public void SetNextProcessor(IStringProcessor nextProcessor)
        {
            _nextProcessor = nextProcessor;
        }
    }
}

