﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I do not want to quit.");
            Console.ReadLine();
        }
    }
}
