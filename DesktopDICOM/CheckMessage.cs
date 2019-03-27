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
    public partial class CheckMessage : Form
    {
      
        public CheckMessage()
        {
            InitializeComponent();
        }     
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ParserService p = new ParserService();
            var model = p.reader2();
          

            for (int i = 0; i < model.Count; i++)
            {

                for (int j = 0; j < model[i].campos.Count; j++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Checked = true;
                    item.Text = model[i].campos[j].nombre + " : " + model[i].campos[j].data;
                    listView1.Items.Add(item);


                }
            }


            listView2.Items.Clear();
            
          
            foreach (var segmento in model)
            {
                ListViewItem item = new ListViewItem();
                item.Text = segmento.errorText;
                listView2.Items.Add(item);
            }


        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParserService p = new ParserService();
            var model = p.reader2();

            Agendar a = new Agendar(model);
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
