using System;
using System.Collections;
using Specialist.DB;

using SCP = System.Collections.Specialized;

namespace Specialist.DB {
    class Database {
    }
}

namespace Program {
    class Inner{}
}

namespace Vars
{
    class Program
    {
        int yyy;


        static void Main(string[] args)
        {
            {
                int a = 10;

                //int b = (a = a+1);
                // a = a + 2;
                //a += 2;
                //a = a + 1
                //a += 1;
                // int b = a++; //suffix (postfix)
                //int b = ++a; // prefix
                
                // В С и в С++ - UB
                int b = a++ + ++a; // не надо так писать

                Console.WriteLine($"a = {a}\nb = {b}"); // a = 12 b = 22

            }
            
            {
                global::Program.Inner inner;
                global::Vars.Program p3;

                SCP.NameValueCollection nm;
                
                //Specialist.Database db;
                ArrayList lll;
                
                Database db;
                Program p2;

                
                #region numbers
    #if _DEBUG_
                int x = 0b0101;
                double d = 2.5d;  //3e7
                
                decimal dm = 2.5m;

                float  f = 2f;
                Console.WriteLine(x);
    #endif
    #endregion
                short a2 = 1;
                
                
                int u = 100, v;

                int a = 100;
                int b = a + 10;

                int r2 = (int) (100 / 2.5); // explicit conv
                
                int a3 = a2; // implicit conv
                
                // checked
                // unchecked * 
                
                unchecked {
                    short a4 = (short)a3;
                }
                

                var q = 10; // int q = 10;
                var r = "abc"; // string r = "abc"
                int @i = 7;
                Console.WriteLine(i);

                Console.WriteLine( a );

                #region strings
                string да = "YES!";
                string filepath = @"c:\cs-0309\HelloWorld";

                string add = $"2 + 2 равно {2 + 2}";
                
                // System.String
                string userName = "Сергей";
                int userAge = 44;
                // Привет, userName - userAge!
                string result = $"Привет, {{{userName}}} - {userAge}!";
                #endregion

                Program p = null;
                String s = null;

                int xx; // System.Int32 xx;
                long ll; // System.Int64 ll;

                
                Console.WriteLine( да );
                Console.WriteLine( filepath );
                Console.WriteLine( add );
                Console.WriteLine( result );
            }
        }
    }
}
