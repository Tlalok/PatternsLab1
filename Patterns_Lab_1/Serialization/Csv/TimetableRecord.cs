using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.Serialization.Csv
{
    enum RecordType
    {
        Bus,
        Train
    };

    class TimetableRecord
    {
        public RecordType Type { get; set; }
        public string Number { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Destination { get; set; }
        public string DepartureStation { get; set; }
        public string DeparturePlatform { get; set; }
        public string ArrivalStation { get; set; }
        public string TicketType { get; set; }
        public int TicketCost { get; set; }
        public string BusBrand { get; set; }
        public TimeSpan TravelTime { get; set; }
    }
}
