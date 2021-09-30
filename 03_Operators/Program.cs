using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;

            //Addition
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            //Subtraction
            int difference = numTwo - numOne;
            Console.WriteLine(difference);

            //Multiplication
            int product = numOne * numTwo;
            Console.WriteLine(product);

            //Division
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //TimeSpan
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1997, 5, 6);
            TimeSpan timeSpan = today - someDay;
            Console.WriteLine(timeSpan);

            //Conversions
            //Casting
            //type name = (castType)value
            int five = 5;
            double doubleFive = (double)five;
            Console.WriteLine(doubleFive);

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);
            Console.WriteLine(a);

            //string myString = "This is a string.";
            //byte myByte = (byte)myString;

            decimal myMoney = 5.87m;
            int intMoney = (int)myMoney; //5

            //Conversion
            //type = Convert.ToType(value);

            int intFive = 5;
            decimal decimalFive = Convert.ToDecimal(intFive);

            decimal decimalTwo = 2.55m;
            int intTwo = Convert.ToInt32(decimalTwo); //3

            //Parsing
            //type name = type.Parse(string)
            string decimalString = "5.69878";
            decimal decimalValue = decimal.Parse(decimalString);


            //Comparison Operators
            Console.WriteLine("Enter your age.");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter in your name.");
            string userName = Console.ReadLine();

            bool equals = (age == 41);
            Console.WriteLine("User is 41: " + equals);

            bool notEquals = age != 41;
            Console.WriteLine($"User is not 41: {notEquals}");
            Console.WriteLine(notEquals);


            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Lists are equal: " + listsAreEqual);

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 99;

            bool orValue = equals || notEquals;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;


            bool andValue = equals && notEquals;
            tOrT = true && true;
            tOrF = true && false;
            fOrT = false && true;
            fOrF = false && false;

            //&& - both sides of the comparison have to be true in order to deliver a true bool
            int x = 13;
            bool test = x < 44 && x > 10;
            Console.WriteLine(test);

            //|| - ONLY one side of the comparison has to be true in order to deliver a true bool
            int y = 10;
            bool test2 = y > 20 || y < 15; // Is 10 > 20 or is 10 < 15? false OR true
            Console.WriteLine(test2);



            Console.ReadKey();
        }
    }
}
