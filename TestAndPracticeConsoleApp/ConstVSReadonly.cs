using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class ConstClass
	{
		// const field members are only static available. which means they can not be accessed via instances of the class.
		public const int Age = 10;
		public const string Country = "iran";
	}

	public class ReadonlyClass
	{
		public readonly string Name;
		public string LastName { get; }
		// using init will make a readonly property but it should be setted via object initializer.(the comment on RunCode will hit error)
		public string Mobile { get; init; }
		public string FullName => Name + LastName;
		public ReadonlyClass(string name)
		{
			this.Name = name;
		}
	}
	internal class ConstVSReadonly
	{
		public void RunCode()
		{
			ConstClass constClass = new();
			ReadonlyClass readonlyClass = new("asghar");
			ReadonlyClass readonlyClass1 = new("akbar") { Mobile = "dsad"};

			//readonlyClass.Mobile = "vsdinv";

			int a = 20;
			int b = a + ConstClass.Age;

		}
	}
}
