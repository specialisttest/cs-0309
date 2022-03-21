using System;
using System.Collections;

namespace Lab9
{
    class Books : IEnumerable
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
        public IEnumerable GetByAuthor()
        {
            return new EnumAuthor(books);
        }
        public IEnumerable GetReverseEnum()
        {
            for (int i = books.Length-1; i >= 0; i--)
                yield return books[i];
        }
        public IEnumerable GetByPrice()
        {
            Book[] data = (Book[])books.Clone();
            Array.Sort(data, Book.ByPrice());

            for (int i=0; i<data.Length; ++i)
                yield return data[i];
        }
    }

    class EnumAuthor : IEnumerable, IEnumerator
    {
        int i = -1;
        Book[] data;

        public EnumAuthor(Book[] books)
        {
            data = (Book[])books.Clone();
            Array.Sort(data, Book.ByAuthor());
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public object Current
        {
            get
            {
                return data[i];
            }
        }
        public bool MoveNext()
        {
            i++;
            if (i < data.Length) return true;
            else return false;
        }
        public void Reset()
        {
            i = -1;
        }
    }
}
