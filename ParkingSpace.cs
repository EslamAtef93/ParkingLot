using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingSpace
    {
        public string SerialNumber { get; private set; }
        public VehicleSize SpaceSize { get; private set; }
        public Vehicle? ParkedVehicle { get; private set; }
        public ParkingSpace(string serialNumber, VehicleSize spaceSize)
        {
            SerialNumber = serialNumber;
            SpaceSize = spaceSize;
        }

        public void Park(Vehicle vehicle)
        {
            if (ParkedVehicle != null || vehicle.Size != SpaceSize)
                throw new InvalidOperationException("This parking space not suitable for this car");

            ParkedVehicle = vehicle;
        }

        public void UnPark()
        {
            ParkedVehicle = null;
        }
    }
}
