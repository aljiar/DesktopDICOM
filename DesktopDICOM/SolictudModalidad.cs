using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDICOM
{
    class SolictudModalidad
    {
        public int IdSolicitudModalidad { get; set; }
        public Paciente Paciente {get;set;}
        public Modalidad Modalidad { get; set; }
    }
}
