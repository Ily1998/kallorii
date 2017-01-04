using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.MouseEnter += (s, e) =>
            {
                 label5.ForeColor = Color.Blue;
            };
            label5.MouseLeave += (s, e) =>
            {
                label5.ForeColor = Color.Black;
            };
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
        }
        double s1 = 0;
        double s2 = 0;
        double s3 = 0;
        double s4 = 0;
        double s5 = 0;
        double s6 = 0;
        double s7 = 0;
        double s8 = 0;
        double s9 = 0;
        double s10 = 0;
        double s11 = 0;
        double s12 = 0;
        double s13 = 0;
        double s14 = 0;
        double s15 = 0;
        double s16 = 0;
        double s17 = 0;

        public static double sum(double s1, double s2, double s3, double s4, double s5, double s6, double s7, double s8, double s9, double s10, double s11, double s12, double s13, double s14, double s15, double s16, double s17)
        { return s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10 + s11 + s12 + s13 + s14 + s15 + s16 + s17; }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox18.Text = Convert.ToString(sum(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17));
        }

        Form2 a = new Form2();
        private void label5_Click(object sender, EventArgs e)
        {

            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text) * 0.64;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s2 = Convert.ToDouble(textBox2.Text) * 8.99;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text) * 1.74;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            s4 = Convert.ToDouble(textBox4.Text) * 2.97;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            s5 = Convert.ToDouble(textBox5.Text) * 3.28;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            s6 = Convert.ToDouble(textBox6.Text) * 3.43;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            s7 = Convert.ToDouble(textBox7.Text) * 3.33;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            s8 = Convert.ToDouble(textBox8.Text) * 0.28;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            s9 = Convert.ToDouble(textBox9.Text) * 0.73;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            s10 = Convert.ToDouble(textBox10.Text) * 0.19;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            s11 = Convert.ToDouble(textBox11.Text) * 0.47;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            s12 = Convert.ToDouble(textBox12.Text) * 0.47;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            s13 = Convert.ToDouble(textBox13.Text) * 0.47;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            s14 = Convert.ToDouble(textBox14.Text) * 0.34;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            s15 = Convert.ToDouble(textBox15.Text) * 1.87;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            s16 = Convert.ToDouble(textBox16.Text) * 1.9;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            s17 = Convert.ToDouble(textBox17.Text) * 2.57;
        }

    
         
        

    }
}
