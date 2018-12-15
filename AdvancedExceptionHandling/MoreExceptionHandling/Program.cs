using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;
            try
            {
                while (!validAnswer && age <= 0)
                {

                    Console.WriteLine("Please enter your age.");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);

                    if (!validAnswer) Console.WriteLine("Please enter whole numbers only.");
                    {
                        if (age < 0)
                            throw new InvalidOperationException();
                    }
                    Console.WriteLine("You have entered:" + age + "years old.");
                    Console.ReadLine();
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Error, you are not following directions.");
                Console.ReadLine();

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Please enter your age in whole digits.");
                Console.ReadLine();
            }
        

            }
        }
    }

