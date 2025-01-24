using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string licenceNumber) : base(licenceNumber, VehicleSize.Compact)
        {
            
        }
    }
}
