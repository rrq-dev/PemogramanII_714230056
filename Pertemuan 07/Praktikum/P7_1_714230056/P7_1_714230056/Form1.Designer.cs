namespace P7_1_714230056
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.cbAngkatan = new System.Windows.Forms.ComboBox();
            this.bCek = new System.Windows.Forms.Button();
            this.bTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbWeekday = new System.Windows.Forms.RadioButton();
            this.rbWeekend = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.cbLiburan = new System.Windows.Forms.CheckBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(114, 25);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(121, 20);
            this.txtNama.TabIndex = 3;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(114, 84);
            this.txtKelas.Multiline = true;
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(143, 52);
            this.txtKelas.TabIndex = 4;
            // 
            // cbAngkatan
            // 
            this.cbAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAngkatan.FormattingEnabled = true;
            this.cbAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbAngkatan.Location = new System.Drawing.Point(114, 53);
            this.cbAngkatan.Name = "cbAngkatan";
            this.cbAngkatan.Size = new System.Drawing.Size(121, 21);
            this.cbAngkatan.TabIndex = 5;
            // 
            // bCek
            // 
            this.bCek.Location = new System.Drawing.Point(46, 158);
            this.bCek.Name = "bCek";
            this.bCek.Size = new System.Drawing.Size(75, 23);
            this.bCek.TabIndex = 6;
            this.bCek.Text = "Cek";
            this.bCek.UseVisualStyleBackColor = true;
            this.bCek.Click += new System.EventHandler(this.bCek_Click);
            // 
            // bTutup
            // 
            this.bTutup.Location = new System.Drawing.Point(221, 158);
            this.bTutup.Name = "bTutup";
            this.bTutup.Size = new System.Drawing.Size(75, 23);
            this.bTutup.TabIndex = 7;
            this.bTutup.Text = "Tutup";
            this.bTutup.UseVisualStyleBackColor = true;
            this.bTutup.Click += new System.EventHandler(this.bTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(97, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "KEGIATAN";
            // 
            // rbWeekday
            // 
            this.rbWeekday.AutoSize = true;
            this.rbWeekday.Location = new System.Drawing.Point(12, 305);
            this.rbWeekday.Name = "rbWeekday";
            this.rbWeekday.Size = new System.Drawing.Size(89, 17);
            this.rbWeekday.TabIndex = 9;
            this.rbWeekday.TabStop = true;
            this.rbWeekday.Text = "Senin - Jumat";
            this.rbWeekday.UseVisualStyleBackColor = true;
            this.rbWeekday.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbWeekend
            // 
            this.rbWeekend.AutoSize = true;
            this.rbWeekend.Location = new System.Drawing.Point(12, 328);
            this.rbWeekend.Name = "rbWeekend";
            this.rbWeekend.Size = new System.Drawing.Size(97, 17);
            this.rbWeekend.TabIndex = 10;
            this.rbWeekend.TabStop = true;
            this.rbWeekend.Text = "Sabtu - Minggu";
            this.rbWeekend.UseVisualStyleBackColor = true;
            this.rbWeekend.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(12, 378);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(55, 17);
            this.cbKuliah.TabIndex = 11;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            this.cbKuliah.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(12, 401);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(50, 17);
            this.cbTidur.TabIndex = 12;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.UseVisualStyleBackColor = true;
            this.cbTidur.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbLiburan
            // 
            this.cbLiburan.AutoSize = true;
            this.cbLiburan.Location = new System.Drawing.Point(12, 424);
            this.cbLiburan.Name = "cbLiburan";
            this.cbLiburan.Size = new System.Drawing.Size(61, 17);
            this.cbLiburan.TabIndex = 13;
            this.cbLiburan.Text = "Liburan";
            this.cbLiburan.UseVisualStyleBackColor = true;
            this.cbLiburan.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(169, 418);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 23);
            this.bPrint.TabIndex = 14;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(269, 418);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 15;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(385, 466);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.cbLiburan);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbWeekend);
            this.Controls.Add(this.rbWeekday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bTutup);
            this.Controls.Add(this.bCek);
            this.Controls.Add(this.cbAngkatan);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Manchester United";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.ComboBox cbAngkatan;
        private System.Windows.Forms.Button bCek;
        private System.Windows.Forms.Button bTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbWeekday;
        private System.Windows.Forms.RadioButton rbWeekend;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.CheckBox cbLiburan;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bReset;
    }
}

