using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class Tickets
    {
        public int Id { get; set; }
        public DateTime BookingDate{ get; set; }
        public string Passenger_Id { get; set; }
        public int Schedule_Id { get; set; }
        public Schedule Schedule { get; set; }
        public Passenger Passenger { get; set; }

    }
}
