using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	class ReqMembers
	{
		public required string Name;
		public required string Mobile { get; set; }
		// if the next line becomes uncommented, it will cause error on ass variable since required makes Name field to be instantiated
		// at the time we instantiate from this class, but we did not give it a default value nor we used ctor at creating the ass variable.
		// so it generates an error since Name has no value and it is required.
		//public ReqMembers(string name)
		//{
		//	this.Name = name;
		//}

		//public ReqMembers(string mobile)
		//{
		//	this.Mobile = mobile;
		//}
		public required string Emails { get; init; }
	}

	internal class RequiredMembers
	{
		public void RunCode()
		{
			//var ass = new ReqMembers { Name = "vfjdo", Mobile = "sdfjsd" };
			var ass2 = new ReqMembers { Name = "vfjdo", Mobile = "sdfjsd" , Emails = "dsffsdv"};
			// next line will hit error since we have
			//ass2.Emails = "";
			ass2.Mobile = "";

			/// this will hit error:
			//var ass = new ReqMembers();
		}
	}
}
