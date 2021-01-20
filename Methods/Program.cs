using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";
            
            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Price = 15;
            product1.Details = "Amasya Elması";

            Product product2 = new Product();

            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Details = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2};

            //type-safe 
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Details);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("-----------Methods------------");

            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Armut", "Yeşil Armut", 12);
            cartManager.Add2("Elma", "Yeşil Elma", 12);
            cartManager.Add2("Karpuz", "Yeşil Karpuz", 12);


        }
    }
}
