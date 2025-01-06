using MySql.Data.MySqlClient;
using P9_714230056.controller;
using P9_714230056.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P9_714230056.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_nilai m_Nilai = new M_nilai();
        string id_nilai;

        public void Tampil()
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }
        public void GetDataMhs()
        {
            // ambil data NPM dari table (t_mahasiswa) untuk mengisi data pada combobox NPM
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                int npm = reader.GetInt32("npm");
                cbNPM.Items.Add(npm);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public FormNilai()
        {
            InitializeComponent();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        private void DataNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbKategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbNPM.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " + "WHERE t_nilai.npm LIKE '%' '" + tbCariData.Text + "' '%' " + "OR nama LIKE '%' '" + tbCariData.Text + "' '%'" + "OR matkul LIKE '%' '" + tbCariData.Text + "' '%'");

        }
        public void GetNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + cbNPM.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbNama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void cbNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        public void ResetForm()
        {
            cbMatkul.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
            cbNPM.SelectedIndex = -1;
            tbNilai.Text = "";
            tbNama.Text = "";
            tbCariData.Text = "";
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Pastikan deklarasi m_Nilai digunakan dengan benar
                m_Nilai.Matkul = cbMatkul.Text;
                m_Nilai.Kategori = cbKategori.Text;
                m_Nilai.Npm = cbNPM.Text;
                m_Nilai.Nilai = tbNilai.Text;

                Nilai nilai = new Nilai();
                nilai.Insert(m_Nilai); // Menggunakan objek m_Nilai yang telah diisi

                ResetForm();
                Tampil();
            }
        }

        private void bUbah_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Pastikan deklarasi m_Nilai digunakan dengan benar
                m_Nilai.Matkul = cbMatkul.Text;
                m_Nilai.Kategori = cbKategori.Text;
                m_Nilai.Npm = cbNPM.Text;
                m_Nilai.Nilai = tbNilai.Text;

                Nilai nilai = new Nilai();
                nilai.Insert(m_Nilai); // Menggunakan objek m_Nilai yang telah diisi

                ResetForm();
                Tampil();
            }
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                ResetForm();
                Tampil();
            }

        }
    }
}
