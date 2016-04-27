﻿using Patterns_Lab_1.Models;
using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1
{
    public class TimetableFileReader
    {
        private ISerializationFactory factory;

        public TimetableFileReader(ISerializationFactory factory)
        {
            this.factory = factory;
        }

        public Timetable Read(string path)
        {
            using (var file = File.OpenRead(path))
            {
                return factory.CreateDeserializer().Deserialize(file);
            }
        }
    }
}
