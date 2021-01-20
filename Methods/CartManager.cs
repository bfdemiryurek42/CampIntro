using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name );
        }
        public void Add2(string productName, string details, double price)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }
    }
}
