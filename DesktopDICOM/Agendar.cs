using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDICOM
{
    public partial class Agendar : Form
    {
        public Agendar(List<Segmento> model)
        {
            InitializeComponent();

            for (int i = 0; i < model.Count; i++)
            {
                if (model[i].nombreSegmento=="PID")
                {
                    for (int j = 0; j < model[i].campos.Count; j++)
                    {
                       txtNombre.Text =model[i].campos[5].data.Replace('^',' ');
                        txtSexo.Text = model[i].campos[8].data;
                        string fechaBD = model[i].campos[7].data;
                        string year = "";
                        for (int x = 0; x <= 3; x++)
                        {
                            year = year + fechaBD[x];
                        }
                        string mes = "";
                        for (int y = 4; y <= 5; y++)
                        {
                            mes = mes + fechaBD[y];
                        }
                        string dia = "";
                        for (int z = 6; z <= 7; z++)
                        {
                            dia = dia + fechaBD[z];
                        }
                        string fecha = dia + "/" + mes + "/" + year;
                        
                       
                       txtBD.Text = fecha;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.IdPaciente = 1;
            paciente.NombrePaciente = txtNombre.Text;
            paciente.FechaPaciente = txtBD.Text;
            paciente.SexoPaciente = txtSexo.Text;
            paciente.AlergiasPaciente = "Penicilina";
            paciente.Telefono = Convert.ToInt32(txtTel.Text);

            Modalidad modalidad = new Modalidad();
            modalidad.IdModalidad = 1;
            modalidad.NombreModalidad = comboBoxEstudio.Text;
            modalidad.AbreviacionModalidad = "TM";


            SolictudModalidad solicitud = new SolictudModalidad();
            solicitud.IdSolicitudModalidad = 1;
            solicitud.Paciente = paciente;
            solicitud.Modalidad = modalidad;
            solicitud.RequestPhysician = txtMedico.Text;
            solicitud.RequestProcedureDescription = "";
            solicitud.ScheduledProcedureStartDate = dateFechaEstudio.ToString() ;
            solicitud.ScheduledProcedureStartTime =dateTimePicker1.ToString();
            solicitud.RequestProcedurePriority = "LOW";

            MessageBox.Show("Se agrego Exitosamente el agendamiento");
        }

        private void Agendar_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
