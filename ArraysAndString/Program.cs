using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ArraysAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //int k = int.Parse(Console.ReadLine());
                //int[] nums = new int[4];
                int[] nums = new int[4] { 100, 200, 0, 0 };
                //int[] nums = new int[] { 100, 200, 0, 0 };
                //int[] nums = { 100, 200, 0, 0 };

                Console.WriteLine(nums.Length);
                Console.WriteLine(nums.Rank);

                //nums[0] = 100;
                //nums[1] = 200;

                for (int i = 0; i < nums.Length; i++)
                    Console.WriteLine(nums[i]);

                /*Console.WriteLine(nums[0]);
                Console.WriteLine(nums[1]);
                Console.WriteLine(nums[2]);
                Console.WriteLine(nums[3]);*/

                int[,] matrix = // new int[2, 3]
                {
                { 1, 2, 3},
                { 4, 5, 6}
            };

                Console.WriteLine(matrix.Length);
                //Console.WriteLine(matrix.LongLength);
                //Console.WriteLine(matrix.GetLongLength(0));
                Console.WriteLine(matrix.Rank);
                Console.WriteLine(matrix.GetLength(0));
                Console.WriteLine(matrix.GetLength(1));

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write("{0,3}", matrix[i, j]);
                    Console.WriteLine();
                }

                int[][] jagged =
                {
                new int[]{ 1, 2, 3},
                new int[]{ 4, 5}
            };

                Console.WriteLine(jagged.Length);
                Console.WriteLine(jagged.Rank);

                for (int i = 0; i < jagged.Length; i++)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                        Console.Write("{0,3}", jagged[i][j]);

                    Console.WriteLine();
                }

                Range rnd = 3..7;

                int[] d = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


                int[] d1 = d[2..^2];
                for (int i = 0; i < d1.Length; i++)
                    Console.Write("{0,3}", d1[i]);

                Console.WriteLine();

                Span<int> dat1 = stackalloc[] { 1, 2, 5, 8 };
                foreach (int k in dat1)
                    Console.WriteLine(k);


                // Сколько строк создано? 0!!
                string[] names = new string[3];

                // Console.WriteLine(names[0].Length); // Null Reference Exception
            }
            {
                char ch = '\u001F';
                Console.WriteLine("Size of char: {0}", sizeof(char));
            }
            {
                string hello = "Привет";
                string name = "Сергей";

                string r = hello + " " + name + "!";
                /*
                 * "Привет "
                 * "Привет Сергей"
                 * "Привет Сергей!"
                 * 
                 */

                Console.WriteLine(r);
                Console.WriteLine(r.Length);
                Console.WriteLine(r[0]);
                Console.WriteLine(r[^1]);
                Console.WriteLine ( String.Format("Привет, {0}!", name) );

                Console.WriteLine( r.Replace("Сергей", "Андрей"));
                Console.WriteLine( r );

            }
            {
                // 1 2 3 .. 100 
                // BAD
                //string r = string.Empty; // ""
                //for (int i = 1; i <= 100; i++)
                //    r += i.ToString() + " ";
                
                
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= 100; i++)
                    sb.Append(i).Append(' ');

                string r = sb.ToString();    
                Console.WriteLine(r);
            }
            /*{
                Console.Write("Введите число: ");
                string s = Console.ReadLine();
                // int k = int.Parse(s);
                int k;

                if (int.TryParse(s, out k))
                    Console.WriteLine($"Вы ввели число {k}");
                else
                    Console.WriteLine("Вы ввели не число");
            }*/
            {
                string s = "hedghog hedghog";
                Regex r = new Regex(@"he");
                foreach(Match m in r.Matches(s))
                    if (m.Success)
                        Console.WriteLine($"Found {m.Value} at {m.Index}");

            
            }
            {
                Console.Write("Введите телефон (123-45-67): ");
                string phone = Console.ReadLine();
                Regex rg = new Regex(@"\d{3}-\d{2}-\d{2}");
                if (rg.IsMatch(phone))
                    Console.WriteLine("Телефон: {0}", phone);
                else
                    Console.WriteLine("Вы ввели неверные телефон");

            }




        }
    }
}
