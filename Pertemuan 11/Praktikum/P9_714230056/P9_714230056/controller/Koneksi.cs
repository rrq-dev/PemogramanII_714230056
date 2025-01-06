using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace P9_714230056
{
    internal class Koneksi
    {
        // Function ShowData untuk mengambil data dari database
        public DataTable ShowData(string query)
        {
            try
            {
                // Pastikan koneksi terbuka
                if (kon == null || kon.State != ConnectionState.Open)
                {
                    OpenConnection();
                }

                // Buat objek MySqlDataAdapter untuk eksekusi query
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
                DataTable dataTable = new DataTable();

                // Isi data ke dalam DataTable
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat menampilkan data: " + ex.Message);
                return null;
            }
            finally
            {
                // Tutup koneksi setelah selesai
                CloseConnection();
            }
        }


        public MySqlConnection GetConnection()
        {
            return kon;
        }

        // String koneksi ke database
        private string connectionstring = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=jumatberkah123;";
        private MySqlConnection kon;

        // Metode untuk membuka koneksi
        public void OpenConnection()
        {
            try
            {
                kon = new MySqlConnection(connectionstring);
                kon.Open();
                Console.WriteLine("Koneksi berhasil dibuka.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membuka koneksi: " + ex.Message);
            }
        }

        // Metode untuk menutup koneksi
        public void CloseConnection()
        {
            try
            {
                if (kon != null && kon.State == ConnectionState.Open)
                {
                    kon.Close();
                    Console.WriteLine("Koneksi berhasil ditutup.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat menutup koneksi: " + ex.Message);
            }
        }

        // Metode untuk menjalankan query (READ data)
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                if (kon == null || kon.State != ConnectionState.Open)
                {
                    OpenConnection();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat menjalankan query: " + ex.Message);
                return null;
            }

        }
        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

    }
}
