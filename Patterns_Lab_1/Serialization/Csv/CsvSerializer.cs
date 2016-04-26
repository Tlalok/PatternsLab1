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
        private readonly string csvExtension = ".csv";

        public bool Applicable(string extension)
        {
            return extension.ToLower() == csvExtension;
        }

        public void Serialize(Timetable timetable, Stream file)
        {
            using (var stream = new StreamWriter(file))
            {
                var writer = new CsvWriter(stream);
                writer.WriteHeader<TimetableRecord>();
                foreach (var record in timetable.buses)
                    writer.WriteRecord(record.ToTimetableRecord());
                foreach (var record in timetable.trains)
                    writer.WriteRecord(record.ToTimetableRecord());
            }
        }
    }
}
