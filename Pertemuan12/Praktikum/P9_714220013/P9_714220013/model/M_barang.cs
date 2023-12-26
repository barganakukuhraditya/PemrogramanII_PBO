using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714220013.model
{
    class M_barang
    {
        string nama_barang, harga;
        public M_barang()
        {
        }
        public M_barang(string nama_barang, string harga)
        {
            this.Nama_barang = nama_barang;
            this.Harga = harga;
        }
        public string Nama_barang
        {
            get => nama_barang; set => nama_barang =
       value;
        }
        public string Harga { get => harga; set => harga = value; }
    }

}
