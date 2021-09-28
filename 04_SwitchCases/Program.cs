using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evalutaed.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!!");
                    break;
            }

            //Challenge
            // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let them know.

            Console.WriteLine("How are you feeling today, on a range of 1 to 5?");
           string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                case "0":
                    Console.WriteLine("Sorry to hear that");
                    break;
                case "2":
                case "2.5":
                    Console.WriteLine("Hope you get better");
                    break;
                case "3":
                    Console.WriteLine("Hang in there");
                    break;
                case "4":
                    Console.WriteLine("Not bad, not bad");
                    break;
                case "5":
                    Console.WriteLine("Good to hear!");
                    break;
                default:
                    Console.WriteLine("It looks like you have entered a value beyond one through through five.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
