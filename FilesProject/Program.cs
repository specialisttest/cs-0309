using System;
using System.IO;

using System.IO.Compression;

using System.Runtime.Serialization.Formatters.Soap;

namespace FilesProject
{
    class Program
    {
        const string fileName = @"..\..\test.txt";
        const string dirName = @"..\..\";

        static void Main(string[] args)
        {
            if (!File.Exists(fileName))
                File.Create(fileName);

            FileInfo fi = new FileInfo(fileName);
            if (!fi.Exists)
                fi.Create();
            else
                Console.WriteLine("{0} {1}",
                    fi.FullName, fi.CreationTime);

            string content = File.ReadAllText(fileName);
            Console.WriteLine(content);
            

            DirectoryInfo dir = new DirectoryInfo(dirName);
            Console.WriteLine(dir.FullName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (var d in dirs)
                Console.WriteLine(d.Name.ToUpper());

            foreach (var f in dir.GetFiles())
                Console.WriteLine(f.Name.ToLower());


            //Path.Combine

            //Console.WriteLine(Path.GetTempFileName());

            //Console.WriteLine(File.ReadAllText(fileName));


            //FileStream fs = new FileStream(fileName, FileMode.Open);
            //fs.Seek(0, SeekOrigin.Begin)
            //fs.read

            using (StreamReader reader = new StreamReader(fileName))
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            } // reader.Dispose()


            //reader.Close();

            /*
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName, true);
                writer.WriteLine(DateTime.Now.ToLongTimeString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer?.Dispose();
            }


            // IDisposable
            using (StreamWriter writer2 = new StreamWriter(fileName, true))
            {
                writer2.WriteLine(DateTime.Now.ToLongTimeString());
            } // writer.Dispose()
            */

            //ZipFile.OpenRead("my.zip").Entries[0].Open()

            SoapFormatter f;



        }
    }
}
