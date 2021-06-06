using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_3laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_b.Items.Add("-1.1");
            combo_b.Items.Add("11.1");
            combo_b.Items.Add("23.75");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double z = 0;
            float x = float.Parse(textBox_x.Text);
            
            
            double result = 0;


            switch (combo_b.SelectedIndex)
            {
                case 0: b = -1.1; break;
                case 1: b = 11.1; break;
                case 2: b = 23.75; break;

            }

            if (a1.Checked)
                a = -0.7;
            
            if (a2.Checked)
                a = -2.1;
            
            if (a_3.Checked)
                a = 2.2;
            


            if (z1.Checked == true)
            {
                z = Math.Exp(a);
            }
            if (z2.Checked == true)
            {
                double x2 = Math.Pow(x, 2);
                z = Math.Exp(b);
            }
            if (z3.Checked == true)
            {
                double ab = a * b;
                z = Math.Exp(ab);
            }

            if (x <= 5 * a)
            {
                double ax = x * a;
                double b2 = Math.Pow(b, 2);
                double xz = x * z;
                double cos1 = Math.Cos(xz);
                result = 2.5 * b2 + ax - 4.5 * cos1;
                result_label.Text = result.ToString();


            }

            if (x > b )
            {
                double a2 = Math.Pow(a, 2);
                double f = Math.Pow(a2 - 5.4 * x, 3);
                double xz = x * z;
                double ln = Math.Log(xz);
                result = f + ln;
                result_label.Text = result.ToString();

            }
            
            

            if (x <= b & x > 5 * a )
            {
                double b2 = Math.Pow(b, 2);
                double x3 = Math.Pow(x, 3);
                double x3z = x3 * z;
                double s = Math.Sqrt(6.5 * b2 + (a - x3z));

                result_label.Text = result.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
