using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDICOM
{
    class ServicioDICOM
    {
        public void IniciarServidorDICOM()
        {
            Process.Start("CMD.exe", "/k " + @"cd C:\\Program Files\\Orthanc Server" + "&" + @" Orthanc.exe ""C:\\Users\\usuario\\Documents\\Bioinfo\\Orthanc-1.5.6\\Orthanc-1.5.6\\Resources\\Configuration.json""");
        }
        public void AgregarArchivoDICOM()
        {
            string texto = "archivodicom.txt" + "\"";
            Process.Start("CMD.exe", "/k " + "&" + @"cd ""C:\Users\usuario\Documents\Bioinfo\dcmtk-3.6.4-win64-dynamic\bin" +texto+ "&" + @" dump2dcm.exe ""C:\Users\usuario\Documents\Bioinfo\Orthanc-1.5.6\Orthanc-1.5.6\Plugins\Samples\ModalityWorklists\WorklistsDatabase\myworklist.wl""");
           
        }
        public string RealizarConsultaDICOM(String dato)
        {
            string nombre = dato;
            Process.Start("CMD.exe", "/k " + @"cd C:\Users\usuario\Documents\Bioinfo\dcmtk-3.6.4-win64-dynamic\bin" + "&" + " findscu --call FINDSCU -W -k " + "\"PatientName=" + nombre + "*\"  localhost 4242");
            //ProcessStartInfo info = new ProcessStartInfo();
            //info.Arguments = @"cd C:\Users\usuario\Documents\Bioinfo\dcmtk-3.6.4-win64-dynamic\bin" + "&" + " findscu --call FINDSCU -W -k " + "\"PatientName=" + nombre + "*\"  localhost 4242";
            //info.WindowStyle = ProcessWindowStyle.Hidden;
            //info.CreateNoWindow = true;
            //info.FileName = "cmd.exe";
            //info.UseShellExecute = false;
            //info.RedirectStandardOutput = true;
            //string result;
            //using (Process process = Process.Start(info))
            //{
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        result = reader.ReadToEnd();
            //        //BuscarPaciente b = new BuscarPaciente(result);
            //    }
            //}

            return "";
        }
    }
}
