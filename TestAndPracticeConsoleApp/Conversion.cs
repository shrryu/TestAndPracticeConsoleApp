using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class Conversion
	{
		public void RunCode()
		{
			int a = 33;
			float myFloat = (float)3.14;
			float b = (float)346.86;
			double c = 98.97;


			var IntToFloat = float.Parse(a.ToString());
			var IntToDouble = double.Parse(a.ToString());
			var v = b.ToString();
			var FloatToInt = int.TryParse(b.ToString(), out int vv);
			var FloatToDouble = double.Parse(b.ToString());
			var DoubleToInt = int.TryParse(c.ToString(), out int bb);
			var DoubleToFloat = float.Parse(c.ToString());
		}
	}
}
