using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230056
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Menu Persegi Panjang ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HitungLuas();
                        break;
                    case "2":
                        HitungKeliling();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }

        static void HitungLuas()
        {
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine("Luas persegi panjang: " + luas);

            UlangAtauKembali();
        }

        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);
            Console.WriteLine("Keliling persegi panjang: " + keliling);

            UlangAtauKembali();
        }

        static void UlangAtauKembali()
        {
            Console.Write("Apakah ingin mengulang (Y/T)? ");
            string ulang = Console.ReadLine().ToUpper();

            if (ulang == "T")
            {
                Console.WriteLine("Terima kasih!");
                Environment.Exit(0);
            }
        }
    }
}