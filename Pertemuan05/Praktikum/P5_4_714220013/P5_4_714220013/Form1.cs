using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string kelas = "";

            if(tbNama.Text == "")
            {
                MessageBox.Show("Nama harus diisi!",
                                   "Warning!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbJK.Text != "Laki-laki" && cbJK.Text != "Perempuan")
            {
                MessageBox.Show("Jenis kelamin tidak valid!",
                                            "Warning!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbBiola.Checked)
            {
                kelas += "Biola, ";
            }
            if (cbGitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas += "Piano, ";
            }
            if (cbDrum.Checked)
            {
                kelas += "Drum, ";
            }
            if (cbVokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (cbKomposer.Checked)
            {
                kelas += "Komposer, ";
            }
            
            kelas = kelas.TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(kelas))
            {
                MessageBox.Show("Tolong pilih salah satu atau lebih dari pilihan kelas!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (rb1.Checked == true)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if(rb2.Checked == true)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rb3.Checked == true)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (rb4.Checked == true)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                MessageBox.Show("Harus memilih salah satu jadwal!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Nama : " + tbNama.Text +
                "\nJenis Kelamin : " + cbJK.Text +
                "\nTanggal Lahir : " + dtpTL.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
