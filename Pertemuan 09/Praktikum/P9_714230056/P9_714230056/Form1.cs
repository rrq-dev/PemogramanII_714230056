using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714230056
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            try
            {
                // Memanggil fungsi ShowData dari class Koneksi
                string query = "SELECT * FROM t_mahasiswa";
                DataMahasiswa.DataSource = koneksi.ExecuteQuery(query);

                //mengubah nama kolom tabel
                DataMahasiswa.Columns[0].HeaderText = "NPM";
                DataMahasiswa.Columns[1].HeaderText = "Nama";
                DataMahasiswa.Columns[2].HeaderText = "Angkatan";
                DataMahasiswa.Columns[3].HeaderText = "Alamat";
                DataMahasiswa.Columns[4].HeaderText = "Email";
                DataMahasiswa.Columns[5].HeaderText = "NO HP";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menampilkan data: " + ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
