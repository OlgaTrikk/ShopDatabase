using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new ShopDbContext())
			{
				//Person newPerson = new Person("Mary", "Smith");

				//db.Persons.Add(newPerson);
				//db.SaveChanges();

				ShoppingCart newCart = new ShoppingCart();
				//newCart.Client = newPerson;
				//db.ShoppingCarts.Add(newCart);

				//newPerson.ShoppingCarts.Add(newCart);
				//db.Persons.Add(newPerson);

				List<Food> groceries = new List<Food>
				{
					new Food("banana", 1),
					new Food("icecream", 2),
					new Food("potatoes", 1),
				};

				//foreach(var food in groceries)
				//{
				//	newCart.Items.Add(food);
				//}

				//db.ShoppingCarts.Add(newCart);

				Console.WriteLine("What do you want to buy?");
				var foodName = Console.ReadLine();
				Food chosenFood = groceries.FirstOrDefault(x => x.Name == foodName);
				newCart.Items.Add(chosenFood);

				db.ShoppingCarts.Add(newCart);

				db.SaveChanges();

				var carts = db.ShoppingCarts.Include("Items").OrderBy(c => c.DateCreated).ToList();
				foreach (var cart in carts)
				{
					Console.WriteLine("");
					Console.WriteLine($"Shopping cart created on {cart.DateCreated}");
					Console.WriteLine("Items in cart");
					var foodItems = cart.Items;
					foreach (var food in foodItems)
					{
						Console.WriteLine("****");
						Console.WriteLine($"{food.Name} Price: {food.Price}");
					}
				}
			}

			Console.ReadKey();
		}
	}
}
