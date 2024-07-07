using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class ShortDataType
	{
		public void RunCode()
		{
			short x = 1;
			short y = 1;
			// next line shows error because --short-- variables have no arithmetic operations so they are implicitly converted into int
			//short z = x + y;

			// but this one is OK since the result of adding 2 ints is fine and then we simply convert it into short:
			short z = (short)(x + y);
		}
	}
}
