using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public partial class Person
    {
        public string EMail { get; set; }

        partial void Verify()
        {
            Console.WriteLine("Verify e-mail...");
        }

    }
}
