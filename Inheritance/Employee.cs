using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        public new void SayName()

        {
            int ID = Convert.ToInt32(Console.ReadLine());
        }
    }
}