using FirstAidForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPertolongan
{
    public partial class FormPertolongan : Form
    {
        public FormPertolongan()
        {
            
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Pertolongan_Load(object sender, EventArgs e)
        {

        }

        private void TbCari_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void BtCari_Click(object sender, EventArgs e)
        {
            using (var db = new PertolonganEntities())
            {
                var query = from TablePertolongan in db.TablePertolongans where TablePertolongan.Kasus == tbCari.Text select TablePertolongan;
                foreach (var item in query)
                {
                    tbGejala.Text = item.Gejala;
                    tbPertolongan.Text = item.Penanganan;
                }
                if (tbGejala.Text != "" && tbPertolongan.Text != "")
                {
                    MessageBox.Show("Data ditemukan!");
                }
                else
                {
                    MessageBox.Show("Data belum tersedia!");
                }
            }
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
