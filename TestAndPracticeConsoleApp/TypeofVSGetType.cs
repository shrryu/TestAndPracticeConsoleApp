using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	internal class TypeofVSGetType
	{
		public void RunCode()
		{
			var asset = new Asset();
			// this is in compile time
			var assetTypeof = typeof(Asset);
			// this is in runtime time
			var assetGetType = asset.GetType();

			Console.WriteLine(assetTypeof.Name);
			Console.WriteLine(assetGetType.Name);
			Console.WriteLine(assetTypeof == assetGetType);
		}
	}
}
