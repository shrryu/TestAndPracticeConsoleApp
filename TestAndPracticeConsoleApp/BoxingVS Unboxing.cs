using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class BoxingVS_Unboxing
	{
		public void RunCode()
		{
			object a = 72;
			int b = 34;

			// boxing:
			object box = b;

			// unboxing:
			int unbox = (int)a;

			// next line throws exception since a number is int by default (technically, a which has 72 in it, is of int type).
			long unbox2 = (long)b;
			// however, it can be fixed by the next line:
			long unbox3 = (int)box;

			// and this one for numbers with precision: (since numbers with precision are of type double)
			object c = 4.54;
			int unbox4 = (int)(double)c;
			// the (double) code does the unboxing, then (int) code does a conversion.
		}
	}
}
