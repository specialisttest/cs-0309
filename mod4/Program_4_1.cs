namespace System
{
    class Program
    {
        static void Main(string []args)
        {
            int num;
            int sum = 0;

            foreach (var s in args)
            {
                num = int.Parse(s);
                sum += num;
                Console.WriteLine(s);
            }
            Console.WriteLine("sum="+sum);
        }
    }
}
