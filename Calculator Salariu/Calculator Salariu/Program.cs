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
            MessageBoxUtils.OK = "OK";
            MessageBoxUtils.Yes = "Da";
            MessageBoxUtils.No = "Nu";
            MessageBoxUtils.Register();
        }
    }
}
