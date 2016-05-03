using CsvHelper;
using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1.Serialization.Csv
{
    public class CsvSerializer : ITimetableSerializer
    {
        public void Serialize(Timetable timetable, Stream file)
        {
            using (var stream = new StreamWriter(file))
            {
                var writer = new CsvWriter(stream);
                writer.WriteHeader<TimetableRecord>();
                foreach (var record in timetable.Buses)
                    writer.WriteRecord(record.ToTimetableRecord());
                foreach (var record in timetable.Trains)
                    writer.WriteRecord(record.ToTimetableRecord());
            }
        }
    }
}
