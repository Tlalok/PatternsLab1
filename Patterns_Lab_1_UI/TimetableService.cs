using Patterns_Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1_UI
{
    public class TimetableService
    {
        private static List<DayOfWeek> Weekdays = new List<DayOfWeek>
        {
            DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday
        };

        private static List<DayOfWeek> Weekend = new List<DayOfWeek>
        {
            DayOfWeek.Saturday, DayOfWeek.Sunday
        };

        private TimetableFileRepository repository;
        private Timetable timetable;

        private Func<BusTimetable, bool> busFilter = bus => true;
        private Func<TrainTimetable, bool> trainFilter = train => true;

        private DateTime? nearestToTime = null;
        private int countRecordsToDisplay = -1;


        public event Action<Timetable> onChange;

        public Timetable Timetable
        {
            get
            {
                var filteredBuses = timetable.Buses.Where(busFilter);
                var filteredTrains = timetable.Trains.Where(trainFilter);
                if (countRecordsToDisplay > -1)
                {
                    filteredBuses = filteredBuses.Where(bus => bus.DepartureDate >= nearestToTime)
                                                 .OrderBy(bus => bus.DepartureDate)
                                                 .Take(countRecordsToDisplay);
                    filteredTrains = filteredTrains.Where(train => train.DepartureDate >= nearestToTime)
                                                   .OrderBy(train => train.DepartureDate)
                                                   .Take(countRecordsToDisplay);
                }

                return new Timetable
                {
                    Buses = filteredBuses.ToList(),
                    Trains = filteredTrains.ToList()
                };
            }
        }

        public TimetableService()
        {
            this.repository = null;
            this.timetable = null;
        }

        public TimetableService(TimetableFileRepository repository)
        {
            this.repository = repository;
            this.timetable = repository.ReadTimetable();
        }

        public void SetRepository(TimetableFileRepository repository)
        {
            this.repository = repository;
            this.timetable = repository.ReadTimetable();
            ResetFilter();
        }

        public List<BusTimetable> GetBuses()
        {
            return timetable.Buses;
        }

        public void AddBus(BusTimetable busTimetable)
        {
            timetable.Buses.Add(busTimetable);
            onChange(this.Timetable);
        }

        public void DeleteBus(BusTimetable busTimetable)
        {
            timetable.Buses.Remove(busTimetable);
            onChange(this.Timetable);
        }

        public List<TrainTimetable> GetTrains()
        {
            return timetable.Trains;
        }

        public void AddTrain(TrainTimetable trainTimetable)
        {
            timetable.Trains.Add(trainTimetable);
            onChange(this.Timetable);
        }

        public void DeleteTrain(TrainTimetable trainTimetable)
        {
            timetable.Trains.Remove(trainTimetable);
            onChange(this.Timetable);
        }

        public void SaveTimetable()
        {
            repository.SaveTimetable(timetable);
        }

        public void ApplyFilter(DateTime startTime, DateTime endTime, bool weekdays, bool weekend, string departurePoint, string destination, DateTime? nearestToTime, int countRecords)
        {
            busFilter = bus => bus.DepartureDate >= startTime
                            && bus.DepartureDate <= endTime
                            && (weekdays || !Weekdays.Contains(bus.DepartureDate.DayOfWeek))
                            && (weekend || !Weekend.Contains(bus.DepartureDate.DayOfWeek))
                            && (String.IsNullOrEmpty(departurePoint) || String.Equals(departurePoint, bus.DepartureStation, StringComparison.OrdinalIgnoreCase))
                            && (String.IsNullOrEmpty(destination) || String.Equals(destination, bus.ArrivalStation, StringComparison.OrdinalIgnoreCase));

            trainFilter = train => train.DepartureDate >= startTime
                                && train.DepartureDate <= endTime
                                && (weekdays || !Weekdays.Contains(train.DepartureDate.DayOfWeek))
                                && (weekend || !Weekend.Contains(train.DepartureDate.DayOfWeek))
                                && (String.IsNullOrEmpty(departurePoint) || String.Equals(departurePoint, train.DepartureStation, StringComparison.OrdinalIgnoreCase))
                                && (String.IsNullOrEmpty(destination) || String.Equals(destination, train.ArrivalStation, StringComparison.OrdinalIgnoreCase));

            this.nearestToTime = nearestToTime.HasValue ? nearestToTime : DateTime.Now;
            countRecordsToDisplay = countRecords;

            onChange(this.Timetable);
        }

        public void ResetFilter()
        {
            busFilter = bus => true;
            trainFilter = train => true;
            nearestToTime = null;
            countRecordsToDisplay = -1;

            onChange(this.Timetable);
        }

        public List<string> BusDestinations
        {
            get
            {
                return timetable.Buses.Select(bus => bus.Destination).ToList();
            }
        }

        public List<string> BusArrivalStations
        {
            get
            {
                return timetable.Buses.Select(bus => bus.ArrivalStation).ToList();
            }
        }

        public List<string> TrainDestinations
        {
            get
            {
                return timetable.Trains.Select(train => train.Destination).Distinct().ToList();
            }
        }

        public List<string> TrainArrivalStations
        {
            get
            {
                return timetable.Trains.Select(train => train.ArrivalStation).Distinct().ToList();
            }
        }

        public int GetBusId(BusTimetable bus)
        {
            return timetable.Buses.IndexOf(bus);
        }

        public int GetTrainId(TrainTimetable train)
        {
            return timetable.Trains.IndexOf(train);
        }
    }
}
