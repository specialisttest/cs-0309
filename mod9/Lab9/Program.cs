using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            foreach (Book book in books.GetByPrice())       Console.WriteLine(book);
            foreach (Book book in books.GetReverseEnum())   Console.WriteLine(book);
            foreach (Book book in books.GetByAuthor())      Console.WriteLine(book);

            Console.WriteLine();
            foreach (Book book in books)        Console.WriteLine(book);
        }
    }
}
