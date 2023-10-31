namespace P5_4_714220013
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtpTL = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(393, 77);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(180, 20);
            this.tbNama.TabIndex = 3;
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbJK.Location = new System.Drawing.Point(393, 111);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(121, 21);
            this.cbJK.TabIndex = 4;
            this.cbJK.Text = "--Pilih Jenis Kelamin--";
            // 
            // dtpTL
            // 
            this.dtpTL.Location = new System.Drawing.Point(393, 144);
            this.dtpTL.Name = "dtpTL";
            this.dtpTL.Size = new System.Drawing.Size(200, 20);
            this.dtpTL.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.cbKomposer);
            this.groupBox1.Controls.Add(this.cbVokal);
            this.groupBox1.Controls.Add(this.cbDrum);
            this.groupBox1.Controls.Add(this.cbPiano);
            this.groupBox1.Controls.Add(this.cbKonduktor);
            this.groupBox1.Controls.Add(this.cbSaxophone);
            this.groupBox1.Controls.Add(this.cbGitar);
            this.groupBox1.Controls.Add(this.cbBiola);
            this.groupBox1.Location = new System.Drawing.Point(121, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(145, 139);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(73, 17);
            this.cbKomposer.TabIndex = 7;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(145, 103);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(53, 17);
            this.cbVokal.TabIndex = 6;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(145, 68);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(51, 17);
            this.cbDrum.TabIndex = 5;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(145, 33);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 4;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(29, 139);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(75, 17);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(29, 103);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(80, 17);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(29, 68);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(48, 17);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(29, 33);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(49, 17);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.rb4);
            this.groupBox2.Controls.Add(this.rb3);
            this.groupBox2.Controls.Add(this.rb2);
            this.groupBox2.Controls.Add(this.rb1);
            this.groupBox2.Location = new System.Drawing.Point(417, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 180);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(12, 139);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(129, 17);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "Minggu, 13.00 - 17.00";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(12, 103);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(169, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(12, 68);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(166, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(12, 33);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(159, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(306, 390);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 8;
            this.btnTampilkan.Text = "&Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(417, 390);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "S&elesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTL);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "ASTRA MUSIC SCHOOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtpTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label4;
    }
}

