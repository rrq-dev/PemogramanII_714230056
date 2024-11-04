using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230056
{
   class ProducTest_714230056
    {
        static void Main(string[] args)
        {
            Book_714230056 product1 = new Book_714230056("Book", "C# Object Oriented Solution", "300");
            DVD_714230056 product2 = new DVD_714230056("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
