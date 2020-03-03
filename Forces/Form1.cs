using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare values from textboxes
            double Force, Angle;

            //Read values from textboxes
            try
            {
                Force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the Force Box, you doofus!");
                Force = 0.0;
            }

            Angle = double.Parse(textBox2.Text);

            // Parse means to read this text as a number
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);

            //Calculate Fx and Fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            //put values for Fx and Fy in labels
            label3.Text = "Fx = " + Fx + "N";
            label4.Text = "Fy = " + Fy + "N";
        }
    }
}
