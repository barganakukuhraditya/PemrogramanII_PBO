namespace P6_4_714220013
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtND = new System.Windows.Forms.TextBox();
            this.txtNB = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.dtpTgl = new System.Windows.Forms.DateTimePicker();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTamu = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpWaktu = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Tamu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reservasi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jenis Reservasi";
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(153, 74);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(130, 20);
            this.txtND.TabIndex = 6;
            this.txtND.Leave += new System.EventHandler(this.txtND_Leave);
            // 
            // txtNB
            // 
            this.txtNB.Location = new System.Drawing.Point(328, 74);
            this.txtNB.Name = "txtNB";
            this.txtNB.Size = new System.Drawing.Size(130, 20);
            this.txtNB.TabIndex = 7;
            this.txtNB.Leave += new System.EventHandler(this.txtNB_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(154, 198);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(200, 20);
            this.txtTelp.TabIndex = 9;
            this.txtTelp.Leave += new System.EventHandler(this.txtTelp_Leave);
            // 
            // dtpTgl
            // 
            this.dtpTgl.Location = new System.Drawing.Point(154, 320);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(200, 20);
            this.dtpTgl.TabIndex = 11;
            // 
            // cbJenis
            // 
            this.cbJenis.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Items.AddRange(new object[] {
            "Hiburan",
            "Lainnya",
            "Makan Malam",
            "Pernikahan",
            "Pribadi",
            "Ulang Tahun",
            "VIP"});
            this.cbJenis.Location = new System.Drawing.Point(154, 386);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(121, 21);
            this.cbJenis.TabIndex = 12;
            this.cbJenis.Text = "Please Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(198, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "RESERVASI RESTORAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nama Depan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nama Belakang";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(291, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTamu
            // 
            this.txtTamu.Location = new System.Drawing.Point(153, 259);
            this.txtTamu.Name = "txtTamu";
            this.txtTamu.Size = new System.Drawing.Size(57, 20);
            this.txtTamu.TabIndex = 18;
            this.txtTamu.Leave += new System.EventHandler(this.txtTamu_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // dtpWaktu
            // 
            this.dtpWaktu.CustomFormat = "HH:mm";
            this.dtpWaktu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWaktu.Location = new System.Drawing.Point(380, 320);
            this.dtpWaktu.Name = "dtpWaktu";
            this.dtpWaktu.Size = new System.Drawing.Size(92, 20);
            this.dtpWaktu.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(656, 498);
            this.Controls.Add(this.dtpWaktu);
            this.Controls.Add(this.txtTamu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.dtpTgl);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNB);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulir Reservasi Restoran";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.TextBox txtNB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.DateTimePicker dtpTgl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTamu;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.DateTimePicker dtpWaktu;
    }
}

