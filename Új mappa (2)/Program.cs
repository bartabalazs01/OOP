using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("konyvcime", "irojaa");
            book1.Title = "konyvcime";
            book1.Author = "irojaa";
            book1.Price = 2500;
            Console.WriteLine(book1.ToString());   

            Console.Write("Adja meg hany konyvet szeretne beolvasni: ");
            string s = Console.ReadLine();
            int n;
            while (!Int32.TryParse(s, out n));

            Book[] book = new Book[3];
            for(int i = 0; i < n; i++)
            {
                int price, pages;
                Console.Write("Adja meg a konyv cimet: ");
                string name = Console.ReadLine();
                Console.Write("Adja meg a konyv szerzojet: ");
                string author = Console.ReadLine();
                Console.Write("Adja meg a konyv arat: ");
                while (!Int32.TryParse(Console.ReadLine(), out price));
                Console.Write("Adja meg hany oldalas a konyv: ");
                while (!Int32.TryParse(Console.ReadLine(), out pages));
                Console.Write("Adja meg a konyv kiadojat: ");
               	string publisher = Console.ReadLine();
                book[i] = new Book(name, author, price, pages, publisher);
                book[i].WriteItOut();
            }

            Book.LongestBook(book);


        }
    }
}
