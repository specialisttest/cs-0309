using System;

namespace mod2
{
    enum Figures { Romb, Rect, Triangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public int color;
        public Figures type;
    }
    class Program
    {
        static void Main()
        {
            Fdata fd = new Fdata { x0 = 8, y0 = 3,
                color = 12212, type = Figures.Romb };

            Console.WriteLine(fd.x0 + " " + fd.y0);
            Console.WriteLine(fd.type);
            Console.WriteLine(fd.color);
        }
    }
}
