using Ninject;
using Patterns_Lab_1;
using Patterns_Lab_1.Serialization.Csv;
using Patterns_Lab_1.Serialization.Interfaces;
using Patterns_Lab_1.Serialization.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1_UI
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolverForms(this IKernel kernel)
        {
            //kernel.Bind<TimetableFileReader>().ToConstructor<TimetableFileReader>((argSyntax) =>
            //    new TimetableFileReader
            //    (
            //        new List<ITimetableDeserializer>(2)
            //        {
            //            new CsvDeserializer(), new XmlDeserializer()
            //        }
            //    )
            //).InSingletonScope();

            kernel.Bind<SerializationFactoryContainer>().ToConstructor<SerializationFactoryContainer>((argSyntax) =>
                new SerializationFactoryContainer
                (
                    new List<ISerializationFactory>(2)
                    {
                        new CsvFactory(), new XmlFactory()
                    }
                )
            ).InSingletonScope();
        }
    }
}
