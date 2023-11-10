using System;
namespace Methods
{
	public class BasketManager
	{
		//name convention
		/// syntax
		public void Add(Product product)
		{
			Console.WriteLine("Congratulations. Added to the basket: " + product.Name);
		}

		public void Add2(string productName, string description, double price, int stockQuantity)
		{
            Console.WriteLine("Congratulations. Added to the basket: " + productName);

        }
	}
}

