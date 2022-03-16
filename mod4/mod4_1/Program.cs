using System;

namespace mod4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;

            foreach (var s in args)
            {
                int num;
                //num = int.Parse(s);
                if (int.TryParse(s, out num))
                    sum += num;

                Console.WriteLine(s);
            }
            Console.WriteLine("sum= " + sum);
        }
    }
}
