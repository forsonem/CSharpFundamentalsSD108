using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16)
            {
                Console.WriteLine("Student spent less than 16 hours studying.");
                Console.WriteLine("Another Line.");
            }


            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Woo Hoo! You are productive!");
            }
            else
            {
                Console.WriteLine("Get to work now!");
            }

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if(age > 17)
            {
                Console.WriteLine("Congrats on being an adult!");
            }
            else
            {
                if(age < 6 && age > 0)
                {
                    Console.WriteLine("You are a kiddo!");
                }
                else if( age < 0)
                {
                    Console.WriteLine("You are a baby!");
                }
                else
                {
                    Console.WriteLine("You are not even born!");
                }
            }


            Console.ReadKey();
        }
    }
}
