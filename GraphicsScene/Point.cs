using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicsScene
{
    public class Point: Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, string color = DEFAULT_COLOR)
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

        public override string ToString() => $"Point ({X}, {Y}). {Color}";
        

        public override double Area => 0d;

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator *(int k, Point p)=> new Point(p.X * k, p.Y * k);
        
        public static Point operator *(Point p, int k)=>k * p;
        

        public static Point operator ++(Point p)=> new Point(p.X + 1, p.Y + 1);

        public static bool operator true(Point p) {
            return p.X == 0 && p.Y ==0;
        }

        public static bool operator false(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }

        public static bool operator !(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Color);
        }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;
            if (object.ReferenceEquals(p, null)) return false;
            return X == p.X && Y == p.Y && Color == p.Color;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return object.Equals(p1, p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2); 
        }
    }
}
