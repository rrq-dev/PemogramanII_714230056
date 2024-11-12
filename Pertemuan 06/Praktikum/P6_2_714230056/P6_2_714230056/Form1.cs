using System;
using System.Windows.Forms;

namespace P6_2_714230056
{
    public partial class Form1 : Form
    {
        private string filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult userResponse = openFileDialog1.ShowDialog();
                if (userResponse == DialogResult.OK)
                {
                    filepath = openFileDialog1.FileName;
                    MessageBox.Show("Kamu berhasil membuka : " + filepath, "Sukses boi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kamu membatalkan operasi membuka file.", "Warning",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error nih",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
