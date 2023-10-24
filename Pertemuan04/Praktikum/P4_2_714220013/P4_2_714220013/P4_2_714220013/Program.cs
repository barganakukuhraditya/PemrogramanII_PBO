using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Kendaraan kendaraan1 = new Mobil("Porsche", 2012, 2);
            Kendaraan kendaraan2 = new Motor("KTM", 2020, "Sport");

            kendaraan1.Informasi();
            kendaraan2.Informasi();
        }
    }
}
