using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //A rental car is a type of rentalVehicle so this works. Rental Vehicle can be inherited.
    public enum CarType { Hatchback, Sedan, Compact}
    public class RentalCar : RentalVehicle
    {
        public CarType CarStyle { get; set; }
    }
}
