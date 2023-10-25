using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            // variabel
            string os = "";
            string status = "";

            if (rb_android.Checked == true) //value rb_android
            {
                os = "Android";
            }
            else if(rb_ios.Checked == true) //value rb_ios
            {
                os = "iOS";
            }

            if (cbYa.Checked == true) //vallue cbYa
            {
                status = "Ya, sudah diperbaiki";
            }

            MessageBox.Show(
                "Merk HP : " + txtMerkHP.Text +
                "\nSistem Operasi : " + os +
                "\nStatus Perbaikan : " + status,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
