using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeList = new Employee<string>();
            Employee<int> employeeInt = new Employee<int>();
            employeeList.things = new List<string>() { "Sally", "Smith" };
            employeeInt.things = new List<int>();
            employeeInt.things.Add(10);
            employeeInt.things.Add(20);

            foreach (string item in employeeList.things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in employeeInt.things)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

        }
    }
}

