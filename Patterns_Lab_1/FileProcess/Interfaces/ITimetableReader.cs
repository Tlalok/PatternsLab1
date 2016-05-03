using Patterns_Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.FileProcess.Interfaces
{
    public interface ITimetableFileReader
    {
        Timetable Read(string path);
    }
}
