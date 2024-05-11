using System;
namespace SdfElmar
{
	public class StringProcessorChain : IStringProcessor
    {
        private IStringProcessor _processorChain;

        public StringProcessorChain()
        {
            BuildChain();
        }
        private void BuildChain()
        {
            var appendProcessor = new AppendProcessor();
            var bAppendProcessor = new BAppendProcessor();
            var cAppendProcessor = new CAppendProcessor();

            appendProcessor.SetNextProcessor(bAppendProcessor);
            bAppendProcessor.SetNextProcessor(cAppendProcessor);

            _processorChain = appendProcessor;
        }
        public string Process(string input)
        {
            return _processorChain.Process(input);
        }
        public void SetNextProcessor(IStringProcessor nextProcessor)
        {
            throw new NotImplementedException();
        }
    }
}

