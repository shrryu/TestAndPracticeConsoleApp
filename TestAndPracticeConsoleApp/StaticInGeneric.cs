using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class Bob<T>
	{
        public static int Count { get; set; }
    }
	internal class StaticInGeneric
	{
		public void RunCode()
		{
			Console.WriteLine(++Bob<int>.Count);	// 1
			Console.WriteLine(++Bob<int>.Count);	// 2
			Console.WriteLine(++Bob<string>.Count); // 1
			Console.WriteLine(++Bob<object>.Count); // 1
		}
	}
}
