using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.Serialization.Interfaces
{
    public interface ISerializationFactory
    {
        ITimetableDeserializer CreateDeserializer();

        ITimetableSerializer CreateSerializer();

        bool Applicable(string extension);
    }
}
