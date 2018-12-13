using System;



namespace DateTimeDrill
{
    class Program
    {
        
                
        public static void Main()
        { 

            DateTime now = DateTime.Now;
            Console.WriteLine("The date and time is currently" +" " + " " + now);
           
            Console.WriteLine("Please enter a number between 1 and 12.");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In {0} hours it will be {1}", x, now.AddHours(x));
            Console.ReadLine();
        }
    }
}
