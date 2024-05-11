using System;
namespace SdfElmar.Exception
{
	public class FileLengthException:IOException
	{
		public FileLengthException(string message):base(message)
		{
		}
	}
}

