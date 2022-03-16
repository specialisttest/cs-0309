using System;

namespace ValueTypes
{
    enum Colors : byte { Red = 1, Green = 100, Blue = 200 }

    // Value Type
    struct Money 
    {
        public decimal Summa;
        public string Currency;

        public override string ToString() 
        {
            return $"Money: {Summa}{Currency}";
        }
    }


    class Program
    {
        public static (double? x1, double? x2, bool HasRoots, bool SingleRoot)
                SqEq(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0d) return (null, null, false, false);
            if (d == 0d)
            {
                double x = (-b) / (2 * a);
                return (x, x, true, true);
            }
            // d > 0;
            double ds = Math.Sqrt(d);
            double x1 = (-b + ds) / (2 * a);
            double x2 = (-b - ds) / (2 * a);

            return (x1, x2, true, false);
        }

        static void Main(string[] args)
        {
            {
                Colors c1 = Colors.Green;
                Console.WriteLine(c1);
                Console.WriteLine(sizeof(Colors));
                int ordinal = (int)c1;
                Console.WriteLine(ordinal);
                Colors c2 = (Colors)200;
                Console.WriteLine(c2);
            }
            {
                Money m1 = new Money { Summa = 100m, Currency = "USD"};
                Money m2 = m1;
                m2.Currency = "RUB";

                Console.WriteLine($"{m1.Summa}{m1.Currency}"); // 100USD
                Console.WriteLine($"{m2.Summa}{m2.Currency}"); // 100RUB
                


                (decimal, string) savings = (200m, "EUR");
                Console.WriteLine($"{savings.Item1}{savings.Item2}");
                //(decimal, string) s2 = savings;
                var s2 = savings;
                s2.Item1++;
                Console.WriteLine(s2 == savings);

                (decimal Summa, string Currency) s3 = s2;
                Console.WriteLine($"{s3.Summa}{s3.Currency}");

                var s4 = (Summa:300m, Currency:"RUB");
                Console.WriteLine($"{s4.Summa}{s4.Currency}");

                var r = SqEq(2, -7, 6);
                if (r.HasRoots)
                    Console.WriteLine($"x1 = {r.x1} x2 = {r.x2}");

                Console.WriteLine(m1);


            }
            {
                int x = 5; // 0101
                int y = x >> 1; //  0010
                int z = x << 1; //  1010
                int q = x & 1; // BIT AND
                int v = x | 1; // BIT OR

            }
        }
    }
}
