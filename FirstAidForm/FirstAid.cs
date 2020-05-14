using FirstAidForm;
using FormPertolongan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormUtama
{
    public partial class FirstAid : Form
    {
        public FirstAid()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            FormPertolongan.FormPertolongan pertolonganForm = new FormPertolongan.FormPertolongan();
            pertolonganForm.ShowDialog();
        }

        private void AmbulansForm_Click(object sender, EventArgs e)
        {
            FormAmbulans.FormAmbulans ambulansForm = new FormAmbulans.FormAmbulans();
            ambulansForm.ShowDialog();
        }

        private void NotesForm_Click(object sender, EventArgs e)
        {
            ProfilNotes.InputProfilNotes profilnoteForm = new ProfilNotes.InputProfilNotes();
            profilnoteForm.ShowDialog();
        }

        private void FirstAid_Load(object sender, EventArgs e)
        {

        }

        private void TbAlergi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPenyakit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbUmur_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbObat_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbKejadian_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbKeluhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbDiagnosa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNafas_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCari_Click(object sender, EventArgs e)
        {
            using (var db = new ProfilNotesModel())
            {
                var query = from ProfilNote in db.ProfilNotes where ProfilNote.Nama == textBoxCari.Text select ProfilNote;
                foreach (var item in query)
                {
                    tbumur.Text = item.Umur.ToString();
                    tbpenyakit.Text = item.Penyakit;
                    tbalergi.Text = item.Alergi;
                    tbobat.Text = item.Obat;
                    tbkejadian.Text = item.Kejadian;
                    tbkeluhan.Text = item.Keluhan;
                    tbdiagnosa.Text = item.Diagnosa;
                    tbnafas.Text = item.Nafas.ToString();
                    tbnadi.Text = item.Nadi.ToString();
                }
            }

        }
    }
}
