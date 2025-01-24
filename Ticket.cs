using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Ticket
    {
        public int Id { get; private set; }
        public DateTime EntryTime { get; private set; }
        public ParkingSpace BookedSpace { get; private set; }
        public double PaidAmount { get; private set; }

        public Ticket(DateTime entryTime, ParkingSpace parkingSpace) 
        {
            Id = new Random().Next();
            EntryTime = entryTime;
            BookedSpace = parkingSpace;
            PaidAmount = 0;
        }
        
        public double CalculateFees()
        {
            double hourlyRate = 2;
            var parkingHours = (DateTime.Now - EntryTime).TotalHours;
            var roundedHoures = parkingHours < 1 ? 1 : Math.Ceiling(parkingHours);

            return roundedHoures * hourlyRate;
        }

        public void Pay()
        {
            PaidAmount = CalculateFees();
            Console.WriteLine(PaidAmount);
        }
    }
}
