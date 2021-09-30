
using _07_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_Methods
{
    [TestClass]
    public class PersonMethodsTest
    {
        [TestClass]
        public class MethodExamples
        {
            [TestMethod]
            public void MethodExecution()
            {
                SayHello("Severa");
                int methodReturn = AddTwoNumbers(1, 2);
                Console.WriteLine(methodReturn);

                AddTwoNumbers(3.05, 2.56);
                AddTwoNumbers(3, 2.55); //double value = int + double
                int value = (int)AddTwoNumbers(3.66, 1); // double value = double + int

                //DateTime birthday = new DateTime(1892,11,24);
                int age = CalculateAge(new DateTime(1892, 11, 24));
                Console.WriteLine($"My age is: {age}");
                //int numOne = 1000;
                //int numTwo = 3000;
                //int sum = numOne + numTwo;
                //Console.WriteLine(sum);

                //int numThree = 5000;
                //int numFour = 10000;
                //int sumTwo = numThree+ numFour;
                //Console.WriteLine(sumTwo);

                //int methodSum = AddTwoNumbers(5000, 10000);
                //Console.WriteLine(methodSum);

                //int methodSum2 = AddTwoNumbers(1000, 3000);
                //Console.WriteLine(methodSum2);


            }

            //1) Access Modifier 
            //2) Return Type
            //3) Method Signature
            //Name
            //Parameters
            //4) Body - the actual code
            [TestMethod]
            public void SayHello(string name)
            {
                Console.WriteLine($"Hello World! And Hello {name}!");
            }

            [TestMethod]
            public int AddTwoNumbers(int numOne, int numTwo)
            {
                int sum = numOne + numTwo;
                return sum;
            }

            [TestMethod]
            public double AddTwoNumbers(double numOne, double numTwo)
            {
                double sum = numOne + numTwo;
                return sum;
            }

            [TestMethod]
            public int CalculateAge(DateTime birthday)
            {
                TimeSpan ageSpan = DateTime.Now - birthday;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                //double floorValue = Math.Floor(totalAgeInYears);
                int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return years;
            }
        }
    }
}
