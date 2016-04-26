using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Patterns_Lab_1.Serialization.Xml
{
    public class XmlDeserializer : ITimetableDeserializer
    {
        private readonly string xmlExtension = ".xml";

        public bool Applicable(string extension)
        {
            return extension.ToLower() == xmlExtension;
        }

        public Timetable Deserialize(Stream file)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Timetable));
            return (Timetable)serializer.Deserialize(file);
        }
    }
}
