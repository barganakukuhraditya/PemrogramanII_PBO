using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil SuatuMobil = new Mobil();
            Mobil MobilSaya = new Mobil() { nama = "Kijang Inova", kecepatan = 0, bensin = 30000, posisi = 0 };
            MobilSaya.maju();
            Console.WriteLine(SuatuMobil.nama);
            Console.WriteLine(SuatuMobil.bensin);

            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);

            Mobil MobilAnda = new Mobil("Volks Wagen", 1000, 50000);
            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilAnda.bensin);

            /* Property Materi*/
            PropertyTest p = new PropertyTest();
            p.Materi = "Bahasa Pemrograman C#";
            Console.WriteLine(p.Materi);

            /* Property Nilai*/
            Person v = new Person();
            v.Nilai = 60;
            Console.WriteLine(v.Nilai);

            /* Inheritance (Kelas Turunan)*/
            Civic c = new Civic();
            Console.WriteLine(c.Roda);
            c.Klakson();
            c.Klakson2();

            //Polymorphism (Sesuatu yg sama dapat memiliki bentuk yg berbeda beda)
            Bentuk bl = new Lingkaran();
            bl.Gambar();
            Bentuk bp = new Persegi();
            bp.Gambar();

        }
        public class Mobil
        {
            public double kecepatan;
            public double bensin;
            public double posisi;
            public string nama;

            public void percepat()
            {
                this.kecepatan += 10;
                this.bensin -= 5;
            }
            public void maju()
            {
                this.posisi += this.kecepatan;
                this.bensin -= 2;
            }
            public void isiBensin(double bensin)
            {
                this.bensin += bensin;
            }



            public Mobil(string nama, double kecepatan, double bensin)
            {
                this.nama = nama;
                this.kecepatan = kecepatan;
                this.bensin = bensin;
                this.posisi = 0;
            }
            public Mobil()
            {
                this.nama = "";
                this.kecepatan = 0;
                this.bensin = 0;
                this.posisi = 0;
            }
        }
    }
}
