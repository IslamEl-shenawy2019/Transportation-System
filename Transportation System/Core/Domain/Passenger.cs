using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
    }
}
