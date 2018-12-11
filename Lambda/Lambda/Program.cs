using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employeeOne = new Employee() { firstName = "Nancy", lastName = "Ontiveros", ID = 101 };
            Employee employeeTwo = new Employee() { firstName = "Jennifer", lastName = "Coates", ID = 102 };
            Employee employeeThree = new Employee() { firstName = "Matt", lastName = "Taylor", ID = 103 };
            Employee employeeFour = new Employee() { firstName = "Cynthia", lastName = "Saulsbury", ID = 104 };
            Employee employeeFive = new Employee() { firstName = "Joe", lastName = "Smith", ID = 105 };
            Employee employeeSix = new Employee() { firstName = "Shoshanna", lastName = "Montgomery", ID = 106 };
            Employee employeeSeven = new Employee() { firstName = "Jeff", lastName = "Daniels", ID = 107 };
            Employee employeeEight = new Employee() { firstName = "Dwayne", lastName = "Peters", ID = 108 };
            Employee employeeNine = new Employee() { firstName = "Mary", lastName = "Johnson", ID = 109 };
            Employee employeeTen = new Employee() { firstName = "Joe", lastName = "Davison", ID = 110 };
            List<Employee> employees = new List<Employee> { employeeOne, employeeTwo, employeeThree, employeeFour, employeeFive, employeeSix, employeeSeven, employeeEight, employeeNine, employeeTen };


            Console.WriteLine(" Current Employees: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);

            }
            Console.WriteLine();

            List<Employee> firstNameJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    firstNameJoe.Add(employee);
                }
            }
            Console.WriteLine("Employees with the first name of Joe:");
            foreach (Employee employee in firstNameJoe)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
                Console.WriteLine();
                Console.ReadLine();

            }
                // Now create list using Lambda expression
            
                List<Employee> lambdaListJoe = employees.Where(x => x.firstName == "Joe").ToList();
                Console.WriteLine("Joe's lambda list:");
                    foreach (Employee employee in lambdaListJoe)
                {
                    Console.WriteLine(employee.firstName + " " + employee.lastName);
                }

                List<Employee> overFiveID = employees.Where(x => x.ID > 5).ToList();
                foreach (Employee employee in overFiveID)

                Console.WriteLine(lambdaListJoe.Count);
                Console.WriteLine(overFiveID.Count);
                Console.ReadLine();
                

            }
        }
    }


