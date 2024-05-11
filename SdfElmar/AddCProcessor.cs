using System;
namespace SdfElmar
{
    public class AddCProcessor : BaseStringProcessor
    {
        public AddCProcessor(IStringProcessor successor) : base(successor)
        {
        }

        public override string ProcessString(string input)
        {
            try
            {
                return base.ProcessString(input + "C");
            }
            catch (IOException e)
            {
                return input.Replace("C", "");
            }
        }
    }
}

