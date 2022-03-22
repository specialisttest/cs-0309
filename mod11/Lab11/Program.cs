using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book(){Id=1, Price=32, Author="Seemann", Title="Dependency Injection in .NET" });
            books.Add(new Book() {Id=2, Price=42, Author="Richter", Title="CLR via C#" });
            books.Add(new Book() {Id=3, Price=21, Author="Munro", Title="ASP.NET MVC 5" });
            books.Add(new Book() {Id=4, Price =39, Author="Esposito", Title= "Microsoft® ASP.NET and AJAX" });
            books.Add(new Book() {Id=5, Price=30, Author="Esposito", Title="Architecting Applications for the Enterprise" });
            books.Add(new Book() {Id=6, Price=23, Author="Watson", Title="Writing High-Performance .NET Code" });
            books.Add(new Book() {Id=7, Price=37, Author="Sharp", Title="Microsoft Visual C# 2013" });
            books.Add(new Book() {Id=8, Price=20, Author="Esposito", Title= "Programming Microsoft® ASP.NET 2.0" });
            books.Add(new Book() {Id=9, Price=11, Author="Stubblebine", Title="Regular Expression" });
            books.Add(new Book() {Id=10, Price=27, Author="Liberty", Title="Learning Visual Basic .Net" });
            books.Add(new Book() {Id=11, Price=62, Author="Cwalina", Title="Framework Design Guidelines" });
            books.Add(new Book() {Id=12, Price=55, Author="Blewett", Title="Pro Asynchronous Programming with .NET" });
            books.Add(new Book() {Id=13, Price=47, Author="Nathan", Title="Windows Presentation Foundation Unleashed" });

            //books.Sort();
            books.Sort(Book.ByAuthor());
            foreach (var book in books)     Console.WriteLine(book);
        }
    }
}
