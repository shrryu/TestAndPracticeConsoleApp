using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class Dude
	{
		public string Name;
		public Dude(string n) { Name = n; }
	}
	internal class Equality
	{
		public void RunCode()
		{
			Dude d1 = new Dude("John");
			Dude d2 = new Dude("John");
			Console.WriteLine(d1 == d2); // False
			Dude d3 = d1;
			Console.WriteLine(d1 == d3); // True

			Console.WriteLine(d1.Name == d2.Name); // True
			d2.Name = "fjdis";
			Console.WriteLine(d1.Name == d2.Name); // False
		}
	}
}
