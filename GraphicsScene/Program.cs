using System;

namespace GraphicsScene
{
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



            //new Circle(10, 20, 30) { R=-10};
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            Shape.ScaleScene(2);

            Shape.DrawScene();
            
        }
    }
}
