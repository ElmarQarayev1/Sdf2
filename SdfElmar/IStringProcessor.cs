using System;
namespace SdfElmar
{
	public interface IStringProcessor
	{
        string Process(string input);
        void SetNextProcessor(IStringProcessor nextProcessor);
    }
}

