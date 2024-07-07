using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class Deconst
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public void Deconstruct()
		{

		}
		public void Deconstruct(out string Name)
		{
			Name = this.Name;
		}

		public void Deconstruct(out string Name, out int Age)
		{
			Name = this.Name;
			Age = this.Age;
		}
	}

	public class Deconstruction
	{
		public void RunCode()
		{
			var dec = new Deconst();
			dec.Name = "akbar";
			dec.Age = 2;

			dec.Deconstruct();

			// or

			(string name, var age) = dec;
		}
	}
}
