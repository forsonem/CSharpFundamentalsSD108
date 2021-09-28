using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09252021_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze Part 1
            string superCopy = "Supercalifragilisticexpialidocious";
            string superLongWord = superCopy.ToLower();
            foreach (char letter in superLongWord)
            {
                Console.WriteLine(letter);
            }
            //Bronze Part 2
            foreach(char letter in superLongWord)
            {
                string writeLine = (letter == 'i') ? "i" : "Not an i";
                Console.WriteLine(writeLine);
            }
            //Silver
            Console.WriteLine(superLongWord.Length);
            //Gold
            foreach (char letter in superLongWord)
            {
                string writeLine = (letter == 'i' || letter == 'l') ? letter.ToString() : "Not an i";
                Console.WriteLine(writeLine);
            }

            Console.ReadKey();
        }
    }
}
