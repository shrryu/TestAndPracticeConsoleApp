using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public interface IA
	{
		public void Print();
	}

	public interface IB
	{
		public void Print();
	}

	public interface IC
	{
		public void Print();
	}

	public interface IDA
	{
		void Print() => Console.WriteLine("IDA interface");
	}

	public interface IDB : IDA
	{
		void IDA.Print() => Console.WriteLine("IDB interface");
	}

	public interface IDC : IDA
	{
		void IDA.Print() => Console.WriteLine("IDC interface");
	}


	public class DiamondClassA : IB, IC
	{
		public void Print()
		{
			throw new NotImplementedException();
		}
	}

	public class DiamondClassB : IDB, IDC
	{
		// without the next line, we will have compile error since there a ambiguity for in choosing between IDB.Print or IDC.Print
		void IDA.Print()
		{
			throw new NotImplementedException();
		}

	}
	public class DiamondProblem
	{
		public void RunCode()
		{
			var dProblemA = new DiamondClassA();
			var dProblemB = new DiamondClassB();

			dProblemA.Print();
			IDA aa = (IDA)dProblemB;
			IDB bb = (IDB)dProblemB;
			IDC dd = (IDC)dProblemB;
			aa.Print();
			bb.Print();
			dd.Print();
		}
	}
}
