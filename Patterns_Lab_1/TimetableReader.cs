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
    public class TimetableReader
    {
        private IEnumerable<ITimetableDeserializer> deserializers;

        public TimetableReader(IEnumerable<ITimetableDeserializer> deserializers)
        {
            this.deserializers = deserializers;
        }

        public Timetable Read(string path)
        {
            var extension = Path.GetExtension(path);
            foreach (var deserializer in deserializers)
            {
                if (deserializer.Applicable(extension))
                {
                    using (var file = File.OpenRead(path))
                    {
                        return deserializer.Deserialize(file);
                    }
                }
            }
            throw new ArgumentException("Unknown file type.", path);
        }
    }
}
