namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Name = "apple";
        product1.Price = 15;
        product1.Description = "description";

        Product product2 = new Product();
        product2.Name = "watermelon";
        product2.Price = 80;
        product2.Description = "description";

        Product[] products = new Product[] { product1, product2 };
        //type-safe --tip güvenli
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Description);
            Console.WriteLine("*****************");
        }

        Console.WriteLine("-----------Methods----------");
        //instance - örnek
        //encapsulation
        BasketManager basketManager= new BasketManager();
        basketManager.Add(product1);
        basketManager.Add(product2);

        basketManager.Add2("Banana", "description", 20, 10);
        basketManager.Add2("Banana", "description", 20,9);
        basketManager.Add2("Banana", "description", 20,5);
        Console.ReadLine();
    }
}
//DO NOT REPEAT YOURSELF! - DRY- Clean Code- Best Practise
