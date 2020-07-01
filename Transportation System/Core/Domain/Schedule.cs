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
        public TimeSpan ExpectedTime { get; set; }
    }
}
