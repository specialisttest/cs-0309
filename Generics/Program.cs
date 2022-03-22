using System;
using System.Diagnostics.CodeAnalysis;

namespace Generics
{



    class ReadonlyStorage<T>
        where T : IComparable<T>
                  // struct, class, new()
    { 
        
        public T Data { get; private set; }

        public bool IsGreater(T x)
        {
            //T t = new T();
            return this.Data.CompareTo(x) > 0;
        }

        public ReadonlyStorage(T data)
        {
            this.Data = data;
        }
    }
    
    class Program
    {

        static void Swap<T>(ref T a, ref T b)
            where T : struct
        {
            T c = a;
            a = b;
            b = c;
        }

        interface A<out T> {
            T Get();
        }
        interface B<in T> {
            void Add(T t);
        }

        class BImpl<T> : A<T>, B<T>
        {
            public void Add(T t)
            {
                
            }
            
            public T Get()
            {
                return default(T);
            }
        }

        

        static void Main(string[] args)
        {
            {
                BImpl<string> bimpl = new BImpl<string>();
                A<string> a = bimpl; // инвариант
                B<string> b = bimpl;

                // A<object>    !=  A<string>
                // object Get()     string Get()
                A<object> a2 = bimpl; // контрвариантом

                B<object> bimpl2 = new BImpl<object>();
                B<string> b2 = bimpl2; // ковариант

            }
            

            ReadonlyStorage<int> r1 = new ReadonlyStorage<int>(5);
            ReadonlyStorage<double> r2 = new ReadonlyStorage<double>(2.5);
            ReadonlyStorage<string> r3 = new ReadonlyStorage<string>("abc");
            //ReadonlyStorage<Program> r4 = new ReadonlyStorage<Program>(new Program());

            Console.WriteLine(r1.Data);
            Console.WriteLine(r2.Data);
            Console.WriteLine(r3.Data);


            {
                int a = 2, b = 10;
                Console.WriteLine($"a = {a} b = {b}");
                Swap<int>(ref a, ref b);
                Console.WriteLine($"a = {a} b = {b}");
            }
            {
                double a = 2.5, b = 10.1;
                Console.WriteLine($"a = {a} b = {b}");
                Swap(ref a, ref b);
                Console.WriteLine($"a = {a} b = {b}");
            }
            
            
        }

    }
}
