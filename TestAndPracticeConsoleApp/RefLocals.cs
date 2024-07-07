using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class RefLocals
	{
		public void RunCode()
		{
			var array = new int[5] { 10, 20, 30, 40, 50 };

			// this is a reference to the 4th element of array. so whenever this variable changes, the 4th element of array changes too.
			ref int arrayElementReference = ref array[3];

			arrayElementReference += 439;

			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine(array[i]);
			}
		}
	}
}
