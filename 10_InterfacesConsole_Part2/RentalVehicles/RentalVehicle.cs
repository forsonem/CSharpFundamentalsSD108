using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //Building a rental vehicle application
    //Rental Vehicle will serve as our base class
    public class RentalVehicle
    {
        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public int NumberOfPassengers { get; set; }


        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting");
            Console.WriteLine("Turn key to on");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}
