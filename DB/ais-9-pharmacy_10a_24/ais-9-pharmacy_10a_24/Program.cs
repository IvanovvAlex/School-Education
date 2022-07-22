using ais_9_pharmacy_10a_24.Data;
using ais_9_pharmacy_10a_24.Services.MedicamentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ais_9_pharmacy_10a_24
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            MedicamentService medicamentService = new MedicamentService(context);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(medicamentService));
        }
    }
}
