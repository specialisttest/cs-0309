using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionProject
{
    [Serializable]
    public class MyException: Exception
    {
        public int InvalidData { get; private set; }

        public MyException() { }
        public MyException(string message, int invalidData) : base(message)
        {
            this.InvalidData = invalidData;
        }
        public MyException(string message, int invalidData, Exception inner) : base(message, inner)
        {
            this.InvalidData = invalidData;
        }
    }
}
