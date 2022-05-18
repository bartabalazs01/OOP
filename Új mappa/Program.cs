using System;

namespace Myproducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new("name1", 400, 27);
            Bread bread1 = new("name2", 250, 33, 0.9);
            Console.WriteLine(product1.ToString());
            Console.WriteLine(bread1.ToString());
            Console.WriteLine(product1.CompareProducts(bread1));
            Product product2 = new Bread("name3", 100, 15, 1);
            Console.WriteLine(product2.ToString());
            Bread bread2 = new Product("name4", 600, 30) as Bread;
        }
    }
}
