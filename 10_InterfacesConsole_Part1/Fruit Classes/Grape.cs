using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1.Fruit_Classes
{
    public class Grape : IFruit
    {
        public string Name { get; set; }
        public bool Peeled { get; set; }

        public string Peel()
        {
            return "Who peels grapes";
        }

    }
}
