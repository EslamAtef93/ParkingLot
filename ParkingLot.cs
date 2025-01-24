using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot
    {
        public List<ParkingSpace> ParkingSpaces { get; private set; }
        public List<Ticket> Tickets { get; }
        public ParkingLot(List<ParkingSpace> parkingSpaces) 
        {
            ParkingSpaces = parkingSpaces;
            Tickets = new List<Ticket>();
        }

        public Ticket ParkingVehicle(Vehicle vehicle)
        {
            var unParkedSpace = ParkingSpaces.FirstOrDefault(x => x.ParkedVehicle == null && x.SpaceSize == vehicle.Size);

            if (unParkedSpace == null)
                throw new InvalidOperationException("There is no parking space suitable for this car");

            unParkedSpace.Park(vehicle);

            var ticket = new Ticket(DateTime.Now, unParkedSpace);
            Tickets.Add(ticket);

            return ticket;
        }

        public double RemoveVehicle(int ticketId)
        {
            var ticket = Tickets.FirstOrDefault(x => x.Id == ticketId && x.PaidAmount == 0);

            if (ticket == null)
                throw new InvalidOperationException("This ticket is not found or paid before");

            ticket.BookedSpace.UnPark();           
            ticket.Pay();

            return ticket.PaidAmount;
        }
    }
}
