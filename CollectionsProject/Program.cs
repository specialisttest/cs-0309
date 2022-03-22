using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class Test
    {
        public string Data { get; private set; }

        public Test(string Data) {
            this.Data = Data;
        }

        public override string ToString()
        {
            return Data+this.GetHashCode();
        }
        
        public override int GetHashCode()
        {
            return this.Data.GetHashCode();
        }
        
        
        public override bool Equals(object obj)
        {
            if (obj is Test t)
                return this.Data == t.Data;
            return base.Equals(obj);
        }
    }

    class ReverseIntOrder : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }

    class Program
    {
        static bool TestString(string s) {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (c == '(' || c == '[')
                    st.Push(c);
                if ( c == ')' && (st.Count == 0 || st.Pop() != '('))
                    return false;
                if (c == ']' && (st.Count == 0 || st.Pop() != '['))
                    return false;
            }
            return st.Count == 0;
        }


        static void Main(string[] args)
        {
            string s = " ( [ a b c  ] ) * [ (  x ) ] (( z )) [[ ]]";
            Console.WriteLine(TestString(s));

            IDictionary<string, int> persons =
                new Dictionary<string, int>();

            persons.Add("Sergey", 40);
            persons.Add("Kosty", 12);
            persons.Add("Alex", 10);
            persons["Alex"] = 11;

            string name = "Kosty";
            if (persons.ContainsKey(name))
            {
                int age = persons[name];
                Console.WriteLine("{0} : {1}", name, age);
            }

            ISet<Test> set = new HashSet<Test>();
            set.Add(new Test("first"));
            set.Add(new Test("second"));
            set.Add(new Test("first"));
            

            Console.WriteLine(set.Count);
            foreach(var t in set)
                Console.WriteLine(t);

            SortedList<int, string> table = new SortedList<int, string>(new ReverseIntOrder());
            table.Add(3, "Cat");
            table.Add(11, "Dog");
            table.Add(-1, "Snake");
            table.Add(0, "human");
            foreach (var p in table)
                Console.WriteLine(p);

        }
    }
}
