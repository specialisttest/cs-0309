using System;

namespace Geometry
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            //Ваш код!
            Circle circ = new Circle(new Fdata() { x0 = -7, y0 = 8, a = 10});
            circ.Move(1, 1);
            circ.PrintInfo();
            Console.WriteLine(circ.Area());


            object[] data = {rect, rt, circ };

            Print(data);
        }

        public static void Print(object[] data)
        {
            foreach (var o in data) {
                Rect r = (Rect)o;
                r.PrintInfo();
            }

        }
    }
}
