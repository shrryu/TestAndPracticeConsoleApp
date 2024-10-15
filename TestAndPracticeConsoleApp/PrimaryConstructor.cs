using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class PrimaryConstructor(string Name, int Age)
	{
		// the line above is the primary constructor.
		public string Mobile { get; set; }
		// parameters in primary constructor are public fields, but they also can be defined explicitly in class:
		public string Name { get; set; } = Name;
		// any other constructor for this class must call primary constructor:
		public PrimaryConstructor(string Name, int Age, string Mobile)
			: this(Name, Age)
		{
			this.Mobile = Mobile;
		}

		public void Test()
		{
			Console.WriteLine(Name);
			Console.WriteLine(Age + 988);
			Console.WriteLine(Mobile);
		}
	}

	public class RunPrimaryConstructor
	{
		public void RunCode()
		{
			var primary = new PrimaryConstructor("sdfasd;fh", 44);
			var primary1 = new PrimaryConstructor("sdfasd;fh", 44, "mob");
			primary.Test();
			primary1.Test();
		}

	}
}
