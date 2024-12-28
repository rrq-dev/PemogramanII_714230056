using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _714230056_RaihanAdityaH_ATS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Size = new Size(816, 267); // Set initial size
            // Populate the ComboBox Program Studi
            PopulateProgramStudiComboBox();
        }

        // Populate ComboBox Program Studi with available options
        private void PopulateProgramStudiComboBox()
        {
            cbPstudi.Items.Clear();
            cbPstudi.Items.Add("Teknik Informatika");
            cbPstudi.Items.Add("Sistem Informasi");
            cbPstudi.Items.Add("Teknik Komputer");
            cbPstudi.Items.Add("Manajemen Informatika");

            cbPstudi.SelectedIndex = 0; // Set default selection if needed
        }

        // Button to validate and resize the form (Pilih Mata Kuliah)
        private void bPMK_Click(object sender, EventArgs e)
        {
            // Validate and show success message
            if (ValidateForm())
            {
                MessageBox.Show("Informasi telah lengkap!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(816, 626); // Adjust form size after validation
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data telah disimpan.");
            GenerateSummary(); // Display the summary
        }

        // Button to reset the form (Batal)
        private void button2_Click(object sender, EventArgs e)
        {
            // Reset form to its default state
            ResetForm();
        }

        // Form validation logic
        private bool ValidateForm()
        {
            StringBuilder errorMessage = new StringBuilder();
            bool isValid = true;

            // Validation for required fields
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi!");
                epWarning.SetError(txtNama, "Nama tidak boleh kosong");
                isValid = false;
            }
            else
            {
                epWarning.SetError(txtNama, string.Empty); // Clear error
            }

            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi!");
                epWarning.SetError(txtKelas, "Kelas tidak boleh kosong");
                isValid = false;
            }
            else
            {
                epWarning.SetError(txtKelas, string.Empty); // Clear error
            }

            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                errorMessage.AppendLine("Alamat harus diisi!");
                epWarning.SetError(txtAlamat, "Alamat tidak boleh kosong");
                isValid = false;
            }
            else
            {
                epWarning.SetError(txtAlamat, string.Empty); // Clear error
            }

            // NPM validation (must be numeric)
            if (!Regex.IsMatch(txtNPM.Text, @"^\d+$"))
            {
                errorMessage.AppendLine("NPM harus berupa angka!");
                epWrong.SetError(txtNPM, "NPM hanya boleh angka");
                isValid = false;
            }
            else
            {
                epWrong.SetError(txtNPM, string.Empty); // Clear error
            }

            // Nama validation (only letters)
            if (!Regex.IsMatch(txtNama.Text, @"^[a-zA-Z\s]+$"))
            {
                errorMessage.AppendLine("Nama hanya boleh mengandung huruf!");
                epWrong.SetError(txtNama, "Nama hanya boleh huruf");
                isValid = false;
            }
            else
            {
                epWrong.SetError(txtNama, string.Empty); // Clear error
            }

            // Tahun Akademik validation (format yyyy/yyyy)
            if (!Regex.IsMatch(txtTakademik.Text, @"^\d{4}/\d{4}$"))
            {
                errorMessage.AppendLine("Tahun Akademik harus berformat yyyy/yyyy!");
                epWrong.SetError(txtTakademik, "Format harus yyyy/yyyy");
                isValid = false;
            }
            else
            {
                epWrong.SetError(txtTakademik, string.Empty); // Clear error
            }

            // Show errors if validation fails
            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }

        // Reset all form controls to their default state
        private void ResetForm()
        {
            txtNama.Clear();
            txtKelas.Clear();
            txtAlamat.Clear();
            txtTakademik.Clear();
            txtNPM.Clear();
            rbCwok.Checked = false;
            rbCewk.Checked = false;
            cbPstudi.SelectedIndex = -1;

            // Reset all checkboxes
            cbAlgo1.Checked = false; cbAlgo1.Enabled = true;
            cbBasisdata1.Checked = false; cbBasisdata1.Enabled = true;
            cbLitek.Checked = false; cbLitek.Enabled = true;
            cbMTKdisk.Checked = false; cbMTKdisk.Enabled = true;
            cbPmg1.Checked = false; cbPmg1.Enabled = true;
            cbPkn.Checked = false; cbPkn.Enabled = true;

            cbAlgo2.Checked = false; cbAlgo2.Enabled = false;
            cbBasisdata2.Checked = false; cbBasisdata2.Enabled = false;
            cbLitedata.Checked = false; cbLitedata.Enabled = false;
            cbSCM.Checked = false; cbSCM.Enabled = false;
            cbPmg2.Checked = false; cbPmg2.Enabled = false;

            this.Size = new Size(816, 267); // Reset to initial form size
        }

        // Handle the semester radio buttons and enable/disable checkboxes
        private void rbSmster1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmster1.Checked)
            {
                EnableSemester1Courses();
            }
        }

        private void rbSmster2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmster2.Checked)
            {
                EnableSemester2Courses();
            }
        }

        private void rbSmster3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmster3.Checked)
            {
                EnableSemester3Courses();
            }
        }

        private void EnableSemester1Courses()
        {
            // Enable semester 1 courses
            cbAlgo1.Enabled = true; cbAlgo1.Checked = true;
            cbBasisdata1.Enabled = true; cbBasisdata1.Checked = true;
            cbLitek.Enabled = true; cbLitek.Checked = true;
            cbMTKdisk.Enabled = true; cbMTKdisk.Checked = true;
            cbPmg1.Enabled = true; cbPmg1.Checked = true;
            cbPkn.Enabled = true; cbPkn.Checked = true;

            // Disable other semester courses
            cbAljabar.Enabled = false; cbAljabar.Checked = false;
            cbAlgo2.Enabled = false; cbAlgo2.Checked = false;
            cbBasisdata2.Enabled = false; cbBasisdata2.Checked = false;
            cbLitedata.Enabled = false; cbLitedata.Checked = false;
            cbSCM.Enabled = false; cbSCM.Checked = false;
            cbPmg2.Enabled = false; cbPmg2.Checked = false;
        }

        private void EnableSemester2Courses()
        {
            // Enable semester 2 courses
            cbAlgo2.Enabled = true; cbAlgo2.Checked = true;
            cbBasisdata2.Enabled = true; cbBasisdata2.Checked = true;
            cbLitedata.Enabled = true; cbLitedata.Checked = true;
            cbSCM.Enabled = true; cbSCM.Checked = true;
            cbPmg2.Enabled = true; cbPmg2.Checked = true;

            // Aljabar specific logic
            cbAljabar.Enabled = true; cbAljabar.Checked = true; // Ensure Aljabar is checked

            // Disable other semester courses
            cbAlgo1.Enabled = false; cbAlgo1.Checked = false;
            cbBasisdata1.Enabled = false; cbBasisdata1.Checked = false;
            cbLitek.Enabled = false; cbLitek.Checked = false;
            cbMTKdisk.Enabled = false; cbMTKdisk.Checked = false;
            cbPmg1.Enabled = false; cbPmg1.Checked = false;
            cbPkn.Enabled = false; cbPkn.Checked = false;
        }

        private void EnableSemester3Courses()
        {
            // Enable semester 3 courses
            cbAlgo2.Enabled = true; cbAlgo2.Checked = true;
            cbPmg2.Enabled = true; cbPmg2.Checked = true;

            // Disable other semester courses
            cbAljabar.Enabled = false; cbAljabar.Checked = false;
            cbAlgo1.Enabled = false; cbAlgo1.Checked = false;
            cbBasisdata1.Enabled = false; cbBasisdata1.Checked = false;
            cbLitek.Enabled = false; cbLitek.Checked = false;
            cbMTKdisk.Enabled = false; cbMTKdisk.Checked = false;
            cbPmg1.Enabled = false; cbPmg1.Checked = false;
            cbPkn.Enabled = false; cbPkn.Checked = false;
            cbLitedata.Enabled = false; cbLitedata.Checked = false;
            cbBasisdata2.Enabled = false; cbBasisdata2.Checked = false;
            cbSCM.Enabled = false; cbSCM.Checked = false;
        }

        // Event handlers for text changes (NPM, Nama, Kelas, etc.)
        private void txtNPM_TextChanged(object sender, EventArgs e)
        {
            // Validate NPM: should be numeric
            if (!Regex.IsMatch(txtNPM.Text, @"^\d+$"))
            {
                epWrong.SetError(txtNPM, "NPM hanya boleh angka");
            }
            else
            {
                epWrong.SetError(txtNPM, string.Empty); // Clear error
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            // Validate Nama: should contain only letters and spaces
            if (!Regex.IsMatch(txtNama.Text, @"^[a-zA-Z\s]+$"))
            {
                epWrong.SetError(txtNama, "Nama hanya boleh huruf");
            }
            else
            {
                epWrong.SetError(txtNama, string.Empty); // Clear error
            }
        }

        private void txtKelas_TextChanged(object sender, EventArgs e)
        {
            // Ensure Kelas is not empty
            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                epWarning.SetError(txtKelas, "Kelas tidak boleh kosong!");
            }
            else
            {
                epWarning.SetError(txtKelas, string.Empty); // Clear error
            }
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            // Ensure Alamat is not empty
            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                epWarning.SetError(txtAlamat, "Alamat tidak boleh kosong!");
            }
            else
            {
                epWarning.SetError(txtAlamat, string.Empty); // Clear error
            }
        }

        private void txtTakademik_TextChanged(object sender, EventArgs e)
        {
            // Validate Tahun Akademik: must match the format yyyy/yyyy
            if (!Regex.IsMatch(txtTakademik.Text, @"^\d{4}/\d{4}$"))
            {
                epWrong.SetError(txtTakademik, "Format harus yyyy/yyyy");
            }
            else
            {
                epWrong.SetError(txtTakademik, string.Empty); // Clear error
            }
        }

        private void rbCwok_CheckedChanged(object sender, EventArgs e)
        {
            // Handle gender selection logic if needed
            Console.WriteLine("Gender selected: Laki - Laki");
        }

        private void rbCewk_CheckedChanged(object sender, EventArgs e)
        {
            // Handle gender selection logic if needed
            Console.WriteLine("Gender selected: Perempuan");
        }

        private void cbPstudi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle Program Studi selection logic
            Console.WriteLine("Program Studi selected: " + cbPstudi.SelectedItem.ToString());
        }
        private void GenerateSummary()
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine("=== Rekap Data Mahasiswa ===");
            summary.AppendLine($"Nama: {txtNama.Text}");
            summary.AppendLine($"NPM: {txtNPM.Text}");
            summary.AppendLine($"Kelas: {txtKelas.Text}");
            summary.AppendLine($"Alamat: {txtAlamat.Text}");
            summary.AppendLine($"Tahun Akademik: {txtTakademik.Text}");
            summary.AppendLine($"Jenis Kelamin: {(rbCwok.Checked ? "Laki-Laki" : rbCewk.Checked ? "Perempuan" : "Tidak dipilih")}");
            summary.AppendLine($"Program Studi: {cbPstudi.SelectedItem}");

            summary.AppendLine("\n=== Mata Kuliah yang Dipilih ===");
            if (cbAlgo1.Checked) summary.AppendLine("- Algoritma 1");
            if (cbBasisdata1.Checked) summary.AppendLine("- Basis Data 1");
            if (cbLitek.Checked) summary.AppendLine("- Logika Teknik");
            if (cbMTKdisk.Checked) summary.AppendLine("- Matematika Diskret");
            if (cbPmg1.Checked) summary.AppendLine("- Pemrograman 1");
            if (cbPkn.Checked) summary.AppendLine("- Pendidikan Kewarganegaraan");
            if (cbAlgo2.Checked) summary.AppendLine("- Algoritma 2");
            if (cbBasisdata2.Checked) summary.AppendLine("- Basis Data 2");
            if (cbLitedata.Checked) summary.AppendLine("- Literasi Data");
            if (cbSCM.Checked) summary.AppendLine("- Supply Chain Management");
            if (cbPmg2.Checked) summary.AppendLine("- Pemrograman 2");
            if (cbAljabar.Checked) summary.AppendLine("- Aljabar");

            MessageBox.Show(summary.ToString(), "Rekap Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
