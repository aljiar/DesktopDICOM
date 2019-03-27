using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace DesktopDICOM
{
    class ServicioTexto
    {
        StreamReader Lector;
        public void LeerTexto(string Ruta)
        {
           //Parser
        }
        public void CrearTextoDICOM(SolictudModalidad solictud)
        {

            string archivoTxt = "C:\\Users\\cae-1\\Desktop\\archivodicom.txt";
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(archivoTxt);
            string contenido = "(0002, 0000) UL 202                                      #   4, 1 FileMetaInformationGroupLength"+"\r\n" +
                            "(0002, 0001) OB 00\01                                    #   2, 1 FileMetaInformationVersion" + "\r\n" +
                            "(0002, 0002) UI[1.2.276.0.7230010.3.1.0.1]              #  26, 1 MediaStorageSOPClassUID" + "\r\n" +
                            "(0002, 0003) UI[1.2.276.0.7230010.3.1.4.2831176407.11154.1448031138.805061] #  58, 1 MediaStorageSOPInstanceUID" + "\r\n" +
                            "(0002, 0010) UI = LittleEndianExplicit                    #  20, 1 TransferSyntaxUID" + "\r\n" +
                            "(0002, 0012) UI[1.2.276.0.7230010.3.0.3.6.0]            #  28, 1 ImplementationClassUID" + "\r\n" +
                            "(0002, 0013) SH[OFFIS_DCMTK_360]                        #  16, 1 ImplementationVersionName" + "\r\n" +
                            "(0008, 0005) CS[ISO_IR 100]                             #  10, 1 SpecificCharacterSet" + "\r\n" +
                            "(0008,0050) SH [00000 ]                                 #   6, 1 AccessionNumber" + "\r\n" +
                            "(0010, 0010) PN[" + solictud.Paciente.NombrePaciente.Replace(" ", "^") + "]  #  16, 1 PatientName" + "\r\n" +
                            "(0010, 0020) LO[" + solictud.Paciente.IdPaciente + "]        #   8, 1 PatientID" + "\r\n" +
                            "(0010, 0030) DA[" + solictud.Paciente.FechaPaciente + "]    #   8, 1 PatientBirthDate" + "\r\n" +
                            "(0010, 0040) CS[" + solictud.Paciente.SexoPaciente + "]       #   2, 1 PatientSex" + "\r\n" +
                            "(0010, 2110) LO[" + solictud.Paciente.AlergiasPaciente + "]    #   6, 1 Allergies" + "\r\n" +
                            "(0020, 000d) UI[1.2.276.0.7230010.3.2.101]                                  #  26, 1 StudyInstanceUID" + "\r\n" +
                            "(0032, 1032) PN[" + solictud.RequestPhysician + "]            #   6, 1 RequestingPhysician" + "\r\n" +
                            "(0032, 1060) LO[" + solictud.RequestProcedureDescription + "]  #   6, 1 RequestedProcedureDescription" + "\r\n" +
                            "(0040, 0100) SQ(Sequence with undefined length #=1)     # u/l, 1 ScheduledProcedureStepSequence" + "\r\n" +
                            "(fffe, e000) na(Item with undefined length #=11)        # u/l, 1 Item" + "\r\n" +
                            "(0008, 0060) CS["+solictud.Modalidad.AbreviacionModalidad+ " #   2, 1 Modality" + "\r\n" +
                            "(0032, 1070) LO[BARIUMSULFAT]                           #  12, 1 RequestedContrastAgent" + "\r\n" +
                            "(0040, 0001) AE[AA32\\AA33]                             #  10, 2 ScheduledStationAETitle" + "\r\n" +
                            "(0040, 0002) DA["+solictud.ScheduledProcedureStartDate+ "] #   8, 1 ScheduledProcedureStepStartDate" + "\r\n" +
                            "(0040, 0003) TM["+solictud.ScheduledProcedureStartTime+ "]   #   6, 1 ScheduledProcedureStepStartTime" + "\r\n" +
                            "(0040, 0006) PN[JOHNSON]                               #   8, 1 ScheduledPerformingPhysicianName" + "\r\n" +
                            "(0040, 0007) LO[EXAM74]                                 #   6, 1 ScheduledProcedureStepDescription" + "\r\n" +
                            "(0040, 0009) SH[SPD3445]                               #   8, 1 ScheduledProcedureStepID" + "\r\n" +
                            "(0040, 0010) SH[STN456]                                 #   6, 1 ScheduledStationName" + "\r\n" +
                            "(0040, 0011) SH[B34F56]                                 #   6, 1 ScheduledProcedureStepLocation" + "\r\n" +
                            "(0040, 0012) LO(no value available)                     #   0, 0 PreMedication" + "\r\n" +
                            "(fffe, e00d) na(ItemDelimitationItem)                   #   0, 0 ItemDelimitationItem" + "\r\n" +
                            "(fffe, e0dd) na(SequenceDelimitationItem)               #   0, 0 SequenceDelimitationItem" + "\r\n" +
                            "(0040, 1001) SH[RPP454G234]                             #  10, 1 RequestedProcedureID" + "\r\n" +
                            "(0040, 1003) SH[" + solictud.RequestProcedurePriority + "] #   4, 1 RequestedProcedurePriority sp" + "\r\n";
            objWriter.Write(contenido);
            objWriter.Close();
        }
    }
}
