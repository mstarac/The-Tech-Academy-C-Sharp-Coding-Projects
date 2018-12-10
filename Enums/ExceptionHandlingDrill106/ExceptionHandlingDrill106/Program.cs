using System;
using System.Collections.Generic;


class Program
    {
        static void Main()
        {
        try
        {

            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            intList.Add(50);
            intList.Add(60);
            intList.Add(70);
            intList.Add(80);

            Console.WriteLine("Please enter a number to divide list numbers by. ");
            int numberEntered = Convert.ToInt32(Console.ReadLine());
            foreach (int i in intList)
            {
                Console.WriteLine(i / numberEntered);
            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter an integer.");
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero.");
        }
        finally
        {

            Console.ReadLine();
        }
    }
       
 }





//        }
//        finally
//        {

//            Console.WriteLine("Please enter a number to divide list numbers by.");
//            int numberEntered = Convert.ToInt32(Console.ReadLine());
//        }

