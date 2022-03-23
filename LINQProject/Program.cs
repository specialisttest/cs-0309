using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }


    class Program
    {
        /*public static IList<Person> PersonsAdultFilter(IList<Person> persons)
        {
            IList<Person> result = new List<Person>();
            foreach (Person p in persons)
                if (p.Age >= 18)
                    result.Add(p);
            return result;
        }
        public IEnumerable<Person> PersonsAdultFilter(
            IEnumerable<Person> persons)
        {
            foreach (Person p in persons)
                if (p.Age >= 18)
                    yield return p;
        }*/


        static void Main(string[] args)
        {
            IList<Person> people = new List<Person>(){
                new Person() { Name = "Sergey", Age = 40},
                new Person() { Name = "Vasiliy", Age = 35},
                new Person() { Name = "Kosty", Age = 12},
                new Person() { Name = "Alex", Age = 10}
            };

            //var result = PersonsAdultFilter(people);
            var result =
                from p in people
                where p.Age >= 18
                orderby p.Name
                select new { Name = p.Name, Age = p.Age }; //.ToList();

            /*var result = people.Where(p => p.Age >= 18).
                        OrderBy(p => p.Name).
                        Select(p => p);*/

            //people[2].Age = 20;

            foreach (var person in result)
                Console.WriteLine("{0} {1}", person.Name, person.Age);

                //Person p1 = result.First();
                //Console.WriteLine("First adult: {0}", p1.Name);


        }
    }
}
