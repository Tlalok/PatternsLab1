using Patterns_Lab_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1.Serialization.Interfaces
{
    public interface ITimetableDeserializer
    {
        Timetable Deserialize(Stream file);
    }
}
