using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDICOM
{
    class ManagerAPP
    {
        List<Paciente> listaPacientes=new List<Paciente>();
        List<Modalidad> listaModalidades=new List<Modalidad>();
        List<SolictudModalidad> listaSolicitudes=new List<SolictudModalidad>();
        ServicioDICOM servicioDICOM = new ServicioDICOM();
        ServicioTexto servicioTexto = new ServicioTexto();
        public void AgregarPacientes(Paciente paciente)
        {
            listaPacientes.Add(paciente);
        }
        public void AgregarModalidad(Modalidad modalidad)
        {
            listaModalidades.Add(modalidad);
        }
        public void AgregarSolicitud(SolictudModalidad solictud)
        {
            AgregarPacientes(solictud.Paciente);
            listaSolicitudes.Add(solictud);
        }
        public void LevantarDICOM()
        {
            servicioDICOM.IniciarServidorDICOM();
        }
        public void AgregarADICOM()
        {
            servicioDICOM.AgregarArchivoDICOM();
        }
        public void ConsultaDICOM()
        {
            servicioDICOM.RealizarConsultaDICOM();
        }
        public void LeerArchivo(String ruta)
        {
            servicioTexto.LeerTexto(ruta);
        }
    }
}
