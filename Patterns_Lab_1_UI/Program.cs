﻿using Ninject;
using Patterns_Lab_1.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_Lab_1_UI
{
    static class Program
    {
        private static readonly IKernel resolver;
        private static readonly SerializationFactoryContainer factories;

        public static IKernel Resolver { get { return resolver; } }

        public static SerializationFactoryContainer Factories { get { return factories; } }

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolverForms();
            factories = resolver.Get<SerializationFactoryContainer>();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
