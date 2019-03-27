using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDICOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarMensaje_Click(object sender, EventArgs e)
        {
            CheckMessage c = new CheckMessage();
            c.Show();
        }

        private void AgendarSolictud_Click(object sender, EventArgs e)
        {
            //Agendar a = new Agendar(List < Segmento > model);
            //a.Show();
        }

        private void BuscarPaciente_Click(object sender, EventArgs e)
        {

            //ServicioDICOM p = new ServicioDICOM();
            //string hola = p.RealizarConsultaDICOM();
            BuscarPaciente bp = new BuscarPaciente();
            bp.Show();
        }
    }
}
