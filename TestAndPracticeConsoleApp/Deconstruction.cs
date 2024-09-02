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
			Console.WriteLine("deconstructed");
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

			// this will not erase dec's memory, just want to extract data from dec.
			dec.Deconstruct();

			// or

			(string name, var age) = dec;
		}
	}
}
