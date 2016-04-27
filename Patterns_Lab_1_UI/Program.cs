using Ninject;
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

        public static IKernel Resolver { get { return resolver; } }

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolverForms();
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
