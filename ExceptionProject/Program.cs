using System;

namespace ExceptionProject
{
    class Program
    {
        static void Test(string s1, string s2)
        {
            try
            {
                int n1 = int.Parse(s1);
                int n2 = int.Parse(s2);

                // n1 in [0..100]
                if (n1 < 0 || n1 > 100)
                    //throw new ArgumentOutOfRangeException("n1 out of [0..100]");
                    throw new MyException("n1 out of [0..100]", n1);

                int n = n1 / n2;

                Console.WriteLine(n);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyException e) when (e.InvalidData > 0)
            {
                Console.WriteLine($"{e.Message} Invalid Data: {e.InvalidData}");
                //throw; //throw e;
                throw new ArgumentOutOfRangeException("n1", e);
            }
            catch (MyException e) when (e.InvalidData <= 0)
            {
                Console.WriteLine($"{e.Message} Invalid Data (below zero): {e.InvalidData}");

            }
            /*catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            finally
            {
                Console.WriteLine("Finally");

            }


            Console.WriteLine("продолжение работы Test");
        }

        static void Main(string[] args)
        {
            try
            {
                Test("99", "3");

                checked
                //unchecked
                {
                    int max = int.MaxValue;
                    Console.WriteLine(max);
                    max++;
                    //max = unchecked(max + 1);
                    Console.WriteLine(max);

                }


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("продолжение работы Main");
        }
    }
}
