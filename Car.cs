﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car : Vehicle
    {
        public Car(string licenceNumber) : base(licenceNumber, VehicleSize.Regular)
        {
            
        }
    }
}
