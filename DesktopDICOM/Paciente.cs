using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDICOM
{
    class Paciente
    {
        public int IdPaciente { get; set;}
        public string NombrePaciente { get; set; }
        public string FechaPaciente { get; set; }
        public string SexoPaciente { get; set; }
        public string AlergiasPaciente { get; set; }
        public int Telefono { get; set; }
    }
}
