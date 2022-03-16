using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonCSharp
{
    // non thread-safe
    public class SingletonSimple
    {
        private SingletonSimple() { }

        private static SingletonSimple instance = null;

        public static SingletonSimple Instance {
            get {
                if (instance == null)
                    instance = new SingletonSimple();

                return instance;
            }
        }
    }
}
