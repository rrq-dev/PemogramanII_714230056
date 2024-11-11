using System;
using System.Windows.Forms;

namespace P5_4_714230056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Di dalam InitializeComponent atau di constructor Form1
            this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\ASUS\\source\\repos\\P5_4_714230056\\P5_4_714230056\\Logo Manchester United.png");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // Event handler untuk tombol Tampilkan
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);

            // Event handler untuk tombol Selesai
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Mengatur opsi pada ComboBox Posisi
            comboBoxPosisi.Items.AddRange(new string[] { "Striker", "Midfielder", "Defender", "Goalkeeper" });
            comboBoxPosisi.SelectedIndex = 0; // Set pilihan default
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            // Validasi jika nama tidak diisi
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama pemain harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            // Validasi jika posisi tidak dipilih
            if (comboBoxPosisi.SelectedItem == null)
            {
                MessageBox.Show("Posisi pemain harus dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxPosisi.Focus();
                return;
            }

            // Validasi jika tanggal lahir tidak dipilih (opsional, karena DateTimePicker selalu memiliki nilai default)

            // Validasi jika kelas tidak dipilih
            if (!rbSenior.Checked && !rbU23.Checked && !rbAkademi.Checked && !rbJunior.Checked)
            {
                MessageBox.Show("Kelas pemain harus dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi jika jadwal latihan tidak dipilih
            if (!cbSenin.Checked && !cbSelasa.Checked && !cbRabu.Checked && !cbKamis.Checked &&
                !cbJumat.Checked && !cbSabtu.Checked && !cbMinggu.Checked)
            {
                MessageBox.Show("Jadwal latihan harus dipilih setidaknya satu hari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mengambil data dari form setelah semua validasi lolos
            string nama = txtNama.Text;
            string posisi = comboBoxPosisi.SelectedItem.ToString();
            DateTime tanggalLahir = dateTimePickerTanggalLahir.Value;
            string kelas = "";
            string jadwalLatihan = "";

            // Menentukan kelas pemain yang dipilih
            if (rbSenior.Checked) kelas = "Senior";
            else if (rbU23.Checked) kelas = "U23";
            else if (rbAkademi.Checked) kelas = "Akademi";
            else if (rbJunior.Checked) kelas = "Junior";

            // Menentukan jadwal latihan yang dipilih
            if (cbSenin.Checked) jadwalLatihan += "Senin, ";
            if (cbSelasa.Checked) jadwalLatihan += "Selasa, ";
            if (cbRabu.Checked) jadwalLatihan += "Rabu, ";
            if (cbKamis.Checked) jadwalLatihan += "Kamis, ";
            if (cbJumat.Checked) jadwalLatihan += "Jumat, ";
            if (cbSabtu.Checked) jadwalLatihan += "Sabtu, ";
            if (cbMinggu.Checked) jadwalLatihan += "Minggu, ";

            // Menghapus koma terakhir dari jadwal latihan
            if (jadwalLatihan.EndsWith(", ")) jadwalLatihan = jadwalLatihan.Remove(jadwalLatihan.Length - 2);

            // Menampilkan informasi pemain
            MessageBox.Show($"History Pendaftaran:\n\nNama: {nama}\nPosisi: {posisi}\nTanggal Lahir: {tanggalLahir.ToShortDateString()}\nKelas: {kelas}\nJadwal Latihan: {jadwalLatihan}",
                            "Informasi Pendaftaran Pemain", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close(); // Tutup aplikasi
        }

    }
}
