using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.Serialization.Csv
{
    public class CsvFactory : ISerializationFactory
    {
        private readonly string csvExtension = ".csv";

        public ITimetableDeserializer CreateDeserializer()
        {
            return new CsvDeserializer();
        }

        public ITimetableSerializer CreateSerializer()
        {
            return new CsvSerializer();
        }

        public bool Applicable(string extension)
        {
            return extension.ToLower() == csvExtension;
        }
    }
}
