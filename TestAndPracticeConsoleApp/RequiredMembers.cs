using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	class ReqMembers
	{
		public required string Name { get; set; }
	}

	internal class RequiredMembers
	{

		public void RunCode()
		{
			//var ass = new ReqMembers { Name = "vfjdo" };

			/// this will hit error:
			//var ass = new ReqMembers();
		}
	}
}
