using System;
using System.Reflection;
using static System.Math;


namespace OOP
{
    public static class MyMath {

        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            //Console.WriteLine(Person.Counter);


            Person.ShowTotal();

            Person p0 = new Person { Name = "Сергей", Age = 44, EMail = "sshuykov@specialist.ru" };

            //Person p1 = new Person{ Name = "Сергей", Age=44};
            //p1.Name = "Сергей";
            //p1.Age = 44;
            //Person p1 = new Person("Сергей", 44);
            Person p1 = new Person();

            Person p2 = new Person("Костя", 15);
            //p2.Name = "Костя";
            //p2.Age = 15;
            //p2.Age = -5;
            //p2.age = -5;

            //p2.Age = 5; // set

            //p2.setAge(5);
            //p2.Name = "Abc";
            Person p3 = new Person("Саша");

            p1.Show(); // this == p1
            p2.Show(); // this == p2
            p3.Show();

            Console.WriteLine(p1.NameUpper);
            //p1.NameUpper = "abc";

            //Console.WriteLine(Person.Counter);
            Person.ShowTotal();

            double x = 1;
            // y = sin(log(x*PI))
            double y = Sin(Log(PI * x));
            double area = MyMath.CircleArea(10d);
            Console.WriteLine(area);


            var stuff = new { Name = "Sergey", EMail = "sshuykov@specialist.ru", Phone = "123-45-67" };
            Console.WriteLine("{0}: {1} - {2}", stuff.Name, stuff.EMail, stuff.Phone);
            Console.WriteLine(stuff.ToString());

            Console.WriteLine(p0); // p0.ToString();

            Person p11 = new Person { Name = "Сергей", Age = 44, EMail = "sshuykov@specialist.ru" };
            Person p12 = new Person { Name = "Сергей", Age = 44, EMail = "sshuykov@specialist.ru" };

            Console.WriteLine(p11.Equals(p12));
            Console.WriteLine(object.Equals(p11, p12));
            Console.WriteLine(object.ReferenceEquals(p11, p12));
            Console.WriteLine(p11.GetHashCode());
            Console.WriteLine(p12.GetHashCode());

            Type pt = p11.GetType();
            Console.WriteLine(pt.Name);

            p1.Age = 18;
            object o1 = p1; // ref type conv
            p1.Age++; // 19;

            Console.WriteLine(o1);


            o1 = "abc";

            int num = 5;
            o1 = num; // boxing
            num++; // 6

            int count = (int)o1; // unboxing
            Console.WriteLine(count);

            Type[] myTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in myTypes)
            {
                Console.WriteLine(type.FullName);
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo props in properties)
                    // props.SetValue(p1, value) // p1.{props.Name} = value
                    Console.WriteLine($"\t{props.PropertyType.Name} {props.Name}");
            }

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            

            string s = "123";
            int k = Convert.ToInt32(s);
            Console.WriteLine(Environment.CurrentDirectory);
            GC.AddMemoryPressure(100000000);
            // call unsafe code required 100000000 byte
            GC.RemoveMemoryPressure(100000000);

            
            WeakReference<Person> px = new WeakReference<Person>(new Person("cache", 20));
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, true);
            GC.WaitForPendingFinalizers();

            Person px0;
            if (px.TryGetTarget(out px0))
            {
                Console.WriteLine(px0);

            }

            //throw new Exception("My error");

            
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject);
        }
    }
}
