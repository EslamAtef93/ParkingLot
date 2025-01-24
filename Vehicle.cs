using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public abstract class Vehicle
    {
        public string LicenceNumber { get; private set; }
        public VehicleSize Size { get; private set; }

        protected Vehicle(string licenceNumber, VehicleSize size) 
        {
            LicenceNumber = licenceNumber;
            Size = size;
        }
    }
}
