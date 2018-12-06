using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int two = Convert.ToInt32(Console.ReadLine());

            NumberClass result = new NumberClass();
            result.NumberModifier(one, two);
            result.NumberModifier(5, 4);

            Console.ReadLine();
        }
    }
}
