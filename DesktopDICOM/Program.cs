using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDICOM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ManagerAPP managerAPP = new ManagerAPP();
            Console.WriteLine("\"Consola App\"");
            managerAPP.LevantarDICOM();
            managerAPP.AgregarADICOM();
            //managerAPP.ConsultaDICOM();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
