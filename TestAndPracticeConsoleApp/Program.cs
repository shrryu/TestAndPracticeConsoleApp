namespace TestAndPracticeConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			IEnumerable<Asset> Items = Enumerable.Empty<Asset>();

			var cc = new RunPrimaryConstructor();
			//var cc = new PrimaryConstructor("dskfhsd", 87);

			cc.RunCode();
		}
	}
}
