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
    public class CsvDeserializer : ITimetableDeserializer
    {
        private readonly string csvExtension = ".csv";

        public bool Applicable(string extension)
        {
            return extension.ToLower() == csvExtension;
        }

        public Timetable Deserialize(Stream file)
        {
            var reader = new CsvReader(new StreamReader(file));
            var records = reader.GetRecords<TimetableRecord>();
            var timetable = new Timetable()
            {
                buses = new List<BusTimetable>(),
                trains = new List<TrainTimetable>()
            };
            foreach (var record in records)
            {
                switch (record.Type)
                {
                    case RecordType.Bus: 
                        timetable.buses.Add(record.ToBusTimetable());
                        break;

                    case RecordType.Train: 
                        timetable.trains.Add(record.ToTrainTimetable());
                        break;

                    default:
                        throw new ArgumentException("Unkown timetable type", "file");
                }
            }
            return timetable;
        }
    }
}
