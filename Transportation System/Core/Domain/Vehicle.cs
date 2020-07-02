using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public enum VehicleType
    {
        TokTok,Taxi
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleName { get; set; }
        public int NumOfSeats { get; set; }
    }
}
