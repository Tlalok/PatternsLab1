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
    public class TimetableWriter
    {
        private IEnumerable<ITimetableSerializer> serializers;

        public TimetableWriter(IEnumerable<ITimetableSerializer> serializers)
        {
            this.serializers = serializers;
        }

        public void Write(Timetable timetable, string path)
        {
            var extension = Path.GetExtension(path);
            foreach (var serializer in serializers)
            {
                if (serializer.Applicable(extension))
                {
                    using (var file = File.OpenWrite(path))
                    {
                        serializer.Serialize(timetable, file);
                        return;
                    }
                }
            }
            throw new ArgumentException("Unknown file type.", path);
        }
    }
}
