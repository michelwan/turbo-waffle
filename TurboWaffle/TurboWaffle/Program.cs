using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboWaffle.Model;
using TurboWaffle.View;

namespace TurboWaffle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var model = new AccountingModel();

            var view = new AccountingForm(model);
            Application.Run(view);
        }
    }
}
