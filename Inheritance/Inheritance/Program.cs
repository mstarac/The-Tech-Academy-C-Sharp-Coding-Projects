using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            string FullName = person.FirstName + person.LastName;
            person.SayName();

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();

            Console.WriteLine("Please enter the name of employee.");
            Console.ReadLine();


        }
    }
}
