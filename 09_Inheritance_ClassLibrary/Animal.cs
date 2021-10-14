using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Inheritance_ClassLibrary
{
    public enum DietType { Herbivore = 1, Omnivore, Carnivore, Insectivore}
    public class Animal
    {
        //private List<Animal> _animalList = new List<Animal>();

        //private bool isHungry;
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public bool IsEndangered { get; set; }

        public DietType TypeOfDiet { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves");
        }

    }
}
