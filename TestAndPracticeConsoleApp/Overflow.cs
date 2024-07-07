using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class Overflow
	{
		public void RunCode()
		{
			int a = int.MinValue;
			// next line will show --int.MaxValue--.
			Console.WriteLine(--a);

			// by using --checked-- operator, we will make the code to throw exception for overflow if it happens.

			int v = int.MaxValue;
			int vv = checked(v + 1);

			checked
			{
				v *= 1023;
				v += 512;
			}
		}
	}
}
