using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicsScene
{
    public class Point: Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, string color)
            : base(color)
            //: base()
        {
            Console.WriteLine("ctor Point()");
            X = x;
            Y = y;
            scene.Add(this); // bad (trap)
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public /*sealed*/ override void Draw()
        {
            Console.WriteLine($"Point ({X}, {Y}). {Color}");
            // base.Draw();
        }

        public override double Area => 0d;

    }
}
