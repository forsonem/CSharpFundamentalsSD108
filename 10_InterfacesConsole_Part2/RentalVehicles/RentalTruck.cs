using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //A rental truck is a type of rentalVehicle so this works. Rental Vehicle can be inherited.
    public enum TruckType { ShortBed, LongBed}
    public class RentalTruck : RentalVehicle
    {
        public TruckType TruckStyle { get; set; }
    }
}
