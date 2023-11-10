using System;
namespace OOP1
{
	public class ProductManager
	{
		//encapsulation
		public void Add(Product product)
		{
			Console.WriteLine(product.ProductName + " eklendi.");
		}
		public void Update(Product product)
		{
            Console.WriteLine(product.ProductName + " eklendi.");
        }
		//public int Topla(int sayi1, int sayi2)
		//{
		//	return sayi1 + sayi2;
		//}
        //public void Topla2(int sayi1, int sayi2)
		//{
		//	Console.WriteLine(sayi1 + sayi2); 
		//}
        //public void BiSeyYap(int number)
        //{
        //    number = 99;
        //}
    }
}

