using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators
            Console.WriteLine("Masukan Angka Pertama :");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Angka Kedua :");
            int angka2 = Convert.ToInt32 (Console.ReadLine());

            int penjumlahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);

            int pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);

            int perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);

           double pembagian = (double)angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);


        }
    }
}
