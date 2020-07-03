using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class Passenger:User
    {
        public virtual List<Promotions> Promotions { get; set; }
        public virtual List<Tickets> Tickets { get; set; }
    }
}
