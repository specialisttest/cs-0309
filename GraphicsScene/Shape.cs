using System;
using System.Collections.Generic;
using System.Text;

/* I)
 * Shape
 *  Color
 *  virtual Draw
 *  
 * Point : Shape
 *  X,Y
 *  override Draw()
 *  MoveBy(dx,dy)
 *  
 * Circle: Shape
 *  X,Y,R
 *  override Draw()
 *  Scale(double factor)
 * II)
 * static List<Shape> scene = new List<Shape>();
 * scene.Add(...)
 * static DrawScene() - перебрать все элементы
 * коллекции scene и вызвать у каждого Draw
 *   
 * 
 * 
 */

namespace GraphicsScene
{
    public /*sealed*/ abstract class Shape
    {
        public const string DEFAULT_COLOR = "black";

        protected string name;
        
        protected static List<Shape> scene = new List<Shape>();
        
        public /*virtual*/ string Color { get; set;} // auto property

        public abstract double Area { get;  }

        public Shape(string Color = DEFAULT_COLOR)
        {
            Console.WriteLine("ctor Shape()");
            this.Color = Color;
            //scene.Add(this); // bad (trap)
        }

        public abstract void Draw();
        //{
            // Console.WriteLine("Shape. {0}", this.Color);
        //}

        public void Test()
        {
            Console.WriteLine("Test");
        }

        public static void DrawScene()
        {
            foreach (Shape s in scene)
                s.Draw(); // polymorphism !!!
        }

        public static double SceneArea()
        {
            double summa = 0d;
            foreach (Shape s in scene)
                summa += s.Area;
            return summa;
        }
    }
}
