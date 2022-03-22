using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab11
{
    class Book : IComparable<Book>
    {
        public int    Id     { get; set; }
        public double Price  { get; set; }
        public string Title  { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return "id="+Id+" price="+Price+"$  "+Author+" : "+Title;
        }

        public int CompareTo(Book b)
        {
            return (int)(this.Price - b.Price);
        }

        class SortbyAuthor : IComparer<Book>
        {
            public int Compare(Book b1, Book b2)
            {
                int res = 0;

                res = b1.Author.CompareTo(b2.Author);
                if (res == 0) res = (int)(b1.Price - b2.Price);

                return res;
            }
        }
        public static IComparer<Book> ByAuthor() { return new SortbyAuthor(); }

    }
}
