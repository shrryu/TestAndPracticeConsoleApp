using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndPracticeConsoleApp
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Customer: Person
	{
        public string Email { get; set; }
    }

	internal class Casting
	{
		public void RunCode()
		{
			// upcast (always Ok)
			Person person = new Customer();
			// downcast (this way it gives error
			//Customer customer = new Person();

			// downcast is available only if we do a explicit cast for it:
			Person person1 = new Person();
			Customer customer0 = (Customer)person;
			// funny thing is the next line will throw an exception even though we used explicit casting:
			//Customer customer1 = (Customer)person1;

			// the as operator will do the downcast but if it's not successful, it will return null instead of throwing an exception (first line is null but the second one contains the instance)
			Customer customer2 = person1 as Customer;
			Customer customer3 = person as Customer;
		}
	}
}
