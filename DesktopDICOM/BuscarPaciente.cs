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
    public partial class BuscarPaciente : Form
    {
        public string hola;
        
        public BuscarPaciente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioDICOM servicioDICOM = new ServicioDICOM();
            String dato = txtNombre.Text;
            string result = servicioDICOM.RealizarConsultaDICOM(dato);
            textBox1.Text = result;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
