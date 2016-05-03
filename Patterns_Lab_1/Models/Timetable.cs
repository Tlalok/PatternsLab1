using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1.Models
{
    public class Timetable
    {
        public List<BusTimetable> Buses { get; set; }
        public List<TrainTimetable> Trains { get; set; }
    }
}
