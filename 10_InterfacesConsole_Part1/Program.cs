using _10_InterfacesConsole_Part1.Fruit_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an IFruit Collection

            List<IFruit> _fruits = new List<IFruit>();

            Orange orange = new Orange() { Name = "Orange" };
            Bannana bannana = new Bannana() { Name = "Bannana" };
            Grape grape = new Grape() { Name = "Grape" };

            _fruits.Add(orange);
            _fruits.Add(bannana);
            _fruits.Add(grape);

            foreach(IFruit fruit in _fruits)
            {
                if(fruit is Orange o)
                {
                    Console.WriteLine("Is orange peeled?");
                    Console.WriteLine(o.Peel());
                    Console.WriteLine("--------------------------");
                }
                else if(fruit is Bannana b)
                {
                    Console.WriteLine("Is Bannana Peeled?");
                    Console.WriteLine(b.Peel());
                    Console.WriteLine("--------------------------");
                }
                else if (fruit is Grape g)
                {
                    Console.WriteLine("Is Grape peeled?");
                    Console.WriteLine(g.Peel());
                    Console.WriteLine("--------------------------");
                }
            }
            Console.ReadKey();



        }
    }
}
