﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.MouseEnter += (s, e) =>
            {
                label1.ForeColor = Color.Blue;
            };
            label1.MouseLeave += (s, e) =>
            {
                label1.ForeColor = Color.Black;
            };


            label2.MouseEnter += (s, e) =>
            {
                label2.ForeColor = Color.Blue;
            };
            label2.MouseLeave += (s, e) =>
            {
                label2.ForeColor = Color.Black;
            };


            label3.MouseEnter += (s, e) =>
            {
                label3.ForeColor = Color.Blue;
            };
            label3.MouseLeave += (s, e) =>
            {
                label3.ForeColor = Color.Black;
            };

            label4.MouseEnter += (s, e) =>
            {
                label4.ForeColor = Color.Blue;
            };

            label4.MouseLeave += (s, e) =>
            {
                label4.ForeColor = Color.Black;
            };


          
        }



        Form3 a = new Form3();
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.ShowDialog();
            this.Show();
            Close();
        }
        Form4 b = new Form4();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            b.ShowDialog();
            this.Show();
            Close();
        }
        Form7 c = new Form7();
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.ShowDialog();
            this.Show();
            Close();
        }
        Form8 d = new Form8();
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            d.ShowDialog();
            this.Show();
            Close();
        }
   

    }
}
