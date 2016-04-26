using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Patterns_Lab_1.Models
{
    public class BusTimetable
    {
        public string Number { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Destination { get; set; }
        public string DepartureStation { get; set; }
        public string DeparturePlatform { get; set; }
        public string ArrivalStation { get; set; }
        public int TicketCost { get; set; }
        public string BusBrand { get; set; }

        [XmlIgnore]
        public TimeSpan TravelTime { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("TravelTime")]
        public String TravelTimeString
        {
            get { return TravelTime.ToString(); }
            set
            {
                TravelTime = string.IsNullOrEmpty(value) ?
                    TimeSpan.Zero : TimeSpan.Parse(value);
            }
        }
    }
}
