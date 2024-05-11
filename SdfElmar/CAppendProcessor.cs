using System;
namespace SdfElmar
{
	public class CAppendProcessor: IStringProcessor
    {
        private IStringProcessor _nextProcessor;

        public string Process(string input)
        {
            return input + "C";
        }

        public void SetNextProcessor(IStringProcessor nextProcessor)
        {
            _nextProcessor = nextProcessor;
        }
    }
}

