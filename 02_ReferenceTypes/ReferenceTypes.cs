using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void ReferenceTypeVariables()
        {
            //Strings
            string thisIsDeclaration;
            thisIsDeclaration = "This is initialized.";

            string declarationAndInitialization = "This is both declaring and initializing a string";

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //Console.WriteLine(firstName);

            //String Operation
            //Concatenation
            string concatenatedFullName;
            string firstName = "Severa";
            string lastName = "Cox";
            concatenatedFullName = firstName + " " + lastName; //Severa Cox
            Console.WriteLine(concatenatedFullName);

            //Interpolation
            string interpolatedFullName = $"{firstName} {lastName}"; //Severa Cox
            Console.WriteLine(interpolatedFullName);

            //Collections
            //List
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add(firstName);
            listOfStrings.Add(lastName);

            //Array
            string[] arrayOfStrings = new string[8];
            string[] anotherArrayOfStrings = { firstName, lastName, "blahblah" };

            //Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue(lastName);
            firstInFirstOut.Enqueue("this is my string added to my queue");

            //Dictionary
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(7, "seven");
            Console.WriteLine(keyValuePairs[7]);

            //Other Types Collections
            SortedList<string, int> sortedKeyValuePairs = new SortedList<string, int>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            //Classes
            Random randomExample = new Random();

            int randomNumber = randomExample.Next();
            Console.WriteLine(randomNumber);

        }
    }
}
