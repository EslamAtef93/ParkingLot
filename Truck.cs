﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Truck : Vehicle
    {
        public Truck(string licenceNumber) : base(licenceNumber, VehicleSize.Large)
        {

        }
    }
}
