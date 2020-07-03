using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class Driver:User
    {
        public VehicleType TransportationType { get; set; }
        public virtual List<Schedule> Schedules { get; set; }
        public virtual List<DriverVehicle> DriverVehicle { get; set; }
    }
}
