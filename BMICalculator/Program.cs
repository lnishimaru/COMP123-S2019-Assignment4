using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    static class Program
    {
        public static BMICalculatorForm mainForm;
        public static SplashScreen startForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BMICalculatorForm());
            mainForm = new BMICalculatorForm();
            startForm = new SplashScreen();
            //Application.Run(mainForm);
            Application.Run(Program.startForm);
        }
    }
}
