using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number.");
            int value = Convert.ToInt32(Console.ReadLine());
            OneMath outcome1 = new OneMath(value);
            Console.WriteLine(outcome1.a);


            Console.WriteLine("Please enter a number.");
            TwoMath outcome2 = new TwoMath(value);
            Console.WriteLine(outcome2.b);


            Console.WriteLine("Please enter a number.");
            ThreeMath outcome3 = new ThreeMath(value);
            Console.WriteLine(outcome3.c);


            Console.ReadLine();
        }
    }
}