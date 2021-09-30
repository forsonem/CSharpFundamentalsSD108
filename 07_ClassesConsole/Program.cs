

using _07_ClassesNew;
using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository repo = new PersonRepository(); //Instance of the Person Repository class. I am creating a Person Repository Object.

            

            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            repo.AddPerson(person2);
            repo.AddPerson(person3);


            


            person1.FirstName = "Mason";
            person2.FirstName = "Anna";




             Person updatedPerson = repo.UpdatePerson(person1,person2);
            Console.WriteLine(updatedPerson.FirstName);

            Console.ReadKey();


            















          
            


        }
    }
}
