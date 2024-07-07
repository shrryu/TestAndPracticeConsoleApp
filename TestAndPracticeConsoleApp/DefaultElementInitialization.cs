using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class DefaultElementInitialization
	{
		public void RunCode()
		{
			var a = new int[100];
			Console.WriteLine(a[90]);

			var b = new string[100];
			Console.WriteLine(b[90]);
		}
	}
}
