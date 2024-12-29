using P9_714230056.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714230056
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

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

        private void bSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi: Pastikan semua field input diisi
                if (string.IsNullOrWhiteSpace(tbNPM.Text) ||
                    string.IsNullOrWhiteSpace(tbNama.Text) ||
                    cbAngkatan.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(tbAlamat.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbNohp.Text))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Membuat objek model mahasiswa
                    Mahasiswa mhs = new Mahasiswa();
                    M_mahasiswa m_mhs = new M_mahasiswa
                    {
                        Npm = tbNPM.Text.Trim(),
                        Nama = tbNama.Text.Trim(),
                        Angkatan = cbAngkatan.Text,
                        Alamat = tbAlamat.Text.Trim(),
                        Email = tbEmail.Text.Trim(),
                        Nohp = tbNohp.Text.Trim()
                    };

                    // Proses penyimpanan data ke database
                    bool status = mhs.Insert(m_mhs);
                    if (status)
                    {
                        MessageBox.Show("Data berhasil disimpan!", "Informasi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form dan tampilkan data terbaru
                        Resetform();
                        Tampil();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data!", "Kesalahan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangkap error dan menampilkan pesan kesalahan
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Resetform()
        {
            tbNPM.Text = "";
            tbNama.Text = "";
            cbAngkatan.SelectedIndex = -1;
            tbAlamat.Text = "";
            tbEmail.Text = "";
            tbNohp.Text = "";
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void bUbah_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi: Pastikan semua field input diisi
                if (string.IsNullOrWhiteSpace(tbNPM.Text) ||
                    string.IsNullOrWhiteSpace(tbNama.Text) ||
                    cbAngkatan.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(tbAlamat.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbNohp.Text))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Membuat objek model mahasiswa
                    Mahasiswa mhs = new Mahasiswa();
                    M_mahasiswa m_mhs = new M_mahasiswa
                    {
                        Npm = tbNPM.Text.Trim(), // Primary key untuk identifikasi data
                        Nama = tbNama.Text.Trim(),
                        Angkatan = cbAngkatan.Text,
                        Alamat = tbAlamat.Text.Trim(),
                        Email = tbEmail.Text.Trim(),
                        Nohp = tbNohp.Text.Trim()
                    };

                    // Proses update data ke database
                    bool status = mhs.Update(m_mhs); // Menggunakan fungsi Update
                    if (status)
                    {
                        MessageBox.Show("Data berhasil diubah!", "Informasi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form dan tampilkan data terbaru
                        Resetform();
                        Tampil();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data!", "Kesalahan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangkap error dan menampilkan pesan kesalahan
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Memanggil fungsi untuk mengosongkan form input
                Resetform();

                // Memanggil fungsi untuk merefresh data di DataGridView
                Tampil();

                // Menampilkan pesan bahwa refresh berhasil
                MessageBox.Show("Data berhasil direfresh!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Menangkap error dan menampilkan pesan kesalahan
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi: Pastikan NPM tidak kosong
                if (string.IsNullOrWhiteSpace(tbNPM.Text))
                {
                    MessageBox.Show("Silakan pilih data yang akan dihapus!", "Peringatan",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Konfirmasi sebelum menghapus
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                      "Konfirmasi", MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Mahasiswa mhs = new Mahasiswa();
                    bool status = mhs.Delete(tbNPM.Text); // Hapus data berdasarkan NPM

                    if (status)
                    {
                        // Reset form dan tampilkan data terbaru
                        Resetform();
                        Tampil();
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangkap error dan menampilkan pesan kesalahan
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
