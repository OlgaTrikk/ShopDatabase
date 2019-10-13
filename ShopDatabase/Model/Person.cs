using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDatabase
{
	public class Person
	{

		public Guid Id { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }

		//public List<ShoppingCart> ShoppingCarts { get; set; }

		public Person(string firstName, string lastName)
		{
			Id = Guid.NewGuid();
			FirstName = firstName;
			LastName = lastName;
			//ShoppingCarts = new List<ShoppingCart>();
		}

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}
