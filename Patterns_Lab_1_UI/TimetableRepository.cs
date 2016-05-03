using Ninject;
using Patterns_Lab_1.FileProcess;
using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1_UI
{
    public class TimetableFileRepository
    {
        public string FilePath { get; private set; }

        public TimetableFileRepository(string path)
        {
            this.FilePath = path;
        }

        public Timetable ReadTimetable()
        {
            var extension = Path.GetExtension(FilePath);
            var factory = Resolver.Instance.Get<SerializationFactoryContainer>().GetFactory(extension);
            return new TimetableFileReader(factory).Read(FilePath);
        }

        public void SaveTimetable(Timetable timetable)
        {
            var extension = Path.GetExtension(FilePath);
            var factory = Resolver.Instance.Get<SerializationFactoryContainer>().GetFactory(extension);
            new TimetableFileWriter(factory).Write(timetable, FilePath);
        }
    }
}
