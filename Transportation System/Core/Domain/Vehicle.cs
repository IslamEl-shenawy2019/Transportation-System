using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public enum VehicleType
    {
        TokTok,
        Bus,
        MicroBus,
        Taxi
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleName { get; set; }
        public VehicleType VehicleType { get; set; }
        public int NumOfSeats { get; set; }
        public virtual List<DriverVehicle> DriverVehicle { get; set; }
        public virtual List<Schedule> Schedules { get; set; }
        public float Price { get; set; }
    }
}
