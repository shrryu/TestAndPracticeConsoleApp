using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	/// cannot instantiate this; also properties and methods must be static
	internal static class StaticClass
	{
		public static int Counter { get; set; } = 0;
		public static void Count()
		{

		}
    }

	internal class Static
	{
		public static int Counter { get; set; } = 0;
		public static void Count()
		{

		}
	}

	internal class Run
	{
		public void RunCode()
		{
			var vv = new Static();
			// this will result in error since we are using an instance of Static to change or get a static property.
			//var cc = vv.Counter++;
			// this is correct:
			var cc = Static.Counter++;


			StaticClass.Counter = 0;
			StaticClass.Count();

			List<Action> actions = new();
			actions.Add(() => Static.Count());
			actions.Add(() => StaticClass.Count());

		}
	}
}
