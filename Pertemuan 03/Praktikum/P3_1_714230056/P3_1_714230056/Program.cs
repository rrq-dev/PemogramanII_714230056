using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714230056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("Menentukan indeks prestasi mahasiswa\n ------------------------------------");
                Console.Write("\nMasukan nama mahasiswa: ");

                String nama = Console.ReadLine();

                Console.WriteLine("Masukan nilai: ");

                int nilai = Convert.ToInt16(Console.ReadLine());
                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\nMasukan indeks yang di tampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\nIngin mengulang kembali(Y / N) ?");
            }
            while (Console.ReadLine() == "Y");
        }

        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Good Job mas!");
                    break;

                case 'B':
                    Console.WriteLine("Good mas");
                    break;

                case 'C':
                    Console.WriteLine("Cukup mas");
                    break;

                case 'D':
                    Console.WriteLine("Buruk mas");
                    break;

                default:
                    Console.WriteLine("Invaldi indeks prestasi");
                    break;
            }
        }
    }
}
