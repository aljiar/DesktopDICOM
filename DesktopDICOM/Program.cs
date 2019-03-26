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
            ServicioDICOM servicioDICOM = new ServicioDICOM();
            Modalidad modalidad = new Modalidad();
            Paciente paciente1 = new Paciente();
            SolictudModalidad solictud = new SolictudModalidad();

            modalidad.IdModalidad = 1001;
            modalidad.NombreModalidad = "Rayos X";
            modalidad.AbreviacionModalidad = "RX";
            
            paciente1.IdPaciente = 1;
            paciente1.NombrePaciente = "Juancho Tacorta";
            paciente1.SexoPaciente = "M";
            paciente1.AlergiasPaciente = "Tantal";
            paciente1.FechaPaciente = "19900927";
            solictud.IdSolicitudModalidad = 1;
            solictud.Paciente = paciente1;
            solictud.Modalidad = modalidad;
            Console.WriteLine(solictud.Paciente.NombrePaciente+" ; "+ solictud.Modalidad.NombreModalidad);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
