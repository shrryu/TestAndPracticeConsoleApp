using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	interface ILogger
	{
		private void vv() => Console.WriteLine("private method in interface");
		void Log(string text) => Console.WriteLine(Prefix + text);
		static string Prefix = "";
	}
	public class NonStaticVirtual : ILogger
	{

	}

	interface ITypeDescribable
	{
		// Description property must be implemented in class but implementing Category is Optional
		// these 2 property can only be accessed through instances of classes that implement this interface
		static abstract string Description { get; }
		static virtual string Category => null;
	}
	public class StaticVirtualFirst : ITypeDescribable
	{
		public static string Description => "Customer tests"; // Mandatory
		public static string Category => "Unit testing"; // Optional
	}
	public class StaticVirtualSecond : ITypeDescribable
	{
		public static string Description => "here is to you"; // Mandatory
		public static string Category => "nikola and bart"; // Optional
	}

	internal class StaticInterfaceMembers
	{
		public void RunCode()
		{
			var nonStaticVirtual1 = new NonStaticVirtual();
			var nonStaticVirtual2 = new NonStaticVirtual();

			// Prefix can only be accessed through ILogger Interface.
			ILogger.Prefix = "Program";
			ILogger loggernonStaticVirtual1 = nonStaticVirtual1 as ILogger;
			ILogger loggernonStaticVirtual2 = nonStaticVirtual2 as ILogger;
			// Log can only be accessed through Instances of ILogger.
			loggernonStaticVirtual1.Log(" TestAndPractice");
			loggernonStaticVirtual2.Log(" TestAndPractice");


			var staticVirtual1 = new StaticVirtualFirst();
			var staticVirtual2 = new StaticVirtualSecond();

			ITypeDescribable TypeDescribableStaticVirtual1 = staticVirtual1 as ITypeDescribable;
			ITypeDescribable TypeDescribableStaticVirtual2 = staticVirtual2 as ITypeDescribable;

			Console.WriteLine(StaticVirtualFirst.Description);
			Console.WriteLine(StaticVirtualSecond.Description);
			Console.WriteLine(StaticVirtualFirst.Category);
			Console.WriteLine(StaticVirtualSecond.Category);
		}
	}
}
