namespace TestAndPracticeConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			var cc = new StaticInterfaceMembers();
			//var cc = new PrimaryConstructor("dskfhsd", 87);

			cc.RunCode();
		}
	}
}
