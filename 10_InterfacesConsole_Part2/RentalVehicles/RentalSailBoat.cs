using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //Sailboats do not have engines
    public class RentalSailBoat: RentalVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Sailboats don't have an engine");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Sailboats don't have an engine");

        }

    }
}
