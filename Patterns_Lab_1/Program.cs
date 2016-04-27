using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization.Csv;
using Patterns_Lab_1.Serialization.Interfaces;
using Patterns_Lab_1.Serialization.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1
{
    class Program
    {
        private static readonly string path = @"D:\bsuir\Patterns\Lab1\timetable.csv";


        static void Main(string[] args)
        {
            //using (var file = File.OpenWrite(path))
            //{
            //    var stream = new StreamWriter(file);
            //    stream.WriteLine("sdfdsfgdsg");
            //    //var csvWriter = new CsvHelper.CsvWriter(stream);
            //    //csvWriter.WriteField("a");
            //    //csvWriter.WriteField(2);
            //    //csvWriter.WriteField(true);
            //    //csvWriter.NextRecord();
            //}
            //return;
            /*
            var timetable = new Timetable
            {
                buses = new List<BusTimetable>(),
                trains = new List<TrainTimetable>()
            };

            timetable.buses.Add(new BusTimetable
            {
                ArrivalStation = "West",
                BusBrand = "Reno",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22))
            });
            timetable.buses.Add(new BusTimetable
            {
                ArrivalStation = "West",
                BusBrand = "Reno",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22)).Add(TimeSpan.FromDays(3))
            });

            timetable.trains.Add(new TrainTimetable
            {
                ArrivalStation = "West",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22)),
                TicketType = "123123"
            });
            timetable.trains.Add(new TrainTimetable
            {
                ArrivalStation = "West",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22)),
                TicketType = "123123"
            });

            var listSerialiers = new List<ITimetableSerializer>(2);
            listSerialiers.Add(new XmlSerializer());
            listSerialiers.Add(new CsvSerializer());
            var writer = new TimetableFileWriter(listSerialiers);

            writer.Write(timetable, path);

            var listDeserializers = new List<ITimetableDeserializer>(2);
            listDeserializers.Add(new XmlDeserializer());
            listDeserializers.Add(new CsvDeserializer());
            var reader = new TimetableFileReader(listDeserializers);

            timetable = new Timetable();
            timetable = reader.Read(path);

            writer.Write(timetable, Path.ChangeExtension(path, ".xml"));
            timetable = reader.Read(Path.ChangeExtension(path, ".xml"));
            */
        }
    }
}
