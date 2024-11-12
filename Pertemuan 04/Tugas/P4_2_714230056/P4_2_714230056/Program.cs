using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230056
{ // Abstraction
    abstract class Ticket
    {
        public string TicketType { get; protected set; }
        public double Price { get; protected set; }

        public Ticket(string ticketType, double price)
        {
            TicketType = ticketType;
            Price = price;
        }

        public virtual void ShowTicketInfo()
        {
            Console.WriteLine($"Tiket {TicketType}, Harga: ${Price}");
        }
    }

    // Inheritance
    class ManUTicket : Ticket
    {
        public string MatchDate { get; private set; }

        public ManUTicket(string ticketType, double price, string matchDate)
            : base(ticketType, price)
        {
            MatchDate = matchDate;
        }

        public override void ShowTicketInfo()
        {
            base.ShowTicketInfo();
            Console.WriteLine($"Tanggal Pertandingan: {MatchDate}");
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string CustomerID { get; set; }

        public Customer(string name, string customerID)
        {
            Name = name;
            CustomerID = customerID;
        }

        public void ShowCustomerInfo()
        {
            Console.WriteLine($"Nama Pelanggan: {Name}, ID: {CustomerID}");
        }
    }

    class TicketSystem
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void PurchaseTicket(Customer customer, Ticket ticket, int quantity)
        {
            Console.WriteLine("\n=== Pembelian Tiket ===");
            customer.ShowCustomerInfo();
            ticket.ShowTicketInfo();
            Console.WriteLine($"Jumlah Tiket: {quantity}");
            Console.WriteLine($"Total Harga: ${ticket.Price * quantity}");
            tickets.Add(ticket);
            Console.WriteLine("Tiket berhasil dibeli!\n");
        }

        public void ShowAllTickets()
        {
            Console.WriteLine("\n=== Semua Tiket Dibeli ===");
            foreach (var ticket in tickets)
            {
                ticket.ShowTicketInfo();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sistem tiket
            TicketSystem ticketSystem = new TicketSystem();

            Console.WriteLine("=== Selamat Datang di Sistem Pembelian Tiket Nonton Manchester United ===");

            // Input data pelanggan
            Console.Write("Masukkan Nama Anda: ");
            string name = Console.ReadLine();

            Console.Write("Masukkan ID Pelanggan: ");
            string customerID = Console.ReadLine();

            Customer customer = new Customer(name, customerID);

            bool beliLagi = true;
            while (beliLagi)
            {
                // Pilih jenis tiket
                Console.WriteLine("\nPilih Jenis Tiket:");
                Console.WriteLine("1. VIP - $150");
                Console.WriteLine("2. Regular - $75");
                Console.Write("Pilihan Anda (1/2): ");
                int ticketChoice = int.Parse(Console.ReadLine());

                string ticketType;
                double price;
                if (ticketChoice == 1)
                {
                    ticketType = "VIP";
                    price = 150.0;
                }
                else
                {
                    ticketType = "Regular";
                    price = 75.0;
                }

                // Input tanggal pertandingan
                Console.Write("Masukkan Tanggal Pertandingan (yyyy-mm-dd): ");
                string matchDate = Console.ReadLine();

                // Input jumlah tiket
                Console.Write("Masukkan Jumlah Tiket: ");
                int quantity = int.Parse(Console.ReadLine());

                // Buat objek tiket
                ManUTicket ticket = new ManUTicket(ticketType, price, matchDate);

                // Proses pembelian tiket
                ticketSystem.PurchaseTicket(customer, ticket, quantity);

                // Tanya apakah ingin membeli tiket lagi
                Console.Write("Apakah Anda ingin membeli tiket lagi? (y/n): ");
                string answer = Console.ReadLine();
                beliLagi = answer.ToLower() == "y";
            }

            // Tampilkan semua tiket yang telah dibeli
            ticketSystem.ShowAllTickets();

            Console.WriteLine("\nTerima kasih telah menggunakan sistem pembelian tiket!");
            Console.ReadKey();
        }
    }
}
