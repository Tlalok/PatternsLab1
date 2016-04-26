using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1.Serialization.Xml
{
    public class XmlSerializer : ITimetableSerializer
    {
        private readonly string xmlExtension = ".xml";

        public bool Applicable(string extension)
        {
            return extension.ToLower() == xmlExtension;
        }

        public void Serialize(Timetable timetable, Stream file)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Timetable));
            serializer.Serialize(file, timetable);
        }
    }
}
