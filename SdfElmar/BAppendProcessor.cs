using System;
namespace SdfElmar
{
	public class BAppendProcessor : BaseStringProcessor
    {
        public BAppendProcessor(IStringProcessor successor) : base(successor)
        {
        }

        public override string ProcessString(string input)
        {
            try
            {
                return base.ProcessString(input + "B");
            }
            catch (IOException e)
            {
                return input.Replace("B", "");
            }
        }

    }
}

