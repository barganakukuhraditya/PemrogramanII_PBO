using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220013
{
    public class Kendaraan
    {   // Field
        private string merek;
        private int tahunProduksi;

        // Constructor
        public Kendaraan(string merek, int tahunProduksi)
        {
            this.merek = merek;
            this.tahunProduksi = tahunProduksi;
        }

        // Property
        public string Merek
        {
            get { return merek; }
            set { merek = value; }
        }

        public int TahunProduksi
        {
            get { return tahunProduksi; }
            set { tahunProduksi = value; }
        }

        // Method
        public virtual void Informasi()
        {
            Console.WriteLine($"Sepeda motor {Merek} diproduksi tahun {TahunProduksi}");
        }
    }
}
