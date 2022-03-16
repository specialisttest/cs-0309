namespace System
{
    class Program
    {
        public static long ffactorial(int n)
        {
            long res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }
        public static long rfactorial(int n)
        {
            return n<=1 ? 1 : n*rfactorial(n-1);
        }
        static void Main()
        {
            Console.WriteLine(ffactorial(5));
            Console.WriteLine(rfactorial(5));
        }
    }
}
