using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.Interfaces
{
    public interface IRental
    {
        int RentalID { get; set; }
        string CurrentRenter{ get; set; }
        decimal PricePerDay { get; set; }
    }
}
