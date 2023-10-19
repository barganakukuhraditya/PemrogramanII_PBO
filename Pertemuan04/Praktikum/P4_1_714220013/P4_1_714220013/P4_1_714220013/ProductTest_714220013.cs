using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220013
{
    class ProductTest_714220013
    {
        static void Main(string[] args)
        {
            Book_714220013 product1 = new Book_714220013("Book", "C# Object Oriented Solution", "300");
            DVD_714220013 product2 = new DVD_714220013("Ethernal Sunshin Of The Spotless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
