﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_1_714230056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vButton_MouseMove(object sender, MouseEventArgs e)
        {
            vButton.Top = e.Y;
            vButton.Left = e.X;
            if (vButton.Top < -16 || vButton.Top > 160)
                vButton.Top = 73;
            if (vButton.Left < -64 || vButton.Left > 364)
                vButton.Left = 160;

        }

        private void csButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }
    }
}
