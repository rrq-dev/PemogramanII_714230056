using System;
using System.Windows.Forms;

namespace P9_714230056.controller
{
    internal class Mahasiswa
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_mahasiswa mahasiswa)
        {
            bool status = false; // Menggunakan `bool` sebagai tipe data
            try
            {
                // Membuka koneksi
                koneksi.OpenConnection();

                // Query INSERT dengan parameter
                string query = "INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp) " +
                               "VALUES (@npm, @nama, @angkatan, @alamat, @email, @nohp)";

                // Menyiapkan perintah MySQL
                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, koneksi.GetConnection()))
                {
                    // Menambahkan parameter ke query
                    command.Parameters.AddWithValue("@npm", mahasiswa.Npm);
                    command.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                    command.Parameters.AddWithValue("@angkatan", mahasiswa.Angkatan);
                    command.Parameters.AddWithValue("@alamat", mahasiswa.Alamat);
                    command.Parameters.AddWithValue("@email", mahasiswa.Email);
                    command.Parameters.AddWithValue("@nohp", mahasiswa.Nohp);

                    // Menjalankan query
                    command.ExecuteNonQuery();
                }

                status = true; // Menandakan data berhasil ditambahkan

                // Pesan berhasil
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Menutup koneksi
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                // Pesan error jika gagal
                MessageBox.Show(e.Message, "Gagal Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Update(M_mahasiswa mahasiswa)
        {
            bool status = false; // Menggunakan `bool` sebagai tipe data
            try
            {
                // Membuka koneksi
                koneksi.OpenConnection();

                // Query UPDATE dengan parameter
                string query = "UPDATE t_mahasiswa SET nama = @nama, angkatan = @angkatan, " +
                               "alamat = @alamat, email = @email, nohp = @nohp WHERE npm = @npm";

                // Menyiapkan perintah MySQL
                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, koneksi.GetConnection()))
                {
                    // Menambahkan parameter ke query
                    command.Parameters.AddWithValue("@npm", mahasiswa.Npm); // Primary key untuk kondisi WHERE
                    command.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                    command.Parameters.AddWithValue("@angkatan", mahasiswa.Angkatan);
                    command.Parameters.AddWithValue("@alamat", mahasiswa.Alamat);
                    command.Parameters.AddWithValue("@email", mahasiswa.Email);
                    command.Parameters.AddWithValue("@nohp", mahasiswa.Nohp);

                    // Menjalankan query
                    command.ExecuteNonQuery();
                }

                status = true; // Menandakan data berhasil diupdate

                // Pesan berhasil
                MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Menutup koneksi
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                // Pesan error jika gagal
                MessageBox.Show(e.Message, "Gagal Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Delete(string npm)
        {
            bool status = false; // Menggunakan `bool` sebagai tipe data untuk status keberhasilan
            try
            {
                // Membuka koneksi
                koneksi.OpenConnection();

                // Query DELETE dengan parameter
                string query = "DELETE FROM t_mahasiswa WHERE npm = @npm";

                // Menyiapkan perintah MySQL
                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, koneksi.GetConnection()))
                {
                    // Menambahkan parameter ke query
                    command.Parameters.AddWithValue("@npm", npm); // Primary key untuk identifikasi data

                    // Menjalankan query
                    command.ExecuteNonQuery();
                }

                status = true; // Menandakan data berhasil dihapus

                // Pesan berhasil
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Menutup koneksi
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                // Pesan error jika gagal
                MessageBox.Show(e.Message, "Gagal Menghapus Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


    }
}
