using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1
{
    public class TimetableFileWriter
    {
        private ISerializationFactory factory;

        public TimetableFileWriter(ISerializationFactory factory)
        {
            this.factory = factory;
        }

        public void Write(Timetable timetable, string path)
        {
            using (var file = File.OpenWrite(path))
            {
                factory.CreateSerializer().Serialize(timetable, file);
            }
        }
    }
}
