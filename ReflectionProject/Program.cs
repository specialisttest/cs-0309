using System;
using System.Reflection;



namespace ReflectionProject
{
    
    [AttributeUsage(AttributeTargets.Class)]
    public class MySuperAttribute : System.Attribute
    {
        private string author;

        public MySuperAttribute(string author="Unknown")
        {
            this.author = author;
        }

        public override string ToString() => $"MySuper : {author}";


    }
    
    [MySuper("Sergey")]
    public class Person
    { 
        public string Name { get; set; }
        public int Age { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Name} - {Age}");  
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(Person);
            PropertyInfo[] ps = type.GetProperties();
            foreach (var pi in ps)
                Console.WriteLine(pi.Name);

            MethodInfo[] ms = type.GetMethods();
            foreach (var mi in ms)
                Console.WriteLine(mi.Name);

            //type.GetCustomAttributes()

            Attribute? attr = type.GetCustomAttribute(typeof(MySuperAttribute));
            if (attr != null)
                Console.WriteLine("Type {0} has attribute {1}",
                        type.FullName, ((MySuperAttribute)attr).ToString());



        }
    }
}
