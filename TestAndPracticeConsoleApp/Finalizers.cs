using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class Finalizers
	{
		// this method will be called once GC comes after the instance of this class that it want's to reclaim it's memory.
		~Finalizers() { Console.WriteLine("Finalizer (destructor)"); }
	}
}
