using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class BaseClass
	{
		public string Name { get; set; } = "sep";
		public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }
	}
	public class Overrider : BaseClass
	{
		public string Name { get; set; } = "overrider";
		public override void Foo() { Console.WriteLine("Overrider.Foo"); }
	}
	public class Hider : BaseClass
	{
		public new string Name { get; set; } = "hider";
		public new void Foo() { Console.WriteLine("Hider.Foo"); }
	}

	internal class HidingInheritedMembers
	{
		public void RunCode()
		{
			Overrider over = new Overrider();
			BaseClass b1 = over;
			over.Foo(); // Overrider.Foo
			b1.Foo(); // Overrider.Foo
			var BaseClassMember = b1.Name; // sep
			var overriderMember = over.Name; // overrider

			Hider h = new Hider();
			BaseClass b2 = h;
			h.Foo(); // Hider.Foo
			b2.Foo(); // BaseClass.Foo
			var BaseClassMember2 = b2.Name; // sep
			var hiderMember = h.Name; // hider
		}
	}
}
