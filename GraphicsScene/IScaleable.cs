using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicsScene
{
    public interface IScaleable
    {
        //public abstract 
        void Scale(double factor);

        
        // IScaleable s  = ...; s.Log();
        public void Log() 
        {
            Console.WriteLine("Default IScaleable.Log()");
        }


        public virtual void Log2()
        {
            Console.WriteLine("Default IScaleable.Log2()");
        }

    }

    public interface IScaleable2 : IScaleable
    {
        public double Factor { get; set; } // not an automatic property
        
        public new void Log2()
        {
            Console.WriteLine("Default IScaleable2.Log2()");
        }
    }

    class Test2 : IScaleable2
    {
        public double Factor { get; set; }

        public void Scale(double factor)
        {
            throw new NotImplementedException();
        }
    }
}
