using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstAidForm;

namespace FormAmbulans
{
    public partial class FormAmbulans : Form
    {
        public FormAmbulans()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Buttoncari_Click(object sender, EventArgs e)
        {
            using (var ch = new DataRSPuskesmasEntities())
            {
                var query = from Table in ch.Tables where Table.Alamat == textBoxkecamatan.Text select Table;
                foreach (var item in query)
                {
                    textBox1.Text = item.Nama;
                    textBox2.Text = item.No_Telp;
                }
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    MessageBox.Show("Data ditemukan");
                }
                else
                {
                    MessageBox.Show("Data tidak dapat ditemukan");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
