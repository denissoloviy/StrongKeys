using Ninject;
using StrongKeys.Service;
using System;
using System.Windows.Forms;

namespace StrongKeys.DesktopRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var kernel = new StandardKernel(new DesktopModule(), new GAModule(), new DBModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(kernel.Get<MainWindow>());
        }
    }
}
