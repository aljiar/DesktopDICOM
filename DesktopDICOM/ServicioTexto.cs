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

            string archivoTxt = "C:\\Users\\archivodicom.txt";
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(archivoTxt);
            string contenido = "(0002, 0000) UL 202                                      #   4, 1 FileMetaInformationGroupLength" +
                            "(0002, 0001) OB 00\01                                    #   2, 1 FileMetaInformationVersion" +
                            "(0002, 0002) UI[1.2.276.0.7230010.3.1.0.1]              #  26, 1 MediaStorageSOPClassUID" +
                            "(0002, 0003) UI[1.2.276.0.7230010.3.1.4.2831176407.11154.1448031138.805061] #  58, 1 MediaStorageSOPInstanceUID" +
                            "(0002, 0010) UI = LittleEndianExplicit                    #  20, 1 TransferSyntaxUID" +
                            "(0002, 0012) UI[1.2.276.0.7230010.3.0.3.6.0]            #  28, 1 ImplementationClassUID" +
                            "(0002, 0013) SH[OFFIS_DCMTK_360]                        #  16, 1 ImplementationVersionName" +
                            "(0008, 0005) CS[ISO_IR 100]                             #  10, 1 SpecificCharacterSet" +
                            "(0008,0050) SH [00000 ]                                 #   6, 1 AccessionNumber" +
                            "(0010, 0010) PN[" + solictud.Paciente.NombrePaciente.Replace(" ", "^") + "]                       #  16, 1 PatientName" +
                            "(0010, 0020) LO[" + solictud.Paciente.IdPaciente + "]                               #   8, 1 PatientID" +
                            "(0010, 0030) DA[" + solictud.Paciente.FechaPaciente + "]                               #   8, 1 PatientBirthDate" +
                            "(0010, 0040) CS[" + solictud.Paciente.SexoPaciente + "]                                     #   2, 1 PatientSex" +
                            "(0010, 2110) LO[" + solictud.Paciente.AlergiasPaciente + "]                                 #   6, 1 Allergies" +
                            "(0020, 000d) UI[1.2.276.0.7230010.3.2.101]                                  #  26, 1 StudyInstanceUID" +
                            "(0032, 1032) PN[" + solictud.RequestPhysician + "]                                 #   6, 1 RequestingPhysician" +
                            "(0032, 1060) LO[" + solictud.RequestProcedureDescription + "]                                 #   6, 1 RequestedProcedureDescription" +
                            "(0040, 0100) SQ(Sequence with undefined length #=1)     # u/l, 1 ScheduledProcedureStepSequence" +
                            "(fffe, e000) na(Item with undefined length #=11)        # u/l, 1 Item" +
                            "(0008, 0060) CS["+solictud.Modalidad.AbreviacionModalidad+" #   2, 1 Modality" +
                            "(0032, 1070) LO[BARIUMSULFAT]                           #  12, 1 RequestedContrastAgent" +
                            "(0040, 0001) AE[AA32\\AA33]                             #  10, 2 ScheduledStationAETitle" +
                            "(0040, 0002) DA["+solictud.ScheduledProcedureStartDate+"]                               #   8, 1 ScheduledProcedureStepStartDate" +
                            "(0040, 0003) TM["+solictud.ScheduledProcedureStartTime+"]                                 #   6, 1 ScheduledProcedureStepStartTime" +
                            "(0040, 0006) PN[JOHNSON]                               #   8, 1 ScheduledPerformingPhysicianName" +
                            "(0040, 0007) LO[EXAM74]                                 #   6, 1 ScheduledProcedureStepDescription" +
                            "(0040, 0009) SH[SPD3445]                               #   8, 1 ScheduledProcedureStepID" +
                            "(0040, 0010) SH[STN456]                                 #   6, 1 ScheduledStationName" +
                            "(0040, 0011) SH[B34F56]                                 #   6, 1 ScheduledProcedureStepLocation" +
                            "(0040, 0012) LO(no value available)                     #   0, 0 PreMedication" +
                            "(fffe, e00d) na(ItemDelimitationItem)                   #   0, 0 ItemDelimitationItem" +
                            "(fffe, e0dd) na(SequenceDelimitationItem)               #   0, 0 SequenceDelimitationItem" +
                            "(0040, 1001) SH[" + solictud.RequestProcedureID + "]                             #  10, 1 RequestedProcedureID" +
                            "(0040, 1003) SH[" + solictud.RequestProcedurePriority + "]                                   #   4, 1 RequestedProcedurePriority sp";
            objWriter.Write(contenido);
            objWriter.Close();
        }
    }
}
