using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace PracticeNewNameSpace
{
    public enum BookStyle
    {
        CRIME, COOK, OTHER
    }
    class BookWithStyle : Book
    {
        private BookStyle _style;

        public BookWithStyle()
        {        }

        public BookWithStyle(string title, string author, int price, int pages, string publisher, BookStyle style) : base(title, author, price, pages, publisher)
        {
            this._style = style;
        }

        public BookStyle Style { get => _style; }

        public override string ToString()
        {
            return base.ToString() + $", Style: {Style}";
        }
        public static void WriteOutAll(Book[] bookArray)
        {
            foreach (Book book in bookArray)
            {
                book.ToString();
            }
        }

        public static BookWithStyle[] AssortByStyle(BookWithStyle[] bookws, BookStyle style)
        {
            int count = 0;
            for (int j = 0; j < bookws.Length; j++)
            {
                if (bookws[j].Style == style) count++;
            }
            BookWithStyle[] assortedArray = new BookWithStyle[count];
            int i = 0;
            foreach (BookWithStyle book in bookws)
            {
                if (book.Style == style)
                {
                    assortedArray[i] = book;
                    i++;
                }
                
            }
            return assortedArray;
        }
    }

    
}
