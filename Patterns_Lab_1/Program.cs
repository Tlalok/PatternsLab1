using Patterns_Lab_1.FileProcess;
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

            //var des = new XmlDeserializer();
            //using (var file = File.OpenRead(path))
            //{
            //    var timetable = des.Deserialize(file);
            //}



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
            
            var timetable = new Timetable
            {
                Buses = new List<BusTimetable>(),
                Trains = new List<TrainTimetable>()
            };

            timetable.Buses.Add(new BusTimetable
            {
                ArrivalStation = "West",
                BusBrand = "Reno",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                DeparturePoint = "Minsk",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22))
            });
            timetable.Buses.Add(new BusTimetable
            {
                ArrivalStation = "West",
                BusBrand = "Reno",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                DeparturePoint = "Minsk",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22)).Add(TimeSpan.FromDays(3))
            });

            timetable.Trains.Add(new TrainTimetable
            {
                ArrivalStation = "West",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                DeparturePoint = "Minsk",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22)),
                TicketType = "123123"
            });
            timetable.Trains.Add(new TrainTimetable
            {
                ArrivalStation = "West",
                DepartureDate = DateTime.Now,
                DeparturePlatform = "B-2",
                DepartureStation = "Central",
                DeparturePoint = "Minsk",
                Destination = "Gomel",
                Number = "525E",
                TicketCost = 250000,
                TravelTime = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(22)),
                TicketType = "123123"
            });

            //var listSerialiers = new List<ITimetableSerializer>(2);
            //listSerialiers.Add(new XmlSerializer());
            //listSerialiers.Add(new CsvSerializer());
            var writer = new TimetableFileWriter(new XmlFactory());

            writer.Write(timetable, Path.ChangeExtension(path, ".xml"));


            //var listDeserializers = new List<ITimetableDeserializer>(2);
            //listDeserializers.Add(new XmlDeserializer());
            //listDeserializers.Add(new CsvDeserializer());
            //var reader = new TimetableFileReader(new XmlFactory());

            //timetable = new Timetable();
            //timetable = reader.Read(Path.ChangeExtension(path, ".xml"));
            //Console.Write("{0} {1}", timetable.Buses[0].Number, timetable.Buses[1].Number);

            //writer.Write(timetable, Path.ChangeExtension(path, ".xml"));
            //timetable = reader.Read(Path.ChangeExtension(path, ".xml"));
            
        }
    }
}
