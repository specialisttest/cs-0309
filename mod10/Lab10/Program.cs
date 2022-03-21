using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            Stream stream = File.Create(@"..\..\books.txt");
            SoapFormatter serializer = new SoapFormatter();
            serializer.Serialize(stream, books);
            stream.Dispose();

            //Stream stream = File.OpenRead("books.txt");
            //SoapFormatter serializer = new SoapFormatter();
            //Books bs = (Books)serializer.Deserialize(stream);
            //stream.Dispose();

            //foreach (Book b in bs) Console.WriteLine(b);

        }
    }
}
