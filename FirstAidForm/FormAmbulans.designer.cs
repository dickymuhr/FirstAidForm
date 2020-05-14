namespace FormAmbulans
{
    partial class FormAmbulans
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
            this.labeldaerah = new System.Windows.Forms.Label();
            this.textBoxkecamatan = new System.Windows.Forms.TextBox();
            this.buttoncari = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeldaerah
            // 
            this.labeldaerah.AutoSize = true;
            this.labeldaerah.Location = new System.Drawing.Point(23, 16);
            this.labeldaerah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldaerah.Name = "labeldaerah";
            this.labeldaerah.Size = new System.Drawing.Size(92, 13);
            this.labeldaerah.TabIndex = 0;
            this.labeldaerah.Text = "Nama Kecamatan";
            // 
            // textBoxkecamatan
            // 
            this.textBoxkecamatan.Location = new System.Drawing.Point(25, 38);
            this.textBoxkecamatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxkecamatan.Name = "textBoxkecamatan";
            this.textBoxkecamatan.Size = new System.Drawing.Size(212, 20);
            this.textBoxkecamatan.TabIndex = 1;
            // 
            // buttoncari
            // 
            this.buttoncari.Location = new System.Drawing.Point(251, 36);
            this.buttoncari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoncari.Name = "buttoncari";
            this.buttoncari.Size = new System.Drawing.Size(93, 21);
            this.buttoncari.TabIndex = 2;
            this.buttoncari.Text = "Cari";
            this.buttoncari.UseVisualStyleBackColor = true;
            this.buttoncari.Click += new System.EventHandler(this.Buttoncari_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama RS/Puskesmas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasil Pencarian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nomor Telp. Ambulans:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 114);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tutup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormAmbulans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttoncari);
            this.Controls.Add(this.textBoxkecamatan);
            this.Controls.Add(this.labeldaerah);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAmbulans";
            this.Text = "Form Ambulans";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldaerah;
        private System.Windows.Forms.TextBox textBoxkecamatan;
        private System.Windows.Forms.Button buttoncari;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

