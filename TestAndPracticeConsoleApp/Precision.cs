using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class Precision
	{
		public void RunCode()
		{
			// float and double are based on 2; so they can only show floating point numbers which are calculable by base 2.
			float a = 0.1f;
			Console.WriteLine(a + a + a + a + a + a + a + a + a + a); // 1.0000001

			// to solve this problem, we use decimal since it is based on 10 instead of 2.
			decimal m = 1M / 6M; // 0.1666666666666666666666666667M
			double d = 1.0 / 6.0; // 0.16666666666666666

			decimal notQuiteWholeDecimal = m + m + m + m + m + m; // 1.0000000000000000000000000002M
			double notQuiteWholeDouble = d + d + d + d + d + d; // 0.99999999999999989
		}
	}
}
