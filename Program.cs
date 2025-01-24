// See https://aka.ms/new-console-template for more information
using ParkingLot;

Console.WriteLine("Hello, World!");

var spaces = new List<ParkingSpace>
{
    new ParkingSpace("PC-1", VehicleSize.Compact),
    new ParkingSpace("PC-2", VehicleSize.Regular),
    new ParkingSpace("PC-3", VehicleSize.Large),
};

var car = new Car("ACV1222362");
var truck = new Truck("XBM34449087");
var motorcycle = new Motorcycle("OLK36890543");

var parkingLot = new ParkingLot.ParkingLot(spaces);

var carTicket = parkingLot.ParkingVehicle(car);
Console.WriteLine($"Car parked with ticket id: {carTicket.Id}");

var truckTicket = parkingLot.ParkingVehicle(truck);
Console.WriteLine($"Truck parked with ticket id: {truckTicket.Id}");

var motorcycleTicket = parkingLot.ParkingVehicle(motorcycle);
Console.WriteLine($"Motorcycle parked with ticket id: {motorcycleTicket.Id}");

Thread.Sleep(2000);

var carFees = parkingLot.RemoveVehicle(carTicket.Id);
Console.WriteLine($"Car removed with parking fees: {carFees}");