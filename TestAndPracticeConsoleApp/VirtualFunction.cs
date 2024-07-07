using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class Asset
	{
		public string Name { get; set; }
		public virtual Asset Clone() => new Asset { Name = Name };
	}
	public class House : Asset
	{
		public decimal Mortgage { get; set; }
		// though Clone method in Asset class returns Asset, it is Ok to return House in House class since House is derived from Asset
		public override House Clone() => new House { Name = Name, Mortgage = Mortgage };
	}
	internal class VirtualFunction
	{
		public void RunCode()
		{

		}
	}
}
