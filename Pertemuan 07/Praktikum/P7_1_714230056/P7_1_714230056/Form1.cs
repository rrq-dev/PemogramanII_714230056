using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(330, 230);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeekday.Checked)
            {
                cbKuliah.Enabled = true;cbKuliah.Checked = false;
                cbTidur.Enabled = true;cbTidur.Checked = false;
                cbLiburan.Enabled = false;cbLiburan.Checked = false;
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeekend.Checked)
            {
                cbKuliah.Enabled = false;cbKuliah.Checked=false;
                cbTidur.Enabled = true;cbTidur.Checked=true;
                cbLiburan.Enabled = true;cbLiburan.Checked=true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            // Validasi nama
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi!");
            }

            // Validasi angkatan
            if (cbAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus dipilih!");
            }

            // Validasi kelas
            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMessage.AppendLine("Kelas wajib diisi!");
            }

            // Hasil validasi
            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                // Jika semua validasi lolos
                MessageBox.Show(
                    "Informasi telah lengkap!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Mengubah ukuran form
                this.Size = new Size(401, 505); // Ukuran sesuai kebutuhan Anda
            }
            else
            {
                // Jika ada error
                MessageBox.Show(
                    errorMsg.Trim(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }


        }

        private void bTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            //string hari = null;
            //string kegiatan = null;
            
            //foreach (Control control in Controls)
            //{
            //    if (control is RadioButton radioButton && radioButton.Checked) 
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }
            //}
            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked)
            //    {
            //        if (!string.IsNullOrEmpty(kegiatan)) 
            //        {
            //            kegiatan += ", ";
            //        }
            //        kegiatan += checkBox.Text;
            //    }
            //}


            // menggunakan LINQ (Language Integrated Query)
                string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked)?.Text;

                string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                );

            MessageBox.Show(
                "Nama: " + txtNama.Text + "\n" +
                "Angkatan: " + cbAngkatan.Text + "\n" +
                "Kelas: " + txtKelas.Text + "\n" +
                "====================================\n" +
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan + "\n",
                "Informasi telah di submit ke database!",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            //txtNama.Text = "";
            //cbAngkatan.SelectedIndex = -1;
            //txtKelas.Text = "";
            //cbKuliah.Checked = false;
            //cbLiburan.Checked = false;
            //cbTidur.Checked = false;
            //rbWeekday.Checked = false;
            //rbWeekend.Checked = false;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                if (control is CheckBox checkbox)
                {
                    checkbox.Checked = false;
                }
                if (control is RadioButton radiobutton)
                {
                    radiobutton.Checked = false;
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
   
            }
            Size = new Size(330, 230);
            MessageBox.Show(
                "Form mu telah di reset!",
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
    }
}
