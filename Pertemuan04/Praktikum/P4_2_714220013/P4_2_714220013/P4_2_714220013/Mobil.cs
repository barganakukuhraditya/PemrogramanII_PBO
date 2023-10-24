using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220013
{
    // Inheritance
    public class Mobil : Kendaraan
    {
        private int jumlahPintu;

        // Constructor
        public Mobil(string merek, int tahunProduksi, int jumlahPintu) : base(merek, tahunProduksi)
        {
            this.jumlahPintu = jumlahPintu;
        }

        // Property
        public int JumlahPintu
        {
            get { return jumlahPintu; }
            set { jumlahPintu = value; }
        }

        // Method
        public override void Informasi()
        {
            Console.WriteLine($"\nMobil \"{Merek}\" {jumlahPintu} pintu, diproduksi pada tahun \"{TahunProduksi}\".");
        }
    }
}
