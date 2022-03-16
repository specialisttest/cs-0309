using System;
using System.Text;

namespace mod4_2
{
    class Program
    {
        public static string IntToBinary(int num)
        {
            // 00000000...0101 == 5
            // num >> 1
            // num & 1 == num % 2 
            // 00000000...0101
            // 000000000000001
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < sizeof(int) * 8; i++) {
                sb.Insert(0,(num & 1) == 0 ? '0' : '1');
                if (i == 7 || i == 15 || i == 23)
                    sb.Insert(0, ' ');
                num = num >> 1;
            }
            return sb.ToString();

        }

        public static string IntToBinary2(int num)
        {
            char[] bits = new char[sizeof(int) * 8+3];
            int j = bits.Length - 1;

            for (int i = 0; i < sizeof(int) * 8; i++)
            {
                bits[j--] = (num & 1) == 0 ? '0' : '1';
                if (i == 7 || i == 15 || i == 23)
                    bits[j--] = ' ';
                num = num >> 1;
            }
            return new string(bits);
        }

        public static string IntToBinary3(int num)
        {
            Span<char> bits = stackalloc char[sizeof(int) * 8 + 3];
            int j = bits.Length - 1;

            for (int i = 0; i < sizeof(int) * 8; i++)
            {
                bits[j--] = (num & 1) == 0 ? '0' : '1';
                if (i == 7 || i == 15 || i == 23)
                    bits[j--] = ' ';
                num = num >> 1;
            }
            return new string(bits);
        }


        static void Main(string[] args)
        {
            Console.WriteLine( IntToBinary(int.MaxValue));
            Console.WriteLine(IntToBinary2(int.MaxValue));
            Console.WriteLine(IntToBinary3(int.MaxValue));
        }
    }
}
