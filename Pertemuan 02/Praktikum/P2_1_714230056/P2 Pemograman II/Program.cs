using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Pemograman_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            // Input angka pertama
            Console.Write("Masukkan angka pertama: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Input angka kedua
            Console.Write("Masukkan angka kedua: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));





        }
    }
}
