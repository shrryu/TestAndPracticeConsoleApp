using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public abstract class Human
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public abstract string Mobile { get; set; }

		public void AddToName(string addition)
		{
			Name += addition;
		}

		public abstract List<string> SplitName(string separator);
	}

	public class Carpenter : Human
	{
		public override string Mobile { get; set; } = "39e4rwedcnasv";

		public override List<string> SplitName(string separator)
		{
			return Name.Split(separator).ToList();
		}
	}

	internal class Abstract
	{
		public void RunCode()
		{
			//var carp = new Carpenter();
			//carp.
		}
	}
}
