using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.Serialization.Xml
{
    public class XmlFactory : ISerializationFactory
    {
        private readonly string xmlExtension = ".xml";

        public ITimetableDeserializer CreateDeserializer()
        {
            return new XmlDeserializer();
        }

        public ITimetableSerializer CreateSerializer()
        {
            return new XmlSerializer();
        }

        public bool Applicable(string extension)
        {
            return extension.ToLower() == xmlExtension;
        }
    }
}
