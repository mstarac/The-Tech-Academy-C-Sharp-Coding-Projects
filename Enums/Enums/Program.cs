using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DaysOfTheWeek

{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}       
namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            

            try
            {
                string dayEntered = Console.ReadLine();
                dayEntered = dayEntered.ToLower();
                string firstLetter = dayEntered.ToUpper().Substring(0, 1);
                dayEntered = firstLetter + dayEntered.Substring(1);


                Enum.Parse(typeof(DayOfWeek), dayEntered);
                Console.WriteLine(" Today is " + dayEntered);
                Console.ReadLine();

                
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error, please enter a valid day of the week");
            }
         }
      }
   }
