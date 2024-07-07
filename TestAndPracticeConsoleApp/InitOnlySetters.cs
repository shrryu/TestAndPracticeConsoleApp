using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class Init
	{
		// this property is like readonly properties; only that it can be set through object initializer.
        public string Name { get; init; }
		public int Age { get; set; }
    }

	internal class InitOnlySetters
	{
		public void RunCode()
		{
			var initClass = new Init() { Name = "akbar" };
			// next line hits an error:
			//initClass.Name = "jafar";
		}
	}
}
