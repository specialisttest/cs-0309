using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // public       
    // internal (*) currenct assembly only
    public partial class Person
    {

        public const string DEFAULT_NAME = "Незнакомец";
        
        /*private static int counter = 0;
        public static int Counter
        {
            get { return counter; }
        }*/
        public static int Counter { get; private set; } = 0;

        /*private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }*/

        public static void ShowTotal()
        {
            Console.WriteLine("Total persons created: {0}", Counter);
        }

        // implicit one-time call by CLR when loading class from assembly
        static Person() {
            Console.WriteLine("static ctor Person");
        }

        public  readonly string NameUpper;

        public string Name { get; /*private*/ set; } = DEFAULT_NAME;

        private int age;

        public int Age
        {
            get { return age; }
            /*private*/ set 
            {
                if (value >= 0 && value <= 120)
                    this.age = value;
                else
                    throw new ArgumentOutOfRangeException("age out of [0..120]");

            }
        }

        public int BirthYear
        {
            get {
                return DateTime.Now.Year - this.Age;
            }
        }

        /*public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            if (age >= 0 && age <= 120)
                this.age = age;
            else
                throw new ArgumentOutOfRangeException("age out of [0..120]");
        }*/

        public Person() : this("Unknown")
        {
            
            Console.WriteLine("ctor Person()");
        }

        public Person(string Name, int Age = 18)
        {
            //int userName;
            
            Console.WriteLine("ctor Person(Name, Age)");
            this.Name = Name;
            this.NameUpper = Name.ToUpper();
            this.Age = Age; // set
            Counter++;
        }

        // private void
        partial void Verify();

        public void Show()
        {
            // verify e-mail
            Verify();
            Console.WriteLine("{0} - {1}", 
                Name, this.Age /* get */);
        }

        public override string ToString()
        {
            return $"{Name} : {Age} {EMail}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {
                Person p = (Person)obj;
                return Name == p.Name && Age == p.Age && EMail == p.EMail;
            }  
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name.GetHashCode(), Age,
                EMail.GetHashCode());
        }

          
         // обычно не используется
         ~Person() {
            Console.WriteLine($"~Person() {Name}");
        }
    }
}
