using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public abstract class Human
	{
		public abstract int Id { get; set; }
		public string Name { get; set; }
		public abstract string Mobile { get; set; }

		public void AddToName(string addition)
		{
			Name += addition;
		}

		public abstract List<string> SplitName(string separator);
	}

	public abstract class Homosapiens : Human
	{
		public override int Id {  get; set; }
	}

	public class Carpenter : Human
	{
		public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public override string Mobile { get; set; } = "39e4rwedcnasv";

		public override List<string> SplitName(string separator)
		{
			return Name.Split(separator).ToList();
		}
	}

	public class Roman : Homosapiens
	{
		public override string Mobile { get; set; } = "007";

		public override List<string> SplitName(string separator)
		{
			throw new NotImplementedException();
		}
	}

	internal class Abstract
	{
		public void RunCode()
		{
			//var carp = new Carpenter();
			//carp.
			var roman = new Roman();
		}
	}
}
