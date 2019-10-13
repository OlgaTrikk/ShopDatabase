using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDatabase
{
	public class ShoppingCart
	{

		public Guid Id { get; set; }

		public double Sum { get; set; }

		public DateTime DateCreated { get; set; }

		//public Person Client { get; set; }

		public List<Food> Items { get; set; }

		public ShoppingCart()
		{
			Id = Guid.NewGuid();
			DateCreated = DateTime.Now;
			Items = new List<Food>();
		}

		//public void AddToCart(Food food, int amount)
		//{
		//	Items.Add(food);
		//	Amounts.Add(amount);
		//	CalculateSum();
		//}

		//public double CalculateSum()
		//{
		//	for (int i = 0; i < Items.Count; i++)
		//	{
		//		Sum = Sum + Items[i].Price * Amounts[i];
		//	}
		//	return Sum;
		//}
	}
}
