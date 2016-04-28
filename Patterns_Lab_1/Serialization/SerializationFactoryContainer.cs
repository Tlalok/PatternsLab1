using Patterns_Lab_1.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Lab_1.Serialization
{
    public class SerializationFactoryContainer
    {
        private IEnumerable<ISerializationFactory> factories;

        public SerializationFactoryContainer(IEnumerable<ISerializationFactory> factories)
        {
            this.factories = factories;
        }

        public ISerializationFactory GetFactory(string extension)
        {
            foreach (var factory in factories)
            {
                if (factory.Applicable(extension))
                {
                    return factory;
                }
            }

            throw new ArgumentException("Unkonwn file type.", "extension");
        }
    }
}
