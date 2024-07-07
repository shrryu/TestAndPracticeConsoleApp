using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class PassingArguments
	{
		public void RunCode()
		{
			PointClass pc = new();
			pc.x = 20;

			int vv = 45;

			Pass(vv);
			Console.WriteLine($"vv after Pass: {vv}");
			PassByRef(ref vv);
			Console.WriteLine($"vv after PassByRef: {vv}");
			Pass(pc);
			Console.WriteLine($"pc.x after Pass: {pc.x}");
			//Console.WriteLine($"---pc: {pc.GetType().GUID}");
			PassByRef(ref pc);
			Console.WriteLine($"pc.x after PassByRef: {pc.x}");
			//Console.WriteLine($"---pc: {pc.GetType().GUID}");


			// out modifer:
			var nikola = "nikola";
			Out(nikola, out string name, out int age);
			Console.WriteLine($"nikola after Out: {nikola}, name after Out: {name}, age after Out: {age}");

			// in modifer:
			In(nikola, in name, in age);
			Console.WriteLine($"nikola after In: {nikola}, name after In: {name}, age after In: {age}");
		}

		public void Pass(int a)
		{
			int b = a;
			b++;
			a--;
			Console.WriteLine($"---a: {a}");
			Console.WriteLine($"---b: {b}");
		}
		public void PassByRef(ref int a)
		{
			int b = a;
			b++;
			a--;
			Console.WriteLine($"---(ref) a: {a}");
			Console.WriteLine($"---(ref) b: {b}");
		}

		public void Pass(PointClass pc)
		{
			var point = pc;
			var point1 = pc;

			//point = new PointClass();
			pc = new PointClass();
			point.x = 19;
			pc.x = 70;
			point1.x = 36;


			Console.WriteLine($"---point.x: {point.x}");
			Console.WriteLine($"---point1.x: {point1.x}");
			Console.WriteLine($"---pc.x: {pc.x}");

			//Console.WriteLine($"---point: {point.GetType().GUID}");
			//Console.WriteLine($"---point1: {point1.GetType().GUID}");
			//Console.WriteLine($"---pc: {pc.GetType().GUID}");
		}

		public void PassByRef(ref PointClass pc)
		{
			var point = pc;
			var point1 = pc;

			//point = new PointClass();
			pc = new PointClass();
			point.x = 19;
			pc.x = 89;
			point1.x = 76;

			Console.WriteLine($"---(ref) point.x: {point.x}");
			Console.WriteLine($"---(ref) point1.x: {point1.x}");
			Console.WriteLine($"---(ref) pc.x: {pc.x}");

			//Console.WriteLine($"---point: {point.GetType().GUID}");
			//Console.WriteLine($"---point1: {point1.GetType().GUID}");
			//Console.WriteLine($"---pc: {pc.GetType().GUID}");
		}


		public void Out(string a, out string b, out int c)
		{
			a = "ben";
			b = a + " new";
			c = 80;
		}

		public void In(string a, in string b, in int c)
		{
			// next 2 lines generate compile time error since --in-- modifier makes parameters not-changeable.
			//b = a + " new";
			//c = 80;

			var v = a + b;
			var i = c + 79;
		}
	}
}
