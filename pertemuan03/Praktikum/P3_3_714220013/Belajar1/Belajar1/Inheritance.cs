using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar1
{
    /* Inheritance (kelas turunan)*/
    internal class Inheritance
    {
    }

    public class Car
    {
        public int Roda { get; set; }
        public int Tahun { get; set; }

        public void Klakson2()
        {
            Console.WriteLine("TOTTTT...!!!");
        }
    }

    /* nama kelas turunan : nama kelas yang ingin diturunkan*/
    class Civic : Car
    {
        public Civic()
        {
            Roda = 4;
        }
        public void Klakson()
        {
            Console.Write("TETTTT...!!!");
        }
    }
}
