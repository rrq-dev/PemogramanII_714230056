namespace P5_4_714230056
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.labelNamaPemain = new System.Windows.Forms.Label();
            this.labelPosisi = new System.Windows.Forms.Label();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.comboBoxPosisi = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBoxKelas = new System.Windows.Forms.GroupBox();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.rbU23 = new System.Windows.Forms.RadioButton();
            this.rbAkademi = new System.Windows.Forms.RadioButton();
            this.rbJunior = new System.Windows.Forms.RadioButton();
            this.groupBoxJadwalLatihan = new System.Windows.Forms.GroupBox();
            this.cbMinggu = new System.Windows.Forms.CheckBox();
            this.cbSenin = new System.Windows.Forms.CheckBox();
            this.cbSabtu = new System.Windows.Forms.CheckBox();
            this.cbSelasa = new System.Windows.Forms.CheckBox();
            this.cbJumat = new System.Windows.Forms.CheckBox();
            this.cbRabu = new System.Windows.Forms.CheckBox();
            this.cbKamis = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.groupBoxKelas.SuspendLayout();
            this.groupBoxJadwalLatihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(128, 25);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 0;
            // 
            // labelNamaPemain
            // 
            this.labelNamaPemain.AutoSize = true;
            this.labelNamaPemain.Location = new System.Drawing.Point(35, 32);
            this.labelNamaPemain.Name = "labelNamaPemain";
            this.labelNamaPemain.Size = new System.Drawing.Size(73, 13);
            this.labelNamaPemain.TabIndex = 1;
            this.labelNamaPemain.Text = "Nama Pemain";
            // 
            // labelPosisi
            // 
            this.labelPosisi.AutoSize = true;
            this.labelPosisi.Location = new System.Drawing.Point(35, 63);
            this.labelPosisi.Name = "labelPosisi";
            this.labelPosisi.Size = new System.Drawing.Size(34, 13);
            this.labelPosisi.TabIndex = 2;
            this.labelPosisi.Text = "Posisi";
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.Location = new System.Drawing.Point(35, 96);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(72, 13);
            this.labelTanggalLahir.TabIndex = 3;
            this.labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // comboBoxPosisi
            // 
            this.comboBoxPosisi.FormattingEnabled = true;
            this.comboBoxPosisi.Items.AddRange(new object[] { "Striker", "Midfielder", "Defender", "Goalkeeper" });
            this.comboBoxPosisi.Location = new System.Drawing.Point(128, 55);
            this.comboBoxPosisi.Name = "comboBoxPosisi";
            this.comboBoxPosisi.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPosisi.TabIndex = 4;
            // 
            // dateTimePickerTanggalLahir
            // 
            this.dateTimePickerTanggalLahir.Location = new System.Drawing.Point(128, 90);
            this.dateTimePickerTanggalLahir.Name = "dateTimePickerTanggalLahir";
            this.dateTimePickerTanggalLahir.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTanggalLahir.TabIndex = 5;
            // 
            // groupBoxKelas
            // 
            this.groupBoxKelas.Controls.Add(this.rbSenior);
            this.groupBoxKelas.Controls.Add(this.rbU23);
            this.groupBoxKelas.Controls.Add(this.rbAkademi);
            this.groupBoxKelas.Controls.Add(this.rbJunior);
            this.groupBoxKelas.Location = new System.Drawing.Point(86, 140);
            this.groupBoxKelas.Name = "groupBoxKelas";
            this.groupBoxKelas.Size = new System.Drawing.Size(200, 120);
            this.groupBoxKelas.TabIndex = 6;
            this.groupBoxKelas.TabStop = false;
            this.groupBoxKelas.Text = "Pilihan Kelas";
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(20, 20);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(55, 17);
            this.rbSenior.TabIndex = 0;
            this.rbSenior.TabStop = true;
            this.rbSenior.Text = "Senior";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // rbU23
            // 
            this.rbU23.AutoSize = true;
            this.rbU23.Location = new System.Drawing.Point(20, 40);
            this.rbU23.Name = "rbU23";
            this.rbU23.Size = new System.Drawing.Size(45, 17);
            this.rbU23.TabIndex = 1;
            this.rbU23.TabStop = true;
            this.rbU23.Text = "U23";
            this.rbU23.UseVisualStyleBackColor = true;
            // 
            // rbAkademi
            // 
            this.rbAkademi.AutoSize = true;
            this.rbAkademi.Location = new System.Drawing.Point(20, 60);
            this.rbAkademi.Name = "rbAkademi";
            this.rbAkademi.Size = new System.Drawing.Size(66, 17);
            this.rbAkademi.TabIndex = 2;
            this.rbAkademi.TabStop = true;
            this.rbAkademi.Text = "Akademi";
            this.rbAkademi.UseVisualStyleBackColor = true;
            // 
            // rbJunior
            // 
            this.rbJunior.AutoSize = true;
            this.rbJunior.Location = new System.Drawing.Point(20, 80);
            this.rbJunior.Name = "rbJunior";
            this.rbJunior.Size = new System.Drawing.Size(53, 17);
            this.rbJunior.TabIndex = 3;
            this.rbJunior.TabStop = true;
            this.rbJunior.Text = "Junior";
            this.rbJunior.UseVisualStyleBackColor = true;
            // 
            // groupBoxJadwalLatihan
            // 
            this.groupBoxJadwalLatihan.Controls.Add(this.cbMinggu);
            this.groupBoxJadwalLatihan.Controls.Add(this.cbSenin);
            this.groupBoxJadwalLatihan.Controls.Add(this.cbSabtu);
            this.groupBoxJadwalLatihan.Controls.Add(this.cbSelasa);
            this.groupBoxJadwalLatihan.Controls.Add(this.cbJumat);
            this.groupBoxJadwalLatihan.Controls.Add(this.cbRabu);
            this.groupBoxJadwalLatihan.Controls.Add(this.cbKamis);
            this.groupBoxJadwalLatihan.Location = new System.Drawing.Point(300, 140);
            this.groupBoxJadwalLatihan.Name = "groupBoxJadwalLatihan";
            this.groupBoxJadwalLatihan.Size = new System.Drawing.Size(200, 120);
            this.groupBoxJadwalLatihan.TabIndex = 7;
            this.groupBoxJadwalLatihan.TabStop = false;
            this.groupBoxJadwalLatihan.Text = "Jadwal Latihan";
            // 
            // cbMinggu
            // 
            this.cbMinggu.AutoSize = true;
            this.cbMinggu.Location = new System.Drawing.Point(20, 100);
            this.cbMinggu.Name = "cbMinggu";
            this.cbMinggu.Size = new System.Drawing.Size(61, 17);
            this.cbMinggu.TabIndex = 6;
            this.cbMinggu.Text = "Minggu";
            this.cbMinggu.UseVisualStyleBackColor = true;
            // 
            // cbSenin
            // 
            this.cbSenin.AutoSize = true;
            this.cbSenin.Location = new System.Drawing.Point(20, 20);
            this.cbSenin.Name = "cbSenin";
            this.cbSenin.Size = new System.Drawing.Size(53, 17);
            this.cbSenin.TabIndex = 0;
            this.cbSenin.Text = "Senin";
            this.cbSenin.UseVisualStyleBackColor = true;
            // 
            // cbSabtu
            // 
            this.cbSabtu.AutoSize = true;
            this.cbSabtu.Location = new System.Drawing.Point(20, 80);
            this.cbSabtu.Name = "cbSabtu";
            this.cbSabtu.Size = new System.Drawing.Size(54, 17);
            this.cbSabtu.TabIndex = 5;
            this.cbSabtu.Text = "Sabtu";
            this.cbSabtu.UseVisualStyleBackColor = true;
            // 
            // cbSelasa
            // 
            this.cbSelasa.AutoSize = true;
            this.cbSelasa.Location = new System.Drawing.Point(20, 40);
            this.cbSelasa.Name = "cbSelasa";
            this.cbSelasa.Size = new System.Drawing.Size(58, 17);
            this.cbSelasa.TabIndex = 1;
            this.cbSelasa.Text = "Selasa";
            this.cbSelasa.UseVisualStyleBackColor = true;
            // 
            // cbJumat
            // 
            this.cbJumat.AutoSize = true;
            this.cbJumat.Location = new System.Drawing.Point(20, 60);
            this.cbJumat.Name = "cbJumat";
            this.cbJumat.Size = new System.Drawing.Size(54, 17);
            this.cbJumat.TabIndex = 4;
            this.cbJumat.Text = "Jumat";
            this.cbJumat.UseVisualStyleBackColor = true;
            // 
            // cbRabu
            // 
            this.cbRabu.AutoSize = true;
            this.cbRabu.Location = new System.Drawing.Point(100, 20);
            this.cbRabu.Name = "cbRabu";
            this.cbRabu.Size = new System.Drawing.Size(52, 17);
            this.cbRabu.TabIndex = 2;
            this.cbRabu.Text = "Rabu";
            this.cbRabu.UseVisualStyleBackColor = true;
            // 
            // cbKamis
            // 
            this.cbKamis.AutoSize = true;
            this.cbKamis.Location = new System.Drawing.Point(100, 40);
            this.cbKamis.Name = "cbKamis";
            this.cbKamis.Size = new System.Drawing.Size(54, 17);
            this.cbKamis.TabIndex = 3;
            this.cbKamis.Text = "Kamis";
            this.cbKamis.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(300, 300);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 8;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(400, 300);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBoxJadwalLatihan);
            this.Controls.Add(this.groupBoxKelas);
            this.Controls.Add(this.dateTimePickerTanggalLahir);
            this.Controls.Add(this.comboBoxPosisi);
            this.Controls.Add(this.labelTanggalLahir);
            this.Controls.Add(this.labelPosisi);
            this.Controls.Add(this.labelNamaPemain);
            this.Controls.Add(this.txtNama);
            this.Name = "Form1";
            this.Text = "Form Pendaftaran Pemain Manchester United";
            this.groupBoxKelas.ResumeLayout(false);
            this.groupBoxKelas.PerformLayout();
            this.groupBoxJadwalLatihan.ResumeLayout(false);
            this.groupBoxJadwalLatihan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label labelNamaPemain;
        private System.Windows.Forms.Label labelPosisi;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.ComboBox comboBoxPosisi;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalLahir;

        private System.Windows.Forms.GroupBox groupBoxKelas;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.RadioButton rbU23;
        private System.Windows.Forms.RadioButton rbAkademi;
        private System.Windows.Forms.RadioButton rbJunior;

        private System.Windows.Forms.GroupBox groupBoxJadwalLatihan;
        private System.Windows.Forms.CheckBox cbSenin;
        private System.Windows.Forms.CheckBox cbSelasa;
        private System.Windows.Forms.CheckBox cbRabu;
        private System.Windows.Forms.CheckBox cbKamis;
        private System.Windows.Forms.CheckBox cbJumat;
        private System.Windows.Forms.CheckBox cbSabtu;
        private System.Windows.Forms.CheckBox cbMinggu;

        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
    }
}
