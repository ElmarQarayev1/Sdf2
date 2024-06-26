﻿using System;
namespace SdfElmar
{
	public class AppendProcessor : BaseStringProcessor
    {
         public AppendProcessor(IStringProcessor successor) : base(successor)
        {
        }

        public override string ProcessString(string input)
        {
            try
            {
                return base.ProcessString(input + "A");
            }
            catch (IOException e)
            {
                return input.Replace("A", "");
            }
        }
    }
}

