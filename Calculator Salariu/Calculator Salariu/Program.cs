using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Salariu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorSalarii());
        }

        private static void Initialize()
        {
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Nu";
            MessageBoxManager.Register();
        }
    }
}
