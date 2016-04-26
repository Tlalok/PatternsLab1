using Patterns_Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.Serialization.Csv
{
    static class TimetableRecordHelper
    {
        public static BusTimetable ToBusTimetable(this TimetableRecord record)
        {
            return new BusTimetable
            {
                ArrivalStation = record.ArrivalStation,
                BusBrand = record.BusBrand,
                DepartureDate = record.DepartureDate,
                DeparturePlatform = record.DeparturePlatform,
                DepartureStation = record.DepartureStation,
                Destination = record.Destination,
                Number = record.Number,
                TicketCost = record.TicketCost,
                TravelTime = record.TravelTime
            };
        }

        public static TrainTimetable ToTrainTimetable(this TimetableRecord record)
        {
            return new TrainTimetable
            {
                ArrivalStation = record.ArrivalStation,
                DepartureDate = record.DepartureDate,
                DeparturePlatform = record.DeparturePlatform,
                DepartureStation = record.DepartureStation,
                Destination = record.Destination,
                Number = record.Number,
                TicketCost = record.TicketCost,
                TravelTime = record.TravelTime,
                TicketType = record.TicketType
            };
        }

        public static TimetableRecord ToTimetableRecord(this TrainTimetable record)
        {
            return new TimetableRecord
            {
                Type = RecordType.Train,
                ArrivalStation = record.ArrivalStation,
                DepartureDate = record.DepartureDate,
                DeparturePlatform = record.DeparturePlatform,
                DepartureStation = record.DepartureStation,
                Destination = record.Destination,
                Number = record.Number,
                TicketCost = record.TicketCost,
                TravelTime = record.TravelTime,
                TicketType = record.TicketType
            };
        }

        public static TimetableRecord ToTimetableRecord(this BusTimetable record)
        {
            return new TimetableRecord
            {
                Type = RecordType.Bus,
                ArrivalStation = record.ArrivalStation,
                BusBrand = record.BusBrand,
                DepartureDate = record.DepartureDate,
                DeparturePlatform = record.DeparturePlatform,
                DepartureStation = record.DepartureStation,
                Destination = record.Destination,
                Number = record.Number,
                TicketCost = record.TicketCost,
                TravelTime = record.TravelTime
            };
        }
    }
}
