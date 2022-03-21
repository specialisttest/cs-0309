using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicsScene
{
    public class Circle:  Shape, IScaleable
    {
        public int X { get; set; }
        public int Y { get; set; }


        private int r;
        public int R {
            get => r;
            set 
            {
                if (value > 0)
                    r = value;
                else
                    throw new ArgumentOutOfRangeException("r > 0");
            
            }
        
        }

        public override double Area => Math.PI * R * R;
            
        

        protected Circle(int x, int y, int r, string color = DEFAULT_COLOR)
            : base(color)
        {
            X = x;
            Y = y;
            R = r;
        }

        // фабричный метод
        public static Circle Create(int x, int y, int r, string color = DEFAULT_COLOR)
        {
            Circle c = new Circle(x, y, r, color);
            Shape.scene.Add(c); // hook
            return c;
        }


        public override void Draw() 
        {
            Console.WriteLine($"Circle ({X}, {Y}). R: {R}. {Color}");
        }


        //void IScaleable.Scale(double factor) // explicit implementation
        
        public void Scale(double factor) // implicit implementation
        {
            R = (int)Math.Round(R * factor);
        }

        // override
        //void IScaleable.Log()
        public void Log()
        {
            Console.WriteLine("Circle.Test()");
        }

    }
}
