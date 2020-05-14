namespace FormUtama
{
    partial class FirstAid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PertolonganForm = new System.Windows.Forms.Button();
            this.ambulansForm = new System.Windows.Forms.Button();
            this.notesForm = new System.Windows.Forms.Button();
            this.tbumur = new System.Windows.Forms.TextBox();
            this.tbpenyakit = new System.Windows.Forms.TextBox();
            this.tbalergi = new System.Windows.Forms.TextBox();
            this.tbnadi = new System.Windows.Forms.TextBox();
            this.tbnafas = new System.Windows.Forms.TextBox();
            this.tbdiagnosa = new System.Windows.Forms.TextBox();
            this.tbkeluhan = new System.Windows.Forms.TextBox();
            this.tbkejadian = new System.Windows.Forms.TextBox();
            this.tbobat = new System.Windows.Forms.TextBox();
            this.lblUmur = new System.Windows.Forms.Label();
            this.lblPenyakit = new System.Windows.Forms.Label();
            this.lblAlergi = new System.Windows.Forms.Label();
            this.lblKejadian = new System.Windows.Forms.Label();
            this.lblKeluhan = new System.Windows.Forms.Label();
            this.lblObat = new System.Windows.Forms.Label();
            this.lblDiagnosa = new System.Windows.Forms.Label();
            this.lblNafas = new System.Windows.Forms.Label();
            this.lblNadi = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PertolonganForm
            // 
            this.PertolonganForm.Location = new System.Drawing.Point(12, 209);
            this.PertolonganForm.Name = "PertolonganForm";
            this.PertolonganForm.Size = new System.Drawing.Size(131, 55);
            this.PertolonganForm.TabIndex = 0;
            this.PertolonganForm.Text = "Panduan Pertolongan";
            this.PertolonganForm.UseVisualStyleBackColor = true;
            this.PertolonganForm.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ambulansForm
            // 
            this.ambulansForm.Location = new System.Drawing.Point(149, 209);
            this.ambulansForm.Name = "ambulansForm";
            this.ambulansForm.Size = new System.Drawing.Size(144, 55);
            this.ambulansForm.TabIndex = 1;
            this.ambulansForm.Text = "Ambulance";
            this.ambulansForm.UseVisualStyleBackColor = true;
            this.ambulansForm.Click += new System.EventHandler(this.AmbulansForm_Click);
            // 
            // notesForm
            // 
            this.notesForm.Location = new System.Drawing.Point(299, 209);
            this.notesForm.Name = "notesForm";
            this.notesForm.Size = new System.Drawing.Size(133, 55);
            this.notesForm.TabIndex = 2;
            this.notesForm.Text = "Notes";
            this.notesForm.UseVisualStyleBackColor = true;
            this.notesForm.Click += new System.EventHandler(this.NotesForm_Click);
            // 
            // tbumur
            // 
            this.tbumur.Location = new System.Drawing.Point(88, 91);
            this.tbumur.Margin = new System.Windows.Forms.Padding(2);
            this.tbumur.Name = "tbumur";
            this.tbumur.ReadOnly = true;
            this.tbumur.Size = new System.Drawing.Size(125, 20);
            this.tbumur.TabIndex = 60;
            this.tbumur.TextChanged += new System.EventHandler(this.TbUmur_TextChanged);
            // 
            // tbpenyakit
            // 
            this.tbpenyakit.Location = new System.Drawing.Point(88, 116);
            this.tbpenyakit.Margin = new System.Windows.Forms.Padding(2);
            this.tbpenyakit.Name = "tbpenyakit";
            this.tbpenyakit.ReadOnly = true;
            this.tbpenyakit.Size = new System.Drawing.Size(125, 20);
            this.tbpenyakit.TabIndex = 59;
            this.tbpenyakit.TextChanged += new System.EventHandler(this.TbPenyakit_TextChanged);
            // 
            // tbalergi
            // 
            this.tbalergi.Location = new System.Drawing.Point(88, 143);
            this.tbalergi.Margin = new System.Windows.Forms.Padding(2);
            this.tbalergi.Name = "tbalergi";
            this.tbalergi.ReadOnly = true;
            this.tbalergi.Size = new System.Drawing.Size(125, 20);
            this.tbalergi.TabIndex = 58;
            this.tbalergi.TextChanged += new System.EventHandler(this.TbAlergi_TextChanged);
            // 
            // tbnadi
            // 
            this.tbnadi.Location = new System.Drawing.Point(300, 169);
            this.tbnadi.Margin = new System.Windows.Forms.Padding(2);
            this.tbnadi.Name = "tbnadi";
            this.tbnadi.ReadOnly = true;
            this.tbnadi.Size = new System.Drawing.Size(82, 20);
            this.tbnadi.TabIndex = 57;
            this.tbnadi.TextChanged += new System.EventHandler(this.TbNadi_TextChanged);
            // 
            // tbnafas
            // 
            this.tbnafas.Location = new System.Drawing.Point(300, 144);
            this.tbnafas.Margin = new System.Windows.Forms.Padding(2);
            this.tbnafas.Name = "tbnafas";
            this.tbnafas.ReadOnly = true;
            this.tbnafas.Size = new System.Drawing.Size(82, 20);
            this.tbnafas.TabIndex = 56;
            this.tbnafas.TextChanged += new System.EventHandler(this.TbNafas_TextChanged);
            // 
            // tbdiagnosa
            // 
            this.tbdiagnosa.Location = new System.Drawing.Point(300, 118);
            this.tbdiagnosa.Margin = new System.Windows.Forms.Padding(2);
            this.tbdiagnosa.Name = "tbdiagnosa";
            this.tbdiagnosa.ReadOnly = true;
            this.tbdiagnosa.Size = new System.Drawing.Size(132, 20);
            this.tbdiagnosa.TabIndex = 55;
            this.tbdiagnosa.TextChanged += new System.EventHandler(this.TbDiagnosa_TextChanged);
            // 
            // tbkeluhan
            // 
            this.tbkeluhan.Location = new System.Drawing.Point(300, 92);
            this.tbkeluhan.Margin = new System.Windows.Forms.Padding(2);
            this.tbkeluhan.Name = "tbkeluhan";
            this.tbkeluhan.ReadOnly = true;
            this.tbkeluhan.Size = new System.Drawing.Size(132, 20);
            this.tbkeluhan.TabIndex = 54;
            this.tbkeluhan.TextChanged += new System.EventHandler(this.TbKeluhan_TextChanged);
            // 
            // tbkejadian
            // 
            this.tbkejadian.Location = new System.Drawing.Point(300, 68);
            this.tbkejadian.Margin = new System.Windows.Forms.Padding(2);
            this.tbkejadian.Name = "tbkejadian";
            this.tbkejadian.ReadOnly = true;
            this.tbkejadian.Size = new System.Drawing.Size(132, 20);
            this.tbkejadian.TabIndex = 53;
            this.tbkejadian.TextChanged += new System.EventHandler(this.TbKejadian_TextChanged);
            // 
            // tbobat
            // 
            this.tbobat.Location = new System.Drawing.Point(88, 168);
            this.tbobat.Margin = new System.Windows.Forms.Padding(2);
            this.tbobat.Name = "tbobat";
            this.tbobat.ReadOnly = true;
            this.tbobat.Size = new System.Drawing.Size(125, 20);
            this.tbobat.TabIndex = 52;
            this.tbobat.TextChanged += new System.EventHandler(this.TbObat_TextChanged);
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Location = new System.Drawing.Point(14, 95);
            this.lblUmur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(32, 13);
            this.lblUmur.TabIndex = 50;
            this.lblUmur.Text = "Umur";
            // 
            // lblPenyakit
            // 
            this.lblPenyakit.AutoSize = true;
            this.lblPenyakit.Location = new System.Drawing.Point(14, 120);
            this.lblPenyakit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPenyakit.Name = "lblPenyakit";
            this.lblPenyakit.Size = new System.Drawing.Size(48, 13);
            this.lblPenyakit.TabIndex = 49;
            this.lblPenyakit.Text = "Penyakit";
            // 
            // lblAlergi
            // 
            this.lblAlergi.AutoSize = true;
            this.lblAlergi.Location = new System.Drawing.Point(14, 147);
            this.lblAlergi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlergi.Name = "lblAlergi";
            this.lblAlergi.Size = new System.Drawing.Size(33, 13);
            this.lblAlergi.TabIndex = 48;
            this.lblAlergi.Text = "Alergi";
            // 
            // lblKejadian
            // 
            this.lblKejadian.AutoSize = true;
            this.lblKejadian.Location = new System.Drawing.Point(226, 72);
            this.lblKejadian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKejadian.Name = "lblKejadian";
            this.lblKejadian.Size = new System.Drawing.Size(51, 13);
            this.lblKejadian.TabIndex = 47;
            this.lblKejadian.Text = "Kronologi";
            // 
            // lblKeluhan
            // 
            this.lblKeluhan.AutoSize = true;
            this.lblKeluhan.Location = new System.Drawing.Point(226, 96);
            this.lblKeluhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeluhan.Name = "lblKeluhan";
            this.lblKeluhan.Size = new System.Drawing.Size(46, 13);
            this.lblKeluhan.TabIndex = 46;
            this.lblKeluhan.Text = "Keluhan";
            // 
            // lblObat
            // 
            this.lblObat.AutoSize = true;
            this.lblObat.Location = new System.Drawing.Point(14, 172);
            this.lblObat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObat.Name = "lblObat";
            this.lblObat.Size = new System.Drawing.Size(30, 13);
            this.lblObat.TabIndex = 45;
            this.lblObat.Text = "Obat";
            // 
            // lblDiagnosa
            // 
            this.lblDiagnosa.AutoSize = true;
            this.lblDiagnosa.Location = new System.Drawing.Point(226, 122);
            this.lblDiagnosa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnosa.Name = "lblDiagnosa";
            this.lblDiagnosa.Size = new System.Drawing.Size(52, 13);
            this.lblDiagnosa.TabIndex = 44;
            this.lblDiagnosa.Text = "Diagnosa";
            // 
            // lblNafas
            // 
            this.lblNafas.AutoSize = true;
            this.lblNafas.Location = new System.Drawing.Point(226, 148);
            this.lblNafas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNafas.Name = "lblNafas";
            this.lblNafas.Size = new System.Drawing.Size(35, 13);
            this.lblNafas.TabIndex = 43;
            this.lblNafas.Text = "Nafas";
            // 
            // lblNadi
            // 
            this.lblNadi.AutoSize = true;
            this.lblNadi.Location = new System.Drawing.Point(226, 173);
            this.lblNadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNadi.Name = "lblNadi";
            this.lblNadi.Size = new System.Drawing.Size(29, 13);
            this.lblNadi.TabIndex = 42;
            this.lblNadi.Text = "Nadi";
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(18, 31);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(257, 20);
            this.textBoxCari.TabIndex = 61;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(296, 31);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(133, 23);
            this.buttonCari.TabIndex = 62;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.ButtonCari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Pencarian Berdasar Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "/menit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "/menit";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(14, 67);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(59, 16);
            this.lblNama.TabIndex = 41;
            this.lblNama.Text = "Riwayat:";
            // 
            // FirstAid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.tbumur);
            this.Controls.Add(this.tbpenyakit);
            this.Controls.Add(this.tbalergi);
            this.Controls.Add(this.tbnadi);
            this.Controls.Add(this.tbnafas);
            this.Controls.Add(this.tbdiagnosa);
            this.Controls.Add(this.tbkeluhan);
            this.Controls.Add(this.tbkejadian);
            this.Controls.Add(this.tbobat);
            this.Controls.Add(this.lblUmur);
            this.Controls.Add(this.lblPenyakit);
            this.Controls.Add(this.lblAlergi);
            this.Controls.Add(this.lblKejadian);
            this.Controls.Add(this.lblKeluhan);
            this.Controls.Add(this.lblObat);
            this.Controls.Add(this.lblDiagnosa);
            this.Controls.Add(this.lblNafas);
            this.Controls.Add(this.lblNadi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.notesForm);
            this.Controls.Add(this.ambulansForm);
            this.Controls.Add(this.PertolonganForm);
            this.Name = "FirstAid";
            this.Text = "First Aid";
            this.Load += new System.EventHandler(this.FirstAid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PertolonganForm;
        private System.Windows.Forms.Button ambulansForm;
        private System.Windows.Forms.Button notesForm;
        private System.Windows.Forms.TextBox tbumur;
        private System.Windows.Forms.TextBox tbpenyakit;
        private System.Windows.Forms.TextBox tbalergi;
        private System.Windows.Forms.TextBox tbnadi;
        private System.Windows.Forms.TextBox tbnafas;
        private System.Windows.Forms.TextBox tbdiagnosa;
        private System.Windows.Forms.TextBox tbkeluhan;
        private System.Windows.Forms.TextBox tbkejadian;
        private System.Windows.Forms.TextBox tbobat;
        private System.Windows.Forms.Label lblUmur;
        private System.Windows.Forms.Label lblPenyakit;
        private System.Windows.Forms.Label lblAlergi;
        private System.Windows.Forms.Label lblKejadian;
        private System.Windows.Forms.Label lblKeluhan;
        private System.Windows.Forms.Label lblObat;
        private System.Windows.Forms.Label lblDiagnosa;
        private System.Windows.Forms.Label lblNafas;
        private System.Windows.Forms.Label lblNadi;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNama;
    }
}

