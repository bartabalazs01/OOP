using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Book
    {
        private string _title;
        private string _author;
        private readonly string _yearOfAppearance = DateTime.Today.ToString("yyyy");
        private int _price;

        private int _pages;
        private string _publisher = "Mora";

        public Book()
        { }

        public Book(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public Book(string title, string author, int price)
        {
            _title = title;
            _author = author;
            _price = price;
        }

        public Book(string title, string author, int price, int pages, string publisher)
        {
            _title = title;
            _author = author;
            _price = price;
            _pages = pages;
            _publisher = publisher;
        }

        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public int Price { get => _price; set => _price = value; }

        public string YearOfAppearance => _yearOfAppearance;

        public int Pages { get => _pages; set => _pages = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }

        public int IncreasePrice(int percent)
        {
            return this._price = _price * (1 + percent);
        }

        public void WriteItOut()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Title: {_title}, Author: {_author}, Appearance: {YearOfAppearance}, Price: {_price} Ft, Pages: {_pages}, Publisher: {_publisher}"; 
        }

        public static Book WhichIsLonger(Book book1, Book book2)
        {
            if (book1.Pages > book2.Pages) return book1;
            else return book2;
        }

        public bool OddPages()
        {
            return Pages % 2 == 0;
        }

        public static void LongestBook(Book[] bookArray)
        {
            Book b1 = bookArray.First();
            foreach (Book book in bookArray.Skip(1))
            {
                if (book.Pages > b1.Pages) b1 = book;
            }

            Book b2 = bookArray.Where(b => b.Pages == bookArray.Max(m => m.Pages)).First();
        }

        public static void WriteOutByAuthor(Book[] bookArray)
        {

            List<Book> bookList = new List<Book>(bookArray);
            
        }
    }

}
