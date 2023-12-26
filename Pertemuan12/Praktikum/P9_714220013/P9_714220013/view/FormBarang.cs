using P9_714220013.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714220013.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;

        public void Tampil()
        {
            string query = "SELECT * FROM t_barang";
            // Query DB
            DataBarang.DataSource = koneksi.ShowData(query);

            // Mengubah nama header table
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }

        public void resetForm()
        {
            tbBarang.Text = "";
            tbHarga.Text = "";
            tbCariData.Text = "";
        }

        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbBarang.Text == "" || (tbBarang.Text).All(Char.IsNumber) || tbHarga.Text == "" || (tbHarga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang brg = new Barang();
                m_barang.Nama_barang = tbBarang.Text;
                m_barang.Harga = tbHarga.Text;

                brg.Insert(m_barang);
                resetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbBarang.Text != "" || !tbBarang.Text.All(Char.IsNumber) || tbHarga.Text != "" || !tbHarga.Text.All(Char.IsLetter))
            {
                Barang brg = new Barang();
                m_barang.Nama_barang = tbBarang.Text;
                m_barang.Harga = tbHarga.Text;

                brg.Update(m_barang, id_barang);
                resetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Barang brg = new Barang();
                brg.Delete(id_barang);
                resetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
            Tampil();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
