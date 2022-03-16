using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle
    {
        Fdata fd;

        public double a
        {
            get { return fd.a; }
            set { fd.a = fd.b = value; }
        }
        public double b
        {
            get { return fd.b; }
            set { fd.b = fd.a = value; }
        }
        public Circle(Fdata fd)
        {
            this.fd = fd;
            this.fd.type = Figures.Circle;
        }

        public double Area()
        {
            return Math.PI * a * a / 4;
        }
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" d=" + a);
        }
    }
}
