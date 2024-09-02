using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class StaticConstructor
	{
		// when an object of class is instantiated, static ctor will first be executed. before that, static field initializer would have run
		public static Guid Id { get; set; } = new Guid();
		public static string Email { get; set; } = "sep@gmail.com";
		public string Name { get; set; } = "sep";
		static StaticConstructor()
		{
			Console.WriteLine("Static constructor here");
		}

		public StaticConstructor()
		{
			Console.WriteLine("Simple constructor here");
		}

    }

	internal class StaticConstructorTest
	{
		public void RunCode()
		{
			var staticCtor = new StaticConstructor();
		}
	}
}
