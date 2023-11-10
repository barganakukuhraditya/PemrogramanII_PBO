using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P6_4_714220013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtND_Leave(object sender, EventArgs e)
        {
            String inputText = txtND.Text;

            if (String.IsNullOrEmpty(inputText))
            {
                epWarning.SetError(txtND, "Nama Depan tidak boleh kosong!");
                epError.SetError(txtND, "");
                epCorrect.SetError(txtND, "");
            }
            else
            {
                if (char.IsUpper(inputText[0]) && inputText.Substring(1).All(Char.IsLetter))
                {
                    epWarning.SetError(txtND, "");
                    epError.SetError(txtND, "");
                    epCorrect.SetError(txtND, "Benar!");
                }
                else
                {
                    epWarning.SetError(txtND, "");
                    epError.SetError(txtND, "Harus diawali dengan huruf kapital dan hanya berisi huruf!");
                    epWarning.SetError(txtND, "");
                }
            }
        }

        private void txtNB_Leave(object sender, EventArgs e)
        {
            String inputText = txtNB.Text;

            if (String.IsNullOrEmpty(inputText))
            {
                epWarning.SetError(txtNB, "Nama Belakang tidak boleh kosong!");
                epError.SetError(txtNB, "");
                epCorrect.SetError(txtNB, "");
            }
            else
            {
                if (char.IsUpper(inputText[0]) && inputText.Substring(1).All(Char.IsLetter))
                {
                    epWarning.SetError(txtNB, "");
                    epError.SetError(txtNB, "");
                    epCorrect.SetError(txtNB, "Benar!");
                }
                else
                {
                    epWarning.SetError(txtNB, "");
                    epError.SetError(txtNB, "Harus diawali dengan huruf kapital dan hanya berisi huruf!");
                    epCorrect.SetError(txtNB, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            String inputEmail = txtEmail.Text;

            if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && Char.IsLower(inputEmail[0]))
            {
                epWarning.SetError(txtEmail, "");
                epError.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Benar!");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && Char.IsUpper(inputEmail[0]))
                {
                    epWarning.SetError(txtEmail, "Email harus berisikan huruf kecil semua!\nContoh: a@b.c");
                    epError.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
                else
                {
                    epWarning.SetError(txtEmail, "");
                    epError.SetError(txtEmail, "Email tidak boleh kosong!");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtTelp_Leave(object sender, EventArgs e)
        {
            if (txtTelp.Text == "")
            {
                epWarning.SetError(txtTelp, "Nomor Telepon tidak boleh kosong!");
                epError.SetError(txtTelp, "");
                epCorrect.SetError(txtTelp, "");
            }
            else
            {
                if ((txtTelp.Text).All(Char.IsNumber))
                {
                    if (txtTelp.Text.Length >= 10 && txtTelp.Text.Length <= 13)
                    {
                        epWarning.SetError(txtTelp, "");
                        epError.SetError(txtTelp, "");
                        epCorrect.SetError(txtTelp, "Benar!");
                    }
                    else
                    {
                        epWarning.SetError(txtTelp, "Nomor Telepon harus memiliki setidaknya 10 digit!\nMax 13 digit.");
                        epError.SetError(txtTelp, "");
                        epCorrect.SetError(txtTelp, "");
                    }
                }
                else
                {
                    epWarning.SetError(txtTelp, "");
                    epError.SetError(txtTelp, "Nomor Telepon tidak valid!\nInputan hanya boleh angka.");
                    epCorrect.SetError(txtTelp, "");
                }
            }
        }

        private void txtTamu_Leave(object sender, EventArgs e)
        {
            int inputTamu = Convert.ToInt32(txtTamu.Text);

            if (txtTamu.Text == "")
            {
                epWarning.SetError(txtTamu, "Harus Mengisi Jumlah Tamu!");
                epError.SetError(txtTamu, "");
                epCorrect.SetError(txtTamu, "");
            }
            else
            {
                if ((txtTamu.Text).All(Char.IsNumber))
                {
                    if (inputTamu >= 4)
                    {
                        epWarning.SetError(txtTamu, "");
                        epError.SetError(txtTamu, "");
                        epCorrect.SetError(txtTamu, "Benar!");
                    }
                    else
                    {
                        epWarning.SetError(txtTamu, "Mohon Maaf, Tamu harus lebih dari 4 orang ya:)");
                        epError.SetError(txtTamu, "");
                        epCorrect.SetError(txtTamu, "");
                    }
                }
                else
                {
                    epWarning.SetError(txtTamu, "");
                    epError.SetError(txtTamu, "Jumlah Tamu tidak Valid!\nInputan hanya boleh angka.");
                    epCorrect.SetError(txtTamu, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtND.Text == "")
            {
                MessageBox.Show("Nama Depan harus diisi!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtND.Text).All(Char.IsNumber))
            {
                MessageBox.Show("Nama Depan tidak boleh mengandung angka!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNB.Text == "")
            {
                MessageBox.Show("Nama Belakang harus diisi!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtNB.Text).All(Char.IsNumber))
            {
                MessageBox.Show("Nama Belakang tidak boleh mengandung angka!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("E-mail harus diisi!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelp.Text == "")
            {
                MessageBox.Show("Nomor Telepon harus diisi!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtTelp.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Nomor Telepon harus berisikan angka!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTamu.Text == "")
            {
                MessageBox.Show("Jumlah Tamu harus diisi!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtTamu.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Jumlah Tamu harus berisikan angka!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbJenis.Text != "Hiburan" && cbJenis.Text != "Makan Malam" && cbJenis.Text != "Pernikahan" && cbJenis.Text != "Pernikahan" && cbJenis.Text != "Ulang Tahun" && cbJenis.Text != "Pribadi" && cbJenis.Text != "VIP" && cbJenis.Text != "Lainnya")
            {
                MessageBox.Show("Jenis Reservasi tidak valid!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama : " + txtND.Text + txtNB.Text +
                "\nE-mail : " + txtEmail.Text +
                "\nTelepon : " + txtTelp.Text +
                "\nJumlah Tamu : " + txtTamu.Text +
                "\nTanggal & Waktu Reservasi : " + dtpTgl.Text + ", " + dtpWaktu.Text +
                "\nJenis Reservasi : " + cbJenis.Text,
                "Informasi Reservasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
