using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDICOM
{
    class ServicioDICOM
    {
        public void IniciarServidorDICOM()
        {
            Process.Start("CMD.exe", "/k " + @"cd C:\\Program Files\\Orthanc Server" + "&" + @" Orthanc.exe ""C:\\Users\\Alan Jimenez\\Documents\\Orthanc-1.5.6\\Resources\\Configuration.json""");
        }
        public void AgregarArchivoDICOM()
        {
            string texto = "archivodicom.txt" + "\"";
            Process.Start("CMD.exe", "/k " + "&" + @"cd C:\\Users\\Alan Jimenez\\Documents\\dcmtk-3.6.4-win64-dynamic\\bin" + "&" + @" dump2dcm.exe ""C:\\Users\\Alan Jimenez\\Documents\\Orthanc-1.5.6\\Plugins\\Samples\\ModalityWorklists\\WorklistsDatabase\\" + texto + @" > ""C:\\Users\\Alan Jimenez\\Documents\\Orthanc-1.5.6\\Plugins\\Samples\\ModalityWorklists\\WorklistsDatabase\\prueba2.wl""");
        }
        public void RealizarConsultaDICOM()
        {
            string nombre = "VIVALDI";
            Process.Start("CMD.exe", "/k " + @"cd C:\\Users\\Alan Jimenez\\Documents\\dcmtk-3.6.4-win64-dynamic\\bin" + "&" + " findscu --call FINDSCU -W -k \"" + "\"PatientName =" + nombre + " *\"  localhost 4242");
        }
    }
}
