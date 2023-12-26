using MySql.Data.MySqlClient;
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
    public partial class FormTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksi_barang mtb = new M_transaksi_barang();
        M_barang mb = new M_barang();
        string id_transaksi;

        public void Tampil()
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "Qty";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }

        public void resetForm()
        {
            cbID.SelectedIndex = -1;
            tbBarang.Text = "";
            tbHarga.Text = "";
            tbQty.Text = "";
            tbTotal.Text = "";
            tbCariData.Text = "";
        }

        public FormTransaksiBarang()
        {
            InitializeComponent();
            tbBarang.ReadOnly = true;
            tbBarang.Enabled = false;
            tbHarga.Enabled = false;
            tbHarga.ReadOnly = true;
            tbTotal.Enabled = false;
            tbTotal.ReadOnly = true;

            LoadIdBarang();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void GetDataBarang(int selectIdBarang)
        {
            koneksi.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = koneksi.reader(query);

            if (reader.Read())
            {
                tbBarang.Text = reader["nama_barang"].ToString();
                tbHarga.Text = reader["harga"].ToString();
            }

            reader.Close();
            koneksi.CloseConnection();
        }

        private void TotalHarga()
        {
            if (double.TryParse(tbQty.Text, out double qty_barang) && double.TryParse(tbHarga.Text.Replace(".", ""), out double harga_barang))
            {
                double total = qty_barang * harga_barang;

                string formattedTotal = string.Format("{0:#,##0}", total);

                tbTotal.Text = formattedTotal;
            }
        }

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        public void LoadIdBarang()
        {
            koneksi.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = koneksi.ShowData(query);

            cbID.DisplayMember = "id_barang";
            cbID.ValueMember = "id_barang";
            cbID.DataSource = dataTable;

            koneksi.CloseConnection();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex == -1 || tbBarang.Text == "" || tbHarga.Text == "" || tbQty.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang tb = new TransaksiBarang();
                mtb.Id_barang = cbID.SelectedValue.ToString();
                mtb.Qty = tbQty.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(".", "");

                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    mtb.Total = numericTotal.ToString();
                }

                tb.Insert(mtb);
                resetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex != -1 && tbBarang.Text != "" && tbHarga.Text != "" && tbQty.Text != "" && tbTotal.Text != "")
            {
                TransaksiBarang tb = new TransaksiBarang();
                mtb.Id_barang = cbID.SelectedValue.ToString(); // Ubah ini menjadi id_barang dari combo box
                mtb.Qty = tbQty.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(".", "");

                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    mtb.Total = numericTotal.ToString();
                }

                tb.Update(mtb, id_transaksi);
                resetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Perhatian",
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
                brg.Delete(id_transaksi);
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
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbID.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHarga.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQty.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                e.Value = FormatDigitAngka(number);
                e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            FormatDigit(tbHarga);
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex != -1)
            {
                int selectIdBarang;
                if (int.TryParse(cbID.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }
    }
}
