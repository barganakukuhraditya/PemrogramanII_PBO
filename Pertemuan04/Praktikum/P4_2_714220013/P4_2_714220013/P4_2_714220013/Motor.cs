using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220013
{
    // Inheritance
    public class Motor : Kendaraan
    {
        private string jenis;

        // Constructor
        public Motor(string merek, int tahunProduksi, string jenis) : base(merek, tahunProduksi)
        {
            this.jenis = jenis;
        }

        // Property
        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        // Method
        public override void Informasi()
        {
            Console.WriteLine($"\nMotor \"{Merek}\" dengan jenis \"{Jenis}\", diproduksi pada tahun \"{TahunProduksi}\".\n");
        }
    }
}
