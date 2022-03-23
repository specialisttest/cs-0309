using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ASyncProject
{
    class Program
    {
        static long Sum()
        {
            long summa = 0;
            for (long i = 1; i <= 100000000; i++)
                summa += i;
            return summa;
        }

        static Task<long> SumAsync()
        {
            return Task.Run(() =>
            {
                long summa = 0;
                for (long i = 1; i <= 100000000; i++)
                    summa += i;
                return summa;
            });
        }


        static async void Test()
        {
            long r1 = await SumAsync();
            long r2 = await SumAsync();

            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
        
        static async Task<long> LongExecute() {
            return await Task.Run(() =>
            {
                long summa = 0;
                for (long i = 1; i <= 100000000; i++)
                    summa += i;
                return summa;
            });

            //t2.Wait();
            //return t2.Result;
        }

        static void Main(string[] args)
        {
            Test();

            dynamic o = new Program();
            //o.djkghasjkdhgjsfk();

            Thread.Sleep(2000);
            // TPL
            //System.Threading.Thread
            /*
            Task task = new Task(() => Console.WriteLine("Hello task"));
            task.Start();
            task.Wait();
            //Console.ReadKey();
            //Task.Factory.StartNew()

            Task<long> t2 = LongExecute();
            t2.Wait();
            Console.WriteLine(t2.Result);*/

        }
    }
}
