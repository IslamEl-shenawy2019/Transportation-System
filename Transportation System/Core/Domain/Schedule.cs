using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Startpoint { get; set; }
        public string EndPoint { get; set; }
        public float InitialPrice { get; set; }
        float finalPrice;
        public float FinalPrice {
            get { return finalPrice; }
            private set {
                finalPrice = InitialPrice + Vehicle.Price;
            } }
        public string Route { get; set; }
        public TimeSpan ExpectedTime { get; set; }
        public virtual List<Tickets> Tickets { get; set; }
        public int Vehicle_Id { get; set; }
        public string Driver_Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public Driver Driver { get; set; }

    }
}
