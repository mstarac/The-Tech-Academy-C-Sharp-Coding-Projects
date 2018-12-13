using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill154
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here is some text.";
            File.WriteAllText(@"C:\Users\Student\Desktop\FileIO.txt", text);
            Console.WriteLine("Here is some text.");
            Console.ReadLine();

        }
    }
}
