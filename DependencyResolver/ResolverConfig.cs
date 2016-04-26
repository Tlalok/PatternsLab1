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

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolverForms(this IKernel kernel)
        {
            kernel.Bind<TimetableReader>().ToConstructor<TimetableReader>((argSyntax) =>
                new TimetableReader
                (
                    new List<ITimetableDeserializer>(2)
                    {
                        new CsvDeserializer(), new XmlDeserializer()
                    }
                )
            ).InSingletonScope();
        }
    }
}

