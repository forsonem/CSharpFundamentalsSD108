using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Inheritance_ClassLibrary
{
    public class Cat : Animal
    {

        public double ClawLength { get; set; }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly!");
        }

        public virtual void MakeSounds()
        {
            
            Console.WriteLine("meow");
        }
    }
    public class Lion : Cat
    {
        public override void MakeSounds()
        {
            
            Console.WriteLine("Roar");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey!");
            base.Move();
        }
    }
}
