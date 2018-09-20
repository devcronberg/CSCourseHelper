using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCronberg.CSCourseHelper.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            string t = "***";
            
            //int u = 1;
            Console.WriteLine(t.ToStringEx());
        }
    }

    class Person {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
