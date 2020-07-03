using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class Promotions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Details { get; set; }
        public string Passenger_Id { get; set; }
        public Passenger Passenger { get; set; }
    }
}
