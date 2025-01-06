namespace P9_714230056.view
{
    partial class FormNilai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bHapus = new System.Windows.Forms.Button();
            this.bUbah = new System.Windows.Forms.Button();
            this.bSimpan = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNPM = new System.Windows.Forms.ComboBox();
            this.tbNilai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbMatkul = new System.Windows.Forms.ComboBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(511, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(72, 42);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(152, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bHapus);
            this.groupBox3.Controls.Add(this.bUbah);
            this.groupBox3.Controls.Add(this.bSimpan);
            this.groupBox3.Controls.Add(this.bRefresh);
            this.groupBox3.Location = new System.Drawing.Point(511, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 237);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // bHapus
            // 
            this.bHapus.Location = new System.Drawing.Point(43, 178);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(181, 29);
            this.bHapus.TabIndex = 3;
            this.bHapus.Text = "Hapus";
            this.bHapus.UseVisualStyleBackColor = true;
            this.bHapus.Click += new System.EventHandler(this.bHapus_Click);
            // 
            // bUbah
            // 
            this.bUbah.Location = new System.Drawing.Point(43, 134);
            this.bUbah.Name = "bUbah";
            this.bUbah.Size = new System.Drawing.Size(181, 29);
            this.bUbah.TabIndex = 2;
            this.bUbah.Text = "Ubah";
            this.bUbah.UseVisualStyleBackColor = true;
            this.bUbah.Click += new System.EventHandler(this.bUbah_Click);
            // 
            // bSimpan
            // 
            this.bSimpan.Location = new System.Drawing.Point(43, 87);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(181, 29);
            this.bSimpan.TabIndex = 1;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(43, 47);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(181, 29);
            this.bRefresh.TabIndex = 0;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNama);
            this.groupBox2.Controls.Add(this.cbMatkul);
            this.groupBox2.Controls.Add(this.cbKategori);
            this.groupBox2.Controls.Add(this.cbNPM);
            this.groupBox2.Controls.Add(this.tbNilai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(40, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            // 
            // cbNPM
            // 
            this.cbNPM.FormattingEnabled = true;
            this.cbNPM.Location = new System.Drawing.Point(91, 84);
            this.cbNPM.Name = "cbNPM";
            this.cbNPM.Size = new System.Drawing.Size(205, 21);
            this.cbNPM.TabIndex = 14;
            this.cbNPM.SelectedIndexChanged += new System.EventHandler(this.cbNPM_SelectedIndexChanged);
            // 
            // tbNilai
            // 
            this.tbNilai.Location = new System.Drawing.Point(91, 111);
            this.tbNilai.Multiline = true;
            this.tbNilai.Name = "tbNilai";
            this.tbNilai.Size = new System.Drawing.Size(205, 22);
            this.tbNilai.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matkul";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(40, 38);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.Size = new System.Drawing.Size(715, 229);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 274);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Mahasiswa";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "ATS",
            "AAS"});
            this.cbKategori.Location = new System.Drawing.Point(91, 56);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(205, 21);
            this.cbKategori.TabIndex = 15;
            // 
            // cbMatkul
            // 
            this.cbMatkul.FormattingEnabled = true;
            this.cbMatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbMatkul.Location = new System.Drawing.Point(91, 28);
            this.cbMatkul.Name = "cbMatkul";
            this.cbMatkul.Size = new System.Drawing.Size(205, 21);
            this.cbMatkul.TabIndex = 16;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(302, 84);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(143, 20);
            this.tbNama.TabIndex = 17;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.DataNilai);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bUbah;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNPM;
        private System.Windows.Forms.TextBox tbNilai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMatkul;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbNama;
    }
}