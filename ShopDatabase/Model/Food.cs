using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDatabase
{
	public class Food
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		public double Price { get; set; }


		public Food()
		{			
		}

		public Food(string name, double price)
		{
			Id = Guid.NewGuid();
			Name = name;
			Price = price;
		}
	}
}
