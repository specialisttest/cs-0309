using System;
using System.Collections.Generic;

namespace GraphicsScene
{
    public static class IntExt
    {
        public static int Cube(this int x)
        {
            return x * x * x;
        }

        public static int Power(this int x, int power)
        {
            int r = 1;
            for (int i = 1; i <= power; i++)
                r *= x;
            return r;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 6, "red"); // ctor: Object, Shape, Point
            p1.Draw(); // Point.Draw()
            

            Shape s1 = p1; // implicit ref conv
            s1.Draw(); // Point.Draw()

            
            if (s1 is Point)
            {
                Point p2 = (Point)s1; // explicit ref conv - operator cast
                p2.MoveBy(1, 2);
            }


            Point p4 = s1 as Point; // 1. only for ref types 2. return null if cannot conv
            //if (p4 != null)
            //    p4.MoveBy(2, 1);
            p4?.MoveBy(2, 1);

            //try
            //{
            Circle c1 = Circle.Create(10, 20, 30);
            
            s1 = c1;
            s1.Draw(); // Circle.Draw();

            // VMT - Virtual Methods Table
            /*
             *  Method      Class       Address
             * Draw         Shape       XXX
             * Draw         Point       YYY
             * Draw         Circle      ZZZ
             * 
             */

            if (s1 is Point p3){ // since C# 7.1
                //Point p3 = (Point)s1;
                p3.MoveBy(1, 1);
            }

            (s1 as Point)?.MoveBy(1, 1);

            Point p11 = new Point(10, 20);
            Point p12 = new Point(1, 2);
            Console.WriteLine(p11);
            Console.WriteLine(p12);

            Point p13 = p11 + p12; //Point.Add(p11, p12);

            Console.WriteLine(p13);

            p13 = 2 * p13 * 5;
            p13 *= 2;
            Console.WriteLine(p13);

            Point p14 = 1 * p13;
            Console.WriteLine(p13);
            Console.WriteLine(p14);

            if (p13)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine(p13 == p14);
            Console.WriteLine(p11[0]); // p.X
            Console.WriteLine(p11[1]); // p.Y
            Console.WriteLine(p11["x"]); // p.X
            Console.WriteLine(p11["y"]); // p.Y

            //double d = (double)p11;
            double d = p11;

            //new Circle(10, 20, 30) { R=-10};
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //Shape.ScaleScene(2);

            //Shape.DrawScene();

            int k = 5;
            int k3 = k.Cube(); //IntExt.Cube(k);
            Console.WriteLine(k3);
            Console.WriteLine(k.Power(4));
            


        }
    }
}
