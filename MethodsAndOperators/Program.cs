using System;
using System.Collections;
using System.Collections.Generic;

namespace MethodsAndOperators
{
    class Program
    {
        const int ONE = 1;

        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static double Average(int a, int b) 
        {
            double avg = (a + b) / 2d;
            return avg;
        }

        /*static IEnumerable<int> GetNumbers3() 
        {
            List<int> nums = new List<int>();
            for (int i = 3; i < 100; i += 3)
                nums.Add(i);

            return nums;
        }*/
        static IEnumerable<int> GetNumbers3()
        {
            for (int i = 3; i < 100; i += 3)
            {
                if (i < 30) yield return i;
                else yield break; // return со значениями накопленными yield return ранее
            }
                
        }

        static double Average(params int[] m) 
        {
            int summa = 0;
            foreach(int k in m)
                summa += k;

            return (double)summa / m.Length;
        }

        /*static void SayHello(string name)
        {
            Console.WriteLine($"Привет {name}!");

        }*/
        static void SayHello(string name = "Незнакомец", int age = 18)
        {
            Console.WriteLine($"Привет {name} - {age}!");
        }

        static void Init(out int a) 
        {
            a = 100;
        }

        // since C# 8.0
        static string test(int obj) => obj switch
        {
            3 => "три",
            var i when i > 0 => ">0",
            _ => "NA"
        };
        

        
        static void Main(string[] args)
        {
            
            SayHello("Sergey", 43);
            SayHello("Andrey");
            SayHello();
            SayHello(age:27, name:"Alex");
            SayHello(age: 29);

            {
                int x = 7, y = 5;
                Console.WriteLine($"Before Swap: {x} {y}");
                Swap(ref x, ref y);
                Console.WriteLine($"After  Swap: {x} {y}");
            }

            {
                string x = "abc";
                Console.WriteLine(x);
            }
            {
                int a;
                Init(out a);
                Console.WriteLine($"init {a}");
                a = -1;
                if (a > 0)
                {
                    Console.WriteLine("a > 0");
                    Console.WriteLine("a больше 0");
                }
                else
                    Console.WriteLine("a не больше нуля");


                Console.WriteLine(Average(11, 12));

                Console.WriteLine(Average(new int[] { 11, 12, 13, 14 }));
                Console.WriteLine(Average(11, 12, 13, 14, 15));
                Console.WriteLine(Average(11, 12, 13, 14, 15, 16));
            }
            {
                int a = 12;
                
                switch (a) 
                {
                    case 1:
                        Console.WriteLine("один");
                        break; // return
                    case 1+ONE:
                        Console.WriteLine("два");
                        break;
                    case 3: 
                        Console.WriteLine("три");
                        break;
                    case int k when k > 3 && k <= 20:
                        Console.WriteLine("Много");
                        break;
                    case > 40: // C# 9.0
                        Console.WriteLine("Очень много");
                        break;
                    default:
                        Console.WriteLine("Очень много");
                        break;
                }

                object o = 4;
                //o = "abc";
                switch(o)
                {

                    case int:  Console.WriteLine("int"); break;
                    case string: Console.WriteLine("string"); break;
                }

                Console.WriteLine(test(4));

                for (int i = 100, k = 0; i > 0 && k <100; i -= 3, k++)
                {
                    if (k > 10) break;
                    if (i == 85) continue;
                    Console.WriteLine($"{i} {k}");
                }

                string[] names =  { "Сергей", "Юлия", "Татьяна"};
                //for (int i = 0; i < names.Length; i++)
                //    Console.WriteLine(names[i]);
                //foreach(string name in names)
                //    Console.WriteLine(name);

                IEnumerator en = names.GetEnumerator();
                while (en.MoveNext())
                    Console.WriteLine(en.Current);


            }
            {
                //  1 2 3 4 ... 10
                //  2 4 6 8 ... 20
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        if (j == 5) goto label;
                        Console.Write("{0,4}", i * j);
                    }
                    Console.WriteLine();
                }
            label:
                Console.WriteLine("\ncontinue execution");

            
            }
            {
                foreach (int n in GetNumbers3())
                    Console.WriteLine(n);
            }
            

        }
    }
}
