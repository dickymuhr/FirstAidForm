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

namespace ProfilNotes
{
    public partial class InputProfilNotes : Form
    {

        public enum Mode { Insert }
        
        public ProfilNote newProfilNote;

        public InputProfilNotes()
        {
            InitializeComponent();
            
        }
        private void TambahData()
        {
            if (tbNama.Text != "" && tbKejadian.Text != "" && tbKeluhan.Text != "")
            {
                using (var db = new ProfilNotesModel())
                {
                    newProfilNote = new ProfilNote
                    {
                        Nama = tbNama.Text,
                        Umur = Convert.ToInt32(tbUmur.Text),
                        Penyakit = tbPenyakit.Text,
                        Alergi = tbAlergi.Text,
                        Obat = tbObat.Text,
                        Kejadian = tbKejadian.Text,
                        Keluhan = tbKeluhan.Text,
                        Diagnosa = tbDiagnosa.Text,
                        Nafas = Convert.ToInt32(tbNafas.Text)*4,
                        Nadi = Convert.ToInt32(tbNadi.Text)*4,
                    };
                    db.ProfilNotes.Add(newProfilNote);
                    db.SaveChanges();

                    
                    MessageBox.Show("ProfilNotes ditambahkan");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nama, kejadian, dan keluhan harus diisi");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            
                TambahData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbNafas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
