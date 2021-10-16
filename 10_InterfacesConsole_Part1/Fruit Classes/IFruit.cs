using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1.Fruit_Classes
{
    public interface IFruit
    {
        string Name { get;} //Property with only a get
        bool Peeled { get; set; } //Property with a get and a set

        string Peel(); //Method with only a return type and no parameters or business logic
        

    }
}
