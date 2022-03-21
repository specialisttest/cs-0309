using System;
using System.Collections;

namespace Lab10
{
    [Serializable]
    class Books : IEnumerable
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }    
}
