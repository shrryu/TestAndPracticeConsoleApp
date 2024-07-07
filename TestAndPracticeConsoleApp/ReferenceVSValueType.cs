using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal struct PointStrct
	{
		public int x;
		public int y;
		public int z;
	}

	internal class PointClass
	{
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

	internal class ReferenceVSValueType
	{
		public void RunCode()
		{
			// value type:
			PointStrct pointStrct1 = new PointStrct();
			pointStrct1.x = 10;

			PointStrct pointStrct2 = pointStrct1;

			pointStrct2.x = 20;
			Console.WriteLine(pointStrct1.x);
			Console.WriteLine(pointStrct2.x);

			// reference type:
			PointClass pointClass1 = new PointClass();
			pointClass1.x = 10;

			PointClass pointClass2 = pointClass1;
			pointClass2.x = 20;

			Console.WriteLine(pointClass1.x);
			Console.WriteLine(pointClass2.x);

			// In array:
			var pointStructArray = new PointStrct[1000];
			pointStructArray[500].x = 30;
			Console.WriteLine(pointStructArray[500].x);

			var pointClassArray = new PointClass[1000];
			// error since PointClass is reference type so pointClassArray must first instantiates it's elements before read from or assign value into it's properties.
			pointClassArray[1000].x = 40;
			Console.WriteLine(pointClassArray[500].x);


		}
	}
}
