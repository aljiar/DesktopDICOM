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
        public string RequestPhysician { get; set; }
        public string RequestProcedureDescription { get; set; }
        public string RequestProcedureID { get; set; }
        public string ScheduledProcedureStartDate { get; set; }
        public string ScheduledProcedureStartTime { get; set; }
        public string RequestProcedurePriority { get; set; }
      
    }
}
